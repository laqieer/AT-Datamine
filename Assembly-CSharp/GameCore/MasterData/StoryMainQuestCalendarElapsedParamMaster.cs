// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestCalendarElapsedParamMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001294")]
  [Serializable]
  public sealed class StoryMainQuestCalendarElapsedParamMaster : 
    BaseMaster<StoryMainQuestCalendarElapsedParamData>
  {
    [Token(Token = "0x600698E")]
    [Address(RVA = "0x48D1578", Offset = "0x48D1578", VA = "0x48D1578")]
    public IReadOnlyDictionary<int, StoryMainQuestCalendarElapsedParamData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestCalendarElapsedParamData>) null;
    }

    [Token(Token = "0x600698F")]
    [Address(RVA = "0x48D1580", Offset = "0x48D1580", VA = "0x48D1580", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006990")]
    [Address(RVA = "0x48D15E0", Offset = "0x48D15E0", VA = "0x48D15E0", Slot = "5")]
    protected override StoryMainQuestCalendarElapsedParamData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestCalendarElapsedParamData) null;
    }

    [Token(Token = "0x6006991")]
    [Address(RVA = "0x48D1638", Offset = "0x48D1638", VA = "0x48D1638")]
    public StoryMainQuestCalendarElapsedParamMaster()
    {
    }
  }
}
