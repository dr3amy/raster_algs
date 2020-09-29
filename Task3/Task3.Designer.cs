﻿using System.ComponentModel;
 using System.Drawing;

 namespace raster_algs
{
    partial class Task3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.algorithmList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = Color.Brown;
            this.canvas.Location = new System.Drawing.Point(44, 58);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(709, 380);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += this.OnClick;
            // 
            // algorithmList
            // 
            this.algorithmList.FormattingEnabled = true;
            this.algorithmList.Items.AddRange(new object[] {"Брезенхейм", "Ву"});
            this.algorithmList.Location = new System.Drawing.Point(56, 9);
            this.algorithmList.Name = "algorithmList";
            this.algorithmList.Size = new System.Drawing.Size(131, 21);
            this.algorithmList.TabIndex = 1;
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.algorithmList);
            this.Controls.Add(this.canvas);
            this.Name = "Task3";
            this.Text = "Рисование прямой";
            ((System.ComponentModel.ISupportInitialize) (this.canvas)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox algorithmList;
        private System.Windows.Forms.PictureBox canvas;

        #endregion
    }
}