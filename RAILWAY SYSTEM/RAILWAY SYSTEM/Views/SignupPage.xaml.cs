using System.Data;
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
        string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID = ABC; PASSWORD = 5656";
        con = new OracleConnection(conStr);

        con.Open();
        OracleCommand getStd = con.CreateCommand();
        getStd.CommandText = "SELECT * From emp";
        getStd.CommandType = CommandType.Text;
        OracleDataReader StdDR = getStd.ExecuteReader();

        while (StdDR.Read())
        {
        }
        StdDR.Close();
        con.Close();
    }
}
