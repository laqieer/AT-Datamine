// Decompiled with JetBrains decompiler
// Type: Battle.Staging.ViewGridSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200259A")]
  public class ViewGridSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A1BB")]
    [FieldOffset(Offset = "0x10")]
    private IDirector director;
    [Token(Token = "0x400A1BC")]
    [FieldOffset(Offset = "0x18")]
    private IGridData target;

    [Token(Token = "0x600E832")]
    [Address(RVA = "0x4C3EDA0", Offset = "0x4C3EDA0", VA = "0x4C3EDA0")]
    public static ViewGridSequence Create(IDirector director, IGridData target)
    {
      return (ViewGridSequence) null;
    }

    [Token(Token = "0x1700319F")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E833"), Address(RVA = "0x4C3EE18", Offset = "0x4C3EE18", VA = "0x4C3EE18", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E834"), Address(RVA = "0x4C3EE20", Offset = "0x4C3EE20", VA = "0x4C3EE20")] private set
      {
      }
    }

    [Token(Token = "0x600E835")]
    [Address(RVA = "0x4C3EE10", Offset = "0x4C3EE10", VA = "0x4C3EE10")]
    private ViewGridSequence()
    {
    }

    [Token(Token = "0x600E836")]
    [Address(RVA = "0x4C3EE2C", Offset = "0x4C3EE2C", VA = "0x4C3EE2C", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E837")]
    [Address(RVA = "0x4C3F0C4", Offset = "0x4C3F0C4", VA = "0x4C3F0C4", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E838")]
    [Address(RVA = "0x4C3F1F4", Offset = "0x4C3F1F4", VA = "0x4C3F1F4", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E839")]
    [Address(RVA = "0x4C3F200", Offset = "0x4C3F200", VA = "0x4C3F200", Slot = "6")]
    public void Abort()
    {
    }
  }
}
