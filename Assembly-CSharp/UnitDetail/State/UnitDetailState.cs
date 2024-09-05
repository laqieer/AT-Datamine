// Decompiled with JetBrains decompiler
// Type: UnitDetail.State.UnitDetailState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using Scenes.OutGame;
using UnityEngine;

#nullable disable
namespace UnitDetail.State
{
  [Token(Token = "0x20004CF")]
  public class UnitDetailState : StateMachineState<UnitDetailSubScene>
  {
    [Token(Token = "0x6001B46")]
    [Address(RVA = "0x2C2C69C", Offset = "0x2C2C69C", VA = "0x2C2C69C", Slot = "6")]
    public override void Execute(UnitDetailSubScene entity, float deltaTime)
    {
    }

    [Token(Token = "0x6001B47")]
    [Address(RVA = "0x2C2C6A0", Offset = "0x2C2C6A0", VA = "0x2C2C6A0", Slot = "7")]
    public override void Exit(UnitDetailSubScene entity)
    {
    }

    [Token(Token = "0x17000359")]
    protected virtual UnitDetailSubScene.StateIndices StateIndex
    {
      [Token(Token = "0x6001B48"), Address(RVA = "0x2C2C6A4", Offset = "0x2C2C6A4", VA = "0x2C2C6A4", Slot = "9")] get
      {
        return new UnitDetailSubScene.StateIndices();
      }
    }

    [Token(Token = "0x6001B49")]
    [Address(RVA = "0x2C2C6AC", Offset = "0x2C2C6AC", VA = "0x2C2C6AC", Slot = "8")]
    public override int GetStateType() => new int();

    [Token(Token = "0x6001B4A")]
    [Address(RVA = "0x2C2C6B8", Offset = "0x2C2C6B8", VA = "0x2C2C6B8", Slot = "10")]
    public virtual void OnNextUnit()
    {
    }

    [Token(Token = "0x6001B4B")]
    [Address(RVA = "0x2C2C6BC", Offset = "0x2C2C6BC", VA = "0x2C2C6BC", Slot = "11")]
    public virtual void OnPrevUnit()
    {
    }

    [Token(Token = "0x6001B4C")]
    [Address(RVA = "0x2C2C6C0", Offset = "0x2C2C6C0", VA = "0x2C2C6C0", Slot = "12")]
    public virtual void OnBack()
    {
    }

    [Token(Token = "0x6001B4D")]
    [Address(RVA = "0x2C2C6C4", Offset = "0x2C2C6C4", VA = "0x2C2C6C4", Slot = "13")]
    public virtual void OnSwitchOverViewer()
    {
    }

    [Token(Token = "0x6001B4E")]
    [Address(RVA = "0x2C2C6C8", Offset = "0x2C2C6C8", VA = "0x2C2C6C8", Slot = "14")]
    public virtual void OnSwitchOverCustomize()
    {
    }

    [Token(Token = "0x6001B4F")]
    [Address(RVA = "0x2C2C6CC", Offset = "0x2C2C6CC", VA = "0x2C2C6CC", Slot = "15")]
    public virtual void OnFlick(CommonGesturePanel.Direction direction, Vector2 speed)
    {
    }

    [Token(Token = "0x6001B50")]
    [Address(RVA = "0x2C2C6D0", Offset = "0x2C2C6D0", VA = "0x2C2C6D0", Slot = "16")]
    public virtual void OnDragStart(Vector2 position)
    {
    }

    [Token(Token = "0x6001B51")]
    [Address(RVA = "0x2C2C6D4", Offset = "0x2C2C6D4", VA = "0x2C2C6D4", Slot = "17")]
    public virtual void OnDrag(Vector2 position, Vector2 delta)
    {
    }

    [Token(Token = "0x6001B52")]
    [Address(RVA = "0x2C2C6D8", Offset = "0x2C2C6D8", VA = "0x2C2C6D8", Slot = "18")]
    public virtual void OnDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B53")]
    [Address(RVA = "0x2C2C6DC", Offset = "0x2C2C6DC", VA = "0x2C2C6DC", Slot = "19")]
    public virtual void OnClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001B54")]
    [Address(RVA = "0x2C2C6E0", Offset = "0x2C2C6E0", VA = "0x2C2C6E0", Slot = "20")]
    public virtual void OnDoubleClick(Vector2 position)
    {
    }

    [Token(Token = "0x6001B55")]
    [Address(RVA = "0x2C2C6E4", Offset = "0x2C2C6E4", VA = "0x2C2C6E4", Slot = "21")]
    public virtual void OnPinchStart(Vector2 center)
    {
    }

    [Token(Token = "0x6001B56")]
    [Address(RVA = "0x2C2C6E8", Offset = "0x2C2C6E8", VA = "0x2C2C6E8", Slot = "22")]
    public virtual void OnPinch(float delta)
    {
    }

    [Token(Token = "0x6001B57")]
    [Address(RVA = "0x2C2C6EC", Offset = "0x2C2C6EC", VA = "0x2C2C6EC", Slot = "23")]
    public virtual void OnPinchEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B58")]
    [Address(RVA = "0x2C2C6F0", Offset = "0x2C2C6F0", VA = "0x2C2C6F0", Slot = "24")]
    public virtual void OnDoubleDrag(Vector2 delta)
    {
    }

    [Token(Token = "0x6001B59")]
    [Address(RVA = "0x2C2C6F4", Offset = "0x2C2C6F4", VA = "0x2C2C6F4", Slot = "25")]
    public virtual void OnDoubleDragEnd(Vector2 position)
    {
    }

    [Token(Token = "0x6001B5A")]
    [Address(RVA = "0x2C2C250", Offset = "0x2C2C250", VA = "0x2C2C250")]
    public UnitDetailState()
    {
    }
  }
}
