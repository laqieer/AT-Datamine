// Decompiled with JetBrains decompiler
// Type: AnimatorIK
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Model.IK;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000D8")]
[RequireComponent(typeof (Animator))]
public class AnimatorIK : global::IK, IIKGoalImplementor, IIKImplementor, ILookAtIKImplementor
{
  [Token(Token = "0x40003AD")]
  [FieldOffset(Offset = "0x40")]
  public bool ikActive;
  [Token(Token = "0x40003AE")]
  [FieldOffset(Offset = "0x41")]
  public bool useOffset;
  [Token(Token = "0x40003AF")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  public Transform leftFootObj;
  [Token(Token = "0x40003B0")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  public Transform rightFootObj;
  [Token(Token = "0x40003B1")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  public Transform leftHandObj;
  [Token(Token = "0x40003B2")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  public Transform rightHandObj;
  [Token(Token = "0x40003B3")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  public Transform lookAtObj;
  [Token(Token = "0x40003B4")]
  [FieldOffset(Offset = "0x70")]
  public float leftFootWeightPosition;
  [Token(Token = "0x40003B5")]
  [FieldOffset(Offset = "0x74")]
  public float leftFootWeightRotation;
  [Token(Token = "0x40003B6")]
  [FieldOffset(Offset = "0x78")]
  public float rightFootWeightPosition;
  [Token(Token = "0x40003B7")]
  [FieldOffset(Offset = "0x7C")]
  public float rightFootWeightRotation;
  [Token(Token = "0x40003B8")]
  [FieldOffset(Offset = "0x80")]
  public float leftHandWeightPosition;
  [Token(Token = "0x40003B9")]
  [FieldOffset(Offset = "0x84")]
  public float leftHandWeightRotation;
  [Token(Token = "0x40003BA")]
  [FieldOffset(Offset = "0x88")]
  public float rightHandWeightPosition;
  [Token(Token = "0x40003BB")]
  [FieldOffset(Offset = "0x8C")]
  public float rightHandWeightRotation;
  [Token(Token = "0x40003BC")]
  [FieldOffset(Offset = "0x90")]
  public float lookAtWeight;
  [Token(Token = "0x40003BD")]
  [FieldOffset(Offset = "0x94")]
  private Vector3 locWeaponGrabDir;

  [Token(Token = "0x600064E")]
  [Address(RVA = "0x4181374", Offset = "0x4181374", VA = "0x4181374")]
  protected void Awake()
  {
  }

  [Token(Token = "0x600064F")]
  [Address(RVA = "0x4181380", Offset = "0x4181380", VA = "0x4181380", Slot = "4")]
  protected override void Start()
  {
  }

  [Token(Token = "0x6000650")]
  [Address(RVA = "0x41817FC", Offset = "0x41817FC", VA = "0x41817FC")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x6000651")]
  [Address(RVA = "0x4181800", Offset = "0x4181800", VA = "0x4181800")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000652")]
  [Address(RVA = "0x4181808", Offset = "0x4181808", VA = "0x4181808")]
  public bool TryGetIKPosition(in AvatarIKGoal goal, out Vector3 goalPosition) => new bool();

  [Token(Token = "0x6000653")]
  [Address(RVA = "0x41819E0", Offset = "0x41819E0", VA = "0x41819E0")]
  public bool TryGetIKPositionWeight(in AvatarIKGoal goal, out float value) => new bool();

  [Token(Token = "0x6000654")]
  [Address(RVA = "0x4181A40", Offset = "0x4181A40", VA = "0x4181A40")]
  public bool TryGetIKRotation(in AvatarIKGoal goal, out Quaternion goalRotation) => new bool();

  [Token(Token = "0x6000655")]
  [Address(RVA = "0x4181B5C", Offset = "0x4181B5C", VA = "0x4181B5C")]
  public bool TryGetIKRotationWeight(in AvatarIKGoal goal, out float value) => new bool();

  [Token(Token = "0x6000656")]
  [Address(RVA = "0x4181990", Offset = "0x4181990", VA = "0x4181990")]
  private Transform GetGoalTransform(in AvatarIKGoal goal) => (Transform) null;

  [Token(Token = "0x6000657")]
  [Address(RVA = "0x4181BBC", Offset = "0x4181BBC", VA = "0x4181BBC", Slot = "10")]
  public bool TryGetLookAtWeight(
    out float weight,
    out float bodyWeight,
    out float headWeight,
    out float eyesWeight,
    out float clampWeight)
  {
    return new bool();
  }

  [Token(Token = "0x6000658")]
  [Address(RVA = "0x4181C14", Offset = "0x4181C14", VA = "0x4181C14", Slot = "11")]
  public bool TryGetLookAtPosition(out Vector3 position) => new bool();

  [Token(Token = "0x6000659")]
  [Address(RVA = "0x4181CE4", Offset = "0x4181CE4", VA = "0x4181CE4")]
  public AnimatorIK()
  {
  }

  [Token(Token = "0x600065A")]
  [Address(RVA = "0x4181D48", Offset = "0x4181D48", VA = "0x4181D48", Slot = "6")]
  private bool Model\u002EIK\u002EIIKGoalImplementor\u002ETryGetIKPosition(
    in AvatarIKGoal goal,
    out Vector3 goalPosition)
  {
    return new bool();
  }

  [Token(Token = "0x600065B")]
  [Address(RVA = "0x4181D4C", Offset = "0x4181D4C", VA = "0x4181D4C", Slot = "7")]
  private bool Model\u002EIK\u002EIIKGoalImplementor\u002ETryGetIKPositionWeight(
    in AvatarIKGoal goal,
    out float value)
  {
    return new bool();
  }

  [Token(Token = "0x600065C")]
  [Address(RVA = "0x4181D50", Offset = "0x4181D50", VA = "0x4181D50", Slot = "8")]
  private bool Model\u002EIK\u002EIIKGoalImplementor\u002ETryGetIKRotation(
    in AvatarIKGoal goal,
    out Quaternion goalRotation)
  {
    return new bool();
  }

  [Token(Token = "0x600065D")]
  [Address(RVA = "0x4181D54", Offset = "0x4181D54", VA = "0x4181D54", Slot = "9")]
  private bool Model\u002EIK\u002EIIKGoalImplementor\u002ETryGetIKRotationWeight(
    in AvatarIKGoal goal,
    out float value)
  {
    return new bool();
  }
}
