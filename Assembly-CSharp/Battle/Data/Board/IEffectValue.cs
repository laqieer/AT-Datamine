// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IEffectValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200279B")]
  public interface IEffectValue
  {
    [Token(Token = "0x17003528")]
    BattleEffectValueTypeEnum ValueType { [Token(Token = "0x600F756")] get; }

    [Token(Token = "0x17003529")]
    int Value { [Token(Token = "0x600F757")] get; }
  }
}
