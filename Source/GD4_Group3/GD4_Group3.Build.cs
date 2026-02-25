// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GD4_Group3 : ModuleRules
{
	public GD4_Group3(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GD4_Group3",
			"GD4_Group3/Variant_Platforming",
			"GD4_Group3/Variant_Platforming/Animation",
			"GD4_Group3/Variant_Combat",
			"GD4_Group3/Variant_Combat/AI",
			"GD4_Group3/Variant_Combat/Animation",
			"GD4_Group3/Variant_Combat/Gameplay",
			"GD4_Group3/Variant_Combat/Interfaces",
			"GD4_Group3/Variant_Combat/UI",
			"GD4_Group3/Variant_SideScrolling",
			"GD4_Group3/Variant_SideScrolling/AI",
			"GD4_Group3/Variant_SideScrolling/Gameplay",
			"GD4_Group3/Variant_SideScrolling/Interfaces",
			"GD4_Group3/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
