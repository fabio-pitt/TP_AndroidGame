// An Android game

using UnrealBuildTool;
using System.Collections.Generic;

public class TP_AndroidGameTarget : TargetRules
{
	public TP_AndroidGameTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("TP_AndroidGame");
	}
}
