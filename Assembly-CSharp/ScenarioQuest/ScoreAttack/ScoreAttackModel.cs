// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.ScenarioQuest.ScoreAttack;
using System;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x200083F")]
  public class ScoreAttackModel
  {
    [Token(Token = "0x400274B")]
    [FieldOffset(Offset = "0x20")]
    private int freeApNum;
    [Token(Token = "0x400274C")]
    [FieldOffset(Offset = "0x28")]
    private DateTime dailyUpdateDateTime;

    [Token(Token = "0x170006F8")]
    public int ScoreAttackId
    {
      [Token(Token = "0x6002F70"), Address(RVA = "0x3E6F6AC", Offset = "0x3E6F6AC", VA = "0x3E6F6AC")] get
      {
        return new int();
      }
      [Token(Token = "0x6002F71"), Address(RVA = "0x3E6F6B4", Offset = "0x3E6F6B4", VA = "0x3E6F6B4")] private set
      {
      }
    }

    [Token(Token = "0x140000E5")]
    public event Func<int> OnChangeQuest
    {
      [Token(Token = "0x6002F72"), Address(RVA = "0x3E6F6BC", Offset = "0x3E6F6BC", VA = "0x3E6F6BC")] add
      {
      }
      [Token(Token = "0x6002F73"), Address(RVA = "0x3E6F76C", Offset = "0x3E6F76C", VA = "0x3E6F76C")] remove
      {
      }
    }

    [Token(Token = "0x170006F9")]
    public int QuestId
    {
      [Token(Token = "0x6002F74"), Address(RVA = "0x3E6F81C", Offset = "0x3E6F81C", VA = "0x3E6F81C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6002F75")]
    [Address(RVA = "0x3E6F840", Offset = "0x3E6F840", VA = "0x3E6F840")]
    public int FreeApNum() => new int();

    [Token(Token = "0x6002F76")]
    [Address(RVA = "0x3E6F848", Offset = "0x3E6F848", VA = "0x3E6F848")]
    public ScoreAttackModel(ScoreAttackSubScene.Parameter param)
    {
    }

    [Token(Token = "0x6002F77")]
    [Address(RVA = "0x3E6F87C", Offset = "0x3E6F87C", VA = "0x3E6F87C")]
    public void SetApiData(int freeCount)
    {
    }

    [Token(Token = "0x6002F78")]
    [Address(RVA = "0x3E6F884", Offset = "0x3E6F884", VA = "0x3E6F884")]
    public void SetDailyUpdateDateTime()
    {
    }

    [Token(Token = "0x6002F79")]
    [Address(RVA = "0x3E6F8DC", Offset = "0x3E6F8DC", VA = "0x3E6F8DC")]
    public bool IsDailyUpdateDateTime() => new bool();
  }
}
