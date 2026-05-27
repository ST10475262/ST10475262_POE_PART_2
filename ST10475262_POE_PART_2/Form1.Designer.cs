namespace ST10475262_POE_PART_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelDisplay = new FlowLayoutPanel();
            txtInput = new TextBox();
            btnSend = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelDisplay
            // 
            panelDisplay.Location = new Point(12, 188);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(1078, 400);
            panelDisplay.TabIndex = 0;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 614);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(861, 27);
            txtInput.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(932, 604);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(130, 47);
            btnSend.TabIndex = 2;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(189, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 170);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(475, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(378, 170);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 673);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(panelDisplay);
            Name = "Form1";
            Text = "CYPHERR BOT";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel panelDisplay;
        private TextBox txtInput;
        private Button btnSend;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
