using System.IO;
using System.Text;

namespace Davis_FinalProject_Cs
{
    public class AuthenticationResult
    {
        public bool IsAuthenticated { get; set; }
        public string PatientId { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class Authentication
    {
        public AuthenticationResult ValidateCredentials(string username, string password)
        {
            string credentialsPath = "..\\..\\auth.txt";
            string[] lines = File.ReadAllLines(credentialsPath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string storedUsername = parts[0].Trim();
                    string storedPasswordHash = parts[1].Trim();
                    string patientId = parts[2].Trim();
                    string enteredPasswordHash = HashUtility.HashPassword(password);

                    if (string.Equals(storedUsername, username, StringComparison.OrdinalIgnoreCase) &&
                        string.Equals(storedPasswordHash, enteredPasswordHash))
                    {
                        return new AuthenticationResult
                        {
                            IsAuthenticated = true,
                            PatientId = patientId
                        };
                    }
                }
            }

            return new AuthenticationResult
            {
                IsAuthenticated = false,
                ErrorMessage = "Invalid username or password."
            };
        }

        public static class HashUtility
        {
            public static string HashPassword(string password)
            {
                using (var sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(password);
                    byte[] hash = sha256.ComputeHash(bytes);
                    return Convert.ToBase64String(hash);
                }
            }
        }
    }
}