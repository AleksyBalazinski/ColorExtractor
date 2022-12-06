namespace ColorExtractor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contolsPanel = new System.Windows.Forms.Panel();
            this.trackBarV = new System.Windows.Forms.TrackBar();
            this.buttonGenerateHSV = new System.Windows.Forms.Button();
            this.checkBoxGrayScale = new System.Windows.Forms.CheckBox();
            this.buttonSeparateChannels = new System.Windows.Forms.Button();
            this.groupBoxLabSettings = new System.Windows.Forms.GroupBox();
            this.comboBoxIlluminant = new System.Windows.Forms.ComboBox();
            this.comboBoxColorProfile = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownGamma = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWhiteY = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownBlueX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreenX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreenY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlueY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWhiteX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRedY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRedX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.mainImagePanel = new System.Windows.Forms.Panel();
            this.pictureBoxMainImage = new System.Windows.Forms.PictureBox();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.labelRes3 = new System.Windows.Forms.Label();
            this.labelRes2 = new System.Windows.Forms.Label();
            this.labelRes1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).BeginInit();
            this.groupBoxLabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWhiteY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlueX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreenX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreenY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlueY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWhiteX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRedX)).BeginInit();
            this.mainImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).BeginInit();
            this.resultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contolsPanel
            // 
            this.contolsPanel.Controls.Add(this.trackBarV);
            this.contolsPanel.Controls.Add(this.buttonGenerateHSV);
            this.contolsPanel.Controls.Add(this.checkBoxGrayScale);
            this.contolsPanel.Controls.Add(this.buttonSeparateChannels);
            this.contolsPanel.Controls.Add(this.groupBoxLabSettings);
            this.contolsPanel.Controls.Add(this.comboBoxMethod);
            this.contolsPanel.Controls.Add(this.buttonLoadImage);
            this.contolsPanel.Location = new System.Drawing.Point(-3, 3);
            this.contolsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contolsPanel.Name = "contolsPanel";
            this.contolsPanel.Size = new System.Drawing.Size(270, 727);
            this.contolsPanel.TabIndex = 0;
            // 
            // trackBarV
            // 
            this.trackBarV.Location = new System.Drawing.Point(141, 49);
            this.trackBarV.Name = "trackBarV";
            this.trackBarV.Size = new System.Drawing.Size(125, 56);
            this.trackBarV.TabIndex = 6;
            this.trackBarV.Scroll += new System.EventHandler(this.trackBarV_Scroll);
            // 
            // buttonGenerateHSV
            // 
            this.buttonGenerateHSV.Location = new System.Drawing.Point(154, 8);
            this.buttonGenerateHSV.Name = "buttonGenerateHSV";
            this.buttonGenerateHSV.Size = new System.Drawing.Size(97, 35);
            this.buttonGenerateHSV.TabIndex = 5;
            this.buttonGenerateHSV.Text = "Generate";
            this.buttonGenerateHSV.UseVisualStyleBackColor = true;
            this.buttonGenerateHSV.Click += new System.EventHandler(this.buttonGenerateHSV_Click);
            // 
            // checkBoxGrayScale
            // 
            this.checkBoxGrayScale.AutoSize = true;
            this.checkBoxGrayScale.Location = new System.Drawing.Point(161, 168);
            this.checkBoxGrayScale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxGrayScale.Name = "checkBoxGrayScale";
            this.checkBoxGrayScale.Size = new System.Drawing.Size(93, 24);
            this.checkBoxGrayScale.TabIndex = 4;
            this.checkBoxGrayScale.Text = "grayscale";
            this.checkBoxGrayScale.UseVisualStyleBackColor = true;
            // 
            // buttonSeparateChannels
            // 
            this.buttonSeparateChannels.Location = new System.Drawing.Point(160, 112);
            this.buttonSeparateChannels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSeparateChannels.Name = "buttonSeparateChannels";
            this.buttonSeparateChannels.Size = new System.Drawing.Size(91, 56);
            this.buttonSeparateChannels.TabIndex = 3;
            this.buttonSeparateChannels.Text = "separate channels";
            this.buttonSeparateChannels.UseVisualStyleBackColor = true;
            this.buttonSeparateChannels.Click += new System.EventHandler(this.buttonSeparateChannels_Click);
            // 
            // groupBoxLabSettings
            // 
            this.groupBoxLabSettings.Controls.Add(this.comboBoxIlluminant);
            this.groupBoxLabSettings.Controls.Add(this.comboBoxColorProfile);
            this.groupBoxLabSettings.Controls.Add(this.label10);
            this.groupBoxLabSettings.Controls.Add(this.label9);
            this.groupBoxLabSettings.Controls.Add(this.numericUpDownGamma);
            this.groupBoxLabSettings.Controls.Add(this.numericUpDownWhiteY);
            this.groupBoxLabSettings.Controls.Add(this.label8);
            this.groupBoxLabSettings.Controls.Add(this.numericUpDownBlueX);
            this.groupBoxLabSettings.Controls.Add(this.numericUpDownGreenX);
            this.groupBoxLabSettings.Controls.Add(this.numericUpDownGreenY);
            this.groupBoxLabSettings.Controls.Add(this.numericUpDownBlueY);
            this.groupBoxLabSettings.Controls.Add(this.numericUpDownWhiteX);
            this.groupBoxLabSettings.Controls.Add(this.numericUpDownRedY);
            this.groupBoxLabSettings.Controls.Add(this.numericUpDownRedX);
            this.groupBoxLabSettings.Controls.Add(this.label7);
            this.groupBoxLabSettings.Controls.Add(this.label6);
            this.groupBoxLabSettings.Controls.Add(this.label5);
            this.groupBoxLabSettings.Controls.Add(this.label4);
            this.groupBoxLabSettings.Controls.Add(this.label3);
            this.groupBoxLabSettings.Controls.Add(this.label2);
            this.groupBoxLabSettings.Controls.Add(this.label1);
            this.groupBoxLabSettings.Location = new System.Drawing.Point(3, 185);
            this.groupBoxLabSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLabSettings.Name = "groupBoxLabSettings";
            this.groupBoxLabSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLabSettings.Size = new System.Drawing.Size(263, 428);
            this.groupBoxLabSettings.TabIndex = 2;
            this.groupBoxLabSettings.TabStop = false;
            this.groupBoxLabSettings.Text = "Lab settings";
            // 
            // comboBoxIlluminant
            // 
            this.comboBoxIlluminant.FormattingEnabled = true;
            this.comboBoxIlluminant.Items.AddRange(new object[] {
            "D65",
            "D50",
            "E"});
            this.comboBoxIlluminant.Location = new System.Drawing.Point(159, 89);
            this.comboBoxIlluminant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxIlluminant.Name = "comboBoxIlluminant";
            this.comboBoxIlluminant.Size = new System.Drawing.Size(89, 28);
            this.comboBoxIlluminant.TabIndex = 20;
            this.comboBoxIlluminant.Text = "N/A";
            this.comboBoxIlluminant.SelectedIndexChanged += new System.EventHandler(this.comboBoxIlluminant_SelectedIndexChanged);
            // 
            // comboBoxColorProfile
            // 
            this.comboBoxColorProfile.FormattingEnabled = true;
            this.comboBoxColorProfile.Items.AddRange(new object[] {
            "sRGB",
            "Adobe RGB",
            "Apple RGB",
            "CIE RGB",
            "Wide Gamut"});
            this.comboBoxColorProfile.Location = new System.Drawing.Point(159, 44);
            this.comboBoxColorProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxColorProfile.Name = "comboBoxColorProfile";
            this.comboBoxColorProfile.Size = new System.Drawing.Size(89, 28);
            this.comboBoxColorProfile.TabIndex = 19;
            this.comboBoxColorProfile.Text = "N/A";
            this.comboBoxColorProfile.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorProfile_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Predefined illuminant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Predefined color profile";
            // 
            // numericUpDownGamma
            // 
            this.numericUpDownGamma.DecimalPlaces = 3;
            this.numericUpDownGamma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownGamma.Location = new System.Drawing.Point(102, 373);
            this.numericUpDownGamma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownGamma.Name = "numericUpDownGamma";
            this.numericUpDownGamma.Size = new System.Drawing.Size(71, 27);
            this.numericUpDownGamma.TabIndex = 16;
            // 
            // numericUpDownWhiteY
            // 
            this.numericUpDownWhiteY.DecimalPlaces = 5;
            this.numericUpDownWhiteY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWhiteY.Location = new System.Drawing.Point(184, 323);
            this.numericUpDownWhiteY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownWhiteY.Name = "numericUpDownWhiteY";
            this.numericUpDownWhiteY.Size = new System.Drawing.Size(71, 27);
            this.numericUpDownWhiteY.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gamma";
            // 
            // numericUpDownBlueX
            // 
            this.numericUpDownBlueX.DecimalPlaces = 5;
            this.numericUpDownBlueX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownBlueX.Location = new System.Drawing.Point(103, 275);
            this.numericUpDownBlueX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownBlueX.Name = "numericUpDownBlueX";
            this.numericUpDownBlueX.Size = new System.Drawing.Size(70, 27);
            this.numericUpDownBlueX.TabIndex = 14;
            // 
            // numericUpDownGreenX
            // 
            this.numericUpDownGreenX.DecimalPlaces = 5;
            this.numericUpDownGreenX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownGreenX.Location = new System.Drawing.Point(103, 229);
            this.numericUpDownGreenX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownGreenX.Name = "numericUpDownGreenX";
            this.numericUpDownGreenX.Size = new System.Drawing.Size(70, 27);
            this.numericUpDownGreenX.TabIndex = 13;
            // 
            // numericUpDownGreenY
            // 
            this.numericUpDownGreenY.DecimalPlaces = 5;
            this.numericUpDownGreenY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownGreenY.Location = new System.Drawing.Point(186, 229);
            this.numericUpDownGreenY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownGreenY.Name = "numericUpDownGreenY";
            this.numericUpDownGreenY.Size = new System.Drawing.Size(69, 27);
            this.numericUpDownGreenY.TabIndex = 12;
            // 
            // numericUpDownBlueY
            // 
            this.numericUpDownBlueY.DecimalPlaces = 5;
            this.numericUpDownBlueY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownBlueY.Location = new System.Drawing.Point(186, 275);
            this.numericUpDownBlueY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownBlueY.Name = "numericUpDownBlueY";
            this.numericUpDownBlueY.Size = new System.Drawing.Size(69, 27);
            this.numericUpDownBlueY.TabIndex = 11;
            // 
            // numericUpDownWhiteX
            // 
            this.numericUpDownWhiteX.DecimalPlaces = 5;
            this.numericUpDownWhiteX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWhiteX.Location = new System.Drawing.Point(103, 323);
            this.numericUpDownWhiteX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownWhiteX.Name = "numericUpDownWhiteX";
            this.numericUpDownWhiteX.Size = new System.Drawing.Size(70, 27);
            this.numericUpDownWhiteX.TabIndex = 10;
            // 
            // numericUpDownRedY
            // 
            this.numericUpDownRedY.DecimalPlaces = 5;
            this.numericUpDownRedY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownRedY.Location = new System.Drawing.Point(184, 187);
            this.numericUpDownRedY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRedY.Name = "numericUpDownRedY";
            this.numericUpDownRedY.Size = new System.Drawing.Size(71, 27);
            this.numericUpDownRedY.TabIndex = 8;
            // 
            // numericUpDownRedX
            // 
            this.numericUpDownRedX.DecimalPlaces = 5;
            this.numericUpDownRedX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownRedX.Location = new System.Drawing.Point(103, 187);
            this.numericUpDownRedX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRedX.Name = "numericUpDownRedX";
            this.numericUpDownRedX.Size = new System.Drawing.Size(71, 27);
            this.numericUpDownRedX.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "White point";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Blue primary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Green primary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Red primary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chromacity";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "YCbCr",
            "HSV",
            "Lab"});
            this.comboBoxMethod.Location = new System.Drawing.Point(14, 109);
            this.comboBoxMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(124, 28);
            this.comboBoxMethod.TabIndex = 1;
            this.comboBoxMethod.Text = "Select method";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(10, 13);
            this.buttonLoadImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(125, 60);
            this.buttonLoadImage.TabIndex = 0;
            this.buttonLoadImage.Text = "Load image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // mainImagePanel
            // 
            this.mainImagePanel.Controls.Add(this.pictureBoxMainImage);
            this.mainImagePanel.Location = new System.Drawing.Point(273, 3);
            this.mainImagePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainImagePanel.Name = "mainImagePanel";
            this.mainImagePanel.Size = new System.Drawing.Size(722, 421);
            this.mainImagePanel.TabIndex = 1;
            // 
            // pictureBoxMainImage
            // 
            this.pictureBoxMainImage.Location = new System.Drawing.Point(0, 8);
            this.pictureBoxMainImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxMainImage.Name = "pictureBoxMainImage";
            this.pictureBoxMainImage.Size = new System.Drawing.Size(343, 400);
            this.pictureBoxMainImage.TabIndex = 0;
            this.pictureBoxMainImage.TabStop = false;
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.labelRes3);
            this.resultsPanel.Controls.Add(this.labelRes2);
            this.resultsPanel.Controls.Add(this.labelRes1);
            this.resultsPanel.Controls.Add(this.pictureBox3);
            this.resultsPanel.Controls.Add(this.pictureBox2);
            this.resultsPanel.Controls.Add(this.pictureBox1);
            this.resultsPanel.Location = new System.Drawing.Point(273, 432);
            this.resultsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(722, 313);
            this.resultsPanel.TabIndex = 2;
            // 
            // labelRes3
            // 
            this.labelRes3.AutoSize = true;
            this.labelRes3.Location = new System.Drawing.Point(471, 5);
            this.labelRes3.Name = "labelRes3";
            this.labelRes3.Size = new System.Drawing.Size(73, 20);
            this.labelRes3.TabIndex = 5;
            this.labelRes3.Text = "labelRes3";
            // 
            // labelRes2
            // 
            this.labelRes2.AutoSize = true;
            this.labelRes2.Location = new System.Drawing.Point(235, 7);
            this.labelRes2.Name = "labelRes2";
            this.labelRes2.Size = new System.Drawing.Size(73, 20);
            this.labelRes2.TabIndex = 4;
            this.labelRes2.Text = "labelRes2";
            // 
            // labelRes1
            // 
            this.labelRes1.AutoSize = true;
            this.labelRes1.Location = new System.Drawing.Point(3, 5);
            this.labelRes1.Name = "labelRes1";
            this.labelRes1.Size = new System.Drawing.Size(73, 20);
            this.labelRes1.TabIndex = 3;
            this.labelRes1.Text = "labelRes1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(471, 31);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(229, 267);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(235, 31);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 267);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 267);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 737);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.mainImagePanel);
            this.Controls.Add(this.contolsPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1015, 784);
            this.MinimumSize = new System.Drawing.Size(1015, 784);
            this.Name = "Form1";
            this.Text = "Color Extractor";
            this.contolsPanel.ResumeLayout(false);
            this.contolsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).EndInit();
            this.groupBoxLabSettings.ResumeLayout(false);
            this.groupBoxLabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWhiteY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlueX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreenX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreenY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlueY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWhiteX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRedX)).EndInit();
            this.mainImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).EndInit();
            this.resultsPanel.ResumeLayout(false);
            this.resultsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel contolsPanel;
        private Button buttonLoadImage;
        private Panel mainImagePanel;
        private Panel resultsPanel;
        private PictureBox pictureBoxMainImage;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBoxMethod;
        private GroupBox groupBoxLabSettings;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownBlueX;
        private NumericUpDown numericUpDownGreenX;
        private NumericUpDown numericUpDownGreenY;
        private NumericUpDown numericUpDownBlueY;
        private NumericUpDown numericUpDownWhiteX;
        private NumericUpDown numericUpDownWhiteY;
        private NumericUpDown numericUpDownRedY;
        private NumericUpDown numericUpDownRedX;
        private NumericUpDown numericUpDownGamma;
        private Label label8;
        private ComboBox comboBoxIlluminant;
        private ComboBox comboBoxColorProfile;
        private Label label10;
        private Label label9;
        private Button buttonSeparateChannels;
        private CheckBox checkBoxGrayScale;
        private Label labelRes3;
        private Label labelRes2;
        private Label labelRes1;
        private Button buttonGenerateHSV;
        private TrackBar trackBarV;
    }
}