// Decompiled with JetBrains decompiler
// Type: staq.Camera.MapView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D7A")]
  public class MapView : Status
  {
    [Token(Token = "0x4010E00")]
    [FieldOffset(Offset = "0x38")]
    private Vector3Base lookAtPosition;
    [Token(Token = "0x4010E01")]
    [FieldOffset(Offset = "0x40")]
    private ScalerBase distance;
    [Token(Token = "0x4010E02")]
    [FieldOffset(Offset = "0x48")]
    private ScalerBase rotateX;
    [Token(Token = "0x4010E03")]
    [FieldOffset(Offset = "0x50")]
    private bool lookAtEulerDirty;
    [Token(Token = "0x4010E04")]
    [FieldOffset(Offset = "0x58")]
    private GeometryContainer geometryContainer;
    [Token(Token = "0x4010E05")]
    [FieldOffset(Offset = "0x60")]
    private ScalerBase fieldOfView;

    [Token(Token = "0x6018BAD")]
    [Address(RVA = "0x2647460", Offset = "0x2647460", VA = "0x2647460")]
    public MapView(GeometryContainer inputGeometryContainer)
    {
    }

    [Token(Token = "0x6018BAE")]
    [Address(RVA = "0x26476C4", Offset = "0x26476C4", VA = "0x26476C4")]
    public void Initialize(
      ScalerBase inputRotateX,
      ScalerBase inputDistance,
      ScalerBase inputFieldOfView)
    {
    }

    [Token(Token = "0x6018BAF")]
    [Address(RVA = "0x26476FC", Offset = "0x26476FC", VA = "0x26476FC", Slot = "4")]
    public override void GetRotate(out Quaternion outputRotate)
    {
    }

    [Token(Token = "0x6018BB0")]
    [Address(RVA = "0x26477A8", Offset = "0x26477A8", VA = "0x26477A8", Slot = "5")]
    public override void GetPosition(out Vector3 outputPosition)
    {
    }

    [Token(Token = "0x6018BB1")]
    [Address(RVA = "0x26478E8", Offset = "0x26478E8", VA = "0x26478E8", Slot = "6")]
    public override float GetFieldOfView() => new float();

    [Token(Token = "0x6018BB2")]
    [Address(RVA = "0x2647928", Offset = "0x2647928", VA = "0x2647928", Slot = "11")]
    public override bool GetDirty() => new bool();

    [Token(Token = "0x6018BB3")]
    [Address(RVA = "0x26479A8", Offset = "0x26479A8", VA = "0x26479A8", Slot = "12")]
    public override void SetDirty(bool value)
    {
    }

    [Token(Token = "0x6018BB4")]
    [Address(RVA = "0x2647A24", Offset = "0x2647A24", VA = "0x2647A24", Slot = "13")]
    public override void GetCamera(ref UnityEngine.Camera camera)
    {
    }

    [Token(Token = "0x6018BB5")]
    [Address(RVA = "0x2647AEC", Offset = "0x2647AEC", VA = "0x2647AEC", Slot = "8")]
    public override void SetFocusPosition(Vector3Base inputPosition, bool inputMove)
    {
    }

    [Token(Token = "0x6018BB6")]
    [Address(RVA = "0x2647C1C", Offset = "0x2647C1C", VA = "0x2647C1C", Slot = "9")]
    public override void StartSwipe(Vector3Base position)
    {
    }

    [Token(Token = "0x6018BB7")]
    [Address(RVA = "0x2647C20", Offset = "0x2647C20", VA = "0x2647C20", Slot = "10")]
    public override bool GetWaitIdle() => new bool();

    [Token(Token = "0x6018BB8")]
    [Address(RVA = "0x2647594", Offset = "0x2647594", VA = "0x2647594")]
    public void SetLookAtPosition(Vector3Base inputLookAtPosition)
    {
    }

    [Token(Token = "0x6018BB9")]
    [Address(RVA = "0x264762C", Offset = "0x264762C", VA = "0x264762C")]
    public void SetDistance(ScalerBase inputDistance)
    {
    }

    [Token(Token = "0x6018BBA")]
    [Address(RVA = "0x26475E0", Offset = "0x26475E0", VA = "0x26475E0")]
    public void SetRotateX(ScalerBase inputRotateX)
    {
    }

    [Token(Token = "0x6018BBB")]
    [Address(RVA = "0x2647678", Offset = "0x2647678", VA = "0x2647678")]
    public void SetFieldOfView(ScalerBase inputFieldOfView)
    {
    }

    [Token(Token = "0x6018BBC")]
    [Address(RVA = "0x2647C40", Offset = "0x2647C40", VA = "0x2647C40")]
    public void Change(
      ScalerBase inputRotateX,
      ScalerBase inputDistance,
      ScalerBase inputFieldOfView)
    {
    }
  }
}
