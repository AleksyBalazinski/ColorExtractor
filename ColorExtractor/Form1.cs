using System.Diagnostics;

namespace ColorExtractor
{
    public partial class Form1 : Form
    {
        Bitmap? mainImageBitmap;
        readonly Bitmap bitmap1;
        readonly Bitmap bitmap2;
        readonly Bitmap bitmap3;
        public Form1()
        {
            InitializeComponent();
            //mainImageBitmap = new(pictureBoxMainImage.Width, pictureBoxMainImage.Height);
            bitmap1 = new(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap1;
            bitmap2 = new(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = bitmap2;
            bitmap3 = new(pictureBox3.Width, pictureBox3.Height);
            pictureBox3.Image = bitmap3;

            labelRes1.Visible = false;
            labelRes2.Visible = false;
            labelRes3.Visible = false;
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Filter = "Image files (.jpg, .png)|*.jpg;*.png"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mainImageBitmap = new(ofd.FileName);
                pictureBoxMainImage.Image = mainImageBitmap;
                var imageSize = pictureBoxMainImage.Image.Size;
                var fitSize = pictureBoxMainImage.ClientSize;
                pictureBoxMainImage.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
            }
        }

        private void buttonSeparateChannels_Click(object sender, EventArgs e)
        {
            if (mainImageBitmap == null)
                return;
            if (comboBoxMethod.SelectedIndex == 0) // YCaCb
            {
                labelRes1.Visible = true; labelRes1.Text = "Y";
                labelRes2.Visible = true; labelRes2.Text = "Cb";
                labelRes3.Visible = true; labelRes3.Text = "Cr";

                Painter.Paint(mainImageBitmap, bitmap1, bitmap2, bitmap3, new YCbCrSeparator(), 
                    pictureBoxMainImage.Image.Size.Height, pictureBoxMainImage.Image.Size.Width,
                    checkBoxGrayScale.Checked == true ? PresentationMode.GrayScale : PresentationMode.Color);
                pictureBox1.Invalidate();
                pictureBox2.Invalidate();
                pictureBox3.Invalidate();
            }
            if (comboBoxMethod.SelectedIndex == 1) // HSV
            {
                labelRes1.Visible = true; labelRes1.Text = "H";
                labelRes2.Visible = true; labelRes2.Text = "S";
                labelRes3.Visible = true; labelRes3.Text = "V";

                Painter.Paint(mainImageBitmap, bitmap1, bitmap2, bitmap3, new HSVSeparator(), 
                    pictureBoxMainImage.Image.Size.Height, pictureBoxMainImage.Image.Size.Width,
                    checkBoxGrayScale.Checked == true ? PresentationMode.GrayScale : PresentationMode.Color);
                pictureBox1.Invalidate();
                pictureBox2.Invalidate();
                pictureBox3.Invalidate();
            }

            if (comboBoxMethod.SelectedIndex == 2) // Lab
            {
                labelRes1.Visible = true; labelRes1.Text = "L";
                labelRes2.Visible = true; labelRes2.Text = "a";
                labelRes3.Visible = true; labelRes3.Text = "b";

                double redPrimaryX = decimal.ToDouble(numericUpDownRedX.Value);
                double redPrimaryY = decimal.ToDouble(numericUpDownRedY.Value);
                double greenPrimaryX = decimal.ToDouble(numericUpDownGreenX.Value);
                double greenPrimaryY = decimal.ToDouble(numericUpDownGreenY.Value);
                double bluePrimaryX = decimal.ToDouble(numericUpDownBlueX.Value);
                double bluePrimaryY = decimal.ToDouble(numericUpDownBlueY.Value);
                double whitePointX = decimal.ToDouble(numericUpDownWhiteX.Value);
                double whitePointY = decimal.ToDouble(numericUpDownWhiteY.Value);
                double gamma = decimal.ToDouble(numericUpDownGamma.Value);

                RGBColorSpace colorSpace = new(redPrimaryX, redPrimaryY,
                    greenPrimaryX, greenPrimaryY,
                    bluePrimaryX, bluePrimaryY,
                    whitePointX, whitePointY,
                    gamma);

                Painter.Paint(mainImageBitmap, bitmap1, bitmap2, bitmap3, new LabSeparator(colorSpace),
                    pictureBoxMainImage.Image.Size.Height, pictureBoxMainImage.Image.Size.Width,
                    checkBoxGrayScale.Checked == true ? PresentationMode.GrayScale : PresentationMode.Color);
                pictureBox1.Invalidate();
                pictureBox2.Invalidate();
                pictureBox3.Invalidate();

            }
        }

        private void comboBoxColorProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColorProfile.SelectedIndex == 0) // sRGB
            {
                DisableNumericInput();

                numericUpDownRedX.Value = Convert.ToDecimal(0.64);
                numericUpDownRedY.Value = Convert.ToDecimal(0.33);
                numericUpDownGreenX.Value = Convert.ToDecimal(0.30);
                numericUpDownGreenY.Value = Convert.ToDecimal(0.60);
                numericUpDownBlueX.Value = Convert.ToDecimal(0.15);
                numericUpDownBlueY.Value = Convert.ToDecimal(0.06);
                numericUpDownWhiteX.Value = Convert.ToDecimal(0.31271); // D65
                numericUpDownWhiteY.Value = Convert.ToDecimal(0.32902);
                numericUpDownGamma.Value = Convert.ToDecimal(2.2);

                comboBoxIlluminant.SelectedIndex = 0;
            }
            if(comboBoxColorProfile.SelectedIndex == 1) // Adobe RGB
            {
                DisableNumericInput();

                numericUpDownRedX.Value = Convert.ToDecimal(0.64);
                numericUpDownRedY.Value = Convert.ToDecimal(0.33);
                numericUpDownGreenX.Value = Convert.ToDecimal(0.21);
                numericUpDownGreenY.Value = Convert.ToDecimal(0.71);
                numericUpDownBlueX.Value = Convert.ToDecimal(0.15);
                numericUpDownBlueY.Value = Convert.ToDecimal(0.06);
                numericUpDownWhiteX.Value = Convert.ToDecimal(0.31271); // D65
                numericUpDownWhiteY.Value = Convert.ToDecimal(0.32902);
                numericUpDownGamma.Value = Convert.ToDecimal(2.2);

                comboBoxIlluminant.SelectedIndex = 0;
            }
            if (comboBoxColorProfile.SelectedIndex == 2) // Apple RGB
            {
                DisableNumericInput();

                numericUpDownRedX.Value = Convert.ToDecimal(0.625);
                numericUpDownRedY.Value = Convert.ToDecimal(0.34);
                numericUpDownGreenX.Value = Convert.ToDecimal(0.28);
                numericUpDownGreenY.Value = Convert.ToDecimal(0.595);
                numericUpDownBlueX.Value = Convert.ToDecimal(0.155);
                numericUpDownBlueY.Value = Convert.ToDecimal(0.07);
                numericUpDownWhiteX.Value = Convert.ToDecimal(0.31271); // D65
                numericUpDownWhiteY.Value = Convert.ToDecimal(0.32902);
                numericUpDownGamma.Value = Convert.ToDecimal(1.8);

                comboBoxIlluminant.SelectedIndex = 0;
            }
            if (comboBoxColorProfile.SelectedIndex == 3) // CIE RGB
            {
                DisableNumericInput();

                numericUpDownRedX.Value = Convert.ToDecimal(0.7347);
                numericUpDownRedY.Value = Convert.ToDecimal(0.2653);
                numericUpDownGreenX.Value = Convert.ToDecimal(0.2738);
                numericUpDownGreenY.Value = Convert.ToDecimal(0.7174);
                numericUpDownBlueX.Value = Convert.ToDecimal(0.1666);
                numericUpDownBlueY.Value = Convert.ToDecimal(0.0089);
                numericUpDownWhiteX.Value = Convert.ToDecimal(0.33333); // E
                numericUpDownWhiteY.Value = Convert.ToDecimal(0.33333);
                numericUpDownGamma.Value = Convert.ToDecimal(1);

                comboBoxIlluminant.SelectedIndex = 2;
            }
            if (comboBoxColorProfile.SelectedIndex == 4) // Wide Gamut
            {
                DisableNumericInput();

                numericUpDownRedX.Value = Convert.ToDecimal(0.7347);
                numericUpDownRedY.Value = Convert.ToDecimal(0.2653);
                numericUpDownGreenX.Value = Convert.ToDecimal(0.1152);
                numericUpDownGreenY.Value = Convert.ToDecimal(0.8264);
                numericUpDownBlueX.Value = Convert.ToDecimal(0.1566);
                numericUpDownBlueY.Value = Convert.ToDecimal(0.0177);
                numericUpDownWhiteX.Value = Convert.ToDecimal(0.34567); // D50
                numericUpDownWhiteY.Value = Convert.ToDecimal(0.35850);
                numericUpDownGamma.Value = Convert.ToDecimal(1.2);

                comboBoxIlluminant.SelectedIndex = 1;
            }
        }
        private void DisableNumericInput()
        {
            numericUpDownRedX.Enabled = false;
            numericUpDownRedY.Enabled = false;
            numericUpDownGreenX.Enabled = false;
            numericUpDownGreenY.Enabled = false;
            numericUpDownBlueX.Enabled = false;
            numericUpDownBlueY.Enabled = false;
            numericUpDownWhiteX.Enabled = false;
            numericUpDownWhiteY.Enabled = false;
            numericUpDownGamma.Enabled = false;

            comboBoxIlluminant.Enabled = false;
        }

        private void comboBoxIlluminant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxIlluminant.SelectedIndex == 0) // D65
            {
                numericUpDownWhiteX.Value = Convert.ToDecimal(0.31271); // D65
                numericUpDownWhiteY.Value = Convert.ToDecimal(0.32902);

                numericUpDownWhiteX.Enabled = false;
                numericUpDownWhiteY.Enabled = false;
            }
            if(comboBoxIlluminant.SelectedIndex == 1) // D50
            {
                numericUpDownWhiteX.Value = Convert.ToDecimal(0.34567); // D50
                numericUpDownWhiteY.Value = Convert.ToDecimal(0.35850);

                numericUpDownWhiteX.Enabled = false;
                numericUpDownWhiteY.Enabled = false;
            }
            if(comboBoxIlluminant.SelectedIndex == 2) // E
            {
                numericUpDownWhiteX.Value = Convert.ToDecimal(0.33333); // E
                numericUpDownWhiteY.Value = Convert.ToDecimal(0.33333);

                numericUpDownWhiteX.Enabled = false;
                numericUpDownWhiteY.Enabled = false;
            }
        }
    }
}