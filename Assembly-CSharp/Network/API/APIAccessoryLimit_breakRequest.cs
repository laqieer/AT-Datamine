// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryLimit_breakRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B3B")]
  [Serializable]
  public class APIAccessoryLimit_breakRequest
  {
    [Token(Token = "0x40074D2")]
    [FieldOffset(Offset = "0x10")]
    public string player_accessory_id;
    [Token(Token = "0x40074D3")]
    [FieldOffset(Offset = "0x18")]
    public int break_limit_count;

    [Token(Token = "0x6009FE1")]
    [Address(RVA = "0x46C270C", Offset = "0x46C270C", VA = "0x46C270C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009FE2")]
    [Address(RVA = "0x46C2754", Offset = "0x46C2754", VA = "0x46C2754")]
    public APIAccessoryLimit_breakRequest()
    {
    }
  }
}
