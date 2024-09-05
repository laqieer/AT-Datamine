// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleDropRewardResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A8C")]
  [Serializable]
  public class PlayerBattleDropRewardResult
  {
    [Token(Token = "0x40071C4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int reward_type;
    [Token(Token = "0x40071C5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int reward_id;
    [Token(Token = "0x40071C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int reward_quantity;
    [Token(Token = "0x40071C7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool is_new;
    [Token(Token = "0x40071C8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string reward_result_id;
    [Token(Token = "0x40071C9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int battle_drop_reward_type_id;

    [Token(Token = "0x17001A08")]
    public int RewardType
    {
      [Token(Token = "0x6009925"), Address(RVA = "0x48F0724", Offset = "0x48F0724", VA = "0x48F0724")] get
      {
        return new int();
      }
      [Token(Token = "0x6009926"), Address(RVA = "0x48F072C", Offset = "0x48F072C", VA = "0x48F072C")] set
      {
      }
    }

    [Token(Token = "0x17001A09")]
    public int RewardId
    {
      [Token(Token = "0x6009927"), Address(RVA = "0x48F0734", Offset = "0x48F0734", VA = "0x48F0734")] get
      {
        return new int();
      }
      [Token(Token = "0x6009928"), Address(RVA = "0x48F073C", Offset = "0x48F073C", VA = "0x48F073C")] set
      {
      }
    }

    [Token(Token = "0x17001A0A")]
    public int RewardQuantity
    {
      [Token(Token = "0x6009929"), Address(RVA = "0x48F0744", Offset = "0x48F0744", VA = "0x48F0744")] get
      {
        return new int();
      }
      [Token(Token = "0x600992A"), Address(RVA = "0x48F074C", Offset = "0x48F074C", VA = "0x48F074C")] set
      {
      }
    }

    [Token(Token = "0x17001A0B")]
    public bool IsNew
    {
      [Token(Token = "0x600992B"), Address(RVA = "0x48F0754", Offset = "0x48F0754", VA = "0x48F0754")] get
      {
        return new bool();
      }
      [Token(Token = "0x600992C"), Address(RVA = "0x48F075C", Offset = "0x48F075C", VA = "0x48F075C")] set
      {
      }
    }

    [Token(Token = "0x17001A0C")]
    public string RewardResultId
    {
      [Token(Token = "0x600992D"), Address(RVA = "0x48F0768", Offset = "0x48F0768", VA = "0x48F0768")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600992E"), Address(RVA = "0x48F0770", Offset = "0x48F0770", VA = "0x48F0770")] set
      {
      }
    }

    [Token(Token = "0x17001A0D")]
    public int BattleDropRewardTypeId
    {
      [Token(Token = "0x600992F"), Address(RVA = "0x48F0778", Offset = "0x48F0778", VA = "0x48F0778")] get
      {
        return new int();
      }
      [Token(Token = "0x6009930"), Address(RVA = "0x48F0780", Offset = "0x48F0780", VA = "0x48F0780")] set
      {
      }
    }

    [Token(Token = "0x6009931")]
    [Address(RVA = "0x48F0788", Offset = "0x48F0788", VA = "0x48F0788")]
    public PlayerBattleDropRewardResult()
    {
    }
  }
}
