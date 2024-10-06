// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F79")]
  public class AreaViewerPresenter
  {
    [Token(Token = "0x400CB47")]
    [FieldOffset(Offset = "0x18")]
    private ViewState currentState;

    [Token(Token = "0x17003EBB")]
    private Dictionary<ViewState, IAreaViewerView> Views
    {
      [Token(Token = "0x6012907"), Address(RVA = "0x2129A28", Offset = "0x2129A28", VA = "0x2129A28")] get
      {
        return (Dictionary<ViewState, IAreaViewerView>) null;
      }
    }

    [Token(Token = "0x17003EBC")]
    private AreaViewerModel Model
    {
      [Token(Token = "0x6012908"), Address(RVA = "0x2129A30", Offset = "0x2129A30", VA = "0x2129A30")] get
      {
        return (AreaViewerModel) null;
      }
    }

    [Token(Token = "0x6012909")]
    [Address(RVA = "0x2129A38", Offset = "0x2129A38", VA = "0x2129A38")]
    public AreaViewerPresenter(AreaViewerModel model)
    {
    }

    [Token(Token = "0x601290A")]
    [Address(RVA = "0x212A490", Offset = "0x212A490", VA = "0x212A490")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x601290B")]
    [Address(RVA = "0x212A55C", Offset = "0x212A55C", VA = "0x212A55C")]
    private void ChangeState(ViewState next)
    {
    }

    [Token(Token = "0x601290C")]
    [Address(RVA = "0x2129BDC", Offset = "0x2129BDC", VA = "0x2129BDC")]
    private void CreateBackgroundLoader(AreaViewerModel model)
    {
    }

    [Token(Token = "0x601290D")]
    [Address(RVA = "0x2129E58", Offset = "0x2129E58", VA = "0x2129E58")]
    private void CreateCameraView(AreaViewerModel model)
    {
    }

    [Token(Token = "0x601290E")]
    [Address(RVA = "0x212A090", Offset = "0x212A090", VA = "0x212A090")]
    private void CreateActorView(AreaViewerModel model)
    {
    }

    [Token(Token = "0x601290F")]
    private T Register<T>(ViewState state, T view) where T : IAreaViewerView => (T) null;
  }
}
