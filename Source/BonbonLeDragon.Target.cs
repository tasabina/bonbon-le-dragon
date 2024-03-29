// Copyright © 2024 Sabina Talipova. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class BonbonLeDragonTarget : TargetRules
{
	public BonbonLeDragonTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "BonbonLeDragon" } );
	}
}
