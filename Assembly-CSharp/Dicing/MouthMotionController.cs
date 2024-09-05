// Decompiled with JetBrains decompiler
// Type: Dicing.MouthMotionController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Dicing
{
  [Token(Token = "0x2001F41")]
  public class MouthMotionController : DicingMotionControllerBase<MouthMotion>
  {
    [Token(Token = "0x4008608")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private MouthMotionController.MouthMotionGroup[] mouthMotionGroups;
    [Token(Token = "0x4008609")]
    [FieldOffset(Offset = "0x58")]
    [Header("一回の口パクで中口が入る最小回数")]
    [SerializeField]
    private int minMiddleMouthCount;
    [Token(Token = "0x400860A")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    [Header("一回の口パクで中口が入る最大回数")]
    private int maxMiddleMouthCount;
    [Token(Token = "0x400860B")]
    [FieldOffset(Offset = "0x60")]
    private float animTotalTime;

    [Token(Token = "0x600B99E")]
    [Address(RVA = "0x213DB0C", Offset = "0x213DB0C", VA = "0x213DB0C", Slot = "4")]
    public override void FixedClose(float transitionTime = -1f)
    {
    }

    [Token(Token = "0x600B99F")]
    [Address(RVA = "0x213DBBC", Offset = "0x213DBBC", VA = "0x213DBBC", Slot = "5")]
    public override void FixedOpen(float transitionTime = -1f)
    {
    }

    [Token(Token = "0x600B9A0")]
    [Address(RVA = "0x213DC6C", Offset = "0x213DC6C", VA = "0x213DC6C")]
    public float GetMouthAnimTotalTime() => new float();

    [Token(Token = "0x600B9A1")]
    [Address(RVA = "0x213DC74", Offset = "0x213DC74", VA = "0x213DC74", Slot = "6")]
    protected override IEnumerator WaitDuration(float transitionTime = -1f, bool debugflag = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600B9A2")]
    [Address(RVA = "0x213DD28", Offset = "0x213DD28", VA = "0x213DD28")]
    public MouthMotionController()
    {
    }

    [Token(Token = "0x2001F42")]
    [Serializable]
    public class MouthMotionGroup : DicingMotionControllerBase<MouthMotion>.IMotionGroup
    {
      [Token(Token = "0x400860C")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private MouthMotion mouthMotion;
      [Token(Token = "0x400860D")]
      [FieldOffset(Offset = "0x14")]
      [SerializeField]
      private float duration;

      [Token(Token = "0x1700268F")]
      public MouthMotion Motion
      {
        [Token(Token = "0x600B9A3"), Address(RVA = "0x213DF24", Offset = "0x213DF24", VA = "0x213DF24", Slot = "4")] get
        {
          return new MouthMotion();
        }
      }

      [Token(Token = "0x17002690")]
      public float Duration
      {
        [Token(Token = "0x600B9A4"), Address(RVA = "0x213DF2C", Offset = "0x213DF2C", VA = "0x213DF2C", Slot = "5")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x600B9A5")]
      [Address(RVA = "0x213DEE0", Offset = "0x213DEE0", VA = "0x213DEE0")]
      public MouthMotionGroup(MouthMotion mouthMotion, float duration)
      {
      }
    }
  }
}
