// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001138")]
  [Serializable]
  public sealed class ScoreAttackQuestMaster : BaseMaster<ScoreAttackQuestData>, IStoryQuestMaster
  {
    [Token(Token = "0x600630F")]
    [Address(RVA = "0x4AE51CC", Offset = "0x4AE51CC", VA = "0x4AE51CC")]
    public IReadOnlyDictionary<int, ScoreAttackQuestData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ScoreAttackQuestData>) null;
    }

    [Token(Token = "0x6006310")]
    [Address(RVA = "0x4AE51D4", Offset = "0x4AE51D4", VA = "0x4AE51D4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006311")]
    [Address(RVA = "0x4AE5234", Offset = "0x4AE5234", VA = "0x4AE5234", Slot = "5")]
    protected override ScoreAttackQuestData LoadEntity(IMasterDataReader reader)
    {
      return (ScoreAttackQuestData) null;
    }

    [Token(Token = "0x6006312")]
    [Address(RVA = "0x4AE528C", Offset = "0x4AE528C", VA = "0x4AE528C", Slot = "6")]
    public IStoryQuestData GetQuestData(int questID) => (IStoryQuestData) null;

    [Token(Token = "0x6006313")]
    [Address(RVA = "0x4AE52E4", Offset = "0x4AE52E4", VA = "0x4AE52E4")]
    public IReadOnlyCollection<ScoreAttackQuestData> GetListByEventID(int eventId)
    {
      return (IReadOnlyCollection<ScoreAttackQuestData>) null;
    }

    [Token(Token = "0x6006314")]
    [Address(RVA = "0x4AE5408", Offset = "0x4AE5408", VA = "0x4AE5408")]
    public ScoreAttackQuestData GetScoreAttackQuestData(int questId) => (ScoreAttackQuestData) null;

    [Token(Token = "0x6006315")]
    [Address(RVA = "0x4AE5510", Offset = "0x4AE5510", VA = "0x4AE5510")]
    public ScoreAttackQuestMaster()
    {
    }
  }
}
