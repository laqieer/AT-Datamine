// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SubEquipmentClassificationDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E8F")]
  [Serializable]
  public sealed class SubEquipmentClassificationDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004684")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004685")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int subEquipmentClassification;
    [Token(Token = "0x4004686")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int equipmentClassification;

    [Token(Token = "0x17000D2A")]
    public int Key
    {
      [Token(Token = "0x6005899"), Address(RVA = "0x3C2C5B8", Offset = "0x3C2C5B8", VA = "0x3C2C5B8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600589A")]
    [Address(RVA = "0x3C2C5C0", Offset = "0x3C2C5C0", VA = "0x3C2C5C0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600589B")]
    [Address(RVA = "0x3C2C72C", Offset = "0x3C2C72C", VA = "0x3C2C72C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600589C")]
    [Address(RVA = "0x3C2C7C0", Offset = "0x3C2C7C0", VA = "0x3C2C7C0")]
    public SubEquipmentClassificationDescriptionData()
    {
    }
  }
}
