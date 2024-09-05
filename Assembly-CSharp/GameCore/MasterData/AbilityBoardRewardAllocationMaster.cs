// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardRewardAllocationMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001354")]
  [Serializable]
  public sealed class AbilityBoardRewardAllocationMaster : 
    BaseMaster<AbilityBoardRewardAllocationData>
  {
    [Token(Token = "0x4005ADE")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityBoardRewardAllocationData>> descriptionTable;

    [Token(Token = "0x6006CEA")]
    [Address(RVA = "0x46F7CF8", Offset = "0x46F7CF8", VA = "0x46F7CF8")]
    public IReadOnlyDictionary<int, AbilityBoardRewardAllocationData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardRewardAllocationData>) null;
    }

    [Token(Token = "0x6006CEB")]
    [Address(RVA = "0x46F7D00", Offset = "0x46F7D00", VA = "0x46F7D00", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006CEC")]
    [Address(RVA = "0x46F7FC4", Offset = "0x46F7FC4", VA = "0x46F7FC4", Slot = "5")]
    protected override AbilityBoardRewardAllocationData LoadEntity(IMasterDataReader reader)
    {
      return (AbilityBoardRewardAllocationData) null;
    }

    [Token(Token = "0x6006CED")]
    [Address(RVA = "0x46F8034", Offset = "0x46F8034", VA = "0x46F8034")]
    private void OnLoadEntity(AbilityBoardRewardAllocationData entity)
    {
    }

    [Token(Token = "0x6006CEE")]
    [Address(RVA = "0x46F7D68", Offset = "0x46F7D68", VA = "0x46F7D68")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006CEF")]
    [Address(RVA = "0x46F8038", Offset = "0x46F8038", VA = "0x46F8038")]
    private void GroupingByStyleExpId(AbilityBoardRewardAllocationData entity)
    {
    }

    [Token(Token = "0x6006CF0")]
    [Address(RVA = "0x46F81F4", Offset = "0x46F81F4", VA = "0x46F81F4")]
    public IReadOnlyList<AbilityBoardRewardAllocationData> GetListByRewardGroupId(int rewardGroupId)
    {
      return (IReadOnlyList<AbilityBoardRewardAllocationData>) null;
    }

    [Token(Token = "0x6006CF1")]
    [Address(RVA = "0x46F82B0", Offset = "0x46F82B0", VA = "0x46F82B0")]
    public AbilityBoardRewardAllocationMaster()
    {
    }
  }
}
