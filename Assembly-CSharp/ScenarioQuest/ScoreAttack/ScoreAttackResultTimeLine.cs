// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackResultTimeLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.Direction;
using UnityEngine.Events;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x200084C")]
  public class ScoreAttackResultTimeLine : TimeLineFacade
  {
    [Token(Token = "0x4002782")]
    [FieldOffset(Offset = "0x20")]
    private TimeLineFacade.Direction topIn;
    [Token(Token = "0x4002783")]
    [FieldOffset(Offset = "0x30")]
    private TimeLineFacade.Direction topOut;
    [Token(Token = "0x4002784")]
    [FieldOffset(Offset = "0x40")]
    private TimeLineFacade.Direction next;
    [Token(Token = "0x4002785")]
    [FieldOffset(Offset = "0x50")]
    private TimeLineFacade.Direction highScore;

    [Token(Token = "0x6002FC9")]
    [Address(RVA = "0x3E74A90", Offset = "0x3E74A90", VA = "0x3E74A90")]
    public ScoreAttackResultTimeLine(UITimelineController timeline)
    {
    }

    [Token(Token = "0x6002FCA")]
    [Address(RVA = "0x3E74B94", Offset = "0x3E74B94", VA = "0x3E74B94")]
    public void In(UnityAction callback = null)
    {
    }

    [Token(Token = "0x6002FCB")]
    [Address(RVA = "0x3E74BAC", Offset = "0x3E74BAC", VA = "0x3E74BAC")]
    public void Out(UnityAction callback = null)
    {
    }

    [Token(Token = "0x6002FCC")]
    [Address(RVA = "0x3E73F20", Offset = "0x3E73F20", VA = "0x3E73F20")]
    public void NextButtonIn(UnityAction callback = null)
    {
    }

    [Token(Token = "0x6002FCD")]
    [Address(RVA = "0x3E73F50", Offset = "0x3E73F50", VA = "0x3E73F50")]
    public void HighScoreIn(UnityAction callback = null)
    {
    }
  }
}
