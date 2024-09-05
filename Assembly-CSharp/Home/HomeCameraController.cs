// Decompiled with JetBrains decompiler
// Type: Home.HomeCameraController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B1D")]
  public class HomeCameraController
  {
    [Token(Token = "0x40032A2")]
    [FieldOffset(Offset = "0x10")]
    private readonly HomeManager homeManager;
    [Token(Token = "0x40032A3")]
    [FieldOffset(Offset = "0x18")]
    private readonly HomeSet homeSet;
    [Token(Token = "0x40032A4")]
    [FieldOffset(Offset = "0x20")]
    private readonly GameCore.Input.Input input;
    [Token(Token = "0x40032A5")]
    [FieldOffset(Offset = "0x28")]
    private float currentAngle;
    [Token(Token = "0x40032A6")]
    [FieldOffset(Offset = "0x30")]
    private List<RaycastResult> raycastResults;
    [Token(Token = "0x40032A7")]
    [FieldOffset(Offset = "0x38")]
    private bool invalidDrag;

    [Token(Token = "0x6003F3A")]
    [Address(RVA = "0x2C1AC80", Offset = "0x2C1AC80", VA = "0x2C1AC80")]
    public HomeCameraController(HomeManager homeManager)
    {
    }

    [Token(Token = "0x6003F3B")]
    [Address(RVA = "0x2C1AFD8", Offset = "0x2C1AFD8", VA = "0x2C1AFD8")]
    public void Update()
    {
    }

    [Token(Token = "0x6003F3C")]
    [Address(RVA = "0x2C1B000", Offset = "0x2C1B000", VA = "0x2C1B000")]
    private void OnDragStart(Vector2 lastEndPos, Vector2 deltaPos)
    {
    }

    [Token(Token = "0x6003F3D")]
    [Address(RVA = "0x2C1B2A8", Offset = "0x2C1B2A8", VA = "0x2C1B2A8")]
    private void OnDrag(Vector2 lastEndPos, Vector2 deltaPos)
    {
    }

    [Token(Token = "0x6003F3E")]
    [Address(RVA = "0x2C1B2E0", Offset = "0x2C1B2E0", VA = "0x2C1B2E0")]
    private void OnDragEnd(Vector2 lastEndPos, Vector2 deltaPos, GameObject hitObj)
    {
    }

    [Token(Token = "0x6003F3F")]
    [Address(RVA = "0x2C1B044", Offset = "0x2C1B044", VA = "0x2C1B044")]
    private bool IsUIIntersectsRaycast(Vector2 screenPos) => new bool();

    [Token(Token = "0x6003F40")]
    [Address(RVA = "0x2C1B1C4", Offset = "0x2C1B1C4", VA = "0x2C1B1C4")]
    private void Drag(float dragDeltaX)
    {
    }

    [Token(Token = "0x6003F41")]
    [Address(RVA = "0x2C1B428", Offset = "0x2C1B428", VA = "0x2C1B428")]
    public void UpdateCameraState()
    {
    }

    [Token(Token = "0x6003F42")]
    [Address(RVA = "0x2C1B318", Offset = "0x2C1B318", VA = "0x2C1B318")]
    private CinemachineVirtualCamera GetCameraBySelectingState() => (CinemachineVirtualCamera) null;

    [Token(Token = "0x6003F43")]
    [Address(RVA = "0x2C1AE7C", Offset = "0x2C1AE7C", VA = "0x2C1AE7C")]
    public void ResetCameras()
    {
    }
  }
}
