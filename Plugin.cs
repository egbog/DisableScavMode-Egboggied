using BepInEx;
using BepInEx.Configuration;
using SIT.Core.SP.ScavMode;


namespace SIT.Core
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    [BepInProcess("EscapeFromTarkov.exe")]
    public class Plugin : BaseUnityPlugin
    {
		public static ConfigEntry<bool> DisableInsuranceScreen { get; set; }

		private void Awake()
        {
			initConfig();
            new DisableScavModePatch().Enable();
			new DisableInsuranceScreenPatch().Enable();
        }

		private void initConfig()
		{
			string insuranceScreen = "Disable Insurance Screen";

			DisableInsuranceScreen = Config.Bind<bool>(insuranceScreen, "Skips insurance screen if enabled.", true);
		}
    }
}
