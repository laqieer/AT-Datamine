// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalTradeUsableMedalListMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001180")]
  [Serializable]
  public sealed class MedalTradeUsableMedalListMaster : BaseMaster<MedalTradeUsableMedalListData>
  {
    [Token(Token = "0x60064A0")]
    [Address(RVA = "0x4AF16C0", Offset = "0x4AF16C0", VA = "0x4AF16C0")]
    public IReadOnlyDictionary<int, MedalTradeUsableMedalListData> GetEntities()
    {
      return (IReadOnlyDictionary<int, MedalTradeUsableMedalListData>) null;
    }

    [Token(Token = "0x60064A1")]
    [Address(RVA = "0x4AF16C8", Offset = "0x4AF16C8", VA = "0x4AF16C8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60064A2")]
    [Address(RVA = "0x4AF1728", Offset = "0x4AF1728", VA = "0x4AF1728", Slot = "5")]
    protected override MedalTradeUsableMedalListData LoadEntity(IMasterDataReader reader)
    {
      return (MedalTradeUsableMedalListData) null;
    }

    [Token(Token = "0x60064A3")]
    [Address(RVA = "0x4AF1780", Offset = "0x4AF1780", VA = "0x4AF1780")]
    public MedalData[] GetMedalDatas(int medalShopId) => (MedalData[]) null;

    [Token(Token = "0x60064A4")]
    [Address(RVA = "0x4AF0E90", Offset = "0x4AF0E90", VA = "0x4AF0E90")]
    public List<MedalTradeUsableMedalListData> GetMedalListDatasByMedalId(int medalId)
    {
      return (List<MedalTradeUsableMedalListData>) null;
    }

    [Token(Token = "0x60064A5")]
    [Address(RVA = "0x4AF197C", Offset = "0x4AF197C", VA = "0x4AF197C")]
    public MedalTradeUsableMedalListMaster()
    {
    }
  }
}
