// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2ParameterUpResultDialogUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E26")]
  public class Adv2ParameterUpResultDialogUI : MonoBehaviour
  {
    [Token(Token = "0x40110D6")]
    private const string Tags_Text = "Text";
    [Token(Token = "0x40110D7")]
    private const string Tags_CloseButton = "CloseButton";
    [Token(Token = "0x40110D8")]
    private const string TweenGroupId_Popup_In = "Popup_In";
    [Token(Token = "0x40110D9")]
    private const string TweenGroupId_Popup_Out = "Popup_Out";
    [Token(Token = "0x40110DA")]
    private const string TweenGroupId_NextParameter_In = "NextParameter_In";
    [Token(Token = "0x40110DB")]
    private const string TweenGroupId_NextParameter_Out = "NextParameter_Out";
    [Token(Token = "0x40110DC")]
    [FieldOffset(Offset = "0x18")]
    private Transform parent;
    [Token(Token = "0x40110DD")]
    [FieldOffset(Offset = "0x20")]
    private Adv2UiLinker linker;
    [Token(Token = "0x40110DE")]
    [FieldOffset(Offset = "0x28")]
    private UITweenGroup tweenRoot;
    [Token(Token = "0x40110DF")]
    [FieldOffset(Offset = "0x30")]
    private Button closeButton;
    [Token(Token = "0x40110E0")]
    [FieldOffset(Offset = "0x38")]
    private Queue<string> textQueue;
    [Token(Token = "0x40110E1")]
    [FieldOffset(Offset = "0x40")]
    private bool isTappedClose;

    [Token(Token = "0x601909E")]
    [Address(RVA = "0x2968680", Offset = "0x2968680", VA = "0x2968680")]
    public static Adv2ParameterUpResultDialogUI Create(GameObject addComponent, Transform parent)
    {
      return (Adv2ParameterUpResultDialogUI) null;
    }

    [Token(Token = "0x601909F")]
    [Address(RVA = "0x29686E0", Offset = "0x29686E0", VA = "0x29686E0")]
    public void SetBindObject(GameObject prefab)
    {
    }

    [Token(Token = "0x60190A0")]
    [Address(RVA = "0x2968770", Offset = "0x2968770", VA = "0x2968770")]
    private void Init(GameObject prefab)
    {
    }

    [Token(Token = "0x60190A1")]
    [Address(RVA = "0x2968B54", Offset = "0x2968B54", VA = "0x2968B54")]
    private void OnClose()
    {
    }

    [Token(Token = "0x60190A2")]
    [Address(RVA = "0x2968B60", Offset = "0x2968B60", VA = "0x2968B60")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x60190A3")]
    [Address(RVA = "0x2968AB0", Offset = "0x2968AB0", VA = "0x2968AB0")]
    private void SetActiveButton(bool isActive)
    {
    }

    [Token(Token = "0x60190A4")]
    [Address(RVA = "0x2968B90", Offset = "0x2968B90", VA = "0x2968B90")]
    public IEnumerator PlayDirection(List<string> textList) => (IEnumerator) null;

    [Token(Token = "0x60190A5")]
    [Address(RVA = "0x2968C2C", Offset = "0x2968C2C", VA = "0x2968C2C")]
    private IEnumerator UpdateContents() => (IEnumerator) null;

    [Token(Token = "0x60190A6")]
    [Address(RVA = "0x2968CBC", Offset = "0x2968CBC", VA = "0x2968CBC")]
    private IEnumerator WaitOnClose() => (IEnumerator) null;

    [Token(Token = "0x60190A7")]
    [Address(RVA = "0x2968D4C", Offset = "0x2968D4C", VA = "0x2968D4C")]
    private IEnumerator PlayAndWaitTweenGroup(string tweenGroupId) => (IEnumerator) null;

    [Token(Token = "0x60190A8")]
    [Address(RVA = "0x2968DE8", Offset = "0x2968DE8", VA = "0x2968DE8")]
    private void SetText(string text)
    {
    }

    [Token(Token = "0x60190A9")]
    [Address(RVA = "0x2969124", Offset = "0x2969124", VA = "0x2969124")]
    public Adv2ParameterUpResultDialogUI()
    {
    }
  }
}
