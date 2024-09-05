// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryOptionLotteryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F4A")]
  [Serializable]
  public sealed class AccessoryOptionLotteryData : IMasterDataEntity
  {
    [Token(Token = "0x4004CF3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004CF4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004CF5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int optionLotteryGroup;
    [Token(Token = "0x4004CF6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public AccessroyOptionEffectTypeEnum effectType;
    [Token(Token = "0x4004CF7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int weight;

    [Token(Token = "0x17000D5F")]
    public int Key
    {
      [Token(Token = "0x6005A13"), Address(RVA = "0x3C3B308", Offset = "0x3C3B308", VA = "0x3C3B308", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A14")]
    [Address(RVA = "0x3C3B310", Offset = "0x3C3B310", VA = "0x3C3B310", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A15")]
    [Address(RVA = "0x3C3B53C", Offset = "0x3C3B53C", VA = "0x3C3B53C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A16")]
    [Address(RVA = "0x3C3B5F4", Offset = "0x3C3B5F4", VA = "0x3C3B5F4")]
    public AccessoryOptionLotteryData()
    {
    }
  }
}
