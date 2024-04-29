using System.Data;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using Oracle.ManagedDataAccess.Client;
using RAILWAY_SYSTEM.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RAILWAY_SYSTEM.Views;

public sealed partial class SignupPage : Page
{
    OracleConnection con;
    public SignupViewModel ViewModel
    {
        get;
    }

    public SignupPage()
    {
        ViewModel = App.GetService<SignupViewModel>();
        InitializeComponent();
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID = SHISH; PASSWORD = 1234";
        con = new OracleConnection(conStr);

        
    }

    private void Signup_Click(object sender, RoutedEventArgs e)
    {
        //Frame.Navigate(typeof(AdminPage));
        OracleCommand insertAtt = con.CreateCommand();
        if (type.Content == "Passenger")
        {
            con.Open();
            insertAtt.CommandType = CommandType.Text;
            insertAtt.CommandText = "INSERT INTO Passenger VALUES('" +
            userText1.Text.ToString() + "\', \'" +
            userText.Text.ToString() + "\', \'" +
            userMail.Text.ToString() + "\', \'" +
            Pass.Password.ToString() + "\')";
            insertAtt.ExecuteNonQuery();
            con.Close();
            return;
        }

        con.Open();
        insertAtt.CommandType = CommandType.Text;
        insertAtt.CommandText = "INSERT INTO Passenger VALUES('" +
        userText1.Text.ToString() + "\', '" +
        userText.Text.ToString() + "\', '" +
        userMail.Text.ToString() + "\', '" +
        Pass.Password.ToString() + "\')";
        insertAtt.ExecuteNonQuery();
        con.Close();


    }
    private void P_Click(object sender, RoutedEventArgs e)
    {
        type.Content = "Passenger";
    }

    private void E_Click(object sender, RoutedEventArgs e)
    {
        type.Content = "Employee";
    }
}


