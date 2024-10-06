// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.DifficultyScoreMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200110F")]
  [Serializable]
  public sealed class DifficultyScoreMaster : BaseMaster<DifficultyScoreData>
  {
    [Token(Token = "0x6006244")]
    [Address(RVA = "0x4ADDECC", Offset = "0x4ADDECC", VA = "0x4ADDECC")]
    public IReadOnlyDictionary<int, DifficultyScoreData> GetEntities()
    {
      return (IReadOnlyDictionary<int, DifficultyScoreData>) null;
    }

    [Token(Token = "0x6006245")]
    [Address(RVA = "0x4ADDED4", Offset = "0x4ADDED4", VA = "0x4ADDED4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006246")]
    [Address(RVA = "0x4ADDF34", Offset = "0x4ADDF34", VA = "0x4ADDF34", Slot = "5")]
    protected override DifficultyScoreData LoadEntity(IMasterDataReader reader)
    {
      return (DifficultyScoreData) null;
    }

    [Token(Token = "0x6006247")]
    [Address(RVA = "0x4ADDF8C", Offset = "0x4ADDF8C", VA = "0x4ADDF8C")]
    public DifficultyScoreData GetData(int groupId, int difficulty) => (DifficultyScoreData) null;

    [Token(Token = "0x6006248")]
    [Address(RVA = "0x4ADE098", Offset = "0x4ADE098", VA = "0x4ADE098")]
    public DifficultyScoreMaster()
    {
    }
  }
}
