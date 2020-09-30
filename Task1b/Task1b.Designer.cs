namespace raster_algs.Task1b
{
    partial class Task1b
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
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.imageToFillBox = new System.Windows.Forms.PictureBox();
            this.actionGroupBox = new System.Windows.Forms.GroupBox();
            this.drawRadioButton = new System.Windows.Forms.RadioButton();
            this.fillRadioButton = new System.Windows.Forms.RadioButton();
            this.imageToDrawBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageToFillBox)).BeginInit();
            this.actionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageToDrawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(11, 11);
            this.chooseFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(89, 34);
            this.chooseFileButton.TabIndex = 1;
            this.chooseFileButton.Text = "Выбрать файл";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // imageToFillBox
            // 
            this.imageToFillBox.Location = new System.Drawing.Point(1, 66);
            this.imageToFillBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageToFillBox.Name = "imageToFillBox";
            this.imageToFillBox.Size = new System.Drawing.Size(143, 112);
            this.imageToFillBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageToFillBox.TabIndex = 4;
            this.imageToFillBox.TabStop = false;
            this.imageToFillBox.Visible = false;
            // 
            // actionGroupBox
            // 
            this.actionGroupBox.Controls.Add(this.drawRadioButton);
            this.actionGroupBox.Controls.Add(this.fillRadioButton);
            this.actionGroupBox.Location = new System.Drawing.Point(11, 196);
            this.actionGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.actionGroupBox.Name = "actionGroupBox";
            this.actionGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.actionGroupBox.Size = new System.Drawing.Size(133, 65);
            this.actionGroupBox.TabIndex = 7;
            this.actionGroupBox.TabStop = false;
            this.actionGroupBox.Visible = false;
            // 
            // drawRadioButton
            // 
            this.drawRadioButton.AutoSize = true;
            this.drawRadioButton.Checked = true;
            this.drawRadioButton.Location = new System.Drawing.Point(15, 36);
            this.drawRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.drawRadioButton.Name = "drawRadioButton";
            this.drawRadioButton.Size = new System.Drawing.Size(73, 17);
            this.drawRadioButton.TabIndex = 1;
            this.drawRadioButton.TabStop = true;
            this.drawRadioButton.Text = "Рисовать";
            this.drawRadioButton.UseVisualStyleBackColor = true;
            this.drawRadioButton.CheckedChanged += new System.EventHandler(this.drawRadioButton_CheckedChanged);
            // 
            // fillRadioButton
            // 
            this.fillRadioButton.AutoSize = true;
            this.fillRadioButton.Location = new System.Drawing.Point(15, 16);
            this.fillRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.fillRadioButton.Name = "fillRadioButton";
            this.fillRadioButton.Size = new System.Drawing.Size(61, 17);
            this.fillRadioButton.TabIndex = 0;
            this.fillRadioButton.Text = "Залить";
            this.fillRadioButton.UseVisualStyleBackColor = true;
            // 
            // imageToDrawBox
            // 
            this.imageToDrawBox.Location = new System.Drawing.Point(157, 10);
            this.imageToDrawBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageToDrawBox.Name = "imageToDrawBox";
            this.imageToDrawBox.Size = new System.Drawing.Size(530, 379);
            this.imageToDrawBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageToDrawBox.TabIndex = 8;
            this.imageToDrawBox.TabStop = false;
            this.imageToDrawBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageToDrawBox_MouseClick);
            this.imageToDrawBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageToDrawBox_MouseDown);
            this.imageToDrawBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageToDrawBox_MouseMove);
            this.imageToDrawBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageToDrawBox_MouseUp);
            // 
            // Task1b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 400);
            this.Controls.Add(this.imageToDrawBox);
            this.Controls.Add(this.actionGroupBox);
            this.Controls.Add(this.imageToFillBox);
            this.Controls.Add(this.chooseFileButton);
            this.Name = "Task1b";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageToFillBox)).EndInit();
            this.actionGroupBox.ResumeLayout(false);
            this.actionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageToDrawBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.PictureBox imageToFillBox;
        private System.Windows.Forms.GroupBox actionGroupBox;
        private System.Windows.Forms.RadioButton drawRadioButton;
        private System.Windows.Forms.RadioButton fillRadioButton;
        private System.Windows.Forms.PictureBox imageToDrawBox;
    }
}