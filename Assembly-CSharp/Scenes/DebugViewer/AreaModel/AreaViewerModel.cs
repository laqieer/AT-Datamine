// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F83")]
  public class AreaViewerModel : IAreaViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CB59")]
    [FieldOffset(Offset = "0x20")]
    private List<IAreaViewerModel> models;

    [Token(Token = "0x17003EC1")]
    public Rect MainWindowRect
    {
      [Token(Token = "0x6012935"), Address(RVA = "0x212B598", Offset = "0x212B598", VA = "0x212B598")] set
      {
      }
      [Token(Token = "0x6012936"), Address(RVA = "0x212B5A4", Offset = "0x212B5A4", VA = "0x212B5A4")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x17003EC2")]
    public AreaViewerModelBackgroundLoader BackgroundLoader
    {
      [Token(Token = "0x6012937"), Address(RVA = "0x212B5B0", Offset = "0x212B5B0", VA = "0x212B5B0")] get
      {
        return (AreaViewerModelBackgroundLoader) null;
      }
    }

    [Token(Token = "0x17003EC3")]
    public AreaViewerModelCamera CameraManager
    {
      [Token(Token = "0x6012938"), Address(RVA = "0x212B5B8", Offset = "0x212B5B8", VA = "0x212B5B8")] get
      {
        return (AreaViewerModelCamera) null;
      }
    }

    [Token(Token = "0x17003EC4")]
    public AreaViewerModelActor Actor
    {
      [Token(Token = "0x6012939"), Address(RVA = "0x212B5C0", Offset = "0x212B5C0", VA = "0x212B5C0")] get
      {
        return (AreaViewerModelActor) null;
      }
    }

    [Token(Token = "0x601293A")]
    [Address(RVA = "0x212B048", Offset = "0x212B048", VA = "0x212B048")]
    public AreaViewerModel(AreaViewerScene scene)
    {
    }

    [Token(Token = "0x601293B")]
    [Address(RVA = "0x212B4E0", Offset = "0x212B4E0", VA = "0x212B4E0", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601293C")]
    [Address(RVA = "0x212AB58", Offset = "0x212AB58", VA = "0x212AB58", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x601293D")]
    [Address(RVA = "0x212ADB4", Offset = "0x212ADB4", VA = "0x212ADB4", Slot = "6")]
    public void Destroy()
    {
    }

    [Token(Token = "0x601293E")]
    [Address(RVA = "0x212A9C0", Offset = "0x212A9C0", VA = "0x212A9C0")]
    public void CopyClipboard()
    {
    }

    [Token(Token = "0x601293F")]
    private T Register<T>(T model) where T : IAreaViewerModel => (T) null;
  }
}
