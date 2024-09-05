// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.DeckTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EA6")]
  [Serializable]
  public sealed class DeckTypeMaster : BaseMaster<DeckTypeData>
  {
    [Token(Token = "0x600590D")]
    [Address(RVA = "0x3C2FC54", Offset = "0x3C2FC54", VA = "0x3C2FC54")]
    public IReadOnlyDictionary<int, DeckTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, DeckTypeData>) null;
    }

    [Token(Token = "0x600590E")]
    [Address(RVA = "0x3C2FC5C", Offset = "0x3C2FC5C", VA = "0x3C2FC5C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600590F")]
    [Address(RVA = "0x3C2FCBC", Offset = "0x3C2FCBC", VA = "0x3C2FCBC", Slot = "5")]
    protected override DeckTypeData LoadEntity(IMasterDataReader reader) => (DeckTypeData) null;

    [Token(Token = "0x6005910")]
    [Address(RVA = "0x3C2FD14", Offset = "0x3C2FD14", VA = "0x3C2FD14")]
    public DeckTypeData GetByDeckType(DeckTypeEnum deckTypeEnum) => (DeckTypeData) null;

    [Token(Token = "0x6005911")]
    [Address(RVA = "0x3C2FE1C", Offset = "0x3C2FE1C", VA = "0x3C2FE1C")]
    public DeckTypeMaster()
    {
    }
  }
}
