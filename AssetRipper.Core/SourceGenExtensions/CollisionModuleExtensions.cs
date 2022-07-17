﻿using AssetRipper.Core.Classes.ParticleSystem.CollisionModule;
using AssetRipper.SourceGenerated.Subclasses.CollisionModule;

namespace AssetRipper.Core.SourceGenExtensions
{
	public static class CollisionModuleExtensions
	{
		public static ParticleSystemCollisionType GetCollisionType(this ICollisionModule module)
		{
			return (ParticleSystemCollisionType)module.Type;
		}
		
		public static ParticleSystemCollisionMode GetCollisionMode(this ICollisionModule module)
		{
			return (ParticleSystemCollisionMode)module.CollisionMode;
		}

		public static ParticleSystemCollisionQuality GetCollisionQuality(this ICollisionModule module)
		{
			return (ParticleSystemCollisionQuality)module.Quality;
		}
	}
}
