// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.ExpeditionBattleCorrelationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Expedition
{
  [Token(Token = "0x20025CE")]
  public class ExpeditionBattleCorrelationData : CorrelationDataBase
  {
    [Token(Token = "0x600E965")]
    [Address(RVA = "0x4C49D88", Offset = "0x4C49D88", VA = "0x4C49D88", Slot = "4")]
    protected override CorrelationType GenerateCorrelation(int playerId1, int playerId2)
    {
      return new CorrelationType();
    }

    [Token(Token = "0x600E966")]
    [Address(RVA = "0x4C49D98", Offset = "0x4C49D98", VA = "0x4C49D98")]
    public ExpeditionBattleCorrelationData()
    {
    }
  }
}
