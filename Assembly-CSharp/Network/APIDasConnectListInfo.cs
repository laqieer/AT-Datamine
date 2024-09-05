// Decompiled with JetBrains decompiler
// Type: Network.APIDasConnectListInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019E4")]
  [Serializable]
  public class APIDasConnectListInfo
  {
    [Token(Token = "0x4006EFB")]
    [FieldOffset(Offset = "0x10")]
    public string connect_id;
    [Token(Token = "0x4006EFC")]
    [FieldOffset(Offset = "0x18")]
    public string expiry_time;
    [Token(Token = "0x4006EFD")]
    [FieldOffset(Offset = "0x20")]
    public string platform;
    [Token(Token = "0x4006EFE")]
    [FieldOffset(Offset = "0x28")]
    public string version;

    [Token(Token = "0x60093DB")]
    [Address(RVA = "0x4D12EE4", Offset = "0x4D12EE4", VA = "0x4D12EE4")]
    public APIDasConnectListInfo()
    {
    }
  }
}
