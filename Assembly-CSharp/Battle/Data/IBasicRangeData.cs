// Decompiled with JetBrains decompiler
// Type: Battle.Data.IBasicRangeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200270D")]
  public interface IBasicRangeData
  {
    [Token(Token = "0x17003380")]
    IReadOnlyList<(int x, int y)> ActualPositions { [Token(Token = "0x600F249")] get; }

    [Token(Token = "0x17003381")]
    IReadOnlyList<int> ActualFlags { [Token(Token = "0x600F24A")] get; }

    [Token(Token = "0x17003382")]
    int Count { [Token(Token = "0x600F24B")] get; }

    [Token(Token = "0x600F24C")]
    int GetFlagAt(int x, int y);

    [Token(Token = "0x600F24D")]
    bool HasFlagAt(int x, int y);

    [Token(Token = "0x17003383")]
    int defaultMinX { [Token(Token = "0x600F24E")] get; }

    [Token(Token = "0x17003384")]
    int defaultMaxX { [Token(Token = "0x600F24F")] get; }

    [Token(Token = "0x17003385")]
    int defaultMinY { [Token(Token = "0x600F250")] get; }

    [Token(Token = "0x17003386")]
    int defaultMaxY { [Token(Token = "0x600F251")] get; }
  }
}
