// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalTradeUsableMedalListData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001184")]
  [Serializable]
  public sealed class MedalTradeUsableMedalListData : IMasterDataEntity
  {
    [Token(Token = "0x40054A7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054A8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int shopID;
    [Token(Token = "0x40054A9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int medalID;

    [Token(Token = "0x17000F3C")]
    public int Key
    {
      [Token(Token = "0x60064AD"), Address(RVA = "0x4AF1B18", Offset = "0x4AF1B18", VA = "0x4AF1B18", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60064AE")]
    [Address(RVA = "0x4AF1B20", Offset = "0x4AF1B20", VA = "0x4AF1B20", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60064AF")]
    [Address(RVA = "0x4AF1C8C", Offset = "0x4AF1C8C", VA = "0x4AF1C8C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60064B0")]
    [Address(RVA = "0x4AF1D20", Offset = "0x4AF1D20", VA = "0x4AF1D20")]
    public MedalTradeUsableMedalListData()
    {
    }
  }
}
