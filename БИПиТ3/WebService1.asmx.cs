using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Data;

namespace БИПиТ3
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //Data Source = DESKTOP - M0UINHO\SQLSERVER;Initial Catalog = adverst; Integrated Security = True
        public static string connectionString = @"workstation id = AdverstDataBase.mssql.somee.com; packet size = 4096; user id = Pororo_SQLLogin_1; pwd=zkuy1ecq38;data source = AdverstDataBase.mssql.somee.com; persist security info=False;initial catalog = AdverstDataBase";
        public SqlConnection sqlConnection = new SqlConnection(connectionString);
        [WebMethod]
        public DataSet GetRecords()
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT IdO, Client, Service, Time, FORMAT(Price, 'C0') as Price, " +
                "FORMAT(Total, 'C0') as Total, FORMAT (Date, 'dd.MM.yyyy') as Date FROM [OrderView]", connectionString);
            DataSet orders = new DataSet();
            adapter.Fill(orders);
            sqlConnection.Close();
            return orders;
        }

        public DataSet Clients()
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT IdC, Client FROM [Client]", connectionString);
            DataSet clients = new DataSet();
            adapter.Fill(clients);
            sqlConnection.Close();
            return clients;
        }
        public DataSet Service()
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT IdS, Service FROM [Service]", connectionString);
            DataSet service = new DataSet();
            adapter.Fill(service);
            sqlConnection.Close();
            return service;
        }

        public void NewRec(int IdC,int IdS, int Time, DateTime Date)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO[Order] (IdC_FK, IdS_FK, Time, Date) VALUES (@IdC_FK, @IdS_FK, @Time, @Date)", sqlConnection);
            command.Parameters.AddWithValue("IdC_FK", IdC);
            command.Parameters.AddWithValue("IdS_FK", IdS);
            command.Parameters.AddWithValue("Time", Time);
            command.Parameters.AddWithValue("Date", Date);
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeleteRec(int orderID)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM[Order] WHERE [IdO] = @IdO", sqlConnection);
            command.Parameters.AddWithValue("IdO", orderID);
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public List<string> GetData(string dateBegin, string dateEnd)
        {
            List<string> rowsID = new List<string>();
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM[Order] WHERE [Date] NOT BETWEEN @dateBegin and @dateEnd", sqlConnection);
            command.Parameters.AddWithValue("dateBegin", dateBegin);
            command.Parameters.AddWithValue("dateEnd", dateEnd);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                rowsID.Add((String.Format("{0}", reader[0])));
            }
            sqlConnection.Close();
            return rowsID;
        }

    }
}
