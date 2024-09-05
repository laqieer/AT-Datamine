// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EffectDataUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.DuelScene;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002799")]
  public static class EffectDataUtility
  {
    [Token(Token = "0x600F74F")]
    [Address(RVA = "0x1ECFC04", Offset = "0x1ECFC04", VA = "0x1ECFC04")]
    public static EffectKey CreateKey(BattleEffectTypeEnum effectType, params int[] subParameters)
    {
      return new EffectKey();
    }

    [Token(Token = "0x600F750")]
    [Address(RVA = "0x1ED9A28", Offset = "0x1ED9A28", VA = "0x1ED9A28")]
    public static ActionType GetActionType(this EffectData self) => new ActionType();
  }
}
