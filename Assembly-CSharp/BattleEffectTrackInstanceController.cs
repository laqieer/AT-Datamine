// Decompiled with JetBrains decompiler
// Type: BattleEffectTrackInstanceController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001B7")]
[ExecuteInEditMode]
public class BattleEffectTrackInstanceController : MonoBehaviour
{
  [Token(Token = "0x4000A96")]
  [FieldOffset(Offset = "0x18")]
  private GameObject target;
  [Token(Token = "0x4000A97")]
  [FieldOffset(Offset = "0x20")]
  private Coroutine hideWithDelayCoroutine;

  [Token(Token = "0x6000B57")]
  [Address(RVA = "0x4BC8990", Offset = "0x4BC8990", VA = "0x4BC8990")]
  public void Show()
  {
  }

  [Token(Token = "0x6000B58")]
  [Address(RVA = "0x4BC89F0", Offset = "0x4BC89F0", VA = "0x4BC89F0")]
  public void HideWithDelay(float delayTime)
  {
  }

  [Token(Token = "0x6000B59")]
  [Address(RVA = "0x4BC8A40", Offset = "0x4BC8A40", VA = "0x4BC8A40")]
  private IEnumerator HideWithDelayCoroutine(float delayTime) => (IEnumerator) null;

  [Token(Token = "0x6000B5A")]
  [Address(RVA = "0x4BC89DC", Offset = "0x4BC89DC", VA = "0x4BC89DC")]
  public void StopHideCoutine()
  {
  }

  [Token(Token = "0x6000B5B")]
  [Address(RVA = "0x4BC8AE0", Offset = "0x4BC8AE0", VA = "0x4BC8AE0")]
  public static BattleEffectTrackInstanceController GetBattleEffectTimelineInstanceRecycler(
    GameObject target)
  {
    return (BattleEffectTrackInstanceController) null;
  }

  [Token(Token = "0x6000B5C")]
  [Address(RVA = "0x4BC8CDC", Offset = "0x4BC8CDC", VA = "0x4BC8CDC")]
  private void SetTarget(GameObject target)
  {
  }

  [Token(Token = "0x6000B5D")]
  [Address(RVA = "0x4BC8CE4", Offset = "0x4BC8CE4", VA = "0x4BC8CE4")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000B5E")]
  [Address(RVA = "0x4BC8D88", Offset = "0x4BC8D88", VA = "0x4BC8D88")]
  public BattleEffectTrackInstanceController()
  {
  }
}
