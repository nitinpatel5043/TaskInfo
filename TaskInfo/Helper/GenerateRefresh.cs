using System.Security.Cryptography;

namespace TaskInfo.Helper
{
    public static class GenerateRefresh
    {
        // It creates a referesh token for us
        public static string GenerateRefreshToken()
        {
            byte[] randomNumber = new byte[64];
            RandomNumberGenerator rng = RandomNumberGenerator.Create();

            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);

        }
    }
}
