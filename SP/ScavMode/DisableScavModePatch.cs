using EFT.UI;
using System.Reflection;
using SPT.Reflection.Patching;
using UnityEngine;
using UnityEngine.UI;

/**
 * ORIGINAL CODE written by MaoMao / TheMaoci. All credit goes to him! His code is closed source and subject to license.
 */

namespace SIT.Core.SP.ScavMode
{
    /// <summary>
    /// 
    /// </summary>
    public class DisableScavModePatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return typeof(EFT.UI.Matchmaker.MatchMakerSideSelectionScreen).GetMethod("Awake", BindingFlags.Public | BindingFlags.Instance);
        }

        [PatchPostfix]
        static void PatchPostfix
			(EFT.UI.Matchmaker.MatchMakerSideSelectionScreen __instance, 
			Button ____savagesBigButton, 
			Button ____pmcBigButton)
        {
            ____savagesBigButton.transform.parent.gameObject.SetActive(false);
            ____pmcBigButton.transform.parent.transform.localPosition = new Vector3(-220, 520, 0);
		}
    }
}
