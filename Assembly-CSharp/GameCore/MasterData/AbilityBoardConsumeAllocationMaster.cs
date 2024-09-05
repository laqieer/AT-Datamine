// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardConsumeAllocationMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001330")]
  [Serializable]
  public sealed class AbilityBoardConsumeAllocationMaster : 
    BaseMaster<AbilityBoardConsumeAllocationData>
  {
    [Token(Token = "0x4005A8C")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityBoardConsumeAllocationData>> descriptionTable;

    [Token(Token = "0x6006C45")]
    [Address(RVA = "0x46F1F3C", Offset = "0x46F1F3C", VA = "0x46F1F3C")]
    public IReadOnlyDictionary<int, AbilityBoardConsumeAllocationData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardConsumeAllocationData>) null;
    }

    [Token(Token = "0x6006C46")]
    [Address(RVA = "0x46F1F44", Offset = "0x46F1F44", VA = "0x46F1F44", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006C47")]
    [Address(RVA = "0x46F2208", Offset = "0x46F2208", VA = "0x46F2208", Slot = "5")]
    protected override AbilityBoardConsumeAllocationData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardConsumeAllocationData) null;
    }

    [Token(Token = "0x6006C48")]
    [Address(RVA = "0x46F2278", Offset = "0x46F2278", VA = "0x46F2278")]
    private void OnLoadEntity(AbilityBoardConsumeAllocationData entity)
    {
    }

    [Token(Token = "0x6006C49")]
    [Address(RVA = "0x46F1FAC", Offset = "0x46F1FAC", VA = "0x46F1FAC")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006C4A")]
    [Address(RVA = "0x46F227C", Offset = "0x46F227C", VA = "0x46F227C")]
    private void GroupingByStyleExpId(AbilityBoardConsumeAllocationData entity)
    {
    }

    [Token(Token = "0x6006C4B")]
    [Address(RVA = "0x46F2438", Offset = "0x46F2438", VA = "0x46F2438")]
    public IReadOnlyList<AbilityBoardConsumeAllocationData> GetListByConsumeGroupId(int consumeId)
    {
      return (IReadOnlyList<AbilityBoardConsumeAllocationData>) null;
    }

    [Token(Token = "0x6006C4C")]
    [Address(RVA = "0x46F24F4", Offset = "0x46F24F4", VA = "0x46F24F4")]
    public AbilityBoardConsumeAllocationMaster()
    {
    }
  }
}
