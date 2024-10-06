// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IBattlePlayerDataHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002757")]
  public interface IBattlePlayerDataHandler
  {
    [Token(Token = "0x600F58D")]
    bool TryGetBattlePlayer(int id, out BattlePlayerData player);

    [Token(Token = "0x600F58E")]
    bool RegisterBattlePlayer(BattlePlayerData player);
  }
}
