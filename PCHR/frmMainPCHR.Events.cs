using Davis_FinalProject_Cs.Models.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace Davis_FinalProject_Cs.PCHR
{
    public partial class frmMainPCHR
    {
        // Event handlers for the link labels
        private async void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var linkLabel = sender as LinkLabel;
            if (linkLabel != null)
            {
                // Extract the action (Save, Edit, Cancel) and group (PersonalDetails, ContactDetails) from the lnk's name
                string groupName = linkLabel.Name.Replace("lnk", "").Replace("Save", "").Replace("Edit", "").Replace("Cancel", "");
                string action = linkLabel.Name.Substring(linkLabel.Name.Length - 4);

                // Find the corresponding group box control
                GroupBox groupBox = this.Controls.Find("grp" + groupName, true).FirstOrDefault() as GroupBox;

                if (groupBox != null)
                {
                    // Determine the enable state based on the action
                    bool enable = action.Equals("Edit", StringComparison.OrdinalIgnoreCase);
                    ToggleControls(groupBox, enable);
                }

                if (action.Equals("Save", StringComparison.OrdinalIgnoreCase))
                {
                    // Call a method to save the data to the database
                    await SavePatientData(groupName);
                }
            }
        }

        // Enable/disable controls in a group box
        private void ToggleControls(Control parentControl, bool enable)
        {
            foreach (Control control in parentControl.Controls)
            {
                // If the control is a nested GroupBox, recursively toggle children
                if (control is GroupBox)
                {
                    ToggleControls(control, enable);
                }
                else if (control is TextBox || control is DateTimePicker || control is CheckBox || control is ComboBox)
                {
                    control.Enabled = enable;
                    // Set the background color for TextBox and DateTimePicker
                    if (control is TextBox || control is DateTimePicker || control is ComboBox)
                    {
                        control.BackColor = enable ? Color.LightYellow : SystemColors.Control;
                    }
                }
                else if (control is RadioButton)
                {
                    control.Enabled = enable;
                }
            }
        }

        private async Task SavePatientData(string groupName)
        {
            try
            {
                // Retrieve the patient from the database
                var patient = await _dataAccess.GetPatientByIdAsync(_patientId);
                if (patient == null)
                {
                    MessageBox.Show("Patient not found.");
                    return;
                }

                // Update the patient entity with the data from the form controls
                switch (groupName)
                {
                    case "PersonalDetails":
                        patient.FirstName = txtPersonalDetailsFirstName.Text;
                        patient.LastName = txtPersonalDetailsLastName.Text;
                        patient.Email = txtContactDetailsEmail.Text;
                        patient.Title = cmbPersonalDetailsTitle.Text;
                        patient.Initials = txtPersonalDetailsInitials.Text;
                        patient.DateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
                        break;

                    case "ContactDetails":
                        patient.AddressStreet = txtContactDetailsAddress.Text;
                        patient.AddressCity = txtContactDetailsCity.Text;
                        patient.AddressZip = txtContactDetailsPostalCode.Text;
                        patient.PhoneHome = txtContactDetailsHomePhone.Text;
                        patient.PhoneMobile = txtContactDetailsMobilePhone.Text;
                        patient.Email = txtContactDetailsEmail.Text;
                        break;

                    case "EmergencyContactDetails":
                        var emergencyContactData = new EmergencyContactTbl
                        {
                            FirstName = txtEmergencyContactDetailsName.Text.Split(' ')[0],
                            LastName = txtEmergencyContactDetailsName.Text.Split(' ').Length > 1 ?
                                                txtEmergencyContactDetailsName.Text.Split(' ')[1] : "",
                            Relationship = txtEmergencyContactDetailsRelationship.Text,
                            AddressStreet = txtEmergencyContactDetailsAddress.Text,
                            AddressSuburb = txtEmergencyContactDetailsSuburb.Text,
                            AddressCity = txtEmergencyContactDetailsCity.Text,
                            AddressZip = txtEmergencyContactDetailsPostalCode.Text,
                            PhoneHome = txtEmergencyContactDetailsHomePhone.Text,
                            PhoneMobile = txtEmergencyContactDetailsMobilePhone.Text,
                            PhoneWork = txtEmergencyContactDetailsWorkPhone.Text,
                            Fax = txtEmergencyContactDetailsFax.Text,
                            Email = txtEmergencyContactDetailsEmail.Text
                        };
                        await _dataAccess.AddOrUpdateEmergencyContactAsync(_patientId, emergencyContactData);
                        break;

                    case "PrimaryCareProviderDetails":
                        var primaryCareProviderData = new PrimaryCareTbl
                        {
                            //PrimaryCareProviderId = txtPrimaryCareDetailsPrimaryId.Text,
                            PrimaryId = txtPrimaryCareDetailsPrimaryId.Text,
                            NameFisrt = txtPrimaryCareDetailsFullName.Text.Split(' ')[0],
                            NameLast = txtPrimaryCareDetailsFullName.Text.Split(' ').Length > 1 ?
                                                txtPrimaryCareDetailsFullName.Text.Split(' ')[1] : "",
                            Specialty = txtPrimaryCareDetailsSpecialty.Text,
                            PhoneMobile = txtPrimaryCareDetailsMobilePhone.Text,
                            PhoneOffice = txtPrimaryCareDetailsWorkPhone.Text
                        };
                        await _dataAccess.AddOrUpdatePrimaryCareProviderAsync(primaryCareProviderData);

                        break;


                    case "HealthInsuranceDetails":

                        break;

                    case "PersonalMedicalDetails":

                        break;

                    case "AllergyDetails":

                        break;

                    case "ImmunizationDetails":

                        break;

                    case "PrescribedMedicationDetails":

                        break;

                    case "TestResultDetails":

                        break;

                    case "MedicalConditionDetails":

                        break;

                    case "MedicalProcedureDetails":

                        break;

                }

                // Save the changes to the database
                await _dataAccess.SaveAsync();

                MessageBox.Show("Patient data saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}");
            }
        }

        // Attach the event handlers to the link labels
        public void AttachLinkLabelHandlers()
        {
            lnkPersonalDetailsSave.LinkClicked += LinkClicked;
            lnkPersonalDetailsEdit.LinkClicked += LinkClicked;
            lnkPersonalDetailsCancel.LinkClicked += LinkClicked;
            lnkContactDetailsSave.LinkClicked += LinkClicked;
            lnkContactDetailsEdit.LinkClicked += LinkClicked;
            lnkContactDetailsCancel.LinkClicked += LinkClicked;
            lnkEmergencyContactDetailsSave.LinkClicked += LinkClicked;
            lnkEmergencyContactDetailsEdit.LinkClicked += LinkClicked;
            lnkEmergencyContactDetailsCancel.LinkClicked += LinkClicked;
            lnkPrimaryCareProviderDetailsSave.LinkClicked += LinkClicked;
            lnkPrimaryCareProviderDetailsEdit.LinkClicked += LinkClicked;
            lnkPrimaryCareProviderDetailsCancel.LinkClicked += LinkClicked;
            lnkHealthInsuranceDetailsSave.LinkClicked += LinkClicked;
            lnkHealthInsuranceDetailsEdit.LinkClicked += LinkClicked;
            lnkHealthInsuranceDetailsCancel.LinkClicked += LinkClicked;
            lnkPersonalMedicalDetailsSave.LinkClicked += LinkClicked;
            lnkPersonalMedicalDetailsEdit.LinkClicked += LinkClicked;
            lnkPersonalMedicalDetailsCancel.LinkClicked += LinkClicked;
            lnkAllergyDetailsSave.LinkClicked += LinkClicked;
            lnkAllergyDetailsEdit.LinkClicked += LinkClicked;
            lnkAllergyDetailsCancel.LinkClicked += LinkClicked;
            lnkImmunizationDetailsSave.LinkClicked += LinkClicked;
            lnkImmunizationDetailsEdit.LinkClicked += LinkClicked;
            lnkImmunizationDetailsCancel.LinkClicked += LinkClicked;
            lnkPrescribedMedicationDetailsSave.LinkClicked += LinkClicked;
            lnkPrescribedMedicationDetailsEdit.LinkClicked += LinkClicked;
            lnkPrescribedMedicationDetailsCancel.LinkClicked += LinkClicked;
            lnkTestResultDetailsSave.LinkClicked += LinkClicked;
            lnkTestResultDetailsEdit.LinkClicked += LinkClicked;
            lnkTestResultDetailsCancel.LinkClicked += LinkClicked;
            lnkMedicalConditionDetailsSave.LinkClicked += LinkClicked;
            lnkMedicalConditionDetailsEdit.LinkClicked += LinkClicked;
            lnkMedicalConditionDetailsCancel.LinkClicked += LinkClicked;
            lnkMedicalProcedureDetailsSave.LinkClicked += LinkClicked;
            lnkMedicalProcedureDetailsEdit.LinkClicked += LinkClicked;
            lnkMedicalProcedureDetailsCancel.LinkClicked += LinkClicked;
        }
    }
}