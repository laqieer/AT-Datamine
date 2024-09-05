// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.CameraController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnitDetail.Data.ScriptableObjects;
using UnityEngine;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004A8")]
  [Serializable]
  public class CameraController
  {
    [Token(Token = "0x4001896")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Camera camera;
    [Token(Token = "0x4001897")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform lookAtTarget;
    [Token(Token = "0x4001898")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform cameraControlTarget;
    [Token(Token = "0x4001899")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CameraController.ResetSetting resetSetting;
    [Token(Token = "0x400189A")]
    [FieldOffset(Offset = "0x30")]
    private float baseFrustumHeight;
    [Token(Token = "0x400189B")]
    [FieldOffset(Offset = "0x34")]
    private float baseDistance;
    [Token(Token = "0x400189C")]
    [FieldOffset(Offset = "0x38")]
    private Vector3 rotate;
    [Token(Token = "0x400189D")]
    [FieldOffset(Offset = "0x44")]
    private readonly Vector3 xz;
    [Token(Token = "0x400189E")]
    [FieldOffset(Offset = "0x50")]
    private Viewer3DSetting setting;

    [Token(Token = "0x1700032D")]
    public float Zoom
    {
      [Token(Token = "0x6001A24"), Address(RVA = "0x2C24CEC", Offset = "0x2C24CEC", VA = "0x2C24CEC")] get
      {
        return new float();
      }
      [Token(Token = "0x6001A25"), Address(RVA = "0x2C24CF4", Offset = "0x2C24CF4", VA = "0x2C24CF4")] private set
      {
      }
    }

    [Token(Token = "0x1700032E")]
    public Vector2 XYTranslate
    {
      [Token(Token = "0x6001A26"), Address(RVA = "0x2C24CFC", Offset = "0x2C24CFC", VA = "0x2C24CFC")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001A27"), Address(RVA = "0x2C24D04", Offset = "0x2C24D04", VA = "0x2C24D04")] private set
      {
      }
    }

    [Token(Token = "0x6001A28")]
    [Address(RVA = "0x2C24D0C", Offset = "0x2C24D0C", VA = "0x2C24D0C")]
    public void Initialize(Viewer3DSetting setting)
    {
    }

    [Token(Token = "0x6001A29")]
    [Address(RVA = "0x2C24E40", Offset = "0x2C24E40", VA = "0x2C24E40")]
    public IEnumerator Reset() => (IEnumerator) null;

    [Token(Token = "0x6001A2A")]
    [Address(RVA = "0x2C24ED0", Offset = "0x2C24ED0", VA = "0x2C24ED0")]
    public IEnumerator Reset(float duration) => (IEnumerator) null;

    [Token(Token = "0x6001A2B")]
    [Address(RVA = "0x2C24F70", Offset = "0x2C24F70", VA = "0x2C24F70")]
    public void Rotate(Vector2 direction)
    {
    }

    [Token(Token = "0x6001A2C")]
    [Address(RVA = "0x2C25040", Offset = "0x2C25040", VA = "0x2C25040")]
    public void AdjustZoom(float zoom)
    {
    }

    [Token(Token = "0x6001A2D")]
    [Address(RVA = "0x2C250C4", Offset = "0x2C250C4", VA = "0x2C250C4")]
    public void Translate(Vector2 direction)
    {
    }

    [Token(Token = "0x6001A2E")]
    [Address(RVA = "0x2C24DF4", Offset = "0x2C24DF4", VA = "0x2C24DF4")]
    private float GetFrustumHeight(float distance) => new float();

    [Token(Token = "0x6001A2F")]
    [Address(RVA = "0x2C251BC", Offset = "0x2C251BC", VA = "0x2C251BC")]
    public float GetFrustumRatio() => new float();

    [Token(Token = "0x6001A30")]
    [Address(RVA = "0x2C251E4", Offset = "0x2C251E4", VA = "0x2C251E4")]
    public CameraController()
    {
    }

    [Token(Token = "0x20004A9")]
    [Serializable]
    private class ResetSetting
    {
      [Token(Token = "0x40018A1")]
      [FieldOffset(Offset = "0x10")]
      public float duration;
      [Token(Token = "0x40018A2")]
      [FieldOffset(Offset = "0x18")]
      public AnimationCurve curve;

      [Token(Token = "0x6001A31")]
      [Address(RVA = "0x2C25290", Offset = "0x2C25290", VA = "0x2C25290")]
      public ResetSetting()
      {
      }
    }
  }
}
