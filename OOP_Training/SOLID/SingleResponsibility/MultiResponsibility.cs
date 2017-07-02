using System;
using System.Data.SqlClient;

namespace OOP_Training.SOLID.SingleResponsibility
{
    public class ComplexCalculator
    {
        private static readonly string _connectionString = "connectionString";

        public decimal MultiplyAndRound(decimal firstNum, decimal secondNum)
        {
            var sqlString = "select val from Setting where id = 'digit'";
            var conn = new SqlConnection(_connectionString);
            var cmd = new SqlCommand(sqlString, conn);

            var digit = 0;
            using (var dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    digit = Convert.ToInt32(dr["val"]);
                }
            }

            return Math.Round(firstNum * secondNum, digit, MidpointRounding.AwayFromZero);
        }
    }
}