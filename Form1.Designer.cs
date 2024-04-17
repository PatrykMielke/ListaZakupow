namespace Zbieracz_zamowien
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.wyszukiwarka = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonNowyProdukt = new System.Windows.Forms.Button();
            this.buttonUsunZlisty = new System.Windows.Forms.Button();
            this.ilosc = new System.Windows.Forms.NumericUpDown();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(146, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista produktów";
            // 
            // wyszukiwarka
            // 
            this.wyszukiwarka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.wyszukiwarka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.wyszukiwarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.wyszukiwarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyszukiwarka.FormattingEnabled = true;
            this.wyszukiwarka.Location = new System.Drawing.Point(60, 162);
            this.wyszukiwarka.Name = "wyszukiwarka";
            this.wyszukiwarka.Size = new System.Drawing.Size(295, 290);
            this.wyszukiwarka.TabIndex = 1;
            this.wyszukiwarka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wyszukiwarka_KeyDown);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.iloscKolumna});
            this.dataGrid.Location = new System.Drawing.Point(719, 107);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(541, 463);
            this.dataGrid.TabIndex = 2;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(1014, 607);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(161, 82);
            this.buttonDodaj.TabIndex = 3;
            this.buttonDodaj.Text = "Dodaj zamówienie";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonNowyProdukt
            // 
            this.buttonNowyProdukt.Location = new System.Drawing.Point(375, 279);
            this.buttonNowyProdukt.Name = "buttonNowyProdukt";
            this.buttonNowyProdukt.Size = new System.Drawing.Size(61, 35);
            this.buttonNowyProdukt.TabIndex = 4;
            this.buttonNowyProdukt.Text = "Dodaj nowy";
            this.buttonNowyProdukt.UseVisualStyleBackColor = true;
            this.buttonNowyProdukt.Click += new System.EventHandler(this.buttonNowyProdukt_Click);
            // 
            // buttonUsunZlisty
            // 
            this.buttonUsunZlisty.Location = new System.Drawing.Point(770, 607);
            this.buttonUsunZlisty.Name = "buttonUsunZlisty";
            this.buttonUsunZlisty.Size = new System.Drawing.Size(161, 82);
            this.buttonUsunZlisty.TabIndex = 5;
            this.buttonUsunZlisty.Text = "Usuń produkt z listy";
            this.buttonUsunZlisty.UseVisualStyleBackColor = true;
            this.buttonUsunZlisty.Click += new System.EventHandler(this.buttonUsunZlisty_Click);
            // 
            // ilosc
            // 
            this.ilosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ilosc.Location = new System.Drawing.Point(361, 163);
            this.ilosc.Name = "ilosc";
            this.ilosc.Size = new System.Drawing.Size(120, 26);
            this.ilosc.TabIndex = 6;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa produktu";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Width = 400;
            // 
            // iloscKolumna
            // 
            this.iloscKolumna.HeaderText = "Ilość";
            this.iloscKolumna.Name = "iloscKolumna";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.ilosc);
            this.Controls.Add(this.buttonUsunZlisty);
            this.Controls.Add(this.buttonNowyProdukt);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.wyszukiwarka);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamowienia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wyszukiwarka;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonNowyProdukt;
        private System.Windows.Forms.Button buttonUsunZlisty;
        private System.Windows.Forms.NumericUpDown ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscKolumna;
    }
}

