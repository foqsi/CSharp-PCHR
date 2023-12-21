using Davis_FinalProject_Cs.Models.DataLayer;
using System.Diagnostics;

namespace Davis_FinalProject_Cs.PCHR
{
    public partial class frmMainPCHR : Form
    {
        private readonly DataLayer.DataAccess _dataAccess;
        private readonly string _patientId;
        private readonly string _primaryId;

        public frmMainPCHR(string patientId)
        {
            InitializeComponent();
            this.Load += frmMainPCHR_Load;

            AttachLinkLabelHandlers();
            _patientId = patientId;
            _dataAccess = new DataLayer.DataAccess(new PCHRContext());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmMainPCHR_Load(object sender, EventArgs e)
        {
            try
            {
                // Use the _patientId field that was set in the constructor
                if (!string.IsNullOrEmpty(_patientId))
                {
                    PatientTbl patient = await _dataAccess.GetPatientByIdAsync(_patientId);
                    List<MedicationTbl> medications = await _dataAccess.GetMedicationsByPatientIdAsync(_patientId);

                    if (patient != null)
                    {
                        DisplayPatientDetails(patient);
                        await DisplayEmergencyContactDetailsAsync();

                        var emergencyContact = await _dataAccess.GetEmergencyContactByPatientIdAsync(_patientId);
                        if (emergencyContact != null)
                        {
                            SetTextBoxText(txtEmergencyContactDetailsName, emergencyContact.FirstName + " " + emergencyContact.LastName, "Name");
                            SetTextBoxText(txtEmergencyContactDetailsRelationship, emergencyContact.Relationship, "Relationship");
                            SetTextBoxText(txtEmergencyContactDetailsAddress, emergencyContact.AddressStreet, "Address");
                            SetTextBoxText(txtEmergencyContactDetailsSuburb, emergencyContact.AddressSuburb, "Suburb");
                            SetTextBoxText(txtEmergencyContactDetailsCity, emergencyContact.AddressCity, "City");
                            SetTextBoxText(txtEmergencyContactDetailsPostalCode, emergencyContact.AddressZip, "Postal code");
                            SetTextBoxText(txtEmergencyContactDetailsHomePhone, emergencyContact.PhoneHome, "Home phone");
                            SetTextBoxText(txtEmergencyContactDetailsMobilePhone, emergencyContact.PhoneMobile, "Mobile phone");
                            SetTextBoxText(txtEmergencyContactDetailsWorkPhone, emergencyContact.PhoneWork, "Work phone");
                            SetTextBoxText(txtEmergencyContactDetailsFax, emergencyContact.Fax, "Fax");
                            SetTextBoxText(txtEmergencyContactDetailsEmail, emergencyContact.Email, "Email");
                        }
                        else
                        {
                            MessageBox.Show("No emergency contact details available.");
                        }


                        // Primary care provider details
                        var primaryCareProvider = await _dataAccess.GetPrimaryCareProviderByIdAsync(patient.PrimaryCareProviderId);
                        if (primaryCareProvider != null)
                        {
                            DisplayPrimaryCareProviderDetails(primaryCareProvider);
                        }
                        else
                        {
                            txtPrimaryCareDetailsFullName.Text = "No Primary Care Provider.";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Patient not found.");
                    }

                    if (medications != null)
                    {
                        // Populate medications
                        lstMedicationsList.Items.Clear();
                        foreach (var medication in medications)
                        {
                            lstMedicationsList.Items.Add(medication.Medication);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No patient ID is provided.");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async void DisplayPatientDetails(PatientTbl patient)
        {
            //SetTextBoxText(txtUsername, , "Username");
            SetTextBoxText(txtIdentityNumber, patient.PatientId, "Identity Number");
            SetTextBoxText(txtPersonalDetailsFirstName, patient.FirstName, "First Name");
            SetTextBoxText(txtPersonalDetailsLastName, patient.LastName, "Last Name");
            SetTextBoxText(txtPersonalDetailsInitials, patient.Initials, "Initials");
            cmbPersonalDetailsTitle.Text = patient.Title;
            dtpDateOfBirth.Value = patient.DateOfBirth.Value.ToDateTime(new TimeOnly());

            //Patient contact details
            SetTextBoxText(txtContactDetailsAddress, patient.AddressStreet, "Address");
            SetTextBoxText(txtContactDetailsCity, patient.AddressCity, "City");
            SetTextBoxText(txtContactDetailsPostalCode, patient.AddressZip, "Postal code");
            SetTextBoxText(txtContactDetailsHomePhone, patient.PhoneHome, "Home phone");
            SetTextBoxText(txtContactDetailsMobilePhone, patient.PhoneMobile, "Mobile phone");
            SetTextBoxText(txtContactDetailsEmail, patient.Email, "Email");
        }

        private async Task DisplayEmergencyContactDetailsAsync()
        {
            var emergencyContact = await _dataAccess.GetEmergencyContactByPatientIdAsync(_patientId);
            if (emergencyContact != null)
            {
                SetTextBoxText(txtEmergencyContactDetailsName, emergencyContact.FirstName + " " + emergencyContact.LastName, "Name");
                SetTextBoxText(txtEmergencyContactDetailsRelationship, emergencyContact.Relationship, "Relationship");
                SetTextBoxText(txtEmergencyContactDetailsAddress, emergencyContact.AddressStreet, "Address");
                SetTextBoxText(txtEmergencyContactDetailsSuburb, emergencyContact.AddressSuburb, "Suburb");
                SetTextBoxText(txtEmergencyContactDetailsCity, emergencyContact.AddressCity, "City");
                SetTextBoxText(txtEmergencyContactDetailsPostalCode, emergencyContact.AddressZip, "Postal code");
                SetTextBoxText(txtEmergencyContactDetailsHomePhone, emergencyContact.PhoneHome, "Home phone");
                SetTextBoxText(txtEmergencyContactDetailsMobilePhone, emergencyContact.PhoneMobile, "Mobile phone");
                SetTextBoxText(txtEmergencyContactDetailsWorkPhone, emergencyContact.PhoneWork, "Work phone");
                SetTextBoxText(txtEmergencyContactDetailsFax, emergencyContact.Fax, "Fax");
                SetTextBoxText(txtEmergencyContactDetailsEmail, emergencyContact.Email, "Email");
            }
            else
            {
                MessageBox.Show("No emergency contact details available.");
            }
        }
        private async void DisplayPrimaryCareProviderDetails(PrimaryCareTbl primaryCareProvider)
        {
            SetTextBoxText(txtPrimaryCareDetailsPrimaryId, primaryCareProvider.PrimaryId, "Primary ID");
            SetTextBoxText(txtPrimaryCareDetailsFullName, primaryCareProvider.NameFisrt + " " + primaryCareProvider.NameLast, "Name");
            SetTextBoxText(txtPrimaryCareDetailsSpecialty, primaryCareProvider.Specialty, "Specialty");
            SetTextBoxText(txtPrimaryCareDetailsMobilePhone, primaryCareProvider.PhoneMobile, "Mobile phone");
            SetTextBoxText(txtPrimaryCareDetailsWorkPhone, primaryCareProvider.PhoneOffice, "Office phone");
        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current user: " + _patientId);
        }

        private void SetTextBoxText(TextBox textBox, string value, string fieldName)
        {
            try
            {
                if (value != null)
                {
                    textBox.Text = value;
                }
                else
                {
                    textBox.Text = string.Empty;
                    Debug.WriteLine($"Warning: The value for {fieldName} is null.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred setting the text for {fieldName}: {ex.Message}");
            }
        }
    }
}
