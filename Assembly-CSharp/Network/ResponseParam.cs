// Decompiled with JetBrains decompiler
// Type: Network.ResponseParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019FE")]
  public struct ResponseParam
  {
    [Token(Token = "0x4006F4B")]
    [FieldOffset(Offset = "0x0")]
    public readonly string RespounseBody;
    [Token(Token = "0x4006F4C")]
    [FieldOffset(Offset = "0x8")]
    public readonly string ErrorCode;
    [Token(Token = "0x4006F4D")]
    [FieldOffset(Offset = "0x10")]
    public readonly long HttpStatusCode;

    [Token(Token = "0x6009460")]
    [Address(RVA = "0x4D15E48", Offset = "0x4D15E48", VA = "0x4D15E48")]
    public ResponseParam(string respounseBody, string errorCode, long statusCode)
    {
    }

    [Token(Token = "0x6009461")]
    public T GetJson<T>() => (T) null;
  }
}
