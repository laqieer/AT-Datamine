// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerViewCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.DebugViewer.FreeOperationCamera;
using System;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F96")]
  internal class AreaViewerViewCamera : AreaViewerViewBase
  {
    [Token(Token = "0x400CB9B")]
    [FieldOffset(Offset = "0x28")]
    private OperationParameter cameraParameter;
    [Token(Token = "0x400CB9C")]
    [FieldOffset(Offset = "0x38")]
    public EventHandler<OperationParameter> OnChangeParameter;
    [Token(Token = "0x400CB9D")]
    [FieldOffset(Offset = "0x40")]
    public Func<string> GetCameraInfo;

    [Token(Token = "0x60129B5")]
    [Address(RVA = "0x429263C", Offset = "0x429263C", VA = "0x429263C", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x60129B6")]
    [Address(RVA = "0x42927F8", Offset = "0x42927F8", VA = "0x42927F8")]
    public void SetCameraParameter(OperationParameter param)
    {
    }

    [Token(Token = "0x60129B7")]
    [Address(RVA = "0x4292804", Offset = "0x4292804", VA = "0x4292804")]
    public AreaViewerViewCamera()
    {
    }
  }
}
