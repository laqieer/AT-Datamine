// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerViewBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2003082")]
  internal abstract class AdvViewerViewBase : 
    DebugViewerViewBase<ViewState>,
    IAdvViewerView,
    IDebugViewerView<ViewState>
  {
    [Token(Token = "0x6012F63")]
    [Address(RVA = "0x431E850", Offset = "0x431E850", VA = "0x431E850", Slot = "14")]
    protected override sealed string ToViewStateName(ViewState state) => (string) null;

    [Token(Token = "0x6012F64")]
    [Address(RVA = "0x431D7C8", Offset = "0x431D7C8", VA = "0x431D7C8")]
    protected AdvViewerViewBase()
    {
    }
  }
}
