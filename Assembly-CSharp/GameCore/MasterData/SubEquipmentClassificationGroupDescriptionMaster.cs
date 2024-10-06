// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SubEquipmentClassificationGroupDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200137E")]
  [Serializable]
  public sealed class SubEquipmentClassificationGroupDescriptionMaster : 
    BaseMaster<SubEquipmentClassificationGroupDescriptionData>
  {
    [Token(Token = "0x4005B47")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<SubEquipmentClassificationGroupDescriptionData>> descriptionTable;

    [Token(Token = "0x6006DAD")]
    [Address(RVA = "0x46FED4C", Offset = "0x46FED4C", VA = "0x46FED4C")]
    public IReadOnlyDictionary<int, SubEquipmentClassificationGroupDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SubEquipmentClassificationGroupDescriptionData>) null;
    }

    [Token(Token = "0x6006DAE")]
    [Address(RVA = "0x46FED54", Offset = "0x46FED54", VA = "0x46FED54", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006DAF")]
    [Address(RVA = "0x46FF018", Offset = "0x46FF018", VA = "0x46FF018", Slot = "5")]
    protected override SubEquipmentClassificationGroupDescriptionData LoadEntity(
      IMasterDataReader reader)
    {
      return (SubEquipmentClassificationGroupDescriptionData) null;
    }

    [Token(Token = "0x6006DB0")]
    [Address(RVA = "0x46FF088", Offset = "0x46FF088", VA = "0x46FF088")]
    private void OnLoadEntity(
      SubEquipmentClassificationGroupDescriptionData entity)
    {
    }

    [Token(Token = "0x6006DB1")]
    [Address(RVA = "0x46FEDBC", Offset = "0x46FEDBC", VA = "0x46FEDBC")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006DB2")]
    [Address(RVA = "0x46FF08C", Offset = "0x46FF08C", VA = "0x46FF08C")]
    private void GroupingByStyleId(
      SubEquipmentClassificationGroupDescriptionData entity)
    {
    }

    [Token(Token = "0x6006DB3")]
    [Address(RVA = "0x46FF1E4", Offset = "0x46FF1E4", VA = "0x46FF1E4")]
    public IReadOnlyList<SubEquipmentClassificationGroupDescriptionData> GetListByGroupId(
      int groupId)
    {
      return (IReadOnlyList<SubEquipmentClassificationGroupDescriptionData>) null;
    }

    [Token(Token = "0x6006DB4")]
    [Address(RVA = "0x46FF2A0", Offset = "0x46FF2A0", VA = "0x46FF2A0")]
    public SubEquipmentClassificationGroupDescriptionMaster()
    {
    }
  }
}
