// Decompiled with JetBrains decompiler
// Type: SkillExplanation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20001C3")]
public class SkillExplanation : MonoBehaviour
{
  [Token(Token = "0x4000AB5")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private UITweenGroup tweenGroup;
  [Token(Token = "0x4000AB6")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Text skillName;
  [Token(Token = "0x4000AB7")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Text skillExplanation;
  [Token(Token = "0x4000AB8")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private SkillIconSub[] skillIconSubs;
  [Token(Token = "0x4000AB9")]
  [FieldOffset(Offset = "0x38")]
  private SkillExplanation.LatestPlay latestPlay;

  [Token(Token = "0x6000B8B")]
  [Address(RVA = "0x4BCA14C", Offset = "0x4BCA14C", VA = "0x4BCA14C")]
  public void Show(SkillParameterData skillParam)
  {
  }

  [Token(Token = "0x6000B8C")]
  [Address(RVA = "0x4BCA61C", Offset = "0x4BCA61C", VA = "0x4BCA61C")]
  public void Out()
  {
  }

  [Token(Token = "0x6000B8D")]
  [Address(RVA = "0x4BCA504", Offset = "0x4BCA504", VA = "0x4BCA504")]
  private void Play(string name, SkillExplanation.LatestPlay latestPlay)
  {
  }

  [Token(Token = "0x6000B8E")]
  [Address(RVA = "0x4BCA24C", Offset = "0x4BCA24C", VA = "0x4BCA24C")]
  private void SetSubSkillIcon(SkillParameterData skillParam)
  {
  }

  [Token(Token = "0x6000B8F")]
  [Address(RVA = "0x4BCA6AC", Offset = "0x4BCA6AC", VA = "0x4BCA6AC")]
  private void HideSubSkillIcons()
  {
  }

  [Token(Token = "0x6000B90")]
  [Address(RVA = "0x4BCA724", Offset = "0x4BCA724", VA = "0x4BCA724")]
  public SkillExplanation()
  {
  }

  [Token(Token = "0x20001C4")]
  private enum LatestPlay
  {
    [Token(Token = "0x4000ABB")] Show,
    [Token(Token = "0x4000ABC")] Out,
  }
}
