using MelonLoader;
using UnityEngine;
using jlib;

namespace template // Lowercase!
{
	public class Template : MelonMod
	{
		public const string Version = "1.0.0";

		private MelonPreferences_Entry<bool> enableMod;

		public override void OnInitializeMelon()
		{
			var menu = JLib.Register("Template", Color.yellow); // Change color!

			enableMod = menu.Bool("Enable Mod", true, Color.green);
		}
	}
}
