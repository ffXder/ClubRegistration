namespace ClubRegistration
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;
        public FrmClubRegistration()
        {
            InitializeComponent();
            DisplayComboBox();
        }

        private void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            gridViewMembers.DataSource = clubRegistrationQuery.bindingSource;
        }
        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();
        }


        private int RegistrationID()
        {
            return count++;
        }


        //display combobox items
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
            txtStudentId.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            cbGender.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
        }

        private bool ValidateStudentInfo()
        {
            if (!long.TryParse(txtStudentId.Text, out long studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid Age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // get the input text
            StudentId = Convert.ToInt32(txtStudentId.Text);
            FirstName = txtFirstName.Text.Trim();
            MiddleName = txtMiddleName.Text.Trim();
            LastName = txtLastName.Text.Trim();
            Age = Convert.ToInt32(txtAge.Text);
            Gender = cbGender.Text;
            Program = cbProgram.Text;

            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(MiddleName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(Program))
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // button events
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateStudentInfo()) return;

            ID = RegistrationID(); //create ID

            bool isRegistered = clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);

            if (isRegistered)
            {
                MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                RefreshListOfClubMembers();
            }
            else
            {
                MessageBox.Show("Failed to register student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdateMember = new FrmUpdateMember(clubRegistrationQuery, RefreshListOfClubMembers);
            frmUpdateMember.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }
    }
}
