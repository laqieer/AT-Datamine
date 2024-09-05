// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGearMindEquipmentType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ABB")]
  [Serializable]
  public class PlayerGearMindEquipmentType
  {
    [Token(Token = "0x400728F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007290")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int mind_equipment_id;
    [Token(Token = "0x4007291")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int limit_break_count;
    [Token(Token = "0x4007292")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x4007293")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private bool is_favorite;
    [Token(Token = "0x4007294")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int duplicate_count;
    [Token(Token = "0x4007295")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string created_at;

    [Token(Token = "0x17001AE5")]
    public string Id
    {
      [Token(Token = "0x6009AFC"), Address(RVA = "0x48F17E8", Offset = "0x48F17E8", VA = "0x48F17E8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AFD"), Address(RVA = "0x48F17F0", Offset = "0x48F17F0", VA = "0x48F17F0")] set
      {
      }
    }

    [Token(Token = "0x17001AE6")]
    public int MindEquipmentId
    {
      [Token(Token = "0x6009AFE"), Address(RVA = "0x48F17F8", Offset = "0x48F17F8", VA = "0x48F17F8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AFF"), Address(RVA = "0x48F1800", Offset = "0x48F1800", VA = "0x48F1800")] set
      {
      }
    }

    [Token(Token = "0x17001AE7")]
    public int LimitBreakCount
    {
      [Token(Token = "0x6009B00"), Address(RVA = "0x48F1808", Offset = "0x48F1808", VA = "0x48F1808")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B01"), Address(RVA = "0x48F1810", Offset = "0x48F1810", VA = "0x48F1810")] set
      {
      }
    }

    [Token(Token = "0x17001AE8")]
    public int Experience
    {
      [Token(Token = "0x6009B02"), Address(RVA = "0x48F1818", Offset = "0x48F1818", VA = "0x48F1818")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B03"), Address(RVA = "0x48F1820", Offset = "0x48F1820", VA = "0x48F1820")] set
      {
      }
    }

    [Token(Token = "0x17001AE9")]
    public bool IsFavorite
    {
      [Token(Token = "0x6009B04"), Address(RVA = "0x48F1828", Offset = "0x48F1828", VA = "0x48F1828")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009B05"), Address(RVA = "0x48F1830", Offset = "0x48F1830", VA = "0x48F1830")] set
      {
      }
    }

    [Token(Token = "0x17001AEA")]
    public int DuplicateCount
    {
      [Token(Token = "0x6009B06"), Address(RVA = "0x48F183C", Offset = "0x48F183C", VA = "0x48F183C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B07"), Address(RVA = "0x48F1844", Offset = "0x48F1844", VA = "0x48F1844")] set
      {
      }
    }

    [Token(Token = "0x17001AEB")]
    public string CreatedAt
    {
      [Token(Token = "0x6009B08"), Address(RVA = "0x48F184C", Offset = "0x48F184C", VA = "0x48F184C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009B09"), Address(RVA = "0x48F1854", Offset = "0x48F1854", VA = "0x48F1854")] set
      {
      }
    }

    [Token(Token = "0x6009B0A")]
    [Address(RVA = "0x48F185C", Offset = "0x48F185C", VA = "0x48F185C")]
    public PlayerGearMindEquipmentType()
    {
    }
  }
}
