// Decompiled with JetBrains decompiler
// Type: Battle.Process.IRollbackProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026A0")]
  public interface IRollbackProcessor : IDisposable
  {
    [Token(Token = "0x1700329F")]
    List<BoardData> BackupBoard { [Token(Token = "0x600EF3E")] get; }

    [Token(Token = "0x170032A0")]
    int RollbackCount { [Token(Token = "0x600EF3F")] get; }

    [Token(Token = "0x600EF40")]
    void BackupCurrentBoard(Queue<UnitCommandBase> executedCommand);

    [Token(Token = "0x600EF41")]
    void RollbackBoard(int index);

    [Token(Token = "0x600EF42")]
    void RollbackOne();

    [Token(Token = "0x600EF43")]
    void ApplyBoard(int index);
  }
}
