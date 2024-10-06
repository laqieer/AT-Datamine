// Decompiled with JetBrains decompiler
// Type: Battle.Staging.WaitWhileSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x20025BA")]
  public sealed class WaitWhileSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A24F")]
    [FieldOffset(Offset = "0x18")]
    private Func<bool> onStep;
    [Token(Token = "0x400A250")]
    [FieldOffset(Offset = "0x20")]
    private Action onCompleted;

    [Token(Token = "0x600E8EA")]
    [Address(RVA = "0x4C3C904", Offset = "0x4C3C904", VA = "0x4C3C904")]
    public static WaitWhileSequence Create(Func<bool> onStep, Action onCompleted)
    {
      return (WaitWhileSequence) null;
    }

    [Token(Token = "0x170031B4")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E8EB"), Address(RVA = "0x4C46260", Offset = "0x4C46260", VA = "0x4C46260", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E8EC"), Address(RVA = "0x4C46268", Offset = "0x4C46268", VA = "0x4C46268")] private set
      {
      }
    }

    [Token(Token = "0x600E8ED")]
    [Address(RVA = "0x4C46234", Offset = "0x4C46234", VA = "0x4C46234")]
    private WaitWhileSequence(Func<bool> onStep, Action onCompleted)
    {
    }

    [Token(Token = "0x600E8EE")]
    [Address(RVA = "0x4C46274", Offset = "0x4C46274", VA = "0x4C46274", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E8EF")]
    [Address(RVA = "0x4C46278", Offset = "0x4C46278", VA = "0x4C46278", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E8F0")]
    [Address(RVA = "0x4C462C4", Offset = "0x4C462C4", VA = "0x4C462C4", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E8F1")]
    [Address(RVA = "0x4C462F4", Offset = "0x4C462F4", VA = "0x4C462F4", Slot = "6")]
    public void Abort()
    {
    }
  }
}
