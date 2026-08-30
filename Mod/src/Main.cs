using MelonLoader;
using UnityEngine;
using jlib;

namespace BL-Template
{
	public class ABC : MelonMod
	{
		public const string Version = "1.0.0";
		
		public override void OnInitializeMelon()
		{
			// MelonPreferences
			var category = MelonPreferences.CreateCategory("BL-Template");
			category.SetFilePath("Jorink/BL-Template.cfg");
			
			category.SaveToFile();

			// BoneMenu Page
			var modPage = JLib.rootPage.CreatePage("BL-Template", Color.yellow); // Change color!
		}
	}
}
