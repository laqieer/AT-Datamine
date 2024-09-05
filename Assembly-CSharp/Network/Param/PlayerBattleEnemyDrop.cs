// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleEnemyDrop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A8D")]
  [Serializable]
  public class PlayerBattleEnemyDrop
  {
    [Token(Token = "0x40071CA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int enemy_id;
    [Token(Token = "0x40071CB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int battle_drop_reward_type_id;

    [Token(Token = "0x17001A0E")]
    public int EnemyId
    {
      [Token(Token = "0x6009932"), Address(RVA = "0x48F0790", Offset = "0x48F0790", VA = "0x48F0790")] get
      {
        return new int();
      }
      [Token(Token = "0x6009933"), Address(RVA = "0x48F0798", Offset = "0x48F0798", VA = "0x48F0798")] set
      {
      }
    }

    [Token(Token = "0x17001A0F")]
    public int BattleDropRewardTypeId
    {
      [Token(Token = "0x6009934"), Address(RVA = "0x48F07A0", Offset = "0x48F07A0", VA = "0x48F07A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009935"), Address(RVA = "0x48F07A8", Offset = "0x48F07A8", VA = "0x48F07A8")] set
      {
      }
    }

    [Token(Token = "0x6009936")]
    [Address(RVA = "0x48F07B0", Offset = "0x48F07B0", VA = "0x48F07B0")]
    public PlayerBattleEnemyDrop()
    {
    }
  }
}
