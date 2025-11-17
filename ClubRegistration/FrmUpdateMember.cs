using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private Action refreshGridAction;

        private long StudentId;
        private int Age;
        private string FirstName, MiddleName, LastName, Gender, Program;

        public FrmUpdateMember(ClubRegistrationQuery query, Action refreshAction)
        {
            InitializeComponent();
            clubRegistrationQuery = query;
            refreshGridAction = refreshAction;
            DisplayComboBox();

        }
        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            PopulateStudentId();
            //cbStudentId.Enabled = true;
        }

        private void PopulateStudentId()
        {
            DataTable membersTable = clubRegistrationQuery.dataTable;
            cbStudentId.DataSource = membersTable;
            cbStudentId.DisplayMember = "StudentId";
            cbStudentId.ValueMember = "StudentId";
            cbStudentId.SelectedIndex = -1;
        }
        private void DisplayComboBox()
        {
            string[] listOfPrograms = {
                "BS in Information Technology",
                "BS in Computer Science",
                "BS in Tourism Management",
                "BS in Hospitality Management",
                "BS in Computer Engineering" };

            cbProgram.Items.AddRange(listOfPrograms);

            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
        }

        private void ClearInputFields()
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            cbGender.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
        }

        private void cbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudentId.SelectedIndex == -1 || cbStudentId.SelectedValue == null)
            {
                ClearInputFields();
                return;
            }

            if (long.TryParse(cbStudentId.SelectedValue.ToString(), out StudentId))
            {
                // Populate fields with current member info
                txtFirstName.Text = clubRegistrationQuery._FirstName;
                txtMiddleName.Text = clubRegistrationQuery._MiddleName;
                txtLastName.Text = clubRegistrationQuery._LastName;
                txtAge.Text = clubRegistrationQuery._Age.ToString();
                cbGender.Text = clubRegistrationQuery._Gender;
                cbProgram.Text = clubRegistrationQuery._Program;
            }
            else
            {
                MessageBox.Show("Please select a valid Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputFields();
            }

            if (!clubRegistrationQuery.GetMemberInfo(StudentId))
            {
                MessageBox.Show("Error retrieving member information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputFields();
                return;
            }


        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (cbStudentId.SelectedValue == null || cbStudentId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(cbStudentId.SelectedValue.ToString(), out StudentId))
            {
                MessageBox.Show("Please select a valid Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtAge.Text, out Age))
            {
                MessageBox.Show("Please enter a valid Age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //get all input text
            FirstName = txtFirstName.Text.Trim();
            MiddleName = txtMiddleName.Text.Trim();
            LastName = txtLastName.Text.Trim();
            Gender = cbGender.Text;
            Program = cbProgram.Text;

            //validates if null or empty
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(MiddleName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(Program))
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clubRegistrationQuery.UpdateMember(StudentId, FirstName, MiddleName, LastName, Age, Gender, Program))
            {
                MessageBox.Show("Member information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();

                refreshGridAction?.Invoke();

                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating member information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
