// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGearUnitTrustType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ABE")]
  [Serializable]
  public class PlayerGearUnitTrustType
  {
    [Token(Token = "0x400729B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x400729C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int unit_trust_id;
    [Token(Token = "0x400729D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int skill_level;
    [Token(Token = "0x400729E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int skill_energy;
    [Token(Token = "0x400729F")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private bool is_favorite;
    [Token(Token = "0x40072A0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string created_at;

    [Token(Token = "0x17001AF1")]
    public string Id
    {
      [Token(Token = "0x6009B17"), Address(RVA = "0x48F18C4", Offset = "0x48F18C4", VA = "0x48F18C4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009B18"), Address(RVA = "0x48F18CC", Offset = "0x48F18CC", VA = "0x48F18CC")] set
      {
      }
    }

    [Token(Token = "0x17001AF2")]
    public int UnitTrustId
    {
      [Token(Token = "0x6009B19"), Address(RVA = "0x48F18D4", Offset = "0x48F18D4", VA = "0x48F18D4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B1A"), Address(RVA = "0x48F18DC", Offset = "0x48F18DC", VA = "0x48F18DC")] set
      {
      }
    }

    [Token(Token = "0x17001AF3")]
    public int SkillLevel
    {
      [Token(Token = "0x6009B1B"), Address(RVA = "0x48F18E4", Offset = "0x48F18E4", VA = "0x48F18E4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B1C"), Address(RVA = "0x48F18EC", Offset = "0x48F18EC", VA = "0x48F18EC")] set
      {
      }
    }

    [Token(Token = "0x17001AF4")]
    public int SkillEnergy
    {
      [Token(Token = "0x6009B1D"), Address(RVA = "0x48F18F4", Offset = "0x48F18F4", VA = "0x48F18F4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B1E"), Address(RVA = "0x48F18FC", Offset = "0x48F18FC", VA = "0x48F18FC")] set
      {
      }
    }

    [Token(Token = "0x17001AF5")]
    public bool IsFavorite
    {
      [Token(Token = "0x6009B1F"), Address(RVA = "0x48F1904", Offset = "0x48F1904", VA = "0x48F1904")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009B20"), Address(RVA = "0x48F190C", Offset = "0x48F190C", VA = "0x48F190C")] set
      {
      }
    }

    [Token(Token = "0x17001AF6")]
    public string CreatedAt
    {
      [Token(Token = "0x6009B21"), Address(RVA = "0x48F1918", Offset = "0x48F1918", VA = "0x48F1918")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009B22"), Address(RVA = "0x48F1920", Offset = "0x48F1920", VA = "0x48F1920")] set
      {
      }
    }

    [Token(Token = "0x6009B23")]
    [Address(RVA = "0x48F1928", Offset = "0x48F1928", VA = "0x48F1928")]
    public PlayerGearUnitTrustType()
    {
    }
  }
}
