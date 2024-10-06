// Decompiled with JetBrains decompiler
// Type: UnitView.InputSystem.IInputEventOnPointerDown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitView.InputSystem
{
  [Token(Token = "0x20003D8")]
  public interface IInputEventOnPointerDown
  {
    [Token(Token = "0x6001644")]
    void OnPointerDown(InputEventData eventData);

    [Token(Token = "0x6001645")]
    void DuringPointerDown(InputEventData eventData);

    [Token(Token = "0x6001646")]
    void OnPointerDoubleTap(InputEventData eventData);
  }
}
