// Decompiled with JetBrains decompiler
// Type: IK
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Model.IK;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000D7")]
[RequireComponent(typeof (Animator))]
public class IK : MonoBehaviour
{
  [Token(Token = "0x40003A6")]
  [FieldOffset(Offset = "0x18")]
  protected Animator avatar;
  [Token(Token = "0x40003A7")]
  [FieldOffset(Offset = "0x0")]
  private static readonly AvatarIKGoal[] AllIKGoal;
  [Token(Token = "0x40003A8")]
  [FieldOffset(Offset = "0x8")]
  private static readonly AvatarIKHint[] AllIKHint;
  [Token(Token = "0x40003A9")]
  [FieldOffset(Offset = "0x20")]
  protected IKImplManager<IIKGoalImplementor> goalImpl;
  [Token(Token = "0x40003AA")]
  [FieldOffset(Offset = "0x28")]
  protected IKImplManager<IIKHintImplementor> hintImpl;
  [Token(Token = "0x40003AB")]
  [FieldOffset(Offset = "0x30")]
  protected IKImplManager<ILookAtIKImplementor> lookAtImpl;
  [Token(Token = "0x40003AC")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  public Transform bodyObj;

  [Token(Token = "0x600063E")]
  [Address(RVA = "0x4180418", Offset = "0x4180418", VA = "0x4180418", Slot = "4")]
  protected virtual void Start()
  {
  }

  [Token(Token = "0x600063F")]
  [Address(RVA = "0x418055C", Offset = "0x418055C", VA = "0x418055C", Slot = "5")]
  protected virtual void OnAnimatorIK(int layerIndex)
  {
  }

  [Token(Token = "0x6000640")]
  [Address(RVA = "0x4180470", Offset = "0x4180470", VA = "0x4180470")]
  public void SetBodyObject(Transform body)
  {
  }

  [Token(Token = "0x6000641")]
  [Address(RVA = "0x4180680", Offset = "0x4180680", VA = "0x4180680")]
  protected void OnAnimatorGoalIK(IIKGoalImplementor impl)
  {
  }

  [Token(Token = "0x6000642")]
  [Address(RVA = "0x41809A0", Offset = "0x41809A0", VA = "0x41809A0")]
  protected void OnAnimatorHintIK(IIKHintImplementor impl)
  {
  }

  [Token(Token = "0x6000643")]
  [Address(RVA = "0x4180BB4", Offset = "0x4180BB4", VA = "0x4180BB4")]
  protected void OnAnimatorLookAtIK(ILookAtIKImplementor impl)
  {
  }

  [Token(Token = "0x6000644")]
  [Address(RVA = "0x4180D60", Offset = "0x4180D60", VA = "0x4180D60")]
  public void SetImplementor(IIKImplementor impl, bool isLock = false)
  {
  }

  [Token(Token = "0x6000645")]
  [Address(RVA = "0x4180E34", Offset = "0x4180E34", VA = "0x4180E34")]
  public void SetImplementorGoal(IIKGoalImplementor impl, bool isLock = false)
  {
  }

  [Token(Token = "0x6000646")]
  [Address(RVA = "0x4180EB0", Offset = "0x4180EB0", VA = "0x4180EB0")]
  public void SetImplementorHint(IIKHintImplementor impl, bool isLock = false)
  {
  }

  [Token(Token = "0x6000647")]
  [Address(RVA = "0x4180F2C", Offset = "0x4180F2C", VA = "0x4180F2C")]
  public void SetImplementorLookAt(ILookAtIKImplementor impl, bool isLock = false)
  {
  }

  [Token(Token = "0x6000648")]
  [Address(RVA = "0x4180FA8", Offset = "0x4180FA8", VA = "0x4180FA8")]
  public void RemoveImplementor(IIKImplementor impl)
  {
  }

  [Token(Token = "0x6000649")]
  [Address(RVA = "0x4181068", Offset = "0x4181068", VA = "0x4181068")]
  public void RemoveImplementorGoal(IIKGoalImplementor impl)
  {
  }

  [Token(Token = "0x600064A")]
  [Address(RVA = "0x41810D0", Offset = "0x41810D0", VA = "0x41810D0")]
  public void RemoveImplementorHint(IIKHintImplementor impl)
  {
  }

  [Token(Token = "0x600064B")]
  [Address(RVA = "0x4181138", Offset = "0x4181138", VA = "0x4181138")]
  public void RemoveImplementorLookAt(ILookAtIKImplementor impl)
  {
  }

  [Token(Token = "0x600064C")]
  [Address(RVA = "0x41811A0", Offset = "0x41811A0", VA = "0x41811A0")]
  public IK()
  {
  }

  [Token(Token = "0x600064D")]
  [Address(RVA = "0x41812A4", Offset = "0x41812A4", VA = "0x41812A4")]
  static IK()
  {
  }
}
