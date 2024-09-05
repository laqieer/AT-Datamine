// Decompiled with JetBrains decompiler
// Type: Battle.UI.CommandButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023B4")]
  public class CommandButton : MonoBehaviour
  {
    [Token(Token = "0x4009821")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x4009822")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x4009823")]
    public const string DecisionIn = "Decision_In";
    [Token(Token = "0x4009824")]
    public const string DecisionOut = "Decision_Out";
    [Token(Token = "0x4009825")]
    public const string SelectIn = "Select_In";
    [Token(Token = "0x4009826")]
    public const string SelectOut = "Select_Out";

    [Token(Token = "0x17002F1B")]
    public UITweenGroup Tween
    {
      [Token(Token = "0x600DA7A"), Address(RVA = "0x22D9BD8", Offset = "0x22D9BD8", VA = "0x22D9BD8")] get
      {
        return (UITweenGroup) null;
      }
    }

    [Token(Token = "0x17002F1C")]
    public CommonButton Button
    {
      [Token(Token = "0x600DA7B"), Address(RVA = "0x22D9BE0", Offset = "0x22D9BE0", VA = "0x22D9BE0")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x600DA7C")]
    [Address(RVA = "0x22D9BE8", Offset = "0x22D9BE8", VA = "0x22D9BE8")]
    public string GetDecisionInTweenName() => (string) null;

    [Token(Token = "0x600DA7D")]
    [Address(RVA = "0x22D9C28", Offset = "0x22D9C28", VA = "0x22D9C28")]
    public string GetDecisionOutTweenName() => (string) null;

    [Token(Token = "0x600DA7E")]
    [Address(RVA = "0x22D9C68", Offset = "0x22D9C68", VA = "0x22D9C68")]
    public void ShowSelectButton(bool isShow)
    {
    }

    [Token(Token = "0x600DA7F")]
    [Address(RVA = "0x22D9CE0", Offset = "0x22D9CE0", VA = "0x22D9CE0")]
    public CommandButton()
    {
    }
  }
}
