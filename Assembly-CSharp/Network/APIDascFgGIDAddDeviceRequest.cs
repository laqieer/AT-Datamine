// Decompiled with JetBrains decompiler
// Type: Network.APIDascFgGIDAddDeviceRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019BF")]
  [Serializable]
  public class APIDascFgGIDAddDeviceRequest
  {
    [Token(Token = "0x4006E8C")]
    [FieldOffset(Offset = "0x10")]
    public string secret_key;
    [Token(Token = "0x4006E8D")]
    [FieldOffset(Offset = "0x18")]
    public APIDascFgGIDConnectInfo connect_info;

    [Token(Token = "0x6009326")]
    [Address(RVA = "0x4D1079C", Offset = "0x4D1079C", VA = "0x4D1079C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009327")]
    [Address(RVA = "0x4D107E4", Offset = "0x4D107E4", VA = "0x4D107E4")]
    public APIDascFgGIDAddDeviceRequest()
    {
    }
  }
}
