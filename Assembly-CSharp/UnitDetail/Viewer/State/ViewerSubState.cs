// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.State.ViewerSubState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnitDetail.State;
using UnityEngine;

#nullable disable
namespace UnitDetail.Viewer.State
{
  [Token(Token = "0x20004CA")]
  public abstract class ViewerSubState : UnitDetailSubState<UnitViewerStateHandler>
  {
    [Token(Token = "0x17000353")]
    public abstract UnitViewerStateHandler.SubStateIndices SubStateIndex { [Token(Token = "0x6001B1D")] get; }

    [Token(Token = "0x17000354")]
    protected abstract UnitViewerStateHandler.SubStateIndices NextSubStateIndex { [Token(Token = "0x6001B1E")] get; }

    [Token(Token = "0x17000355")]
    protected abstract UnitViewerBase Viewer { [Token(Token = "0x6001B1F")] get; }

    [Token(Token = "0x6001B20")]
    [Address(RVA = "0x2C2BBDC", Offset = "0x2C2BBDC", VA = "0x2C2BBDC", Slot = "5")]
    protected override void OnEnter(UnitDetailStateHandlerBase entity)
    {
    }

    [Token(Token = "0x6001B21")]
    [Address(RVA = "0x2C2BC74", Offset = "0x2C2BC74", VA = "0x2C2BC74", Slot = "8")]
    public override int GetStateType() => new int();

    [Token(Token = "0x6001B22")]
    [Address(RVA = "0x2C2A14C", Offset = "0x2C2A14C", VA = "0x2C2A14C")]
    public void OnSwitchOverNext()
    {
    }

    [Token(Token = "0x6001B23")]
    [Address(RVA = "0x2C2BC84", Offset = "0x2C2BC84", VA = "0x2C2BC84", Slot = "9")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6001B24")]
    [Address(RVA = "0x2C2BC94", Offset = "0x2C2BC94", VA = "0x2C2BC94", Slot = "11")]
    public override void OnDragStart(Vector2 position)
    {
    }

    [Token(Token = "0x6001B25")]
    [Address(RVA = "0x2C2BCDC", Offset = "0x2C2BCDC", VA = "0x2C2BCDC", Slot = "12")]
    public override void OnDrag(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6001B26")]
    [Address(RVA = "0x2C2BD90", Offset = "0x2C2BD90", VA = "0x2C2BD90", Slot = "13")]
    public override void OnDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B27")]
    [Address(RVA = "0x2C2BDD8", Offset = "0x2C2BDD8", VA = "0x2C2BDD8", Slot = "14")]
    public override void OnClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001B28")]
    [Address(RVA = "0x2C2BE20", Offset = "0x2C2BE20", VA = "0x2C2BE20", Slot = "15")]
    public override void OnDoubleClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001B29")]
    [Address(RVA = "0x2C2BE68", Offset = "0x2C2BE68", VA = "0x2C2BE68", Slot = "16")]
    public override void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x6001B2A")]
    [Address(RVA = "0x2C2BEAC", Offset = "0x2C2BEAC", VA = "0x2C2BEAC", Slot = "17")]
    public override void OnPinch(float delta)
    {
    }

    [Token(Token = "0x6001B2B")]
    [Address(RVA = "0x2C2BEE8", Offset = "0x2C2BEE8", VA = "0x2C2BEE8", Slot = "18")]
    public override void OnPinchEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B2C")]
    [Address(RVA = "0x2C2BF30", Offset = "0x2C2BF30", VA = "0x2C2BF30", Slot = "19")]
    public override void OnDoubleDrag(Vector2 delta)
    {
    }

    [Token(Token = "0x6001B2D")]
    [Address(RVA = "0x2C2BFCC", Offset = "0x2C2BFCC", VA = "0x2C2BFCC", Slot = "20")]
    public override void OnDoubleDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B2E")]
    [Address(RVA = "0x2C2C014", Offset = "0x2C2C014", VA = "0x2C2C014", Slot = "24")]
    public virtual void OnUpdateMotionList()
    {
    }

    [Token(Token = "0x6001B2F")]
    [Address(RVA = "0x2C296F0", Offset = "0x2C296F0", VA = "0x2C296F0")]
    public void OnPlayMotion(string stateName)
    {
    }

    [Token(Token = "0x6001B30")]
    [Address(RVA = "0x2C2C0FC", Offset = "0x2C2C0FC", VA = "0x2C2C0FC")]
    public void OnEndMotion()
    {
    }

    [Token(Token = "0x6001B31")]
    [Address(RVA = "0x2C2C228", Offset = "0x2C2C228", VA = "0x2C2C228", Slot = "25")]
    protected virtual void OnBackImpl()
    {
    }

    [Token(Token = "0x6001B32")]
    [Address(RVA = "0x2C2C018", Offset = "0x2C2C018", VA = "0x2C2C018")]
    private void PlayMotion(string stateName, Action endAnimationCallback)
    {
    }

    [Token(Token = "0x6001B33")]
    [Address(RVA = "0x2C2C100", Offset = "0x2C2C100", VA = "0x2C2C100")]
    private void CrossFadeIdleMotion()
    {
    }

    [Token(Token = "0x6001B34")]
    [Address(RVA = "0x2C2B970", Offset = "0x2C2B970", VA = "0x2C2B970")]
    protected ViewerSubState()
    {
    }
  }
}
