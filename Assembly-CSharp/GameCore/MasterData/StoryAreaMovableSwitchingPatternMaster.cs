// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableSwitchingPatternMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011D5")]
  [Serializable]
  public sealed class StoryAreaMovableSwitchingPatternMaster : 
    BaseMaster<StoryAreaMovableSwitchingPatternData>
  {
    [Token(Token = "0x6006604")]
    [Address(RVA = "0x4D216CC", Offset = "0x4D216CC", VA = "0x4D216CC")]
    public IReadOnlyDictionary<int, StoryAreaMovableSwitchingPatternData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryAreaMovableSwitchingPatternData>) null;
    }

    [Token(Token = "0x6006605")]
    [Address(RVA = "0x4D216D4", Offset = "0x4D216D4", VA = "0x4D216D4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006606")]
    [Address(RVA = "0x4D21734", Offset = "0x4D21734", VA = "0x4D21734", Slot = "5")]
    protected override StoryAreaMovableSwitchingPatternData LoadEntity(IMasterDataReader reader)
    {
      return (StoryAreaMovableSwitchingPatternData) null;
    }

    [Token(Token = "0x6006607")]
    [Address(RVA = "0x4D2178C", Offset = "0x4D2178C", VA = "0x4D2178C")]
    public StoryAreaMovableSwitchingPatternMaster()
    {
    }
  }
}
