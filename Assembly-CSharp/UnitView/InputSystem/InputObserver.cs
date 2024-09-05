// Decompiled with JetBrains decompiler
// Type: UnitView.InputSystem.InputObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace UnitView.InputSystem
{
  [Token(Token = "0x20003E8")]
  public class InputObserver : 
    Singleton<InputObserver>,
    IInputEventHandler,
    IInputEventOnPointer,
    IInputEventOnPointerDown,
    IInputEventOnPointerUp,
    IInputEventOnDoublePointer
  {
    [Token(Token = "0x400169E")]
    [FieldOffset(Offset = "0x10")]
    private InputObserverMonobehaviour entity;

    [Token(Token = "0x1700027C")]
    public List<IInputEventOnPointerDown> PointerDownListeners
    {
      [Token(Token = "0x6001697"), Address(RVA = "0x2487A1C", Offset = "0x2487A1C", VA = "0x2487A1C")] get
      {
        return (List<IInputEventOnPointerDown>) null;
      }
    }

    [Token(Token = "0x1700027D")]
    public List<IInputEventOnPointerUp> PointerUpListeners
    {
      [Token(Token = "0x6001698"), Address(RVA = "0x2487A24", Offset = "0x2487A24", VA = "0x2487A24")] get
      {
        return (List<IInputEventOnPointerUp>) null;
      }
    }

    [Token(Token = "0x1700027E")]
    public List<IInputEventOnDoublePointer> MultiTapListeners
    {
      [Token(Token = "0x6001699"), Address(RVA = "0x2487A2C", Offset = "0x2487A2C", VA = "0x2487A2C")] get
      {
        return (List<IInputEventOnDoublePointer>) null;
      }
    }

    [Token(Token = "0x600169A")]
    [Address(RVA = "0x2487A34", Offset = "0x2487A34", VA = "0x2487A34")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600169B")]
    [Address(RVA = "0x2487B40", Offset = "0x2487B40", VA = "0x2487B40", Slot = "4")]
    private void UnitView\u002EInputSystem\u002EIInputEventOnPointerDown\u002EOnPointerDown(
      InputEventData eventData)
    {
    }

    [Token(Token = "0x600169C")]
    [Address(RVA = "0x2487C24", Offset = "0x2487C24", VA = "0x2487C24", Slot = "5")]
    private void UnitView\u002EInputSystem\u002EIInputEventOnPointerDown\u002EDuringPointerDown(
      InputEventData eventData)
    {
    }

    [Token(Token = "0x600169D")]
    [Address(RVA = "0x2487D08", Offset = "0x2487D08", VA = "0x2487D08", Slot = "6")]
    private void UnitView\u002EInputSystem\u002EIInputEventOnPointerDown\u002EOnPointerDoubleTap(
      InputEventData eventData)
    {
    }

    [Token(Token = "0x600169E")]
    [Address(RVA = "0x2487DEC", Offset = "0x2487DEC", VA = "0x2487DEC", Slot = "7")]
    private void UnitView\u002EInputSystem\u002EIInputEventOnPointerUp\u002EOnPointerUp(
      InputEventData eventData)
    {
    }

    [Token(Token = "0x600169F")]
    [Address(RVA = "0x2487ED0", Offset = "0x2487ED0", VA = "0x2487ED0", Slot = "8")]
    private void UnitView\u002EInputSystem\u002EIInputEventOnDoublePointer\u002EOnDoublePointerDown(
      InputEventData first,
      InputEventData second)
    {
    }

    [Token(Token = "0x60016A0")]
    [Address(RVA = "0x2487FB8", Offset = "0x2487FB8", VA = "0x2487FB8", Slot = "9")]
    private void UnitView\u002EInputSystem\u002EIInputEventOnDoublePointer\u002EDuringDoublePointerDown(
      InputEventData first,
      InputEventData second,
      DoubleSwipe doubleSwipe)
    {
    }

    [Token(Token = "0x60016A1")]
    [Address(RVA = "0x24880B0", Offset = "0x24880B0", VA = "0x24880B0")]
    public InputObserver()
    {
    }
  }
}
