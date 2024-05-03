using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace Zbieracz_zamowien
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelHistory.Hide();
            ZapytaniaSQL.UpdateClientList(comboKontrahenci);
            ZapytaniaSQL.UpdateProductList(wyszukiwarka);
        }

        // wyszukiwarka
        private void wyszukiwarka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // if contains -> pokazać w datagridzie z użyciem timera ig
                if (wyszukiwarka.SelectedItem == null || !wyszukiwarka.Items.Contains(wyszukiwarka.SelectedItem.ToString())) return;
                ilosc.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                // if contains -> pokazać w datagridzie z użyciem timera ig
                if (wyszukiwarka.SelectedItem == null || !wyszukiwarka.Items.Contains(wyszukiwarka.SelectedItem.ToString())) return;
                ilosc.Focus();
            }
        }

        // ilość combo
        private void ilosc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab) { wyszukiwarka.Focus(); return; }
            if (e.KeyCode == Keys.Enter) AddNewProductOnList();

            
        }

        private void AddNewProductOnList()
        {
            var selectedItem = wyszukiwarka.SelectedItem;

            if (selectedItem == null)
            {
                DialogResult result = MessageBox.Show(wyszukiwarka.Text, "Czy chcesz nowy produkt?", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    ZapytaniaSQL.AddProduct(wyszukiwarka);
                    ZapytaniaSQL.UpdateProductList(wyszukiwarka);
                    wyszukiwarka.Text = null;
                    wyszukiwarka.Focus();
                    return;
                }
                else
                {
                    return;
                }
            }

            // check if the product is already in the datagrid
            if (dataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString() == selectedItem.ToString()) 
                    {
                        MessageBox.Show("Produkt już jest na liście");
                        return;
                    }
                }
            }

            //replace comma with a dot
            string amount = ilosc.Value.ToString();

            if (amount.Contains(",")) amount = amount.Replace(",", ".");


            int rowIndex = dataGridView.Rows.Add();
            dataGridView.Rows[rowIndex].Cells[0].Value = selectedItem;
            dataGridView.Rows[rowIndex].Cells[1].Value = amount;
            dataGridView.Rows[rowIndex].Cells[2].Value = rowIndex;

            wyszukiwarka.SelectedItem = null;
            ilosc.Value = 1.0m;

            wyszukiwarka.Focus();
        }




        // kontrahenci

        private void comboKontrahenci_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboKontrahenci.SelectedItem == null)
                {
                    MessageBox.Show("Brak klienta w bazie.\nWpisz jego nazwę jeszcze raz, a następnie kliknij tab i enter, żeby dodać nowego :)");
                    return;
                }
                wyszukiwarka.Focus();
            }
            if(e.KeyCode == Keys.Tab)
            {
                buttonDodajKlienta.Focus();
            }
        }


        // buttons
        private void buttonUsunZlisty_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count < 1 || dataGridView.SelectedRows.Count < 1) return;

            dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
        }

        private void buttonNowyProdukt_Click(object sender, EventArgs e)
        {
            if (wyszukiwarka.SelectedItem == null || wyszukiwarka.SelectedItem.ToString().Length == 0) return;

            AddNewProductOnList();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            ZapytaniaSQL.AddNewList(dataGridView,comboKontrahenci);
        }

        // nowy klient
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboKontrahenci.SelectedItem != null) { wyszukiwarka.Focus(); return; }


            DialogResult result = MessageBox.Show(comboKontrahenci.Text, "Czy chcesz nowego klienta?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ZapytaniaSQL.AddClient(comboKontrahenci);
                ZapytaniaSQL.UpdateClientList(comboKontrahenci);
                comboKontrahenci.Text = null;
                comboKontrahenci.Focus();
                return;
            }
            else
            {
                return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panelNewOrder.Show();
            panelHistory.Hide();
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Gray;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panelHistory.Show();
            panelNewOrder.Hide();
            label5.ForeColor = Color.Gray;
            label6.ForeColor = Color.Black;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            if (date != null)
            {
                ZapytaniaSQL.GroupUp(date,dataGridView1);
            }
            else
            {
                MessageBox.Show("Data jest pusta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Zamowienie.pdf";

                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        Font calibri = FontFactory.GetFont(@"C:\Windows\Fonts\Calibri.ttf", "Identity-H", BaseFont.EMBEDDED,20);
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, calibri));
                                pdfTable.AddCell(cell);
                            }

                            calibri = FontFactory.GetFont(@"C:\Windows\Fonts\Calibri.ttf", "Identity-H", BaseFont.EMBEDDED, 16);
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), calibri));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Zapisano!", "Info");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak danych w tabeli", "Info");
            }
        }




    }
}
