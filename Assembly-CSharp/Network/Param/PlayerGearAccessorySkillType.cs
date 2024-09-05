// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGearAccessorySkillType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AB8")]
  [Serializable]
  public class PlayerGearAccessorySkillType
  {
    [Token(Token = "0x4007282")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int skill_id;
    [Token(Token = "0x4007283")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int skill_level;
    [Token(Token = "0x4007284")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int skill_energy;

    [Token(Token = "0x17001AD8")]
    public int SkillId
    {
      [Token(Token = "0x6009ADF"), Address(RVA = "0x48F16FC", Offset = "0x48F16FC", VA = "0x48F16FC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AE0"), Address(RVA = "0x48F1704", Offset = "0x48F1704", VA = "0x48F1704")] set
      {
      }
    }

    [Token(Token = "0x17001AD9")]
    public int SkillLevel
    {
      [Token(Token = "0x6009AE1"), Address(RVA = "0x48F170C", Offset = "0x48F170C", VA = "0x48F170C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AE2"), Address(RVA = "0x48F1714", Offset = "0x48F1714", VA = "0x48F1714")] set
      {
      }
    }

    [Token(Token = "0x17001ADA")]
    public int SkillEnergy
    {
      [Token(Token = "0x6009AE3"), Address(RVA = "0x48F171C", Offset = "0x48F171C", VA = "0x48F171C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AE4"), Address(RVA = "0x48F1724", Offset = "0x48F1724", VA = "0x48F1724")] set
      {
      }
    }

    [Token(Token = "0x6009AE5")]
    [Address(RVA = "0x48F172C", Offset = "0x48F172C", VA = "0x48F172C")]
    public PlayerGearAccessorySkillType()
    {
    }
  }
}
