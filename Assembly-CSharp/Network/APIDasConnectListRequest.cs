// Decompiled with JetBrains decompiler
// Type: Network.APIDasConnectListRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019E6")]
  [Serializable]
  public class APIDasConnectListRequest
  {
    [Token(Token = "0x4006F00")]
    [FieldOffset(Offset = "0x10")]
    public string secret_key;
    [Token(Token = "0x4006F01")]
    [FieldOffset(Offset = "0x18")]
    public string device_id;

    [Token(Token = "0x60093DD")]
    [Address(RVA = "0x4D12EF4", Offset = "0x4D12EF4", VA = "0x4D12EF4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x60093DE")]
    [Address(RVA = "0x4D12F3C", Offset = "0x4D12F3C", VA = "0x4D12F3C")]
    public APIDasConnectListRequest()
    {
    }
  }
}
