// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.PhaseBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001806")]
  public abstract class PhaseBase
  {
    [Token(Token = "0x4006936")]
    [FieldOffset(Offset = "0x10")]
    private Action<PhaseBase> NextPhaseMethodOnce;

    [Token(Token = "0x60087ED")]
    [Address(RVA = "0x43D8BC4", Offset = "0x43D8BC4", VA = "0x43D8BC4")]
    private void InernalOwnerEnter()
    {
    }

    [Token(Token = "0x60087EE")]
    [Address(RVA = "0x43D8BD0", Offset = "0x43D8BD0", VA = "0x43D8BD0", Slot = "4")]
    protected virtual void OnEnter()
    {
    }

    [Token(Token = "0x60087EF")]
    [Address(RVA = "0x43D8BD4", Offset = "0x43D8BD4", VA = "0x43D8BD4")]
    private void InernalOwnerUpdate()
    {
    }

    [Token(Token = "0x60087F0")]
    [Address(RVA = "0x43D8BEC", Offset = "0x43D8BEC", VA = "0x43D8BEC", Slot = "5")]
    protected virtual void OnUpdate()
    {
    }

    [Token(Token = "0x60087F1")]
    [Address(RVA = "0x43D8BF0", Offset = "0x43D8BF0", VA = "0x43D8BF0")]
    private void InernalOwnerEnd()
    {
    }

    [Token(Token = "0x60087F2")]
    [Address(RVA = "0x43D8C00", Offset = "0x43D8C00", VA = "0x43D8C00", Slot = "6")]
    protected virtual void OnEnd()
    {
    }

    [Token(Token = "0x60087F3")]
    [Address(RVA = "0x43D8C04", Offset = "0x43D8C04", VA = "0x43D8C04")]
    protected void NextPhase(PhaseBase Phase)
    {
    }

    [Token(Token = "0x60087F4")]
    [Address(RVA = "0x43D8C24", Offset = "0x43D8C24", VA = "0x43D8C24")]
    private void SetNextActionMethod(Action<PhaseBase> action)
    {
    }

    [Token(Token = "0x60087F5")]
    [Address(RVA = "0x43D8C2C", Offset = "0x43D8C2C", VA = "0x43D8C2C")]
    protected PhaseBase()
    {
    }

    [Token(Token = "0x2001807")]
    public class PhaseUpdater
    {
      [Token(Token = "0x4006937")]
      [FieldOffset(Offset = "0x10")]
      private PhaseBase nowPhase;
      [Token(Token = "0x4006938")]
      [FieldOffset(Offset = "0x18")]
      private PhaseBase nextPhase;

      [Token(Token = "0x60087F6")]
      [Address(RVA = "0x43D8C34", Offset = "0x43D8C34", VA = "0x43D8C34")]
      public PhaseUpdater(PhaseBase firstPhase)
      {
      }

      [Token(Token = "0x60087F7")]
      [Address(RVA = "0x43D8A54", Offset = "0x43D8A54", VA = "0x43D8A54")]
      public void Update()
      {
      }

      [Token(Token = "0x60087F8")]
      [Address(RVA = "0x43D8C5C", Offset = "0x43D8C5C", VA = "0x43D8C5C")]
      private void NextPhase(PhaseBase phase)
      {
      }

      [Token(Token = "0x60087F9")]
      public bool PhaseIs<T>() where T : PhaseBase => new bool();
    }
  }
}
