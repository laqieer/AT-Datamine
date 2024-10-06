// Decompiled with JetBrains decompiler
// Type: Battle.Staging.AutoTurretRotateSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.Staging
{
  [Token(Token = "0x2002572")]
  public sealed class AutoTurretRotateSequence : StagingDirector.ISequence, IStepUpdate
  {
    [Token(Token = "0x400A0B2")]
    [FieldOffset(Offset = "0x10")]
    private Transform transform;
    [Token(Token = "0x400A0B3")]
    [FieldOffset(Offset = "0x18")]
    private Vector3 startEulerAngles;
    [Token(Token = "0x400A0B4")]
    [FieldOffset(Offset = "0x24")]
    private Vector3 endEulerAngles;
    [Token(Token = "0x400A0B5")]
    [FieldOffset(Offset = "0x30")]
    private Action onCompleted;
    [Token(Token = "0x400A0B7")]
    private const float ROTATE_DURATION = 0.5f;
    [Token(Token = "0x400A0B8")]
    [FieldOffset(Offset = "0x3C")]
    private float progress;

    [Token(Token = "0x17003180")]
    public bool IsCompleted
    {
      [Token(Token = "0x600E6E5"), Address(RVA = "0x4879294", Offset = "0x4879294", VA = "0x4879294", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E6E6"), Address(RVA = "0x487929C", Offset = "0x487929C", VA = "0x487929C")] private set
      {
      }
    }

    [Token(Token = "0x600E6E7")]
    [Address(RVA = "0x48792A8", Offset = "0x48792A8", VA = "0x48792A8")]
    private AutoTurretRotateSequence()
    {
    }

    [Token(Token = "0x600E6E8")]
    [Address(RVA = "0x48786C4", Offset = "0x48786C4", VA = "0x48786C4")]
    public static StagingDirector.ISequence Create(
      Transform transform,
      Vector3 end,
      Action onCompleted = null)
    {
      return (StagingDirector.ISequence) null;
    }

    [Token(Token = "0x600E6E9")]
    [Address(RVA = "0x48792B0", Offset = "0x48792B0", VA = "0x48792B0", Slot = "5")]
    public void Start()
    {
    }

    [Token(Token = "0x600E6EA")]
    [Address(RVA = "0x48792FC", Offset = "0x48792FC", VA = "0x48792FC", Slot = "8")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600E6EB")]
    [Address(RVA = "0x48793B4", Offset = "0x48793B4", VA = "0x48793B4", Slot = "7")]
    public void Complete()
    {
    }

    [Token(Token = "0x600E6EC")]
    [Address(RVA = "0x48793E4", Offset = "0x48793E4", VA = "0x48793E4", Slot = "6")]
    public void Abort()
    {
    }
  }
}
