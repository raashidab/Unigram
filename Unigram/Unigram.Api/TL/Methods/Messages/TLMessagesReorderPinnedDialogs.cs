// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.reorderPinnedDialogs
	/// </summary>
	public partial class TLMessagesReorderPinnedDialogs : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Force = (1 << 0),
		}

		public bool IsForce { get { return Flags.HasFlag(Flag.Force); } set { Flags = value ? (Flags | Flag.Force) : (Flags & ~Flag.Force); } }

		public Flag Flags { get; set; }
		public TLVector<TLInputPeerBase> Order { get; set; }

		public TLMessagesReorderPinnedDialogs() { }
		public TLMessagesReorderPinnedDialogs(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesReorderPinnedDialogs; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Flags = (Flag)from.ReadInt32();
			Order = TLFactory.Read<TLVector<TLInputPeerBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x959FF644);
			to.Write((Int32)Flags);
			to.WriteObject(Order, cache);
			if (cache) WriteToCache(to);
		}
	}
}