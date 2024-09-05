// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerViewBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F95")]
  internal abstract class AreaViewerViewBase : 
    DebugViewerViewBase<ViewState>,
    IAreaViewerView,
    IDebugViewerView<ViewState>
  {
    [Token(Token = "0x60129B3")]
    [Address(RVA = "0x42925C0", Offset = "0x42925C0", VA = "0x42925C0", Slot = "14")]
    protected override sealed string ToViewStateName(ViewState state) => (string) null;

    [Token(Token = "0x60129B4")]
    [Address(RVA = "0x4292350", Offset = "0x4292350", VA = "0x4292350")]
    protected AreaViewerViewBase()
    {
    }
  }
}
