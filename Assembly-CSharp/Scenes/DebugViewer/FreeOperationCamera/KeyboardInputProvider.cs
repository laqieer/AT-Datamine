// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.FreeOperationCamera.KeyboardInputProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.FreeOperationCamera
{
  [Token(Token = "0x2002F77")]
  public class KeyboardInputProvider : MonoBehaviour, IInputEventProvider
  {
    [Token(Token = "0x140001B5")]
    public event EventHandler<float> AddFieldOfView
    {
      [Token(Token = "0x60128F0"), Address(RVA = "0x2129180", Offset = "0x2129180", VA = "0x2129180", Slot = "4")] add
      {
      }
      [Token(Token = "0x60128F1"), Address(RVA = "0x2129230", Offset = "0x2129230", VA = "0x2129230", Slot = "5")] remove
      {
      }
    }

    [Token(Token = "0x140001B6")]
    public event EventHandler<Vector3> MoveDirection
    {
      [Token(Token = "0x60128F2"), Address(RVA = "0x21292E0", Offset = "0x21292E0", VA = "0x21292E0", Slot = "6")] add
      {
      }
      [Token(Token = "0x60128F3"), Address(RVA = "0x2129390", Offset = "0x2129390", VA = "0x2129390", Slot = "7")] remove
      {
      }
    }

    [Token(Token = "0x140001B7")]
    public event EventHandler<Vector3> MoveRotation
    {
      [Token(Token = "0x60128F4"), Address(RVA = "0x2129440", Offset = "0x2129440", VA = "0x2129440", Slot = "8")] add
      {
      }
      [Token(Token = "0x60128F5"), Address(RVA = "0x21294F0", Offset = "0x21294F0", VA = "0x21294F0", Slot = "9")] remove
      {
      }
    }

    [Token(Token = "0x140001B8")]
    public event EventHandler ChangeSpeedMode
    {
      [Token(Token = "0x60128F6"), Address(RVA = "0x21295A0", Offset = "0x21295A0", VA = "0x21295A0", Slot = "10")] add
      {
      }
      [Token(Token = "0x60128F7"), Address(RVA = "0x212963C", Offset = "0x212963C", VA = "0x212963C", Slot = "11")] remove
      {
      }
    }

    [Token(Token = "0x60128F8")]
    [Address(RVA = "0x21296D8", Offset = "0x21296D8", VA = "0x21296D8")]
    private void Start()
    {
    }

    [Token(Token = "0x60128F9")]
    [Address(RVA = "0x212978C", Offset = "0x212978C", VA = "0x212978C")]
    private void Update()
    {
    }

    [Token(Token = "0x60128FA")]
    [Address(RVA = "0x212989C", Offset = "0x212989C", VA = "0x212989C")]
    private Vector3 GetDirection() => new Vector3();

    [Token(Token = "0x60128FB")]
    [Address(RVA = "0x2129954", Offset = "0x2129954", VA = "0x2129954")]
    private Vector3 GetRotation() => new Vector3();

    [Token(Token = "0x60128FC")]
    [Address(RVA = "0x212984C", Offset = "0x212984C", VA = "0x212984C")]
    private float GetFieldOfView() => new float();

    [Token(Token = "0x60128FD")]
    [Address(RVA = "0x21299DC", Offset = "0x21299DC", VA = "0x21299DC")]
    private void UpdateAdjustMode()
    {
    }

    [Token(Token = "0x60128FE")]
    [Address(RVA = "0x2129A20", Offset = "0x2129A20", VA = "0x2129A20")]
    public KeyboardInputProvider()
    {
    }
  }
}
