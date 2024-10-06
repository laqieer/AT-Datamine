// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleFacilityPlacementData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E5F")]
  [Serializable]
  public sealed class BattleFacilityPlacementData : IMasterDataEntity
  {
    [Token(Token = "0x400458C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400458D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000CF0")]
    public int Key
    {
      [Token(Token = "0x60057A2"), Address(RVA = "0x3E42008", Offset = "0x3E42008", VA = "0x3E42008", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60057A3")]
    [Address(RVA = "0x3E42010", Offset = "0x3E42010", VA = "0x3E42010", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60057A4")]
    [Address(RVA = "0x3E4211C", Offset = "0x3E4211C", VA = "0x3E4211C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60057A5")]
    [Address(RVA = "0x3E421A4", Offset = "0x3E421A4", VA = "0x3E421A4")]
    public BattleFacilityPlacementData()
    {
    }
  }
}
