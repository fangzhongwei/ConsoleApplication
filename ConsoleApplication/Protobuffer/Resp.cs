// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: src/resp.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from src/resp.proto</summary>
public static partial class RespReflection {

  #region Descriptor
  /// <summary>File descriptor for src/resp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RespReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg5zcmMvcmVzcC5wcm90byJLCh1TZW5kTG9naW5WZXJpZmljYXRpb25Db2Rl",
          "UmVzcBIMCgRjb2RlGAEgASgJEgsKA21zZxgCIAEoCRIPCgdjaGFubmVsGAMg",
          "ASgFIlIKCUxvZ2luUmVzcBIMCgRjb2RlGAEgASgJEgsKA21zZxgCIAEoCRIN",
          "CgV0b2tlbhgDIAEoCRILCgNrZXkYBCABKAkSDgoGbW9iaWxlGAUgASgJQikK",
          "J2NvbS5sYXdzb2ZuYXR1cmUuYXBpZ2F0ZXdheS5kb21haW4uaHR0cGIGcHJv",
          "dG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SendLoginVerificationCodeResp), global::SendLoginVerificationCodeResp.Parser, new[]{ "Code", "Msg", "Channel" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::LoginResp), global::LoginResp.Parser, new[]{ "Code", "Msg", "Token", "Key", "Mobile" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SendLoginVerificationCodeResp : pb::IMessage<SendLoginVerificationCodeResp> {
  private static readonly pb::MessageParser<SendLoginVerificationCodeResp> _parser = new pb::MessageParser<SendLoginVerificationCodeResp>(() => new SendLoginVerificationCodeResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SendLoginVerificationCodeResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RespReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendLoginVerificationCodeResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendLoginVerificationCodeResp(SendLoginVerificationCodeResp other) : this() {
    code_ = other.code_;
    msg_ = other.msg_;
    channel_ = other.channel_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendLoginVerificationCodeResp Clone() {
    return new SendLoginVerificationCodeResp(this);
  }

  /// <summary>Field number for the "code" field.</summary>
  public const int CodeFieldNumber = 1;
  private string code_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Code {
    get { return code_; }
    set {
      code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "msg" field.</summary>
  public const int MsgFieldNumber = 2;
  private string msg_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Msg {
    get { return msg_; }
    set {
      msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "channel" field.</summary>
  public const int ChannelFieldNumber = 3;
  private int channel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Channel {
    get { return channel_; }
    set {
      channel_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SendLoginVerificationCodeResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SendLoginVerificationCodeResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Code != other.Code) return false;
    if (Msg != other.Msg) return false;
    if (Channel != other.Channel) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Code.Length != 0) hash ^= Code.GetHashCode();
    if (Msg.Length != 0) hash ^= Msg.GetHashCode();
    if (Channel != 0) hash ^= Channel.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Code.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Code);
    }
    if (Msg.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Msg);
    }
    if (Channel != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Channel);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Code.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
    }
    if (Msg.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
    }
    if (Channel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Channel);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SendLoginVerificationCodeResp other) {
    if (other == null) {
      return;
    }
    if (other.Code.Length != 0) {
      Code = other.Code;
    }
    if (other.Msg.Length != 0) {
      Msg = other.Msg;
    }
    if (other.Channel != 0) {
      Channel = other.Channel;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          Code = input.ReadString();
          break;
        }
        case 18: {
          Msg = input.ReadString();
          break;
        }
        case 24: {
          Channel = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class LoginResp : pb::IMessage<LoginResp> {
  private static readonly pb::MessageParser<LoginResp> _parser = new pb::MessageParser<LoginResp>(() => new LoginResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<LoginResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RespReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginResp(LoginResp other) : this() {
    code_ = other.code_;
    msg_ = other.msg_;
    token_ = other.token_;
    key_ = other.key_;
    mobile_ = other.mobile_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginResp Clone() {
    return new LoginResp(this);
  }

  /// <summary>Field number for the "code" field.</summary>
  public const int CodeFieldNumber = 1;
  private string code_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Code {
    get { return code_; }
    set {
      code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "msg" field.</summary>
  public const int MsgFieldNumber = 2;
  private string msg_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Msg {
    get { return msg_; }
    set {
      msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "token" field.</summary>
  public const int TokenFieldNumber = 3;
  private string token_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Token {
    get { return token_; }
    set {
      token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "key" field.</summary>
  public const int KeyFieldNumber = 4;
  private string key_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Key {
    get { return key_; }
    set {
      key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "mobile" field.</summary>
  public const int MobileFieldNumber = 5;
  private string mobile_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Mobile {
    get { return mobile_; }
    set {
      mobile_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as LoginResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(LoginResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Code != other.Code) return false;
    if (Msg != other.Msg) return false;
    if (Token != other.Token) return false;
    if (Key != other.Key) return false;
    if (Mobile != other.Mobile) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Code.Length != 0) hash ^= Code.GetHashCode();
    if (Msg.Length != 0) hash ^= Msg.GetHashCode();
    if (Token.Length != 0) hash ^= Token.GetHashCode();
    if (Key.Length != 0) hash ^= Key.GetHashCode();
    if (Mobile.Length != 0) hash ^= Mobile.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Code.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Code);
    }
    if (Msg.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Msg);
    }
    if (Token.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Token);
    }
    if (Key.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(Key);
    }
    if (Mobile.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(Mobile);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Code.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
    }
    if (Msg.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
    }
    if (Token.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
    }
    if (Key.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
    }
    if (Mobile.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Mobile);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(LoginResp other) {
    if (other == null) {
      return;
    }
    if (other.Code.Length != 0) {
      Code = other.Code;
    }
    if (other.Msg.Length != 0) {
      Msg = other.Msg;
    }
    if (other.Token.Length != 0) {
      Token = other.Token;
    }
    if (other.Key.Length != 0) {
      Key = other.Key;
    }
    if (other.Mobile.Length != 0) {
      Mobile = other.Mobile;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          Code = input.ReadString();
          break;
        }
        case 18: {
          Msg = input.ReadString();
          break;
        }
        case 26: {
          Token = input.ReadString();
          break;
        }
        case 34: {
          Key = input.ReadString();
          break;
        }
        case 42: {
          Mobile = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
