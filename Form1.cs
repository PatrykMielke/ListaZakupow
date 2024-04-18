using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (e.KeyCode != Keys.Enter) return;

            var selectedItem = wyszukiwarka.SelectedItem;

            if(selectedItem == null)
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
            if (dataGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Cells[0].Value.ToString() == selectedItem.ToString()) return;
                }
            }

            int rowIndex = dataGrid.Rows.Add(selectedItem, ilosc.Value);
            dataGrid.Rows[rowIndex].Tag = rowIndex;

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
            if (dataGrid.Rows.Count < 1) return;

            int selectedRow = (int)dataGrid.SelectedRows[0].Tag;
            dataGrid.Rows.RemoveAt(selectedRow);
        }

        private void buttonNowyProdukt_Click(object sender, EventArgs e)
        {
            if (wyszukiwarka.SelectedItem == null || wyszukiwarka.SelectedItem.ToString().Length == 0) return;

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            ZapytaniaSQL.AddNewOrder(dataGrid,comboKontrahenci);
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
    }
}
