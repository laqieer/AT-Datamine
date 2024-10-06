// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponLimitBreakData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F78")]
  [Serializable]
  public sealed class WeaponLimitBreakData : IMasterDataEntity
  {
    [Token(Token = "0x4004DEA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004DEB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D78")]
    public int Key
    {
      [Token(Token = "0x6005AFF"), Address(RVA = "0x277C6D8", Offset = "0x277C6D8", VA = "0x277C6D8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B00")]
    [Address(RVA = "0x277C6E0", Offset = "0x277C6E0", VA = "0x277C6E0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B01")]
    [Address(RVA = "0x277C7EC", Offset = "0x277C7EC", VA = "0x277C7EC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B02")]
    [Address(RVA = "0x277C874", Offset = "0x277C874", VA = "0x277C874")]
    public WeaponLimitBreakData()
    {
    }
  }
}
