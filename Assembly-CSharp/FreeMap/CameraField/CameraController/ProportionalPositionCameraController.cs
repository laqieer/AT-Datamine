// Decompiled with JetBrains decompiler
// Type: FreeMap.CameraField.CameraController.ProportionalPositionCameraController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.CameraField.CameraController
{
  [Token(Token = "0x200196B")]
  public class ProportionalPositionCameraController : FreeMapCameraControllerBase
  {
    [Token(Token = "0x4006D4C")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private ProportionalPositionCameraController.InterpolationAxisType interpolationAxis;
    [Token(Token = "0x4006D4D")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ProportionalPositionCameraController.InterpolationAngleOfView interpolationParam;

    [Token(Token = "0x1700175B")]
    public ProportionalPositionCameraController.InterpolationAxisType AxisType
    {
      [Token(Token = "0x60090FD"), Address(RVA = "0x4D072A0", Offset = "0x4D072A0", VA = "0x4D072A0")] get
      {
        return new ProportionalPositionCameraController.InterpolationAxisType();
      }
    }

    [Token(Token = "0x60090FE")]
    [Address(RVA = "0x4D072A8", Offset = "0x4D072A8", VA = "0x4D072A8", Slot = "4")]
    protected override void InternalInitialize()
    {
    }

    [Token(Token = "0x60090FF")]
    [Address(RVA = "0x4D07304", Offset = "0x4D07304", VA = "0x4D07304", Slot = "7")]
    protected override void SetCartPositionAndRotation(bool isClip)
    {
    }

    [Token(Token = "0x6009100")]
    [Address(RVA = "0x4D07374", Offset = "0x4D07374", VA = "0x4D07374")]
    private Vector3 CalcPosition(out float xRate, out float yRate, out float zRate, bool isClip)
    {
      return new Vector3();
    }

    [Token(Token = "0x6009101")]
    [Address(RVA = "0x4D079EC", Offset = "0x4D079EC", VA = "0x4D079EC")]
    private void ExecutionInterpolationFromAxisType(
      float xRate,
      float yRate,
      float zRate,
      Action<float> action)
    {
    }

    [Token(Token = "0x6009102")]
    [Address(RVA = "0x4D077BC", Offset = "0x4D077BC", VA = "0x4D077BC")]
    private void ExecutionInterpolation(float xRate, float yRate, float zRate)
    {
    }

    [Token(Token = "0x6009103")]
    [Address(RVA = "0x4D079D4", Offset = "0x4D079D4", VA = "0x4D079D4")]
    private float CalcDistanceRate(float numerator, float denominator) => new float();

    [Token(Token = "0x6009104")]
    [Address(RVA = "0x4D07A58", Offset = "0x4D07A58", VA = "0x4D07A58", Slot = "8")]
    public override CameraControlType GetControlType() => new CameraControlType();

    [Token(Token = "0x6009105")]
    [Address(RVA = "0x4D07A60", Offset = "0x4D07A60", VA = "0x4D07A60")]
    public ProportionalPositionCameraController()
    {
    }

    [Token(Token = "0x200196C")]
    public enum InterpolationAxisType
    {
      [Token(Token = "0x4006D4F")] None,
      [Token(Token = "0x4006D50")] XAxis,
      [Token(Token = "0x4006D51")] YAxis,
      [Token(Token = "0x4006D52")] ZAxis,
    }

    [Token(Token = "0x200196D")]
    [Serializable]
    public class InterpolationAngleOfView
    {
      [Token(Token = "0x4006D53")]
      [FieldOffset(Offset = "0x10")]
      private Vector3 baseLookAtOffset;
      [Token(Token = "0x4006D54")]
      [FieldOffset(Offset = "0x1C")]
      private float baseFieldOfView;
      [Token(Token = "0x4006D55")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private Vector3 minusLookAtOffset;
      [Token(Token = "0x4006D56")]
      [FieldOffset(Offset = "0x2C")]
      [SerializeField]
      private Vector3 plusLookAtOffset;
      [Token(Token = "0x4006D57")]
      [FieldOffset(Offset = "0x38")]
      [SerializeField]
      private Vector3 minusPositionOffset;
      [Token(Token = "0x4006D58")]
      [FieldOffset(Offset = "0x44")]
      [SerializeField]
      private Vector3 plusPositionOffset;
      [Token(Token = "0x4006D59")]
      [FieldOffset(Offset = "0x50")]
      [SerializeField]
      private float minusFieldOfView;
      [Token(Token = "0x4006D5A")]
      [FieldOffset(Offset = "0x54")]
      [SerializeField]
      private float plusFieldOfView;

      [Token(Token = "0x6009106")]
      [Address(RVA = "0x4D072F8", Offset = "0x4D072F8", VA = "0x4D072F8")]
      public void Initialize(Vector3 baseLookAtOffset, float baseFoV)
      {
      }

      [Token(Token = "0x6009107")]
      [Address(RVA = "0x4D07B7C", Offset = "0x4D07B7C", VA = "0x4D07B7C")]
      public Vector3 CalcLookAtOffset(float positionRate) => new Vector3();

      [Token(Token = "0x6009108")]
      [Address(RVA = "0x4D07BC8", Offset = "0x4D07BC8", VA = "0x4D07BC8")]
      public float CalcFieldOfView(float positionRate) => new float();

      [Token(Token = "0x6009109")]
      [Address(RVA = "0x4D07BF8", Offset = "0x4D07BF8", VA = "0x4D07BF8")]
      public Vector3 CalcPositionOffset(float positionRate) => new Vector3();

      [Token(Token = "0x600910A")]
      [Address(RVA = "0x4D07AC0", Offset = "0x4D07AC0", VA = "0x4D07AC0")]
      public InterpolationAngleOfView()
      {
      }
    }
  }
}
