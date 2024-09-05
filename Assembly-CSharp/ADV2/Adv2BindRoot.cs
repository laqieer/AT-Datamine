// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2BindRoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E0A")]
  public class Adv2BindRoot : MonoBehaviour
  {
    [Token(Token = "0x4011029")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected Transform realParent;
    [Token(Token = "0x401102A")]
    [FieldOffset(Offset = "0x20")]
    public Vector3 OffsetPosition;
    [Token(Token = "0x401102B")]
    [FieldOffset(Offset = "0x2C")]
    public Vector3 OffsetEulerAngles;
    [Token(Token = "0x401102C")]
    [FieldOffset(Offset = "0x38")]
    public Vector3 OffsetScale;

    [Token(Token = "0x17005135")]
    public Transform RealParent
    {
      [Token(Token = "0x6018F66"), Address(RVA = "0x2CB5FE8", Offset = "0x2CB5FE8", VA = "0x2CB5FE8")] set
      {
      }
    }

    [Token(Token = "0x17005136")]
    public Animator RootAnimator
    {
      [Token(Token = "0x6018F67"), Address(RVA = "0x2CB5FF0", Offset = "0x2CB5FF0", VA = "0x2CB5FF0")] protected set
      {
      }
      [Token(Token = "0x6018F68"), Address(RVA = "0x2CB5FF8", Offset = "0x2CB5FF8", VA = "0x2CB5FF8")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x6018F69")]
    [Address(RVA = "0x2CB6000", Offset = "0x2CB6000", VA = "0x2CB6000")]
    public void SetParent(Transform parent)
    {
    }

    [Token(Token = "0x6018F6A")]
    [Address(RVA = "0x2CB60F0", Offset = "0x2CB60F0", VA = "0x2CB60F0")]
    public void LinkParent(Transform parent)
    {
    }

    [Token(Token = "0x6018F6B")]
    [Address(RVA = "0x2CB6150", Offset = "0x2CB6150", VA = "0x2CB6150")]
    public void CalcTransform()
    {
    }

    [Token(Token = "0x6018F6C")]
    [Address(RVA = "0x2CB624C", Offset = "0x2CB624C", VA = "0x2CB624C")]
    public void SetRootAnimator(Animator animator)
    {
    }

    [Token(Token = "0x6018F6D")]
    [Address(RVA = "0x2CB6254", Offset = "0x2CB6254", VA = "0x2CB6254")]
    public Adv2BindRoot()
    {
    }
  }
}
