// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGearWeaponSkillType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AC0")]
  [Serializable]
  public class PlayerGearWeaponSkillType
  {
    [Token(Token = "0x40072A3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int skill_id;
    [Token(Token = "0x40072A4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int skill_level;
    [Token(Token = "0x40072A5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int skill_energy;

    [Token(Token = "0x17001AF9")]
    public int SkillId
    {
      [Token(Token = "0x6009B29"), Address(RVA = "0x48F1958", Offset = "0x48F1958", VA = "0x48F1958")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B2A"), Address(RVA = "0x48F1960", Offset = "0x48F1960", VA = "0x48F1960")] set
      {
      }
    }

    [Token(Token = "0x17001AFA")]
    public int SkillLevel
    {
      [Token(Token = "0x6009B2B"), Address(RVA = "0x48F1968", Offset = "0x48F1968", VA = "0x48F1968")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B2C"), Address(RVA = "0x48F1970", Offset = "0x48F1970", VA = "0x48F1970")] set
      {
      }
    }

    [Token(Token = "0x17001AFB")]
    public int SkillEnergy
    {
      [Token(Token = "0x6009B2D"), Address(RVA = "0x48F1978", Offset = "0x48F1978", VA = "0x48F1978")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B2E"), Address(RVA = "0x48F1980", Offset = "0x48F1980", VA = "0x48F1980")] set
      {
      }
    }

    [Token(Token = "0x6009B2F")]
    [Address(RVA = "0x48F1988", Offset = "0x48F1988", VA = "0x48F1988")]
    public PlayerGearWeaponSkillType()
    {
    }
  }
}
