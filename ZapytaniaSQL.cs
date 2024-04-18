using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zbieracz_zamowien
{
    internal class ZapytaniaSQL
    {
        private static string CONN = "Data Source=.;Initial Catalog=ListaZakupow;Integrated Security=True";

        public static void UpdateClientList(ComboBox comboKontrahenci)
        {
            List<string> client_list = new List<string>();
            SqlConnection conn = new SqlConnection(CONN);
            SqlCommand cmd = new SqlCommand("select [nazwa kontrahenta] from kontrahenci order by [nazwa kontrahenta] asc", conn);

            conn.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    client_list.Add(reader.GetString(0));
                }
            }
            comboKontrahenci.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            comboKontrahenci.DataSource = client_list;

            conn.Close();
        }
        public static void UpdateProductList(ComboBox productBrowser)
        {
            List<string> product_list = new List<string>();
            SqlConnection conn = new SqlConnection(CONN);


            // 
            //
            //

            //                   Zdobyć id produktu XDXD

            //

            //


            SqlCommand cmd = new SqlCommand("select CONCAT([Nazwa produktu], ' ', Jednostka) produkt from Produkty order by produkt asc", conn);

            conn.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    product_list.Add(reader.GetString(0));
                }
            }
            productBrowser.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            productBrowser.DataSource = product_list;

            conn.Close();
        }

        public static void AddProduct(ComboBox productBrowser)
        {
            SqlConnection conn = new SqlConnection(CONN);
            SqlCommand cmd = new SqlCommand("insert into produkty([nazwa produktu],[jednostka]) values (@parametr,'kg'),(@parametr,'szt')", conn);
            cmd.Parameters.AddWithValue("@parametr", productBrowser.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void AddClient(ComboBox comboKontrahenci)
        {
            SqlConnection conn = new SqlConnection(CONN);
            SqlCommand cmd = new SqlCommand("insert into kontrahenci values (@parametr)", conn);
            cmd.Parameters.AddWithValue("@parametr", comboKontrahenci.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void AddNewOrder(DataGridView dataGridView, ComboBox client)
        {
            if (client.SelectedItem == null || dataGridView.Rows.Count < 1)
            {
                return;
            }

            // Get new ID_List 

            int newId = 0;
            SqlConnection conn = new SqlConnection(CONN);
            SqlCommand cmd = new SqlCommand("select max(ID_Listy) id from Listy", conn);

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        newId = 1;
                    }
                    else
                    {
                        newId = reader.GetInt16(0)+1;
                    }
                    
                }
            }
            conn.Close();
            
            // Get All products

            List<string> products = new List<string>();
            List<decimal> amount = new List<decimal>();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                products.Add(dataGridView.Rows[i].Cells[0].Value.ToString());
                amount.Add((decimal)dataGridView.Rows[i].Cells[1].Value);
            }

            string insertCmd = "insert into Listy values ";

            string newParameter;
            for (int i = 0; i < products.Count; i++)
            {
                newParameter = "(";
                newParameter += newId.ToString() + ",";
                newParameter += products[i].ToString() + ",";
                newParameter += amount[i];
                newParameter += ")";
                if (i < products.Count-1) newParameter += ",";

                insertCmd += newParameter;
            }
            MessageBox.Show(insertCmd);


        }
    }
}
