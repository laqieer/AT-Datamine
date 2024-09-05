// Decompiled with JetBrains decompiler
// Type: ADV2.PsBattleAdv.PsBattleAdvMainProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Process;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace ADV2.PsBattleAdv
{
  [Token(Token = "0x2003E79")]
  public sealed class PsBattleAdvMainProcess : BattleProcessBase
  {
    [Token(Token = "0x601924E")]
    [Address(RVA = "0x2CFA0BC", Offset = "0x2CFA0BC", VA = "0x2CFA0BC", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x601924F")]
    [Address(RVA = "0x2CFA178", Offset = "0x2CFA178", VA = "0x2CFA178")]
    public Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x6019250")]
    [Address(RVA = "0x2CFA224", Offset = "0x2CFA224", VA = "0x2CFA224")]
    public void StopCoroutine(IEnumerator routine)
    {
    }

    [Token(Token = "0x6019251")]
    [Address(RVA = "0x2CFA2D0", Offset = "0x2CFA2D0", VA = "0x2CFA2D0")]
    public PsBattleAdvMainProcess()
    {
    }
  }
}
