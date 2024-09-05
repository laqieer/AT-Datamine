// Decompiled with JetBrains decompiler
// Type: Battle.Staging.InteractFacilitySequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Grid;
using Battle.Unit;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002588")]
  public class InteractFacilitySequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A153")]
    [FieldOffset(Offset = "0x10")]
    private IDirector mainDirector;
    [Token(Token = "0x400A154")]
    [FieldOffset(Offset = "0x18")]
    private List<(FacilityView facility, GridObject grid, bool active)> controlInfos;
    [Token(Token = "0x400A156")]
    [FieldOffset(Offset = "0x21")]
    private bool skipFirstFrame;

    [Token(Token = "0x17003195")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E7A0"), Address(RVA = "0x4C36F9C", Offset = "0x4C36F9C", VA = "0x4C36F9C", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E7A1"), Address(RVA = "0x4C36FA4", Offset = "0x4C36FA4", VA = "0x4C36FA4")] private set
      {
      }
    }

    [Token(Token = "0x600E7A2")]
    [Address(RVA = "0x4C36FB0", Offset = "0x4C36FB0", VA = "0x4C36FB0")]
    private InteractFacilitySequence()
    {
    }

    [Token(Token = "0x600E7A3")]
    [Address(RVA = "0x4C3702C", Offset = "0x4C3702C", VA = "0x4C3702C")]
    public static InteractFacilitySequence Create(
      IDirector mainDirector,
      IReadOnlyCollection<FacilityData> facilities)
    {
      return (InteractFacilitySequence) null;
    }

    [Token(Token = "0x600E7A4")]
    [Address(RVA = "0x4C3757C", Offset = "0x4C3757C", VA = "0x4C3757C", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E7A5")]
    [Address(RVA = "0x4C3770C", Offset = "0x4C3770C", VA = "0x4C3770C", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E7A6")]
    [Address(RVA = "0x4C37888", Offset = "0x4C37888", VA = "0x4C37888", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E7A7")]
    [Address(RVA = "0x4C37A84", Offset = "0x4C37A84", VA = "0x4C37A84", Slot = "6")]
    public void Abort()
    {
    }
  }
}
