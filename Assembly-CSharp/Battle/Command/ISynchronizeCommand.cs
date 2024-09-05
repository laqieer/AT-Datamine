// Decompiled with JetBrains decompiler
// Type: Battle.Command.ISynchronizeCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024A6")]
  public interface ISynchronizeCommand
  {
    [Token(Token = "0x600E113")]
    bool Synchronize(IEnumerable<UnitCommandBase> synchronizeCmds);
  }
}
