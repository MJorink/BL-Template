using ModName;
using MelonLoader;
using System.Reflection;

[assembly: MelonInfo(typeof(ModNameMod), ModNameMod.Title, ModNameMod.Version, "Jorink")]
[assembly: MelonGame("Stress Level Zero", "BONELAB")]

[assembly: AssemblyVersion(ModNameMod.Version)]
[assembly: AssemblyDescription(ModNameMod.Description)]
[assembly: AssemblyTitle(ModNameMod.Title)]
