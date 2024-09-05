// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapTransitionTitleUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x2001609")]
  public class FreeMapTransitionTitleUtility
  {
    [Token(Token = "0x4006464")]
    [FieldOffset(Offset = "0x10")]
    private TransitionViewStateHandler viewStateHandler;

    [Token(Token = "0x17001347")]
    private IFreeMapTransitionView currentView
    {
      [Token(Token = "0x6007CCF"), Address(RVA = "0x21A43BC", Offset = "0x21A43BC", VA = "0x21A43BC")] get
      {
        return (IFreeMapTransitionView) null;
      }
    }

    [Token(Token = "0x6007CD0")]
    [Address(RVA = "0x21A1ED4", Offset = "0x21A1ED4", VA = "0x21A1ED4")]
    public void SetupModel(
      FreeMapTransitionTitleModel model,
      FreeMapResourceLoader loader,
      Transform parent)
    {
    }

    [Token(Token = "0x6007CD1")]
    [Address(RVA = "0x21A455C", Offset = "0x21A455C", VA = "0x21A455C")]
    private void OnPlayShow(string title)
    {
    }

    [Token(Token = "0x6007CD2")]
    [Address(RVA = "0x21A4680", Offset = "0x21A4680", VA = "0x21A4680")]
    private void OnPlayHide(Action callback)
    {
    }

    [Token(Token = "0x6007CD3")]
    [Address(RVA = "0x21A4734", Offset = "0x21A4734", VA = "0x21A4734")]
    public void ChangeType(TransitionViewStateHandler.Type state)
    {
    }

    [Token(Token = "0x6007CD4")]
    [Address(RVA = "0x21A1CD4", Offset = "0x21A1CD4", VA = "0x21A1CD4")]
    public FreeMapTransitionTitleUtility()
    {
    }
  }
}
