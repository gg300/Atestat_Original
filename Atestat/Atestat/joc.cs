using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class joc : Form
    {
        private Form1 main = null;
        private List<Image> images = new List<Image>();
        private PictureBox pictureBox = null;
        private int imageIndex = 0;

        public joc(Form callingForm)
        {
            main = callingForm as Form1;
            InitializeComponent();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// display initial
        private void joc_Load(object sender, EventArgs e)
        {
            LoadImages(@"E:\github\C-\C-\Atestat\assets");
            pictureBox = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(1200, 600),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.Fixed3D,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(pictureBox);
        }

        private void LoadImages(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                images.Add(Image.FromFile(file));
            }
        }

        private void ShowPictureBox(Image image)
        {
            pictureBox.Image?.Dispose(); // Dispose the previous image
            pictureBox.Image = image;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageIndex < images.Count)
            {
                ShowPictureBox(images[imageIndex]);
                imageIndex++;
            }
            else
            {
                pictureBox.Dispose(); 
            }
        }
    }
}
