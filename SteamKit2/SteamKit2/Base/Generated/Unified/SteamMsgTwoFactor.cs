// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_twofactor.steamclient.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Unified.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_Status_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_Status_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint state
        {
            get { return __pbn__state.GetValueOrDefault(); }
            set { __pbn__state = value; }
        }
        public bool ShouldSerializestate() => __pbn__state != null;
        public void Resetstate() => __pbn__state = null;
        private uint? __pbn__state;

        [global::ProtoBuf.ProtoMember(2)]
        public uint inactivation_reason
        {
            get { return __pbn__inactivation_reason.GetValueOrDefault(); }
            set { __pbn__inactivation_reason = value; }
        }
        public bool ShouldSerializeinactivation_reason() => __pbn__inactivation_reason != null;
        public void Resetinactivation_reason() => __pbn__inactivation_reason = null;
        private uint? __pbn__inactivation_reason;

        [global::ProtoBuf.ProtoMember(3)]
        public uint authenticator_type
        {
            get { return __pbn__authenticator_type.GetValueOrDefault(); }
            set { __pbn__authenticator_type = value; }
        }
        public bool ShouldSerializeauthenticator_type() => __pbn__authenticator_type != null;
        public void Resetauthenticator_type() => __pbn__authenticator_type = null;
        private uint? __pbn__authenticator_type;

        [global::ProtoBuf.ProtoMember(4)]
        public bool authenticator_allowed
        {
            get { return __pbn__authenticator_allowed.GetValueOrDefault(); }
            set { __pbn__authenticator_allowed = value; }
        }
        public bool ShouldSerializeauthenticator_allowed() => __pbn__authenticator_allowed != null;
        public void Resetauthenticator_allowed() => __pbn__authenticator_allowed = null;
        private bool? __pbn__authenticator_allowed;

        [global::ProtoBuf.ProtoMember(5)]
        public uint steamguard_scheme
        {
            get { return __pbn__steamguard_scheme.GetValueOrDefault(); }
            set { __pbn__steamguard_scheme = value; }
        }
        public bool ShouldSerializesteamguard_scheme() => __pbn__steamguard_scheme != null;
        public void Resetsteamguard_scheme() => __pbn__steamguard_scheme = null;
        private uint? __pbn__steamguard_scheme;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string token_gid
        {
            get { return __pbn__token_gid ?? ""; }
            set { __pbn__token_gid = value; }
        }
        public bool ShouldSerializetoken_gid() => __pbn__token_gid != null;
        public void Resettoken_gid() => __pbn__token_gid = null;
        private string __pbn__token_gid;

        [global::ProtoBuf.ProtoMember(7)]
        public bool email_validated
        {
            get { return __pbn__email_validated.GetValueOrDefault(); }
            set { __pbn__email_validated = value; }
        }
        public bool ShouldSerializeemail_validated() => __pbn__email_validated != null;
        public void Resetemail_validated() => __pbn__email_validated = null;
        private bool? __pbn__email_validated;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue("")]
        public string device_identifier
        {
            get { return __pbn__device_identifier ?? ""; }
            set { __pbn__device_identifier = value; }
        }
        public bool ShouldSerializedevice_identifier() => __pbn__device_identifier != null;
        public void Resetdevice_identifier() => __pbn__device_identifier = null;
        private string __pbn__device_identifier;

        [global::ProtoBuf.ProtoMember(9)]
        public uint time_created
        {
            get { return __pbn__time_created.GetValueOrDefault(); }
            set { __pbn__time_created = value; }
        }
        public bool ShouldSerializetime_created() => __pbn__time_created != null;
        public void Resettime_created() => __pbn__time_created = null;
        private uint? __pbn__time_created;

        [global::ProtoBuf.ProtoMember(10)]
        public uint revocation_attempts_remaining
        {
            get { return __pbn__revocation_attempts_remaining.GetValueOrDefault(); }
            set { __pbn__revocation_attempts_remaining = value; }
        }
        public bool ShouldSerializerevocation_attempts_remaining() => __pbn__revocation_attempts_remaining != null;
        public void Resetrevocation_attempts_remaining() => __pbn__revocation_attempts_remaining = null;
        private uint? __pbn__revocation_attempts_remaining;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue("")]
        public string classified_agent
        {
            get { return __pbn__classified_agent ?? ""; }
            set { __pbn__classified_agent = value; }
        }
        public bool ShouldSerializeclassified_agent() => __pbn__classified_agent != null;
        public void Resetclassified_agent() => __pbn__classified_agent = null;
        private string __pbn__classified_agent;

        [global::ProtoBuf.ProtoMember(12)]
        public bool allow_external_authenticator
        {
            get { return __pbn__allow_external_authenticator.GetValueOrDefault(); }
            set { __pbn__allow_external_authenticator = value; }
        }
        public bool ShouldSerializeallow_external_authenticator() => __pbn__allow_external_authenticator != null;
        public void Resetallow_external_authenticator() => __pbn__allow_external_authenticator = null;
        private bool? __pbn__allow_external_authenticator;

        [global::ProtoBuf.ProtoMember(13)]
        public uint time_transferred
        {
            get { return __pbn__time_transferred.GetValueOrDefault(); }
            set { __pbn__time_transferred = value; }
        }
        public bool ShouldSerializetime_transferred() => __pbn__time_transferred != null;
        public void Resettime_transferred() => __pbn__time_transferred = null;
        private uint? __pbn__time_transferred;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_AddAuthenticator_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong authenticator_time
        {
            get { return __pbn__authenticator_time.GetValueOrDefault(); }
            set { __pbn__authenticator_time = value; }
        }
        public bool ShouldSerializeauthenticator_time() => __pbn__authenticator_time != null;
        public void Resetauthenticator_time() => __pbn__authenticator_time = null;
        private ulong? __pbn__authenticator_time;

        [global::ProtoBuf.ProtoMember(3, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong serial_number
        {
            get { return __pbn__serial_number.GetValueOrDefault(); }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private ulong? __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(4)]
        public uint authenticator_type
        {
            get { return __pbn__authenticator_type.GetValueOrDefault(); }
            set { __pbn__authenticator_type = value; }
        }
        public bool ShouldSerializeauthenticator_type() => __pbn__authenticator_type != null;
        public void Resetauthenticator_type() => __pbn__authenticator_type = null;
        private uint? __pbn__authenticator_type;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string device_identifier
        {
            get { return __pbn__device_identifier ?? ""; }
            set { __pbn__device_identifier = value; }
        }
        public bool ShouldSerializedevice_identifier() => __pbn__device_identifier != null;
        public void Resetdevice_identifier() => __pbn__device_identifier = null;
        private string __pbn__device_identifier;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string sms_phone_id
        {
            get { return __pbn__sms_phone_id ?? ""; }
            set { __pbn__sms_phone_id = value; }
        }
        public bool ShouldSerializesms_phone_id() => __pbn__sms_phone_id != null;
        public void Resetsms_phone_id() => __pbn__sms_phone_id = null;
        private string __pbn__sms_phone_id;

        [global::ProtoBuf.ProtoMember(7)]
        public global::System.Collections.Generic.List<string> http_headers { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_AddAuthenticator_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public byte[] shared_secret
        {
            get { return __pbn__shared_secret; }
            set { __pbn__shared_secret = value; }
        }
        public bool ShouldSerializeshared_secret() => __pbn__shared_secret != null;
        public void Resetshared_secret() => __pbn__shared_secret = null;
        private byte[] __pbn__shared_secret;

        [global::ProtoBuf.ProtoMember(2, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong serial_number
        {
            get { return __pbn__serial_number.GetValueOrDefault(); }
            set { __pbn__serial_number = value; }
        }
        public bool ShouldSerializeserial_number() => __pbn__serial_number != null;
        public void Resetserial_number() => __pbn__serial_number = null;
        private ulong? __pbn__serial_number;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string revocation_code
        {
            get { return __pbn__revocation_code ?? ""; }
            set { __pbn__revocation_code = value; }
        }
        public bool ShouldSerializerevocation_code() => __pbn__revocation_code != null;
        public void Resetrevocation_code() => __pbn__revocation_code = null;
        private string __pbn__revocation_code;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string uri
        {
            get { return __pbn__uri ?? ""; }
            set { __pbn__uri = value; }
        }
        public bool ShouldSerializeuri() => __pbn__uri != null;
        public void Reseturi() => __pbn__uri = null;
        private string __pbn__uri;

        [global::ProtoBuf.ProtoMember(5)]
        public ulong server_time
        {
            get { return __pbn__server_time.GetValueOrDefault(); }
            set { __pbn__server_time = value; }
        }
        public bool ShouldSerializeserver_time() => __pbn__server_time != null;
        public void Resetserver_time() => __pbn__server_time = null;
        private ulong? __pbn__server_time;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string account_name
        {
            get { return __pbn__account_name ?? ""; }
            set { __pbn__account_name = value; }
        }
        public bool ShouldSerializeaccount_name() => __pbn__account_name != null;
        public void Resetaccount_name() => __pbn__account_name = null;
        private string __pbn__account_name;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string token_gid
        {
            get { return __pbn__token_gid ?? ""; }
            set { __pbn__token_gid = value; }
        }
        public bool ShouldSerializetoken_gid() => __pbn__token_gid != null;
        public void Resettoken_gid() => __pbn__token_gid = null;
        private string __pbn__token_gid;

        [global::ProtoBuf.ProtoMember(8)]
        public byte[] identity_secret
        {
            get { return __pbn__identity_secret; }
            set { __pbn__identity_secret = value; }
        }
        public bool ShouldSerializeidentity_secret() => __pbn__identity_secret != null;
        public void Resetidentity_secret() => __pbn__identity_secret = null;
        private byte[] __pbn__identity_secret;

        [global::ProtoBuf.ProtoMember(9)]
        public byte[] secret_1
        {
            get { return __pbn__secret_1; }
            set { __pbn__secret_1 = value; }
        }
        public bool ShouldSerializesecret_1() => __pbn__secret_1 != null;
        public void Resetsecret_1() => __pbn__secret_1 = null;
        private byte[] __pbn__secret_1;

        [global::ProtoBuf.ProtoMember(10)]
        public int status
        {
            get { return __pbn__status.GetValueOrDefault(); }
            set { __pbn__status = value; }
        }
        public bool ShouldSerializestatus() => __pbn__status != null;
        public void Resetstatus() => __pbn__status = null;
        private int? __pbn__status;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_SendEmail_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint email_type
        {
            get { return __pbn__email_type.GetValueOrDefault(); }
            set { __pbn__email_type = value; }
        }
        public bool ShouldSerializeemail_type() => __pbn__email_type != null;
        public void Resetemail_type() => __pbn__email_type = null;
        private uint? __pbn__email_type;

        [global::ProtoBuf.ProtoMember(3)]
        public bool include_activation_code
        {
            get { return __pbn__include_activation_code.GetValueOrDefault(); }
            set { __pbn__include_activation_code = value; }
        }
        public bool ShouldSerializeinclude_activation_code() => __pbn__include_activation_code != null;
        public void Resetinclude_activation_code() => __pbn__include_activation_code = null;
        private bool? __pbn__include_activation_code;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_SendEmail_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_FinalizeAddAuthenticator_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string authenticator_code
        {
            get { return __pbn__authenticator_code ?? ""; }
            set { __pbn__authenticator_code = value; }
        }
        public bool ShouldSerializeauthenticator_code() => __pbn__authenticator_code != null;
        public void Resetauthenticator_code() => __pbn__authenticator_code = null;
        private string __pbn__authenticator_code;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong authenticator_time
        {
            get { return __pbn__authenticator_time.GetValueOrDefault(); }
            set { __pbn__authenticator_time = value; }
        }
        public bool ShouldSerializeauthenticator_time() => __pbn__authenticator_time != null;
        public void Resetauthenticator_time() => __pbn__authenticator_time = null;
        private ulong? __pbn__authenticator_time;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string activation_code
        {
            get { return __pbn__activation_code ?? ""; }
            set { __pbn__activation_code = value; }
        }
        public bool ShouldSerializeactivation_code() => __pbn__activation_code != null;
        public void Resetactivation_code() => __pbn__activation_code = null;
        private string __pbn__activation_code;

        [global::ProtoBuf.ProtoMember(5)]
        public global::System.Collections.Generic.List<string> http_headers { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_FinalizeAddAuthenticator_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool success
        {
            get { return __pbn__success.GetValueOrDefault(); }
            set { __pbn__success = value; }
        }
        public bool ShouldSerializesuccess() => __pbn__success != null;
        public void Resetsuccess() => __pbn__success = null;
        private bool? __pbn__success;

        [global::ProtoBuf.ProtoMember(2)]
        public bool want_more
        {
            get { return __pbn__want_more.GetValueOrDefault(); }
            set { __pbn__want_more = value; }
        }
        public bool ShouldSerializewant_more() => __pbn__want_more != null;
        public void Resetwant_more() => __pbn__want_more = null;
        private bool? __pbn__want_more;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong server_time
        {
            get { return __pbn__server_time.GetValueOrDefault(); }
            set { __pbn__server_time = value; }
        }
        public bool ShouldSerializeserver_time() => __pbn__server_time != null;
        public void Resetserver_time() => __pbn__server_time = null;
        private ulong? __pbn__server_time;

        [global::ProtoBuf.ProtoMember(4)]
        public int status
        {
            get { return __pbn__status.GetValueOrDefault(); }
            set { __pbn__status = value; }
        }
        public bool ShouldSerializestatus() => __pbn__status != null;
        public void Resetstatus() => __pbn__status = null;
        private int? __pbn__status;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_RemoveAuthenticator_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string revocation_code
        {
            get { return __pbn__revocation_code ?? ""; }
            set { __pbn__revocation_code = value; }
        }
        public bool ShouldSerializerevocation_code() => __pbn__revocation_code != null;
        public void Resetrevocation_code() => __pbn__revocation_code = null;
        private string __pbn__revocation_code;

        [global::ProtoBuf.ProtoMember(5)]
        public uint revocation_reason
        {
            get { return __pbn__revocation_reason.GetValueOrDefault(); }
            set { __pbn__revocation_reason = value; }
        }
        public bool ShouldSerializerevocation_reason() => __pbn__revocation_reason != null;
        public void Resetrevocation_reason() => __pbn__revocation_reason = null;
        private uint? __pbn__revocation_reason;

        [global::ProtoBuf.ProtoMember(6)]
        public uint steamguard_scheme
        {
            get { return __pbn__steamguard_scheme.GetValueOrDefault(); }
            set { __pbn__steamguard_scheme = value; }
        }
        public bool ShouldSerializesteamguard_scheme() => __pbn__steamguard_scheme != null;
        public void Resetsteamguard_scheme() => __pbn__steamguard_scheme = null;
        private uint? __pbn__steamguard_scheme;

        [global::ProtoBuf.ProtoMember(7)]
        public bool remove_all_steamguard_cookies
        {
            get { return __pbn__remove_all_steamguard_cookies.GetValueOrDefault(); }
            set { __pbn__remove_all_steamguard_cookies = value; }
        }
        public bool ShouldSerializeremove_all_steamguard_cookies() => __pbn__remove_all_steamguard_cookies != null;
        public void Resetremove_all_steamguard_cookies() => __pbn__remove_all_steamguard_cookies = null;
        private bool? __pbn__remove_all_steamguard_cookies;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_RemoveAuthenticator_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool success
        {
            get { return __pbn__success.GetValueOrDefault(); }
            set { __pbn__success = value; }
        }
        public bool ShouldSerializesuccess() => __pbn__success != null;
        public void Resetsuccess() => __pbn__success = null;
        private bool? __pbn__success;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong server_time
        {
            get { return __pbn__server_time.GetValueOrDefault(); }
            set { __pbn__server_time = value; }
        }
        public bool ShouldSerializeserver_time() => __pbn__server_time != null;
        public void Resetserver_time() => __pbn__server_time = null;
        private ulong? __pbn__server_time;

        [global::ProtoBuf.ProtoMember(5)]
        public uint revocation_attempts_remaining
        {
            get { return __pbn__revocation_attempts_remaining.GetValueOrDefault(); }
            set { __pbn__revocation_attempts_remaining = value; }
        }
        public bool ShouldSerializerevocation_attempts_remaining() => __pbn__revocation_attempts_remaining != null;
        public void Resetrevocation_attempts_remaining() => __pbn__revocation_attempts_remaining = null;
        private uint? __pbn__revocation_attempts_remaining;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_CreateEmergencyCodes_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_CreateEmergencyCodes_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<string> codes { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_DestroyEmergencyCodes_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_DestroyEmergencyCodes_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_ValidateToken_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string code
        {
            get { return __pbn__code ?? ""; }
            set { __pbn__code = value; }
        }
        public bool ShouldSerializecode() => __pbn__code != null;
        public void Resetcode() => __pbn__code = null;
        private string __pbn__code;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CTwoFactor_ValidateToken_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool valid
        {
            get { return __pbn__valid.GetValueOrDefault(); }
            set { __pbn__valid = value; }
        }
        public bool ShouldSerializevalid() => __pbn__valid != null;
        public void Resetvalid() => __pbn__valid = null;
        private bool? __pbn__valid;

    }

    public interface ITwoFactor
    {
        CTwoFactor_Status_Response QueryStatus(CTwoFactor_Status_Request request);
        CTwoFactor_AddAuthenticator_Response AddAuthenticator(CTwoFactor_AddAuthenticator_Request request);
        CTwoFactor_SendEmail_Response SendEmail(CTwoFactor_SendEmail_Request request);
        CTwoFactor_FinalizeAddAuthenticator_Response FinalizeAddAuthenticator(CTwoFactor_FinalizeAddAuthenticator_Request request);
        CTwoFactor_RemoveAuthenticator_Response RemoveAuthenticator(CTwoFactor_RemoveAuthenticator_Request request);
        CTwoFactor_CreateEmergencyCodes_Response CreateEmergencyCodes(CTwoFactor_CreateEmergencyCodes_Request request);
        CTwoFactor_DestroyEmergencyCodes_Response DestroyEmergencyCodes(CTwoFactor_DestroyEmergencyCodes_Request request);
        CTwoFactor_ValidateToken_Response ValidateToken(CTwoFactor_ValidateToken_Request request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
