// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleMainProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002636")]
  public class BattleMainProcess : BattleProcessBase, IProcessOwner<PhaseCode>
  {
    [Token(Token = "0x400A434")]
    [FieldOffset(Offset = "0x28")]
    private BattlePhaseBase currentPhase;
    [Token(Token = "0x400A435")]
    [FieldOffset(Offset = "0x30")]
    private PhaseCode nextPhase;
    [Token(Token = "0x400A436")]
    [FieldOffset(Offset = "0x38")]
    private IBattlePhaseFactory battlePhaseFactory;

    [Token(Token = "0x600ECB1")]
    [Address(RVA = "0x448BED0", Offset = "0x448BED0", VA = "0x448BED0")]
    private BattleMainProcess()
    {
    }

    [Token(Token = "0x600ECB2")]
    [Address(RVA = "0x448BEE0", Offset = "0x448BEE0", VA = "0x448BEE0")]
    public BattleMainProcess(IBattlePhaseFactory battlePhaseFactory)
    {
    }

    [Token(Token = "0x600ECB3")]
    [Address(RVA = "0x448BF08", Offset = "0x448BF08", VA = "0x448BF08", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> owner, BattleCore core)
    {
    }

    [Token(Token = "0x600ECB4")]
    [Address(RVA = "0x448BF6C", Offset = "0x448BF6C", VA = "0x448BF6C", Slot = "12")]
    public override void Dispose()
    {
    }

    [Token(Token = "0x600ECB5")]
    [Address(RVA = "0x448C068", Offset = "0x448C068", VA = "0x448C068", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600ECB6")]
    [Address(RVA = "0x448C350", Offset = "0x448C350", VA = "0x448C350")]
    private void ChangeNextPhase()
    {
    }

    [Token(Token = "0x600ECB7")]
    [Address(RVA = "0x448C498", Offset = "0x448C498", VA = "0x448C498", Slot = "16")]
    public void OnFinishProcess(PhaseCode next)
    {
    }

    [Token(Token = "0x600ECB8")]
    [Address(RVA = "0x448C5CC", Offset = "0x448C5CC", VA = "0x448C5CC", Slot = "17")]
    public Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x600ECB9")]
    [Address(RVA = "0x448C678", Offset = "0x448C678", VA = "0x448C678", Slot = "18")]
    public void StopCoroutine(IEnumerator routine)
    {
    }

    [Token(Token = "0x600ECBA")]
    [Address(RVA = "0x448C724", Offset = "0x448C724", VA = "0x448C724", Slot = "14")]
    public override void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x600ECBB")]
    [Address(RVA = "0x448C740", Offset = "0x448C740", VA = "0x448C740", Slot = "15")]
    public override void OnApplicationPause(bool isPaused)
    {
    }
  }
}
