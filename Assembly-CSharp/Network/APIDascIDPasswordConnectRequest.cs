// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordConnectRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019D4")]
  [Serializable]
  public class APIDascIDPasswordConnectRequest
  {
    [Token(Token = "0x4006ECB")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x4006ECC")]
    [FieldOffset(Offset = "0x18")]
    public string secret_key;
    [Token(Token = "0x4006ECD")]
    [FieldOffset(Offset = "0x20")]
    public APIDascIDPasswordConnectInfo connect_info;

    [Token(Token = "0x600938B")]
    [Address(RVA = "0x4D11E1C", Offset = "0x4D11E1C", VA = "0x4D11E1C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600938C")]
    [Address(RVA = "0x4D11E64", Offset = "0x4D11E64", VA = "0x4D11E64")]
    public APIDascIDPasswordConnectRequest()
    {
    }
  }
}
