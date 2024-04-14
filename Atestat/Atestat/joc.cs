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
            LoadImages(@"D:\gitrepo\Atestat\Atestat\assets");
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
        ///
        public class RefString
        {
            public string Value { get; set; }
        }
        public void ShowPicturesInForm(string folderPath, RefString file2)
        {
            // Create a new form
            Form form = new Form();

            // Get all files in the specified folder
            string[] files = Directory.GetFiles(folderPath);

            // Shuffle the array of files
            Random rng = new Random();
            files = files.OrderBy(file => rng.Next()).ToArray(); // Changed variable name here

            // Initialize the location for the next PictureBox
            int x = 10;
            int y = 10;

            // Loop through each file
            foreach (string file in files)
            {
                // Get the file extension
                string extension = Path.GetExtension(file).ToLower();

                // Check if the file is a picture
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp")
                {
                    // Create a new PictureBox
                    PictureBox pictureBox = new PictureBox
                    {
                        ImageLocation = file,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new System.Drawing.Size(100, 100),
                        Location = new System.Drawing.Point(x, y)
                    };

                    // Add a click event handler
                    pictureBox.Click += (sender, e) =>
                    {
                        file2.Value = file;
                    };

                    // Add the PictureBox to the form
                    form.Controls.Add(pictureBox);

                    // Update the location for the next PictureBox
                    x += 110;
                    if (x + 110 > form.Width)
                    {
                        x = 10;
                        y += 110;
                    }
                }
            }

            // Show the form
            form.ShowDialog();
        }

        bool ok = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imageIndex < images.Count)
            {
                ShowPictureBox(images[imageIndex]);
                imageIndex++;
            }
            else
            {
                RefString file2 = new RefString();
                pictureBox.Dispose();
                timer1.Enabled = false;
                ShowPicturesInForm(@"D:\gitrepo\Atestat\Atestat\assets", file2);
                Console.WriteLine(file2.Value);
            }
        }
    }
}
