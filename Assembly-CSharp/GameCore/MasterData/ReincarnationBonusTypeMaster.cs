// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ReincarnationBonusTypeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F0C")]
  [Serializable]
  public sealed class ReincarnationBonusTypeMaster : BaseMaster<ReincarnationBonusTypeData>
  {
    [Token(Token = "0x6005972")]
    [Address(RVA = "0x3C322D8", Offset = "0x3C322D8", VA = "0x3C322D8")]
    public IReadOnlyDictionary<int, ReincarnationBonusTypeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ReincarnationBonusTypeData>) null;
    }

    [Token(Token = "0x6005973")]
    [Address(RVA = "0x3C322E0", Offset = "0x3C322E0", VA = "0x3C322E0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005974")]
    [Address(RVA = "0x3C32340", Offset = "0x3C32340", VA = "0x3C32340", Slot = "5")]
    protected override ReincarnationBonusTypeData LoadEntity(IMasterDataReader reader)
    {
      return (ReincarnationBonusTypeData) null;
    }

    [Token(Token = "0x6005975")]
    [Address(RVA = "0x3C32398", Offset = "0x3C32398", VA = "0x3C32398")]
    public ReincarnationBonusTypeMaster()
    {
    }
  }
}
