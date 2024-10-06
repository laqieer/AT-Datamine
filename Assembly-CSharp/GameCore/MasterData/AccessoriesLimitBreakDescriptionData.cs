// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoriesLimitBreakDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F4D")]
  [Serializable]
  public sealed class AccessoriesLimitBreakDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004CFB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004CFC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int accessoriesLimitBreak;
    [Token(Token = "0x4004CFD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int limitBreakCount;
    [Token(Token = "0x4004CFE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004CFF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int pieceNum;

    [Token(Token = "0x17000D60")]
    public int Key
    {
      [Token(Token = "0x6005A1E"), Address(RVA = "0x3C3B888", Offset = "0x3C3B888", VA = "0x3C3B888", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A1F")]
    [Address(RVA = "0x3C3B890", Offset = "0x3C3B890", VA = "0x3C3B890", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A20")]
    [Address(RVA = "0x3C3BABC", Offset = "0x3C3BABC", VA = "0x3C3BABC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A21")]
    [Address(RVA = "0x3C3BB70", Offset = "0x3C3BB70", VA = "0x3C3BB70")]
    public AccessoriesLimitBreakDescriptionData()
    {
    }
  }
}
