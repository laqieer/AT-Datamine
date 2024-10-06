// Decompiled with JetBrains decompiler
// Type: Routine.IMovePositionArg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Routine
{
  [Token(Token = "0x2002244")]
  public interface IMovePositionArg
  {
    [Token(Token = "0x17002D56")]
    ActionArg.ActionSettingType ActionSetting { [Token(Token = "0x600D06A")] get; }

    [Token(Token = "0x17002D57")]
    List<(int x, int y)> DestList { [Token(Token = "0x600D06B")] get; }
  }
}
