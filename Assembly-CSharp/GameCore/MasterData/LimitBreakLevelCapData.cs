// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LimitBreakLevelCapData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F5A")]
  [Serializable]
  public sealed class LimitBreakLevelCapData : IMasterDataEntity
  {
    [Token(Token = "0x4004D15")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D16")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004D17")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int limitBreakCount;
    [Token(Token = "0x4004D18")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x4004D19")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int levelCap;

    [Token(Token = "0x17000D67")]
    public int Key
    {
      [Token(Token = "0x6005A5B"), Address(RVA = "0x3C3D774", Offset = "0x3C3D774", VA = "0x3C3D774", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A5C")]
    [Address(RVA = "0x3C3D77C", Offset = "0x3C3D77C", VA = "0x3C3D77C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A5D")]
    [Address(RVA = "0x3C3D9A8", Offset = "0x3C3D9A8", VA = "0x3C3D9A8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A5E")]
    [Address(RVA = "0x3C3DA5C", Offset = "0x3C3DA5C", VA = "0x3C3DA5C")]
    public LimitBreakLevelCapData()
    {
    }
  }
}
