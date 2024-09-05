// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaWeeklyRewardTermData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DF5")]
  [Serializable]
  public sealed class ArenaWeeklyRewardTermData : IMasterDataEntity
  {
    [Token(Token = "0x40042A3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40042A4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40042A5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int arenaWeeklyRewardGroup;
    [Token(Token = "0x40042A6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int rewardFixedHour;
    [Token(Token = "0x40042A7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int rewardFixedMinute;
    [Token(Token = "0x40042A8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x40042A9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public DateTime endAt;

    [Token(Token = "0x17000C3A")]
    public int Key
    {
      [Token(Token = "0x600551A"), Address(RVA = "0x3AAAD2C", Offset = "0x3AAAD2C", VA = "0x3AAAD2C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600551B")]
    [Address(RVA = "0x3AAAD34", Offset = "0x3AAAD34", VA = "0x3AAAD34", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600551C")]
    [Address(RVA = "0x3AAB020", Offset = "0x3AAB020", VA = "0x3AAB020", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600551D")]
    [Address(RVA = "0x3AAB150", Offset = "0x3AAB150", VA = "0x3AAB150")]
    public ArenaWeeklyRewardTermData()
    {
    }
  }
}
