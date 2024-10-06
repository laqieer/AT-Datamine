// Decompiled with JetBrains decompiler
// Type: Battle.Logic.NoDuelActionLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.DuelScene;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024E0")]
  public class NoDuelActionLogic : ActionLogicBase
  {
    [Token(Token = "0x170030B1")]
    public bool AnyHit
    {
      [Token(Token = "0x600E349"), Address(RVA = "0x402785C", Offset = "0x402785C", VA = "0x402785C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E34A"), Address(RVA = "0x4027864", Offset = "0x4027864", VA = "0x4027864")] private set
      {
      }
    }

    [Token(Token = "0x600E34B")]
    [Address(RVA = "0x4027870", Offset = "0x4027870", VA = "0x4027870")]
    public NoDuelActionLogic(
      ActionContext context,
      Team activatorTeam,
      TargetPair mainDefUnitPair,
      List<TargetPair> defUnits)
    {
    }

    [Token(Token = "0x600E34C")]
    [Address(RVA = "0x4027900", Offset = "0x4027900", VA = "0x4027900", Slot = "4")]
    public override DuelData Execute() => (DuelData) null;

    [Token(Token = "0x600E34D")]
    [Address(RVA = "0x4027A7C", Offset = "0x4027A7C", VA = "0x4027A7C", Slot = "5")]
    public override DuelData ExecutePreEffect() => (DuelData) null;

    [Token(Token = "0x600E34E")]
    [Address(RVA = "0x4027BF8", Offset = "0x4027BF8", VA = "0x4027BF8", Slot = "6")]
    public override DuelData ExecutePostEffect() => (DuelData) null;

    [Token(Token = "0x600E34F")]
    [Address(RVA = "0x4027D4C", Offset = "0x4027D4C", VA = "0x4027D4C", Slot = "7")]
    protected override void SolveActiveSkillLogic(ActiveSkillLogic logic)
    {
    }
  }
}
