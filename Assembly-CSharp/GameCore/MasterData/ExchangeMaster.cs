// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExchangeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001053")]
  [Serializable]
  public sealed class ExchangeMaster : BaseMaster<ExchangeData>
  {
    [Token(Token = "0x40050DC")]
    public const string TEXT_AB = "text_masterdata_item";

    [Token(Token = "0x6005ECA")]
    [Address(RVA = "0x28C7744", Offset = "0x28C7744", VA = "0x28C7744")]
    public IReadOnlyDictionary<int, ExchangeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExchangeData>) null;
    }

    [Token(Token = "0x6005ECB")]
    [Address(RVA = "0x28C774C", Offset = "0x28C774C", VA = "0x28C774C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005ECC")]
    [Address(RVA = "0x28C77AC", Offset = "0x28C77AC", VA = "0x28C77AC", Slot = "5")]
    protected override ExchangeData LoadEntity(IMasterDataReader reader) => (ExchangeData) null;

    [Token(Token = "0x6005ECD")]
    [Address(RVA = "0x28C7804", Offset = "0x28C7804", VA = "0x28C7804")]
    public ExchangeMaster()
    {
    }
  }
}
