// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CurrencyMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200104B")]
  [Serializable]
  public sealed class CurrencyMaster : BaseMaster<CurrencyData>
  {
    [Token(Token = "0x40050BE")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005EA1")]
    [Address(RVA = "0x28C5D24", Offset = "0x28C5D24", VA = "0x28C5D24")]
    public IReadOnlyDictionary<int, CurrencyData> GetEntities()
    {
      return (IReadOnlyDictionary<int, CurrencyData>) null;
    }

    [Token(Token = "0x6005EA2")]
    [Address(RVA = "0x28C5D2C", Offset = "0x28C5D2C", VA = "0x28C5D2C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005EA3")]
    [Address(RVA = "0x28C5D8C", Offset = "0x28C5D8C", VA = "0x28C5D8C", Slot = "5")]
    protected override CurrencyData LoadEntity(IMasterDataReader reader) => (CurrencyData) null;

    [Token(Token = "0x6005EA4")]
    [Address(RVA = "0x28C5DE4", Offset = "0x28C5DE4", VA = "0x28C5DE4")]
    public CurrencyMaster()
    {
    }
  }
}
