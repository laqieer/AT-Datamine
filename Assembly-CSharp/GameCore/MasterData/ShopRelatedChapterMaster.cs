// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ShopRelatedChapterMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200118C")]
  [Serializable]
  public sealed class ShopRelatedChapterMaster : BaseMaster<ShopRelatedChapterData>
  {
    [Token(Token = "0x60064CE")]
    [Address(RVA = "0x4AF2C34", Offset = "0x4AF2C34", VA = "0x4AF2C34")]
    public IReadOnlyDictionary<int, ShopRelatedChapterData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ShopRelatedChapterData>) null;
    }

    [Token(Token = "0x60064CF")]
    [Address(RVA = "0x4AF2C3C", Offset = "0x4AF2C3C", VA = "0x4AF2C3C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60064D0")]
    [Address(RVA = "0x4AF2C9C", Offset = "0x4AF2C9C", VA = "0x4AF2C9C", Slot = "5")]
    protected override ShopRelatedChapterData LoadEntity(IMasterDataReader reader)
    {
      return (ShopRelatedChapterData) null;
    }

    [Token(Token = "0x60064D1")]
    [Address(RVA = "0x4AF2CF4", Offset = "0x4AF2CF4", VA = "0x4AF2CF4")]
    public ShopRelatedChapterMaster()
    {
    }
  }
}
