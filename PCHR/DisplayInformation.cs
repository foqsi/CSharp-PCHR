using Davis_FinalProject_Cs.Models.DataLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davis_FinalProject_Cs.PCHR
{
    public partial class DisplayInformation
    {
        private readonly DataAccess _dataAccess;
        private readonly string _patientId;

        public DisplayInformation(DataAccess dataAccess, string patientId)
        {
            _dataAccess = dataAccess;
            _patientId = patientId;
        }

        public async Task LoadPersonalDetails()
        {
            
        }

        public async Task LoadContactDetails()
        {

        }

        public async Task LoadEmergencyContactDetails()
        {

        }

        public async Task LoadPrimaryCareProviderDetails()
        {

        }

        public async Task LoadHealthInsuranceDetails()
        {

        }

        public async Task LoadPersonalMedicalDetails()
        {

        }

        public async Task LoadAllergyDetails()
        {

        }

        public async Task LoadImmunizationDetails()
        {

        }

        public async Task LoadPrescribedMedicationDetails()
        {

        }

        public async Task LoadTestResultDetails()
        {

        }

        public async Task LoadMedicalConditionDetails()
        {

        }

        public async Task LoadMedicalProcedureDetails()
        {

        }

    }
}
