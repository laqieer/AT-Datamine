// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleSortieRestrictionsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E66")]
  [Serializable]
  public sealed class BattleSortieRestrictionsData : IMasterDataEntity
  {
    [Token(Token = "0x40045A5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40045A6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int sortieRestrictionsGroupId;
    [Token(Token = "0x40045A7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public BattleSortieRestrictionsCategoryTypeEnum categoryType;
    [Token(Token = "0x40045A8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public BattleSortieRestrictionsMainComparisonTypeEnum mainComparisonType;
    [Token(Token = "0x40045A9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int mainComparisonValue;
    [Token(Token = "0x40045AA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public BattleSortieRestrictionsSubComparisonTypeEnum subComparisonType;
    [Token(Token = "0x40045AB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int subComparisonValue;

    [Token(Token = "0x17000CF3")]
    public int Key
    {
      [Token(Token = "0x60057C4"), Address(RVA = "0x3E436F0", Offset = "0x3E436F0", VA = "0x3E436F0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60057C5")]
    [Address(RVA = "0x3E436F8", Offset = "0x3E436F8", VA = "0x3E436F8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60057C6")]
    [Address(RVA = "0x3E439E4", Offset = "0x3E439E4", VA = "0x3E439E4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60057C7")]
    [Address(RVA = "0x3E43AB8", Offset = "0x3E43AB8", VA = "0x3E43AB8")]
    public BattleSortieRestrictionsData()
    {
    }
  }
}
