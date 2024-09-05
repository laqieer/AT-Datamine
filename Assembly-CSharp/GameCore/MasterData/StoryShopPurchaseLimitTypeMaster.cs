// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryShopPurchaseLimitTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200119F")]
  [Serializable]
  public sealed class StoryShopPurchaseLimitTypeMaster : BaseMaster<StoryShopPurchaseLimitTypeData>
  {
    [Token(Token = "0x600650C")]
    [Address(RVA = "0x4AF4FB0", Offset = "0x4AF4FB0", VA = "0x4AF4FB0")]
    public IReadOnlyDictionary<int, StoryShopPurchaseLimitTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryShopPurchaseLimitTypeData>) null;
    }

    [Token(Token = "0x600650D")]
    [Address(RVA = "0x4AF4FB8", Offset = "0x4AF4FB8", VA = "0x4AF4FB8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600650E")]
    [Address(RVA = "0x4AF5018", Offset = "0x4AF5018", VA = "0x4AF5018", Slot = "5")]
    protected override StoryShopPurchaseLimitTypeData LoadEntity(IMasterDataReader reader)
    {
      return (StoryShopPurchaseLimitTypeData) null;
    }

    [Token(Token = "0x600650F")]
    [Address(RVA = "0x4AF5070", Offset = "0x4AF5070", VA = "0x4AF5070")]
    public StoryShopPurchaseLimitTypeMaster()
    {
    }
  }
}
