using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zbieracz_zamowien
{
    public partial class Form1 : Form
    {
        private static readonly string CONN = "Data Source=.;Initial Catalog=ListaZakupow;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> product_list = new List<string>();

            SqlConnection conn = new SqlConnection(CONN);
            SqlCommand cmd = new SqlCommand("select CONCAT([Nazwa produktu], ' ', Jednostka) from Produkty", conn);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    product_list.Add(reader.GetString(0));
                }
            }


            //wyszukiwarka.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            
            
            wyszukiwarka.DataSource = product_list;
        }

        private void wyszukiwarka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // if contains -> pokazać w datagridzie z użyciem timera ig

                if (wyszukiwarka.SelectedItem==null || !wyszukiwarka.Items.Contains(wyszukiwarka.SelectedItem.ToString())) return;

                string selectedItem = wyszukiwarka.SelectedItem.ToString();

                if(dataGrid.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGrid.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == selectedItem ) return;
                    }
                }
                
                int rowIndex = dataGrid.Rows.Add(selectedItem, ilosc.Value);
                dataGrid.Rows[rowIndex].Tag = rowIndex;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(CONN);

            // get new ID -> int new_order_id = select max(id) from zamowienia

            //SqlCommand()
        }

        private void buttonUsunZlisty_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count < 1) return;

            int selectedRow = (int)dataGrid.SelectedRows[0].Tag;
            dataGrid.Rows.RemoveAt(selectedRow);
        }

        private void buttonNowyProdukt_Click(object sender, EventArgs e)
        {
            if (wyszukiwarka.SelectedItem == null || wyszukiwarka.SelectedItem.ToString().Length == 0) return;

            string newProduct = wyszukiwarka.SelectedItem.ToString();

            // inserts kg/szt
        }
    }
}
