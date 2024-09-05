// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestRewardPaymentMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200130B")]
  [Serializable]
  public sealed class StorySubquestRewardPaymentMaster : BaseMaster<StorySubquestRewardPaymentData>
  {
    [Token(Token = "0x4005A12")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StorySubquestRewardPaymentData>> groupingTable;
    [Token(Token = "0x4005A13")]
    [FieldOffset(Offset = "0x20")]
    private readonly List<StorySubquestRewardPaymentData> defaultList;

    [Token(Token = "0x6006B83")]
    [Address(RVA = "0x48E2F88", Offset = "0x48E2F88", VA = "0x48E2F88")]
    public IReadOnlyDictionary<int, StorySubquestRewardPaymentData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StorySubquestRewardPaymentData>) null;
    }

    [Token(Token = "0x6006B84")]
    [Address(RVA = "0x48E2F90", Offset = "0x48E2F90", VA = "0x48E2F90", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B85")]
    [Address(RVA = "0x48E3054", Offset = "0x48E3054", VA = "0x48E3054", Slot = "5")]
    protected override StorySubquestRewardPaymentData LoadEntity(IMasterDataReader reader)
    {
      return (StorySubquestRewardPaymentData) null;
    }

    [Token(Token = "0x6006B86")]
    [Address(RVA = "0x48E2FF8", Offset = "0x48E2FF8", VA = "0x48E2FF8")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006B87")]
    [Address(RVA = "0x48E30C4", Offset = "0x48E30C4", VA = "0x48E30C4")]
    private void OnLoadEntity(StorySubquestRewardPaymentData entity)
    {
    }

    [Token(Token = "0x6006B88")]
    [Address(RVA = "0x48E31B4", Offset = "0x48E31B4", VA = "0x48E31B4")]
    private void Grouping(StorySubquestRewardPaymentData entity)
    {
    }

    [Token(Token = "0x6006B89")]
    [Address(RVA = "0x48E3330", Offset = "0x48E3330", VA = "0x48E3330")]
    public IReadOnlyCollection<StorySubquestRewardPaymentData> GetListByRewardSetLabel(
      int taskRewardPaymentLabel)
    {
      return (IReadOnlyCollection<StorySubquestRewardPaymentData>) null;
    }

    [Token(Token = "0x6006B8A")]
    [Address(RVA = "0x48E33B0", Offset = "0x48E33B0", VA = "0x48E33B0")]
    public IReadOnlyList<StorySubquestRewardPaymentData> PaymentDataList(int taskRewardPaymentLabel)
    {
      return (IReadOnlyList<StorySubquestRewardPaymentData>) null;
    }

    [Token(Token = "0x6006B8B")]
    [Address(RVA = "0x48E34E0", Offset = "0x48E34E0", VA = "0x48E34E0")]
    public IReadOnlyList<StorySubquestRewardPaymentData> RewardDataList(int taskRewardPaymentLabel)
    {
      return (IReadOnlyList<StorySubquestRewardPaymentData>) null;
    }

    [Token(Token = "0x6006B8C")]
    [Address(RVA = "0x48E3610", Offset = "0x48E3610", VA = "0x48E3610")]
    public StorySubquestRewardPaymentMaster()
    {
    }
  }
}
