namespace Elements.View
{
    partial class CapacitorControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNameCapacitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCapacitance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name Capacitor";
            // 
            // textBoxNameCapacitor
            // 
            this.textBoxNameCapacitor.Location = new System.Drawing.Point(6, 20);
            this.textBoxNameCapacitor.Name = "textBoxNameCapacitor";
            this.textBoxNameCapacitor.Size = new System.Drawing.Size(122, 22);
            this.textBoxNameCapacitor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Capacitance:";
            // 
            // textBoxCapacitance
            // 
            this.textBoxCapacitance.Location = new System.Drawing.Point(6, 83);
            this.textBoxCapacitance.Name = "textBoxCapacitance";
            this.textBoxCapacitance.Size = new System.Drawing.Size(122, 22);
            this.textBoxCapacitance.TabIndex = 4;
            // 
            // CapacitorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNameCapacitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCapacitance);
            this.Name = "CapacitorControl";
            this.Size = new System.Drawing.Size(139, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNameCapacitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCapacitance;
    }
}
