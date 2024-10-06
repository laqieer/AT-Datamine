// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionLayoutMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200125D")]
  [Serializable]
  public sealed class StoryFreeActionLayoutMaster : BaseMaster<StoryFreeActionLayoutData>
  {
    [Token(Token = "0x40057D7")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, Dictionary<int, List<StoryFreeActionLayoutData>>> areaGroupingTable;
    [Token(Token = "0x40057D8")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, List<StoryFreeActionLayoutData>> groupingTable;

    [Token(Token = "0x6006869")]
    [Address(RVA = "0x4D389B8", Offset = "0x4D389B8", VA = "0x4D389B8")]
    public IReadOnlyDictionary<int, StoryFreeActionLayoutData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFreeActionLayoutData>) null;
    }

    [Token(Token = "0x600686A")]
    [Address(RVA = "0x4D389C0", Offset = "0x4D389C0", VA = "0x4D389C0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600686B")]
    [Address(RVA = "0x4D38A9C", Offset = "0x4D38A9C", VA = "0x4D38A9C", Slot = "5")]
    protected override StoryFreeActionLayoutData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFreeActionLayoutData) null;
    }

    [Token(Token = "0x600686C")]
    [Address(RVA = "0x4D38A28", Offset = "0x4D38A28", VA = "0x4D38A28")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x600686D")]
    [Address(RVA = "0x4D38B0C", Offset = "0x4D38B0C", VA = "0x4D38B0C")]
    private void OnLoadEntity(StoryFreeActionLayoutData entity)
    {
    }

    [Token(Token = "0x600686E")]
    [Address(RVA = "0x4D38E20", Offset = "0x4D38E20", VA = "0x4D38E20")]
    public IEnumerable<StoryFreeActionLayoutData> GetList()
    {
      return (IEnumerable<StoryFreeActionLayoutData>) null;
    }

    [Token(Token = "0x600686F")]
    [Address(RVA = "0x4D38E70", Offset = "0x4D38E70", VA = "0x4D38E70")]
    public IEnumerable<StoryFreeActionLayoutData> GetListByGroupLabel(
      int layoutGroupLabel,
      int sequenceID)
    {
      return (IEnumerable<StoryFreeActionLayoutData>) null;
    }

    [Token(Token = "0x6006870")]
    [Address(RVA = "0x4D39264", Offset = "0x4D39264", VA = "0x4D39264")]
    public IEnumerable<StoryFreeActionLayoutData> GetListByGroupAndAreaID(
      int layoutGroupLabel,
      int areaID,
      int sequenceID)
    {
      return (IEnumerable<StoryFreeActionLayoutData>) null;
    }

    [Token(Token = "0x6006871")]
    [Address(RVA = "0x4D3954C", Offset = "0x4D3954C", VA = "0x4D3954C")]
    public IEnumerable<StoryFreeActionLayoutData> GetListByGroupAndAreaID(
      int layoutGroupLabel,
      int areaID)
    {
      return (IEnumerable<StoryFreeActionLayoutData>) null;
    }

    [Token(Token = "0x6006872")]
    [Address(RVA = "0x4D39658", Offset = "0x4D39658", VA = "0x4D39658")]
    private bool CheckCondition(
      StoryFreeActionLayoutData layout,
      StoryMainQuestSequenceData sequenceData,
      StoryMainQuestCalendarData calendarData)
    {
      return new bool();
    }

    [Token(Token = "0x6006873")]
    [Address(RVA = "0x4D3970C", Offset = "0x4D3970C", VA = "0x4D3970C")]
    public StoryFreeActionLayoutMaster()
    {
    }
  }
}
