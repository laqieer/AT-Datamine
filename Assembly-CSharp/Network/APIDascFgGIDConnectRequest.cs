// Decompiled with JetBrains decompiler
// Type: Network.APIDascFgGIDConnectRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019C3")]
  [Serializable]
  public class APIDascFgGIDConnectRequest
  {
    [Token(Token = "0x4006E98")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x4006E99")]
    [FieldOffset(Offset = "0x18")]
    public string secret_key;
    [Token(Token = "0x4006E9A")]
    [FieldOffset(Offset = "0x20")]
    public APIDascFgGIDConnectInfo connect_info;

    [Token(Token = "0x600933A")]
    [Address(RVA = "0x4D10D64", Offset = "0x4D10D64", VA = "0x4D10D64")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600933B")]
    [Address(RVA = "0x4D10DAC", Offset = "0x4D10DAC", VA = "0x4D10DAC")]
    public APIDascFgGIDConnectRequest()
    {
    }
  }
}
