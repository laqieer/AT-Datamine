// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackEventMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001134")]
  [Serializable]
  public sealed class ScoreAttackEventMaster : BaseMaster<ScoreAttackEventData>
  {
    [Token(Token = "0x6006301")]
    [Address(RVA = "0x4AE49D8", Offset = "0x4AE49D8", VA = "0x4AE49D8")]
    public IReadOnlyDictionary<int, ScoreAttackEventData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ScoreAttackEventData>) null;
    }

    [Token(Token = "0x6006302")]
    [Address(RVA = "0x4AE49E0", Offset = "0x4AE49E0", VA = "0x4AE49E0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006303")]
    [Address(RVA = "0x4AE4A40", Offset = "0x4AE4A40", VA = "0x4AE4A40", Slot = "5")]
    protected override ScoreAttackEventData LoadEntity(IMasterDataReader reader)
    {
      return (ScoreAttackEventData) null;
    }

    [Token(Token = "0x6006304")]
    [Address(RVA = "0x4AE4A98", Offset = "0x4AE4A98", VA = "0x4AE4A98")]
    public ScoreAttackEventData GetDataByScenarioQuestID(int scenarioQuestId)
    {
      return (ScoreAttackEventData) null;
    }

    [Token(Token = "0x6006305")]
    [Address(RVA = "0x4AE4BA0", Offset = "0x4AE4BA0", VA = "0x4AE4BA0")]
    public ScoreAttackEventData GetDataByScoreAttackID(int scoreAttackId)
    {
      return (ScoreAttackEventData) null;
    }

    [Token(Token = "0x6006306")]
    [Address(RVA = "0x4AE4CA8", Offset = "0x4AE4CA8", VA = "0x4AE4CA8")]
    public ScoreAttackEventMaster()
    {
    }
  }
}
