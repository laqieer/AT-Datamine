// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestCalendarHoridayMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001298")]
  [Serializable]
  public sealed class StoryMainQuestCalendarHoridayMaster : 
    BaseMaster<StoryMainQuestCalendarHoridayData>
  {
    [Token(Token = "0x600699E")]
    [Address(RVA = "0x48D1C20", Offset = "0x48D1C20", VA = "0x48D1C20")]
    public IReadOnlyDictionary<int, StoryMainQuestCalendarHoridayData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestCalendarHoridayData>) null;
    }

    [Token(Token = "0x600699F")]
    [Address(RVA = "0x48D1C28", Offset = "0x48D1C28", VA = "0x48D1C28", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60069A0")]
    [Address(RVA = "0x48D1C88", Offset = "0x48D1C88", VA = "0x48D1C88", Slot = "5")]
    protected override StoryMainQuestCalendarHoridayData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestCalendarHoridayData) null;
    }

    [Token(Token = "0x60069A1")]
    [Address(RVA = "0x48D1CE0", Offset = "0x48D1CE0", VA = "0x48D1CE0")]
    public StoryMainQuestCalendarHoridayMaster()
    {
    }
  }
}
