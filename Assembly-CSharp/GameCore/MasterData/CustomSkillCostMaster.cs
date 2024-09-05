// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CustomSkillCostMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011A7")]
  [Serializable]
  public sealed class CustomSkillCostMaster : BaseMaster<CustomSkillCostData>
  {
    [Token(Token = "0x40054F8")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<CustomSkillCostData>> CustomSkillCostDataTable;

    [Token(Token = "0x6006529")]
    [Address(RVA = "0x4AF6360", Offset = "0x4AF6360", VA = "0x4AF6360")]
    public IReadOnlyDictionary<int, CustomSkillCostData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CustomSkillCostData>) null;
    }

    [Token(Token = "0x600652A")]
    [Address(RVA = "0x4AF6368", Offset = "0x4AF6368", VA = "0x4AF6368", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600652B")]
    [Address(RVA = "0x4AF63C8", Offset = "0x4AF63C8", VA = "0x4AF63C8", Slot = "5")]
    protected override CustomSkillCostData LoadEntity(IMasterDataReader reader)
    {
      return (CustomSkillCostData) null;
    }

    [Token(Token = "0x600652C")]
    [Address(RVA = "0x4AF6438", Offset = "0x4AF6438", VA = "0x4AF6438")]
    private void OnLoadEntity(CustomSkillCostData entity)
    {
    }

    [Token(Token = "0x600652D")]
    [Address(RVA = "0x4AF643C", Offset = "0x4AF643C", VA = "0x4AF643C")]
    private void GroupingByLimitBreakId(CustomSkillCostData entity)
    {
    }

    [Token(Token = "0x600652E")]
    [Address(RVA = "0x4AF6594", Offset = "0x4AF6594", VA = "0x4AF6594")]
    public CustomSkillCostMaster()
    {
    }
  }
}
