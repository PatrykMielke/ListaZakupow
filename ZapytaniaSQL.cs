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

        public static void AddNewList(DataGridView dataGridView, ComboBox client)
        {
            if (client.SelectedItem == null || dataGridView.Rows.Count < 1)
            {
                MessageBox.Show("Błąd");
            }

            // Get new ID_List 

            int newID = GetNewListID();
            if (newID == -1)
            {
                MessageBox.Show("Błąd połączenia z bazą");
                return;
            }

            // Get All products

            List<string> products = new List<string>();
            List<string> amount = new List<string>();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                products.Add(dataGridView.Rows[i].Cells[0].Value.ToString());
                amount.Add((string)dataGridView.Rows[i].Cells[1].Value);
            }

            string insertCmd = "insert into Listy values ";

            string newParameter;
            for (int i = 0; i < products.Count; i++)
            {
                newParameter = "(";
                newParameter += newID.ToString() + ",";


                newParameter += " (SELECT id_produktu from produkty where CONCAT([Nazwa produktu], ' ', Jednostka) = '" + products[i].ToString() + "'), ";
                newParameter += amount[i];
                newParameter += ")";

                //remove , at the end

                if (i < products.Count-1) newParameter += ",";

                insertCmd += newParameter;
                
            }

            try
            {
                SqlConnection conn = new SqlConnection(CONN);
                SqlCommand cmd = new SqlCommand(insertCmd, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            AddNewOrder(newID,(string)client.SelectedItem);
            
        }
        private static int GetNewListID()
        {
            var newID = 1;
            SqlConnection conn = new SqlConnection(CONN);
            SqlCommand cmd = new SqlCommand("select max(ID_Listy) id from Listy", conn);

            try
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            newID = reader.GetInt32(0) + 1;
                        }
                    }
                }

                conn.Close();
                return newID;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            
        }

        private static void AddNewOrder(int newID, string client)
        {
            try
            {
                SqlConnection conn = new SqlConnection(CONN);
                SqlCommand cmd = new SqlCommand("insert into zamowienia values ( (select ID_Kontrahenta\r\nfrom kontrahenci\r\nwhere [Nazwa kontrahenta] = @klient), @lista, getdate())", conn);
                cmd.Parameters.AddWithValue("@klient", client);
                cmd.Parameters.AddWithValue("@lista", newID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        internal static void GroupUp(DateTime date,DataGridView dataGridView)
        {
            SqlConnection conn = new SqlConnection(CONN);

            string query = @"
                select concat(p.[Nazwa produktu],' ',p.Jednostka) produkt, sum(l.Ilosc) ilosc
                from produkty p inner join listy l on p.ID_Produktu = l.ID_Produktu inner join Zamowienia z on z.ID_Listy = l.ID_Listy
                where z.Data = @date
                group by [Nazwa produktu], Jednostka
            ";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@date", date.Date);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    dataGridView.Rows.Add(reader.GetString(0) ,reader.GetDecimal(1));
                }
            }
            conn.Close();
            if(dataGridView.Rows.Count < 1)
            {
                MessageBox.Show("Brak zamówień na dany dzień");
            }
        }
    }
}
