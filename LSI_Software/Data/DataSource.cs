using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSI_Software.Model;

namespace LSI_Software.Data
{
    public class DataSource
    {
        public static List<ExportHistoryElement> LoadExportHistoryList(string localSearch, 
            DateTime? dateTimeFrom, 
            DateTime? dateTimeTo)
        {
            List<ExportHistoryElement> exportHistoryElements
                = new List<ExportHistoryElement>();

            string sql = "select * from dbo.export_history where export_date >= @dateFrom and export_date <= @dateTo ";
            string connString = Properties.Settings.Default.connStr;

            SqlConnection connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                if (localSearch != String.Empty)
                {
                    sql = sql + " and export_local_name like @local_name ";
                    command.Parameters.AddWithValue("@local_name", "%" + localSearch + "%");
                }

                command.Parameters.Add("@dateFrom", System.Data.SqlDbType.DateTime);
                if (dateTimeFrom != null)
                    command.Parameters["@dateFrom"].Value = dateTimeFrom;
                else
                    command.Parameters["@dateFrom"].Value = SqlDateTime.MinValue;

                command.Parameters.Add("@dateTo", System.Data.SqlDbType.DateTime);
                if (dateTimeFrom != null)
                    command.Parameters["@dateTo"].Value = dateTimeTo;
                else
                    command.Parameters["@dateTo"].Value = SqlDateTime.MaxValue;

                

                command.CommandText= sql;

                
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AddHistoryElementFromDataReader(exportHistoryElements, dataReader);
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.ToString());
            }
            return exportHistoryElements;

        }

        private static void AddHistoryElementFromDataReader(List<ExportHistoryElement> exportHistoryElements, SqlDataReader dataReader)
        {
            exportHistoryElements.Add(new ExportHistoryElement()
            {
                Id = Convert.ToInt32(dataReader["id"].ToString()),
                Name = dataReader["name"] != DBNull.Value ? dataReader["name"].ToString() : String.Empty,
                DateTimeOfExport = Convert.ToDateTime(dataReader["export_date"]),
                UserName = dataReader["user_name"] != DBNull.Value ? dataReader["user_name"].ToString() : String.Empty,
                ExportLocalName = dataReader["export_local_name"] != DBNull.Value ? dataReader["export_local_name"].ToString() : String.Empty,
            }); ;
        }
    }
}
