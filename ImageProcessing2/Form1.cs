using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Imaging;

namespace ImageProcessing2
{
    public partial class Form1 : Form
    {
        private Bitmap image;
        private readonly object _imageLock = new object();


        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(openFileDialog.FileName);
                pictureBox.Image = image;
                RedrawCharts();
                robertsImage.Image = RobertsOperator();
                previtImage.Image = image.PrewittFilter();
                sobelImage.Image = image.Sobel3x3Filter();
            }
        }

        private void RedrawCharts()
        {
            var hslStatistics = new ImageStatisticsHSL(image);
            var luminanceValues = hslStatistics.Luminance.Values;
            var rgbStatistics = new ImageStatistics(image);
            var redValues = rgbStatistics.Red.Values;
            var greenValues = rgbStatistics.Green.Values;
            var blueValues = rgbStatistics.Blue.Values;
            luminanceChart.Series["Series1"].Points.Clear();
            redChart.Series["Series1"].Points.Clear();
            greenChart.Series["Series1"].Points.Clear();
            blueChart.Series["Series1"].Points.Clear();
            for (var i = 1; i < luminanceValues.Length; ++i)
            {
                luminanceChart.Series["Series1"].Points.AddY(luminanceValues[i]);
            }
            for (var i = 1; i < redValues.Length; ++i)
            {
                redChart.Series["Series1"].Points.AddY(redValues[i]);
            }
            for (var i = 1; i < greenValues.Length; ++i)
            {
                greenChart.Series["Series1"].Points.AddY(greenValues[i]);
            }
            for (var i = 1; i < blueValues.Length; ++i)
            {
                blueChart.Series["Series1"].Points.AddY(blueValues[i]);
            }
        }

        private static Bitmap Equalizing(Bitmap bmp)
        {
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var bmpData = bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);
            var ptr = bmpData.Scan0;
            var bytes = bmpData.Stride * bmp.Height;
            var grayValues = new byte[bytes];
            var R = new int[256];
            var N = new byte[256];
            var left = new byte[256];
            var right = new byte[256];
            System.Runtime.InteropServices.Marshal.Copy(ptr, grayValues, 0, bytes);
            foreach (var t in grayValues)
                ++R[t];

            var z = 0;
            var hint = 0;
            var havg = grayValues.Length / R.Length;
            for (var i = 0; i < N.Length - 1; i++)
            {
                N[i] = 0;
            }
            for (var j = 0; j < R.Length; j++)
            {
                if (z > 255) left[j] = 255;
                else left[j] = (byte)z;
                hint += R[j];
                while (hint > havg)
                {
                    hint -= havg;
                    z++;
                }
                if (z > 255) right[j] = 255;
                else right[j] = (byte)z;

                N[j] = (byte)((left[j] + right[j]) / 2);
            }
            for (var i = 0; i < grayValues.Length; i++)
            {
                if (left[grayValues[i]] == right[grayValues[i]]) grayValues[i] = left[grayValues[i]];
                else grayValues[i] = N[grayValues[i]];
            }

            System.Runtime.InteropServices.Marshal.Copy(grayValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
            return bmp;
        }

        private void EqualizeBtn_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Open an image first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            image = Equalizing(image);
            RedrawCharts();
            pictureBox.Image = image;
        }

        public Bitmap ToGrayScale()
        {
            var result = new Bitmap(image.Width, image.Height);

            lock (_imageLock)
            {
                unsafe
                {
                    var xData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                        ImageLockMode.ReadWrite,
                        PixelFormat.Format24bppRgb);

                    var resultData = result.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                        ImageLockMode.ReadWrite,
                        PixelFormat.Format24bppRgb);

                    var offset = xData.Stride - result.Width * 3;
                    var px = (byte*)xData.Scan0.ToPointer();
                    var presult = (byte*)resultData.Scan0.ToPointer();

                    for (var i = 0; i < image.Height; i++)
                    {
                        for (var j = 0; j < image.Width; j++)
                        {
                            var gray = (int)(0.2989 * px[2] + 0.5870 * px[1] + 0.1140 * px[0]);
                            presult[0] = presult[1] = presult[2] = (byte)gray;
                            px += 3;
                            presult += 3;
                        }
                        px += offset;
                        presult += offset;
                    }

                    image.UnlockBits(xData);
                    result.UnlockBits(resultData);
                }
               
            }

            return result;
        }

        public Bitmap RobertsOperator()
        {
            Bitmap result;
            var grayImg = ToGrayScale();
            lock (_imageLock)
            {
                unsafe
                {
                    result = new Bitmap(grayImg);
                    var data = result.LockBits(new Rectangle(0, 0, grayImg.Width, grayImg.Height),
                        ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                    var p = (byte*)data.Scan0.ToPointer();
                    var offset = data.Stride - result.Width * 3;

                    for (var i = 0; i < result.Height - 1; i++)
                    {
                        for (var j = 0; j < result.Width - 1; j++)
                        {
                            var Gx = (int)Math.Pow(p[0] - (p + 3 + data.Stride)[0], 2);
                            var Gy = (int)Math.Pow((p + 3)[0] - (p + data.Stride)[0], 2);

                            var f = Gx + Gy;
                            p[0] = p[1] = p[2] = (byte)f;

                            p += 3;
                        }

                        p += offset;
                    }

                    result.UnlockBits(data);
                }
            }

            return result;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RobertsImage_DoubleClick(object sender, EventArgs e)
        {
            new ImageForm(robertsImage.Image).Show();
        }

        private void PrevitImage_DoubleClick(object sender, EventArgs e)
        {
            new ImageForm(previtImage.Image).Show();
        }

        private void SobelImage_DoubleClick(object sender, EventArgs e)
        {
            new ImageForm(sobelImage.Image).Show();
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new ImageForm(pictureBox.Image).Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                MessageBox.Show("Open an image first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFileDialog.FileName);
            }
        }
    }
}
