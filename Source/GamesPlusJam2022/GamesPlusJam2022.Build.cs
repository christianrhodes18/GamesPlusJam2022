// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GamesPlusJam2022 : ModuleRules
{
	public GamesPlusJam2022(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Paper2D" });
	}
}
