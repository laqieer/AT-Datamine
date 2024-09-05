// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryPieceMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200103C")]
  [Serializable]
  public sealed class AccessoryPieceMaster : BaseMaster<AccessoryPieceData>
  {
    [Token(Token = "0x400507C")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005E57")]
    [Address(RVA = "0x28C2988", Offset = "0x28C2988", VA = "0x28C2988")]
    public IReadOnlyDictionary<int, AccessoryPieceData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AccessoryPieceData>) null;
    }

    [Token(Token = "0x6005E58")]
    [Address(RVA = "0x28C2990", Offset = "0x28C2990", VA = "0x28C2990", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005E59")]
    [Address(RVA = "0x28C29F0", Offset = "0x28C29F0", VA = "0x28C29F0", Slot = "5")]
    protected override AccessoryPieceData LoadEntity(IMasterDataReader reader)
    {
      return (AccessoryPieceData) null;
    }

    [Token(Token = "0x6005E5A")]
    [Address(RVA = "0x28C2A48", Offset = "0x28C2A48", VA = "0x28C2A48")]
    public AccessoryPieceMaster()
    {
    }
  }
}
