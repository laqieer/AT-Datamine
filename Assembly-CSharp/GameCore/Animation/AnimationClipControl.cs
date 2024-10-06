// Decompiled with JetBrains decompiler
// Type: GameCore.Animation.AnimationClipControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Animations;

#nullable disable
namespace GameCore.Animation
{
  [Token(Token = "0x20014DB")]
  [Serializable]
  public class AnimationClipControl : IChildPlayableAPI
  {
    [Token(Token = "0x4005FEB")]
    [FieldOffset(Offset = "0x18")]
    protected AnimationClipPlayable clipPlayable;

    [Token(Token = "0x17001221")]
    public int ConnectIndex
    {
      [Token(Token = "0x60075A7"), Address(RVA = "0x43F99C0", Offset = "0x43F99C0", VA = "0x43F99C0")] private set
      {
      }
      [Token(Token = "0x60075A8"), Address(RVA = "0x43F99C8", Offset = "0x43F99C8", VA = "0x43F99C8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60075A9")]
    [Address(RVA = "0x43F99D0", Offset = "0x43F99D0", VA = "0x43F99D0")]
    public AnimationClipControl()
    {
    }

    [Token(Token = "0x60075AA")]
    [Address(RVA = "0x43F99D8", Offset = "0x43F99D8", VA = "0x43F99D8")]
    public AnimationClipControl(
      AnimationMixerPlayable rootPlayable,
      AnimationClip clip,
      bool useIK)
    {
    }

    [Token(Token = "0x60075AB")]
    [Address(RVA = "0x43F9A24", Offset = "0x43F9A24", VA = "0x43F9A24")]
    public void Initialize(AnimationMixerPlayable rootPlayable, AnimationClip clip, bool useIK)
    {
    }

    [Token(Token = "0x60075AC")]
    [Address(RVA = "0x43F9C2C", Offset = "0x43F9C2C", VA = "0x43F9C2C", Slot = "5")]
    public bool IsValid() => new bool();

    [Token(Token = "0x60075AD")]
    [Address(RVA = "0x43F9C74", Offset = "0x43F9C74", VA = "0x43F9C74")]
    public void Clear()
    {
    }

    [Token(Token = "0x60075AE")]
    [Address(RVA = "0x43F9D44", Offset = "0x43F9D44", VA = "0x43F9D44")]
    public void DirectUpdate(float time, float weight)
    {
    }
  }
}
