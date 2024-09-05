// Decompiled with JetBrains decompiler
// Type: UnitView.UI.Test.UnitInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitView.UI.Test
{
  [Token(Token = "0x200040C")]
  [Serializable]
  public class UnitInfo
  {
    [Token(Token = "0x400170C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int uniqueID;
    [Token(Token = "0x400170D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ProfileInfo profile;
    [Token(Token = "0x400170E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SkillInfo skill;

    [Token(Token = "0x17000291")]
    public ProfileInfo Profile
    {
      [Token(Token = "0x6001705"), Address(RVA = "0x248A278", Offset = "0x248A278", VA = "0x248A278")] set
      {
      }
      [Token(Token = "0x6001706"), Address(RVA = "0x248A280", Offset = "0x248A280", VA = "0x248A280")] get
      {
        return (ProfileInfo) null;
      }
    }

    [Token(Token = "0x17000292")]
    public int UniqueID
    {
      [Token(Token = "0x6001707"), Address(RVA = "0x248A288", Offset = "0x248A288", VA = "0x248A288")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000293")]
    public WeaponsInfo Weapons
    {
      [Token(Token = "0x6001708"), Address(RVA = "0x248A290", Offset = "0x248A290", VA = "0x248A290")] get
      {
        return (WeaponsInfo) null;
      }
    }

    [Token(Token = "0x17000294")]
    public SkillInfo Skill
    {
      [Token(Token = "0x6001709"), Address(RVA = "0x248A298", Offset = "0x248A298", VA = "0x248A298")] get
      {
        return (SkillInfo) null;
      }
    }

    [Token(Token = "0x600170A")]
    [Address(RVA = "0x248A2A0", Offset = "0x248A2A0", VA = "0x248A2A0")]
    public UnitInfo()
    {
    }
  }
}
