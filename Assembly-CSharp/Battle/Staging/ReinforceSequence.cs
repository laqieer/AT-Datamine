// Decompiled with JetBrains decompiler
// Type: Battle.Staging.ReinforceSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200258B")]
  public class ReinforceSequence : MoveGridSequence
  {
    [Token(Token = "0x400A16A")]
    [FieldOffset(Offset = "0x59")]
    private bool isMoveCompleted;
    [Token(Token = "0x400A16B")]
    [FieldOffset(Offset = "0x5A")]
    private bool isEffectPlaying;
    [Token(Token = "0x400A16C")]
    private const float UnitDisplayTime = 0.25f;
    [Token(Token = "0x400A16D")]
    [FieldOffset(Offset = "0x5C")]
    private float deltaCount;
    [Token(Token = "0x400A16E")]
    [FieldOffset(Offset = "0x60")]
    private bool unitDisplayEventFinish;

    [Token(Token = "0x600E7BB")]
    [Address(RVA = "0x4C38D70", Offset = "0x4C38D70", VA = "0x4C38D70")]
    private ReinforceSequence()
    {
    }

    [Token(Token = "0x17003198")]
    public override bool IsCompleted
    {
      [Token(Token = "0x600E7BC"), Address(RVA = "0x4C38D74", Offset = "0x4C38D74", VA = "0x4C38D74", Slot = "9")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E7BD")]
    [Address(RVA = "0x4C38D94", Offset = "0x4C38D94", VA = "0x4C38D94")]
    public static ReinforceSequence Create(
      IDirector mainDirector,
      UnitParameterData targetUnit,
      GridData startGrid,
      Stack<GridData> route)
    {
      return (ReinforceSequence) null;
    }

    [Token(Token = "0x600E7BE")]
    [Address(RVA = "0x4C38EBC", Offset = "0x4C38EBC", VA = "0x4C38EBC", Slot = "10")]
    public override void Start()
    {
    }

    [Token(Token = "0x600E7BF")]
    [Address(RVA = "0x4C39368", Offset = "0x4C39368", VA = "0x4C39368", Slot = "11")]
    public override void Step(float delta)
    {
    }
  }
}
