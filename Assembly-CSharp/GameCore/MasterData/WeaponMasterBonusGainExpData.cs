// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponMasterBonusGainExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010DE")]
  [Serializable]
  public sealed class WeaponMasterBonusGainExpData : IMasterDataEntity
  {
    [Token(Token = "0x40052A0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052A1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x40052A2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int masterExp;

    [Token(Token = "0x17000E7F")]
    public int Key
    {
      [Token(Token = "0x6006163"), Address(RVA = "0x28E04C4", Offset = "0x28E04C4", VA = "0x28E04C4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006164")]
    [Address(RVA = "0x28E04CC", Offset = "0x28E04CC", VA = "0x28E04CC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006165")]
    [Address(RVA = "0x28E0638", Offset = "0x28E0638", VA = "0x28E0638", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006166")]
    [Address(RVA = "0x28E06CC", Offset = "0x28E06CC", VA = "0x28E06CC")]
    public WeaponMasterBonusGainExpData()
    {
    }
  }
}
