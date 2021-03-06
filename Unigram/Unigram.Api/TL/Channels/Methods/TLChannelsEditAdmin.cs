// <auto-generated/>
using System;

namespace Telegram.Api.TL.Channels.Methods
{
	/// <summary>
	/// RCP method channels.editAdmin.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLChannelsEditAdmin : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public TLInputUserBase UserId { get; set; }
		public TLChannelAdminRights AdminRights { get; set; }

		public TLChannelsEditAdmin() { }
		public TLChannelsEditAdmin(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsEditAdmin; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			UserId = TLFactory.Read<TLInputUserBase>(from);
			AdminRights = TLFactory.Read<TLChannelAdminRights>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x20B88214);
			to.WriteObject(Channel);
			to.WriteObject(UserId);
			to.WriteObject(AdminRights);
		}
	}
}