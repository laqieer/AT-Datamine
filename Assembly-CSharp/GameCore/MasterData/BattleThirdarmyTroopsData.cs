// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleThirdarmyTroopsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E73")]
  [Serializable]
  public sealed class BattleThirdarmyTroopsData : IMasterDataEntity, ITroopsData
  {
    [Token(Token = "0x40045E1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045E2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x40045E3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int number;
    [Token(Token = "0x40045E4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public bool initial;
    [Token(Token = "0x40045E5")]
    [FieldOffset(Offset = "0x1D")]
    [SerializeField]
    public bool quick;

    [Token(Token = "0x17000D18")]
    public int Key
    {
      [Token(Token = "0x6005823"), Address(RVA = "0x3E4656C", Offset = "0x3E4656C", VA = "0x3E4656C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005824")]
    [Address(RVA = "0x3E46574", Offset = "0x3E46574", VA = "0x3E46574", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005825")]
    [Address(RVA = "0x3E467A8", Offset = "0x3E467A8", VA = "0x3E467A8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000D19")]
    public int Troops
    {
      [Token(Token = "0x6005826"), Address(RVA = "0x3E4685C", Offset = "0x3E4685C", VA = "0x3E4685C", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D1A")]
    public bool IsInitial
    {
      [Token(Token = "0x6005827"), Address(RVA = "0x3E46864", Offset = "0x3E46864", VA = "0x3E46864", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000D1B")]
    public bool IsQuick
    {
      [Token(Token = "0x6005828"), Address(RVA = "0x3E4686C", Offset = "0x3E4686C", VA = "0x3E4686C", Slot = "9")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005829")]
    [Address(RVA = "0x3E46874", Offset = "0x3E46874", VA = "0x3E46874")]
    public BattleThirdarmyTroopsData()
    {
    }
  }
}
