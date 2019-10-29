using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessing2
{
    public partial class ImageForm : Form
    {
        public ImageForm(Image image)
        {
            InitializeComponent();
            pictureBox.Image = image;
        }
    }
}
