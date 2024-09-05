// Decompiled with JetBrains decompiler
// Type: UnitView.UI.BasicParameterView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitView.UI
{
  [Token(Token = "0x2000402")]
  [Serializable]
  public class BasicParameterView
  {
    [Token(Token = "0x40016D2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private BasicParameterView.SingleScoreView vitality;
    [Token(Token = "0x40016D3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BasicParameterView.SingleScoreView strength;
    [Token(Token = "0x40016D4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BasicParameterView.SingleScoreView intelligence;
    [Token(Token = "0x40016D5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BasicParameterView.SingleScoreView defence;
    [Token(Token = "0x40016D6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BasicParameterView.SingleScoreView mind;
    [Token(Token = "0x40016D7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BasicParameterView.SingleScoreView agility;
    [Token(Token = "0x40016D8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private BasicParameterView.SingleScoreView dexterity;
    [Token(Token = "0x40016D9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private BasicParameterView.SingleScoreView lucky;

    [Token(Token = "0x60016F4")]
    [Address(RVA = "0x2489C70", Offset = "0x2489C70", VA = "0x2489C70")]
    public void Update(BasicParameterView.ScoreUpdateParam updateParam)
    {
    }

    [Token(Token = "0x60016F5")]
    [Address(RVA = "0x2489E20", Offset = "0x2489E20", VA = "0x2489E20")]
    public BasicParameterView()
    {
    }

    [Token(Token = "0x2000403")]
    public struct ScoreUpdateParam
    {
      [Token(Token = "0x40016DA")]
      [FieldOffset(Offset = "0x0")]
      public int scoreVitality;
      [Token(Token = "0x40016DB")]
      [FieldOffset(Offset = "0x4")]
      public int scoreStrength;
      [Token(Token = "0x40016DC")]
      [FieldOffset(Offset = "0x8")]
      public int scoreIntelligence;
      [Token(Token = "0x40016DD")]
      [FieldOffset(Offset = "0xC")]
      public int scoreDefence;
      [Token(Token = "0x40016DE")]
      [FieldOffset(Offset = "0x10")]
      public int scoreMind;
      [Token(Token = "0x40016DF")]
      [FieldOffset(Offset = "0x14")]
      public int scoreAgility;
      [Token(Token = "0x40016E0")]
      [FieldOffset(Offset = "0x18")]
      public int scoreDexterity;
      [Token(Token = "0x40016E1")]
      [FieldOffset(Offset = "0x1C")]
      public int scoreLucky;
      [Token(Token = "0x40016E2")]
      [FieldOffset(Offset = "0x20")]
      public bool limitedVitality;
      [Token(Token = "0x40016E3")]
      [FieldOffset(Offset = "0x21")]
      public bool limitedStrength;
      [Token(Token = "0x40016E4")]
      [FieldOffset(Offset = "0x22")]
      public bool limitedIntelligence;
      [Token(Token = "0x40016E5")]
      [FieldOffset(Offset = "0x23")]
      public bool limitedDefence;
      [Token(Token = "0x40016E6")]
      [FieldOffset(Offset = "0x24")]
      public bool limitedMind;
      [Token(Token = "0x40016E7")]
      [FieldOffset(Offset = "0x25")]
      public bool limitedAgility;
      [Token(Token = "0x40016E8")]
      [FieldOffset(Offset = "0x26")]
      public bool limitedDexterity;
      [Token(Token = "0x40016E9")]
      [FieldOffset(Offset = "0x27")]
      public bool limitedLucky;
    }

    [Token(Token = "0x2000404")]
    [Serializable]
    public class SingleScoreView
    {
      [Token(Token = "0x40016EA")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Text score;
      [Token(Token = "0x40016EB")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private Image limitedImage;

      [Token(Token = "0x60016F6")]
      [Address(RVA = "0x2489D4C", Offset = "0x2489D4C", VA = "0x2489D4C")]
      public void Update(int score, bool isLimited)
      {
      }

      [Token(Token = "0x60016F7")]
      [Address(RVA = "0x2489E28", Offset = "0x2489E28", VA = "0x2489E28")]
      public SingleScoreView()
      {
      }
    }
  }
}
