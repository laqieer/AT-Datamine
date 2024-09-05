// Decompiled with JetBrains decompiler
// Type: Battle.Process.IPlayerPhaseStepFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002677")]
  public interface IPlayerPhaseStepFactory
  {
    [Token(Token = "0x600EE26")]
    BattlePhaseStepBase Create(PhaseStepCode code);
  }
}
