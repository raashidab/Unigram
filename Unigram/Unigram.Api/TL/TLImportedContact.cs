// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLImportedContact : TLObject 
	{
		public Int32 UserId { get; set; }
		public Int64 ClientId { get; set; }

		public TLImportedContact() { }
		public TLImportedContact(TLBinaryReader from, TLType type = TLType.ImportedContact)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ImportedContact; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ImportedContact)
		{
			UserId = from.ReadInt32();
			ClientId = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xD0028438);
			to.Write(UserId);
			to.Write(ClientId);
		}
	}
}