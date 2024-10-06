// Decompiled with JetBrains decompiler
// Type: Scenes.Title.MenuButtonList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x2002925")]
  public class MenuButtonList : MonoBehaviour
  {
    [Token(Token = "0x400AF75")]
    [FieldOffset(Offset = "0x18")]
    [Header("アニメーション中の入力制御用")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400AF76")]
    [FieldOffset(Offset = "0x20")]
    [Space]
    [Header("Tween制御用")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400AF77")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string tweenKeyPrefix;
    [Token(Token = "0x400AF78")]
    [FieldOffset(Offset = "0x30")]
    [Header("メニューの参照")]
    [Space]
    [SerializeField]
    private MenuButtonInfo[] menuButtonInfos;
    [Token(Token = "0x400AF7A")]
    [FieldOffset(Offset = "0x40")]
    public Action<MenuButtonInfo> OnClickMenuButton;
    [Token(Token = "0x400AF7B")]
    [FieldOffset(Offset = "0x48")]
    public Action<MenuButtonInfo> OnFinishedOutAnimationAction;
    [Token(Token = "0x400AF7C")]
    [FieldOffset(Offset = "0x50")]
    private Coroutine coroutine;

    [Token(Token = "0x170038B8")]
    public MenuButtonInfo Current
    {
      [Token(Token = "0x6010300"), Address(RVA = "0x474C9F4", Offset = "0x474C9F4", VA = "0x474C9F4")] get
      {
        return (MenuButtonInfo) null;
      }
      [Token(Token = "0x6010301"), Address(RVA = "0x474C9FC", Offset = "0x474C9FC", VA = "0x474C9FC")] private set
      {
      }
    }

    [Token(Token = "0x6010302")]
    [Address(RVA = "0x474CA04", Offset = "0x474CA04", VA = "0x474CA04")]
    private void Awake()
    {
    }

    [Token(Token = "0x6010303")]
    [Address(RVA = "0x474CB08", Offset = "0x474CB08", VA = "0x474CB08")]
    private void OnClickButton(MenuButtonInfo menuButtonInfo)
    {
    }

    [Token(Token = "0x6010304")]
    [Address(RVA = "0x474CC70", Offset = "0x474CC70", VA = "0x474CC70")]
    private IEnumerator PlayAnimation(MenuButtonInfo menuButtonInfo, Action onFinishedOutAnimation = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010305")]
    [Address(RVA = "0x474CD14", Offset = "0x474CD14", VA = "0x474CD14")]
    public void SelectByIndex(int index)
    {
    }

    [Token(Token = "0x6010306")]
    [Address(RVA = "0x474CBF0", Offset = "0x474CBF0", VA = "0x474CBF0")]
    public void Select(MenuButtonInfo menuButtonInfo, Action onFinishedOutAnimation = null)
    {
    }

    [Token(Token = "0x6010307")]
    [Address(RVA = "0x474CD58", Offset = "0x474CD58", VA = "0x474CD58")]
    public MenuButtonList()
    {
    }

    [Token(Token = "0x2002926")]
    private class InteractableScope : IDisposable
    {
      [Token(Token = "0x400AF7D")]
      [FieldOffset(Offset = "0x10")]
      private CanvasGroup canvasGroup;
      [Token(Token = "0x400AF7E")]
      [FieldOffset(Offset = "0x18")]
      private bool prevInteractable;

      [Token(Token = "0x6010309")]
      [Address(RVA = "0x474CD64", Offset = "0x474CD64", VA = "0x474CD64")]
      public InteractableScope(CanvasGroup canvasGroup, bool interactable)
      {
      }

      [Token(Token = "0x601030A")]
      [Address(RVA = "0x474CDC0", Offset = "0x474CDC0", VA = "0x474CDC0", Slot = "4")]
      public void Dispose()
      {
      }
    }
  }
}
