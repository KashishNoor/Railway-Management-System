using System.Data;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using Oracle.ManagedDataAccess.Client;
using RAILWAY_SYSTEM.ViewModels;

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
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID = ABC; PASSWORD = 3119";
        con = new OracleConnection(conStr);
    }

    private void Signup_Click(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(AdminPage));
        con.Open();
        OracleCommand insertAtt = con.CreateCommand();
        insertAtt.CommandType = CommandType.Text;
        insertAtt.CommandText = "INSERT INTO PASSENGER VALUES('" +
        userText.Text.ToString() + "','" +
        userMail.Text.ToString() + "','" +
        passText.Password.ToString() + " ')";
        insertAtt.ExecuteNonQuery();
        con.Close();
    }

    private void P_Click(object sender, RoutedEventArgs e)
    {
    }

    private void E_Click(object sender, RoutedEventArgs e)
    {
    }
}
