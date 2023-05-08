using LAB.Debugging;

namespace LAB
{
    public class LABConsts
    {
        public const string LocalizationSourceName = "LAB";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "09da87630ef24eb4956424c0dfa0bfa7";
    }
}
