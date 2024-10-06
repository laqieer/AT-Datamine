// Decompiled with JetBrains decompiler
// Type: Battle.Process.IUnitActionSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002623")]
  public interface IUnitActionSelector
  {
    [Token(Token = "0x17003244")]
    Queue<UnitCommandBase> ActionCommand { [Token(Token = "0x600EBAF")] get; }

    [Token(Token = "0x17003245")]
    CommandType CommandType { [Token(Token = "0x600EBB0")] get; }

    [Token(Token = "0x17003246")]
    UnitParameterData ActionUnit { [Token(Token = "0x600EBB1")] get; }

    [Token(Token = "0x17003247")]
    GridData PrevOwnerGrid { [Token(Token = "0x600EBB2")] get; }

    [Token(Token = "0x17003248")]
    GridData ActionTargetGrid { [Token(Token = "0x600EBB3")] get; }

    [Token(Token = "0x600EBB4")]
    void OnSelectUnit(UnitParameterData unit, GridData selectGrid);

    [Token(Token = "0x600EBB5")]
    void OnSelectGrid(GridData grid);
  }
}
