// Decompiled with JetBrains decompiler
// Type: Battle.ViewCamera.InputControllCamera2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace Battle.ViewCamera
{
  [Token(Token = "0x2002617")]
  public sealed class InputControllCamera2D : IStepUpdate
  {
    [Token(Token = "0x400A370")]
    private const float ZoomFactor = 0.1f;
    [Token(Token = "0x400A371")]
    [FieldOffset(Offset = "0x0")]
    private static float MoveDeadZoneTouchDistance;
    [Token(Token = "0x400A372")]
    [FieldOffset(Offset = "0x10")]
    private int IgnoreLayerMask;
    [Token(Token = "0x400A373")]
    [FieldOffset(Offset = "0x14")]
    private bool enabled;
    [Token(Token = "0x400A374")]
    [FieldOffset(Offset = "0x18")]
    private IMapViewCamera targetCamera;
    [Token(Token = "0x400A376")]
    [FieldOffset(Offset = "0x24")]
    private InputControllCamera2D.Phase phase;
    [Token(Token = "0x400A377")]
    [FieldOffset(Offset = "0x28")]
    private Vector2 moveStartTouchPosition;
    [Token(Token = "0x400A378")]
    [FieldOffset(Offset = "0x30")]
    private Vector3 moveStartCameraPosition;
    [Token(Token = "0x400A379")]
    [FieldOffset(Offset = "0x3C")]
    private Vector2 currentTouchPosition;
    [Token(Token = "0x400A37A")]
    [FieldOffset(Offset = "0x44")]
    private float zoomStartPinchLength;
    [Token(Token = "0x400A37B")]
    [FieldOffset(Offset = "0x48")]
    private float zoomStartCameraDistane;
    [Token(Token = "0x400A37C")]
    [FieldOffset(Offset = "0x4C")]
    private bool overDZ;
    [Token(Token = "0x400A37D")]
    [FieldOffset(Offset = "0x50")]
    private EventSystem currentEventSystem;
    [Token(Token = "0x400A37E")]
    [FieldOffset(Offset = "0x58")]
    private PointerEventData currentPointerEventData;
    [Token(Token = "0x400A37F")]
    [FieldOffset(Offset = "0x60")]
    private List<RaycastResult> raycastResults;

    [Token(Token = "0x1700322E")]
    public bool Enabled
    {
      [Token(Token = "0x600EB3E"), Address(RVA = "0x4B99804", Offset = "0x4B99804", VA = "0x4B99804")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EB3F"), Address(RVA = "0x4B99824", Offset = "0x4B99824", VA = "0x4B99824")] set
      {
      }
    }

    [Token(Token = "0x1700322F")]
    public IMapViewCamera TargetCamera
    {
      [Token(Token = "0x600EB40"), Address(RVA = "0x4B99830", Offset = "0x4B99830", VA = "0x4B99830")] set
      {
      }
    }

    [Token(Token = "0x17003230")]
    public float InitialDistance
    {
      [Token(Token = "0x600EB41"), Address(RVA = "0x4B998F8", Offset = "0x4B998F8", VA = "0x4B998F8")] get
      {
        return new float();
      }
      [Token(Token = "0x600EB42"), Address(RVA = "0x4B99900", Offset = "0x4B99900", VA = "0x4B99900")] set
      {
      }
    }

    [Token(Token = "0x600EB43")]
    [Address(RVA = "0x4B99908", Offset = "0x4B99908", VA = "0x4B99908")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600EB44")]
    [Address(RVA = "0x4B999F4", Offset = "0x4B999F4", VA = "0x4B999F4", Slot = "4")]
    public void Step(float deltaSeconds)
    {
    }

    [Token(Token = "0x600EB45")]
    [Address(RVA = "0x4B9A1FC", Offset = "0x4B9A1FC", VA = "0x4B9A1FC")]
    public Vector3 WorldDeltaFromScreenDelta(ref Vector2 a, ref Vector2 b) => new Vector3();

    [Token(Token = "0x600EB46")]
    [Address(RVA = "0x4B99F98", Offset = "0x4B99F98", VA = "0x4B99F98")]
    private bool CheckIgnore() => new bool();

    [Token(Token = "0x600EB47")]
    [Address(RVA = "0x4B9A360", Offset = "0x4B9A360", VA = "0x4B9A360")]
    private bool CheckIgnoreMoveDistanceByPointerDevice() => new bool();

    [Token(Token = "0x600EB48")]
    [Address(RVA = "0x4B9A564", Offset = "0x4B9A564", VA = "0x4B9A564")]
    public InputControllCamera2D()
    {
    }

    [Token(Token = "0x2002618")]
    private enum Phase
    {
      [Token(Token = "0x400A381")] None,
      [Token(Token = "0x400A382")] Move,
      [Token(Token = "0x400A383")] Zoom,
      [Token(Token = "0x400A384")] Ignore,
    }
  }
}
