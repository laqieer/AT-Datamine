// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SubEquipmentClassificationGroupDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001380")]
  [Serializable]
  public sealed class SubEquipmentClassificationGroupDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005B4A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B4B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int subEquipmentClassificationGroup;
    [Token(Token = "0x4005B4C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int subEquipmentClassification;

    [Token(Token = "0x17001087")]
    public int Key
    {
      [Token(Token = "0x6006DB8"), Address(RVA = "0x46FF3C4", Offset = "0x46FF3C4", VA = "0x46FF3C4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006DB9")]
    [Address(RVA = "0x46FF3CC", Offset = "0x46FF3CC", VA = "0x46FF3CC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006DBA")]
    [Address(RVA = "0x46FF538", Offset = "0x46FF538", VA = "0x46FF538", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006DBB")]
    [Address(RVA = "0x46FF5CC", Offset = "0x46FF5CC", VA = "0x46FF5CC")]
    public SubEquipmentClassificationGroupDescriptionData()
    {
    }
  }
}
