// Decompiled with JetBrains decompiler
// Type: UnitView.InputSystem.IInputEventOnDoublePointer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitView.InputSystem
{
  [Token(Token = "0x20003DA")]
  public interface IInputEventOnDoublePointer
  {
    [Token(Token = "0x6001648")]
    void OnDoublePointerDown(InputEventData first, InputEventData second);

    [Token(Token = "0x6001649")]
    void DuringDoublePointerDown(
      InputEventData first,
      InputEventData second,
      DoubleSwipe doubleSwipe);
  }
}
