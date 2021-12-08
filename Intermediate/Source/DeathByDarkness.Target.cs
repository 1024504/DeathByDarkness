using UnrealBuildTool;

public class DeathByDarknessTarget : TargetRules
{
	public DeathByDarknessTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("DeathByDarkness");
	}
}
