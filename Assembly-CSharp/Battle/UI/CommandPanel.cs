// Decompiled with JetBrains decompiler
// Type: Battle.UI.CommandPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023BB")]
  public abstract class CommandPanel : MonoBehaviour
  {
    [Token(Token = "0x400984D")]
    [FieldOffset(Offset = "0x18")]
    protected UITimelineController timeline;
    [Token(Token = "0x400984E")]
    [FieldOffset(Offset = "0x20")]
    protected ManualActionSelector selector;
    [Token(Token = "0x400984F")]
    [FieldOffset(Offset = "0x28")]
    protected CommandType command;
    [Token(Token = "0x4009850")]
    [FieldOffset(Offset = "0x2C")]
    protected bool isOpen;
    [Token(Token = "0x4009851")]
    [FieldOffset(Offset = "0x2D")]
    protected bool isInitialized;
    [Token(Token = "0x4009852")]
    [FieldOffset(Offset = "0x30")]
    public Action<bool> MainCommandSetActiveAction;

    [Token(Token = "0x17002F25")]
    public bool IsOpen
    {
      [Token(Token = "0x600DA9B"), Address(RVA = "0x21455E4", Offset = "0x21455E4", VA = "0x21455E4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600DA9C")]
    [Address(RVA = "0x21455EC", Offset = "0x21455EC", VA = "0x21455EC")]
    public void SetTimeLineController(UITimelineController timelineController)
    {
    }

    [Token(Token = "0x600DA9D")]
    [Address(RVA = "0x21455F4", Offset = "0x21455F4", VA = "0x21455F4")]
    public void SetData(CommandType commandType, ManualActionSelector manualActionSelector)
    {
    }

    [Token(Token = "0x600DA9E")]
    [Address(RVA = "0x2145600", Offset = "0x2145600", VA = "0x2145600")]
    public void ResetOpenFlag()
    {
    }

    [Token(Token = "0x600DA9F")]
    protected abstract void Initialize();

    [Token(Token = "0x600DAA0")]
    public abstract void Open(UnitParameterData unit);

    [Token(Token = "0x600DAA1")]
    protected abstract IEnumerator OpenTimeLine();

    [Token(Token = "0x600DAA2")]
    public abstract void Close();

    [Token(Token = "0x600DAA3")]
    protected abstract IEnumerator CloseTimeLine();

    [Token(Token = "0x600DAA4")]
    protected abstract void HidePanelButton();

    [Token(Token = "0x600DAA5")]
    [Address(RVA = "0x2145608", Offset = "0x2145608", VA = "0x2145608")]
    protected CommandPanel()
    {
    }
  }
}
