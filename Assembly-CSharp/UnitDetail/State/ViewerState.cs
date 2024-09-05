// Decompiled with JetBrains decompiler
// Type: UnitDetail.State.ViewerState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame;
using UnitDetail.Viewer;
using UnityEngine;

#nullable disable
namespace UnitDetail.State
{
  [Token(Token = "0x20004D2")]
  public class ViewerState : UnitDetailState
  {
    [Token(Token = "0x4001948")]
    [FieldOffset(Offset = "0x20")]
    private UnitViewerStateHandler stateHandler;

    [Token(Token = "0x6001B6C")]
    [Address(RVA = "0x2C2C778", Offset = "0x2C2C778", VA = "0x2C2C778")]
    public ViewerState(UnitViewerStateHandler stateHandler)
    {
    }

    [Token(Token = "0x6001B6D")]
    [Address(RVA = "0x2C2C79C", Offset = "0x2C2C79C", VA = "0x2C2C79C", Slot = "5")]
    protected override void OnEnter(UnitDetailSubScene entity)
    {
    }

    [Token(Token = "0x6001B6E")]
    [Address(RVA = "0x2C2C7D0", Offset = "0x2C2C7D0", VA = "0x2C2C7D0", Slot = "12")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6001B6F")]
    [Address(RVA = "0x2C2C7F4", Offset = "0x2C2C7F4", VA = "0x2C2C7F4", Slot = "16")]
    public override void OnDragStart(Vector2 position)
    {
    }

    [Token(Token = "0x6001B70")]
    [Address(RVA = "0x2C2C814", Offset = "0x2C2C814", VA = "0x2C2C814", Slot = "17")]
    public override void OnDrag(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6001B71")]
    [Address(RVA = "0x2C2C834", Offset = "0x2C2C834", VA = "0x2C2C834", Slot = "18")]
    public override void OnDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B72")]
    [Address(RVA = "0x2C2C854", Offset = "0x2C2C854", VA = "0x2C2C854", Slot = "19")]
    public override void OnClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001B73")]
    [Address(RVA = "0x2C2C874", Offset = "0x2C2C874", VA = "0x2C2C874", Slot = "20")]
    public override void OnDoubleClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001B74")]
    [Address(RVA = "0x2C2C894", Offset = "0x2C2C894", VA = "0x2C2C894", Slot = "21")]
    public override void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x6001B75")]
    [Address(RVA = "0x2C2C8B4", Offset = "0x2C2C8B4", VA = "0x2C2C8B4", Slot = "22")]
    public override void OnPinch(float delta)
    {
    }

    [Token(Token = "0x6001B76")]
    [Address(RVA = "0x2C2C8D8", Offset = "0x2C2C8D8", VA = "0x2C2C8D8", Slot = "23")]
    public override void OnPinchEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B77")]
    [Address(RVA = "0x2C2C8FC", Offset = "0x2C2C8FC", VA = "0x2C2C8FC", Slot = "24")]
    public override void OnDoubleDrag(Vector2 delta)
    {
    }

    [Token(Token = "0x6001B78")]
    [Address(RVA = "0x2C2C920", Offset = "0x2C2C920", VA = "0x2C2C920", Slot = "25")]
    public override void OnDoubleDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B79")]
    [Address(RVA = "0x2C2C944", Offset = "0x2C2C944", VA = "0x2C2C944", Slot = "14")]
    public override void OnSwitchOverCustomize()
    {
    }
  }
}
