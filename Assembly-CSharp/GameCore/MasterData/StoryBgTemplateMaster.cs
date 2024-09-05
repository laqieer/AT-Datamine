// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBgTemplateMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012CE")]
  [Serializable]
  public sealed class StoryBgTemplateMaster : BaseMaster<StoryBgTemplateData>
  {
    [Token(Token = "0x6006A8B")]
    [Address(RVA = "0x48D9C90", Offset = "0x48D9C90", VA = "0x48D9C90")]
    public IReadOnlyDictionary<int, StoryBgTemplateData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryBgTemplateData>) null;
    }

    [Token(Token = "0x6006A8C")]
    [Address(RVA = "0x48D9C98", Offset = "0x48D9C98", VA = "0x48D9C98", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006A8D")]
    [Address(RVA = "0x48D9CF8", Offset = "0x48D9CF8", VA = "0x48D9CF8", Slot = "5")]
    protected override StoryBgTemplateData LoadEntity(IMasterDataReader reader)
    {
      return (StoryBgTemplateData) null;
    }

    [Token(Token = "0x6006A8E")]
    [Address(RVA = "0x48D9D50", Offset = "0x48D9D50", VA = "0x48D9D50")]
    public StoryBgTemplateData GetMaster(int bgArea, int advType, int template)
    {
      return (StoryBgTemplateData) null;
    }

    [Token(Token = "0x6006A8F")]
    [Address(RVA = "0x48D9F40", Offset = "0x48D9F40", VA = "0x48D9F40")]
    public StoryBgTemplateMaster()
    {
    }
  }
}
