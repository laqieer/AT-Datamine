// Decompiled with JetBrains decompiler
// Type: UnitView.UI.BattleParameterView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData.Parameters;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitView.UI
{
  [Token(Token = "0x2000405")]
  [Serializable]
  public class BattleParameterView
  {
    [Token(Token = "0x40016EC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text combatPower;
    [Token(Token = "0x40016ED")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BattleParameterView.SingleScoreView hp;
    [Token(Token = "0x40016EE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BattleParameterView.SingleScoreView physicsAttack;
    [Token(Token = "0x40016EF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BattleParameterView.SingleScoreView magicAttack;
    [Token(Token = "0x40016F0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BattleParameterView.SingleScoreView physicsDefence;
    [Token(Token = "0x40016F1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BattleParameterView.SingleScoreView magicDefence;
    [Token(Token = "0x40016F2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private BattleParameterView.SingleScoreView hit;
    [Token(Token = "0x40016F3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private BattleParameterView.SingleScoreView avoid;
    [Token(Token = "0x40016F4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BattleParameterView.SingleScoreView critical;
    [Token(Token = "0x40016F5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private BattleParameterView.SingleScoreView criticalAvoid;
    [Token(Token = "0x40016F6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private BattleParameterView.SingleScoreView moveAmount;
    [Token(Token = "0x40016F7")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private BattleParameterView.SingleScoreView range;

    [Token(Token = "0x60016F8")]
    [Address(RVA = "0x2489E30", Offset = "0x2489E30", VA = "0x2489E30")]
    public void Update(BattleParameterView.ScoreUpdateParam updateParam)
    {
    }

    [Token(Token = "0x60016F9")]
    [Address(RVA = "0x248A054", Offset = "0x248A054", VA = "0x248A054")]
    public BattleParameterView()
    {
    }

    [Token(Token = "0x2000406")]
    public struct ScoreUpdateParam
    {
      [Token(Token = "0x40016F8")]
      [FieldOffset(Offset = "0x0")]
      public int conbatPower;
      [Token(Token = "0x40016F9")]
      [FieldOffset(Offset = "0x8")]
      public IParameterValueToText valueToTextHp;
      [Token(Token = "0x40016FA")]
      [FieldOffset(Offset = "0x10")]
      public IParameterValueToText valueToTextPhysicsAttack;
      [Token(Token = "0x40016FB")]
      [FieldOffset(Offset = "0x18")]
      public IParameterValueToText valueToTextMagicAttack;
      [Token(Token = "0x40016FC")]
      [FieldOffset(Offset = "0x20")]
      public IParameterValueToText valueToTextPhysicsDefence;
      [Token(Token = "0x40016FD")]
      [FieldOffset(Offset = "0x28")]
      public IParameterValueToText valueToTextMagicDefence;
      [Token(Token = "0x40016FE")]
      [FieldOffset(Offset = "0x30")]
      public IParameterValueToText valueToTextHit;
      [Token(Token = "0x40016FF")]
      [FieldOffset(Offset = "0x38")]
      public IParameterValueToText valueToTextAvoid;
      [Token(Token = "0x4001700")]
      [FieldOffset(Offset = "0x40")]
      public IParameterValueToText valueToTextCritical;
      [Token(Token = "0x4001701")]
      [FieldOffset(Offset = "0x48")]
      public IParameterValueToText valueToTextCriticalAvoid;
      [Token(Token = "0x4001702")]
      [FieldOffset(Offset = "0x50")]
      public IParameterValueToText valueToTextMoveAmount;
      [Token(Token = "0x4001703")]
      [FieldOffset(Offset = "0x58")]
      public IParameterValueToText valueToTextRange;
    }

    [Token(Token = "0x2000407")]
    [Serializable]
    public class SingleScoreView
    {
      [Token(Token = "0x4001704")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Text score;

      [Token(Token = "0x60016FA")]
      [Address(RVA = "0x2489F94", Offset = "0x2489F94", VA = "0x2489F94")]
      public void Update(IParameterValueToText valueToText)
      {
      }

      [Token(Token = "0x60016FB")]
      [Address(RVA = "0x248A05C", Offset = "0x248A05C", VA = "0x248A05C")]
      public SingleScoreView()
      {
      }
    }
  }
}
