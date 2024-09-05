// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordConnectInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019D7")]
  [Serializable]
  public class APIDascIDPasswordConnectInfo
  {
    [Token(Token = "0x4006ED7")]
    [FieldOffset(Offset = "0x10")]
    public string user_id;
    [Token(Token = "0x4006ED8")]
    [FieldOffset(Offset = "0x18")]
    public string user_secret;

    [Token(Token = "0x600939E")]
    [Address(RVA = "0x4D12240", Offset = "0x4D12240", VA = "0x4D12240")]
    public APIDascIDPasswordConnectInfo()
    {
    }
  }
}
