// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_sitelicenseclient.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientSiteInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong site_id
        {
            get { return __pbn__site_id.GetValueOrDefault(); }
            set { __pbn__site_id = value; }
        }
        public bool ShouldSerializesite_id() => __pbn__site_id != null;
        public void Resetsite_id() => __pbn__site_id = null;
        private ulong? __pbn__site_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string site_name
        {
            get { return __pbn__site_name ?? ""; }
            set { __pbn__site_name = value; }
        }
        public bool ShouldSerializesite_name() => __pbn__site_name != null;
        public void Resetsite_name() => __pbn__site_name = null;
        private string __pbn__site_name;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientSiteLicenseCheckout : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientSiteLicenseCheckoutResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(2)]
        public int eresult
        {
            get { return __pbn__eresult ?? 2; }
            set { __pbn__eresult = value; }
        }
        public bool ShouldSerializeeresult() => __pbn__eresult != null;
        public void Reseteresult() => __pbn__eresult = null;
        private int? __pbn__eresult;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientSiteLicenseGetAvailableSeats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientSiteLicenseGetAvailableSeatsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(2)]
        public int eresult
        {
            get { return __pbn__eresult ?? 2; }
            set { __pbn__eresult = value; }
        }
        public bool ShouldSerializeeresult() => __pbn__eresult != null;
        public void Reseteresult() => __pbn__eresult = null;
        private int? __pbn__eresult;

        [global::ProtoBuf.ProtoMember(2)]
        public uint seats
        {
            get { return __pbn__seats.GetValueOrDefault(); }
            set { __pbn__seats = value; }
        }
        public bool ShouldSerializeseats() => __pbn__seats != null;
        public void Resetseats() => __pbn__seats = null;
        private uint? __pbn__seats;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientSiteLicenseGetContentCacheInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgClientSiteLicenseGetContentCacheInfoResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool use_cache
        {
            get { return __pbn__use_cache.GetValueOrDefault(); }
            set { __pbn__use_cache = value; }
        }
        public bool ShouldSerializeuse_cache() => __pbn__use_cache != null;
        public void Resetuse_cache() => __pbn__use_cache = null;
        private bool? __pbn__use_cache;

        [global::ProtoBuf.ProtoMember(2)]
        public uint ipv4_address
        {
            get { return __pbn__ipv4_address.GetValueOrDefault(); }
            set { __pbn__ipv4_address = value; }
        }
        public bool ShouldSerializeipv4_address() => __pbn__ipv4_address != null;
        public void Resetipv4_address() => __pbn__ipv4_address = null;
        private uint? __pbn__ipv4_address;

        [global::ProtoBuf.ProtoMember(3)]
        public uint port_number
        {
            get { return __pbn__port_number.GetValueOrDefault(); }
            set { __pbn__port_number = value; }
        }
        public bool ShouldSerializeport_number() => __pbn__port_number != null;
        public void Resetport_number() => __pbn__port_number = null;
        private uint? __pbn__port_number;

        [global::ProtoBuf.ProtoMember(4)]
        public uint p2p_group
        {
            get { return __pbn__p2p_group.GetValueOrDefault(); }
            set { __pbn__p2p_group = value; }
        }
        public bool ShouldSerializep2p_group() => __pbn__p2p_group != null;
        public void Resetp2p_group() => __pbn__p2p_group = null;
        private uint? __pbn__p2p_group;

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
