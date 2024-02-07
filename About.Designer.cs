namespace Melody
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label2 = new Label();
            websiteLinkLabel = new LinkLabel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(284, 154);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 35);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 295);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 2;
            label1.Text = "Created by";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "MELODY_ICO.ico");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 216);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 265);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 4;
            // 
            // websiteLinkLabel
            // 
            websiteLinkLabel.AutoSize = true;
            websiteLinkLabel.Location = new Point(192, 295);
            websiteLinkLabel.Name = "websiteLinkLabel";
            websiteLinkLabel.Size = new Size(71, 30);
            websiteLinkLabel.TabIndex = 5;
            websiteLinkLabel.TabStop = true;
            websiteLinkLabel.Text = "jmshtr";
            websiteLinkLabel.LinkClicked += websiteLinkLabel_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 231);
            label3.Name = "label3";
            label3.Size = new Size(82, 30);
            label3.TabIndex = 6;
            label3.Text = "Melody";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 336);
            Controls.Add(label3);
            Controls.Add(websiteLinkLabel);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "About";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label2;
        private LinkLabel websiteLinkLabel;
        private Label label3;
    }
}