// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FirstPerson_cpp : ModuleRules
{
	public FirstPerson_cpp(ReadOnlyTargetRules Target) : base(Target)
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
			"FirstPerson_cpp",
			"FirstPerson_cpp/Variant_Horror",
			"FirstPerson_cpp/Variant_Horror/UI",
			"FirstPerson_cpp/Variant_Shooter",
			"FirstPerson_cpp/Variant_Shooter/AI",
			"FirstPerson_cpp/Variant_Shooter/UI",
			"FirstPerson_cpp/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
