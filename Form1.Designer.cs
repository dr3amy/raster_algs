namespace raster_algs
{
    partial class Loader
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Task1a = new System.Windows.Forms.Button();
            this.Task1b = new System.Windows.Forms.Button();
            this.Task2 = new System.Windows.Forms.Button();
            this.Task3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1a
            // 
            this.Task1a.Location = new System.Drawing.Point(65, 11);
            this.Task1a.Margin = new System.Windows.Forms.Padding(2);
            this.Task1a.Name = "Task1a";
            this.Task1a.Size = new System.Drawing.Size(161, 54);
            this.Task1a.TabIndex = 1;
            this.Task1a.Text = "Task1a";
            this.Task1a.UseVisualStyleBackColor = true;
            this.Task1a.Click += new System.EventHandler(this.Task1a_Click);
            // 
            // Task1b
            // 
            this.Task1b.Location = new System.Drawing.Point(65, 81);
            this.Task1b.Margin = new System.Windows.Forms.Padding(2);
            this.Task1b.Name = "Task1b";
            this.Task1b.Size = new System.Drawing.Size(161, 54);
            this.Task1b.TabIndex = 2;
            this.Task1b.Text = "Task1b";
            this.Task1b.UseVisualStyleBackColor = true;
            this.Task1b.Click += new System.EventHandler(this.Task1b_Click);
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(65, 156);
            this.Task2.Margin = new System.Windows.Forms.Padding(2);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(161, 54);
            this.Task2.TabIndex = 3;
            this.Task2.Text = "Task2";
            this.Task2.UseVisualStyleBackColor = true;
            this.Task2.Click += new System.EventHandler(this.Task2_Click);
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(65, 229);
            this.Task3.Margin = new System.Windows.Forms.Padding(2);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(161, 54);
            this.Task3.TabIndex = 4;
            this.Task3.Text = "Task3";
            this.Task3.UseVisualStyleBackColor = true;
            this.Task3.Click += new System.EventHandler(this.Task3_Click);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 294);
            this.Controls.Add(this.Task3);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.Task1b);
            this.Controls.Add(this.Task1a);
            this.Name = "Loader";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Task1a;
        private System.Windows.Forms.Button Task1b;
        private System.Windows.Forms.Button Task2;
        private System.Windows.Forms.Button Task3;
    }
}

