// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.FreeOperationCamera.GUIInputProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.FreeOperationCamera
{
  [Token(Token = "0x2002F76")]
  [RequireComponent(typeof (Scenes.DebugViewer.FreeOperationCamera.FreeOperationCamera))]
  public class GUIInputProvider : MonoBehaviour, IInputEventProvider
  {
    [Token(Token = "0x400CB39")]
    public const int FirstWindowID = 10000;
    [Token(Token = "0x400CB3A")]
    public const int SecondWindowID = 10001;
    [Token(Token = "0x400CB3B")]
    [FieldOffset(Offset = "0x18")]
    private Rect transitionWindowRect;
    [Token(Token = "0x400CB3C")]
    [FieldOffset(Offset = "0x28")]
    private Rect rotateWindowRect;
    [Token(Token = "0x400CB41")]
    [FieldOffset(Offset = "0x58")]
    public bool isShow;

    [Token(Token = "0x140001B1")]
    public event EventHandler<float> AddFieldOfView
    {
      [Token(Token = "0x60128DE"), Address(RVA = "0x2128024", Offset = "0x2128024", VA = "0x2128024", Slot = "4")] add
      {
      }
      [Token(Token = "0x60128DF"), Address(RVA = "0x21280D4", Offset = "0x21280D4", VA = "0x21280D4", Slot = "5")] remove
      {
      }
    }

    [Token(Token = "0x140001B2")]
    public event EventHandler<Vector3> MoveDirection
    {
      [Token(Token = "0x60128E0"), Address(RVA = "0x2128184", Offset = "0x2128184", VA = "0x2128184", Slot = "6")] add
      {
      }
      [Token(Token = "0x60128E1"), Address(RVA = "0x2128234", Offset = "0x2128234", VA = "0x2128234", Slot = "7")] remove
      {
      }
    }

    [Token(Token = "0x140001B3")]
    public event EventHandler<Vector3> MoveRotation
    {
      [Token(Token = "0x60128E2"), Address(RVA = "0x21282E4", Offset = "0x21282E4", VA = "0x21282E4", Slot = "8")] add
      {
      }
      [Token(Token = "0x60128E3"), Address(RVA = "0x2128394", Offset = "0x2128394", VA = "0x2128394", Slot = "9")] remove
      {
      }
    }

    [Token(Token = "0x140001B4")]
    public event EventHandler ChangeSpeedMode
    {
      [Token(Token = "0x60128E4"), Address(RVA = "0x2128444", Offset = "0x2128444", VA = "0x2128444", Slot = "10")] add
      {
      }
      [Token(Token = "0x60128E5"), Address(RVA = "0x21284E0", Offset = "0x21284E0", VA = "0x21284E0", Slot = "11")] remove
      {
      }
    }

    [Token(Token = "0x60128E6")]
    [Address(RVA = "0x212857C", Offset = "0x212857C", VA = "0x212857C")]
    private void Start()
    {
    }

    [Token(Token = "0x60128E7")]
    [Address(RVA = "0x21286BC", Offset = "0x21286BC", VA = "0x21286BC")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x60128E8")]
    [Address(RVA = "0x2128AB0", Offset = "0x2128AB0", VA = "0x2128AB0")]
    private void DoTransitionWindow(int windowId)
    {
    }

    [Token(Token = "0x60128E9")]
    [Address(RVA = "0x2128F7C", Offset = "0x2128F7C", VA = "0x2128F7C")]
    private void DoRotationWindow(int windowId)
    {
    }

    [Token(Token = "0x60128EA")]
    [Address(RVA = "0x21289E0", Offset = "0x21289E0", VA = "0x21289E0")]
    private void DrawAdjustMode()
    {
    }

    [Token(Token = "0x60128EB")]
    [Address(RVA = "0x2129000", Offset = "0x2129000", VA = "0x2129000")]
    private float DrawFovButton() => new float();

    [Token(Token = "0x60128EC")]
    [Address(RVA = "0x2128C84", Offset = "0x2128C84", VA = "0x2128C84")]
    private Vector2 DrawArrowKey(Rect windowRect) => new Vector2();

    [Token(Token = "0x60128ED")]
    [Address(RVA = "0x2128B0C", Offset = "0x2128B0C", VA = "0x2128B0C")]
    private float DrawUpDown() => new float();

    [Token(Token = "0x60128EE")]
    [Address(RVA = "0x21286A8", Offset = "0x21286A8", VA = "0x21286A8")]
    private Vector2 WindowSize() => new Vector2();

    [Token(Token = "0x60128EF")]
    [Address(RVA = "0x2129178", Offset = "0x2129178", VA = "0x2129178")]
    public GUIInputProvider()
    {
    }
  }
}
