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

        // Define the Oracle connection string
        string conStr = @"DATA SOURCE=localhost:1521/XE; USER ID=SHISH; PASSWORD=1234";
        con = new OracleConnection(conStr);  // Initialize Oracle connection
    }

    private void Signup_Click(object sender, RoutedEventArgs e)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();  // Open the Oracle connection
        }
        // Check if the selected type is "Passenger"
        if (type.Content.ToString() == "Passenger")
        {
            con.Open();  // Open the Oracle connection

            // Prepare the parameterized OracleCommand for the Passenger table
            OracleCommand insertAtt = new OracleCommand(
                "INSERT INTO Passenger (PASSENGER_ID, NAME, EMAIL, PASSWORD, PHONE) VALUES (:passenger_id, :name, :email, :password, :phone)",
                con
            );

            insertAtt.CommandType = CommandType.Text;

            // Add parameter values for Passenger insertion
            insertAtt.Parameters.Add(":passenger_id", OracleDbType.Varchar2).Value = GenerateUniquePassengerId();
            insertAtt.Parameters.Add(":name", OracleDbType.Varchar2).Value = userText1.Text;
            insertAtt.Parameters.Add(":email", OracleDbType.Varchar2).Value = userMail.Text;
            insertAtt.Parameters.Add(":password", OracleDbType.Varchar2).Value = Pass.Password;
            insertAtt.Parameters.Add(":phone", OracleDbType.Varchar2).Value = userText1.Text;

            insertAtt.ExecuteNonQuery(); 

            con.Close();  

            return;  
        }
        else  // Insert into Employee1 if the type is not "Passenger"
        {
            con.Open();  // Open the connection

            // Prepare the parameterized OracleCommand for Employee1 table
            OracleCommand insertAtt = new OracleCommand(
                "INSERT INTO Employee (EID, NAME, ROLE, EMAIL, PHONE) VALUES (:eid, :name, :role, :email, :phone)",
                con
            );

            insertAtt.CommandType = CommandType.Text;

            // Add parameter values for Employee1 insertion
            insertAtt.Parameters.Add(":eid", OracleDbType.Varchar2).Value = GenerateUniqueEmployeeId();
            insertAtt.Parameters.Add(":name", OracleDbType.Varchar2).Value = userText1.Text;
            insertAtt.Parameters.Add(":role", OracleDbType.Varchar2).Value = "Employee";  // Adjust role as needed
            insertAtt.Parameters.Add(":email", OracleDbType.Varchar2).Value = userMail.Text;
            insertAtt.Parameters.Add(":phone", OracleDbType.Varchar2).Value = userText1.Text;

            insertAtt.ExecuteNonQuery();  // Execute the query

            con.Close();  // Close the connection
        }
    }

    private void P_Click(object sender, RoutedEventArgs e)
    {
        type.Content = "Passenger";  // Set the type to Passenger when clicked
    }

    private void E_Click(object sender, RoutedEventArgs e)
    {
        type.Content = "Employee";  // Set the type to Employee when clicked
    }

    private string GenerateUniquePassengerId()
    {
        // Example implementation to generate a unique passenger ID
        return new Random().Next(1000, 9999).ToString();  // Ensure uniqueness
    }

    private string GenerateUniqueEmployeeId()
    {
        // Example implementation to generate a unique employee ID
        return new Random().Next(1000, 9999).ToString();  // Ensure uniqueness
    }
}
