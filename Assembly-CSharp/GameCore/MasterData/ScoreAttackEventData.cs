// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001137")]
  [Serializable]
  public sealed class ScoreAttackEventData : IMasterDataEntity
  {
    [Token(Token = "0x40053C0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053C1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int scoreAttackDetailId;
    [Token(Token = "0x40053C2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x40053C3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x40053C4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int consumeCostFreeDailyCount;
    [Token(Token = "0x40053C5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int scenarioQuestID;
    [Token(Token = "0x40053C6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int scoreAttackRewardGroup;
    [Token(Token = "0x40053C7")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int styleID;

    [Token(Token = "0x17000ED9")]
    public int Key
    {
      [Token(Token = "0x600630B"), Address(RVA = "0x4AE4D38", Offset = "0x4AE4D38", VA = "0x4AE4D38", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600630C")]
    [Address(RVA = "0x4AE4D40", Offset = "0x4AE4D40", VA = "0x4AE4D40", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600630D")]
    [Address(RVA = "0x4AE508C", Offset = "0x4AE508C", VA = "0x4AE508C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600630E")]
    [Address(RVA = "0x4AE51C4", Offset = "0x4AE51C4", VA = "0x4AE51C4")]
    public ScoreAttackEventData()
    {
    }
  }
}
