// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.ActionTargetResultData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x2002544")]
  public sealed class ActionTargetResultData
  {
    [Token(Token = "0x400A03E")]
    [FieldOffset(Offset = "0x10")]
    public UnitParameterData Target;
    [Token(Token = "0x400A03F")]
    [FieldOffset(Offset = "0x18")]
    public GridData Grid;
    [Token(Token = "0x400A040")]
    [FieldOffset(Offset = "0x20")]
    public bool IsHit;
    [Token(Token = "0x400A041")]
    [FieldOffset(Offset = "0x21")]
    public bool IsCritical;
    [Token(Token = "0x400A042")]
    [FieldOffset(Offset = "0x22")]
    public bool IsWeakness;
    [Token(Token = "0x400A043")]
    [FieldOffset(Offset = "0x23")]
    public bool HasResistByBarrier;
    [Token(Token = "0x400A044")]
    [FieldOffset(Offset = "0x28")]
    public UnitParameterChange BeforeParam;
    [Token(Token = "0x400A045")]
    [FieldOffset(Offset = "0x30")]
    public UnitParameterChange AfterParam;

    [Token(Token = "0x17003175")]
    public bool IsKilled
    {
      [Token(Token = "0x600E629"), Address(RVA = "0x486CE34", Offset = "0x486CE34", VA = "0x486CE34")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E62A")]
    [Address(RVA = "0x486CE7C", Offset = "0x486CE7C", VA = "0x486CE7C")]
    public ActionTargetResultData()
    {
    }
  }
}
