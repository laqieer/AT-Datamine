// Decompiled with JetBrains decompiler
// Type: UnitDetail.State.UnitDetailSubState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UnitDetail.State
{
  [Token(Token = "0x20004D0")]
  public abstract class UnitDetailSubState : StateMachineState<UnitDetailStateHandlerBase>
  {
    [Token(Token = "0x6001B5B")]
    [Address(RVA = "0x2C2C6F8", Offset = "0x2C2C6F8", VA = "0x2C2C6F8", Slot = "6")]
    public override void Execute(UnitDetailStateHandlerBase entity, float deltaTime)
    {
    }

    [Token(Token = "0x6001B5C")]
    [Address(RVA = "0x2C2C6FC", Offset = "0x2C2C6FC", VA = "0x2C2C6FC", Slot = "7")]
    public override void Exit(UnitDetailStateHandlerBase entity)
    {
    }

    [Token(Token = "0x6001B5D")]
    [Address(RVA = "0x2C2C700", Offset = "0x2C2C700", VA = "0x2C2C700", Slot = "9")]
    public virtual void OnBack()
    {
    }

    [Token(Token = "0x6001B5E")]
    [Address(RVA = "0x2C2C704", Offset = "0x2C2C704", VA = "0x2C2C704", Slot = "10")]
    public virtual void OnFlick(GameCore.Input.Input.Direction direction)
    {
    }

    [Token(Token = "0x6001B5F")]
    [Address(RVA = "0x2C2C708", Offset = "0x2C2C708", VA = "0x2C2C708", Slot = "11")]
    public virtual void OnDragStart(Vector2 position)
    {
    }

    [Token(Token = "0x6001B60")]
    [Address(RVA = "0x2C2C70C", Offset = "0x2C2C70C", VA = "0x2C2C70C", Slot = "12")]
    public virtual void OnDrag(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6001B61")]
    [Address(RVA = "0x2C2C710", Offset = "0x2C2C710", VA = "0x2C2C710", Slot = "13")]
    public virtual void OnDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B62")]
    [Address(RVA = "0x2C2C714", Offset = "0x2C2C714", VA = "0x2C2C714", Slot = "14")]
    public virtual void OnClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001B63")]
    [Address(RVA = "0x2C2C718", Offset = "0x2C2C718", VA = "0x2C2C718", Slot = "15")]
    public virtual void OnDoubleClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001B64")]
    [Address(RVA = "0x2C2C71C", Offset = "0x2C2C71C", VA = "0x2C2C71C", Slot = "16")]
    public virtual void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x6001B65")]
    [Address(RVA = "0x2C2C720", Offset = "0x2C2C720", VA = "0x2C2C720", Slot = "17")]
    public virtual void OnPinch(float delta)
    {
    }

    [Token(Token = "0x6001B66")]
    [Address(RVA = "0x2C2C724", Offset = "0x2C2C724", VA = "0x2C2C724", Slot = "18")]
    public virtual void OnPinchEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B67")]
    [Address(RVA = "0x2C2C728", Offset = "0x2C2C728", VA = "0x2C2C728", Slot = "19")]
    public virtual void OnDoubleDrag(Vector2 delta)
    {
    }

    [Token(Token = "0x6001B68")]
    [Address(RVA = "0x2C2C72C", Offset = "0x2C2C72C", VA = "0x2C2C72C", Slot = "20")]
    public virtual void OnDoubleDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B69")]
    [Address(RVA = "0x2C2C730", Offset = "0x2C2C730", VA = "0x2C2C730")]
    protected UnitDetailSubState()
    {
    }
  }
}
