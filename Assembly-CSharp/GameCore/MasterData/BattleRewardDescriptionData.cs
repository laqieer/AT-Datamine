// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleRewardDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E63")]
  [Serializable]
  public sealed class BattleRewardDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x400459D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400459E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardGroupId;
    [Token(Token = "0x400459F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40045A0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x40045A1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000CF2")]
    public int Key
    {
      [Token(Token = "0x60057B5"), Address(RVA = "0x3E42D24", Offset = "0x3E42D24", VA = "0x3E42D24", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60057B6")]
    [Address(RVA = "0x3E42D2C", Offset = "0x3E42D2C", VA = "0x3E42D2C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60057B7")]
    [Address(RVA = "0x3E42F58", Offset = "0x3E42F58", VA = "0x3E42F58", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60057B8")]
    [Address(RVA = "0x3E4300C", Offset = "0x3E4300C", VA = "0x3E4300C")]
    public BattleRewardDescriptionData()
    {
    }
  }
}
