// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.PlayerPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026C9")]
  public class PlayerPhase : BattlePhaseBase, IProcessOwner<PhaseStepCode>
  {
    [Token(Token = "0x400A61E")]
    [FieldOffset(Offset = "0x28")]
    private BattlePhaseStepBase currentPhaseStep;
    [Token(Token = "0x400A61F")]
    [FieldOffset(Offset = "0x30")]
    private PhaseStepCode nextPhaseStep;
    [Token(Token = "0x400A620")]
    [FieldOffset(Offset = "0x38")]
    private IPlayerPhaseStepFactory phaseStepFactory;

    [Token(Token = "0x600F013")]
    [Address(RVA = "0x40E4118", Offset = "0x40E4118", VA = "0x40E4118")]
    private PlayerPhase()
    {
    }

    [Token(Token = "0x600F014")]
    [Address(RVA = "0x40E4120", Offset = "0x40E4120", VA = "0x40E4120")]
    public PlayerPhase(IPlayerPhaseStepFactory phaseStepFactory)
    {
    }

    [Token(Token = "0x600F015")]
    [Address(RVA = "0x40E4148", Offset = "0x40E4148", VA = "0x40E4148", Slot = "10")]
    public override void Initialize(IProcessOwner<PhaseCode> owner, BattleCore core)
    {
    }

    [Token(Token = "0x600F016")]
    [Address(RVA = "0x40E4168", Offset = "0x40E4168", VA = "0x40E4168", Slot = "14")]
    public override void Dispose()
    {
    }

    [Token(Token = "0x600F017")]
    [Address(RVA = "0x40E4194", Offset = "0x40E4194", VA = "0x40E4194", Slot = "15")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600F018")]
    [Address(RVA = "0x40E429C", Offset = "0x40E429C", VA = "0x40E429C")]
    private UnitParameterData GetNextActionUnit() => (UnitParameterData) null;

    [Token(Token = "0x600F019")]
    [Address(RVA = "0x40E4700", Offset = "0x40E4700", VA = "0x40E4700", Slot = "12")]
    public override void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x600F01A")]
    [Address(RVA = "0x40E474C", Offset = "0x40E474C", VA = "0x40E474C", Slot = "13")]
    public override void OnApplicationPause(bool isPaused)
    {
    }

    [Token(Token = "0x600F01B")]
    [Address(RVA = "0x40E45D4", Offset = "0x40E45D4", VA = "0x40E45D4")]
    private void ChangeNextPhaseStep()
    {
    }

    [Token(Token = "0x600F01C")]
    [Address(RVA = "0x40E4798", Offset = "0x40E4798", VA = "0x40E4798", Slot = "16")]
    public void OnFinishProcess(PhaseStepCode next)
    {
    }

    [Token(Token = "0x600F01D")]
    [Address(RVA = "0x40E47A0", Offset = "0x40E47A0", VA = "0x40E47A0", Slot = "17")]
    public Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x600F01E")]
    [Address(RVA = "0x40E484C", Offset = "0x40E484C", VA = "0x40E484C", Slot = "18")]
    public void StopCoroutine(IEnumerator routine)
    {
    }
  }
}
