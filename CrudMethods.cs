using MySql.Data.MySqlClient;
using System;

namespace BDMySqlForTest
{
    public static class CrudMethods
    {
        public static string DbConnStr = "server=127.0.0.1:3306;user=root;database=test;password=root;";
        private static MySqlConnection connection = new MySqlConnection(DbConnStr);

        public static string AddNewProject(string projName)
        {
            var sqlRequest = $"INSERT INTO `project` (`name`) VALUES (`{projName}`)";
            return ExecuteSqlRequest(sqlRequest);
        }
        public static string AddNewTestResult(string nameTest, int status, int projectId, string methodName,
                                                DateTime startTime, DateTime endTime, string env, string browser)
        {
            var sqlRequest = "INSERT INTO `test` (`name`, `status_id`, `method_name`, `project_id`,"+
                             "`session_id`, `start_time`, `end_time`, `env`,`browser`) "+
                             $"VALUES ('{nameTest}', {status}, '{methodName}',{projectId},3, '{startTime}', '{endTime}', '{env}', '{browser}')";
            return ExecuteSqlRequest(sqlRequest);
        }
        private static string ExecuteSqlRequest(string sqlRequest)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand(sqlRequest, connection);
            var firstCol = command.ExecuteScalar().ToString();
            connection.Close();
            return firstCol;
        }
    }
}
