namespace raster_algs.Task2
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chooseBorderColorBtn = new System.Windows.Forms.Button();
            this.borderColorPan = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSelectBorder = new System.Windows.Forms.RadioButton();
            this.radioPen = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chooseHighlightColorBtn = new System.Windows.Forms.Button();
            this.highlightColorPan = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(9, 390);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(154, 36);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chooseHighlightColorBtn);
            this.groupBox2.Controls.Add(this.highlightColorPan);
            this.groupBox2.Controls.Add(this.chooseBorderColorBtn);
            this.groupBox2.Controls.Add(this.borderColorPan);
            this.groupBox2.Location = new System.Drawing.Point(9, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 87);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // chooseBorderColorBtn
            // 
            this.chooseBorderColorBtn.Location = new System.Drawing.Point(5, 18);
            this.chooseBorderColorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.chooseBorderColorBtn.Name = "chooseBorderColorBtn";
            this.chooseBorderColorBtn.Size = new System.Drawing.Size(109, 26);
            this.chooseBorderColorBtn.TabIndex = 12;
            this.chooseBorderColorBtn.Text = "Цвет границы";
            this.chooseBorderColorBtn.UseVisualStyleBackColor = true;
            this.chooseBorderColorBtn.Click += new System.EventHandler(this.chooseBorderColorBtn_Click);
            // 
            // borderColorPan
            // 
            this.borderColorPan.BackColor = System.Drawing.Color.Black;
            this.borderColorPan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.borderColorPan.Location = new System.Drawing.Point(119, 18);
            this.borderColorPan.Name = "borderColorPan";
            this.borderColorPan.Size = new System.Drawing.Size(26, 26);
            this.borderColorPan.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSelectBorder);
            this.groupBox1.Controls.Add(this.radioPen);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 69);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // radioSelectBorder
            // 
            this.radioSelectBorder.AutoSize = true;
            this.radioSelectBorder.Location = new System.Drawing.Point(5, 42);
            this.radioSelectBorder.Name = "radioSelectBorder";
            this.radioSelectBorder.Size = new System.Drawing.Size(134, 17);
            this.radioSelectBorder.TabIndex = 11;
            this.radioSelectBorder.TabStop = true;
            this.radioSelectBorder.Text = "Выделение границы";
            this.radioSelectBorder.UseVisualStyleBackColor = true;
            this.radioSelectBorder.CheckedChanged += new System.EventHandler(this.radioSelectBorder_CheckedChanged);
            // 
            // radioPen
            // 
            this.radioPen.AutoSize = true;
            this.radioPen.Location = new System.Drawing.Point(6, 19);
            this.radioPen.Name = "radioPen";
            this.radioPen.Size = new System.Drawing.Size(78, 17);
            this.radioPen.TabIndex = 8;
            this.radioPen.Text = "Карандаш";
            this.radioPen.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(169, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 414);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // chooseHighlightColorBtn
            // 
            this.chooseHighlightColorBtn.Location = new System.Drawing.Point(5, 48);
            this.chooseHighlightColorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.chooseHighlightColorBtn.Name = "chooseHighlightColorBtn";
            this.chooseHighlightColorBtn.Size = new System.Drawing.Size(109, 26);
            this.chooseHighlightColorBtn.TabIndex = 14;
            this.chooseHighlightColorBtn.Text = "Цвет выделения";
            this.chooseHighlightColorBtn.UseVisualStyleBackColor = true;
            this.chooseHighlightColorBtn.Click += new System.EventHandler(this.chooseHighlightColorBtn_Click);
            // 
            // highlightColorPan
            // 
            this.highlightColorPan.BackColor = System.Drawing.Color.Black;
            this.highlightColorPan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.highlightColorPan.Location = new System.Drawing.Point(119, 48);
            this.highlightColorPan.Name = "highlightColorPan";
            this.highlightColorPan.Size = new System.Drawing.Size(26, 26);
            this.highlightColorPan.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button chooseBorderColorBtn;
        private System.Windows.Forms.Panel borderColorPan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSelectBorder;
        private System.Windows.Forms.RadioButton radioPen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button chooseHighlightColorBtn;
        private System.Windows.Forms.Panel highlightColorPan;
    }
}