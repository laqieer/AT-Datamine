// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestCalendarElapsedMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001296")]
  [Serializable]
  public sealed class StoryMainQuestCalendarElapsedMaster : 
    BaseMaster<StoryMainQuestCalendarElapsedData>
  {
    [Token(Token = "0x6006996")]
    [Address(RVA = "0x48D1894", Offset = "0x48D1894", VA = "0x48D1894")]
    public IReadOnlyDictionary<int, StoryMainQuestCalendarElapsedData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestCalendarElapsedData>) null;
    }

    [Token(Token = "0x6006997")]
    [Address(RVA = "0x48D189C", Offset = "0x48D189C", VA = "0x48D189C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006998")]
    [Address(RVA = "0x48D18FC", Offset = "0x48D18FC", VA = "0x48D18FC", Slot = "5")]
    protected override StoryMainQuestCalendarElapsedData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestCalendarElapsedData) null;
    }

    [Token(Token = "0x6006999")]
    [Address(RVA = "0x48D1954", Offset = "0x48D1954", VA = "0x48D1954")]
    public StoryMainQuestCalendarElapsedMaster()
    {
    }
  }
}
