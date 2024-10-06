// Decompiled with JetBrains decompiler
// Type: GameCore.Input.BackKeyHandlerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.Input
{
  [Token(Token = "0x2001449")]
  public abstract class BackKeyHandlerBase : IBackKeyHandler
  {
    [Token(Token = "0x4005D64")]
    [FieldOffset(Offset = "0x18")]
    protected bool Enable;

    [Token(Token = "0x17001179")]
    public abstract bool IsActive { [Token(Token = "0x6007233")] get; }

    [Token(Token = "0x1700117A")]
    public abstract bool IsNull { [Token(Token = "0x6007234")] get; }

    [Token(Token = "0x1700117B")]
    public Action OnBackKeyAction
    {
      [Token(Token = "0x6007235"), Address(RVA = "0x404DDF0", Offset = "0x404DDF0", VA = "0x404DDF0", Slot = "6")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6007236"), Address(RVA = "0x404DDF8", Offset = "0x404DDF8", VA = "0x404DDF8", Slot = "7")] set
      {
      }
    }

    [Token(Token = "0x6007237")]
    [Address(RVA = "0x404DE00", Offset = "0x404DE00", VA = "0x404DE00", Slot = "8")]
    public void HandleEvent()
    {
    }

    [Token(Token = "0x6007238")]
    [Address(RVA = "0x404DE1C", Offset = "0x404DE1C", VA = "0x404DE1C", Slot = "9")]
    public void SetHandleEnable(bool enable)
    {
    }

    [Token(Token = "0x6007239")]
    [Address(RVA = "0x404D978", Offset = "0x404D978", VA = "0x404D978")]
    protected BackKeyHandlerBase(Action onBackKey, bool enabled)
    {
    }
  }
}
