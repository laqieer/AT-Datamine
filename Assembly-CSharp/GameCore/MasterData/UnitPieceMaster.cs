// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.UnitPieceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200106A")]
  [Serializable]
  public sealed class UnitPieceMaster : BaseMaster<UnitPieceData>
  {
    [Token(Token = "0x400513C")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005F3E")]
    [Address(RVA = "0x28CC3A0", Offset = "0x28CC3A0", VA = "0x28CC3A0")]
    public IReadOnlyDictionary<int, UnitPieceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, UnitPieceData>) null;
    }

    [Token(Token = "0x6005F3F")]
    [Address(RVA = "0x28CC3A8", Offset = "0x28CC3A8", VA = "0x28CC3A8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F40")]
    [Address(RVA = "0x28CC408", Offset = "0x28CC408", VA = "0x28CC408", Slot = "5")]
    protected override UnitPieceData LoadEntity(IMasterDataReader reader) => (UnitPieceData) null;

    [Token(Token = "0x6005F41")]
    [Address(RVA = "0x28CC460", Offset = "0x28CC460", VA = "0x28CC460")]
    public UnitPieceMaster()
    {
    }
  }
}
