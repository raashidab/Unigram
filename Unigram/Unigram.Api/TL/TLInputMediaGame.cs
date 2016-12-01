// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputMediaGame : TLInputMediaBase 
	{
		public TLInputGameBase Id { get; set; }

		public TLInputMediaGame() { }
		public TLInputMediaGame(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.InputMediaGame; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = TLFactory.Read<TLInputGameBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xD33F43F3);
			to.WriteObject(Id, cache);
			if (cache) WriteToCache(to);
		}
	}
}