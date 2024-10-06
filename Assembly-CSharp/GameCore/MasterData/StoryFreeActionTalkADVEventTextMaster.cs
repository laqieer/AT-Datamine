// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionTalkADVEventTextMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001285")]
  [Serializable]
  public sealed class StoryFreeActionTalkADVEventTextMaster : 
    BaseMaster<StoryFreeActionTalkADVEventTextData>
  {
    [Token(Token = "0x4005885")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFreeActionTalkADVEventTextData>> groupingDic;

    [Token(Token = "0x6006945")]
    [Address(RVA = "0x48CEAEC", Offset = "0x48CEAEC", VA = "0x48CEAEC")]
    public IReadOnlyDictionary<int, StoryFreeActionTalkADVEventTextData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionTalkADVEventTextData>) null;
    }

    [Token(Token = "0x6006946")]
    [Address(RVA = "0x48CEAF4", Offset = "0x48CEAF4", VA = "0x48CEAF4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006947")]
    [Address(RVA = "0x48CEE0C", Offset = "0x48CEE0C", VA = "0x48CEE0C", Slot = "5")]
    protected override StoryFreeActionTalkADVEventTextData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionTalkADVEventTextData) null;
    }

    [Token(Token = "0x6006948")]
    [Address(RVA = "0x48CEB64", Offset = "0x48CEB64", VA = "0x48CEB64")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x6006949")]
    [Address(RVA = "0x48CEE7C", Offset = "0x48CEE7C", VA = "0x48CEE7C")]
    private void OnLoadEntity(StoryFreeActionTalkADVEventTextData entity)
    {
    }

    [Token(Token = "0x600694A")]
    [Address(RVA = "0x48CEBBC", Offset = "0x48CEBBC", VA = "0x48CEBBC")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x600694B")]
    [Address(RVA = "0x48CEFF8", Offset = "0x48CEFF8", VA = "0x48CEFF8")]
    public IReadOnlyList<StoryFreeActionTalkADVEventTextData> GetGroupingList(int tableID)
    {
      return (IReadOnlyList<StoryFreeActionTalkADVEventTextData>) null;
    }

    [Token(Token = "0x600694C")]
    [Address(RVA = "0x48CF0B4", Offset = "0x48CF0B4", VA = "0x48CF0B4")]
    public IEnumerable<StoryFreeActionTalkADVEventTextData> GetList()
    {
      return (IEnumerable<StoryFreeActionTalkADVEventTextData>) null;
    }

    [Token(Token = "0x600694D")]
    [Address(RVA = "0x48CF104", Offset = "0x48CF104", VA = "0x48CF104")]
    public StoryFreeActionTalkADVEventTextMaster()
    {
    }
  }
}
