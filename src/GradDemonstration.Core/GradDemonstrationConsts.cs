using GradDemonstration.Debugging;

namespace GradDemonstration
{
    public class GradDemonstrationConsts
    {
        public const string LocalizationSourceName = "GradDemonstration";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "32ac1b68fc4c4872a95bb2f7070a6ac0";
    }
}
