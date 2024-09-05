// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpeciesData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EA3")]
  [Serializable]
  public sealed class SpeciesData : IMasterDataEntity
  {
    [Token(Token = "0x40046B7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40046B8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D3C")]
    public int Key
    {
      [Token(Token = "0x6005901"), Address(RVA = "0x3C2F57C", Offset = "0x3C2F57C", VA = "0x3C2F57C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005902")]
    [Address(RVA = "0x3C2F584", Offset = "0x3C2F584", VA = "0x3C2F584", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005903")]
    [Address(RVA = "0x3C2F690", Offset = "0x3C2F690", VA = "0x3C2F690", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005904")]
    [Address(RVA = "0x3C2F718", Offset = "0x3C2F718", VA = "0x3C2F718")]
    public SpeciesData()
    {
    }
  }
}
