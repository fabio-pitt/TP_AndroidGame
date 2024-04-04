// An Android game

using UnrealBuildTool;
using System.Collections.Generic;

public class TP_AndroidGameEditorTarget : TargetRules
{
	public TP_AndroidGameEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("TP_AndroidGame");
	}
}
