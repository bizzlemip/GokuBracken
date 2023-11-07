using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using LC_API;
using UnityEngine;

namespace Gok.Patches
{
    [HarmonyPatch]
    class EnemyTypes
    {
        [HarmonyPatch(typeof(FlowermanAI), "Start")]
        [HarmonyPostfix]
        public static void  SummonGok(FlowermanAI __instance)
        {
            __instance.creatureAngerVoice.clip = LC_API.BundleAPI.BundleLoader.GetLoadedAsset<AudioClip>("assets/ultra.mp3");
            __instance.crackNeckSFX = LC_API.BundleAPI.BundleLoader.GetLoadedAsset<AudioClip>("assets/mods.mp3");
            __instance.crackNeckAudio.clip = LC_API.BundleAPI.BundleLoader.GetLoadedAsset<AudioClip>("assets/mods.mp3");
            GameObject.Destroy(__instance.gameObject.transform.Find("FlowermanModel").Find("LOD1").gameObject.GetComponent<SkinnedMeshRenderer>());
            GameObject Gok = UnityEngine.Object.Instantiate(LC_API.BundleAPI.BundleLoader.GetLoadedAsset<GameObject>("assets/Gok.prefab"), __instance.gameObject.transform);
            Gok.transform.localPosition = new Vector3(0f, 1.5f, 0f);
        }
    }
}
