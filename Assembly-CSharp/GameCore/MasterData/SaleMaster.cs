// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SaleMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E9B")]
  [Serializable]
  public sealed class SaleMaster : BaseMaster<SaleData>
  {
    [Token(Token = "0x60058DB")]
    [Address(RVA = "0x3C2E3C0", Offset = "0x3C2E3C0", VA = "0x3C2E3C0")]
    public IReadOnlyDictionary<int, SaleData> GetEntities()
    {
      return (IReadOnlyDictionary<int, SaleData>) null;
    }

    [Token(Token = "0x60058DC")]
    [Address(RVA = "0x3C2E3C8", Offset = "0x3C2E3C8", VA = "0x3C2E3C8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60058DD")]
    [Address(RVA = "0x3C2E428", Offset = "0x3C2E428", VA = "0x3C2E428", Slot = "5")]
    protected override SaleData LoadEntity(IMasterDataReader reader) => (SaleData) null;

    [Token(Token = "0x60058DE")]
    [Address(RVA = "0x3C2E480", Offset = "0x3C2E480", VA = "0x3C2E480")]
    public SaleData GetSaleData(ItemTypeEnum itemType, RarityTypeEnum rarityType)
    {
      return (SaleData) null;
    }

    [Token(Token = "0x60058DF")]
    [Address(RVA = "0x3C2E58C", Offset = "0x3C2E58C", VA = "0x3C2E58C")]
    public SaleMaster()
    {
    }
  }
}
