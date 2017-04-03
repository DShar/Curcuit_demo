namespace DemoRLC1._1
{
    partial class Parameters
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
            this.textBox_resistance = new System.Windows.Forms.TextBox();
            this.textBox_capacity = new System.Windows.Forms.TextBox();
            this.textBox_inductance = new System.Windows.Forms.TextBox();
            this.textBox_voltSum = new System.Windows.Forms.TextBox();
            this.label_info = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_resistance = new System.Windows.Forms.Label();
            this.label_capacity = new System.Windows.Forms.Label();
            this.label_inductance = new System.Windows.Forms.Label();
            this.listBox_volt_cur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_resistance
            // 
            this.textBox_resistance.Location = new System.Drawing.Point(85, 71);
            this.textBox_resistance.Name = "textBox_resistance";
            this.textBox_resistance.Size = new System.Drawing.Size(100, 20);
            this.textBox_resistance.TabIndex = 0;
            // 
            // textBox_capacity
            // 
            this.textBox_capacity.Location = new System.Drawing.Point(85, 119);
            this.textBox_capacity.Name = "textBox_capacity";
            this.textBox_capacity.Size = new System.Drawing.Size(100, 20);
            this.textBox_capacity.TabIndex = 1;
            // 
            // textBox_inductance
            // 
            this.textBox_inductance.Location = new System.Drawing.Point(85, 166);
            this.textBox_inductance.Name = "textBox_inductance";
            this.textBox_inductance.Size = new System.Drawing.Size(100, 20);
            this.textBox_inductance.TabIndex = 2;
            // 
            // textBox_voltSum
            // 
            this.textBox_voltSum.Location = new System.Drawing.Point(85, 214);
            this.textBox_voltSum.Name = "textBox_voltSum";
            this.textBox_voltSum.Size = new System.Drawing.Size(100, 20);
            this.textBox_voltSum.TabIndex = 3;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Footlight MT Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.Location = new System.Drawing.Point(70, 9);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(147, 15);
            this.label_info.TabIndex = 6;
            this.label_info.Text = "Введите параметры схемы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_resistance
            // 
            this.label_resistance.AutoSize = true;
            this.label_resistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_resistance.Location = new System.Drawing.Point(52, 71);
            this.label_resistance.Name = "label_resistance";
            this.label_resistance.Size = new System.Drawing.Size(27, 16);
            this.label_resistance.TabIndex = 8;
            this.label_resistance.Text = "R=";
            // 
            // label_capacity
            // 
            this.label_capacity.AutoSize = true;
            this.label_capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_capacity.Location = new System.Drawing.Point(52, 123);
            this.label_capacity.Name = "label_capacity";
            this.label_capacity.Size = new System.Drawing.Size(26, 16);
            this.label_capacity.TabIndex = 9;
            this.label_capacity.Text = "C=";
            // 
            // label_inductance
            // 
            this.label_inductance.AutoSize = true;
            this.label_inductance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_inductance.Location = new System.Drawing.Point(52, 170);
            this.label_inductance.Name = "label_inductance";
            this.label_inductance.Size = new System.Drawing.Size(24, 16);
            this.label_inductance.TabIndex = 10;
            this.label_inductance.Text = "L=";
            // 
            // listBox_volt_cur
            // 
            this.listBox_volt_cur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_volt_cur.FormattingEnabled = true;
            this.listBox_volt_cur.ItemHeight = 16;
            this.listBox_volt_cur.Items.AddRange(new object[] {
            "Uвх",
            "Iобщ"});
            this.listBox_volt_cur.Location = new System.Drawing.Point(24, 214);
            this.listBox_volt_cur.Name = "listBox_volt_cur";
            this.listBox_volt_cur.Size = new System.Drawing.Size(52, 20);
            this.listBox_volt_cur.TabIndex = 11;
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.listBox_volt_cur);
            this.Controls.Add(this.label_inductance);
            this.Controls.Add(this.label_capacity);
            this.Controls.Add(this.label_resistance);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.textBox_voltSum);
            this.Controls.Add(this.textBox_inductance);
            this.Controls.Add(this.textBox_capacity);
            this.Controls.Add(this.textBox_resistance);
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "Parameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_resistance;
        private System.Windows.Forms.TextBox textBox_capacity;
        private System.Windows.Forms.TextBox textBox_inductance;
        private System.Windows.Forms.TextBox textBox_voltSum;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_resistance;
        private System.Windows.Forms.Label label_capacity;
        private System.Windows.Forms.Label label_inductance;
        private System.Windows.Forms.ListBox listBox_volt_cur;
    }
}