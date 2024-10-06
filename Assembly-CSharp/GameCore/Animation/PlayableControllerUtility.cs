// Decompiled with JetBrains decompiler
// Type: GameCore.Animation.PlayableControllerUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Playables;

#nullable disable
namespace GameCore.Animation
{
  [Token(Token = "0x20014EA")]
  public static class PlayableControllerUtility
  {
    [Token(Token = "0x4006033")]
    public const float WEIGHT_MIN = 0.0f;
    [Token(Token = "0x4006034")]
    public const float WEIGHT_MAX = 1f;

    [Token(Token = "0x6007642")]
    [Address(RVA = "0x44E8AA0", Offset = "0x44E8AA0", VA = "0x44E8AA0")]
    public static void LimitLookAtBodyWeight(ref float weight)
    {
    }

    [Token(Token = "0x6007643")]
    [Address(RVA = "0x44E8AC4", Offset = "0x44E8AC4", VA = "0x44E8AC4")]
    public static void LimitLookAtHeadWeight(ref float weight)
    {
    }

    [Token(Token = "0x6007644")]
    [Address(RVA = "0x44E8AE8", Offset = "0x44E8AE8", VA = "0x44E8AE8")]
    public static void LimitLookAtClampWeight(ref float weight)
    {
    }

    [Token(Token = "0x6007645")]
    public static void TransitionWeight<TPlayable>(
      TPlayable playable,
      IChildPlayableAPI before,
      IChildPlayableAPI after,
      float changeTime = 0.0f)
      where TPlayable : struct, IPlayable
    {
    }
  }
}
