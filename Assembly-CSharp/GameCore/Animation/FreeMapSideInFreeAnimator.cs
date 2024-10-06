// Decompiled with JetBrains decompiler
// Type: GameCore.Animation.FreeMapSideInFreeAnimator
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
  [Token(Token = "0x20014E2")]
  [Serializable]
  public class FreeMapSideInFreeAnimator : IChildPlayableAPI
  {
    [Token(Token = "0x4006009")]
    [FieldOffset(Offset = "0x10")]
    protected Animator targetAnimator;
    [Token(Token = "0x400600A")]
    [FieldOffset(Offset = "0x18")]
    protected FreeMapSideRuntimeAnimatorControl animatorController;
    [Token(Token = "0x400600B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected AnimationLayerControl layerControl;
    [Token(Token = "0x400600C")]
    [FieldOffset(Offset = "0x28")]
    protected AnimationLayerMixerPlayable rootPlayable;
    [Token(Token = "0x400600D")]
    [FieldOffset(Offset = "0x38")]
    protected bool isActiveAnimatorController;
    [Token(Token = "0x400600E")]
    [FieldOffset(Offset = "0x3C")]
    protected float transitionTime;

    [Token(Token = "0x1700122E")]
    public Animator TargetAnimator
    {
      [Token(Token = "0x60075EE"), Address(RVA = "0x43FCACC", Offset = "0x43FCACC", VA = "0x43FCACC")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x1700122F")]
    public FreeMapSideRuntimeAnimatorControl AnimatorController
    {
      [Token(Token = "0x60075EF"), Address(RVA = "0x43FCAD4", Offset = "0x43FCAD4", VA = "0x43FCAD4")] get
      {
        return (FreeMapSideRuntimeAnimatorControl) null;
      }
    }

    [Token(Token = "0x17001230")]
    public AnimationLayerControl LayerControl
    {
      [Token(Token = "0x60075F0"), Address(RVA = "0x43FCADC", Offset = "0x43FCADC", VA = "0x43FCADC")] get
      {
        return (AnimationLayerControl) null;
      }
    }

    [Token(Token = "0x17001231")]
    public int ConnectIndex
    {
      [Token(Token = "0x60075F1"), Address(RVA = "0x43FC190", Offset = "0x43FC190", VA = "0x43FC190", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60075F2")]
    [Address(RVA = "0x43FB8EC", Offset = "0x43FB8EC", VA = "0x43FB8EC")]
    public void Initialize(
      AnimationMixerPlayable parent,
      Animator target,
      RuntimeAnimatorController controller)
    {
    }

    [Token(Token = "0x60075F3")]
    [Address(RVA = "0x43FB56C", Offset = "0x43FB56C", VA = "0x43FB56C")]
    public void WeightUpdate()
    {
    }

    [Token(Token = "0x60075F4")]
    [Address(RVA = "0x43FC148", Offset = "0x43FC148", VA = "0x43FC148", Slot = "5")]
    public bool IsValid() => new bool();

    [Token(Token = "0x60075F5")]
    [Address(RVA = "0x43FBEA4", Offset = "0x43FBEA4", VA = "0x43FBEA4")]
    public void ChangeControl(bool isActiveAnimatorController, float time = 0.3f)
    {
    }

    [Token(Token = "0x60075F6")]
    [Address(RVA = "0x43FCE38", Offset = "0x43FCE38", VA = "0x43FCE38")]
    public void AddClip(string clipName, AnimationClip clip)
    {
    }

    [Token(Token = "0x60075F7")]
    [Address(RVA = "0x43FCE54", Offset = "0x43FCE54", VA = "0x43FCE54")]
    public void RemoveClip(string clipName)
    {
    }

    [Token(Token = "0x60075F8")]
    [Address(RVA = "0x43FCE6C", Offset = "0x43FCE6C", VA = "0x43FCE6C")]
    public void DirectUpdate(string clipName, float time, float weight)
    {
    }

    [Token(Token = "0x60075F9")]
    [Address(RVA = "0x43FC34C", Offset = "0x43FC34C", VA = "0x43FC34C")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60075FA")]
    [Address(RVA = "0x43FC7CC", Offset = "0x43FC7CC", VA = "0x43FC7CC")]
    public FreeMapSideInFreeAnimator()
    {
    }
  }
}
