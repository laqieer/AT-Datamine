// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestYearMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012B5")]
  [Serializable]
  public sealed class StoryMainQuestYearMaster : BaseMaster<StoryMainQuestYearData>
  {
    [Token(Token = "0x4005911")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x6006A31")]
    [Address(RVA = "0x48D7270", Offset = "0x48D7270", VA = "0x48D7270")]
    public IReadOnlyDictionary<int, StoryMainQuestYearData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestYearData>) null;
    }

    [Token(Token = "0x6006A32")]
    [Address(RVA = "0x48D7278", Offset = "0x48D7278", VA = "0x48D7278", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A33")]
    [Address(RVA = "0x48D72D8", Offset = "0x48D72D8", VA = "0x48D72D8", Slot = "5")]
    protected override StoryMainQuestYearData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestYearData) null;
    }

    [Token(Token = "0x6006A34")]
    [Address(RVA = "0x48D7330", Offset = "0x48D7330", VA = "0x48D7330")]
    public StoryMainQuestYearData GetByLastYear(StoryMainQuestYearData thisYear)
    {
      return (StoryMainQuestYearData) null;
    }

    [Token(Token = "0x6006A35")]
    [Address(RVA = "0x48D760C", Offset = "0x48D760C", VA = "0x48D760C")]
    public StoryMainQuestYearData GetByNextYear(StoryMainQuestYearData thisYear)
    {
      return (StoryMainQuestYearData) null;
    }

    [Token(Token = "0x6006A36")]
    [Address(RVA = "0x48D745C", Offset = "0x48D745C", VA = "0x48D745C")]
    private StoryMainQuestYearData GetByTargetYear(int year, string targetName)
    {
      return (StoryMainQuestYearData) null;
    }

    [Token(Token = "0x6006A37")]
    [Address(RVA = "0x48D7740", Offset = "0x48D7740", VA = "0x48D7740")]
    public StoryMainQuestYearMaster()
    {
    }
  }
}
