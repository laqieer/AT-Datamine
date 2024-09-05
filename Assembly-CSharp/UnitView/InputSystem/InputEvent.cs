// Decompiled with JetBrains decompiler
// Type: UnitView.InputSystem.InputEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitView.InputSystem
{
  [Token(Token = "0x20003DB")]
  public abstract class InputEvent
  {
    [Token(Token = "0x4001689")]
    [FieldOffset(Offset = "0x10")]
    public readonly TapsData Taps;
    [Token(Token = "0x400168A")]
    [FieldOffset(Offset = "0x18")]
    private InputEvent.Histories histories;

    [Token(Token = "0x600164A")]
    public abstract bool Touched();

    [Token(Token = "0x600164B")]
    [Address(RVA = "0x2486414", Offset = "0x2486414", VA = "0x2486414", Slot = "5")]
    protected virtual void UpdatePointerDownState()
    {
    }

    [Token(Token = "0x600164C")]
    [Address(RVA = "0x2486418", Offset = "0x2486418", VA = "0x2486418")]
    public void UpdateOnStart()
    {
    }

    [Token(Token = "0x600164D")]
    public abstract void OnUpdate();

    [Token(Token = "0x600164E")]
    [Address(RVA = "0x2486424", Offset = "0x2486424", VA = "0x2486424")]
    public void UpdateOnEnd()
    {
    }

    [Token(Token = "0x600164F")]
    [Address(RVA = "0x2486790", Offset = "0x2486790", VA = "0x2486790")]
    public bool IsPointerDown(InputEventDataEditable eventData) => new bool();

    [Token(Token = "0x6001650")]
    [Address(RVA = "0x24867D0", Offset = "0x24867D0", VA = "0x24867D0")]
    public bool IsPointerUp(InputEventDataEditable eventData) => new bool();

    [Token(Token = "0x6001651")]
    [Address(RVA = "0x2486810", Offset = "0x2486810", VA = "0x2486810")]
    public void OnEventCalledPointerUp()
    {
    }

    [Token(Token = "0x6001652")]
    [Address(RVA = "0x24869B0", Offset = "0x24869B0", VA = "0x24869B0")]
    public bool IsDoubleTap() => new bool();

    [Token(Token = "0x6001653")]
    [Address(RVA = "0x2486ADC", Offset = "0x2486ADC", VA = "0x2486ADC")]
    public DoubleSwipe JudgeDoubleSwipe(Vector3 tap1Dir, Vector3 tap2Dir) => new DoubleSwipe();

    [Token(Token = "0x6001654")]
    [Address(RVA = "0x2486508", Offset = "0x2486508", VA = "0x2486508")]
    private void ActionToTap(Action<InputEventDataEditable> action)
    {
    }

    [Token(Token = "0x6001655")]
    [Address(RVA = "0x2486C9C", Offset = "0x2486C9C", VA = "0x2486C9C")]
    public static InputEvent Create() => (InputEvent) null;

    [Token(Token = "0x6001656")]
    [Address(RVA = "0x2486CF8", Offset = "0x2486CF8", VA = "0x2486CF8")]
    protected InputEvent()
    {
    }

    [Token(Token = "0x20003DC")]
    private class Histories
    {
      [Token(Token = "0x400168B")]
      [FieldOffset(Offset = "0x10")]
      private InputEventDataEditable.History history1;
      [Token(Token = "0x400168C")]
      [FieldOffset(Offset = "0x2C")]
      private InputEventDataEditable.History history2;

      [Token(Token = "0x6001657")]
      [Address(RVA = "0x2486908", Offset = "0x2486908", VA = "0x2486908")]
      public void Set(InputEventDataEditable data)
      {
      }

      [Token(Token = "0x6001658")]
      [Address(RVA = "0x24869D4", Offset = "0x24869D4", VA = "0x24869D4")]
      public bool IsDoubleTap(InputEventData data) => new bool();

      [Token(Token = "0x6001659")]
      [Address(RVA = "0x248707C", Offset = "0x248707C", VA = "0x248707C")]
      private bool IsTap(float pointingTime) => new bool();

      [Token(Token = "0x600165A")]
      [Address(RVA = "0x2486F1C", Offset = "0x2486F1C", VA = "0x2486F1C")]
      public Histories()
      {
      }
    }

    [Token(Token = "0x20003DD")]
    private class Editor : InputEvent
    {
      [Token(Token = "0x600165B")]
      [Address(RVA = "0x248709C", Offset = "0x248709C", VA = "0x248709C", Slot = "4")]
      public override bool Touched() => new bool();

      [Token(Token = "0x600165C")]
      [Address(RVA = "0x24870A8", Offset = "0x24870A8", VA = "0x24870A8", Slot = "6")]
      public override void OnUpdate()
      {
      }

      [Token(Token = "0x600165D")]
      [Address(RVA = "0x2487108", Offset = "0x2487108", VA = "0x2487108", Slot = "5")]
      protected override void UpdatePointerDownState()
      {
      }

      [Token(Token = "0x600165E")]
      [Address(RVA = "0x248716C", Offset = "0x248716C", VA = "0x248716C")]
      public Editor()
      {
      }
    }

    [Token(Token = "0x20003DE")]
    private class TouchDevice : InputEvent
    {
      [Token(Token = "0x600165F")]
      [Address(RVA = "0x2487170", Offset = "0x2487170", VA = "0x2487170", Slot = "4")]
      public override bool Touched() => new bool();

      [Token(Token = "0x6001660")]
      [Address(RVA = "0x248718C", Offset = "0x248718C", VA = "0x248718C", Slot = "6")]
      public override void OnUpdate()
      {
      }

      [Token(Token = "0x6001661")]
      [Address(RVA = "0x24872DC", Offset = "0x24872DC", VA = "0x24872DC", Slot = "5")]
      protected override void UpdatePointerDownState()
      {
      }

      [Token(Token = "0x6001662")]
      [Address(RVA = "0x2487448", Offset = "0x2487448", VA = "0x2487448")]
      private void SetPosition(int index, InputEventDataEditable eventData)
      {
      }

      [Token(Token = "0x6001663")]
      [Address(RVA = "0x2486CF4", Offset = "0x2486CF4", VA = "0x2486CF4")]
      public TouchDevice()
      {
      }
    }

    [Token(Token = "0x20003DF")]
    private class Android : InputEvent.TouchDevice
    {
      [Token(Token = "0x6001664")]
      [Address(RVA = "0x24874A4", Offset = "0x24874A4", VA = "0x24874A4")]
      public Android()
      {
      }
    }

    [Token(Token = "0x20003E0")]
    private class IOS : InputEvent.TouchDevice
    {
      [Token(Token = "0x6001665")]
      [Address(RVA = "0x24874A8", Offset = "0x24874A8", VA = "0x24874A8")]
      public IOS()
      {
      }
    }

    [Token(Token = "0x20003E1")]
    private class PointerDevice : InputEvent
    {
      [Token(Token = "0x6001666")]
      [Address(RVA = "0x24874AC", Offset = "0x24874AC", VA = "0x24874AC", Slot = "4")]
      public override bool Touched() => new bool();

      [Token(Token = "0x6001667")]
      [Address(RVA = "0x24874B8", Offset = "0x24874B8", VA = "0x24874B8", Slot = "6")]
      public override void OnUpdate()
      {
      }

      [Token(Token = "0x6001668")]
      [Address(RVA = "0x2487510", Offset = "0x2487510", VA = "0x2487510", Slot = "5")]
      protected override void UpdatePointerDownState()
      {
      }

      [Token(Token = "0x6001669")]
      [Address(RVA = "0x2487574", Offset = "0x2487574", VA = "0x2487574")]
      public PointerDevice()
      {
      }
    }
  }
}
