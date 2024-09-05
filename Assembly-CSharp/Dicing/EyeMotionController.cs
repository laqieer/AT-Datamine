// Decompiled with JetBrains decompiler
// Type: Dicing.EyeMotionController
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
  [Token(Token = "0x2001F3C")]
  public class EyeMotionController : DicingMotionControllerBase<EyeMotion>
  {
    [Token(Token = "0x40085F6")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private EyeMotionController.EyeMotionGroup[] eyeMotionGroups;

    [Token(Token = "0x600B98B")]
    [Address(RVA = "0x213D10C", Offset = "0x213D10C", VA = "0x213D10C", Slot = "4")]
    public override void FixedClose(float transitionTime = -1f)
    {
    }

    [Token(Token = "0x600B98C")]
    [Address(RVA = "0x213D1BC", Offset = "0x213D1BC", VA = "0x213D1BC", Slot = "5")]
    public override void FixedOpen(float transitionTime = -1f)
    {
    }

    [Token(Token = "0x600B98D")]
    [Address(RVA = "0x213D26C", Offset = "0x213D26C", VA = "0x213D26C")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600B98E")]
    [Address(RVA = "0x213D28C", Offset = "0x213D28C", VA = "0x213D28C")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600B98F")]
    [Address(RVA = "0x213D298", Offset = "0x213D298", VA = "0x213D298", Slot = "6")]
    protected override IEnumerator WaitDuration(float transitionTime = -1f, bool debugflag = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600B990")]
    [Address(RVA = "0x213D338", Offset = "0x213D338", VA = "0x213D338")]
    public EyeMotionController()
    {
    }

    [Token(Token = "0x2001F3D")]
    [Serializable]
    public class EyeMotionGroup : DicingMotionControllerBase<EyeMotion>.IMotionGroup
    {
      [Token(Token = "0x40085F7")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private EyeMotion eyeMotion;
      [Token(Token = "0x40085F8")]
      [FieldOffset(Offset = "0x14")]
      [SerializeField]
      private float duration;

      [Token(Token = "0x1700268B")]
      public EyeMotion Motion
      {
        [Token(Token = "0x600B991"), Address(RVA = "0x213D528", Offset = "0x213D528", VA = "0x213D528", Slot = "4")] get
        {
          return new EyeMotion();
        }
      }

      [Token(Token = "0x1700268C")]
      public float Duration
      {
        [Token(Token = "0x600B992"), Address(RVA = "0x213D530", Offset = "0x213D530", VA = "0x213D530", Slot = "5")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x600B993")]
      [Address(RVA = "0x213D4E4", Offset = "0x213D4E4", VA = "0x213D4E4")]
      public EyeMotionGroup(EyeMotion eyeMotion, float duration)
      {
      }
    }
  }
}
