// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponPieceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001070")]
  [Serializable]
  public sealed class WeaponPieceMaster : BaseMaster<WeaponPieceData>
  {
    [Token(Token = "0x400514F")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005F59")]
    [Address(RVA = "0x28CD308", Offset = "0x28CD308", VA = "0x28CD308")]
    public IReadOnlyDictionary<int, WeaponPieceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, WeaponPieceData>) null;
    }

    [Token(Token = "0x6005F5A")]
    [Address(RVA = "0x28CD310", Offset = "0x28CD310", VA = "0x28CD310", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005F5B")]
    [Address(RVA = "0x28CD370", Offset = "0x28CD370", VA = "0x28CD370", Slot = "5")]
    protected override WeaponPieceData LoadEntity(IMasterDataReader reader)
    {
      return (WeaponPieceData) null;
    }

    [Token(Token = "0x6005F5C")]
    [Address(RVA = "0x28CD3C8", Offset = "0x28CD3C8", VA = "0x28CD3C8")]
    public WeaponPieceMaster()
    {
    }
  }
}
