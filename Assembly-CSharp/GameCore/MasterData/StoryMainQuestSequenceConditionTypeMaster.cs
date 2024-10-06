// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceConditionTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012A2")]
  [Serializable]
  public sealed class StoryMainQuestSequenceConditionTypeMaster : 
    BaseMaster<StoryMainQuestSequenceConditionTypeData>
  {
    [Token(Token = "0x60069CD")]
    [Address(RVA = "0x48D3688", Offset = "0x48D3688", VA = "0x48D3688")]
    public IReadOnlyDictionary<int, StoryMainQuestSequenceConditionTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestSequenceConditionTypeData>) null;
    }

    [Token(Token = "0x60069CE")]
    [Address(RVA = "0x48D3690", Offset = "0x48D3690", VA = "0x48D3690", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60069CF")]
    [Address(RVA = "0x48D36F0", Offset = "0x48D36F0", VA = "0x48D36F0", Slot = "5")]
    protected override StoryMainQuestSequenceConditionTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestSequenceConditionTypeData) null;
    }

    [Token(Token = "0x60069D0")]
    [Address(RVA = "0x48D3748", Offset = "0x48D3748", VA = "0x48D3748")]
    public StoryMainQuestSequenceConditionTypeMaster()
    {
    }
  }
}
