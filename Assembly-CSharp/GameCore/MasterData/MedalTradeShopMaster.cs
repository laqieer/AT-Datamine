// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalTradeShopMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200117E")]
  [Serializable]
  public sealed class MedalTradeShopMaster : BaseMaster<MedalTradeShopData>
  {
    [Token(Token = "0x6006490")]
    [Address(RVA = "0x4AF0A38", Offset = "0x4AF0A38", VA = "0x4AF0A38")]
    public IReadOnlyDictionary<int, MedalTradeShopData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MedalTradeShopData>) null;
    }

    [Token(Token = "0x6006491")]
    [Address(RVA = "0x4AF0A40", Offset = "0x4AF0A40", VA = "0x4AF0A40", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006492")]
    [Address(RVA = "0x4AF0AA0", Offset = "0x4AF0AA0", VA = "0x4AF0AA0", Slot = "5")]
    protected override MedalTradeShopData LoadEntity(IMasterDataReader reader)
    {
      return (MedalTradeShopData) null;
    }

    [Token(Token = "0x6006493")]
    [Address(RVA = "0x4AF0AF8", Offset = "0x4AF0AF8", VA = "0x4AF0AF8")]
    public MedalTradeShopData[] GetInPeriod() => (MedalTradeShopData[]) null;

    [Token(Token = "0x6006494")]
    [Address(RVA = "0x4AF0BE0", Offset = "0x4AF0BE0", VA = "0x4AF0BE0")]
    public bool CheckInPeriod(MedalTradeShopData data) => new bool();

    [Token(Token = "0x6006495")]
    [Address(RVA = "0x4AF0CFC", Offset = "0x4AF0CFC", VA = "0x4AF0CFC")]
    public List<MedalTradeShopData> GetAvailableShopsByMedalId(int medalId)
    {
      return (List<MedalTradeShopData>) null;
    }

    [Token(Token = "0x6006496")]
    [Address(RVA = "0x4AF0FAC", Offset = "0x4AF0FAC", VA = "0x4AF0FAC")]
    public MedalTradeShopMaster()
    {
    }
  }
}
