// Copyright Lijiaxu

using UnrealBuildTool;
using System.Collections.Generic;

public class AruaTarget : TargetRules
{
	public AruaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Arua" } );
	}
}
