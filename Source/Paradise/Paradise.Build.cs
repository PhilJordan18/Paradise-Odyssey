// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Paradise : ModuleRules
{
	public Paradise(ReadOnlyTargetRules Target) : base(Target)
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

		PrivateDependencyModuleNames.AddRange(new string[]
		{
			"GameplayAbilities",
			"GameplayTags",
			"GameplayTasks"
		});

		PublicIncludePaths.AddRange(new string[] {
			"Paradise",
			"Paradise/Variant_Platforming",
			"Paradise/Variant_Platforming/Animation",
			"Paradise/Variant_Combat",
			"Paradise/Variant_Combat/AI",
			"Paradise/Variant_Combat/Animation",
			"Paradise/Variant_Combat/Gameplay",
			"Paradise/Variant_Combat/Interfaces",
			"Paradise/Variant_Combat/UI",
			"Paradise/Variant_SideScrolling",
			"Paradise/Variant_SideScrolling/AI",
			"Paradise/Variant_SideScrolling/Gameplay",
			"Paradise/Variant_SideScrolling/Interfaces",
			"Paradise/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
