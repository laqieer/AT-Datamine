// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ShopLayoutMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001187")]
  [Serializable]
  public sealed class ShopLayoutMaster : BaseMaster<ShopLayoutData>
  {
    [Token(Token = "0x60064BC")]
    [Address(RVA = "0x4AF213C", Offset = "0x4AF213C", VA = "0x4AF213C")]
    public IReadOnlyDictionary<int, ShopLayoutData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ShopLayoutData>) null;
    }

    [Token(Token = "0x60064BD")]
    [Address(RVA = "0x4AF2144", Offset = "0x4AF2144", VA = "0x4AF2144", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60064BE")]
    [Address(RVA = "0x4AF21A4", Offset = "0x4AF21A4", VA = "0x4AF21A4", Slot = "5")]
    protected override ShopLayoutData LoadEntity(IMasterDataReader reader) => (ShopLayoutData) null;

    [Token(Token = "0x60064BF")]
    [Address(RVA = "0x4AF21FC", Offset = "0x4AF21FC", VA = "0x4AF21FC")]
    public ShopLayoutData Get(int label, int objectId) => (ShopLayoutData) null;

    [Token(Token = "0x60064C0")]
    [Address(RVA = "0x4AF2308", Offset = "0x4AF2308", VA = "0x4AF2308")]
    public ShopLayoutData Get(ShopTypeEnum type) => (ShopLayoutData) null;

    [Token(Token = "0x60064C1")]
    [Address(RVA = "0x4AF2410", Offset = "0x4AF2410", VA = "0x4AF2410")]
    public IEnumerable<ShopLayoutData> GetList() => (IEnumerable<ShopLayoutData>) null;

    [Token(Token = "0x60064C2")]
    [Address(RVA = "0x4AF2460", Offset = "0x4AF2460", VA = "0x4AF2460")]
    public IEnumerable<ShopLayoutData> GetListByLabel(int label)
    {
      return (IEnumerable<ShopLayoutData>) null;
    }

    [Token(Token = "0x60064C3")]
    [Address(RVA = "0x4AF2568", Offset = "0x4AF2568", VA = "0x4AF2568")]
    public ShopLayoutMaster()
    {
    }
  }
}
