// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerFggfcCoinMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AB1")]
  [Serializable]
  public class PlayerFggfcCoinMission
  {
    [Token(Token = "0x4007262")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int mission_id;
    [Token(Token = "0x4007263")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string name;
    [Token(Token = "0x4007264")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string description;
    [Token(Token = "0x4007265")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string possible_end_at;
    [Token(Token = "0x4007266")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string end_at;
    [Token(Token = "0x4007267")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private long reward_quantity;
    [Token(Token = "0x4007268")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private bool is_achieved;

    [Token(Token = "0x17001AAF")]
    public int MissionId
    {
      [Token(Token = "0x6009A8F"), Address(RVA = "0x48F1374", Offset = "0x48F1374", VA = "0x48F1374")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A90"), Address(RVA = "0x48F137C", Offset = "0x48F137C", VA = "0x48F137C")] set
      {
      }
    }

    [Token(Token = "0x17001AB0")]
    public string Name
    {
      [Token(Token = "0x6009A91"), Address(RVA = "0x48F1384", Offset = "0x48F1384", VA = "0x48F1384")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A92"), Address(RVA = "0x48F138C", Offset = "0x48F138C", VA = "0x48F138C")] set
      {
      }
    }

    [Token(Token = "0x17001AB1")]
    public string Description
    {
      [Token(Token = "0x6009A93"), Address(RVA = "0x48F1394", Offset = "0x48F1394", VA = "0x48F1394")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A94"), Address(RVA = "0x48F139C", Offset = "0x48F139C", VA = "0x48F139C")] set
      {
      }
    }

    [Token(Token = "0x17001AB2")]
    public string PossibleEndAt
    {
      [Token(Token = "0x6009A95"), Address(RVA = "0x48F13A4", Offset = "0x48F13A4", VA = "0x48F13A4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A96"), Address(RVA = "0x48F13AC", Offset = "0x48F13AC", VA = "0x48F13AC")] set
      {
      }
    }

    [Token(Token = "0x17001AB3")]
    public string EndAt
    {
      [Token(Token = "0x6009A97"), Address(RVA = "0x48F13B4", Offset = "0x48F13B4", VA = "0x48F13B4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A98"), Address(RVA = "0x48F13BC", Offset = "0x48F13BC", VA = "0x48F13BC")] set
      {
      }
    }

    [Token(Token = "0x17001AB4")]
    public long RewardQuantity
    {
      [Token(Token = "0x6009A99"), Address(RVA = "0x48F13C4", Offset = "0x48F13C4", VA = "0x48F13C4")] get
      {
        return new long();
      }
      [Token(Token = "0x6009A9A"), Address(RVA = "0x48F13CC", Offset = "0x48F13CC", VA = "0x48F13CC")] set
      {
      }
    }

    [Token(Token = "0x17001AB5")]
    public bool IsAchieved
    {
      [Token(Token = "0x6009A9B"), Address(RVA = "0x48F13D4", Offset = "0x48F13D4", VA = "0x48F13D4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009A9C"), Address(RVA = "0x48F13DC", Offset = "0x48F13DC", VA = "0x48F13DC")] set
      {
      }
    }

    [Token(Token = "0x6009A9D")]
    [Address(RVA = "0x48F13E8", Offset = "0x48F13E8", VA = "0x48F13E8")]
    public PlayerFggfcCoinMission()
    {
    }
  }
}
