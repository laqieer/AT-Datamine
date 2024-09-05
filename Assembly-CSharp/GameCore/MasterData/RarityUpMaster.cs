// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.RarityUpMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013A4")]
  [Serializable]
  public sealed class RarityUpMaster : BaseMaster<RarityUpData>
  {
    [Token(Token = "0x6006E55")]
    [Address(RVA = "0x47047F8", Offset = "0x47047F8", VA = "0x47047F8")]
    public IReadOnlyDictionary<int, RarityUpData> GetEntities()
    {
      return (IReadOnlyDictionary<int, RarityUpData>) null;
    }

    [Token(Token = "0x6006E56")]
    [Address(RVA = "0x4704800", Offset = "0x4704800", VA = "0x4704800", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006E57")]
    [Address(RVA = "0x4704860", Offset = "0x4704860", VA = "0x4704860", Slot = "5")]
    protected override RarityUpData LoadEntity(IMasterDataReader reader) => (RarityUpData) null;

    [Token(Token = "0x6006E58")]
    [Address(RVA = "0x47048B8", Offset = "0x47048B8", VA = "0x47048B8")]
    public IReadOnlyCollection<RarityUpData> GetDatasByStyleID(int rarityUpStyleId, int rarityStar)
    {
      return (IReadOnlyCollection<RarityUpData>) null;
    }

    [Token(Token = "0x6006E59")]
    [Address(RVA = "0x47049E0", Offset = "0x47049E0", VA = "0x47049E0")]
    public IReadOnlyCollection<RarityUpData> GetDataByInitialRarityStar(
      int initialRarityStar,
      int rarityStar)
    {
      return (IReadOnlyCollection<RarityUpData>) null;
    }

    [Token(Token = "0x6006E5A")]
    [Address(RVA = "0x4704B08", Offset = "0x4704B08", VA = "0x4704B08")]
    public RarityUpMaster()
    {
    }
  }
}
