// Decompiled with JetBrains decompiler
// Type: staq.Camera.SwipeGroundPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D7F")]
  public class SwipeGroundPosition : Vector3Base
  {
    [Token(Token = "0x4010E0C")]
    [FieldOffset(Offset = "0x20")]
    private Matrix4x4 viewportMatrix;
    [Token(Token = "0x4010E0D")]
    [FieldOffset(Offset = "0x60")]
    private Vector3 startTouchVector;
    [Token(Token = "0x4010E0E")]
    [FieldOffset(Offset = "0x70")]
    private UnityEngine.Camera camera;
    [Token(Token = "0x4010E0F")]
    [FieldOffset(Offset = "0x78")]
    private float distanceGround;
    [Token(Token = "0x4010E10")]
    [FieldOffset(Offset = "0x7C")]
    private Vector2 screenPosition;
    [Token(Token = "0x4010E11")]
    [FieldOffset(Offset = "0x84")]
    private bool screenPositionDirty;
    [Token(Token = "0x4010E12")]
    [FieldOffset(Offset = "0x88")]
    private Vector3 startPosition;
    [Token(Token = "0x4010E13")]
    [FieldOffset(Offset = "0x94")]
    private Vector3 position;
    [Token(Token = "0x4010E14")]
    [FieldOffset(Offset = "0xA0")]
    private bool touchEnable;
    [Token(Token = "0x4010E15")]
    [FieldOffset(Offset = "0xA8")]
    private Action<Vector3> onMoveFinish;
    [Token(Token = "0x4010E16")]
    [FieldOffset(Offset = "0xB0")]
    private Vector3[] movePositions;
    [Token(Token = "0x4010E17")]
    [FieldOffset(Offset = "0xB8")]
    private float moveTime;
    [Token(Token = "0x4010E18")]
    [FieldOffset(Offset = "0xBC")]
    private bool moveEnabled;

    [Token(Token = "0x6018BD2")]
    [Address(RVA = "0x2648480", Offset = "0x2648480", VA = "0x2648480")]
    private Vector3 GetLookAtGroundVector(ref Vector2 inputScreenPosition) => new Vector3();

    [Token(Token = "0x6018BD3")]
    [Address(RVA = "0x2648674", Offset = "0x2648674", VA = "0x2648674")]
    public SwipeGroundPosition(UnityEngine.Camera inputCamera, Vector2 inputScreenPosition)
    {
    }

    [Token(Token = "0x6018BD4")]
    [Address(RVA = "0x2648900", Offset = "0x2648900", VA = "0x2648900", Slot = "7")]
    public override void GetValue(out Vector3 outputValue)
    {
    }

    [Token(Token = "0x6018BD5")]
    [Address(RVA = "0x2648990", Offset = "0x2648990", VA = "0x2648990", Slot = "8")]
    public override bool GetDirty() => new bool();

    [Token(Token = "0x6018BD6")]
    [Address(RVA = "0x26489B0", Offset = "0x26489B0", VA = "0x26489B0", Slot = "5")]
    public override void SetDirty(bool value)
    {
    }

    [Token(Token = "0x6018BD7")]
    [Address(RVA = "0x26489C0", Offset = "0x26489C0", VA = "0x26489C0", Slot = "4")]
    public override void TimeUpdate(float deltaTime)
    {
    }

    [Token(Token = "0x6018BD8")]
    [Address(RVA = "0x2648B1C", Offset = "0x2648B1C", VA = "0x2648B1C", Slot = "11")]
    public override bool GetWaitIdle() => new bool();

    [Token(Token = "0x6018BD9")]
    [Address(RVA = "0x2648B24", Offset = "0x2648B24", VA = "0x2648B24", Slot = "12")]
    public override void SetOnMoveFinish(Action<Vector3> inputOnMoveFinish)
    {
    }
  }
}
