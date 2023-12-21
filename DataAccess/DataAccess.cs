using Davis_FinalProject_Cs.Models.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class DataAccess
    {
        private readonly PCHRContext _context;

        public DataAccess(PCHRContext context)
        {
            _context = context;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// PATIENT DETAILS
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<PatientTbl> GetPatientByIdAsync(string id)
        {
            return await _context.PatientTbls.FindAsync(id);
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// EMERGENCY CONTACT DETAILS
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="emergencyContactData"></param>
        /// <returns></returns>
        public async Task AddOrUpdateEmergencyContactAsync(string patientId, EmergencyContactTbl emergencyContactData)
        {
            var emergencyContact = await _context.EmergencyContact.FirstOrDefaultAsync(e => e.PatientId == patientId);
            if (emergencyContact == null)
            {
                // Emergency contact does not exist, create a new one
                emergencyContact = new EmergencyContactTbl { PatientId = patientId };
                _context.EmergencyContact.Add(emergencyContact);
            }
            // Update emergency contact details
            emergencyContact.FirstName = emergencyContactData.FirstName;
            emergencyContact.LastName = emergencyContactData.LastName;
            emergencyContact.Relationship = emergencyContactData.Relationship;
            emergencyContact.AddressStreet = emergencyContactData.AddressStreet;
            emergencyContact.AddressCity = emergencyContactData.AddressCity;
            emergencyContact.AddressZip = emergencyContactData.AddressZip;
            emergencyContact.PhoneHome = emergencyContactData.PhoneHome;
            emergencyContact.PhoneMobile = emergencyContactData.PhoneMobile;
            emergencyContact.Email = emergencyContactData.Email;
            emergencyContact.AddressSuburb = emergencyContactData.AddressSuburb;

            await _context.SaveChangesAsync();
        }

        public async Task<EmergencyContactTbl> GetEmergencyContactByPatientIdAsync(string patientId)
        {
            return await _context.EmergencyContact.FirstOrDefaultAsync(ec => ec.PatientId == patientId);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// PRIMARY CARE PROVIDER DETAILS
        /// </summary>
        /// <param name="primaryId"></param>
        /// <param name="primaryCareData"></param>
        /// <returns></returns>
        public async Task AddOrUpdatePrimaryCareProviderAsync(PrimaryCareTbl primaryCareProviderData)
        {
            // Check if the primary care provider already exists in the database
            var existingProvider = await _context.PrimaryCareTbls
                .FindAsync(primaryCareProviderData.PrimaryCareProviderId);

            if (existingProvider != null)
            {
                // Update existing provider details
                _context.Entry(existingProvider).CurrentValues.SetValues(primaryCareProviderData);
            }
            else
            {
                // Add a new primary care provider
                _context.PrimaryCareTbls.Add(primaryCareProviderData);
            }

            // Save changes to the database
            await _context.SaveChangesAsync();
        }

        public async Task<PrimaryCareTbl> GetPrimaryCareProviderByIdAsync(string id)
        {
            return await _context.PrimaryCareTbls.FirstOrDefaultAsync(p => p.PrimaryCareProviderId == id);
        }

        public async Task<PrimaryCareTbl> GetPrimaryCareProviderByPatientIdAsync(string patientId)
        {
            return await _context.PrimaryCareTbls.FindAsync(patientId);
        }

        // Add this method to get medications by patient ID
        public async Task<List<MedicationTbl>> GetMedicationsByPatientIdAsync(string patientId)
        {
            return await _context.MedicationTbls
                                 .Where(m => m.PatientId == patientId)
                                 .ToListAsync();
        }

        // Implement the SaveAsync method to save changes to the database
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        // ... Other data access methods ...
    }
}
