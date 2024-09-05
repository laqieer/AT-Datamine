// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Prediction.ActionResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Logic.Prediction
{
  [Token(Token = "0x20024E9")]
  public sealed class ActionResult
  {
    [Token(Token = "0x4009E4E")]
    [FieldOffset(Offset = "0x20")]
    public readonly int AttackerId;
    [Token(Token = "0x4009E4F")]
    [FieldOffset(Offset = "0x28")]
    public List<int> AttackSupporterIds;
    [Token(Token = "0x4009E50")]
    [FieldOffset(Offset = "0x30")]
    public readonly int DefenderId;
    [Token(Token = "0x4009E51")]
    [FieldOffset(Offset = "0x34")]
    public readonly int SkillId;
    [Token(Token = "0x4009E52")]
    [FieldOffset(Offset = "0x38")]
    public UnitParameterChange AttackerBefore;
    [Token(Token = "0x4009E53")]
    [FieldOffset(Offset = "0x40")]
    public UnitParameterChange AttackerAfter;
    [Token(Token = "0x4009E54")]
    [FieldOffset(Offset = "0x48")]
    public List<TargetResult> TargetResults;

    [Token(Token = "0x170030BE")]
    public SkillTriggerTimingTypeEnum Trigger
    {
      [Token(Token = "0x600E37F"), Address(RVA = "0x402A874", Offset = "0x402A874", VA = "0x402A874")] get
      {
        return new SkillTriggerTimingTypeEnum();
      }
      [Token(Token = "0x600E380"), Address(RVA = "0x402A87C", Offset = "0x402A87C", VA = "0x402A87C")] private set
      {
      }
    }

    [Token(Token = "0x170030BF")]
    public List<EffectResult> Effects
    {
      [Token(Token = "0x600E381"), Address(RVA = "0x402A884", Offset = "0x402A884", VA = "0x402A884")] get
      {
        return (List<EffectResult>) null;
      }
      [Token(Token = "0x600E382"), Address(RVA = "0x402A88C", Offset = "0x402A88C", VA = "0x402A88C")] private set
      {
      }
    }

    [Token(Token = "0x170030C0")]
    public TargetResult MainTargetResult
    {
      [Token(Token = "0x600E383"), Address(RVA = "0x402A894", Offset = "0x402A894", VA = "0x402A894")] get
      {
        return (TargetResult) null;
      }
    }

    [Token(Token = "0x600E384")]
    [Address(RVA = "0x402A90C", Offset = "0x402A90C", VA = "0x402A90C")]
    public ActionResult(ActionContext context, SkillTriggerTimingTypeEnum trigger)
    {
    }

    [Token(Token = "0x600E385")]
    [Address(RVA = "0x402A4F4", Offset = "0x402A4F4", VA = "0x402A4F4")]
    public void AddEffectResult(EffectResult result)
    {
    }

    [Token(Token = "0x600E386")]
    [Address(RVA = "0x402B314", Offset = "0x402B314", VA = "0x402B314")]
    private TargetResult GetActionTargetResult(TargetPair targetPair) => (TargetResult) null;

    [Token(Token = "0x600E387")]
    [Address(RVA = "0x402B188", Offset = "0x402B188", VA = "0x402B188")]
    private TargetResult GetActionTargetResult(int unitId, int x, int y) => (TargetResult) null;
  }
}
