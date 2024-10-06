// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponOptionLotteryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F8D")]
  [Serializable]
  public sealed class WeaponOptionLotteryData : IMasterDataEntity
  {
    [Token(Token = "0x4004E89")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004E8A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004E8B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int optionLotteryGroup;
    [Token(Token = "0x4004E8C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public OptionEffectTypeEnum effectType;
    [Token(Token = "0x4004E8D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int weight;

    [Token(Token = "0x17000D85")]
    public int Key
    {
      [Token(Token = "0x6005B65"), Address(RVA = "0x2781C58", Offset = "0x2781C58", VA = "0x2781C58", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B66")]
    [Address(RVA = "0x2781C60", Offset = "0x2781C60", VA = "0x2781C60", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B67")]
    [Address(RVA = "0x2781E8C", Offset = "0x2781E8C", VA = "0x2781E8C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B68")]
    [Address(RVA = "0x2781F44", Offset = "0x2781F44", VA = "0x2781F44")]
    public WeaponOptionLotteryData()
    {
    }
  }
}
