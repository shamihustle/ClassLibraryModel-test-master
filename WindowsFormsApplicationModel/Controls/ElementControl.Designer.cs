namespace Elements.View.Controls
{
    partial class ElementControl
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
            this.comboBoxElements = new System.Windows.Forms.ComboBox();
            this.resistorControl = new Elements.View.ResistorControl();
            this.inductorControl = new Elements.View.InductorControl();
            this.capacitorControl = new Elements.View.CapacitorControl();
            this.SuspendLayout();
            // 
            // comboBoxElements
            // 
            this.comboBoxElements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxElements.FormattingEnabled = true;
            this.comboBoxElements.Location = new System.Drawing.Point(3, 3);
            this.comboBoxElements.Name = "comboBoxElements";
            this.comboBoxElements.Size = new System.Drawing.Size(115, 24);
            this.comboBoxElements.TabIndex = 3;
            this.comboBoxElements.SelectedIndexChanged += new System.EventHandler(this.comboBoxElements_SelectedIndexChanged);
            // 
            // resistorControl
            // 
            this.resistorControl.Location = new System.Drawing.Point(3, 30);
            this.resistorControl.Name = "resistorControl";
            this.resistorControl.Size = new System.Drawing.Size(129, 113);
            this.resistorControl.TabIndex = 6;
            // 
            // inductorControl
            // 
            this.inductorControl.Location = new System.Drawing.Point(3, 30);
            this.inductorControl.Name = "inductorControl";
            this.inductorControl.Size = new System.Drawing.Size(132, 122);
            this.inductorControl.TabIndex = 5;
            // 
            // capacitorControl
            // 
            this.capacitorControl.Location = new System.Drawing.Point(3, 33);
            this.capacitorControl.Name = "capacitorControl";
            this.capacitorControl.Size = new System.Drawing.Size(139, 119);
            this.capacitorControl.TabIndex = 4;
            // 
            // ElementsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resistorControl);
            this.Controls.Add(this.inductorControl);
            this.Controls.Add(this.capacitorControl);
            this.Controls.Add(this.comboBoxElements);
            this.Name = "ElementsControl";
            this.Size = new System.Drawing.Size(134, 156);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxElements;
        private CapacitorControl capacitorControl;
        private InductorControl inductorControl;
        private ResistorControl resistorControl;
    }
}
