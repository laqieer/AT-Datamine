// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ReincarnationBonusTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F0D")]
  [Serializable]
  public sealed class ReincarnationBonusTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004AE2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004AE3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D4A")]
    public int Key
    {
      [Token(Token = "0x6005976"), Address(RVA = "0x3C323E0", Offset = "0x3C323E0", VA = "0x3C323E0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005977")]
    [Address(RVA = "0x3C323E8", Offset = "0x3C323E8", VA = "0x3C323E8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005978")]
    [Address(RVA = "0x3C324F4", Offset = "0x3C324F4", VA = "0x3C324F4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005979")]
    [Address(RVA = "0x3C3257C", Offset = "0x3C3257C", VA = "0x3C3257C")]
    public ReincarnationBonusTypeData()
    {
    }
  }
}
