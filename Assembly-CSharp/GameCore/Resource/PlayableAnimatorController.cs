// Decompiled with JetBrains decompiler
// Type: GameCore.Resource.PlayableAnimatorController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

#nullable disable
namespace GameCore.Resource
{
  [Token(Token = "0x2000CB0")]
  internal class PlayableAnimatorController
  {
    [Token(Token = "0x400391A")]
    [FieldOffset(Offset = "0x10")]
    private PlayableGraph customGraph;
    [Token(Token = "0x400391B")]
    [FieldOffset(Offset = "0x20")]
    private AnimationClipPlayable currentPlayable;
    [Token(Token = "0x400391C")]
    [FieldOffset(Offset = "0x30")]
    private PlayableOutput output;

    [Token(Token = "0x600492C")]
    [Address(RVA = "0x3135368", Offset = "0x3135368", VA = "0x3135368")]
    public static PlayableAnimatorController Create(Animator animator)
    {
      return (PlayableAnimatorController) null;
    }

    [Token(Token = "0x600492D")]
    [Address(RVA = "0x313571C", Offset = "0x313571C", VA = "0x313571C")]
    private PlayableAnimatorController()
    {
    }

    [Token(Token = "0x600492E")]
    [Address(RVA = "0x3135724", Offset = "0x3135724", VA = "0x3135724")]
    public void Initialize(Animator animator)
    {
    }

    [Token(Token = "0x600492F")]
    [Address(RVA = "0x31353F4", Offset = "0x31353F4", VA = "0x31353F4")]
    public void Release()
    {
    }

    [Token(Token = "0x6004930")]
    [Address(RVA = "0x31354D4", Offset = "0x31354D4", VA = "0x31354D4")]
    public void ResetCurrentPlayable()
    {
    }

    [Token(Token = "0x6004931")]
    [Address(RVA = "0x3135678", Offset = "0x3135678", VA = "0x3135678")]
    public void Play(AnimationClip animationClip)
    {
    }
  }
}
