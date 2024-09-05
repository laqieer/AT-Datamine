// Decompiled with JetBrains decompiler
// Type: Network.APIDascFgGIDDisconnectRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019C8")]
  [Serializable]
  public class APIDascFgGIDDisconnectRequest
  {
    [Token(Token = "0x4006EA5")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x4006EA6")]
    [FieldOffset(Offset = "0x18")]
    public string secret_key;
    [Token(Token = "0x4006EA7")]
    [FieldOffset(Offset = "0x20")]
    public APIDascFgGIDConnectInfo connect_info;

    [Token(Token = "0x600934F")]
    [Address(RVA = "0x4D11198", Offset = "0x4D11198", VA = "0x4D11198")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009350")]
    [Address(RVA = "0x4D111E0", Offset = "0x4D111E0", VA = "0x4D111E0")]
    public APIDascFgGIDDisconnectRequest()
    {
    }
  }
}
