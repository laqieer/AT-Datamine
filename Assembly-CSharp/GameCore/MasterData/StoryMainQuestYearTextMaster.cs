// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestYearTextMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012BA")]
  [Serializable]
  public sealed class StoryMainQuestYearTextMaster : BaseMaster<StoryMainQuestYearTextData>
  {
    [Token(Token = "0x6006A45")]
    [Address(RVA = "0x48D7C6C", Offset = "0x48D7C6C", VA = "0x48D7C6C")]
    public IReadOnlyDictionary<int, StoryMainQuestYearTextData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryMainQuestYearTextData>) null;
    }

    [Token(Token = "0x6006A46")]
    [Address(RVA = "0x48D7C74", Offset = "0x48D7C74", VA = "0x48D7C74", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A47")]
    [Address(RVA = "0x48D7CD4", Offset = "0x48D7CD4", VA = "0x48D7CD4", Slot = "5")]
    protected override StoryMainQuestYearTextData LoadEntity(IMasterDataReader reader)
    {
      return (StoryMainQuestYearTextData) null;
    }

    [Token(Token = "0x6006A48")]
    [Address(RVA = "0x48D7D2C", Offset = "0x48D7D2C", VA = "0x48D7D2C")]
    public StoryMainQuestYearTextMaster()
    {
    }
  }
}
