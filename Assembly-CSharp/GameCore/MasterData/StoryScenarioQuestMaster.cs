// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryScenarioQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012F1")]
  [Serializable]
  public sealed class StoryScenarioQuestMaster : BaseMaster<StoryScenarioQuestData>
  {
    [Token(Token = "0x6006B26")]
    [Address(RVA = "0x48DF5F8", Offset = "0x48DF5F8", VA = "0x48DF5F8")]
    public IReadOnlyDictionary<int, StoryScenarioQuestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryScenarioQuestData>) null;
    }

    [Token(Token = "0x6006B27")]
    [Address(RVA = "0x48DF600", Offset = "0x48DF600", VA = "0x48DF600", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006B28")]
    [Address(RVA = "0x48DF660", Offset = "0x48DF660", VA = "0x48DF660", Slot = "5")]
    protected override StoryScenarioQuestData LoadEntity(IMasterDataReader reader)
    {
      return (StoryScenarioQuestData) null;
    }

    [Token(Token = "0x6006B29")]
    [Address(RVA = "0x48DF6B8", Offset = "0x48DF6B8", VA = "0x48DF6B8")]
    public IReadOnlyList<StoryScenarioQuestData> GetListInSchedule(in DateTime dateTime)
    {
      return (IReadOnlyList<StoryScenarioQuestData>) null;
    }

    [Token(Token = "0x6006B2A")]
    [Address(RVA = "0x48DFCA4", Offset = "0x48DFCA4", VA = "0x48DFCA4")]
    public StoryScenarioQuestData GetOneInSchedule(in DateTime dateTime)
    {
      return (StoryScenarioQuestData) null;
    }

    [Token(Token = "0x6006B2B")]
    [Address(RVA = "0x48DFD00", Offset = "0x48DFD00", VA = "0x48DFD00")]
    public StoryScenarioQuestData FindByChapterId(int chapterId) => (StoryScenarioQuestData) null;

    [Token(Token = "0x6006B2C")]
    [Address(RVA = "0x48DFE08", Offset = "0x48DFE08", VA = "0x48DFE08")]
    public StoryScenarioQuestData FindByScoreAttackId(int id) => (StoryScenarioQuestData) null;

    [Token(Token = "0x6006B2D")]
    [Address(RVA = "0x48DFF10", Offset = "0x48DFF10", VA = "0x48DFF10")]
    public StoryScenarioQuestMaster()
    {
    }
  }
}
