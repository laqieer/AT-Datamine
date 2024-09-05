// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestTimeZoneElapsedMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012B3")]
  [Serializable]
  public sealed class StoryMainQuestTimeZoneElapsedMaster : 
    BaseMaster<StoryMainQuestTimeZoneElapsedData>
  {
    [Token(Token = "0x6006A29")]
    [Address(RVA = "0x48D6EE4", Offset = "0x48D6EE4", VA = "0x48D6EE4")]
    public IReadOnlyDictionary<int, StoryMainQuestTimeZoneElapsedData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestTimeZoneElapsedData>) null;
    }

    [Token(Token = "0x6006A2A")]
    [Address(RVA = "0x48D6EEC", Offset = "0x48D6EEC", VA = "0x48D6EEC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A2B")]
    [Address(RVA = "0x48D6F4C", Offset = "0x48D6F4C", VA = "0x48D6F4C", Slot = "5")]
    protected override StoryMainQuestTimeZoneElapsedData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestTimeZoneElapsedData) null;
    }

    [Token(Token = "0x6006A2C")]
    [Address(RVA = "0x48D6FA4", Offset = "0x48D6FA4", VA = "0x48D6FA4")]
    public StoryMainQuestTimeZoneElapsedMaster()
    {
    }
  }
}
