// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDropDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E33")]
  [Serializable]
  public sealed class BattleDropDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x40043D4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40043D5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int setDescription;
    [Token(Token = "0x40043D6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40043D7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x40043D8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;
    [Token(Token = "0x40043D9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int weight;
    [Token(Token = "0x40043DA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public BattleDropRewardTypeEnum dropRewardType;

    [Token(Token = "0x17000C73")]
    public int Key
    {
      [Token(Token = "0x600567B"), Address(RVA = "0x3E36FA0", Offset = "0x3E36FA0", VA = "0x3E36FA0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600567C")]
    [Address(RVA = "0x3E36FA8", Offset = "0x3E36FA8", VA = "0x3E36FA8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600567D")]
    [Address(RVA = "0x3E37294", Offset = "0x3E37294", VA = "0x3E37294", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600567E")]
    [Address(RVA = "0x3E37368", Offset = "0x3E37368", VA = "0x3E37368")]
    public BattleDropDescriptionData()
    {
    }
  }
}
