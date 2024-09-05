// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordDisconnectRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019DD")]
  [Serializable]
  public class APIDascIDPasswordDisconnectRequest
  {
    [Token(Token = "0x4006EE4")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x4006EE5")]
    [FieldOffset(Offset = "0x18")]
    public string secret_key;
    [Token(Token = "0x4006EE6")]
    [FieldOffset(Offset = "0x20")]
    public APIDascIDPasswordConnectInfo connect_info;

    [Token(Token = "0x60093B4")]
    [Address(RVA = "0x4D1267C", Offset = "0x4D1267C", VA = "0x4D1267C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x60093B5")]
    [Address(RVA = "0x4D126C4", Offset = "0x4D126C4", VA = "0x4D126C4")]
    public APIDascIDPasswordDisconnectRequest()
    {
    }
  }
}
