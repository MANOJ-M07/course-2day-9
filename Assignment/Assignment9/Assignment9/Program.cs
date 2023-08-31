using System;
using System.Data.SqlClient;
using System.Data;

namespace Assignment9
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static string conStr = "server=LAPTOP-DLI2FL88;database=Assignment9Db; trusted_connection = true;";

        static void ExOrder(int Custid, decimal total)
        {
            con = new SqlConnection(conStr);
            cmd = new SqlCommand();
            cmd.CommandText = "PlaceOrder";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id", Custid);
            cmd.Parameters.AddWithValue("@total", total);
            con.Open();
            reader = cmd.ExecuteReader();
            Console.WriteLine("Order Placed successfully!!!!");
        }
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter Customer ID : ");
                int Custid = int.Parse(Console.ReadLine());
                Console.Write("Enter Total Amount : ");
                decimal total = decimal.Parse(Console.ReadLine());

                ExOrder(Custid, total);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}