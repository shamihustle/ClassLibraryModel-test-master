namespace Elements.View
{
    partial class SearchForm
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
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.NameElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impedance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.SearchOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Name Element",
            "Nominal",
            "Impedance"});
            this.comboBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSearch.TabIndex = 0;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToAddRows = false;
            this.dataGridViewSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameElement,
            this.Nominal,
            this.Impedance});
            this.dataGridViewSearch.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersVisible = false;
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.Size = new System.Drawing.Size(476, 283);
            this.dataGridViewSearch.TabIndex = 1;
            // 
            // NameElement
            // 
            this.NameElement.HeaderText = "Name Element";
            this.NameElement.Name = "NameElement";
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.Name = "Nominal";
            // 
            // Impedance
            // 
            this.Impedance.HeaderText = "Impedance";
            this.Impedance.Name = "Impedance";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(139, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(213, 22);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(358, 11);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(130, 23);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Search";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // SearchOk
            // 
            this.SearchOk.Location = new System.Drawing.Point(388, 332);
            this.SearchOk.Name = "SearchOk";
            this.SearchOk.Size = new System.Drawing.Size(100, 23);
            this.SearchOk.TabIndex = 5;
            this.SearchOk.Text = "Ok";
            this.SearchOk.UseVisualStyleBackColor = true;
            this.SearchOk.Click += new System.EventHandler(this.SearchOk_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 367);
            this.Controls.Add(this.SearchOk);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impedance;
        private System.Windows.Forms.Button SearchOk;
    }
}