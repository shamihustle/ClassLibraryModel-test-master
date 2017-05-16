namespace Elements.View
{
    partial class ResistorControl
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNameResistor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResistance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name Resistor";
            // 
            // textBoxNameResistor
            // 
            this.textBoxNameResistor.Location = new System.Drawing.Point(6, 20);
            this.textBoxNameResistor.Name = "textBoxNameResistor";
            this.textBoxNameResistor.Size = new System.Drawing.Size(108, 22);
            this.textBoxNameResistor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resistance:";
            // 
            // textBoxResistance
            // 
            this.textBoxResistance.Location = new System.Drawing.Point(6, 83);
            this.textBoxResistance.Name = "textBoxResistance";
            this.textBoxResistance.Size = new System.Drawing.Size(108, 22);
            this.textBoxResistance.TabIndex = 8;
            // 
            // ResistorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNameResistor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResistance);
            this.Name = "ResistorControl";
            this.Size = new System.Drawing.Size(120, 113);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNameResistor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResistance;
    }
}
