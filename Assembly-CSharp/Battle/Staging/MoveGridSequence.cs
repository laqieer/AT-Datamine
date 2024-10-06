// Decompiled with JetBrains decompiler
// Type: Battle.Staging.MoveGridSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Unit;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x200258A")]
  public class MoveGridSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A15D")]
    [FieldOffset(Offset = "0x10")]
    protected IDirector mainDirector;
    [Token(Token = "0x400A15E")]
    [FieldOffset(Offset = "0x18")]
    protected UnitParameterData targetUnit;
    [Token(Token = "0x400A15F")]
    [FieldOffset(Offset = "0x20")]
    protected UnitParameterData copyUnit;
    [Token(Token = "0x400A160")]
    [FieldOffset(Offset = "0x28")]
    protected CharacterActor targetActor;
    [Token(Token = "0x400A161")]
    [FieldOffset(Offset = "0x30")]
    protected CharacterActor doubledActor;
    [Token(Token = "0x400A162")]
    [FieldOffset(Offset = "0x38")]
    protected Stack<GridData> routeGrids;
    [Token(Token = "0x400A163")]
    [FieldOffset(Offset = "0x40")]
    protected GridData prevGrid;
    [Token(Token = "0x400A164")]
    [FieldOffset(Offset = "0x48")]
    protected Vector3Curve curve;
    [Token(Token = "0x400A165")]
    [FieldOffset(Offset = "0x50")]
    protected bool resetDir;
    [Token(Token = "0x400A166")]
    [FieldOffset(Offset = "0x51")]
    protected bool isUpdatePos;
    [Token(Token = "0x400A167")]
    [FieldOffset(Offset = "0x52")]
    private bool isCameraMove;
    [Token(Token = "0x400A168")]
    [FieldOffset(Offset = "0x54")]
    protected float speedMutiplier;

    [Token(Token = "0x17003197")]
    public virtual bool IsCompleted
    {
      [Token(Token = "0x600E7B1"), Address(RVA = "0x4C38044", Offset = "0x4C38044", VA = "0x4C38044", Slot = "9")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E7B2"), Address(RVA = "0x4C3804C", Offset = "0x4C3804C", VA = "0x4C3804C")] private set
      {
      }
    }

    [Token(Token = "0x600E7B3")]
    [Address(RVA = "0x4C38058", Offset = "0x4C38058", VA = "0x4C38058")]
    protected MoveGridSequence()
    {
    }

    [Token(Token = "0x600E7B4")]
    [Address(RVA = "0x4C380D0", Offset = "0x4C380D0", VA = "0x4C380D0")]
    public static MoveGridSequence Create(
      IDirector mainDirector,
      UnitParameterData targetUnit,
      GridData startGrid,
      Stack<GridData> route,
      bool resetDir = true,
      bool isUpdatePos = true,
      bool isCameraMove = false)
    {
      return (MoveGridSequence) null;
    }

    [Token(Token = "0x600E7B5")]
    [Address(RVA = "0x4C3822C", Offset = "0x4C3822C", VA = "0x4C3822C", Slot = "10")]
    public virtual void Start()
    {
    }

    [Token(Token = "0x600E7B6")]
    [Address(RVA = "0x4C38744", Offset = "0x4C38744", VA = "0x4C38744", Slot = "11")]
    public virtual void Step(float delta)
    {
    }

    [Token(Token = "0x600E7B7")]
    [Address(RVA = "0x4C38394", Offset = "0x4C38394", VA = "0x4C38394")]
    protected void MoveToNextGrid(GridData nextGrid)
    {
    }

    [Token(Token = "0x600E7B8")]
    [Address(RVA = "0x4C389CC", Offset = "0x4C389CC", VA = "0x4C389CC", Slot = "12")]
    public virtual void Complete()
    {
    }

    [Token(Token = "0x600E7B9")]
    [Address(RVA = "0x4C38D6C", Offset = "0x4C38D6C", VA = "0x4C38D6C", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E7BA")]
    [Address(RVA = "0x4C38870", Offset = "0x4C38870", VA = "0x4C38870")]
    private void PlayFootStepSe()
    {
    }
  }
}
