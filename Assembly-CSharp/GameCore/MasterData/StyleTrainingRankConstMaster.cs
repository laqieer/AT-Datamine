// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleTrainingRankConstMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013C0")]
  [Serializable]
  public sealed class StyleTrainingRankConstMaster : BaseMaster<StyleTrainingRankConstData>
  {
    [Token(Token = "0x6006F03")]
    [Address(RVA = "0x4710230", Offset = "0x4710230", VA = "0x4710230")]
    public IReadOnlyDictionary<int, StyleTrainingRankConstData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StyleTrainingRankConstData>) null;
    }

    [Token(Token = "0x6006F04")]
    [Address(RVA = "0x4710238", Offset = "0x4710238", VA = "0x4710238", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006F05")]
    [Address(RVA = "0x4710298", Offset = "0x4710298", VA = "0x4710298", Slot = "5")]
    protected override StyleTrainingRankConstData LoadEntity(IMasterDataReader reader)
    {
      return (StyleTrainingRankConstData) null;
    }

    [Token(Token = "0x6006F06")]
    [Address(RVA = "0x47102F0", Offset = "0x47102F0", VA = "0x47102F0")]
    public StyleTrainingRankConstData GetData() => (StyleTrainingRankConstData) null;

    [Token(Token = "0x6006F07")]
    [Address(RVA = "0x471034C", Offset = "0x471034C", VA = "0x471034C")]
    public StyleTrainingRankConstMaster()
    {
    }
  }
}
