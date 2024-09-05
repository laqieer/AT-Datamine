// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.ADV.AdvViewerPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.DebugViewer.AreaMap;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.ADV
{
  [Token(Token = "0x2002F98")]
  public class AdvViewerPresenter
  {
    [Token(Token = "0x400CB9F")]
    [FieldOffset(Offset = "0x10")]
    private bool isDraw;
    [Token(Token = "0x400CBA0")]
    [FieldOffset(Offset = "0x11")]
    private bool isPlayingHide;
    [Token(Token = "0x400CBA1")]
    [FieldOffset(Offset = "0x12")]
    private bool isAutoDemoPlay;
    [Token(Token = "0x400CBA2")]
    [FieldOffset(Offset = "0x13")]
    private bool isHideGui;
    [Token(Token = "0x400CBA3")]
    [FieldOffset(Offset = "0x14")]
    private bool isPlaying;
    [Token(Token = "0x400CBA6")]
    [FieldOffset(Offset = "0x28")]
    private ViewState currentState;

    [Token(Token = "0x17003EE1")]
    private AdvViewerModel ModelManager
    {
      [Token(Token = "0x60129BC"), Address(RVA = "0x4292DFC", Offset = "0x4292DFC", VA = "0x4292DFC")] get
      {
        return (AdvViewerModel) null;
      }
    }

    [Token(Token = "0x17003EE2")]
    private Dictionary<ViewState, IAdvViewerView> Views
    {
      [Token(Token = "0x60129BD"), Address(RVA = "0x4292E04", Offset = "0x4292E04", VA = "0x4292E04")] get
      {
        return (Dictionary<ViewState, IAdvViewerView>) null;
      }
    }

    [Token(Token = "0x60129BE")]
    [Address(RVA = "0x4292E0C", Offset = "0x4292E0C", VA = "0x4292E0C")]
    public AdvViewerPresenter(AdvViewerScene scene, DebugAreaMapLoader loader)
    {
    }

    [Token(Token = "0x60129BF")]
    [Address(RVA = "0x4296850", Offset = "0x4296850", VA = "0x4296850")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60129C0")]
    [Address(RVA = "0x42968E0", Offset = "0x42968E0", VA = "0x42968E0")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x60129C1")]
    [Address(RVA = "0x4296F9C", Offset = "0x4296F9C", VA = "0x4296F9C")]
    public void Update()
    {
    }

    [Token(Token = "0x60129C2")]
    [Address(RVA = "0x42970B4", Offset = "0x42970B4", VA = "0x42970B4")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60129C3")]
    [Address(RVA = "0x42971CC", Offset = "0x42971CC", VA = "0x42971CC")]
    private void ChangeState(ViewState next)
    {
    }

    [Token(Token = "0x60129C4")]
    [Address(RVA = "0x42972D0", Offset = "0x42972D0", VA = "0x42972D0")]
    private void MakeRuntimeDummyData()
    {
    }

    [Token(Token = "0x60129C5")]
    [Address(RVA = "0x429321C", Offset = "0x429321C", VA = "0x429321C")]
    private void SetupMainSequence()
    {
    }

    [Token(Token = "0x60129C6")]
    [Address(RVA = "0x42935E0", Offset = "0x42935E0", VA = "0x42935E0")]
    private void SetupTalkAdvEvent()
    {
    }

    [Token(Token = "0x60129C7")]
    [Address(RVA = "0x4293A68", Offset = "0x4293A68", VA = "0x4293A68")]
    private void SetupSystemMenuEvent()
    {
    }

    [Token(Token = "0x60129C8")]
    [Address(RVA = "0x4293E28", Offset = "0x4293E28", VA = "0x4293E28")]
    private void SetupFlavorObject()
    {
    }

    [Token(Token = "0x60129C9")]
    [Address(RVA = "0x42942A8", Offset = "0x42942A8", VA = "0x42942A8")]
    private void SetupSubQuest()
    {
    }

    [Token(Token = "0x60129CA")]
    [Address(RVA = "0x42946B4", Offset = "0x42946B4", VA = "0x42946B4")]
    private void SetupCommunication()
    {
    }

    [Token(Token = "0x60129CB")]
    [Address(RVA = "0x4294C88", Offset = "0x4294C88", VA = "0x4294C88")]
    private void SetupFacility()
    {
    }

    [Token(Token = "0x60129CC")]
    [Address(RVA = "0x42951C8", Offset = "0x42951C8", VA = "0x42951C8")]
    private void SetupAreaEventQuest()
    {
    }

    [Token(Token = "0x60129CD")]
    [Address(RVA = "0x4295504", Offset = "0x4295504", VA = "0x4295504")]
    private void SetupFreeActionEnter()
    {
    }

    [Token(Token = "0x60129CE")]
    [Address(RVA = "0x4295840", Offset = "0x4295840", VA = "0x4295840")]
    private void SetupEnding()
    {
    }

    [Token(Token = "0x60129CF")]
    [Address(RVA = "0x4295A94", Offset = "0x4295A94", VA = "0x4295A94")]
    private void SetupPreHomeEvStage()
    {
    }

    [Token(Token = "0x60129D0")]
    [Address(RVA = "0x4295CEC", Offset = "0x4295CEC", VA = "0x4295CEC")]
    private void SetupDemoInfoScript()
    {
    }

    [Token(Token = "0x60129D1")]
    [Address(RVA = "0x4296058", Offset = "0x4296058", VA = "0x4296058")]
    private void SetupSampleScript()
    {
    }

    [Token(Token = "0x60129D2")]
    [Address(RVA = "0x42962FC", Offset = "0x42962FC", VA = "0x42962FC")]
    private void SetupReverseLookup()
    {
    }

    [Token(Token = "0x60129D3")]
    private T Register<T>(ViewState state, T view) where T : IAdvViewerView => (T) null;
  }
}
