// Decompiled with JetBrains decompiler
// Type: GameCore.Input.IBackKeyHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.Input
{
  [Token(Token = "0x2001448")]
  public interface IBackKeyHandler
  {
    [Token(Token = "0x17001176")]
    bool IsActive { [Token(Token = "0x600722D")] get; }

    [Token(Token = "0x17001177")]
    bool IsNull { [Token(Token = "0x600722E")] get; }

    [Token(Token = "0x17001178")]
    Action OnBackKeyAction { [Token(Token = "0x600722F")] get; [Token(Token = "0x6007230")] set; }

    [Token(Token = "0x6007231")]
    void HandleEvent();

    [Token(Token = "0x6007232")]
    void SetHandleEnable(bool enable);
  }
}
