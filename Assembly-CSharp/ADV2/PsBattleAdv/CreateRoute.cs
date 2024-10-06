// Decompiled with JetBrains decompiler
// Type: ADV2.PsBattleAdv.CreateRoute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace ADV2.PsBattleAdv
{
  [Token(Token = "0x2003E70")]
  public class CreateRoute
  {
    [Token(Token = "0x40111EF")]
    [FieldOffset(Offset = "0x10")]
    protected BattleCore core;
    [Token(Token = "0x40111F0")]
    [FieldOffset(Offset = "0x18")]
    private MovableAreaSearcher Searcher;
    [Token(Token = "0x40111F1")]
    [FieldOffset(Offset = "0x20")]
    protected GridData moveFrom;
    [Token(Token = "0x40111F2")]
    [FieldOffset(Offset = "0x28")]
    protected GridData moveTo;

    [Token(Token = "0x17005197")]
    public UnitParameterData OwnerUnit
    {
      [Token(Token = "0x6019216"), Address(RVA = "0x2CF4828", Offset = "0x2CF4828", VA = "0x2CF4828")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x6019217"), Address(RVA = "0x2CF4830", Offset = "0x2CF4830", VA = "0x2CF4830")] protected set
      {
      }
    }

    [Token(Token = "0x6019218")]
    [Address(RVA = "0x2CF4838", Offset = "0x2CF4838", VA = "0x2CF4838")]
    public CreateRoute(
      BattleCore core,
      UnitParameterData owner,
      GridData moveFrom,
      GridData moveTo)
    {
    }

    [Token(Token = "0x6019219")]
    [Address(RVA = "0x2CF487C", Offset = "0x2CF487C", VA = "0x2CF487C")]
    public Stack<GridData> CreateRouteGrids(int moveAmount) => (Stack<GridData>) null;
  }
}
