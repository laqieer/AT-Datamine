// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponMasterBonusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010E1")]
  [Serializable]
  public sealed class WeaponMasterBonusData : IMasterDataEntity
  {
    [Token(Token = "0x40052A4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052A5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40052A6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int classification;

    [Token(Token = "0x17000E80")]
    public int Key
    {
      [Token(Token = "0x600616F"), Address(RVA = "0x28E093C", Offset = "0x28E093C", VA = "0x28E093C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006170")]
    [Address(RVA = "0x28E0944", Offset = "0x28E0944", VA = "0x28E0944", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006171")]
    [Address(RVA = "0x28E0AB0", Offset = "0x28E0AB0", VA = "0x28E0AB0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006172")]
    [Address(RVA = "0x28E0B48", Offset = "0x28E0B48", VA = "0x28E0B48")]
    public WeaponMasterBonusData()
    {
    }
  }
}
