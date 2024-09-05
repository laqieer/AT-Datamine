// Decompiled with JetBrains decompiler
// Type: Battle.StoryBattle.StoryBattleCorrelationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.StoryBattle
{
  [Token(Token = "0x20025CC")]
  public class StoryBattleCorrelationData : CorrelationDataBase
  {
    [Token(Token = "0x600E960")]
    [Address(RVA = "0x4C4966C", Offset = "0x4C4966C", VA = "0x4C4966C", Slot = "4")]
    protected override CorrelationType GenerateCorrelation(int playerId1, int playerId2)
    {
      return new CorrelationType();
    }

    [Token(Token = "0x600E961")]
    [Address(RVA = "0x4C497E0", Offset = "0x4C497E0", VA = "0x4C497E0")]
    public StoryBattleCorrelationData()
    {
    }
  }
}
