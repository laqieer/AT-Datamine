// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceRewardsPaymentsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012A4")]
  [Serializable]
  public sealed class StoryMainQuestSequenceRewardsPaymentsMaster : 
    BaseMaster<StoryMainQuestSequenceRewardsPaymentsData>
  {
    [Token(Token = "0x40058DB")]
    [FieldOffset(Offset = "0x18")]
    private GroupTable<int, StoryMainQuestSequenceRewardsPaymentsData> groupTable;

    [Token(Token = "0x60069D5")]
    [Address(RVA = "0x48D3A00", Offset = "0x48D3A00", VA = "0x48D3A00")]
    public IReadOnlyDictionary<int, StoryMainQuestSequenceRewardsPaymentsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestSequenceRewardsPaymentsData>) null;
    }

    [Token(Token = "0x60069D6")]
    [Address(RVA = "0x48D3A08", Offset = "0x48D3A08", VA = "0x48D3A08", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60069D7")]
    [Address(RVA = "0x48D3B74", Offset = "0x48D3B74", VA = "0x48D3B74", Slot = "5")]
    protected override StoryMainQuestSequenceRewardsPaymentsData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestSequenceRewardsPaymentsData) null;
    }

    [Token(Token = "0x60069D8")]
    [Address(RVA = "0x48D3A70", Offset = "0x48D3A70", VA = "0x48D3A70")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60069D9")]
    [Address(RVA = "0x48D3BE4", Offset = "0x48D3BE4", VA = "0x48D3BE4")]
    private void OnLoadEntity(StoryMainQuestSequenceRewardsPaymentsData entity)
    {
    }

    [Token(Token = "0x60069DA")]
    [Address(RVA = "0x48D3C3C", Offset = "0x48D3C3C", VA = "0x48D3C3C")]
    public List<StoryMainQuestSequenceRewardsPaymentsData> GetGroupList(int sequenceID)
    {
      return (List<StoryMainQuestSequenceRewardsPaymentsData>) null;
    }

    [Token(Token = "0x60069DB")]
    [Address(RVA = "0x48D3C94", Offset = "0x48D3C94", VA = "0x48D3C94")]
    public StoryMainQuestSequenceRewardsPaymentsMaster()
    {
    }
  }
}
