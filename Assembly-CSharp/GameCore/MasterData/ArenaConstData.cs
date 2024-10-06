// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DE3")]
  [Serializable]
  public sealed class ArenaConstData : IMasterDataEntity
  {
    [Token(Token = "0x4004278")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004279")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int matchingAutoLotteryInterval;
    [Token(Token = "0x400427A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int reloadConfrontationInterval;
    [Token(Token = "0x400427B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int arenaBattleCoinRequiredAmount;
    [Token(Token = "0x400427C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int maxTimeRewardStorage;
    [Token(Token = "0x400427D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int timeRewardTypeId;
    [Token(Token = "0x400427E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int timeRewardItemId;
    [Token(Token = "0x400427F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int arenaMedalRewardId;

    [Token(Token = "0x17000C31")]
    public int Key
    {
      [Token(Token = "0x60054D2"), Address(RVA = "0x3AA8994", Offset = "0x3AA8994", VA = "0x3AA8994", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60054D3")]
    [Address(RVA = "0x3AA899C", Offset = "0x3AA899C", VA = "0x3AA899C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60054D4")]
    [Address(RVA = "0x3AA8CE8", Offset = "0x3AA8CE8", VA = "0x3AA8CE8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60054D5")]
    [Address(RVA = "0x3AA8DCC", Offset = "0x3AA8DCC", VA = "0x3AA8DCC")]
    public ArenaConstData()
    {
    }
  }
}
