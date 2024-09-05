// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponTypeEnumData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F37")]
  [Serializable]
  public sealed class WeaponTypeEnumData : IMasterDataEntity
  {
    [Token(Token = "0x4004C3B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004C3C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004C3D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string displayName;

    [Token(Token = "0x17000D54")]
    public int Key
    {
      [Token(Token = "0x60059B1"), Address(RVA = "0x3C33AF8", Offset = "0x3C33AF8", VA = "0x3C33AF8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60059B2")]
    [Address(RVA = "0x3C33B00", Offset = "0x3C33B00", VA = "0x3C33B00", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60059B3")]
    [Address(RVA = "0x3C33C6C", Offset = "0x3C33C6C", VA = "0x3C33C6C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60059B4")]
    [Address(RVA = "0x3C33D08", Offset = "0x3C33D08", VA = "0x3C33D08")]
    public WeaponTypeEnumData()
    {
    }
  }
}
