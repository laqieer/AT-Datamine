// Decompiled with JetBrains decompiler
// Type: LoginBonus.TweenGroupExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine.Playables;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AF4")]
  internal static class TweenGroupExtension
  {
    [Token(Token = "0x6003E68")]
    [Address(RVA = "0x2C15288", Offset = "0x2C15288", VA = "0x2C15288")]
    public static void PlayAsync(
      this UITweenGroup tweenGroup,
      string animationKey,
      Action onAnimationComplete)
    {
    }

    [Token(Token = "0x6003E69")]
    [Address(RVA = "0x2C15378", Offset = "0x2C15378", VA = "0x2C15378")]
    public static IAnimationStateHandle PlayHandle(
      this UITweenGroup tweenGroup,
      string animationKey,
      Action onAnimationComplete = null)
    {
      return (IAnimationStateHandle) null;
    }

    [Token(Token = "0x6003E6A")]
    [Address(RVA = "0x2C15404", Offset = "0x2C15404", VA = "0x2C15404")]
    public static void PlayAsync(this PlayableDirector playableDirector, Action onAnimationComplete)
    {
    }

    [Token(Token = "0x6003E6B")]
    [Address(RVA = "0x2C154E0", Offset = "0x2C154E0", VA = "0x2C154E0")]
    public static IAnimationStateHandle PlayHandle(
      this PlayableDirector playableDirector,
      Action onAnimationComplete = null)
    {
      return (IAnimationStateHandle) null;
    }
  }
}
