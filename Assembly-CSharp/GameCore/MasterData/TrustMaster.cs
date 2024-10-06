// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TrustMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F6C")]
  [Serializable]
  public sealed class TrustMaster : BaseMaster<TrustData>
  {
    [Token(Token = "0x4004D8D")]
    public const string TEXT_AB = "text_masterdata_equipment";

    [Token(Token = "0x6005ABA")]
    [Address(RVA = "0x3C42B38", Offset = "0x3C42B38", VA = "0x3C42B38")]
    public IReadOnlyDictionary<int, TrustData> GetEntities()
    {
      return (IReadOnlyDictionary<int, TrustData>) null;
    }

    [Token(Token = "0x6005ABB")]
    [Address(RVA = "0x3C42B40", Offset = "0x3C42B40", VA = "0x3C42B40", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005ABC")]
    [Address(RVA = "0x3C42BA0", Offset = "0x3C42BA0", VA = "0x3C42BA0", Slot = "5")]
    protected override TrustData LoadEntity(IMasterDataReader reader) => (TrustData) null;

    [Token(Token = "0x6005ABD")]
    [Address(RVA = "0x3C42BF8", Offset = "0x3C42BF8", VA = "0x3C42BF8")]
    public IReadOnlyCollection<TrustData> GetList() => (IReadOnlyCollection<TrustData>) null;

    [Token(Token = "0x6005ABE")]
    [Address(RVA = "0x3C42C48", Offset = "0x3C42C48", VA = "0x3C42C48")]
    public TrustMaster()
    {
    }
  }
}
