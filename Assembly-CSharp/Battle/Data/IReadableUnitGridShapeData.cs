// Decompiled with JetBrains decompiler
// Type: Battle.Data.IReadableUnitGridShapeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002744")]
  public interface IReadableUnitGridShapeData
  {
    [Token(Token = "0x17003444")]
    int Id { [Token(Token = "0x600F4AE")] get; }

    [Token(Token = "0x17003445")]
    UnitGridShapeTypeEnum Shape { [Token(Token = "0x600F4AF")] get; }

    [Token(Token = "0x17003446")]
    int ShapeSize { [Token(Token = "0x600F4B0")] get; }

    [Token(Token = "0x17003447")]
    IReadOnlyList<(int x, int y)> GridList { [Token(Token = "0x600F4B1")] get; }

    [Token(Token = "0x600F4B2")]
    int FindIndexByDistance(int x, int y);
  }
}
