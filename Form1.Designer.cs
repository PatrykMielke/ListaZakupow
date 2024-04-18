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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.wyszukiwarka = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonNowyProdukt = new System.Windows.Forms.Button();
            this.buttonUsunZlisty = new System.Windows.Forms.Button();
            this.ilosc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboKontrahenci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDodajKlienta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 244);
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
            this.wyszukiwarka.Location = new System.Drawing.Point(57, 284);
            this.wyszukiwarka.Name = "wyszukiwarka";
            this.wyszukiwarka.Size = new System.Drawing.Size(295, 290);
            this.wyszukiwarka.TabIndex = 3;
            this.wyszukiwarka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wyszukiwarka_KeyDown);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.iloscKolumna});
            this.dataGrid.Location = new System.Drawing.Point(554, 66);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(503, 463);
            this.dataGrid.TabIndex = 100;
            // 
            // Nazwa
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Nazwa.DefaultCellStyle = dataGridViewCellStyle8;
            this.Nazwa.HeaderText = "Nazwa produktu";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            this.Nazwa.Width = 400;
            // 
            // iloscKolumna
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.iloscKolumna.DefaultCellStyle = dataGridViewCellStyle9;
            this.iloscKolumna.HeaderText = "Ilość";
            this.iloscKolumna.Name = "iloscKolumna";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(838, 536);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(161, 82);
            this.buttonDodaj.TabIndex = 201;
            this.buttonDodaj.Text = "Dodaj zamówienie";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonNowyProdukt
            // 
            this.buttonNowyProdukt.Enabled = false;
            this.buttonNowyProdukt.Location = new System.Drawing.Point(358, 329);
            this.buttonNowyProdukt.Name = "buttonNowyProdukt";
            this.buttonNowyProdukt.Size = new System.Drawing.Size(120, 35);
            this.buttonNowyProdukt.TabIndex = 4;
            this.buttonNowyProdukt.Text = "Dodaj nowy produkt";
            this.buttonNowyProdukt.UseVisualStyleBackColor = true;
            this.buttonNowyProdukt.Click += new System.EventHandler(this.buttonNowyProdukt_Click);
            // 
            // buttonUsunZlisty
            // 
            this.buttonUsunZlisty.Location = new System.Drawing.Point(594, 536);
            this.buttonUsunZlisty.Name = "buttonUsunZlisty";
            this.buttonUsunZlisty.Size = new System.Drawing.Size(161, 82);
            this.buttonUsunZlisty.TabIndex = 200;
            this.buttonUsunZlisty.Text = "Usuń produkt z listy";
            this.buttonUsunZlisty.UseVisualStyleBackColor = true;
            this.buttonUsunZlisty.Click += new System.EventHandler(this.buttonUsunZlisty_Click);
            // 
            // ilosc
            // 
            this.ilosc.DecimalPlaces = 1;
            this.ilosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ilosc.Location = new System.Drawing.Point(358, 285);
            this.ilosc.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ilosc.Name = "ilosc";
            this.ilosc.Size = new System.Drawing.Size(120, 26);
            this.ilosc.TabIndex = 4;
            this.ilosc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ilosc_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista klientów";
            // 
            // comboKontrahenci
            // 
            this.comboKontrahenci.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboKontrahenci.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboKontrahenci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboKontrahenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboKontrahenci.FormattingEnabled = true;
            this.comboKontrahenci.Location = new System.Drawing.Point(57, 66);
            this.comboKontrahenci.Name = "comboKontrahenci";
            this.comboKontrahenci.Size = new System.Drawing.Size(295, 148);
            this.comboKontrahenci.TabIndex = 1;
            this.comboKontrahenci.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboKontrahenci_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(354, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ilość";
            // 
            // buttonDodajKlienta
            // 
            this.buttonDodajKlienta.Location = new System.Drawing.Point(359, 66);
            this.buttonDodajKlienta.Name = "buttonDodajKlienta";
            this.buttonDodajKlienta.Size = new System.Drawing.Size(85, 27);
            this.buttonDodajKlienta.TabIndex = 2;
            this.buttonDodajKlienta.Text = "Dodaj nowego";
            this.buttonDodajKlienta.UseVisualStyleBackColor = true;
            this.buttonDodajKlienta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(550, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 202;
            this.label4.Text = "Lista zakupów";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1144, 713);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDodajKlienta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboKontrahenci);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboKontrahenci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDodajKlienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscKolumna;
        private System.Windows.Forms.Label label4;
    }
}

