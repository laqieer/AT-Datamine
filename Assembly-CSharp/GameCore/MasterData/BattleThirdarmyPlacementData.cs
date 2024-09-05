// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleThirdarmyPlacementData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E71")]
  [Serializable]
  public sealed class BattleThirdarmyPlacementData : IMasterDataEntity
  {
    [Token(Token = "0x40045DE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D17")]
    public int Key
    {
      [Token(Token = "0x6005819"), Address(RVA = "0x3E46050", Offset = "0x3E46050", VA = "0x3E46050", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600581A")]
    [Address(RVA = "0x3E46058", Offset = "0x3E46058", VA = "0x3E46058", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600581B")]
    [Address(RVA = "0x3E46164", Offset = "0x3E46164", VA = "0x3E46164", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600581C")]
    [Address(RVA = "0x3E461EC", Offset = "0x3E461EC", VA = "0x3E461EC")]
    public BattleThirdarmyPlacementData()
    {
    }
  }
}
