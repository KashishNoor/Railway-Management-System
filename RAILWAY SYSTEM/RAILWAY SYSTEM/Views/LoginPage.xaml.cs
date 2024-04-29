using System.Data;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Oracle.ManagedDataAccess.Client;
using RAILWAY_SYSTEM.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class LoginPage : Page
{
    OracleConnection con;
    public LoginViewModel ViewModel
    {
        get;
    }

    public LoginPage()
    {
        ViewModel = App.GetService<LoginViewModel>();
        InitializeComponent();
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID = SHISH; PASSWORD = 1234";  // Adjust credentials as needed
        con = new OracleConnection(conStr);
    }

    private void Login_Click(object sender, RoutedEventArgs e)
    {
        // Ensure the Oracle connection is open
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        // Prepare a parameterized query to check if the user exists
        OracleCommand checkUser = new OracleCommand(
            "SELECT user_type FROM (SELECT 'Passenger' AS user_type FROM Passenger WHERE NAME = :username AND PASSWORD = :password " +
            "UNION SELECT 'Employee1' AS user_type FROM Employee1 WHERE NAME = :username AND PASSWORD = :password)",
            con
        );

        checkUser.CommandType = CommandType.Text;

        // Add parameter values
        checkUser.Parameters.Add(":username", OracleDbType.Varchar2).Value = userText.Text;  // Username input
        checkUser.Parameters.Add(":password", OracleDbType.Varchar2).Value = passText.Password;  // Password input

        // Execute the query and check if a record is returned
        OracleDataReader reader = checkUser.ExecuteReader();

        if (reader.Read())  // If a record is found, login is successful
        {
            Error.IsOpen = false;                     
                                   
        }
        else  // If no record is found, display the error message
        {
            Error.IsOpen = true;  // Show the teaching tip with an error message
        }
        con.Close();
    }

}

