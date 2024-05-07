using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();

                string sql = "SELECT h_doctors.doctor_id, h_doctors.doctor_name, AVG(h_consultations.consultation_price) as average_price " +
                             "FROM h_doctors " +
                             "JOIN h_consultations ON h_doctors.doctor_id = h_consultations.h_doctors_doctor_id " +
                             "GROUP BY h_doctors.doctor_id, h_doctors.doctor_name";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("Doctor ID | Doctor Name | Average Consultation Price");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["doctor_id"]} | {reader["doctor_name"]} | {reader["average_price"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.ToString()}");
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}