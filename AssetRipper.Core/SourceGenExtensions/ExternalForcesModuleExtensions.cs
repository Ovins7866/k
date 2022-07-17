﻿using AssetRipper.SourceGenerated.Subclasses.ExternalForcesModule;

namespace AssetRipper.Core.SourceGenExtensions
{
	public static class ExternalForcesModuleExtensions
	{
		public static void SetToDefault(this IExternalForcesModule module, UnityVersion version)
		{
			module.MultiplierCurve?.SetValues(version, 1f);
		}
	}
}
