// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceConditionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012A0")]
  [Serializable]
  public sealed class StoryMainQuestSequenceConditionMaster : 
    BaseMaster<StoryMainQuestSequenceConditionData>
  {
    [Token(Token = "0x60069C3")]
    [Address(RVA = "0x48D30F0", Offset = "0x48D30F0", VA = "0x48D30F0")]
    public IReadOnlyDictionary<int, StoryMainQuestSequenceConditionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestSequenceConditionData>) null;
    }

    [Token(Token = "0x60069C4")]
    [Address(RVA = "0x48D30F8", Offset = "0x48D30F8", VA = "0x48D30F8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60069C5")]
    [Address(RVA = "0x48D3158", Offset = "0x48D3158", VA = "0x48D3158", Slot = "5")]
    protected override StoryMainQuestSequenceConditionData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestSequenceConditionData) null;
    }

    [Token(Token = "0x60069C6")]
    [Address(RVA = "0x48D31B0", Offset = "0x48D31B0", VA = "0x48D31B0")]
    public IEnumerable<StoryMainQuestSequenceConditionData> GetList()
    {
      return (IEnumerable<StoryMainQuestSequenceConditionData>) null;
    }

    [Token(Token = "0x60069C7")]
    [Address(RVA = "0x48D3200", Offset = "0x48D3200", VA = "0x48D3200")]
    public StoryMainQuestSequenceConditionMaster()
    {
    }
  }
}
