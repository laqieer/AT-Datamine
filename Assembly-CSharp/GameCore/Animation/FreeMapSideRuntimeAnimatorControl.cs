// Decompiled with JetBrains decompiler
// Type: GameCore.Animation.FreeMapSideRuntimeAnimatorControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

#nullable disable
namespace GameCore.Animation
{
  [Token(Token = "0x20014E3")]
  public class FreeMapSideRuntimeAnimatorControl : IChildPlayableAPI
  {
    [Token(Token = "0x400600F")]
    private const float TransitionTime = 0.3f;
    [Token(Token = "0x4006010")]
    [FieldOffset(Offset = "0x10")]
    protected Animator targetAnimator;
    [Token(Token = "0x4006011")]
    [FieldOffset(Offset = "0x18")]
    protected List<AnimatorControllerControl> animatorControllers;
    [Token(Token = "0x4006012")]
    [FieldOffset(Offset = "0x20")]
    protected AnimationMixerPlayable rootPlayable;
    [Token(Token = "0x4006013")]
    [FieldOffset(Offset = "0x30")]
    protected AnimatorControllerControl.Handle beforeHandle;
    [Token(Token = "0x4006014")]
    [FieldOffset(Offset = "0x34")]
    protected AnimatorControllerControl.Handle currentHandle;

    [Token(Token = "0x17001232")]
    public int ConnectIndex
    {
      [Token(Token = "0x60075FB"), Address(RVA = "0x43FCF40", Offset = "0x43FCF40", VA = "0x43FCF40", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60075FC")]
    [Address(RVA = "0x43FCAE4", Offset = "0x43FCAE4", VA = "0x43FCAE4")]
    public void Initialize(AnimationLayerMixerPlayable parent, Animator target)
    {
    }

    [Token(Token = "0x60075FD")]
    [Address(RVA = "0x43FCC2C", Offset = "0x43FCC2C", VA = "0x43FCC2C")]
    public AnimatorControllerControl.Handle AddController(RuntimeAnimatorController controller)
    {
      return new AnimatorControllerControl.Handle();
    }

    [Token(Token = "0x60075FE")]
    [Address(RVA = "0x43FCF48", Offset = "0x43FCF48", VA = "0x43FCF48", Slot = "5")]
    public bool IsValid() => new bool();

    [Token(Token = "0x60075FF")]
    [Address(RVA = "0x43FCFC4", Offset = "0x43FCFC4", VA = "0x43FCFC4")]
    public void ChangeAnimator(AnimatorControllerControl.Handle next)
    {
    }

    [Token(Token = "0x6007600")]
    [Address(RVA = "0x43FD168", Offset = "0x43FD168", VA = "0x43FD168")]
    public void Update()
    {
    }

    [Token(Token = "0x6007601")]
    [Address(RVA = "0x43FD1F0", Offset = "0x43FD1F0", VA = "0x43FD1F0")]
    public void ResetTrigger(string name)
    {
    }

    [Token(Token = "0x6007602")]
    [Address(RVA = "0x43FD224", Offset = "0x43FD224", VA = "0x43FD224")]
    public void SetTrigger(string name)
    {
    }

    [Token(Token = "0x6007603")]
    [Address(RVA = "0x43FD250", Offset = "0x43FD250", VA = "0x43FD250")]
    public void SetBool(string name, bool value)
    {
    }

    [Token(Token = "0x6007604")]
    [Address(RVA = "0x43FD290", Offset = "0x43FD290", VA = "0x43FD290")]
    public void SetFloat(string name, float value)
    {
    }

    [Token(Token = "0x6007605")]
    [Address(RVA = "0x43FD2D0", Offset = "0x43FD2D0", VA = "0x43FD2D0")]
    public float GetFloat(string name) => new float();

    [Token(Token = "0x6007606")]
    [Address(RVA = "0x43FD300", Offset = "0x43FD300", VA = "0x43FD300")]
    public void Play(string stateName)
    {
    }

    [Token(Token = "0x17001233")]
    public int layerCount
    {
      [Token(Token = "0x6007607"), Address(RVA = "0x43FD32C", Offset = "0x43FD32C", VA = "0x43FD32C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007608")]
    [Address(RVA = "0x43FD34C", Offset = "0x43FD34C", VA = "0x43FD34C")]
    public string GetLayerName(int layerIndex) => (string) null;

    [Token(Token = "0x6007609")]
    [Address(RVA = "0x43FD3B8", Offset = "0x43FD3B8", VA = "0x43FD3B8")]
    public Transform GetBoneTransform(HumanBodyBones humanBoneId) => (Transform) null;

    [Token(Token = "0x600760A")]
    [Address(RVA = "0x43FD3D4", Offset = "0x43FD3D4", VA = "0x43FD3D4")]
    public bool IsInTransition(int layerIndex) => new bool();

    [Token(Token = "0x600760B")]
    [Address(RVA = "0x43FD400", Offset = "0x43FD400", VA = "0x43FD400")]
    public GameObject GetGameObject() => (GameObject) null;

    [Token(Token = "0x600760C")]
    [Address(RVA = "0x43FD41C", Offset = "0x43FD41C", VA = "0x43FD41C")]
    public void SetAnimatorSpeed(float speed)
    {
    }

    [Token(Token = "0x600760D")]
    [Address(RVA = "0x43FD450", Offset = "0x43FD450", VA = "0x43FD450")]
    public void Destroy()
    {
    }

    [Token(Token = "0x600760E")]
    [Address(RVA = "0x43FD21C", Offset = "0x43FD21C", VA = "0x43FD21C")]
    private AnimatorControllerControl GetCurrentAnimation() => (AnimatorControllerControl) null;

    [Token(Token = "0x600760F")]
    [Address(RVA = "0x43FD5DC", Offset = "0x43FD5DC", VA = "0x43FD5DC")]
    public bool IsAnimationEnd() => new bool();

    [Token(Token = "0x6007610")]
    [Address(RVA = "0x43FD644", Offset = "0x43FD644", VA = "0x43FD644")]
    public bool IsPlayAnimation(string name) => new bool();

    [Token(Token = "0x6007611")]
    [Address(RVA = "0x43FD004", Offset = "0x43FD004", VA = "0x43FD004")]
    private AnimatorControllerControl GetAnimation(AnimatorControllerControl.Handle handle)
    {
      return (AnimatorControllerControl) null;
    }

    [Token(Token = "0x6007612")]
    [Address(RVA = "0x43FCE84", Offset = "0x43FCE84", VA = "0x43FCE84")]
    public FreeMapSideRuntimeAnimatorControl()
    {
    }
  }
}
