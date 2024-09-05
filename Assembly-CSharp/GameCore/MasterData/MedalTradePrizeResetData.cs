// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalTradePrizeResetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200117A")]
  [Serializable]
  public sealed class MedalTradePrizeResetData : IMasterDataEntity
  {
    [Token(Token = "0x400548A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400548B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400548C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int hour;
    [Token(Token = "0x400548D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int minute;
    [Token(Token = "0x400548E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int second;
    [Token(Token = "0x400548F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool isDailyLimit;
    [Token(Token = "0x4005490")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public dayOfWeekTypeEnum dayOfWeek;
    [Token(Token = "0x4005491")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int dateOfMonth;

    [Token(Token = "0x17000F37")]
    public int Key
    {
      [Token(Token = "0x600647F"), Address(RVA = "0x4AEFEEC", Offset = "0x4AEFEEC", VA = "0x4AEFEEC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006480")]
    [Address(RVA = "0x4AEFEF4", Offset = "0x4AEFEF4", VA = "0x4AEFEF4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006481")]
    [Address(RVA = "0x4AF0244", Offset = "0x4AF0244", VA = "0x4AF0244", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006482")]
    [Address(RVA = "0x4AF032C", Offset = "0x4AF032C", VA = "0x4AF032C")]
    public DayOfWeek GetSystemDayOfWeek() => new DayOfWeek();

    [Token(Token = "0x6006483")]
    [Address(RVA = "0x4AF0354", Offset = "0x4AF0354", VA = "0x4AF0354")]
    public RenewalType GetRenewalType() => new RenewalType();

    [Token(Token = "0x6006484")]
    [Address(RVA = "0x4AF039C", Offset = "0x4AF039C", VA = "0x4AF039C")]
    public MedalTradePrizeResetData()
    {
    }
  }
}
