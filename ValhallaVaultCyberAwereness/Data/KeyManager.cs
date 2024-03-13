using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace ValhallaVaultCyberAwereness.Data
{
    public static class KeyManager
    {
        private static string keyVaultName = "vvcs-kv";

        public static async Task<string> GetConnectionString()
        {
            var kvUri = "https://" + keyVaultName + ".vault.azure.net";

            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());

            var secret = await client.GetSecretAsync("connectionstring");

            if (secret != null && !string.IsNullOrEmpty(secret.Value.ToString()))
            {
                return secret.Value.ToString();
            }

            throw new Exception("No key found!");
        }
    }
}
