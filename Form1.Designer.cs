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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.wyszukiwarka = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscKolumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonNowyProdukt = new System.Windows.Forms.Button();
            this.buttonUsunZlisty = new System.Windows.Forms.Button();
            this.ilosc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboKontrahenci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDodajKlienta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelNewOrder = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc)).BeginInit();
            this.panelNewOrder.SuspendLayout();
            this.panelHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(46, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
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
            this.wyszukiwarka.Location = new System.Drawing.Point(50, 272);
            this.wyszukiwarka.Name = "wyszukiwarka";
            this.wyszukiwarka.Size = new System.Drawing.Size(295, 330);
            this.wyszukiwarka.TabIndex = 3;
            this.wyszukiwarka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wyszukiwarka_KeyDown);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa,
            this.iloscKolumna,
            this.numer});
            this.dataGridView.Location = new System.Drawing.Point(548, 53);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(503, 529);
            this.dataGridView.TabIndex = 100;
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
            // numer
            // 
            this.numer.HeaderText = "numer";
            this.numer.Name = "numer";
            this.numer.ReadOnly = true;
            this.numer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numer.Visible = false;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDodaj.Location = new System.Drawing.Point(890, 591);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(161, 42);
            this.buttonDodaj.TabIndex = 201;
            this.buttonDodaj.Text = "Dodaj zamówienie";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonNowyProdukt
            // 
            this.buttonNowyProdukt.Enabled = false;
            this.buttonNowyProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonNowyProdukt.Location = new System.Drawing.Point(352, 305);
            this.buttonNowyProdukt.Name = "buttonNowyProdukt";
            this.buttonNowyProdukt.Size = new System.Drawing.Size(120, 52);
            this.buttonNowyProdukt.TabIndex = 4;
            this.buttonNowyProdukt.Text = "Dodaj nowy produkt";
            this.buttonNowyProdukt.UseVisualStyleBackColor = true;
            this.buttonNowyProdukt.Click += new System.EventHandler(this.buttonNowyProdukt_Click);
            // 
            // buttonUsunZlisty
            // 
            this.buttonUsunZlisty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonUsunZlisty.Location = new System.Drawing.Point(548, 588);
            this.buttonUsunZlisty.Name = "buttonUsunZlisty";
            this.buttonUsunZlisty.Size = new System.Drawing.Size(161, 45);
            this.buttonUsunZlisty.TabIndex = 200;
            this.buttonUsunZlisty.Text = "Usuń produkt z listy";
            this.buttonUsunZlisty.UseVisualStyleBackColor = true;
            this.buttonUsunZlisty.Click += new System.EventHandler(this.buttonUsunZlisty_Click);
            // 
            // ilosc
            // 
            this.ilosc.DecimalPlaces = 2;
            this.ilosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ilosc.Location = new System.Drawing.Point(351, 273);
            this.ilosc.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ilosc.Name = "ilosc";
            this.ilosc.Size = new System.Drawing.Size(120, 26);
            this.ilosc.TabIndex = 4;
            this.ilosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ilosc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ilosc_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(46, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
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
            this.comboKontrahenci.Location = new System.Drawing.Point(50, 54);
            this.comboKontrahenci.Name = "comboKontrahenci";
            this.comboKontrahenci.Size = new System.Drawing.Size(295, 168);
            this.comboKontrahenci.TabIndex = 1;
            this.comboKontrahenci.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboKontrahenci_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(347, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ilość";
            // 
            // buttonDodajKlienta
            // 
            this.buttonDodajKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDodajKlienta.Location = new System.Drawing.Point(352, 54);
            this.buttonDodajKlienta.Name = "buttonDodajKlienta";
            this.buttonDodajKlienta.Size = new System.Drawing.Size(119, 51);
            this.buttonDodajKlienta.TabIndex = 2;
            this.buttonDodajKlienta.Text = "Dodaj nowego klienta";
            this.buttonDodajKlienta.UseVisualStyleBackColor = true;
            this.buttonDodajKlienta.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(544, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 202;
            this.label4.Text = "Lista zakupów";
            // 
            // panelNewOrder
            // 
            this.panelNewOrder.Controls.Add(this.dataGridView);
            this.panelNewOrder.Controls.Add(this.label4);
            this.panelNewOrder.Controls.Add(this.label1);
            this.panelNewOrder.Controls.Add(this.buttonDodajKlienta);
            this.panelNewOrder.Controls.Add(this.wyszukiwarka);
            this.panelNewOrder.Controls.Add(this.label3);
            this.panelNewOrder.Controls.Add(this.buttonDodaj);
            this.panelNewOrder.Controls.Add(this.comboKontrahenci);
            this.panelNewOrder.Controls.Add(this.buttonNowyProdukt);
            this.panelNewOrder.Controls.Add(this.label2);
            this.panelNewOrder.Controls.Add(this.buttonUsunZlisty);
            this.panelNewOrder.Controls.Add(this.ilosc);
            this.panelNewOrder.Location = new System.Drawing.Point(12, 76);
            this.panelNewOrder.Name = "panelNewOrder";
            this.panelNewOrder.Size = new System.Drawing.Size(1119, 657);
            this.panelNewOrder.TabIndex = 203;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 33);
            this.label5.TabIndex = 204;
            this.label5.Text = "Nowe zamówienie";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(837, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 33);
            this.label6.TabIndex = 205;
            this.label6.Text = "Zgrupuj z całego dnia";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelHistory.Controls.Add(this.button2);
            this.panelHistory.Controls.Add(this.dataGridView1);
            this.panelHistory.Controls.Add(this.button1);
            this.panelHistory.Controls.Add(this.dateTimePicker1);
            this.panelHistory.Location = new System.Drawing.Point(12, 74);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(1119, 657);
            this.panelHistory.TabIndex = 206;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 3, 21, 17, 4, 0);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(224, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zgrupuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(520, 26);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(503, 529);
            this.dataGridView1.TabIndex = 203;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nazwa produktu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ilość";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(672, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 32);
            this.button2.TabIndex = 204;
            this.button2.Text = "PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1158, 756);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelNewOrder);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamowienia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilosc)).EndInit();
            this.panelNewOrder.ResumeLayout(false);
            this.panelNewOrder.PerformLayout();
            this.panelHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox wyszukiwarka;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonNowyProdukt;
        private System.Windows.Forms.Button buttonUsunZlisty;
        private System.Windows.Forms.NumericUpDown ilosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboKontrahenci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDodajKlienta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelNewOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscKolumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn numer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button2;
    }
}

