using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageProcessing2
{
    public static class BitmapExtension
    {
        public static Bitmap ConvolutionFilter(this Bitmap sourceBitmap, double[,] xFilterMatrix,
            double[,] yFilterMatrix, double factor = 1, int bias = 0, bool grayscale = false)
        {
            var sourceData =
                sourceBitmap.LockBits(new Rectangle(0, 0,
                        sourceBitmap.Width, sourceBitmap.Height),
                    ImageLockMode.ReadOnly,
                    PixelFormat.Format32bppArgb);


            var pixelBuffer = new byte[sourceData.Stride *
                                       sourceData.Height];


            var resultBuffer = new byte[sourceData.Stride *
                                        sourceData.Height];


            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                pixelBuffer.Length);


            sourceBitmap.UnlockBits(sourceData);


            if (grayscale)
            {
                float rgb = 0;


                for (var k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;


                    pixelBuffer[k] = (byte) rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }


            var filterOffset = 1;


            for (var offsetY = filterOffset;
                offsetY <
                sourceBitmap.Height - filterOffset;
                offsetY++)
            {
                for (var offsetX = filterOffset;
                    offsetX <
                    sourceBitmap.Width - filterOffset;
                    offsetX++)
                {
                    var redX = 0.0;
                    var greenX = 0.0;
                    var blueX = greenX = redX = 0;
                    var greenY = 0.0;
                    var redY = 0.0;
                    var blueY = greenY = redY = 0;


                    var greenTotal = 0.0;
                    var redTotal = 0.0;
                    var blueTotal = greenTotal = redTotal = 0.0;


                    var byteOffset = offsetY *
                                     sourceData.Stride +
                                     offsetX * 4;


                    for (var filterY = -filterOffset;
                        filterY <= filterOffset;
                        filterY++)
                    {
                        for (var filterX = -filterOffset;
                            filterX <= filterOffset;
                            filterX++)
                        {
                            var calcOffset = byteOffset +
                                             (filterX * 4) +
                                             (filterY * sourceData.Stride);


                            blueX += (double)
                                     (pixelBuffer[calcOffset]) *
                                     xFilterMatrix[filterY +
                                                   filterOffset,
                                         filterX +
                                         filterOffset];


                            greenX += (double)
                                      (pixelBuffer[calcOffset + 1]) *
                                      xFilterMatrix[filterY +
                                                    filterOffset,
                                          filterX +
                                          filterOffset];


                            redX += (double)
                                    (pixelBuffer[calcOffset + 2]) *
                                    xFilterMatrix[filterY +
                                                  filterOffset,
                                        filterX +
                                        filterOffset];


                            blueY += (double)
                                     (pixelBuffer[calcOffset]) *
                                     yFilterMatrix[filterY +
                                                   filterOffset,
                                         filterX +
                                         filterOffset];


                            greenY += (double)
                                      (pixelBuffer[calcOffset + 1]) *
                                      yFilterMatrix[filterY +
                                                    filterOffset,
                                          filterX +
                                          filterOffset];


                            redY += (double)
                                    (pixelBuffer[calcOffset + 2]) *
                                    yFilterMatrix[filterY +
                                                  filterOffset,
                                        filterX +
                                        filterOffset];
                        }
                    }


                    blueTotal = Math.Sqrt((blueX * blueX) +
                                          (blueY * blueY));


                    greenTotal = Math.Sqrt((greenX * greenX) +
                                           (greenY * greenY));


                    redTotal = Math.Sqrt((redX * redX) +
                                         (redY * redY));


                    if (blueTotal > 255)
                    {
                        blueTotal = 255;
                    }
                    else if (blueTotal < 0)
                    {
                        blueTotal = 0;
                    }


                    if (greenTotal > 255)
                    {
                        greenTotal = 255;
                    }
                    else if (greenTotal < 0)
                    {
                        greenTotal = 0;
                    }


                    if (redTotal > 255)
                    {
                        redTotal = 255;
                    }
                    else if (redTotal < 0)
                    {
                        redTotal = 0;
                    }


                    resultBuffer[byteOffset] = (byte) (blueTotal);
                    resultBuffer[byteOffset + 1] = (byte) (greenTotal);
                    resultBuffer[byteOffset + 2] = (byte) (redTotal);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }


            var resultBitmap = new Bitmap(sourceBitmap.Width,
                sourceBitmap.Height);


            var resultData =
                resultBitmap.LockBits(new Rectangle(0, 0,
                        resultBitmap.Width, resultBitmap.Height),
                    ImageLockMode.WriteOnly,
                    PixelFormat.Format32bppArgb);


            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);


            return resultBitmap;
        }

        public static Bitmap PrewittFilter(this Bitmap sourceBitmap,
            bool grayscale = true)
        {
            Bitmap resultBitmap =
                ConvolutionFilter(sourceBitmap,
                    Matrix.Prewitt3x3Horizontal,
                    Matrix.Prewitt3x3Vertical,
                    1.0, 0, grayscale);


            return resultBitmap;
        }

        public static Bitmap
            Sobel3x3Filter(this Bitmap sourceBitmap,
                bool grayscale = true)
        {
            Bitmap resultBitmap =
                ConvolutionFilter(sourceBitmap,
                    Matrix.Sobel3x3Horizontal,
                    Matrix.Sobel3x3Vertical,
                    1.0, 0, grayscale);


            return resultBitmap;
        }
    }
}
