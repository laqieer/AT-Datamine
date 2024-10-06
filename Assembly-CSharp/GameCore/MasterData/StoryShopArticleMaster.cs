// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryShopArticleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200118F")]
  [Serializable]
  public sealed class StoryShopArticleMaster : BaseMaster<StoryShopArticleData>
  {
    [Token(Token = "0x60064D6")]
    [Address(RVA = "0x4AF2EDC", Offset = "0x4AF2EDC", VA = "0x4AF2EDC")]
    public IReadOnlyDictionary<int, StoryShopArticleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryShopArticleData>) null;
    }

    [Token(Token = "0x60064D7")]
    [Address(RVA = "0x4AF2EE4", Offset = "0x4AF2EE4", VA = "0x4AF2EE4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60064D8")]
    [Address(RVA = "0x4AF2F44", Offset = "0x4AF2F44", VA = "0x4AF2F44", Slot = "5")]
    protected override StoryShopArticleData LoadEntity(IMasterDataReader reader)
    {
      return (StoryShopArticleData) null;
    }

    [Token(Token = "0x60064D9")]
    [Address(RVA = "0x4AF2F9C", Offset = "0x4AF2F9C", VA = "0x4AF2F9C")]
    public bool UnlockStoryShop(ShopTypeEnum shopType) => new bool();

    [Token(Token = "0x60064DA")]
    [Address(RVA = "0x4AF3620", Offset = "0x4AF3620", VA = "0x4AF3620")]
    public StoryShopArticleMaster()
    {
    }
  }
}
