// Decompiled with JetBrains decompiler
// Type: EEClientLibraries.CameraInputScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace EEClientLibraries
{
  [Token(Token = "0x200036A")]
  public class CameraInputScene : CameraInputBase
  {
    [Token(Token = "0x4001420")]
    private const float wheelBottomUpValue = 2f;
    [Token(Token = "0x4001421")]
    [FieldOffset(Offset = "0x40")]
    private CameraInputScene.TouchParameter[] touchParameters;

    [Token(Token = "0x60013AB")]
    [Address(RVA = "0x286C8F0", Offset = "0x286C8F0", VA = "0x286C8F0", Slot = "4")]
    protected override void DoInitialize()
    {
    }

    [Token(Token = "0x60013AC")]
    [Address(RVA = "0x286C9CC", Offset = "0x286C9CC", VA = "0x286C9CC", Slot = "5")]
    protected override void DoClearInputParameter()
    {
    }

    [Token(Token = "0x60013AD")]
    [Address(RVA = "0x286CA14", Offset = "0x286CA14", VA = "0x286CA14", Slot = "6")]
    protected override void DoUpdateParameter()
    {
    }

    [Token(Token = "0x60013AE")]
    [Address(RVA = "0x286D3BC", Offset = "0x286D3BC", VA = "0x286D3BC", Slot = "7")]
    protected override int CountTouchPoint() => new int();

    [Token(Token = "0x60013AF")]
    [Address(RVA = "0x286D48C", Offset = "0x286D48C", VA = "0x286D48C")]
    private void ClearInput()
    {
    }

    [Token(Token = "0x60013B0")]
    [Address(RVA = "0x286D494", Offset = "0x286D494", VA = "0x286D494")]
    private TouchPhase GetTouchState(int index) => new TouchPhase();

    [Token(Token = "0x60013B1")]
    [Address(RVA = "0x286D594", Offset = "0x286D594", VA = "0x286D594", Slot = "8")]
    protected override Vector3 GetTouchPosition(int index) => new Vector3();

    [Token(Token = "0x60013B2")]
    [Address(RVA = "0x286D670", Offset = "0x286D670", VA = "0x286D670")]
    private int GetTouchId(int index) => new int();

    [Token(Token = "0x60013B3")]
    [Address(RVA = "0x286D75C", Offset = "0x286D75C", VA = "0x286D75C")]
    private float GetMouseWheel() => new float();

    [Token(Token = "0x60013B4")]
    [Address(RVA = "0x286D45C", Offset = "0x286D45C", VA = "0x286D45C")]
    private bool CheckOtherThanTouchDevice() => new bool();

    [Token(Token = "0x60013B5")]
    [Address(RVA = "0x286CA48", Offset = "0x286CA48", VA = "0x286CA48")]
    private void UpdateAlreadyInputParameter()
    {
    }

    [Token(Token = "0x60013B6")]
    [Address(RVA = "0x286CAFC", Offset = "0x286CAFC", VA = "0x286CAFC")]
    private int UpdateNewInputParameter() => new int();

    [Token(Token = "0x60013B7")]
    [Address(RVA = "0x286CDCC", Offset = "0x286CDCC", VA = "0x286CDCC")]
    private void UpdateCameraMoveParameter()
    {
    }

    [Token(Token = "0x60013B8")]
    [Address(RVA = "0x286D008", Offset = "0x286D008", VA = "0x286D008")]
    private void UpdateCameraRotateParameter()
    {
    }

    [Token(Token = "0x60013B9")]
    [Address(RVA = "0x286D1B0", Offset = "0x286D1B0", VA = "0x286D1B0")]
    private void UpdateCameraSwipeParameter()
    {
    }

    [Token(Token = "0x60013BA")]
    [Address(RVA = "0x286D864", Offset = "0x286D864", VA = "0x286D864")]
    private bool IsPinch() => new bool();

    [Token(Token = "0x60013BB")]
    [Address(RVA = "0x286D7A0", Offset = "0x286D7A0", VA = "0x286D7A0")]
    private int GetTouchContinueIndex(int touchId) => new int();

    [Token(Token = "0x60013BC")]
    [Address(RVA = "0x286C0E0", Offset = "0x286C0E0", VA = "0x286C0E0")]
    public CameraInputScene()
    {
    }

    [Token(Token = "0x200036B")]
    private enum MouseInputAssignedTapId
    {
      [Token(Token = "0x4001423")] MouseRight = 100000, // 0x000186A0
      [Token(Token = "0x4001424")] MouseLeft = 200000, // 0x00030D40
    }

    [Token(Token = "0x200036C")]
    private class TouchParameter
    {
      [Token(Token = "0x4001425")]
      [FieldOffset(Offset = "0x10")]
      public int TouchId;
      [Token(Token = "0x4001426")]
      [FieldOffset(Offset = "0x14")]
      public Vector3 FirstTouchPosition;
      [Token(Token = "0x4001427")]
      [FieldOffset(Offset = "0x20")]
      public Vector3 CurrentTouchPosition;
      [Token(Token = "0x4001428")]
      [FieldOffset(Offset = "0x2C")]
      public Vector3 BeforeTouchPosition;
      [Token(Token = "0x4001429")]
      [FieldOffset(Offset = "0x38")]
      public bool IsTrigger;

      [Token(Token = "0x60013BD")]
      [Address(RVA = "0x286D808", Offset = "0x286D808", VA = "0x286D808")]
      public void Copy(CameraInputScene.TouchParameter target)
      {
      }

      [Token(Token = "0x60013BE")]
      [Address(RVA = "0x286C9C4", Offset = "0x286C9C4", VA = "0x286C9C4")]
      public TouchParameter()
      {
      }
    }
  }
}
