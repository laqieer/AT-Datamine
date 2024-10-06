// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryWeeklyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001301")]
  [Serializable]
  public sealed class StoryWeeklyData : IMasterDataEntity
  {
    [Token(Token = "0x40059EC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40059ED")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40059EE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int sundayNoon;
    [Token(Token = "0x40059EF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int sundayNight;
    [Token(Token = "0x40059F0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int mondayNoon;
    [Token(Token = "0x40059F1")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int mondayNight;
    [Token(Token = "0x40059F2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int tuesdayNoon;
    [Token(Token = "0x40059F3")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int tuesdayNight;
    [Token(Token = "0x40059F4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int wednesdayNoon;
    [Token(Token = "0x40059F5")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int wednesdayNight;
    [Token(Token = "0x40059F6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int thursdayNoon;
    [Token(Token = "0x40059F7")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int thursdayNight;
    [Token(Token = "0x40059F8")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int fridayNoon;
    [Token(Token = "0x40059F9")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int fridayNight;
    [Token(Token = "0x40059FA")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int saturdayNoon;
    [Token(Token = "0x40059FB")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int saturdayNight;

    [Token(Token = "0x17001039")]
    public int Key
    {
      [Token(Token = "0x6006B64"), Address(RVA = "0x48E1BF8", Offset = "0x48E1BF8", VA = "0x48E1BF8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B65")]
    [Address(RVA = "0x48E1C00", Offset = "0x48E1C00", VA = "0x48E1C00", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B66")]
    [Address(RVA = "0x48E224C", Offset = "0x48E224C", VA = "0x48E224C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006B67")]
    [Address(RVA = "0x48E23B4", Offset = "0x48E23B4", VA = "0x48E23B4")]
    public StoryWeeklyData()
    {
    }
  }
}
