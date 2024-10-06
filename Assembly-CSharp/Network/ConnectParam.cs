// Decompiled with JetBrains decompiler
// Type: Network.ConnectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019FD")]
  public struct ConnectParam
  {
    [Token(Token = "0x4006F42")]
    [FieldOffset(Offset = "0x0")]
    public readonly string ApiPath;
    [Token(Token = "0x4006F43")]
    [FieldOffset(Offset = "0x8")]
    public readonly string Query;
    [Token(Token = "0x4006F44")]
    [FieldOffset(Offset = "0x10")]
    public readonly RequestType RequestType;
    [Token(Token = "0x4006F45")]
    [FieldOffset(Offset = "0x18")]
    public readonly string Json;
    [Token(Token = "0x4006F46")]
    [FieldOffset(Offset = "0x20")]
    public readonly bool AuthCheck;
    [Token(Token = "0x4006F47")]
    [FieldOffset(Offset = "0x28")]
    public readonly NetworkManager.OnSuccess OnSuccess;
    [Token(Token = "0x4006F48")]
    [FieldOffset(Offset = "0x30")]
    public readonly NetworkManager.OnError OnError;
    [Token(Token = "0x4006F49")]
    [FieldOffset(Offset = "0x38")]
    public readonly bool CreateRequestID;
    [Token(Token = "0x4006F4A")]
    [FieldOffset(Offset = "0x3C")]
    public readonly int NumberOfRetries;

    [Token(Token = "0x600945F")]
    [Address(RVA = "0x4D15E18", Offset = "0x4D15E18", VA = "0x4D15E18")]
    public ConnectParam(
      string apiPath,
      string query,
      RequestType requestType,
      string json,
      bool authCheck,
      NetworkManager.OnSuccess onSuccess,
      NetworkManager.OnError onError,
      bool createRequestID,
      int numberOfRetries)
    {
    }
  }
}
