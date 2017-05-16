namespace Elements.View
{
    partial class InductorControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInductance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNameInductor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inductance:";
            // 
            // textBoxInductance
            // 
            this.textBoxInductance.Location = new System.Drawing.Point(3, 90);
            this.textBoxInductance.Name = "textBoxInductance";
            this.textBoxInductance.Size = new System.Drawing.Size(121, 22);
            this.textBoxInductance.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name Inductor";
            // 
            // textBoxNameInductor
            // 
            this.textBoxNameInductor.Location = new System.Drawing.Point(3, 25);
            this.textBoxNameInductor.Name = "textBoxNameInductor";
            this.textBoxNameInductor.Size = new System.Drawing.Size(121, 22);
            this.textBoxNameInductor.TabIndex = 11;
            // 
            // InductorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxInductance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNameInductor);
            this.Name = "InductorControl";
            this.Size = new System.Drawing.Size(132, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInductance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNameInductor;
    }
}
