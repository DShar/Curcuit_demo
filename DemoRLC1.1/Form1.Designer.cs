namespace DemoRLC1._1
{
    partial class Form1
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
            this.button_series = new System.Windows.Forms.Button();
            this.button_parallel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_series
            // 
            this.button_series.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_series.Location = new System.Drawing.Point(215, 41);
            this.button_series.MaximumSize = new System.Drawing.Size(450, 130);
            this.button_series.MinimumSize = new System.Drawing.Size(270, 90);
            this.button_series.Name = "button_series";
            this.button_series.Size = new System.Drawing.Size(288, 130);
            this.button_series.TabIndex = 0;
            this.button_series.Text = "Последовательное соединение";
            this.button_series.UseVisualStyleBackColor = true;
            this.button_series.Click += new System.EventHandler(this.button_series_Click);
            // 
            // button_parallel
            // 
            this.button_parallel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_parallel.Location = new System.Drawing.Point(215, 175);
            this.button_parallel.MaximumSize = new System.Drawing.Size(450, 150);
            this.button_parallel.MinimumSize = new System.Drawing.Size(270, 90);
            this.button_parallel.Name = "button_parallel";
            this.button_parallel.Size = new System.Drawing.Size(288, 130);
            this.button_parallel.TabIndex = 1;
            this.button_parallel.Text = "Параллельное соединение";
            this.button_parallel.UseVisualStyleBackColor = true;
            this.button_parallel.Click += new System.EventHandler(this.button_parallel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 361);
            this.Controls.Add(this.button_parallel);
            this.Controls.Add(this.button_series);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RLC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_series;
        private System.Windows.Forms.Button button_parallel;
    }
}

