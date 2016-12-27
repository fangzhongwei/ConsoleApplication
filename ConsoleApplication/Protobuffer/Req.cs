// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: src/req.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from src/req.proto</summary>
public static partial class ReqReflection {

  #region Descriptor
  /// <summary>File descriptor for src/req.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg1zcmMvcmVxLnByb3RvIj8KHFNlbmRMb2dpblZlcmlmaWNhdGlvbkNvZGVS",
          "ZXESDwoHdHJhY2VJZBgBIAEoCRIOCgZtb2JpbGUYAiABKAkiaQoITG9naW5S",
          "ZXESCgoCdGkYASABKAkSDgoGbW9iaWxlGAIgASgJEhgKEHZlcmlmaWNhdGlv",
          "bkNvZGUYAyABKAkSEgoKZGV2aWNlVHlwZRgEIAEoBRITCgtmaW5nZXJQcmlu",
          "dBgFIAEoCSJSCgxBdXRvTG9naW5SZXESCgoCdGkYASABKAkSDQoFdG9rZW4Y",
          "AiABKAkSEgoKZGV2aWNlVHlwZRgEIAEoBRITCgtmaW5nZXJQcmludBgFIAEo",
          "CUIpCidjb20ubGF3c29mbmF0dXJlLmFwaWdhdGV3YXkuZG9tYWluLmh0dHBi",
          "BnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SendLoginVerificationCodeReq), global::SendLoginVerificationCodeReq.Parser, new[]{ "TraceId", "Mobile" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::LoginReq), global::LoginReq.Parser, new[]{ "Ti", "Mobile", "VerificationCode", "DeviceType", "FingerPrint" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AutoLoginReq), global::AutoLoginReq.Parser, new[]{ "Ti", "Token", "DeviceType", "FingerPrint" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SendLoginVerificationCodeReq : pb::IMessage<SendLoginVerificationCodeReq> {
  private static readonly pb::MessageParser<SendLoginVerificationCodeReq> _parser = new pb::MessageParser<SendLoginVerificationCodeReq>(() => new SendLoginVerificationCodeReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SendLoginVerificationCodeReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendLoginVerificationCodeReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendLoginVerificationCodeReq(SendLoginVerificationCodeReq other) : this() {
    traceId_ = other.traceId_;
    mobile_ = other.mobile_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendLoginVerificationCodeReq Clone() {
    return new SendLoginVerificationCodeReq(this);
  }

  /// <summary>Field number for the "traceId" field.</summary>
  public const int TraceIdFieldNumber = 1;
  private string traceId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string TraceId {
    get { return traceId_; }
    set {
      traceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "mobile" field.</summary>
  public const int MobileFieldNumber = 2;
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
    return Equals(other as SendLoginVerificationCodeReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SendLoginVerificationCodeReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (TraceId != other.TraceId) return false;
    if (Mobile != other.Mobile) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (TraceId.Length != 0) hash ^= TraceId.GetHashCode();
    if (Mobile.Length != 0) hash ^= Mobile.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (TraceId.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(TraceId);
    }
    if (Mobile.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Mobile);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (TraceId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(TraceId);
    }
    if (Mobile.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Mobile);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SendLoginVerificationCodeReq other) {
    if (other == null) {
      return;
    }
    if (other.TraceId.Length != 0) {
      TraceId = other.TraceId;
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
          TraceId = input.ReadString();
          break;
        }
        case 18: {
          Mobile = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class LoginReq : pb::IMessage<LoginReq> {
  private static readonly pb::MessageParser<LoginReq> _parser = new pb::MessageParser<LoginReq>(() => new LoginReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<LoginReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ReqReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginReq(LoginReq other) : this() {
    ti_ = other.ti_;
    mobile_ = other.mobile_;
    verificationCode_ = other.verificationCode_;
    deviceType_ = other.deviceType_;
    fingerPrint_ = other.fingerPrint_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public LoginReq Clone() {
    return new LoginReq(this);
  }

  /// <summary>Field number for the "ti" field.</summary>
  public const int TiFieldNumber = 1;
  private string ti_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ti {
    get { return ti_; }
    set {
      ti_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "mobile" field.</summary>
  public const int MobileFieldNumber = 2;
  private string mobile_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Mobile {
    get { return mobile_; }
    set {
      mobile_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "verificationCode" field.</summary>
  public const int VerificationCodeFieldNumber = 3;
  private string verificationCode_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string VerificationCode {
    get { return verificationCode_; }
    set {
      verificationCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "deviceType" field.</summary>
  public const int DeviceTypeFieldNumber = 4;
  private int deviceType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int DeviceType {
    get { return deviceType_; }
    set {
      deviceType_ = value;
    }
  }

  /// <summary>Field number for the "fingerPrint" field.</summary>
  public const int FingerPrintFieldNumber = 5;
  private string fingerPrint_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string FingerPrint {
    get { return fingerPrint_; }
    set {
      fingerPrint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as LoginReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(LoginReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Ti != other.Ti) return false;
    if (Mobile != other.Mobile) return false;
    if (VerificationCode != other.VerificationCode) return false;
    if (DeviceType != other.DeviceType) return false;
    if (FingerPrint != other.FingerPrint) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Ti.Length != 0) hash ^= Ti.GetHashCode();
    if (Mobile.Length != 0) hash ^= Mobile.GetHashCode();
    if (VerificationCode.Length != 0) hash ^= VerificationCode.GetHashCode();
    if (DeviceType != 0) hash ^= DeviceType.GetHashCode();
    if (FingerPrint.Length != 0) hash ^= FingerPrint.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Ti.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Ti);
    }
    if (Mobile.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Mobile);
    }
    if (VerificationCode.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(VerificationCode);
    }
    if (DeviceType != 0) {
      output.WriteRawTag(32);
      output.WriteInt32(DeviceType);
    }
    if (FingerPrint.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(FingerPrint);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Ti.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Ti);
    }
    if (Mobile.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Mobile);
    }
    if (VerificationCode.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(VerificationCode);
    }
    if (DeviceType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(DeviceType);
    }
    if (FingerPrint.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(FingerPrint);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(LoginReq other) {
    if (other == null) {
      return;
    }
    if (other.Ti.Length != 0) {
      Ti = other.Ti;
    }
    if (other.Mobile.Length != 0) {
      Mobile = other.Mobile;
    }
    if (other.VerificationCode.Length != 0) {
      VerificationCode = other.VerificationCode;
    }
    if (other.DeviceType != 0) {
      DeviceType = other.DeviceType;
    }
    if (other.FingerPrint.Length != 0) {
      FingerPrint = other.FingerPrint;
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
          Ti = input.ReadString();
          break;
        }
        case 18: {
          Mobile = input.ReadString();
          break;
        }
        case 26: {
          VerificationCode = input.ReadString();
          break;
        }
        case 32: {
          DeviceType = input.ReadInt32();
          break;
        }
        case 42: {
          FingerPrint = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class AutoLoginReq : pb::IMessage<AutoLoginReq> {
  private static readonly pb::MessageParser<AutoLoginReq> _parser = new pb::MessageParser<AutoLoginReq>(() => new AutoLoginReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AutoLoginReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ReqReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AutoLoginReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AutoLoginReq(AutoLoginReq other) : this() {
    ti_ = other.ti_;
    token_ = other.token_;
    deviceType_ = other.deviceType_;
    fingerPrint_ = other.fingerPrint_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AutoLoginReq Clone() {
    return new AutoLoginReq(this);
  }

  /// <summary>Field number for the "ti" field.</summary>
  public const int TiFieldNumber = 1;
  private string ti_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ti {
    get { return ti_; }
    set {
      ti_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "token" field.</summary>
  public const int TokenFieldNumber = 2;
  private string token_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Token {
    get { return token_; }
    set {
      token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "deviceType" field.</summary>
  public const int DeviceTypeFieldNumber = 4;
  private int deviceType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int DeviceType {
    get { return deviceType_; }
    set {
      deviceType_ = value;
    }
  }

  /// <summary>Field number for the "fingerPrint" field.</summary>
  public const int FingerPrintFieldNumber = 5;
  private string fingerPrint_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string FingerPrint {
    get { return fingerPrint_; }
    set {
      fingerPrint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AutoLoginReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AutoLoginReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Ti != other.Ti) return false;
    if (Token != other.Token) return false;
    if (DeviceType != other.DeviceType) return false;
    if (FingerPrint != other.FingerPrint) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Ti.Length != 0) hash ^= Ti.GetHashCode();
    if (Token.Length != 0) hash ^= Token.GetHashCode();
    if (DeviceType != 0) hash ^= DeviceType.GetHashCode();
    if (FingerPrint.Length != 0) hash ^= FingerPrint.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Ti.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Ti);
    }
    if (Token.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Token);
    }
    if (DeviceType != 0) {
      output.WriteRawTag(32);
      output.WriteInt32(DeviceType);
    }
    if (FingerPrint.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(FingerPrint);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Ti.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Ti);
    }
    if (Token.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
    }
    if (DeviceType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(DeviceType);
    }
    if (FingerPrint.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(FingerPrint);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(AutoLoginReq other) {
    if (other == null) {
      return;
    }
    if (other.Ti.Length != 0) {
      Ti = other.Ti;
    }
    if (other.Token.Length != 0) {
      Token = other.Token;
    }
    if (other.DeviceType != 0) {
      DeviceType = other.DeviceType;
    }
    if (other.FingerPrint.Length != 0) {
      FingerPrint = other.FingerPrint;
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
          Ti = input.ReadString();
          break;
        }
        case 18: {
          Token = input.ReadString();
          break;
        }
        case 32: {
          DeviceType = input.ReadInt32();
          break;
        }
        case 42: {
          FingerPrint = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
