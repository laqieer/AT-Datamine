// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerFggIDAchievementMission
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
  [Token(Token = "0x2001AB3")]
  [Serializable]
  public class PlayerFggIDAchievementMission
  {
    [Token(Token = "0x400726C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int mission_id;
    [Token(Token = "0x400726D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int game_id;
    [Token(Token = "0x400726E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string name;
    [Token(Token = "0x400726F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string description;
    [Token(Token = "0x4007270")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string possible_end_at;
    [Token(Token = "0x4007271")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string end_at;
    [Token(Token = "0x4007272")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<FggfcRewardEntityType> rewards;
    [Token(Token = "0x4007273")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private bool is_achieved;

    [Token(Token = "0x17001AB9")]
    public int MissionId
    {
      [Token(Token = "0x6009AA5"), Address(RVA = "0x48F1428", Offset = "0x48F1428", VA = "0x48F1428")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AA6"), Address(RVA = "0x48F1430", Offset = "0x48F1430", VA = "0x48F1430")] set
      {
      }
    }

    [Token(Token = "0x17001ABA")]
    public int GameId
    {
      [Token(Token = "0x6009AA7"), Address(RVA = "0x48F1438", Offset = "0x48F1438", VA = "0x48F1438")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AA8"), Address(RVA = "0x48F1440", Offset = "0x48F1440", VA = "0x48F1440")] set
      {
      }
    }

    [Token(Token = "0x17001ABB")]
    public string Name
    {
      [Token(Token = "0x6009AA9"), Address(RVA = "0x48F1448", Offset = "0x48F1448", VA = "0x48F1448")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AAA"), Address(RVA = "0x48F1450", Offset = "0x48F1450", VA = "0x48F1450")] set
      {
      }
    }

    [Token(Token = "0x17001ABC")]
    public string Description
    {
      [Token(Token = "0x6009AAB"), Address(RVA = "0x48F1458", Offset = "0x48F1458", VA = "0x48F1458")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AAC"), Address(RVA = "0x48F1460", Offset = "0x48F1460", VA = "0x48F1460")] set
      {
      }
    }

    [Token(Token = "0x17001ABD")]
    public string PossibleEndAt
    {
      [Token(Token = "0x6009AAD"), Address(RVA = "0x48F1468", Offset = "0x48F1468", VA = "0x48F1468")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AAE"), Address(RVA = "0x48F1470", Offset = "0x48F1470", VA = "0x48F1470")] set
      {
      }
    }

    [Token(Token = "0x17001ABE")]
    public string EndAt
    {
      [Token(Token = "0x6009AAF"), Address(RVA = "0x48F1478", Offset = "0x48F1478", VA = "0x48F1478")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AB0"), Address(RVA = "0x48F1480", Offset = "0x48F1480", VA = "0x48F1480")] set
      {
      }
    }

    [Token(Token = "0x17001ABF")]
    public List<FggfcRewardEntityType> Rewards
    {
      [Token(Token = "0x6009AB1"), Address(RVA = "0x48F1488", Offset = "0x48F1488", VA = "0x48F1488")] get
      {
        return (List<FggfcRewardEntityType>) null;
      }
      [Token(Token = "0x6009AB2"), Address(RVA = "0x48F1490", Offset = "0x48F1490", VA = "0x48F1490")] set
      {
      }
    }

    [Token(Token = "0x17001AC0")]
    public bool IsAchieved
    {
      [Token(Token = "0x6009AB3"), Address(RVA = "0x48F1498", Offset = "0x48F1498", VA = "0x48F1498")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009AB4"), Address(RVA = "0x48F14A0", Offset = "0x48F14A0", VA = "0x48F14A0")] set
      {
      }
    }

    [Token(Token = "0x6009AB5")]
    [Address(RVA = "0x48F14AC", Offset = "0x48F14AC", VA = "0x48F14AC")]
    public PlayerFggIDAchievementMission()
    {
    }
  }
}
