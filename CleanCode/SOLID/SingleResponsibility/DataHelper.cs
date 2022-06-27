using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class DataHelper
    {
        SqlConnection sqlConnection;
        public DataHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int Execute(string commandText, Dictionary<string,object> parameters)
        {
            SqlCommand command = createCommand(commandText, parameters);
            command.Connection.Open();
            var affected = command.ExecuteNonQuery();
            command.Connection.Close();
            return affected;
            
        }

        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            var command = sqlConnection.CreateCommand();
            command.CommandText = commandText;
            addParametersToCommand(command, parameters);
            return command;

        }

        private void addParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

        }
    }
}
