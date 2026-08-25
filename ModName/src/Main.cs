using MelonLoader;
using BoneLib;
using BoneLib.BoneMenu;
using Il2CppSLZ.Marrow;
using UnityEngine;

namespace ModName
{
	public class ModNameMod : MelonMod
	{
		public const string Title = "ModName";
		public const string Description = "Description";
		public const string Version = "1.0.0";

		private static RigManager rig; // Example

		private static MelonPreferences_Entry<bool> enableEntry;

		public override void OnInitializeMelon()
		{
			SetupMelonPreferences();
			SetupBoneMenu();
			SetupHooks();
		}

		private void SetupMelonPreferences()
		{
			var category = MelonPreferences.CreateCategory("ModName");

			enableEntry = category.CreateEntry("Enable Mod", true);

			MelonPreferences.Save();
			category.SaveToFile();
		}

		private void SetupBoneMenu()
		{
			Page defaultPage = Page.Root.CreatePage("Jorink", Color.red).CreatePage("ModName", Color.yellow); // Change color!

			defaultPage.CreateBool("Enable Mod", Color.green, enableEntry.Value, (value) => { enableEntry.Value = value; });
			defaultPage.CreateFunction("Save Settings", Color.green, () => MelonPreferences.Save());
		}

		private static void SetupHooks()
		{
			Hooking.OnLevelLoaded += OnLevelLoaded; // Example
		}

		private static void OnLevelLoaded(LevelInfo levelInfo)
		{
			rig = Player.RigManager; // Example
		}

		private static bool isModAllowed()
		{
			if (!enableEntry.Value || !rig) return false; // Example
			return true;
		}

		public override void OnUpdate()
		{
			if (!isModAllowed()) return;

			// Either logic here or swap OnUpdate for a hook if it's not needed.
		}
	}
}
