// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MindEquipmentLimitBreakDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F60")]
  [Serializable]
  public sealed class MindEquipmentLimitBreakDescriptionMaster : 
    BaseMaster<MindEquipmentLimitBreakDescriptionData>
  {
    [Token(Token = "0x4004D24")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<MindEquipmentLimitBreakDescriptionData>> limitBreakDescriptionTable;

    [Token(Token = "0x6005A75")]
    [Address(RVA = "0x3C3E5B8", Offset = "0x3C3E5B8", VA = "0x3C3E5B8")]
    public IReadOnlyDictionary<int, MindEquipmentLimitBreakDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MindEquipmentLimitBreakDescriptionData>) null;
    }

    [Token(Token = "0x6005A76")]
    [Address(RVA = "0x3C3E5C0", Offset = "0x3C3E5C0", VA = "0x3C3E5C0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005A77")]
    [Address(RVA = "0x3C3E620", Offset = "0x3C3E620", VA = "0x3C3E620", Slot = "5")]
    protected override MindEquipmentLimitBreakDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (MindEquipmentLimitBreakDescriptionData) null;
    }

    [Token(Token = "0x6005A78")]
    [Address(RVA = "0x3C3E690", Offset = "0x3C3E690", VA = "0x3C3E690")]
    private void OnLoadEntity(MindEquipmentLimitBreakDescriptionData entity)
    {
    }

    [Token(Token = "0x6005A79")]
    [Address(RVA = "0x3C3E694", Offset = "0x3C3E694", VA = "0x3C3E694")]
    private void GroupingByLimitBreakId(MindEquipmentLimitBreakDescriptionData entity)
    {
    }

    [Token(Token = "0x6005A7A")]
    [Address(RVA = "0x3C3E7EC", Offset = "0x3C3E7EC", VA = "0x3C3E7EC")]
    public IReadOnlyCollection<MindEquipmentLimitBreakDescriptionData> GetListByLimitBreakId(
      int limitBreakId)
    {
      return (IReadOnlyCollection<MindEquipmentLimitBreakDescriptionData>) null;
    }

    [Token(Token = "0x6005A7B")]
    [Address(RVA = "0x3C3E8A8", Offset = "0x3C3E8A8", VA = "0x3C3E8A8")]
    public MindEquipmentLimitBreakDescriptionMaster()
    {
    }
  }
}
