// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleChestDropType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A8A")]
  [Serializable]
  public class PlayerBattleChestDropType
  {
    [Token(Token = "0x40071BF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int facility_placement_description_id;
    [Token(Token = "0x40071C0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int battle_drop_reward_type_id;

    [Token(Token = "0x17001A03")]
    public int FacilityPlacementDescriptionId
    {
      [Token(Token = "0x6009919"), Address(RVA = "0x48F06C4", Offset = "0x48F06C4", VA = "0x48F06C4")] get
      {
        return new int();
      }
      [Token(Token = "0x600991A"), Address(RVA = "0x48F06CC", Offset = "0x48F06CC", VA = "0x48F06CC")] set
      {
      }
    }

    [Token(Token = "0x17001A04")]
    public int BattleDropRewardTypeId
    {
      [Token(Token = "0x600991B"), Address(RVA = "0x48F06D4", Offset = "0x48F06D4", VA = "0x48F06D4")] get
      {
        return new int();
      }
      [Token(Token = "0x600991C"), Address(RVA = "0x48F06DC", Offset = "0x48F06DC", VA = "0x48F06DC")] set
      {
      }
    }

    [Token(Token = "0x600991D")]
    [Address(RVA = "0x48F06E4", Offset = "0x48F06E4", VA = "0x48F06E4")]
    public PlayerBattleChestDropType()
    {
    }
  }
}
