﻿namespace ShaderTextRestorer.ShaderBlob.Parameters
{
	public sealed class SamplerParameter
	{
		public SamplerParameter() { }

		public SamplerParameter(uint sampler, int bindPoint)
		{
			Sampler = sampler;
			BindPoint = bindPoint;
		}

		public uint Sampler { get; set; }
		public int BindPoint { get; set; }
	}
}
