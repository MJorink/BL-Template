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
        private static MelonPreferences_Entry<bool> exampleBoolEntry;
        private static MelonPreferences_Entry<float> exampleFloatEntry;

        public override void OnInitializeMelon()
        {
            SetupMelonPreferences();
            SetupBoneMenu();
        }

        private void SetupMelonPreferences()
        {
        	MelonPreferences_Category category;
            category = MelonPreferences.CreateCategory("ModTemplate");

            exampleBoolEntry = category.CreateEntry("Example Bool", false);
            exampleFloatEntry = category.CreateEntry("Example Float", 0.5f);
            
            MelonPreferences.Save();
            category.SaveToFile();
        }

        private void SetupBoneMenu()
        {
            Page defaultPage = Page.Root.CreatePage("Jorink", Color.red).CreatePage("ModTemplate", Color.yellow);

            defaultPage.CreateFloat("Example Float", Color.yellow, exampleFloatEntry.Value, 0.1f, 0.1f, 1f, (value) => exampleFloatEntry.Value = value);
            defaultPage.CreateBool("Example Bool", Color.yellow, exampleBoolEntry.Value, (value) => exampleBoolEntry.Value = value);
            defaultPage.CreateFunction("Save Settings", Color.cyan, () => MelonPreferences.Save());
        }
    }
}
