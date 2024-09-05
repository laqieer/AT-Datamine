// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleTrainingRankMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013C2")]
  [Serializable]
  public sealed class StyleTrainingRankMaster : BaseMaster<StyleTrainingRankData>
  {
    [Token(Token = "0x6006F0C")]
    [Address(RVA = "0x4710614", Offset = "0x4710614", VA = "0x4710614")]
    public IReadOnlyDictionary<int, StyleTrainingRankData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleTrainingRankData>) null;
    }

    [Token(Token = "0x6006F0D")]
    [Address(RVA = "0x471061C", Offset = "0x471061C", VA = "0x471061C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006F0E")]
    [Address(RVA = "0x471067C", Offset = "0x471067C", VA = "0x471067C", Slot = "5")]
    protected override StyleTrainingRankData LoadEntity(IMasterDataReader reader)
    {
      return (StyleTrainingRankData) null;
    }

    [Token(Token = "0x6006F0F")]
    [Address(RVA = "0x47106D4", Offset = "0x47106D4", VA = "0x47106D4")]
    public StyleTrainingRankData GetStyleTrainingRankData(float point)
    {
      return (StyleTrainingRankData) null;
    }

    [Token(Token = "0x6006F10")]
    [Address(RVA = "0x4710860", Offset = "0x4710860", VA = "0x4710860")]
    public StyleTrainingRankData GetMaxRankData() => (StyleTrainingRankData) null;

    [Token(Token = "0x6006F11")]
    [Address(RVA = "0x47108CC", Offset = "0x47108CC", VA = "0x47108CC")]
    public StyleTrainingRankData GetRankDataByType(TrainingRankTypeEnum type)
    {
      return (StyleTrainingRankData) null;
    }

    [Token(Token = "0x6006F12")]
    [Address(RVA = "0x47109D4", Offset = "0x47109D4", VA = "0x47109D4")]
    public StyleTrainingRankData GetNextRankData(TrainingRankTypeEnum currentType)
    {
      return (StyleTrainingRankData) null;
    }

    [Token(Token = "0x6006F13")]
    [Address(RVA = "0x4710A58", Offset = "0x4710A58", VA = "0x4710A58")]
    public StyleTrainingRankMaster()
    {
    }
  }
}
