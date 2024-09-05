// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.MovableMobAnchor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Data;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Area.MovableMob
{
  [Token(Token = "0x2002824")]
  public class MovableMobAnchor : IMovableMobAnchor
  {
    [Token(Token = "0x400AB3F")]
    [FieldOffset(Offset = "0x10")]
    private IMovableMobAnchorData anchorData;
    [Token(Token = "0x400AB40")]
    [FieldOffset(Offset = "0x18")]
    private IMovableMobAnchor nextAnchor;
    [Token(Token = "0x400AB41")]
    [FieldOffset(Offset = "0x20")]
    private float nextAnchorDistance;

    [Token(Token = "0x17003785")]
    public Vector3 AnchorPosition
    {
      [Token(Token = "0x600FCA4"), Address(RVA = "0x4425688", Offset = "0x4425688", VA = "0x4425688", Slot = "4")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17003786")]
    public IMovableMobAnchor NextAnchor
    {
      [Token(Token = "0x600FCA5"), Address(RVA = "0x442572C", Offset = "0x442572C", VA = "0x442572C", Slot = "6")] get
      {
        return (IMovableMobAnchor) null;
      }
    }

    [Token(Token = "0x17003787")]
    public bool IsGoal
    {
      [Token(Token = "0x600FCA6"), Address(RVA = "0x4425734", Offset = "0x4425734", VA = "0x4425734", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003788")]
    public float NextAnchorDistance
    {
      [Token(Token = "0x600FCA7"), Address(RVA = "0x4425744", Offset = "0x4425744", VA = "0x4425744", Slot = "7")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17003789")]
    public float FadeRadius
    {
      [Token(Token = "0x600FCA8"), Address(RVA = "0x442574C", Offset = "0x442574C", VA = "0x442574C", Slot = "8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600FCA9")]
    [Address(RVA = "0x44257F0", Offset = "0x44257F0", VA = "0x44257F0")]
    public MovableMobAnchor(IMovableMobAnchorData anchorData)
    {
    }

    [Token(Token = "0x600FCAA")]
    [Address(RVA = "0x4425818", Offset = "0x4425818", VA = "0x4425818", Slot = "10")]
    public void SetNextAnchor(IMovableMobAnchor nextAnchor)
    {
    }

    [Token(Token = "0x600FCAB")]
    [Address(RVA = "0x44259D0", Offset = "0x44259D0", VA = "0x44259D0", Slot = "9")]
    public Vector3 GetNextPosition(float ratio) => new Vector3();
  }
}
