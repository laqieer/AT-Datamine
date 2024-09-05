// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.IDebugViewerView`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer
{
  [Token(Token = "0x2002F1B")]
  internal interface IDebugViewerView<ViewState> where ViewState : struct
  {
    [Token(Token = "0x1400018E")]
    event EventHandler<ViewState> OnNext;

    [Token(Token = "0x17003E66")]
    BindingParam<Rect> MainWindowRect { [Token(Token = "0x601267B")] get; }

    [Token(Token = "0x601267C")]
    void Initialize(ViewState myState);

    [Token(Token = "0x601267D")]
    void OnGUI();

    [Token(Token = "0x601267E")]
    void OnDrawGizmos();
  }
}
