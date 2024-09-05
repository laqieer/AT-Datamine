// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStoryFacilityType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AE8")]
  [Serializable]
  public class PlayerStoryFacilityType
  {
    [Token(Token = "0x4007361")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int facility_id;
    [Token(Token = "0x4007362")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int total_use_count;
    [Token(Token = "0x4007363")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int last_use_sequence_id;
    [Token(Token = "0x4007364")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int level;
    [Token(Token = "0x4007365")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int rent_item_id;

    [Token(Token = "0x17001BC3")]
    public int FacilityId
    {
      [Token(Token = "0x6009CD9"), Address(RVA = "0x48F2770", Offset = "0x48F2770", VA = "0x48F2770")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CDA"), Address(RVA = "0x48F2778", Offset = "0x48F2778", VA = "0x48F2778")] set
      {
      }
    }

    [Token(Token = "0x17001BC4")]
    public int TotalUseCount
    {
      [Token(Token = "0x6009CDB"), Address(RVA = "0x48F2780", Offset = "0x48F2780", VA = "0x48F2780")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CDC"), Address(RVA = "0x48F2788", Offset = "0x48F2788", VA = "0x48F2788")] set
      {
      }
    }

    [Token(Token = "0x17001BC5")]
    public int LastUseSequenceId
    {
      [Token(Token = "0x6009CDD"), Address(RVA = "0x48F2790", Offset = "0x48F2790", VA = "0x48F2790")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CDE"), Address(RVA = "0x48F2798", Offset = "0x48F2798", VA = "0x48F2798")] set
      {
      }
    }

    [Token(Token = "0x17001BC6")]
    public int Level
    {
      [Token(Token = "0x6009CDF"), Address(RVA = "0x48F27A0", Offset = "0x48F27A0", VA = "0x48F27A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CE0"), Address(RVA = "0x48F27A8", Offset = "0x48F27A8", VA = "0x48F27A8")] set
      {
      }
    }

    [Token(Token = "0x17001BC7")]
    public int RentItemId
    {
      [Token(Token = "0x6009CE1"), Address(RVA = "0x48F27B0", Offset = "0x48F27B0", VA = "0x48F27B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CE2"), Address(RVA = "0x48F27B8", Offset = "0x48F27B8", VA = "0x48F27B8")] set
      {
      }
    }

    [Token(Token = "0x6009CE3")]
    [Address(RVA = "0x48F27C0", Offset = "0x48F27C0", VA = "0x48F27C0")]
    public PlayerStoryFacilityType()
    {
    }
  }
}
