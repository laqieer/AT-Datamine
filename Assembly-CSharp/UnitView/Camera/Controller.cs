// Decompiled with JetBrains decompiler
// Type: UnitView.Camera.Controller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnitView.ModelView;
using UnitView.State;
using UnityEngine;

#nullable disable
namespace UnitView.Camera
{
  [Token(Token = "0x2000410")]
  [Serializable]
  public class Controller
  {
    [Token(Token = "0x4001714")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform freeCameraControlTarget;
    [Token(Token = "0x4001715")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Animator animator;
    [Token(Token = "0x4001716")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Controller.ResetSetting resetSetting;
    [Token(Token = "0x4001717")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 rotate;
    [Token(Token = "0x4001718")]
    [FieldOffset(Offset = "0x34")]
    private readonly Vector3 xz;

    [Token(Token = "0x17000295")]
    public Viewer3DSetting Setting
    {
      [Token(Token = "0x6001716"), Address(RVA = "0x248A580", Offset = "0x248A580", VA = "0x248A580")] private get
      {
        return (Viewer3DSetting) null;
      }
      [Token(Token = "0x6001717"), Address(RVA = "0x248A588", Offset = "0x248A588", VA = "0x248A588")] set
      {
      }
    }

    [Token(Token = "0x17000296")]
    public float Zoom
    {
      [Token(Token = "0x6001718"), Address(RVA = "0x248A590", Offset = "0x248A590", VA = "0x248A590")] get
      {
        return new float();
      }
      [Token(Token = "0x6001719"), Address(RVA = "0x248A598", Offset = "0x248A598", VA = "0x248A598")] private set
      {
      }
    }

    [Token(Token = "0x17000297")]
    public Vector2 XYTranslate
    {
      [Token(Token = "0x600171A"), Address(RVA = "0x248A5A0", Offset = "0x248A5A0", VA = "0x248A5A0")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x600171B"), Address(RVA = "0x248A5A8", Offset = "0x248A5A8", VA = "0x248A5A8")] private set
      {
      }
    }

    [Token(Token = "0x600171C")]
    [Address(RVA = "0x248A5B0", Offset = "0x248A5B0", VA = "0x248A5B0")]
    public void Play(AnimationProperty current, AnimationProperty destination)
    {
    }

    [Token(Token = "0x600171D")]
    [Address(RVA = "0x248A634", Offset = "0x248A634", VA = "0x248A634")]
    public IEnumerator Reset() => (IEnumerator) null;

    [Token(Token = "0x600171E")]
    [Address(RVA = "0x248A6C4", Offset = "0x248A6C4", VA = "0x248A6C4")]
    public IEnumerator Reset(float duration) => (IEnumerator) null;

    [Token(Token = "0x600171F")]
    [Address(RVA = "0x248A764", Offset = "0x248A764", VA = "0x248A764")]
    public void Rotate(Vector2 direction)
    {
    }

    [Token(Token = "0x6001720")]
    [Address(RVA = "0x248A818", Offset = "0x248A818", VA = "0x248A818")]
    public void Pinch(float value)
    {
    }

    [Token(Token = "0x6001721")]
    [Address(RVA = "0x248A990", Offset = "0x248A990", VA = "0x248A990")]
    public void AdjustZoom(float zoom)
    {
    }

    [Token(Token = "0x6001722")]
    [Address(RVA = "0x248AA38", Offset = "0x248AA38", VA = "0x248AA38")]
    public void Translate(Vector2 direction)
    {
    }

    [Token(Token = "0x6001723")]
    [Address(RVA = "0x248AB30", Offset = "0x248AB30", VA = "0x248AB30")]
    public Controller()
    {
    }

    [Token(Token = "0x2000411")]
    [Serializable]
    private class ResetSetting
    {
      [Token(Token = "0x400171C")]
      [FieldOffset(Offset = "0x10")]
      public float Duration;
      [Token(Token = "0x400171D")]
      [FieldOffset(Offset = "0x18")]
      public AnimationCurve Curve;

      [Token(Token = "0x6001724")]
      [Address(RVA = "0x248ABA8", Offset = "0x248ABA8", VA = "0x248ABA8")]
      public ResetSetting()
      {
      }
    }
  }
}
