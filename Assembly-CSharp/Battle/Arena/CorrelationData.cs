// Decompiled with JetBrains decompiler
// Type: Battle.Arena.CorrelationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Arena
{
  [Token(Token = "0x200281D")]
  public class CorrelationData : CorrelationDataBase
  {
    [Token(Token = "0x600FC86")]
    [Address(RVA = "0x4424EE8", Offset = "0x4424EE8", VA = "0x4424EE8", Slot = "4")]
    protected override CorrelationType GenerateCorrelation(int playerId1, int playerId2)
    {
      return new CorrelationType();
    }

    [Token(Token = "0x600FC87")]
    [Address(RVA = "0x442505C", Offset = "0x442505C", VA = "0x442505C")]
    public CorrelationData()
    {
    }
  }
}
