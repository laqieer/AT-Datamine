// Decompiled with JetBrains decompiler
// Type: Battle.Grid.IGridView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x2002534")]
  public interface IGridView : IGridData
  {
    [Token(Token = "0x17003155")]
    GridViewType ViewType { [Token(Token = "0x600E5D6")] get; }

    [Token(Token = "0x17003156")]
    string PrimaryDuelSceneName { [Token(Token = "0x600E5D7")] get; }

    [Token(Token = "0x17003157")]
    bool IsDanger { [Token(Token = "0x600E5D8")] get; }

    [Token(Token = "0x17003158")]
    bool IsFierce { [Token(Token = "0x600E5D9")] get; }

    [Token(Token = "0x17003159")]
    GridFierceType FierceType { [Token(Token = "0x600E5DA")] get; }

    [Token(Token = "0x1700315A")]
    AdjoiningDirection DangerAreaAdjoining { [Token(Token = "0x600E5DB")] get; }

    [Token(Token = "0x1700315B")]
    PredictionMoveParameter PredictionMoveParameter { [Token(Token = "0x600E5DC")] get; }
  }
}
