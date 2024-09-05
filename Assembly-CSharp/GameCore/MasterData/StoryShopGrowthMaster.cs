// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryShopGrowthMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001193")]
  [Serializable]
  public sealed class StoryShopGrowthMaster : BaseMaster<StoryShopGrowthData>
  {
    [Token(Token = "0x60064E4")]
    [Address(RVA = "0x4AF3DF0", Offset = "0x4AF3DF0", VA = "0x4AF3DF0")]
    public IReadOnlyDictionary<int, StoryShopGrowthData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryShopGrowthData>) null;
    }

    [Token(Token = "0x60064E5")]
    [Address(RVA = "0x4AF3DF8", Offset = "0x4AF3DF8", VA = "0x4AF3DF8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60064E6")]
    [Address(RVA = "0x4AF3E58", Offset = "0x4AF3E58", VA = "0x4AF3E58", Slot = "5")]
    protected override StoryShopGrowthData LoadEntity(IMasterDataReader reader)
    {
      return (StoryShopGrowthData) null;
    }

    [Token(Token = "0x60064E7")]
    [Address(RVA = "0x4AF3EB0", Offset = "0x4AF3EB0", VA = "0x4AF3EB0")]
    public int UpdatePaymentCost(int articleId) => new int();

    [Token(Token = "0x60064E8")]
    [Address(RVA = "0x4AF4104", Offset = "0x4AF4104", VA = "0x4AF4104")]
    public int UpdatePurchaseLimit(int articleId) => new int();

    [Token(Token = "0x60064E9")]
    [Address(RVA = "0x4AF4358", Offset = "0x4AF4358", VA = "0x4AF4358")]
    public StoryShopGrowthData[] GetDatasByArticleID(int articleId) => (StoryShopGrowthData[]) null;

    [Token(Token = "0x60064EA")]
    [Address(RVA = "0x4AF447C", Offset = "0x4AF447C", VA = "0x4AF447C")]
    public StoryShopGrowthMaster()
    {
    }
  }
}
