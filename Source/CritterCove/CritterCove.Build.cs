// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CritterCove : ModuleRules
{
	public CritterCove(ReadOnlyTargetRules Target) : base(Target)
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
			"CritterCove",
			"CritterCove/Variant_Horror",
			"CritterCove/Variant_Horror/UI",
			"CritterCove/Variant_Shooter",
			"CritterCove/Variant_Shooter/AI",
			"CritterCove/Variant_Shooter/UI",
			"CritterCove/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
