// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponSkillEnhanceRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001F07")]
  [Serializable]
  public class APIWeaponSkillEnhanceRequest
  {
    [Token(Token = "0x4008531")]
    [FieldOffset(Offset = "0x10")]
    public string player_weapon_id;
    [Token(Token = "0x4008532")]
    [FieldOffset(Offset = "0x18")]
    public int try_count;

    [Token(Token = "0x600B859")]
    [Address(RVA = "0x2133EEC", Offset = "0x2133EEC", VA = "0x2133EEC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B85A")]
    [Address(RVA = "0x2133F34", Offset = "0x2133F34", VA = "0x2133F34")]
    public APIWeaponSkillEnhanceRequest()
    {
    }
  }
}
