// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestTimeZoneElapsedParamMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012B1")]
  [Serializable]
  public sealed class StoryMainQuestTimeZoneElapsedParamMaster : 
    BaseMaster<StoryMainQuestTimeZoneElapsedParamData>
  {
    [Token(Token = "0x6006A21")]
    [Address(RVA = "0x48D6BC8", Offset = "0x48D6BC8", VA = "0x48D6BC8")]
    public IReadOnlyDictionary<int, StoryMainQuestTimeZoneElapsedParamData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestTimeZoneElapsedParamData>) null;
    }

    [Token(Token = "0x6006A22")]
    [Address(RVA = "0x48D6BD0", Offset = "0x48D6BD0", VA = "0x48D6BD0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A23")]
    [Address(RVA = "0x48D6C30", Offset = "0x48D6C30", VA = "0x48D6C30", Slot = "5")]
    protected override StoryMainQuestTimeZoneElapsedParamData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestTimeZoneElapsedParamData) null;
    }

    [Token(Token = "0x6006A24")]
    [Address(RVA = "0x48D6C88", Offset = "0x48D6C88", VA = "0x48D6C88")]
    public StoryMainQuestTimeZoneElapsedParamMaster()
    {
    }
  }
}
