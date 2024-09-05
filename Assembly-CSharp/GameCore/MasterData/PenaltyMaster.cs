// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PenaltyMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E99")]
  [Serializable]
  public sealed class PenaltyMaster : BaseMaster<PenaltyData>
  {
    [Token(Token = "0x60058D3")]
    [Address(RVA = "0x3C2E02C", Offset = "0x3C2E02C", VA = "0x3C2E02C")]
    public IReadOnlyDictionary<int, PenaltyData> GetEntities()
    {
      return (IReadOnlyDictionary<int, PenaltyData>) null;
    }

    [Token(Token = "0x60058D4")]
    [Address(RVA = "0x3C2E034", Offset = "0x3C2E034", VA = "0x3C2E034", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60058D5")]
    [Address(RVA = "0x3C2E094", Offset = "0x3C2E094", VA = "0x3C2E094", Slot = "5")]
    protected override PenaltyData LoadEntity(IMasterDataReader reader) => (PenaltyData) null;

    [Token(Token = "0x60058D6")]
    [Address(RVA = "0x3C2E0EC", Offset = "0x3C2E0EC", VA = "0x3C2E0EC")]
    public PenaltyMaster()
    {
    }
  }
}
