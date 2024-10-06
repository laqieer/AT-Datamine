// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponRarityAptitudeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F7E")]
  [Serializable]
  public sealed class WeaponRarityAptitudeData : IMasterDataEntity
  {
    [Token(Token = "0x4004DF9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004DFA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum weaponRarity;
    [Token(Token = "0x4004DFB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ProficiencyTypeEnum weaponProficiency;
    [Token(Token = "0x4004DFC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int difference;

    [Token(Token = "0x17000D7B")]
    public int Key
    {
      [Token(Token = "0x6005B17"), Address(RVA = "0x277D2C4", Offset = "0x277D2C4", VA = "0x277D2C4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B18")]
    [Address(RVA = "0x277D2CC", Offset = "0x277D2CC", VA = "0x277D2CC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B19")]
    [Address(RVA = "0x277D498", Offset = "0x277D498", VA = "0x277D498", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B1A")]
    [Address(RVA = "0x277D53C", Offset = "0x277D53C", VA = "0x277D53C")]
    public WeaponRarityAptitudeData()
    {
    }
  }
}
