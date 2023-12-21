using Davis_FinalProject_Cs.PCHR;

namespace Davis_FinalProject_Cs
{
    public class LoginController
    {
        private readonly Authentication _authentication;

        public LoginController()
        {
            _authentication = new Authentication();
        }

        public void PerformLogin(string username, string password, Form callingForm)
        {
            var result = _authentication.ValidateCredentials(username, password);

            if (result.IsAuthenticated)
            {
                frmMainPCHR mainPCHR = new frmMainPCHR(result.PatientId);
                callingForm.Hide();
                mainPCHR.ShowDialog();
                callingForm.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        // Other methods like ShowAboutForm, ShowRegistrationForm, etc.
    }
}
