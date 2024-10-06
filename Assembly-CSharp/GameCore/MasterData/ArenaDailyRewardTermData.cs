// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaDailyRewardTermData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DED")]
  [Serializable]
  public sealed class ArenaDailyRewardTermData : IMasterDataEntity
  {
    [Token(Token = "0x4004290")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004291")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004292")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int arenaDailyRewardGroup;
    [Token(Token = "0x4004293")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int rewardFixedHour;
    [Token(Token = "0x4004294")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int rewardFixedMinute;
    [Token(Token = "0x4004295")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x4004296")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public DateTime endAt;

    [Token(Token = "0x17000C36")]
    public int Key
    {
      [Token(Token = "0x60054FA"), Address(RVA = "0x3AA9D58", Offset = "0x3AA9D58", VA = "0x3AA9D58", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60054FB")]
    [Address(RVA = "0x3AA9D60", Offset = "0x3AA9D60", VA = "0x3AA9D60", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60054FC")]
    [Address(RVA = "0x3AAA04C", Offset = "0x3AAA04C", VA = "0x3AAA04C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60054FD")]
    [Address(RVA = "0x3AAA17C", Offset = "0x3AAA17C", VA = "0x3AAA17C")]
    public ArenaDailyRewardTermData()
    {
    }
  }
}
