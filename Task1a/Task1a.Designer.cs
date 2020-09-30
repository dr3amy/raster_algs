namespace raster_algs.Task1a
{
    partial class Task1a
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
            this.enableDrawing = new System.Windows.Forms.RadioButton();
            this.enableFilling = new System.Windows.Forms.RadioButton();
            this.currentColorPicture = new System.Windows.Forms.PictureBox();
            this.changeCurrentColor = new System.Windows.Forms.Button();
            this.workArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workArea)).BeginInit();
            this.SuspendLayout();
            // 
            // enableDrawing
            // 
            this.enableDrawing.AutoSize = true;
            this.enableDrawing.Checked = true;
            this.enableDrawing.Location = new System.Drawing.Point(117, 23);
            this.enableDrawing.Margin = new System.Windows.Forms.Padding(2);
            this.enableDrawing.Name = "enableDrawing";
            this.enableDrawing.Size = new System.Drawing.Size(80, 17);
            this.enableDrawing.TabIndex = 1;
            this.enableDrawing.TabStop = true;
            this.enableDrawing.Text = "Рисование";
            this.enableDrawing.UseVisualStyleBackColor = true;
            // 
            // enableFilling
            // 
            this.enableFilling.AutoSize = true;
            this.enableFilling.Location = new System.Drawing.Point(201, 23);
            this.enableFilling.Margin = new System.Windows.Forms.Padding(2);
            this.enableFilling.Name = "enableFilling";
            this.enableFilling.Size = new System.Drawing.Size(68, 17);
            this.enableFilling.TabIndex = 2;
            this.enableFilling.Text = "Заливка";
            this.enableFilling.UseVisualStyleBackColor = true;
            this.enableFilling.CheckedChanged += new System.EventHandler(this.enableFilling_CheckedChanged);
            // 
            // currentColorPicture
            // 
            this.currentColorPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentColorPicture.Location = new System.Drawing.Point(285, 11);
            this.currentColorPicture.Margin = new System.Windows.Forms.Padding(2);
            this.currentColorPicture.Name = "currentColorPicture";
            this.currentColorPicture.Size = new System.Drawing.Size(76, 41);
            this.currentColorPicture.TabIndex = 3;
            this.currentColorPicture.TabStop = false;
            // 
            // changeCurrentColor
            // 
            this.changeCurrentColor.Location = new System.Drawing.Point(365, 16);
            this.changeCurrentColor.Margin = new System.Windows.Forms.Padding(2);
            this.changeCurrentColor.Name = "changeCurrentColor";
            this.changeCurrentColor.Size = new System.Drawing.Size(100, 30);
            this.changeCurrentColor.TabIndex = 4;
            this.changeCurrentColor.Text = "Изменить цвет";
            this.changeCurrentColor.UseVisualStyleBackColor = true;
            this.changeCurrentColor.Click += new System.EventHandler(this.changeCurrentColor_Click);
            // 
            // workArea
            // 
            this.workArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workArea.Location = new System.Drawing.Point(29, 56);
            this.workArea.Margin = new System.Windows.Forms.Padding(2);
            this.workArea.Name = "workArea";
            this.workArea.Size = new System.Drawing.Size(582, 355);
            this.workArea.TabIndex = 5;
            this.workArea.TabStop = false;
            this.workArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.workArea_MouseDown);
            this.workArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.workArea_MouseMove);
            this.workArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.workArea_MouseUp);
            // 
            // Task1a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 429);
            this.Controls.Add(this.workArea);
            this.Controls.Add(this.changeCurrentColor);
            this.Controls.Add(this.currentColorPicture);
            this.Controls.Add(this.enableFilling);
            this.Controls.Add(this.enableDrawing);
            this.Name = "Task1a";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.currentColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton enableDrawing;
        private System.Windows.Forms.RadioButton enableFilling;
        private System.Windows.Forms.PictureBox currentColorPicture;
        private System.Windows.Forms.Button changeCurrentColor;
        private System.Windows.Forms.PictureBox workArea;
    }
}