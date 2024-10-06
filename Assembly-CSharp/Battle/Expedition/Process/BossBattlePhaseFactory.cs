// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Process.BossBattlePhaseFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Expedition.Process
{
  [Token(Token = "0x20025FF")]
  public class BossBattlePhaseFactory : IBattlePhaseFactory
  {
    [Token(Token = "0x600EA9E")]
    [Address(RVA = "0x4B94244", Offset = "0x4B94244", VA = "0x4B94244", Slot = "4")]
    public BattlePhaseBase Create(PhaseCode code, BattlePlayerData player)
    {
      return (BattlePhaseBase) null;
    }

    [Token(Token = "0x600EA9F")]
    [Address(RVA = "0x4B8A9F8", Offset = "0x4B8A9F8", VA = "0x4B8A9F8")]
    public BossBattlePhaseFactory()
    {
    }
  }
}
