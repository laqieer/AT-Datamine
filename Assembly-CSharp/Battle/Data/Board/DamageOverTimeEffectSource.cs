// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.DamageOverTimeEffectSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200277D")]
  public struct DamageOverTimeEffectSource
  {
    [Token(Token = "0x400A87D")]
    [FieldOffset(Offset = "0x0")]
    public EffectSource effectSource;
    [Token(Token = "0x400A87E")]
    [FieldOffset(Offset = "0x50")]
    public BattleEffectValueTypeEnum valueType;
  }
}
