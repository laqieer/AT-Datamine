// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceSummaryMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012A7")]
  [Serializable]
  public sealed class StoryMainQuestSequenceSummaryMaster : 
    BaseMaster<StoryMainQuestSequenceSummaryData>
  {
    [Token(Token = "0x60069E3")]
    [Address(RVA = "0x48D4098", Offset = "0x48D4098", VA = "0x48D4098")]
    public IReadOnlyDictionary<int, StoryMainQuestSequenceSummaryData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestSequenceSummaryData>) null;
    }

    [Token(Token = "0x60069E4")]
    [Address(RVA = "0x48D40A0", Offset = "0x48D40A0", VA = "0x48D40A0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60069E5")]
    [Address(RVA = "0x48D4100", Offset = "0x48D4100", VA = "0x48D4100", Slot = "5")]
    protected override StoryMainQuestSequenceSummaryData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestSequenceSummaryData) null;
    }

    [Token(Token = "0x60069E6")]
    [Address(RVA = "0x48D4158", Offset = "0x48D4158", VA = "0x48D4158")]
    public StoryMainQuestSequenceSummaryMaster()
    {
    }
  }
}
