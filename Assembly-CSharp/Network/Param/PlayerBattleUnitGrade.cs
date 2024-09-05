// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleUnitGrade
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
  [Token(Token = "0x2001A92")]
  [Serializable]
  public class PlayerBattleUnitGrade
  {
    [Token(Token = "0x40071F1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_unit_id;
    [Token(Token = "0x40071F2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x40071F3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<int> killed_enemy_ids;

    [Token(Token = "0x17001A35")]
    public string PlayerUnitId
    {
      [Token(Token = "0x6009985"), Address(RVA = "0x48F0A28", Offset = "0x48F0A28", VA = "0x48F0A28")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009986"), Address(RVA = "0x48F0A30", Offset = "0x48F0A30", VA = "0x48F0A30")] set
      {
      }
    }

    [Token(Token = "0x17001A36")]
    public int Experience
    {
      [Token(Token = "0x6009987"), Address(RVA = "0x48F0A38", Offset = "0x48F0A38", VA = "0x48F0A38")] get
      {
        return new int();
      }
      [Token(Token = "0x6009988"), Address(RVA = "0x48F0A40", Offset = "0x48F0A40", VA = "0x48F0A40")] set
      {
      }
    }

    [Token(Token = "0x17001A37")]
    public List<int> KilledEnemyIds
    {
      [Token(Token = "0x6009989"), Address(RVA = "0x48F0A48", Offset = "0x48F0A48", VA = "0x48F0A48")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600998A"), Address(RVA = "0x48F0A50", Offset = "0x48F0A50", VA = "0x48F0A50")] set
      {
      }
    }

    [Token(Token = "0x600998B")]
    [Address(RVA = "0x48F0A58", Offset = "0x48F0A58", VA = "0x48F0A58")]
    public PlayerBattleUnitGrade()
    {
    }
  }
}
