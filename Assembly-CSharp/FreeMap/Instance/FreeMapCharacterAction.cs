// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapCharacterAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Animation;
using FreeMap.Instance.Action;
using FreeMap.Loader;
using GameCore.Animation;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018B3")]
  public class FreeMapCharacterAction
  {
    [Token(Token = "0x4006B1D")]
    [FieldOffset(Offset = "0x18")]
    private readonly IFreeMapCharacterActionController[] Actions;

    [Token(Token = "0x17001678")]
    private FreeMapCharacter Parent
    {
      [Token(Token = "0x6008C2F"), Address(RVA = "0x452B7DC", Offset = "0x452B7DC", VA = "0x452B7DC")] get
      {
        return (FreeMapCharacter) null;
      }
    }

    [Token(Token = "0x17001679")]
    public Animator TargetAnimator
    {
      [Token(Token = "0x6008C30"), Address(RVA = "0x452B7E4", Offset = "0x452B7E4", VA = "0x452B7E4")] private set
      {
      }
      [Token(Token = "0x6008C31"), Address(RVA = "0x452B7EC", Offset = "0x452B7EC", VA = "0x452B7EC")] get
      {
        return (Animator) null;
      }
    }

    [Token(Token = "0x1700167A")]
    public FreeMapCharacterAnimatorMotion AnimatorController
    {
      [Token(Token = "0x6008C32"), Address(RVA = "0x452B7F4", Offset = "0x452B7F4", VA = "0x452B7F4")] get
      {
        return (FreeMapCharacterAnimatorMotion) null;
      }
    }

    [Token(Token = "0x1700167B")]
    public FreeMapCharacterClipMotion Clip
    {
      [Token(Token = "0x6008C33"), Address(RVA = "0x452B7FC", Offset = "0x452B7FC", VA = "0x452B7FC")] get
      {
        return (FreeMapCharacterClipMotion) null;
      }
    }

    [Token(Token = "0x1700167C")]
    public OverrideIKGoal IKAction
    {
      [Token(Token = "0x6008C34"), Address(RVA = "0x452B804", Offset = "0x452B804", VA = "0x452B804")] get
      {
        return (OverrideIKGoal) null;
      }
    }

    [Token(Token = "0x6008C35")]
    [Address(RVA = "0x452B80C", Offset = "0x452B80C", VA = "0x452B80C")]
    public FreeMapCharacterAction(FreeMapCharacter parent)
    {
    }

    [Token(Token = "0x6008C36")]
    [Address(RVA = "0x452BC4C", Offset = "0x452BC4C", VA = "0x452BC4C")]
    public void PlayMainAction(CharacterMainAction action)
    {
    }

    [Token(Token = "0x6008C37")]
    [Address(RVA = "0x452BD6C", Offset = "0x452BD6C", VA = "0x452BD6C")]
    public IEnumerator PlayOneceMainAction(CharacterMainAction action) => (IEnumerator) null;

    [Token(Token = "0x6008C38")]
    [Address(RVA = "0x452BE0C", Offset = "0x452BE0C", VA = "0x452BE0C")]
    public CharacterMainAction GetCurrentAction() => new CharacterMainAction();

    [Token(Token = "0x6008C39")]
    [Address(RVA = "0x452BE28", Offset = "0x452BE28", VA = "0x452BE28")]
    public void PlayClip(FreeMapClipActionBase clip)
    {
    }

    [Token(Token = "0x6008C3A")]
    [Address(RVA = "0x452BE98", Offset = "0x452BE98", VA = "0x452BE98")]
    public void Initialize(FreeMapSideInFreeAnimator controller)
    {
    }

    [Token(Token = "0x6008C3B")]
    [Address(RVA = "0x452BF00", Offset = "0x452BF00", VA = "0x452BF00")]
    public void SetTargetAnimator(Animator target)
    {
    }

    [Token(Token = "0x6008C3C")]
    [Address(RVA = "0x452BF24", Offset = "0x452BF24", VA = "0x452BF24")]
    public void SetClipPackage(ResourceCacheHandle clipHandle)
    {
    }

    [Token(Token = "0x6008C3D")]
    [Address(RVA = "0x452BFC4", Offset = "0x452BFC4", VA = "0x452BFC4")]
    public void InitUpdate()
    {
    }

    [Token(Token = "0x6008C3E")]
    [Address(RVA = "0x452C0AC", Offset = "0x452C0AC", VA = "0x452C0AC")]
    public void Update()
    {
    }

    [Token(Token = "0x6008C3F")]
    [Address(RVA = "0x452C1A8", Offset = "0x452C1A8", VA = "0x452C1A8")]
    public void Release()
    {
    }
  }
}
