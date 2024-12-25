using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _09_DatabaseProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi*****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yeri");
            Console.Write("Lütfen getirmek istediğiniz tablo numrasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------");

            SqlConnection connection = new SqlConnection("Data Source=OKAN;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Console.Read();
        }
    }
}
