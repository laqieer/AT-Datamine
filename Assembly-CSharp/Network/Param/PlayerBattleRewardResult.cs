// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleRewardResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A90")]
  [Serializable]
  public class PlayerBattleRewardResult
  {
    [Token(Token = "0x40071DD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<RewardGiveResultEntityType> battle_clear_result;
    [Token(Token = "0x40071DE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<RewardGiveResultEntityType> enemy_fixed_drop_result;
    [Token(Token = "0x40071DF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerBattleDropRewardResult> chest_drop_result;
    [Token(Token = "0x40071E0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleDropRewardResult> enemy_drop_result;
    [Token(Token = "0x40071E1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<RewardGiveResultEntityType> mission_result;
    [Token(Token = "0x40071E2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<RewardGiveResultEntityType> clear_count_bonus_result;

    [Token(Token = "0x17001A21")]
    public List<RewardGiveResultEntityType> BattleClearResult
    {
      [Token(Token = "0x600995B"), Address(RVA = "0x48F08D8", Offset = "0x48F08D8", VA = "0x48F08D8")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
      [Token(Token = "0x600995C"), Address(RVA = "0x48F08E0", Offset = "0x48F08E0", VA = "0x48F08E0")] set
      {
      }
    }

    [Token(Token = "0x17001A22")]
    public List<RewardGiveResultEntityType> EnemyFixedDropResult
    {
      [Token(Token = "0x600995D"), Address(RVA = "0x48F08E8", Offset = "0x48F08E8", VA = "0x48F08E8")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
      [Token(Token = "0x600995E"), Address(RVA = "0x48F08F0", Offset = "0x48F08F0", VA = "0x48F08F0")] set
      {
      }
    }

    [Token(Token = "0x17001A23")]
    public List<PlayerBattleDropRewardResult> ChestDropResult
    {
      [Token(Token = "0x600995F"), Address(RVA = "0x48F08F8", Offset = "0x48F08F8", VA = "0x48F08F8")] get
      {
        return (List<PlayerBattleDropRewardResult>) null;
      }
      [Token(Token = "0x6009960"), Address(RVA = "0x48F0900", Offset = "0x48F0900", VA = "0x48F0900")] set
      {
      }
    }

    [Token(Token = "0x17001A24")]
    public List<PlayerBattleDropRewardResult> EnemyDropResult
    {
      [Token(Token = "0x6009961"), Address(RVA = "0x48F0908", Offset = "0x48F0908", VA = "0x48F0908")] get
      {
        return (List<PlayerBattleDropRewardResult>) null;
      }
      [Token(Token = "0x6009962"), Address(RVA = "0x48F0910", Offset = "0x48F0910", VA = "0x48F0910")] set
      {
      }
    }

    [Token(Token = "0x17001A25")]
    public List<RewardGiveResultEntityType> MissionResult
    {
      [Token(Token = "0x6009963"), Address(RVA = "0x48F0918", Offset = "0x48F0918", VA = "0x48F0918")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
      [Token(Token = "0x6009964"), Address(RVA = "0x48F0920", Offset = "0x48F0920", VA = "0x48F0920")] set
      {
      }
    }

    [Token(Token = "0x17001A26")]
    public List<RewardGiveResultEntityType> ClearCountBonusResult
    {
      [Token(Token = "0x6009965"), Address(RVA = "0x48F0928", Offset = "0x48F0928", VA = "0x48F0928")] get
      {
        return (List<RewardGiveResultEntityType>) null;
      }
      [Token(Token = "0x6009966"), Address(RVA = "0x48F0930", Offset = "0x48F0930", VA = "0x48F0930")] set
      {
      }
    }

    [Token(Token = "0x6009967")]
    [Address(RVA = "0x48F0938", Offset = "0x48F0938", VA = "0x48F0938")]
    public PlayerBattleRewardResult()
    {
    }
  }
}
