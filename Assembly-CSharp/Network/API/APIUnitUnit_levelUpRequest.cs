// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitUnit_levelUpRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EDF")]
  [Serializable]
  public class APIUnitUnit_levelUpRequest
  {
    [Token(Token = "0x4008495")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_id;
    [Token(Token = "0x4008496")]
    [FieldOffset(Offset = "0x18")]
    public int blue_soul_count;

    [Token(Token = "0x600B75F")]
    [Address(RVA = "0x2130904", Offset = "0x2130904", VA = "0x2130904")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B760")]
    [Address(RVA = "0x213094C", Offset = "0x213094C", VA = "0x213094C")]
    public APIUnitUnit_levelUpRequest()
    {
    }
  }
}
