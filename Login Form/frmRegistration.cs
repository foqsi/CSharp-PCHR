using Davis_FinalProject_Cs.Models.DataLayer;
using System.Text;

namespace Davis_FinalProject_Cs.Login_Form
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            string identityNumber = txtIdentityNumber.Text;
            //string title = cmbTitle.SelectedItem.ToString();
            string initials = txtInitials.Text;
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            DateOnly dateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value.Date);
            

            // Required fields
            if (!isTextBoxFilled(txtUsername) || !isTextBoxFilled(txtPassword) || !isTextBoxFilled(txtConfirmPassword))
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            // Hash the password before storing it
            string hashedPassword = HashPassword(password);

            // The path to the credentials file
            string credentialsPath = "..\\..\\auth.txt";

            try
            {
                // Write credentials to file
                using (StreamWriter sw = File.AppendText(credentialsPath))
                {
                    sw.WriteLine($"{username},{hashedPassword},{identityNumber}");
                }

                // Create a new patient object
                PatientTbl newPatient = new PatientTbl
                {
                    PatientId = identityNumber,
                    LastName = lastName,
                    FirstName = firstName,
                    DateOfBirth = dateOfBirth,
                };

                // Insert the new patient into the db
                using (var context = new PCHRContext())
                {
                    context.PatientTbls.Add(newPatient);
                    context.SaveChanges();
                }

                // Show success message if both operations are successful
                MessageBox.Show("User account created and patient record added successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to register user. Error: {ex.Message}");
            }
        }

        private string HashPassword(string password)
        {
            // simple hash
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }

        private bool isTextBoxFilled(TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
