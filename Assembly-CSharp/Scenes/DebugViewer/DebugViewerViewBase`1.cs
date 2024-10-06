// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.DebugViewerViewBase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer
{
  [Token(Token = "0x2002F19")]
  internal abstract class DebugViewerViewBase<ViewState> : IDebugViewerView<ViewState> where ViewState : struct
  {
    [Token(Token = "0x400CA1A")]
    [FieldOffset(Offset = "0x0")]
    protected ViewState myState;

    [Token(Token = "0x1400018D")]
    public event EventHandler<ViewState> OnNext
    {
      [Token(Token = "0x601266C")] add
      {
      }
      [Token(Token = "0x601266D")] remove
      {
      }
    }

    [Token(Token = "0x17003E65")]
    public BindingParam<Rect> MainWindowRect
    {
      [Token(Token = "0x601266E")] get => (BindingParam<Rect>) null;
    }

    [Token(Token = "0x601266F")]
    public virtual void Initialize(ViewState myState)
    {
    }

    [Token(Token = "0x6012670")]
    public virtual void OnGUI()
    {
    }

    [Token(Token = "0x6012671")]
    public virtual void OnDrawGizmos()
    {
    }

    [Token(Token = "0x6012672")]
    private void DoMainWindowCommon(int windowId)
    {
    }

    [Token(Token = "0x6012673")]
    protected abstract void DoMainWindow(int windowId);

    [Token(Token = "0x6012674")]
    protected abstract string ToViewStateName(ViewState state);

    [Token(Token = "0x6012675")]
    protected void DrawBackButton(ViewState next = default (ViewState))
    {
    }

    [Token(Token = "0x6012676")]
    protected Rect CalcDropdownRect() => new Rect();

    [Token(Token = "0x6012677")]
    protected virtual void OnNextState(ViewState next)
    {
    }

    [Token(Token = "0x6012678")]
    protected DebugViewerViewBase()
    {
    }
  }
}
