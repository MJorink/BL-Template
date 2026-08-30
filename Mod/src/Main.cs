using MelonLoader;
using UnityEngine;
using jlib;

namespace Template
{
	public class ABC : MelonMod
	{
		public const string Version = "1.0.0";
		
		public override void OnInitializeMelon()
		{
			// MelonPreferences
			var category = MelonPreferences.CreateCategory("Template");
			category.SetFilePath("Jorink/Template.cfg");
			
			category.SaveToFile();

			// BoneMenu Page
			var modPage = JLib.rootPage.CreatePage("Template", Color.yellow); // Change color!
		}
	}
}
