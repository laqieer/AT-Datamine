// Decompiled with JetBrains decompiler
// Type: Battle.Staging.StagingDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200256A")]
  public sealed class StagingDirector : MonoBehaviour, ISubDirector<IDirector>, IStepUpdate
  {
    [Token(Token = "0x400A08F")]
    [FieldOffset(Offset = "0x18")]
    private Queue<StagingDirector.ISequence> sequences;
    [Token(Token = "0x400A090")]
    [FieldOffset(Offset = "0x20")]
    private StagingDirector.ISequence current;

    [Token(Token = "0x1700317A")]
    public bool Initialized
    {
      [Token(Token = "0x600E6AC"), Address(RVA = "0x4875DCC", Offset = "0x4875DCC", VA = "0x4875DCC", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E6AD"), Address(RVA = "0x4875DD4", Offset = "0x4875DD4", VA = "0x4875DD4")] private set
      {
      }
    }

    [Token(Token = "0x1700317B")]
    public bool IsPlaying
    {
      [Token(Token = "0x600E6AE"), Address(RVA = "0x4875DE0", Offset = "0x4875DE0", VA = "0x4875DE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E6AF")]
    [Address(RVA = "0x4875E44", Offset = "0x4875E44", VA = "0x4875E44", Slot = "5")]
    public void Initialize(IDirector mainDirector)
    {
    }

    [Token(Token = "0x600E6B0")]
    [Address(RVA = "0x4875E50", Offset = "0x4875E50", VA = "0x4875E50", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600E6B1")]
    [Address(RVA = "0x4875F1C", Offset = "0x4875F1C", VA = "0x4875F1C", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E6B2")]
    [Address(RVA = "0x4876078", Offset = "0x4876078", VA = "0x4876078", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E6B3")]
    [Address(RVA = "0x487607C", Offset = "0x487607C", VA = "0x487607C")]
    private void StepCurrentAndStartNext(float delta)
    {
    }

    [Token(Token = "0x600E6B4")]
    [Address(RVA = "0x486F604", Offset = "0x486F604", VA = "0x486F604")]
    public StagingDirector Request(StagingDirector.ISequence sequence) => (StagingDirector) null;

    [Token(Token = "0x600E6B5")]
    [Address(RVA = "0x487625C", Offset = "0x487625C", VA = "0x487625C")]
    public StagingDirector()
    {
    }

    [Token(Token = "0x200256B")]
    public interface ISequence : IStepUpdate
    {
      [Token(Token = "0x1700317C")]
      bool IsCompleted { [Token(Token = "0x600E6B6")] get; }

      [Token(Token = "0x600E6B7")]
      void Start();

      [Token(Token = "0x600E6B8")]
      void Abort();

      [Token(Token = "0x600E6B9")]
      void Complete();
    }
  }
}
