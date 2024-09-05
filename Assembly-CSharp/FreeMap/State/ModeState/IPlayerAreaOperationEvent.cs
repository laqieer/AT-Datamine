// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.IPlayerAreaOperationEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001804")]
  public interface IPlayerAreaOperationEvent
  {
    [Token(Token = "0x60087E7")]
    void FastTravel(ITransitionEvent transition, FreeMapUIParamBase targetParam);

    [Token(Token = "0x60087E8")]
    void AutoMoveToEvent(FreeMapUIParamBase target);

    [Token(Token = "0x60087E9")]
    void GotoTarget(FreeMapUIParamBase target);

    [Token(Token = "0x60087EA")]
    void ChangeAreaAndAutoMove(ITransitionEvent transition, FreeMapUIParamBase target);

    [Token(Token = "0x60087EB")]
    void OnAutoMoveFinish(FreeMapUIParamBase param);
  }
}
