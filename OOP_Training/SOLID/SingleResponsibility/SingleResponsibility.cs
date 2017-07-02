using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OOP_Training.SOLID.SingleResponsibility
{
    public class SimpleCalculator
    {        
        public decimal MultiplyAndRound(decimal firstNum, decimal secondNum)
        {
            var settingRepository = new SettingRepository();

            var digit = settingRepository.GetDigit();

            return Math.Round(firstNum * secondNum, digit, MidpointRounding.AwayFromZero);
        }
    }

    public class SettingRepository
    {
        private static readonly string _connectionString = "connectionString";

        public int GetDigit()
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
            return digit;
        }
    }
}
