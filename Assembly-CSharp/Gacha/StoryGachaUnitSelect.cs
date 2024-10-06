// Decompiled with JetBrains decompiler
// Type: Gacha.StoryGachaUnitSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200158D")]
  internal class StoryGachaUnitSelect : InfiniteCellBase
  {
    [Token(Token = "0x40062DB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40062DC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image unitImage;
    [Token(Token = "0x40062DD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x40062DE")]
    [FieldOffset(Offset = "0x40")]
    private readonly string[] tweenAnim;
    [Token(Token = "0x40062DF")]
    [FieldOffset(Offset = "0x48")]
    private bool isReleased;
    [Token(Token = "0x40062E0")]
    [FieldOffset(Offset = "0x50")]
    private Coroutine animationCoroutine;

    [Token(Token = "0x6007A22")]
    [Address(RVA = "0x229AD54", Offset = "0x229AD54", VA = "0x229AD54")]
    public static InfiniteCellData CreateCellData(
      Vector2 size,
      Action<int, InfiniteCellBase> onUpdateListItem,
      Action<int, InfiniteCellBase> onClickListItem)
    {
      return (InfiniteCellData) null;
    }

    [Token(Token = "0x6007A23")]
    [Address(RVA = "0x2298DB8", Offset = "0x2298DB8", VA = "0x2298DB8")]
    public void SetUnitImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6007A24")]
    [Address(RVA = "0x229AE14", Offset = "0x229AE14", VA = "0x229AE14")]
    private IEnumerator PlayTweenAnimImple(
      Action onFinished,
      params StoryGachaUnitSelect.TweenAnim[] types)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007A25")]
    [Address(RVA = "0x22980F8", Offset = "0x22980F8", VA = "0x22980F8")]
    public void PlayTweenAnim(Action onFinished, params StoryGachaUnitSelect.TweenAnim[] types)
    {
    }

    [Token(Token = "0x6007A26")]
    [Address(RVA = "0x229AEB8", Offset = "0x229AEB8", VA = "0x229AEB8")]
    public void SetIsReleased(bool isReleased)
    {
    }

    [Token(Token = "0x6007A27")]
    [Address(RVA = "0x22963B4", Offset = "0x22963B4", VA = "0x22963B4")]
    public void PlayDisableAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x6007A28")]
    [Address(RVA = "0x2296324", Offset = "0x2296324", VA = "0x2296324")]
    public void PlayEnableAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x6007A29")]
    [Address(RVA = "0x229AEC4", Offset = "0x229AEC4", VA = "0x229AEC4", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6007A2A")]
    [Address(RVA = "0x229AF6C", Offset = "0x229AF6C", VA = "0x229AF6C")]
    public StoryGachaUnitSelect()
    {
    }

    [Token(Token = "0x200158E")]
    public class Parameter
    {
      [Token(Token = "0x40062E1")]
      [FieldOffset(Offset = "0x10")]
      public Action<int, InfiniteCellBase> OnUpdate;
      [Token(Token = "0x40062E2")]
      [FieldOffset(Offset = "0x18")]
      public Action<int, InfiniteCellBase> OnClick;

      [Token(Token = "0x6007A2B")]
      [Address(RVA = "0x229AE0C", Offset = "0x229AE0C", VA = "0x229AE0C")]
      public Parameter()
      {
      }
    }

    [Token(Token = "0x200158F")]
    public enum TweenAnim
    {
      [Token(Token = "0x40062E4")] Lock,
      [Token(Token = "0x40062E5")] Enabled,
      [Token(Token = "0x40062E6")] Unlock,
      [Token(Token = "0x40062E7")] Disabled,
    }
  }
}
