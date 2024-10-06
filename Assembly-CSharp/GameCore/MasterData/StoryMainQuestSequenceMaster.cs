// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012A9")]
  [Serializable]
  public sealed class StoryMainQuestSequenceMaster : BaseMaster<StoryMainQuestSequenceData>
  {
    [Token(Token = "0x40058E5")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryMainQuestSequenceData>> groupingTable;
    [Token(Token = "0x40058E6")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, StoryMainQuestSequenceData> questIdSequenceMap;

    [Token(Token = "0x60069EF")]
    [Address(RVA = "0x48D46B0", Offset = "0x48D46B0", VA = "0x48D46B0")]
    public IReadOnlyDictionary<int, StoryMainQuestSequenceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x60069F0")]
    [Address(RVA = "0x48D46B8", Offset = "0x48D46B8", VA = "0x48D46B8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60069F1")]
    [Address(RVA = "0x48D477C", Offset = "0x48D477C", VA = "0x48D477C", Slot = "5")]
    protected override StoryMainQuestSequenceData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestSequenceData) null;
    }

    [Token(Token = "0x60069F2")]
    [Address(RVA = "0x48D4720", Offset = "0x48D4720", VA = "0x48D4720")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60069F3")]
    [Address(RVA = "0x48D47EC", Offset = "0x48D47EC", VA = "0x48D47EC")]
    private void OnLoadEntity(StoryMainQuestSequenceData entity)
    {
    }

    [Token(Token = "0x60069F4")]
    [Address(RVA = "0x48D486C", Offset = "0x48D486C", VA = "0x48D486C")]
    private void Grouping(StoryMainQuestSequenceData entity)
    {
    }

    [Token(Token = "0x60069F5")]
    [Address(RVA = "0x48D49E8", Offset = "0x48D49E8", VA = "0x48D49E8")]
    public IEnumerable<StoryMainQuestSequenceData> GetList(int chapterID)
    {
      return (IEnumerable<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x60069F6")]
    [Address(RVA = "0x48D4AA4", Offset = "0x48D4AA4", VA = "0x48D4AA4")]
    public IReadOnlyCollection<StoryMainQuestSequenceData> GetList()
    {
      return (IReadOnlyCollection<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x60069F7")]
    [Address(RVA = "0x48D4AF4", Offset = "0x48D4AF4", VA = "0x48D4AF4")]
    public StoryMainQuestSequenceData[] GetDataByCalendarAndTimeslot(
      int calendarId,
      StoryTimeSlotTypeEnum timeslot)
    {
      return (StoryMainQuestSequenceData[]) null;
    }

    [Token(Token = "0x60069F8")]
    [Address(RVA = "0x48D4C1C", Offset = "0x48D4C1C", VA = "0x48D4C1C")]
    public StoryMainQuestSequenceData GetDataByIdAndTimeslot(
      int sequenceId,
      StoryTimeSlotTypeEnum timeslot)
    {
      return (StoryMainQuestSequenceData) null;
    }

    [Token(Token = "0x60069F9")]
    [Address(RVA = "0x48D4CE4", Offset = "0x48D4CE4", VA = "0x48D4CE4")]
    public IReadOnlyCollection<StoryMainQuestSequenceData> GetDataByCalendarID(int calendarId)
    {
      return (IReadOnlyCollection<StoryMainQuestSequenceData>) null;
    }

    [Token(Token = "0x60069FA")]
    [Address(RVA = "0x48D4F18", Offset = "0x48D4F18", VA = "0x48D4F18")]
    public StoryMainQuestSequenceData GetByQuestId(int questId)
    {
      return (StoryMainQuestSequenceData) null;
    }

    [Token(Token = "0x60069FB")]
    [Address(RVA = "0x48D4F90", Offset = "0x48D4F90", VA = "0x48D4F90")]
    public StoryMainQuestSequenceMaster()
    {
    }
  }
}
