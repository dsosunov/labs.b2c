
namespace Labs.Apps.B2C
{
    public static class Constants
    {
        private static readonly string _tenantName = "labsdev";

        private static readonly string _tenantId = $"{_tenantName}.onmicrosoft.com";

        private static readonly string _policySignin = "B2C_1_Dealer_SignUp_SIgnIn";

        private static readonly string _policyPassword = "B2C_1_PasswordReset";

        // set to a unique value for your app, such as your bundle identifier. Used on iOS to share keychain access.

        private static readonly string AuthorityBase = $"https://{_tenantName}.b2clogin.com/tfp/{_tenantId}/";

        public static string ClientId { get; } = "d11464ff-1b0e-4034-b2f3-5cf0a8554e84";

        public static string AuthoritySignin => $"{AuthorityBase}{_policySignin}";
        
        public static string AuthorityPasswordReset => $"{AuthorityBase}{_policyPassword}";
        
        public static string[] Scopes { get; } = { "" };

        public static string IosKeychainSecurityGroups { get; } = "labs.apps";
    }
}
