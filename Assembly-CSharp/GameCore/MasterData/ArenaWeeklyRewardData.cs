// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaWeeklyRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DF3")]
  [Serializable]
  public sealed class ArenaWeeklyRewardData : IMasterDataEntity
  {
    [Token(Token = "0x400429E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400429F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int ArenaWeeklyRewardSet;
    [Token(Token = "0x40042A0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40042A1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x40042A2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000C39")]
    public int Key
    {
      [Token(Token = "0x6005512"), Address(RVA = "0x3AAA934", Offset = "0x3AAA934", VA = "0x3AAA934", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005513")]
    [Address(RVA = "0x3AAA93C", Offset = "0x3AAA93C", VA = "0x3AAA93C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005514")]
    [Address(RVA = "0x3AAAB68", Offset = "0x3AAAB68", VA = "0x3AAAB68", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005515")]
    [Address(RVA = "0x3AAAC1C", Offset = "0x3AAAC1C", VA = "0x3AAAC1C")]
    public ArenaWeeklyRewardData()
    {
    }
  }
}
