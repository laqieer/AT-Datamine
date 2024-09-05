// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitRarityupRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EC3")]
  [Serializable]
  public class APIUnitRarityupRequest
  {
    [Token(Token = "0x4008421")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;
    [Token(Token = "0x4008422")]
    [FieldOffset(Offset = "0x18")]
    public int break_limit_count;

    [Token(Token = "0x600B6AF")]
    [Address(RVA = "0x22ED7FC", Offset = "0x22ED7FC", VA = "0x22ED7FC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B6B0")]
    [Address(RVA = "0x22ED844", Offset = "0x22ED844", VA = "0x22ED844")]
    public APIUnitRarityupRequest()
    {
    }
  }
}
