// Decompiled with JetBrains decompiler
// Type: GameCore.Animation.ScriptSideInFreeAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Model.IK;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

#nullable disable
namespace GameCore.Animation
{
  [Token(Token = "0x20014E9")]
  [Serializable]
  public class ScriptSideInFreeAnimator : IChildPlayableAPI, ILookAtIKImplementor, IIKImplementor
  {
    [Token(Token = "0x4006023")]
    [FieldOffset(Offset = "0x10")]
    protected Animator targetAnimator;
    [Token(Token = "0x4006024")]
    [FieldOffset(Offset = "0x18")]
    protected global::IK targetIK;
    [Token(Token = "0x4006025")]
    [FieldOffset(Offset = "0x20")]
    protected AnimationLayerMixerPlayable rootPlayable;
    [Token(Token = "0x4006026")]
    [FieldOffset(Offset = "0x30")]
    protected AnimatorControllerPlayable animatorControllerPlayable;
    [Token(Token = "0x4006027")]
    [FieldOffset(Offset = "0x40")]
    protected int animatorControllerPlayableIndex;
    [Token(Token = "0x4006028")]
    [FieldOffset(Offset = "0x48")]
    protected Dictionary<string, AnimationLayerControl> layerInfo;
    [Token(Token = "0x4006029")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    protected Vector3 lookAtPosition;
    [Token(Token = "0x400602A")]
    [FieldOffset(Offset = "0x5C")]
    private Vector3 lookAtOffset;
    [Token(Token = "0x400602B")]
    [FieldOffset(Offset = "0x68")]
    public Vector3 FixLookAtPosition;
    [Token(Token = "0x400602C")]
    [FieldOffset(Offset = "0x74")]
    [Range(0.0f, 1f)]
    [SerializeField]
    protected float lookAtWeight;
    [Token(Token = "0x400602D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    [Range(0.0f, 1f)]
    protected float lookAtBodyWeight;
    [Token(Token = "0x400602E")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    [Range(0.0f, 1f)]
    protected float lookAtHeadWeight;
    [Token(Token = "0x400602F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    [Range(0.0f, 1f)]
    protected float lookAtClampWeight;
    [Token(Token = "0x4006030")]
    [FieldOffset(Offset = "0x84")]
    private bool isPauseAnimation;
    [Token(Token = "0x4006031")]
    [FieldOffset(Offset = "0x88")]
    private float oneSecondTurnAngle;
    [Token(Token = "0x4006032")]
    [FieldOffset(Offset = "0x90")]
    private Dictionary<string, HashSet<string>> dicPlayingLyaerClipNameHash;

    [Token(Token = "0x17001237")]
    public Vector3 LookAtPosition
    {
      [Token(Token = "0x6007624"), Address(RVA = "0x43FDB9C", Offset = "0x43FDB9C", VA = "0x43FDB9C")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6007625"), Address(RVA = "0x43FDBA8", Offset = "0x43FDBA8", VA = "0x43FDBA8")] set
      {
      }
    }

    [Token(Token = "0x17001238")]
    public Vector3 LookAtOffset
    {
      [Token(Token = "0x6007626"), Address(RVA = "0x43FDBB4", Offset = "0x43FDBB4", VA = "0x43FDBB4")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6007627"), Address(RVA = "0x43FDBC0", Offset = "0x43FDBC0", VA = "0x43FDBC0")] set
      {
      }
    }

    [Token(Token = "0x17001239")]
    public float LookAtWeight
    {
      [Token(Token = "0x6007628"), Address(RVA = "0x43FDBCC", Offset = "0x43FDBCC", VA = "0x43FDBCC")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700123A")]
    public float LookAtBodyWeight
    {
      [Token(Token = "0x6007629"), Address(RVA = "0x43FDBD4", Offset = "0x43FDBD4", VA = "0x43FDBD4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700123B")]
    public float LookAtHeadWeight
    {
      [Token(Token = "0x600762A"), Address(RVA = "0x43FDBDC", Offset = "0x43FDBDC", VA = "0x43FDBDC")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700123C")]
    public float LookAtClampWeight
    {
      [Token(Token = "0x600762B"), Address(RVA = "0x43FDBE4", Offset = "0x43FDBE4", VA = "0x43FDBE4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700123D")]
    public int ConnectIndex
    {
      [Token(Token = "0x600762C"), Address(RVA = "0x43FDBEC", Offset = "0x43FDBEC", VA = "0x43FDBEC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700123E")]
    public bool IsPauseAnimation
    {
      [Token(Token = "0x600762D"), Address(RVA = "0x43FDBF4", Offset = "0x43FDBF4", VA = "0x43FDBF4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600762E")]
    [Address(RVA = "0x43FB6DC", Offset = "0x43FB6DC", VA = "0x43FB6DC")]
    public void Initialize(AnimationMixerPlayable parent, Animator target)
    {
    }

    [Token(Token = "0x600762F")]
    [Address(RVA = "0x43FBB08", Offset = "0x43FBB08", VA = "0x43FBB08")]
    public void ConnectAnimator(Animator animator, float weight)
    {
    }

    [Token(Token = "0x6007630")]
    [Address(RVA = "0x43FBD14", Offset = "0x43FBD14", VA = "0x43FBD14")]
    public void DisconectAnimator()
    {
    }

    [Token(Token = "0x6007631")]
    [Address(RVA = "0x43FDBFC", Offset = "0x43FDBFC", VA = "0x43FDBFC")]
    public void SetInputAnimatorWeight(float time, float weight)
    {
    }

    [Token(Token = "0x6007632")]
    [Address(RVA = "0x43FDC58", Offset = "0x43FDC58", VA = "0x43FDC58")]
    public void SetTrigger(string trigger)
    {
    }

    [Token(Token = "0x6007633")]
    [Address(RVA = "0x43FDCF8", Offset = "0x43FDCF8", VA = "0x43FDCF8")]
    public void ResetTrigger(string trigger)
    {
    }

    [Token(Token = "0x6007634")]
    [Address(RVA = "0x43FBF54", Offset = "0x43FBF54", VA = "0x43FBF54", Slot = "5")]
    public bool IsValid() => new bool();

    [Token(Token = "0x6007635")]
    [Address(RVA = "0x43FDD98", Offset = "0x43FDD98", VA = "0x43FDD98")]
    public Vector3 GetLookAtForward() => new Vector3();

    [Token(Token = "0x6007636")]
    [Address(RVA = "0x43FDE64", Offset = "0x43FDE64", VA = "0x43FDE64")]
    public float GetTurnAroundTime(Vector3 prevPosition, Vector3 targetPosition) => new float();

    [Token(Token = "0x6007637")]
    [Address(RVA = "0x43FE090", Offset = "0x43FE090", VA = "0x43FE090")]
    public void SetWeight(float weight, float bodyWeight, float headWeight, float clampWeight)
    {
    }

    [Token(Token = "0x6007638")]
    [Address(RVA = "0x43FE0DC", Offset = "0x43FE0DC", VA = "0x43FE0DC")]
    public void LimitWeight(ref float bodyWeight, ref float headWeight, ref float clampWeight)
    {
    }

    [Token(Token = "0x6007639")]
    [Address(RVA = "0x43FBF9C", Offset = "0x43FBF9C", VA = "0x43FBF9C")]
    public void Destroy()
    {
    }

    [Token(Token = "0x600763A")]
    [Address(RVA = "0x43FE0E8", Offset = "0x43FE0E8", VA = "0x43FE0E8")]
    public void AddLayer(string layerName, AvatarMask avatarMask, float weight, bool isAdditive)
    {
    }

    [Token(Token = "0x600763B")]
    [Address(RVA = "0x43FE230", Offset = "0x43FE230", VA = "0x43FE230")]
    public void AddClip(string clipName, string layerName, AnimationClip clip, bool useIK)
    {
    }

    [Token(Token = "0x600763C")]
    [Address(RVA = "0x43FE3B4", Offset = "0x43FE3B4", VA = "0x43FE3B4")]
    public void RemoveClip(string clipName, string layerName)
    {
    }

    [Token(Token = "0x600763D")]
    [Address(RVA = "0x43FE488", Offset = "0x43FE488", VA = "0x43FE488")]
    public void DirectUpdate(string clipName, string layerName, float time, float weight)
    {
    }

    [Token(Token = "0x600763E")]
    [Address(RVA = "0x43FE550", Offset = "0x43FE550", VA = "0x43FE550", Slot = "6")]
    public bool TryGetLookAtWeight(
      out float weight,
      out float bodyWeight,
      out float headWeight,
      out float eyesWeight,
      out float clampWeight)
    {
      return new bool();
    }

    [Token(Token = "0x600763F")]
    [Address(RVA = "0x43FE578", Offset = "0x43FE578", VA = "0x43FE578", Slot = "7")]
    public bool TryGetLookAtPosition(out Vector3 position) => new bool();

    [Token(Token = "0x6007640")]
    [Address(RVA = "0x43FC448", Offset = "0x43FC448", VA = "0x43FC448")]
    public void StopLayer(string layerName)
    {
    }

    [Token(Token = "0x6007641")]
    [Address(RVA = "0x43FC6B0", Offset = "0x43FC6B0", VA = "0x43FC6B0")]
    public ScriptSideInFreeAnimator()
    {
    }
  }
}
