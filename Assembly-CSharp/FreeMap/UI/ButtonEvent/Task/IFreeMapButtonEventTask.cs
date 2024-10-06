// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.Task.IFreeMapButtonEventTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ButtonEvent.Task
{
  [Token(Token = "0x200172A")]
  public interface IFreeMapButtonEventTask
  {
    [Token(Token = "0x600830C")]
    void Execute();

    [Token(Token = "0x600830D")]
    void Update();

    [Token(Token = "0x600830E")]
    bool IsBusy();
  }
}
