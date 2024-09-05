// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleForcedSortieData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E4C")]
  [Serializable]
  public sealed class BattleForcedSortieData : IMasterDataEntity
  {
    [Token(Token = "0x40044EC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40044ED")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int forcesSortieGroupId;
    [Token(Token = "0x40044EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public BatteForcedSortieRestrictionTypeEnum restrictionType;
    [Token(Token = "0x40044EF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int additionalSetting;

    [Token(Token = "0x17000CA0")]
    public int Key
    {
      [Token(Token = "0x60056F6"), Address(RVA = "0x3E3AEAC", Offset = "0x3E3AEAC", VA = "0x3E3AEAC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60056F7")]
    [Address(RVA = "0x3E3AEB4", Offset = "0x3E3AEB4", VA = "0x3E3AEB4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60056F8")]
    [Address(RVA = "0x3E3B080", Offset = "0x3E3B080", VA = "0x3E3B080", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60056F9")]
    [Address(RVA = "0x3E3B124", Offset = "0x3E3B124", VA = "0x3E3B124")]
    public BattleForcedSortieData()
    {
    }
  }
}
