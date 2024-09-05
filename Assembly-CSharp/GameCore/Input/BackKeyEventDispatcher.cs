// Decompiled with JetBrains decompiler
// Type: GameCore.Input.BackKeyEventDispatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace GameCore.Input
{
  [Token(Token = "0x2001441")]
  public class BackKeyEventDispatcher : Singleton<BackKeyEventDispatcher>
  {
    [Token(Token = "0x4005D59")]
    [FieldOffset(Offset = "0x10")]
    private List<IBackKeyHandler> backKeyEventHandlers;

    [Token(Token = "0x6007214")]
    [Address(RVA = "0x404CF40", Offset = "0x404CF40", VA = "0x404CF40")]
    public void MoveToFirst(IBackKeyHandler handler)
    {
    }

    [Token(Token = "0x6007215")]
    [Address(RVA = "0x404CFE0", Offset = "0x404CFE0", VA = "0x404CFE0")]
    public void AddBackKeyHandler(IBackKeyHandler handler)
    {
    }

    [Token(Token = "0x6007216")]
    [Address(RVA = "0x404D074", Offset = "0x404D074", VA = "0x404D074")]
    public void RemoveBackKeyHandler(IBackKeyHandler handler)
    {
    }

    [Token(Token = "0x6007217")]
    [Address(RVA = "0x404D0CC", Offset = "0x404D0CC", VA = "0x404D0CC")]
    public bool ProcessBackKeyEvent() => new bool();

    [Token(Token = "0x6007218")]
    [Address(RVA = "0x404D194", Offset = "0x404D194", VA = "0x404D194")]
    private bool IsEnableBackKey() => new bool();

    [Token(Token = "0x6007219")]
    [Address(RVA = "0x404D3B4", Offset = "0x404D3B4", VA = "0x404D3B4")]
    private void RemoveInvalidBackKeyHandlers()
    {
    }

    [Token(Token = "0x600721A")]
    [Address(RVA = "0x404D4F0", Offset = "0x404D4F0", VA = "0x404D4F0")]
    private IBackKeyHandler GetFirstActiveBackKeyHandler() => (IBackKeyHandler) null;

    [Token(Token = "0x600721B")]
    [Address(RVA = "0x404D5EC", Offset = "0x404D5EC", VA = "0x404D5EC")]
    public BackKeyEventDispatcher()
    {
    }
  }
}
