// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryReplayEntryUnlockMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012C0")]
  [Serializable]
  public sealed class StoryReplayEntryUnlockMaster : BaseMaster<StoryReplayEntryUnlockData>
  {
    [Token(Token = "0x6006A5D")]
    [Address(RVA = "0x48D8784", Offset = "0x48D8784", VA = "0x48D8784")]
    public IReadOnlyDictionary<int, StoryReplayEntryUnlockData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryReplayEntryUnlockData>) null;
    }

    [Token(Token = "0x6006A5E")]
    [Address(RVA = "0x48D878C", Offset = "0x48D878C", VA = "0x48D878C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A5F")]
    [Address(RVA = "0x48D87EC", Offset = "0x48D87EC", VA = "0x48D87EC", Slot = "5")]
    protected override StoryReplayEntryUnlockData LoadEntity(IMasterDataReader reader)
    {
      return (StoryReplayEntryUnlockData) null;
    }

    [Token(Token = "0x6006A60")]
    [Address(RVA = "0x48D8844", Offset = "0x48D8844", VA = "0x48D8844")]
    public StoryReplayEntryUnlockMaster()
    {
    }
  }
}
