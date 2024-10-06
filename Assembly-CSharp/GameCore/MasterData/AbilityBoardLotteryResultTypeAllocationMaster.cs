// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardLotteryResultTypeAllocationMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200134B")]
  [Serializable]
  public sealed class AbilityBoardLotteryResultTypeAllocationMaster : 
    BaseMaster<AbilityBoardLotteryResultTypeAllocationData>
  {
    [Token(Token = "0x4005ACF")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<AbilityBoardLotteryResultTypeAllocationData>> descriptionTable;

    [Token(Token = "0x6006CC3")]
    [Address(RVA = "0x46F6AC0", Offset = "0x46F6AC0", VA = "0x46F6AC0")]
    public IReadOnlyDictionary<int, AbilityBoardLotteryResultTypeAllocationData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AbilityBoardLotteryResultTypeAllocationData>) null;
    }

    [Token(Token = "0x6006CC4")]
    [Address(RVA = "0x46F6AC8", Offset = "0x46F6AC8", VA = "0x46F6AC8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006CC5")]
    [Address(RVA = "0x46F6D8C", Offset = "0x46F6D8C", VA = "0x46F6D8C", Slot = "5")]
    protected override AbilityBoardLotteryResultTypeAllocationData LoadEntity(
      IMasterDataReader reader)
    {
      return (AbilityBoardLotteryResultTypeAllocationData) null;
    }

    [Token(Token = "0x6006CC6")]
    [Address(RVA = "0x46F6DFC", Offset = "0x46F6DFC", VA = "0x46F6DFC")]
    private void OnLoadEntity(AbilityBoardLotteryResultTypeAllocationData entity)
    {
    }

    [Token(Token = "0x6006CC7")]
    [Address(RVA = "0x46F6B30", Offset = "0x46F6B30", VA = "0x46F6B30")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x6006CC8")]
    [Address(RVA = "0x46F6E00", Offset = "0x46F6E00", VA = "0x46F6E00")]
    private void GroupingByGroupId(AbilityBoardLotteryResultTypeAllocationData entity)
    {
    }

    [Token(Token = "0x6006CC9")]
    [Address(RVA = "0x46F6FBC", Offset = "0x46F6FBC", VA = "0x46F6FBC")]
    public IReadOnlyList<AbilityBoardLotteryResultTypeAllocationData> GetListByLotteryResult(
      int lotteryResult)
    {
      return (IReadOnlyList<AbilityBoardLotteryResultTypeAllocationData>) null;
    }

    [Token(Token = "0x6006CCA")]
    [Address(RVA = "0x46F7078", Offset = "0x46F7078", VA = "0x46F7078")]
    public AbilityBoardLotteryResultTypeAllocationMaster()
    {
    }
  }
}
