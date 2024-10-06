// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponMasterBonusDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010D4")]
  [Serializable]
  public sealed class WeaponMasterBonusDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005284")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005285")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int masterBonus;
    [Token(Token = "0x4005286")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4005287")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int physicalDamage;
    [Token(Token = "0x4005288")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int magicDamage;
    [Token(Token = "0x4005289")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int takenPhysicalDamage;
    [Token(Token = "0x400528A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int takenMagicDamage;
    [Token(Token = "0x400528B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int takenHit;
    [Token(Token = "0x400528C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int hit;
    [Token(Token = "0x400528D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int critical;
    [Token(Token = "0x400528E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int takenCritical;
    [Token(Token = "0x400528F")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int hp;

    [Token(Token = "0x17000E7D")]
    public int Key
    {
      [Token(Token = "0x600613C"), Address(RVA = "0x28DEFAC", Offset = "0x28DEFAC", VA = "0x28DEFAC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600613D")]
    [Address(RVA = "0x28DEFB4", Offset = "0x28DEFB4", VA = "0x28DEFB4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600613E")]
    [Address(RVA = "0x28DF480", Offset = "0x28DF480", VA = "0x28DF480", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600613F")]
    [Address(RVA = "0x28DF5A4", Offset = "0x28DF5A4", VA = "0x28DF5A4")]
    public WeaponMasterBonusDescriptionData()
    {
    }
  }
}
