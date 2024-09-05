// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SubEquipmentClassificationDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E8E")]
  [Serializable]
  public sealed class SubEquipmentClassificationDescriptionMaster : 
    BaseMaster<SubEquipmentClassificationDescriptionData>
  {
    [Token(Token = "0x4004683")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<SubEquipmentClassificationDescriptionData>> classificationTable;

    [Token(Token = "0x6005892")]
    [Address(RVA = "0x3C2C238", Offset = "0x3C2C238", VA = "0x3C2C238")]
    public IReadOnlyDictionary<int, SubEquipmentClassificationDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SubEquipmentClassificationDescriptionData>) null;
    }

    [Token(Token = "0x6005893")]
    [Address(RVA = "0x3C2C240", Offset = "0x3C2C240", VA = "0x3C2C240", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005894")]
    [Address(RVA = "0x3C2C2A0", Offset = "0x3C2C2A0", VA = "0x3C2C2A0", Slot = "5")]
    protected override SubEquipmentClassificationDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (SubEquipmentClassificationDescriptionData) null;
    }

    [Token(Token = "0x6005895")]
    [Address(RVA = "0x3C2C310", Offset = "0x3C2C310", VA = "0x3C2C310")]
    private void OnLoadEntity(SubEquipmentClassificationDescriptionData entity)
    {
    }

    [Token(Token = "0x6005896")]
    [Address(RVA = "0x3C2C314", Offset = "0x3C2C314", VA = "0x3C2C314")]
    private void GroupingBySubEquipmentClassificationId(
      SubEquipmentClassificationDescriptionData entity)
    {
    }

    [Token(Token = "0x6005897")]
    [Address(RVA = "0x3C2C46C", Offset = "0x3C2C46C", VA = "0x3C2C46C")]
    public IReadOnlyList<SubEquipmentClassificationDescriptionData> GetSubEquipmentClassificationDescriptions(
      int subEquipmentClassificationId)
    {
      return (IReadOnlyList<SubEquipmentClassificationDescriptionData>) null;
    }

    [Token(Token = "0x6005898")]
    [Address(RVA = "0x3C2C528", Offset = "0x3C2C528", VA = "0x3C2C528")]
    public SubEquipmentClassificationDescriptionMaster()
    {
    }
  }
}
