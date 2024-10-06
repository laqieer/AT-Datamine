// Decompiled with JetBrains decompiler
// Type: Battle.Staging.DyingAttentionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025AB")]
  public sealed class DyingAttentionSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1FE")]
    [FieldOffset(Offset = "0x10")]
    private IDirector mainDirector;
    [Token(Token = "0x400A1FF")]
    [FieldOffset(Offset = "0x18")]
    private UnitParameterData target;
    [Token(Token = "0x400A200")]
    [FieldOffset(Offset = "0x20")]
    private bool enableLost;
    [Token(Token = "0x400A201")]
    [FieldOffset(Offset = "0x21")]
    private bool isAutoBattlePauseUnitLost;
    [Token(Token = "0x400A202")]
    [FieldOffset(Offset = "0x28")]
    private Action onFinish;

    [Token(Token = "0x170031A9")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E892"), Address(RVA = "0x4C42714", Offset = "0x4C42714", VA = "0x4C42714", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E893"), Address(RVA = "0x4C4271C", Offset = "0x4C4271C", VA = "0x4C4271C")] private set
      {
      }
    }

    [Token(Token = "0x600E894")]
    [Address(RVA = "0x4C42728", Offset = "0x4C42728", VA = "0x4C42728")]
    private DyingAttentionSequence()
    {
    }

    [Token(Token = "0x600E895")]
    [Address(RVA = "0x4C42730", Offset = "0x4C42730", VA = "0x4C42730")]
    public static DyingAttentionSequence Create(
      UnitParameterData targetUnit,
      bool isAutoBattlePauseUnitLost,
      IDirector mainDirector,
      Action onFinish,
      bool enableLost)
    {
      return (DyingAttentionSequence) null;
    }

    [Token(Token = "0x600E896")]
    [Address(RVA = "0x4C427C8", Offset = "0x4C427C8", VA = "0x4C427C8", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E897")]
    [Address(RVA = "0x4C42A60", Offset = "0x4C42A60", VA = "0x4C42A60", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E898")]
    [Address(RVA = "0x4C42A30", Offset = "0x4C42A30", VA = "0x4C42A30", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E899")]
    [Address(RVA = "0x4C42A64", Offset = "0x4C42A64", VA = "0x4C42A64", Slot = "6")]
    public void Abort()
    {
    }
  }
}
