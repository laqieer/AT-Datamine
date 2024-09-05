// Decompiled with JetBrains decompiler
// Type: UnitDetail.State.UnitDetailSubState`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitDetail.State
{
  [Token(Token = "0x20004D1")]
  public abstract class UnitDetailSubState<TStateHandler> : UnitDetailSubState where TStateHandler : UnitDetailStateHandlerBase
  {
    [Token(Token = "0x1700035A")]
    protected TStateHandler owner
    {
      [Token(Token = "0x6001B6A")] get => (TStateHandler) null;
    }

    [Token(Token = "0x6001B6B")]
    protected UnitDetailSubState()
    {
    }
  }
}
