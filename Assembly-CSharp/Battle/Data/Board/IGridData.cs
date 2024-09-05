// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IGridData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027E7")]
  public interface IGridData
  {
    [Token(Token = "0x170035D8")]
    Vector2Int Coordinate { [Token(Token = "0x600F91E")] get; }

    [Token(Token = "0x170035D9")]
    float[] Heights { [Token(Token = "0x600F91F")] get; }

    [Token(Token = "0x170035DA")]
    float MaxGridHeight { [Token(Token = "0x600F920")] get; }

    [Token(Token = "0x170035DB")]
    BattleLandCorrectData LandCorrect { [Token(Token = "0x600F921")] get; }

    [Token(Token = "0x170035DC")]
    bool IsSlope { [Token(Token = "0x600F922")] get; }
  }
}
