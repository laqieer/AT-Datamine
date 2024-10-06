// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.FreeOperationCamera.FreeOperationCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.FreeOperationCamera
{
  [Token(Token = "0x2002F75")]
  [RequireComponent(typeof (Camera))]
  public class FreeOperationCamera : MonoBehaviour
  {
    [Token(Token = "0x400CB36")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Camera targetCamera;
    [Token(Token = "0x400CB37")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public SpeedModeType speedType;
    [Token(Token = "0x400CB38")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public OperationParameter Parameter;

    [Token(Token = "0x17003EB9")]
    public Camera TargetCamera
    {
      [Token(Token = "0x60128D3"), Address(RVA = "0x2127440", Offset = "0x2127440", VA = "0x2127440")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x17003EBA")]
    private OperationParameter AdjustedParameter
    {
      [Token(Token = "0x60128D4"), Address(RVA = "0x2127448", Offset = "0x2127448", VA = "0x2127448")] get
      {
        return new OperationParameter();
      }
    }

    [Token(Token = "0x60128D5")]
    [Address(RVA = "0x21274C4", Offset = "0x21274C4", VA = "0x21274C4")]
    private void Start()
    {
    }

    [Token(Token = "0x60128D6")]
    [Address(RVA = "0x2127550", Offset = "0x2127550", VA = "0x2127550")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x60128D7")]
    [Address(RVA = "0x21278F0", Offset = "0x21278F0", VA = "0x21278F0")]
    public void RegisterInput(IInputEventProvider provider)
    {
    }

    [Token(Token = "0x60128D8")]
    [Address(RVA = "0x2127698", Offset = "0x2127698", VA = "0x2127698")]
    public string GetCameraInfo() => (string) null;

    [Token(Token = "0x60128D9")]
    [Address(RVA = "0x2127BC8", Offset = "0x2127BC8", VA = "0x2127BC8")]
    protected void MoveDirection(object sender, Vector3 direction)
    {
    }

    [Token(Token = "0x60128DA")]
    [Address(RVA = "0x2127DAC", Offset = "0x2127DAC", VA = "0x2127DAC")]
    protected void MoveRotation(object sender, Vector3 rotation)
    {
    }

    [Token(Token = "0x60128DB")]
    [Address(RVA = "0x2127EF8", Offset = "0x2127EF8", VA = "0x2127EF8")]
    protected void AddFieldOfView(object sender, float fov)
    {
    }

    [Token(Token = "0x60128DC")]
    [Address(RVA = "0x2127F84", Offset = "0x2127F84", VA = "0x2127F84")]
    protected void ChangeSpeedMode(object sender, EventArgs e)
    {
    }

    [Token(Token = "0x60128DD")]
    [Address(RVA = "0x2127FB4", Offset = "0x2127FB4", VA = "0x2127FB4")]
    public FreeOperationCamera()
    {
    }
  }
}
