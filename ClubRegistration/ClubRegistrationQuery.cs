using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Dynamic;
using Microsoft.Identity.Client;

namespace ClubRegistration
{
    public class ClubRegistrationQuery
    {
        // initalizing SQL variables connection
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;

        // connection string variable
        private string connectionString;
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
            // set connection string
            connectionString = @"Data Source=LAPTOP-NHOM4IUH\SQLEXPRESS;Initial Catalog=ClubDB;Integrated Security=True";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList()
        {
            try
            {
                string ViewClubMembers = "SELECT StudentId, FirstName, LastName, Age, Gender, Program FROM ClubMembers";
                sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);

                dataTable.Clear();
                sqlAdapter.Fill(dataTable);
                bindingSource.DataSource = dataTable;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying club members: " + ex.Message);
                return false;
            }
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string
        MiddleName, string LastName, int Age, string Gender, string Program)
        {
            try
            {
                string insertQuery = "INSERT INTO ClubMembers VALUES(@ID, @StudentId, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)";
                sqlCommand = new SqlCommand(insertQuery, sqlConnect);
                
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                sqlCommand.Parameters.Add("@StudentId", SqlDbType.BigInt).Value = StudentID;
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
                sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering student: " + ex.Message);
                return false;
            }
        }

        public DataTable RetrieveStudentIDs()
        {
            DataTable retrieveStudentIDs = new DataTable();
            try
            {
                string selectQuery = "SELECT StudentID FROM ClubMembers";
                sqlAdapter = new SqlDataAdapter(selectQuery, sqlConnect);
                sqlAdapter.Fill(retrieveStudentIDs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student IDs: " + ex.Message);
            }
            return retrieveStudentIDs;
        }

        public bool GetMemberInfo(long studentId)
        {
            try
            {
                string selectQuery = "SELECT FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentID = @StudentId";
                sqlCommand = new SqlCommand(selectQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@StudentId", studentId);

                sqlConnect.Open();
                sqlReader = sqlCommand.ExecuteReader();

                if (!sqlReader.Read())
                {
                    return false;
                }

                _FirstName = sqlReader["FirstName"].ToString();
                _MiddleName = sqlReader["MiddleName"].ToString();
                _LastName = sqlReader["LastName"].ToString();
                _Age = Convert.ToInt32(sqlReader["Age"]);
                _Gender = sqlReader["Gender"].ToString();
                _Program = sqlReader["Program"].ToString();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving member info: " + ex.Message);
                return false;
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
                sqlConnect.Close();
            }
        }
        public bool UpdateMember(long StudentId, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            try
            {
                string updateQuery = "UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program WHERE StudentId = @StudentId";
                sqlCommand = new SqlCommand(updateQuery, sqlConnect);

                sqlCommand.Parameters.Add("@StudentId", SqlDbType.BigInt).Value = StudentId;
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
                sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

                sqlConnect.Open();
                int rowAffected = sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                return rowAffected > 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating member info: " + ex.Message);
                sqlConnect.Close();
                return false;
            }
        }
    }
}
