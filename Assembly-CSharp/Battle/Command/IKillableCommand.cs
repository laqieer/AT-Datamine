// Decompiled with JetBrains decompiler
// Type: Battle.Command.IKillableCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024A5")]
  public interface IKillableCommand
  {
    [Token(Token = "0x17003049")]
    List<UnitParameterData> KilledUnits { [Token(Token = "0x600E112")] get; }
  }
}
