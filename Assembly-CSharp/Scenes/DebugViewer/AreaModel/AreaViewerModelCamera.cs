// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerModelCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.DebugViewer.FreeOperationCamera;
using System.Collections;
using System.Text;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F8D")]
  public class AreaViewerModelCamera : IAreaViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x17003EDA")]
    private Scenes.DebugViewer.FreeOperationCamera.FreeOperationCamera FreeCamera
    {
      [Token(Token = "0x601298C"), Address(RVA = "0x4291378", Offset = "0x4291378", VA = "0x4291378")] set
      {
      }
      [Token(Token = "0x601298D"), Address(RVA = "0x4291380", Offset = "0x4291380", VA = "0x4291380")] get
      {
        return (Scenes.DebugViewer.FreeOperationCamera.FreeOperationCamera) null;
      }
    }

    [Token(Token = "0x17003EDB")]
    private GUIInputProvider GUIInput
    {
      [Token(Token = "0x601298E"), Address(RVA = "0x4291388", Offset = "0x4291388", VA = "0x4291388")] set
      {
      }
      [Token(Token = "0x601298F"), Address(RVA = "0x4291390", Offset = "0x4291390", VA = "0x4291390")] get
      {
        return (GUIInputProvider) null;
      }
    }

    [Token(Token = "0x17003EDC")]
    public BindingParam<bool> IsShowGUIInput
    {
      [Token(Token = "0x6012990"), Address(RVA = "0x4291398", Offset = "0x4291398", VA = "0x4291398")] private set
      {
      }
      [Token(Token = "0x6012991"), Address(RVA = "0x42913A0", Offset = "0x42913A0", VA = "0x42913A0")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x17003EDD")]
    public BindingParam<OperationParameter> CameraParameter
    {
      [Token(Token = "0x6012992"), Address(RVA = "0x42913A8", Offset = "0x42913A8", VA = "0x42913A8")] private set
      {
      }
      [Token(Token = "0x6012993"), Address(RVA = "0x42913B0", Offset = "0x42913B0", VA = "0x42913B0")] get
      {
        return (BindingParam<OperationParameter>) null;
      }
    }

    [Token(Token = "0x6012994")]
    [Address(RVA = "0x42913B8", Offset = "0x42913B8", VA = "0x42913B8")]
    public AreaViewerModelCamera()
    {
    }

    [Token(Token = "0x6012995")]
    [Address(RVA = "0x4291540", Offset = "0x4291540", VA = "0x4291540", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6012996")]
    [Address(RVA = "0x42915C8", Offset = "0x42915C8", VA = "0x42915C8", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x6012997")]
    [Address(RVA = "0x429166C", Offset = "0x429166C", VA = "0x429166C", Slot = "6")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012998")]
    [Address(RVA = "0x429167C", Offset = "0x429167C", VA = "0x429167C")]
    public void SetupCamera(Camera camera)
    {
    }

    [Token(Token = "0x6012999")]
    [Address(RVA = "0x4291674", Offset = "0x4291674", VA = "0x4291674")]
    public void Release()
    {
    }

    [Token(Token = "0x601299A")]
    [Address(RVA = "0x429173C", Offset = "0x429173C", VA = "0x429173C")]
    public StringBuilder GetFullInfo(StringBuilder sb) => (StringBuilder) null;

    [Token(Token = "0x601299B")]
    [Address(RVA = "0x4291A78", Offset = "0x4291A78", VA = "0x4291A78")]
    public string GetCameraInfo() => (string) null;

    [Token(Token = "0x601299C")]
    [Address(RVA = "0x4291CE0", Offset = "0x4291CE0", VA = "0x4291CE0")]
    public void HideGUIInput()
    {
    }
  }
}
