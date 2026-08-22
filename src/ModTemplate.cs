using MelonLoader;
using BoneLib;
using BoneLib.BoneMenu;
using Il2CppSLZ.Marrow;
using UnityEngine;

[assembly: MelonInfo(typeof(ModTemplate.Core), "ModTemplate", "1.0.0", "jorink")]
[assembly: MelonGame("Stress Level Zero", "BONELAB")]

namespace ModTemplate
{
    public class Core : MelonMod
    {
        private static MelonPreferences_Category category;

        public override void OnInitializeMelon()
        {
            SetupMelonPreferences();
            SetupBoneMenu();
        }

        private void SetupBoneMenu()
        {
            Page defaultPage = Page.Root.CreatePage("Jorink", Color.red).CreatePage("ModTemplate", Color.yellow);
            
            defaultPage.CreateFunction("Save Settings", Color.cyan, () => MelonPreferences.Save());
        }

        private void SetupMelonPreferences()
        {
            category = MelonPreferences.CreateCategory("ModTemplate");
            MelonPreferences.Save();
            category.SaveToFile();
        }
    }
}
