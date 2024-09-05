// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F39")]
  internal class DebugAreaMapUIPresenter
  {
    [Token(Token = "0x400CA7A")]
    [FieldOffset(Offset = "0x10")]
    private bool isDraw;
    [Token(Token = "0x400CA7B")]
    [FieldOffset(Offset = "0x14")]
    private ViewState currentState;
    [Token(Token = "0x400CA7C")]
    [FieldOffset(Offset = "0x18")]
    private IDebugViewerView<ViewState>[] viewState;

    [Token(Token = "0x17003E90")]
    private DebugAreaMapUIModel Model
    {
      [Token(Token = "0x601273D"), Address(RVA = "0x2117C04", Offset = "0x2117C04", VA = "0x2117C04")] get
      {
        return (DebugAreaMapUIModel) null;
      }
    }

    [Token(Token = "0x17003E91")]
    private IDebugViewerView<ViewState> CurrentView
    {
      [Token(Token = "0x601273E"), Address(RVA = "0x2117C0C", Offset = "0x2117C0C", VA = "0x2117C0C")] get
      {
        return (IDebugViewerView<ViewState>) null;
      }
    }

    [Token(Token = "0x601273F")]
    [Address(RVA = "0x2117824", Offset = "0x2117824", VA = "0x2117824")]
    public DebugAreaMapUIPresenter(DebugAreaMapUIModel model)
    {
    }

    [Token(Token = "0x6012740")]
    [Address(RVA = "0x21171D8", Offset = "0x21171D8", VA = "0x21171D8")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x6012741")]
    [Address(RVA = "0x21172FC", Offset = "0x21172FC", VA = "0x21172FC")]
    public void OnDrawGizmos()
    {
    }

    [Token(Token = "0x6012742")]
    [Address(RVA = "0x2117C40", Offset = "0x2117C40", VA = "0x2117C40")]
    private void ChangeViewState(object sender, ViewState next)
    {
    }

    [Token(Token = "0x6012743")]
    [Address(RVA = "0x2117DEC", Offset = "0x2117DEC", VA = "0x2117DEC")]
    private IDebugViewerView<ViewState> CreateView(ViewState viewState)
    {
      return (IDebugViewerView<ViewState>) null;
    }

    [Token(Token = "0x6012744")]
    [Address(RVA = "0x21180D8", Offset = "0x21180D8", VA = "0x21180D8")]
    private DebugAreaMapUIViewLoadMap CreateViewLoadMap() => (DebugAreaMapUIViewLoadMap) null;

    [Token(Token = "0x6012745")]
    [Address(RVA = "0x2118808", Offset = "0x2118808", VA = "0x2118808")]
    private DebugAreaMapUIViewPlayerSetting CreateViewPlayerSetting()
    {
      return (DebugAreaMapUIViewPlayerSetting) null;
    }

    [Token(Token = "0x6012746")]
    [Address(RVA = "0x2118A6C", Offset = "0x2118A6C", VA = "0x2118A6C")]
    private DebugAreaMapUIViewInstanceCreate CreateViewInstanceCreate()
    {
      return (DebugAreaMapUIViewInstanceCreate) null;
    }

    [Token(Token = "0x6012747")]
    [Address(RVA = "0x2118E78", Offset = "0x2118E78", VA = "0x2118E78")]
    private DebugAreaMapUIViewLayoutCreate CreateViewLayoutCreate()
    {
      return (DebugAreaMapUIViewLayoutCreate) null;
    }

    [Token(Token = "0x6012748")]
    [Address(RVA = "0x2119160", Offset = "0x2119160", VA = "0x2119160")]
    private DebugAreaMapUIViewFootSound CreateViewFootSound() => (DebugAreaMapUIViewFootSound) null;

    [Token(Token = "0x6012749")]
    [Address(RVA = "0x211926C", Offset = "0x211926C", VA = "0x211926C")]
    private DebugAreaMapUIViewAutoRun CreateViewAutoRun() => (DebugAreaMapUIViewAutoRun) null;
  }
}
