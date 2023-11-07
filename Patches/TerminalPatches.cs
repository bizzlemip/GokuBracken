using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using LC_API;
using UnityEngine;
using UnityEngine.Video;

namespace Gok.Patches
{
    [HarmonyPatch]
    class TerminalPatches
    {
        [HarmonyPatch(typeof(Terminal), "Awake")]
        [HarmonyPostfix]
        public static void EditTerminal(Terminal __instance)
        {
            __instance.enemyFiles[1].displayVideo = LC_API.BundleAPI.BundleLoader.GetLoadedAsset<VideoClip>("assets/Gok.m4v");
            
        }
    }
}
