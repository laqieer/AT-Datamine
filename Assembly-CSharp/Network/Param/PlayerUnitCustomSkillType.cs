// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitCustomSkillType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AF7")]
  [Serializable]
  public class PlayerUnitCustomSkillType
  {
    [Token(Token = "0x40073BF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40073C0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int custom_skill_id;
    [Token(Token = "0x40073C1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int skill_level;
    [Token(Token = "0x40073C2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int skill_energy;
    [Token(Token = "0x40073C3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private bool is_favorite;
    [Token(Token = "0x40073C4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string created_at;

    [Token(Token = "0x17001C21")]
    public string Id
    {
      [Token(Token = "0x6009DA4"), Address(RVA = "0x48F2DD0", Offset = "0x48F2DD0", VA = "0x48F2DD0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009DA5"), Address(RVA = "0x48F2DD8", Offset = "0x48F2DD8", VA = "0x48F2DD8")] set
      {
      }
    }

    [Token(Token = "0x17001C22")]
    public int CustomSkillId
    {
      [Token(Token = "0x6009DA6"), Address(RVA = "0x48F2DE0", Offset = "0x48F2DE0", VA = "0x48F2DE0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009DA7"), Address(RVA = "0x48F2DE8", Offset = "0x48F2DE8", VA = "0x48F2DE8")] set
      {
      }
    }

    [Token(Token = "0x17001C23")]
    public int SkillLevel
    {
      [Token(Token = "0x6009DA8"), Address(RVA = "0x48F2DF0", Offset = "0x48F2DF0", VA = "0x48F2DF0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009DA9"), Address(RVA = "0x48F2DF8", Offset = "0x48F2DF8", VA = "0x48F2DF8")] set
      {
      }
    }

    [Token(Token = "0x17001C24")]
    public int SkillEnergy
    {
      [Token(Token = "0x6009DAA"), Address(RVA = "0x48F2E00", Offset = "0x48F2E00", VA = "0x48F2E00")] get
      {
        return new int();
      }
      [Token(Token = "0x6009DAB"), Address(RVA = "0x48F2E08", Offset = "0x48F2E08", VA = "0x48F2E08")] set
      {
      }
    }

    [Token(Token = "0x17001C25")]
    public bool IsFavorite
    {
      [Token(Token = "0x6009DAC"), Address(RVA = "0x48F2E10", Offset = "0x48F2E10", VA = "0x48F2E10")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009DAD"), Address(RVA = "0x48F2E18", Offset = "0x48F2E18", VA = "0x48F2E18")] set
      {
      }
    }

    [Token(Token = "0x17001C26")]
    public string CreatedAt
    {
      [Token(Token = "0x6009DAE"), Address(RVA = "0x48F2E24", Offset = "0x48F2E24", VA = "0x48F2E24")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009DAF"), Address(RVA = "0x48F2E2C", Offset = "0x48F2E2C", VA = "0x48F2E2C")] set
      {
      }
    }

    [Token(Token = "0x6009DB0")]
    [Address(RVA = "0x48F2E34", Offset = "0x48F2E34", VA = "0x48F2E34")]
    public PlayerUnitCustomSkillType()
    {
    }
  }
}
