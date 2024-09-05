// Decompiled with JetBrains decompiler
// Type: Battle.Process.IProcess`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002654")]
  public interface IProcess<TFinishCode> : IDisposable, IStepUpdate
  {
    [Token(Token = "0x1700327E")]
    bool IsActive { [Token(Token = "0x600ED5E")] get; }

    [Token(Token = "0x600ED5F")]
    void Initialize(IProcessOwner<TFinishCode> owner, BattleCore core);

    [Token(Token = "0x600ED60")]
    void OnApplicationFocus(bool hasFocus);

    [Token(Token = "0x600ED61")]
    void OnApplicationPause(bool isPaused);
  }
}
