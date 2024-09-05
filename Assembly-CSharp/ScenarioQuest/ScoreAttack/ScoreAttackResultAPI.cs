// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackResultAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.ScoreAttack;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.OutGame;
using System.Collections.Generic;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000844")]
  public class ScoreAttackResultAPI
  {
    [Token(Token = "0x6002F9D")]
    [Address(RVA = "0x3E72524", Offset = "0x3E72524", VA = "0x3E72524")]
    public APIScoreAttackBattleEndRequest CreateEndRequest(
      ScoreAttackBattleResultSubScene.Parameter sceneParameter,
      Result _result,
      PlayerScoreAttackResultScoreType score)
    {
      return (APIScoreAttackBattleEndRequest) null;
    }

    [Token(Token = "0x6002F9E")]
    [Address(RVA = "0x3E72678", Offset = "0x3E72678", VA = "0x3E72678")]
    private List<PlayerBattleUnitGrade> CreateBattleUnitGrades(
      ScoreAttackBattleResultSubScene.Parameter param)
    {
      return (List<PlayerBattleUnitGrade>) null;
    }

    [Token(Token = "0x6002F9F")]
    [Address(RVA = "0x3E72D50", Offset = "0x3E72D50", VA = "0x3E72D50")]
    private None CreateGuestUnitGrades(ScoreAttackBattleResultSubScene.Parameter param)
    {
      return (None) null;
    }

    [Token(Token = "0x6002FA0")]
    [Address(RVA = "0x3E73330", Offset = "0x3E73330", VA = "0x3E73330")]
    public ScoreAttackResultAPI()
    {
    }
  }
}
