// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.DeckTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EA8")]
  [Serializable]
  public sealed class DeckTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40046C1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40046C2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40046C3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DeckTypeEnum deckType;
    [Token(Token = "0x40046C4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int memberLimit;
    [Token(Token = "0x40046C5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int customDeckLimit;
    [Token(Token = "0x40046C6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string defaultNameFormat;
    [Token(Token = "0x40046C7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int partyUnitCount;

    [Token(Token = "0x17000D3E")]
    public int Key
    {
      [Token(Token = "0x6005914"), Address(RVA = "0x3C2FE88", Offset = "0x3C2FE88", VA = "0x3C2FE88", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005915")]
    [Address(RVA = "0x3C2FE90", Offset = "0x3C2FE90", VA = "0x3C2FE90", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005916")]
    [Address(RVA = "0x3C3017C", Offset = "0x3C3017C", VA = "0x3C3017C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005917")]
    [Address(RVA = "0x3C30258", Offset = "0x3C30258", VA = "0x3C30258")]
    public string GetDefaultDeckName(int deckNumber) => (string) null;

    [Token(Token = "0x6005918")]
    [Address(RVA = "0x3C302D8", Offset = "0x3C302D8", VA = "0x3C302D8")]
    public DeckTypeData()
    {
    }
  }
}
