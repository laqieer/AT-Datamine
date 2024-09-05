// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B8F")]
  [Serializable]
  public class APIArenaBattleStartRequest
  {
    [Token(Token = "0x400762C")]
    [FieldOffset(Offset = "0x10")]
    public long arena_id;
    [Token(Token = "0x400762D")]
    [FieldOffset(Offset = "0x18")]
    public int ranking;

    [Token(Token = "0x600A1EA")]
    [Address(RVA = "0x46C9820", Offset = "0x46C9820", VA = "0x46C9820")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A1EB")]
    [Address(RVA = "0x46C9868", Offset = "0x46C9868", VA = "0x46C9868")]
    public APIArenaBattleStartRequest()
    {
    }
  }
}
