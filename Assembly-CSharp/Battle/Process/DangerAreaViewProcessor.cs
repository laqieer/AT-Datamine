// Decompiled with JetBrains decompiler
// Type: Battle.Process.DangerAreaViewProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026B3")]
  public class DangerAreaViewProcessor
  {
    [Token(Token = "0x400A5F2")]
    [FieldOffset(Offset = "0x10")]
    private IDirector mainDirector;
    [Token(Token = "0x400A5F3")]
    [FieldOffset(Offset = "0x18")]
    private BoardData boardData;
    [Token(Token = "0x400A5F4")]
    [FieldOffset(Offset = "0x20")]
    private MovableAreaSearcher moveAreaSearcher;
    [Token(Token = "0x400A5F5")]
    [FieldOffset(Offset = "0x28")]
    private AttackableAreaSearcher attackAreaSearcher;
    [Token(Token = "0x400A5F6")]
    [FieldOffset(Offset = "0x30")]
    private AttackableAreaSearcher effectiveAreaSearcher;

    [Token(Token = "0x600EFAB")]
    [Address(RVA = "0x40DBB28", Offset = "0x40DBB28", VA = "0x40DBB28")]
    public DangerAreaViewProcessor(IDirector mainDirector)
    {
    }

    [Token(Token = "0x600EFAC")]
    [Address(RVA = "0x40DBB50", Offset = "0x40DBB50", VA = "0x40DBB50")]
    public void ApplyBoard(BoardData board)
    {
    }

    [Token(Token = "0x600EFAD")]
    [Address(RVA = "0x40DBB58", Offset = "0x40DBB58", VA = "0x40DBB58")]
    public void Initialize(BoardData board)
    {
    }

    [Token(Token = "0x600EFAE")]
    [Address(RVA = "0x40DBC48", Offset = "0x40DBC48", VA = "0x40DBC48")]
    public void UpdateAll()
    {
    }

    [Token(Token = "0x600EFAF")]
    [Address(RVA = "0x40DBD88", Offset = "0x40DBD88", VA = "0x40DBD88")]
    private void UpdateUserOpponentDangerArea()
    {
    }

    [Token(Token = "0x600EFB0")]
    [Address(RVA = "0x40DC9A4", Offset = "0x40DC9A4", VA = "0x40DC9A4")]
    private bool UpdateDangerArea(UnitParameterData unit) => new bool();

    [Token(Token = "0x600EFB1")]
    [Address(RVA = "0x40DC0A8", Offset = "0x40DC0A8", VA = "0x40DC0A8")]
    private void UpdateFierceArea()
    {
    }

    [Token(Token = "0x600EFB2")]
    [Address(RVA = "0x40DCE88", Offset = "0x40DCE88", VA = "0x40DCE88")]
    private void UpdateFierceArea(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EFB3")]
    [Address(RVA = "0x40DC390", Offset = "0x40DC390", VA = "0x40DC390")]
    private void UpdateAutoTurretOpponentDangerArea()
    {
    }
  }
}
