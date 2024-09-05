// Decompiled with JetBrains decompiler
// Type: Battle.Process.PlayerPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002666")]
  public class PlayerPhase : BattlePhaseBase, IProcessOwner<PhaseStepCode>
  {
    [Token(Token = "0x400A4B6")]
    [FieldOffset(Offset = "0x28")]
    private BattlePhaseStepBase currentPhaseStep;
    [Token(Token = "0x400A4B7")]
    [FieldOffset(Offset = "0x30")]
    private PhaseStepCode nextPhaseStep;
    [Token(Token = "0x400A4B8")]
    [FieldOffset(Offset = "0x38")]
    private IPlayerPhaseStepFactory phaseStepFactory;

    [Token(Token = "0x600ED9B")]
    [Address(RVA = "0x449E4F0", Offset = "0x449E4F0", VA = "0x449E4F0")]
    private PlayerPhase()
    {
    }

    [Token(Token = "0x600ED9C")]
    [Address(RVA = "0x449D188", Offset = "0x449D188", VA = "0x449D188")]
    public PlayerPhase(IPlayerPhaseStepFactory phaseStepFactory)
    {
    }

    [Token(Token = "0x600ED9D")]
    [Address(RVA = "0x449E4F8", Offset = "0x449E4F8", VA = "0x449E4F8", Slot = "10")]
    public override void Initialize(IProcessOwner<PhaseCode> owner, BattleCore core)
    {
    }

    [Token(Token = "0x600ED9E")]
    [Address(RVA = "0x449E658", Offset = "0x449E658", VA = "0x449E658", Slot = "14")]
    public override void Dispose()
    {
    }

    [Token(Token = "0x600ED9F")]
    [Address(RVA = "0x449E680", Offset = "0x449E680", VA = "0x449E680", Slot = "15")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EDA0")]
    [Address(RVA = "0x449E800", Offset = "0x449E800", VA = "0x449E800", Slot = "12")]
    public override void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x600EDA1")]
    [Address(RVA = "0x449E820", Offset = "0x449E820", VA = "0x449E820", Slot = "13")]
    public override void OnApplicationPause(bool isPaused)
    {
    }

    [Token(Token = "0x600EDA2")]
    [Address(RVA = "0x449E6D4", Offset = "0x449E6D4", VA = "0x449E6D4")]
    private void ChangeNextPhaseStep()
    {
    }

    [Token(Token = "0x600EDA3")]
    [Address(RVA = "0x449E840", Offset = "0x449E840", VA = "0x449E840", Slot = "16")]
    public void OnFinishProcess(PhaseStepCode next)
    {
    }

    [Token(Token = "0x600EDA4")]
    [Address(RVA = "0x449E848", Offset = "0x449E848", VA = "0x449E848", Slot = "17")]
    public Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x600EDA5")]
    [Address(RVA = "0x449E8F4", Offset = "0x449E8F4", VA = "0x449E8F4", Slot = "18")]
    public void StopCoroutine(IEnumerator routine)
    {
    }
  }
}
