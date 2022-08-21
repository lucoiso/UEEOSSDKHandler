// Author: Lucas Vilas-Boas
// Year: 2022
// Repo: https://github.com/lucoiso/UEEOSSDKHandler

using System.IO;
using UnrealBuildTool;

public class EOSSDKHandler : ModuleRules
{
	public EOSSDKHandler(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(new[]
		{
			"Core"
		});
		
		PrivateDefinitions.Add("WITH_EOS_SDK=true");
		PrivateDefinitions.Add("WITH_EOS_RTC=true");
		
		PublicIncludePaths.Add(Path.Combine(EngineDirectory, 
			"Plugins/Online/OnlineSubsystemEOS/Source/OnlineSubsystemEOS/Private/"));
		
		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "EOS/SDK/Include"));
	}
}
