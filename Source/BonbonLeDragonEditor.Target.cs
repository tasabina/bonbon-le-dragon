// Copyright © 2024 Sabina Talipova. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BonbonLeDragonEditorTarget : TargetRules
{
	public BonbonLeDragonEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "BonbonLeDragon" } );
	}
}
