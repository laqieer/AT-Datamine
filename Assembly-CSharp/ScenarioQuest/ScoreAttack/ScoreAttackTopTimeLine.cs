// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackTopTimeLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.Direction;
using UnityEngine.Events;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000856")]
  public class ScoreAttackTopTimeLine : TimeLineFacade
  {
    [Token(Token = "0x40027A1")]
    [FieldOffset(Offset = "0x20")]
    private TimeLineFacade.Direction topIn;
    [Token(Token = "0x40027A2")]
    [FieldOffset(Offset = "0x30")]
    private TimeLineFacade.Direction topOut;

    [Token(Token = "0x6002FFB")]
    [Address(RVA = "0x3E75C1C", Offset = "0x3E75C1C", VA = "0x3E75C1C")]
    public ScoreAttackTopTimeLine(UITimelineController timeline)
    {
    }

    [Token(Token = "0x6002FFC")]
    [Address(RVA = "0x3E75CA8", Offset = "0x3E75CA8", VA = "0x3E75CA8")]
    public void In(UnityAction callback = null)
    {
    }

    [Token(Token = "0x6002FFD")]
    [Address(RVA = "0x3E75CBC", Offset = "0x3E75CBC", VA = "0x3E75CBC")]
    public void Out(UnityAction callback = null)
    {
    }
  }
}
