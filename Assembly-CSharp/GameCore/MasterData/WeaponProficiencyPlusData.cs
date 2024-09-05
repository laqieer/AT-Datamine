// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponProficiencyPlusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F7A")]
  [Serializable]
  public sealed class WeaponProficiencyPlusData : IMasterDataEntity
  {
    [Token(Token = "0x4004DEC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004DED")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public WeaponTypeEnum weaponType;
    [Token(Token = "0x4004DEE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ProficiencyTypeEnum weaponProficiency;
    [Token(Token = "0x4004DEF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int physicPower;
    [Token(Token = "0x4004DF0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int magicPower;
    [Token(Token = "0x4004DF1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int hit;

    [Token(Token = "0x17000D79")]
    public int Key
    {
      [Token(Token = "0x6005B07"), Address(RVA = "0x277C984", Offset = "0x277C984", VA = "0x277C984", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B08")]
    [Address(RVA = "0x277C98C", Offset = "0x277C98C", VA = "0x277C98C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B09")]
    [Address(RVA = "0x277CC18", Offset = "0x277CC18", VA = "0x277CC18", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B0A")]
    [Address(RVA = "0x277CCDC", Offset = "0x277CCDC", VA = "0x277CCDC")]
    public WeaponProficiencyPlusData()
    {
    }
  }
}
