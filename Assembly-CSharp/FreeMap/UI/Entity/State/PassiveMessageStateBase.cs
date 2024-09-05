// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.State.PassiveMessageStateBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.Entity.State
{
  [Token(Token = "0x200169D")]
  public abstract class PassiveMessageStateBase : StateMachineState<FreeMapPassiveMessageUI>
  {
    [Token(Token = "0x6007FD6")]
    [Address(RVA = "0x41F0704", Offset = "0x41F0704", VA = "0x41F0704")]
    protected void DebugLog(string message)
    {
    }

    [Token(Token = "0x6007FD7")]
    [Address(RVA = "0x41F0708", Offset = "0x41F0708", VA = "0x41F0708")]
    protected void DebugLogError(string errorMsg)
    {
    }

    [Token(Token = "0x6007FD8")]
    [Address(RVA = "0x41F070C", Offset = "0x41F070C", VA = "0x41F070C")]
    protected PassiveMessageStateBase()
    {
    }
  }
}
