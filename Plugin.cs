using BepInEx;
using HarmonyLib;

namespace Gok
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public Harmony harmonymain;
        private void Awake()
        {
            harmonymain = new Harmony(PluginInfo.PLUGIN_GUID);
            harmonymain.PatchAll();
            Logger.LogInfo($"gok loaded.");
        }
    }
}
