// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Element.FreeMapCharacterLookAt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Model.IK;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Element
{
  [Token(Token = "0x2001904")]
  [RequireComponent(typeof (Animator))]
  public class FreeMapCharacterLookAt : MonoBehaviour, ILookAtIKImplementor, IIKImplementor
  {
    [Token(Token = "0x4006C19")]
    [FieldOffset(Offset = "0x18")]
    [Header("モーションに対するLookAtの重み")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float bodyWeight;
    [Token(Token = "0x4006C1A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float headWeight;
    [Token(Token = "0x4006C1B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float clampWeight;
    [Token(Token = "0x4006C1D")]
    [FieldOffset(Offset = "0x30")]
    private Transform targetNow;
    [Token(Token = "0x4006C1E")]
    [FieldOffset(Offset = "0x38")]
    protected Animator targetAnimator;
    [Token(Token = "0x4006C1F")]
    [FieldOffset(Offset = "0x40")]
    private Transform targetBefore;
    [Token(Token = "0x4006C20")]
    [FieldOffset(Offset = "0x48")]
    private float lookAtWeightNow;
    [Token(Token = "0x4006C21")]
    [FieldOffset(Offset = "0x4C")]
    private float lookAtWeightBefore;
    [Token(Token = "0x4006C22")]
    [FieldOffset(Offset = "0x50")]
    private float lookAtRatio;
    [Token(Token = "0x4006C23")]
    [FieldOffset(Offset = "0x58")]
    private AnimationCurve transitionCurve;
    [Token(Token = "0x4006C24")]
    [FieldOffset(Offset = "0x60")]
    private float transitionSeconds;
    [Token(Token = "0x4006C25")]
    [FieldOffset(Offset = "0x64")]
    private Vector3 lookAtPosition;
    [Token(Token = "0x4006C26")]
    [FieldOffset(Offset = "0x70")]
    private float lookAtWeight;
    [Token(Token = "0x4006C27")]
    [FieldOffset(Offset = "0x78")]
    private List<GameObject> dummyObjects;

    [Token(Token = "0x170016CC")]
    protected global::IK TargetIK
    {
      [Token(Token = "0x6008E1E"), Address(RVA = "0x4AFD5C4", Offset = "0x4AFD5C4", VA = "0x4AFD5C4")] set
      {
      }
      [Token(Token = "0x6008E1F"), Address(RVA = "0x4AFD5CC", Offset = "0x4AFD5CC", VA = "0x4AFD5CC")] get
      {
        return (global::IK) null;
      }
    }

    [Token(Token = "0x170016CD")]
    private Transform TargetNow
    {
      [Token(Token = "0x6008E20"), Address(RVA = "0x4AFD5D4", Offset = "0x4AFD5D4", VA = "0x4AFD5D4")] set
      {
      }
      [Token(Token = "0x6008E21"), Address(RVA = "0x4AFD6A4", Offset = "0x4AFD6A4", VA = "0x4AFD6A4")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x6008E22")]
    [Address(RVA = "0x4AFD6AC", Offset = "0x4AFD6AC", VA = "0x4AFD6AC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008E23")]
    [Address(RVA = "0x4AFD6E4", Offset = "0x4AFD6E4", VA = "0x4AFD6E4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6008E24")]
    [Address(RVA = "0x4AFD814", Offset = "0x4AFD814", VA = "0x4AFD814")]
    public void SetGazePoint(Transform target, AnimationCurve curve, float ratio)
    {
    }

    [Token(Token = "0x6008E25")]
    [Address(RVA = "0x4AFE190", Offset = "0x4AFE190", VA = "0x4AFE190")]
    public void SetGazePoint(float verticalEulerAngle, AnimationCurve curve, float ratio)
    {
    }

    [Token(Token = "0x6008E26")]
    [Address(RVA = "0x4AFE354", Offset = "0x4AFE354", VA = "0x4AFE354")]
    public void RemoveGazePoint(AnimationCurve curve)
    {
    }

    [Token(Token = "0x6008E27")]
    [Address(RVA = "0x4AFDEEC", Offset = "0x4AFDEEC", VA = "0x4AFDEEC")]
    private Transform SetTarget(ref Transform input, Transform newTargetBefore) => (Transform) null;

    [Token(Token = "0x6008E28")]
    [Address(RVA = "0x4AFDD8C", Offset = "0x4AFDD8C", VA = "0x4AFDD8C")]
    public Transform GetDummyTransform() => (Transform) null;

    [Token(Token = "0x6008E29")]
    [Address(RVA = "0x4AFDB00", Offset = "0x4AFDB00", VA = "0x4AFDB00")]
    private Vector3 GetLookAtPosition(float transitionRatio) => new Vector3();

    [Token(Token = "0x6008E2A")]
    [Address(RVA = "0x4AFE308", Offset = "0x4AFE308", VA = "0x4AFE308")]
    private Transform GetFaceTransform(out Vector3 facePosition) => (Transform) null;

    [Token(Token = "0x6008E2B")]
    [Address(RVA = "0x4AFE148", Offset = "0x4AFE148", VA = "0x4AFE148")]
    private Transform GetFaceTransform(out Vector3 facePosition, out Vector3 faceDirection)
    {
      return (Transform) null;
    }

    [Token(Token = "0x6008E2C")]
    [Address(RVA = "0x4AFE420", Offset = "0x4AFE420", VA = "0x4AFE420")]
    private void Update()
    {
    }

    [Token(Token = "0x6008E2D")]
    [Address(RVA = "0x4AFE5D0", Offset = "0x4AFE5D0", VA = "0x4AFE5D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008E2E")]
    [Address(RVA = "0x4AFE658", Offset = "0x4AFE658", VA = "0x4AFE658", Slot = "4")]
    public bool TryGetLookAtWeight(
      out float weight,
      out float bodyWeight,
      out float headWeight,
      out float eyesWeight,
      out float clampWeight)
    {
      return new bool();
    }

    [Token(Token = "0x6008E2F")]
    [Address(RVA = "0x4AFE708", Offset = "0x4AFE708", VA = "0x4AFE708", Slot = "5")]
    public bool TryGetLookAtPosition(out Vector3 position) => new bool();

    [Token(Token = "0x6008E30")]
    [Address(RVA = "0x4AFE784", Offset = "0x4AFE784", VA = "0x4AFE784")]
    public FreeMapCharacterLookAt()
    {
    }
  }
}
