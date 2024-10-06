// Decompiled with JetBrains decompiler
// Type: GameCore.Animation.FreeAnimatorController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

#nullable disable
namespace GameCore.Animation
{
  [Token(Token = "0x20014DF")]
  public class FreeAnimatorController : MonoBehaviour
  {
    [Token(Token = "0x4005FF4")]
    [FieldOffset(Offset = "0x18")]
    private int beforeNameHash;
    [Token(Token = "0x4005FF5")]
    [FieldOffset(Offset = "0x20")]
    private Action playAnimatorAnimation;
    [Token(Token = "0x4005FF6")]
    [FieldOffset(Offset = "0x28")]
    protected Animator targetAnimator;
    [Token(Token = "0x4005FF7")]
    [FieldOffset(Offset = "0x30")]
    protected PlayableGraph graph;
    [Token(Token = "0x4005FF8")]
    [FieldOffset(Offset = "0x40")]
    protected AnimationMixerPlayable rootMixer;
    [Token(Token = "0x4005FF9")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    protected float changeTime;
    [Token(Token = "0x4005FFA")]
    [FieldOffset(Offset = "0x54")]
    protected bool isActiveScriptSide;
    [Token(Token = "0x4005FFB")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    protected ScriptSideInFreeAnimator script;
    [Token(Token = "0x4005FFC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    protected FreeMapSideInFreeAnimator freemap;
    [Token(Token = "0x4005FFD")]
    [FieldOffset(Offset = "0x68")]
    private AnimatorControllerPlayable animatorControllerPlayable;

    [Token(Token = "0x60075CE")]
    [Address(RVA = "0x43FB258", Offset = "0x43FB258", VA = "0x43FB258")]
    public static FreeAnimatorController SetRuntimeAnimatorController(
      Animator target,
      RuntimeAnimatorController controller)
    {
      return (FreeAnimatorController) null;
    }

    [Token(Token = "0x60075CF")]
    [Address(RVA = "0x43FB4F0", Offset = "0x43FB4F0", VA = "0x43FB4F0")]
    private void Update()
    {
    }

    [Token(Token = "0x60075D0")]
    [Address(RVA = "0x43FB5D8", Offset = "0x43FB5D8", VA = "0x43FB5D8")]
    private void OnAnimatorMove()
    {
    }

    [Token(Token = "0x17001225")]
    public Action PlayAnimatorAnimation
    {
      [Token(Token = "0x60075D1"), Address(RVA = "0x43FB6AC", Offset = "0x43FB6AC", VA = "0x43FB6AC")] set
      {
      }
    }

    [Token(Token = "0x17001226")]
    public PlayableGraph RootGraph
    {
      [Token(Token = "0x60075D2"), Address(RVA = "0x43FB6B4", Offset = "0x43FB6B4", VA = "0x43FB6B4")] get
      {
        return new PlayableGraph();
      }
    }

    [Token(Token = "0x17001227")]
    public ScriptSideInFreeAnimator Script
    {
      [Token(Token = "0x60075D3"), Address(RVA = "0x43FB6C0", Offset = "0x43FB6C0", VA = "0x43FB6C0")] get
      {
        return (ScriptSideInFreeAnimator) null;
      }
    }

    [Token(Token = "0x17001228")]
    public FreeMapSideInFreeAnimator FreeMap
    {
      [Token(Token = "0x60075D4"), Address(RVA = "0x43FB6C8", Offset = "0x43FB6C8", VA = "0x43FB6C8")] get
      {
        return (FreeMapSideInFreeAnimator) null;
      }
    }

    [Token(Token = "0x17001229")]
    public AnimatorControllerPlayable AnimatorController
    {
      [Token(Token = "0x60075D5"), Address(RVA = "0x43FB6D0", Offset = "0x43FB6D0", VA = "0x43FB6D0")] get
      {
        return new AnimatorControllerPlayable();
      }
    }

    [Token(Token = "0x60075D6")]
    [Address(RVA = "0x43FB338", Offset = "0x43FB338", VA = "0x43FB338")]
    public void Initialize(Animator target, RuntimeAnimatorController controller)
    {
    }

    [Token(Token = "0x60075D7")]
    [Address(RVA = "0x43FBA70", Offset = "0x43FBA70", VA = "0x43FBA70")]
    public void ConnectAnimatorController(
      RuntimeAnimatorController animatorController,
      Animator animator)
    {
    }

    [Token(Token = "0x60075D8")]
    [Address(RVA = "0x43FBCFC", Offset = "0x43FBCFC", VA = "0x43FBCFC")]
    public void DisconnectAnimatorController()
    {
    }

    [Token(Token = "0x60075D9")]
    [Address(RVA = "0x43FBDB0", Offset = "0x43FBDB0", VA = "0x43FBDB0")]
    public void SetInputAnimatorControllerWeight(float duration, float weight)
    {
    }

    [Token(Token = "0x60075DA")]
    [Address(RVA = "0x43FBDB4", Offset = "0x43FBDB4", VA = "0x43FBDB4")]
    private IEnumerator AnimatorControllerInputWeightChange(
      int input,
      float duration,
      float start,
      float end)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60075DB")]
    [Address(RVA = "0x43FBE78", Offset = "0x43FBE78", VA = "0x43FBE78")]
    public void ChangeControl(bool isActiveScript, float time)
    {
    }

    [Token(Token = "0x60075DC")]
    [Address(RVA = "0x43FBEB4", Offset = "0x43FBEB4", VA = "0x43FBEB4")]
    public void RemoveScriptSide()
    {
    }

    [Token(Token = "0x60075DD")]
    [Address(RVA = "0x43FC198", Offset = "0x43FC198", VA = "0x43FC198")]
    public void RemoveScriptSide(float time)
    {
    }

    [Token(Token = "0x60075DE")]
    [Address(RVA = "0x43FC228", Offset = "0x43FC228", VA = "0x43FC228")]
    protected IEnumerator WaitRemoveScriptSide() => (IEnumerator) null;

    [Token(Token = "0x60075DF")]
    [Address(RVA = "0x43FC2B8", Offset = "0x43FC2B8", VA = "0x43FC2B8")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60075E0")]
    [Address(RVA = "0x43FC438", Offset = "0x43FC438", VA = "0x43FC438")]
    public void StopScriptAnimationLayer(string layerName)
    {
    }

    [Token(Token = "0x60075E1")]
    [Address(RVA = "0x43FC614", Offset = "0x43FC614", VA = "0x43FC614")]
    public FreeAnimatorController()
    {
    }
  }
}
