// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StockCounterMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001391")]
  [Serializable]
  public sealed class StockCounterMaster : BaseMaster<StockCounterData>
  {
    [Token(Token = "0x6006E00")]
    [Address(RVA = "0x47015F4", Offset = "0x47015F4", VA = "0x47015F4")]
    public IReadOnlyDictionary<int, StockCounterData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StockCounterData>) null;
    }

    [Token(Token = "0x6006E01")]
    [Address(RVA = "0x47015FC", Offset = "0x47015FC", VA = "0x47015FC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E02")]
    [Address(RVA = "0x470165C", Offset = "0x470165C", VA = "0x470165C", Slot = "5")]
    protected override StockCounterData LoadEntity(IMasterDataReader reader)
    {
      return (StockCounterData) null;
    }

    [Token(Token = "0x6006E03")]
    [Address(RVA = "0x47016B4", Offset = "0x47016B4", VA = "0x47016B4")]
    public StockCounterMaster()
    {
    }
  }
}
