// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryReplayEntryMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012BE")]
  [Serializable]
  public sealed class StoryReplayEntryMaster : BaseMaster<StoryReplayEntryData>
  {
    [Token(Token = "0x6006A55")]
    [Address(RVA = "0x48D8318", Offset = "0x48D8318", VA = "0x48D8318")]
    public IReadOnlyDictionary<int, StoryReplayEntryData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryReplayEntryData>) null;
    }

    [Token(Token = "0x6006A56")]
    [Address(RVA = "0x48D8320", Offset = "0x48D8320", VA = "0x48D8320", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A57")]
    [Address(RVA = "0x48D8380", Offset = "0x48D8380", VA = "0x48D8380", Slot = "5")]
    protected override StoryReplayEntryData LoadEntity(IMasterDataReader reader)
    {
      return (StoryReplayEntryData) null;
    }

    [Token(Token = "0x6006A58")]
    [Address(RVA = "0x48D83D8", Offset = "0x48D83D8", VA = "0x48D83D8")]
    public StoryReplayEntryMaster()
    {
    }
  }
}
