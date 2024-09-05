// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryReplayEntryDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012BC")]
  [Serializable]
  public sealed class StoryReplayEntryDescriptionMaster : BaseMaster<StoryReplayEntryDescriptionData>
  {
    [Token(Token = "0x6006A4D")]
    [Address(RVA = "0x48D7F8C", Offset = "0x48D7F8C", VA = "0x48D7F8C")]
    public IReadOnlyDictionary<int, StoryReplayEntryDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryReplayEntryDescriptionData>) null;
    }

    [Token(Token = "0x6006A4E")]
    [Address(RVA = "0x48D7F94", Offset = "0x48D7F94", VA = "0x48D7F94", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A4F")]
    [Address(RVA = "0x48D7FF4", Offset = "0x48D7FF4", VA = "0x48D7FF4", Slot = "5")]
    protected override StoryReplayEntryDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (StoryReplayEntryDescriptionData) null;
    }

    [Token(Token = "0x6006A50")]
    [Address(RVA = "0x48D804C", Offset = "0x48D804C", VA = "0x48D804C")]
    public StoryReplayEntryDescriptionMaster()
    {
    }
  }
}
