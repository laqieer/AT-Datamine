// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapFastTravelTransitionTitleView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x2001604")]
  public class FreeMapFastTravelTransitionTitleView : MonoBehaviour, IFreeMapTransitionView
  {
    [Token(Token = "0x4006455")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI titleText;
    [Token(Token = "0x4006456")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Min(0.0f)]
    [Header("演出の最短表示時間")]
    private float minDuration;
    [Token(Token = "0x4006457")]
    [FieldOffset(Offset = "0x24")]
    private bool isPassedDuration;

    [Token(Token = "0x6007CAF")]
    [Address(RVA = "0x21A38BC", Offset = "0x21A38BC", VA = "0x21A38BC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007CB0")]
    [Address(RVA = "0x21A38E0", Offset = "0x21A38E0", VA = "0x21A38E0", Slot = "4")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x6007CB1")]
    [Address(RVA = "0x21A3904", Offset = "0x21A3904", VA = "0x21A3904", Slot = "5")]
    public void PlayShow()
    {
    }

    [Token(Token = "0x6007CB2")]
    [Address(RVA = "0x21A3A7C", Offset = "0x21A3A7C", VA = "0x21A3A7C", Slot = "6")]
    public void PlayHide(Action callback)
    {
    }

    [Token(Token = "0x6007CB3")]
    [Address(RVA = "0x21A3B14", Offset = "0x21A3B14", VA = "0x21A3B14")]
    private void PlayCloseCallback()
    {
    }

    [Token(Token = "0x6007CB4")]
    [Address(RVA = "0x21A3A14", Offset = "0x21A3A14", VA = "0x21A3A14")]
    private IEnumerator TimeCount() => (IEnumerator) null;

    [Token(Token = "0x6007CB5")]
    [Address(RVA = "0x21A3A9C", Offset = "0x21A3A9C", VA = "0x21A3A9C")]
    private IEnumerator PlayHideTask(Action callback) => (IEnumerator) null;

    [Token(Token = "0x6007CB6")]
    [Address(RVA = "0x21A3B88", Offset = "0x21A3B88", VA = "0x21A3B88")]
    public FreeMapFastTravelTransitionTitleView()
    {
    }
  }
}
