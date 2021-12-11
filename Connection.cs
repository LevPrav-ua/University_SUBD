using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

public static class Connection
{
    public static Database db ;
    public static User user;
    public static NpgsqlConnection connection;

	static public bool connect()  
    {
        if(user.type != user.name)
        {
            Console.WriteLine("User.name != User.type_name");
            return false;
        }
        string connString = String.Format("Server={0};" +
                "Port={1};" +
                "Username={2};" +
                "Password={3};" +
                "Database={4}", db.Server, db.Port, user.name, user.password,
                db.database);
        connection = new NpgsqlConnection(connString);
        try
        {
            //Открываем соединение.
            connection.Open();
            if (connection.FullState == ConnectionState.Broken)
            {
                throw new Exception("Connection broken");
                //Тут меняем что-то в своей жизни, но я обычно выбрасываю исключение, чтобы не искать в коде миллион лет, что сломалось.
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
        return true; 
    }

    public static NpgsqlDataAdapter request_adapter(string sql)
    {
        return new NpgsqlDataAdapter(sql, Connection.connection);
    }
    public static NpgsqlDataReader request_reader(string sql)
    {
        NpgsqlCommand npgc = new NpgsqlCommand(sql, connection);
        NpgsqlDataReader reader = npgc.ExecuteReader();
        return reader;
    }

    static public void error(string error_message)
    {
        MessageBox.Show(
           error_message,
            "Сообщение",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
    }
}
