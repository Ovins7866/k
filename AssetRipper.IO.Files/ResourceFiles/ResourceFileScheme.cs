using AssetRipper.IO.Files.Entries;
using AssetRipper.IO.Files.Schemes;
using AssetRipper.IO.Files.SerializedFiles.Parser;
using AssetRipper.IO.Files.Streams.Smart;
using System.Collections.Generic;

namespace AssetRipper.IO.Files.ResourceFiles
{
	public sealed class ResourceFileScheme : FileScheme
	{
		private ResourceFileScheme(SmartStream stream, string filePath, string fileName) : base(filePath, fileName)
		{
			Stream = stream.CreateReference();
		}

		internal static ResourceFileScheme ReadScheme(byte[] buffer, string filePath, string fileName)
		{
			using SmartStream stream = SmartStream.CreateMemory(buffer);
			return new ResourceFileScheme(stream, filePath, fileName);
		}

		internal static ResourceFileScheme ReadScheme(SmartStream stream, string filePath, string fileName)
		{
			return new ResourceFileScheme(stream, filePath, fileName);
		}

		public ResourceFile ReadFile()
		{
			return new ResourceFile(this);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			Stream.Dispose();
		}

		public override FileEntryType SchemeType => FileEntryType.Resource;
		public override IEnumerable<FileIdentifier> Dependencies { get { yield break; } }

		public SmartStream Stream { get; }
	}
}
