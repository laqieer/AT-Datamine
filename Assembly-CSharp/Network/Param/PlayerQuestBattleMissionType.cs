// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerQuestBattleMissionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ACF")]
  [Serializable]
  public class PlayerQuestBattleMissionType
  {
    [Token(Token = "0x40072E5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int quest_id;
    [Token(Token = "0x40072E6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int battle_mission_id;
    [Token(Token = "0x40072E7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool achieved;

    [Token(Token = "0x17001B47")]
    public int QuestId
    {
      [Token(Token = "0x6009BC8"), Address(RVA = "0x48F1EC8", Offset = "0x48F1EC8", VA = "0x48F1EC8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BC9"), Address(RVA = "0x48F1ED0", Offset = "0x48F1ED0", VA = "0x48F1ED0")] set
      {
      }
    }

    [Token(Token = "0x17001B48")]
    public int BattleMissionId
    {
      [Token(Token = "0x6009BCA"), Address(RVA = "0x48F1ED8", Offset = "0x48F1ED8", VA = "0x48F1ED8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009BCB"), Address(RVA = "0x48F1EE0", Offset = "0x48F1EE0", VA = "0x48F1EE0")] set
      {
      }
    }

    [Token(Token = "0x17001B49")]
    public bool Achieved
    {
      [Token(Token = "0x6009BCC"), Address(RVA = "0x48F1EE8", Offset = "0x48F1EE8", VA = "0x48F1EE8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009BCD"), Address(RVA = "0x48F1EF0", Offset = "0x48F1EF0", VA = "0x48F1EF0")] set
      {
      }
    }

    [Token(Token = "0x6009BCE")]
    [Address(RVA = "0x48F1EFC", Offset = "0x48F1EFC", VA = "0x48F1EFC")]
    public PlayerQuestBattleMissionType()
    {
    }
  }
}
