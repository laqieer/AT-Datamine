// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponProficiencyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200138C")]
  [Serializable]
  public sealed class WeaponProficiencyData : IMasterDataEntity
  {
    [Token(Token = "0x4005B5F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B60")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x1700108B")]
    public int Key
    {
      [Token(Token = "0x6006DEB"), Address(RVA = "0x4700C6C", Offset = "0x4700C6C", VA = "0x4700C6C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006DEC")]
    [Address(RVA = "0x4700C74", Offset = "0x4700C74", VA = "0x4700C74", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006DED")]
    [Address(RVA = "0x4700D80", Offset = "0x4700D80", VA = "0x4700D80", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006DEE")]
    [Address(RVA = "0x4700E08", Offset = "0x4700E08", VA = "0x4700E08")]
    public WeaponProficiencyData()
    {
    }
  }
}
