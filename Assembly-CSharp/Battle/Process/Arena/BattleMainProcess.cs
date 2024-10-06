// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.BattleMainProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026BE")]
  public class BattleMainProcess : Battle.Process.BattleMainProcess
  {
    [Token(Token = "0x170032AD")]
    private ArenaBattleConfig config
    {
      [Token(Token = "0x600EFDE"), Address(RVA = "0x40DF508", Offset = "0x40DF508", VA = "0x40DF508")] get
      {
        return (ArenaBattleConfig) null;
      }
    }

    [Token(Token = "0x600EFDF")]
    [Address(RVA = "0x40DF35C", Offset = "0x40DF35C", VA = "0x40DF35C")]
    public BattleMainProcess(IBattlePhaseFactory battlePhaseFactory)
    {
    }

    [Token(Token = "0x600EFE0")]
    [Address(RVA = "0x40DF590", Offset = "0x40DF590", VA = "0x40DF590", Slot = "13")]
    public override void Step(float delta)
    {
    }
  }
}
