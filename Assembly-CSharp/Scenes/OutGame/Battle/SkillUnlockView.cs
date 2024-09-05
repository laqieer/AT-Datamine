// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.SkillUnlockView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003786")]
  public sealed class SkillUnlockView : ResultViewBase
  {
    [Token(Token = "0x400F281")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string showName;
    [Token(Token = "0x400F282")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string hideName;
    [Token(Token = "0x400F283")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F284")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image unitTexture;
    [Token(Token = "0x400F285")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text unitName;
    [Token(Token = "0x400F286")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text unitAlphabet;
    [Token(Token = "0x400F287")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text skillName;
    [Token(Token = "0x400F288")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text skillDescription;
    [Token(Token = "0x400F289")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private float showWaitTime;

    [Token(Token = "0x6015DE2")]
    [Address(RVA = "0x231EC24", Offset = "0x231EC24", VA = "0x231EC24", Slot = "5")]
    public override void Initialize(BattleResultSubScene subScene)
    {
    }

    [Token(Token = "0x6015DE3")]
    [Address(RVA = "0x231EC7C", Offset = "0x231EC7C", VA = "0x231EC7C", Slot = "6")]
    public override void Play()
    {
    }

    [Token(Token = "0x6015DE4")]
    [Address(RVA = "0x231ECC4", Offset = "0x231ECC4", VA = "0x231ECC4")]
    public void Play(
      Sprite unitSprite,
      string unitName,
      string unitAlphabet,
      string skillName,
      string skillDescription)
    {
    }

    [Token(Token = "0x6015DE5")]
    [Address(RVA = "0x231EC34", Offset = "0x231EC34", VA = "0x231EC34")]
    public void Hide(bool immediate = false)
    {
    }

    [Token(Token = "0x6015DE6")]
    [Address(RVA = "0x231ED64", Offset = "0x231ED64", VA = "0x231ED64", Slot = "8")]
    protected override IEnumerator ExecutePlayFlow() => (IEnumerator) null;

    [Token(Token = "0x6015DE7")]
    [Address(RVA = "0x231EDF4", Offset = "0x231EDF4", VA = "0x231EDF4")]
    public SkillUnlockView()
    {
    }
  }
}
