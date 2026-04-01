// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Outlier : ModuleRules
{
	public Outlier(ReadOnlyTargetRules Target) : base(Target)
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
			"Outlier",
			"Outlier/Variant_Platforming",
			"Outlier/Variant_Platforming/Animation",
			"Outlier/Variant_Combat",
			"Outlier/Variant_Combat/AI",
			"Outlier/Variant_Combat/Animation",
			"Outlier/Variant_Combat/Gameplay",
			"Outlier/Variant_Combat/Interfaces",
			"Outlier/Variant_Combat/UI",
			"Outlier/Variant_SideScrolling",
			"Outlier/Variant_SideScrolling/AI",
			"Outlier/Variant_SideScrolling/Gameplay",
			"Outlier/Variant_SideScrolling/Interfaces",
			"Outlier/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
