// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.KilledSpecifiedUnitScoreMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200111C")]
  [Serializable]
  public sealed class KilledSpecifiedUnitScoreMaster : BaseMaster<KilledSpecifiedUnitScoreData>
  {
    [Token(Token = "0x6006280")]
    [Address(RVA = "0x4ADF934", Offset = "0x4ADF934", VA = "0x4ADF934")]
    public IReadOnlyDictionary<int, KilledSpecifiedUnitScoreData> GetEntities()
    {
      return (IReadOnlyDictionary<int, KilledSpecifiedUnitScoreData>) null;
    }

    [Token(Token = "0x6006281")]
    [Address(RVA = "0x4ADF93C", Offset = "0x4ADF93C", VA = "0x4ADF93C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006282")]
    [Address(RVA = "0x4ADF99C", Offset = "0x4ADF99C", VA = "0x4ADF99C", Slot = "5")]
    protected override KilledSpecifiedUnitScoreData LoadEntity(IMasterDataReader reader)
    {
      return (KilledSpecifiedUnitScoreData) null;
    }

    [Token(Token = "0x6006283")]
    [Address(RVA = "0x4ADF9F4", Offset = "0x4ADF9F4", VA = "0x4ADF9F4")]
    public IReadOnlyCollection<KilledSpecifiedUnitScoreData> GetListByGroupId(int groupId)
    {
      return (IReadOnlyCollection<KilledSpecifiedUnitScoreData>) null;
    }

    [Token(Token = "0x6006284")]
    [Address(RVA = "0x4ADFB18", Offset = "0x4ADFB18", VA = "0x4ADFB18")]
    public KilledSpecifiedUnitScoreMaster()
    {
    }
  }
}
