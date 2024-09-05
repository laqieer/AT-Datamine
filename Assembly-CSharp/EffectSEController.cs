// Decompiled with JetBrains decompiler
// Type: EffectSEController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000198")]
public class EffectSEController : MonoBehaviour
{
  [Token(Token = "0x4000A54")]
  [FieldOffset(Offset = "0x18")]
  public string seName;
  [Token(Token = "0x4000A55")]
  [FieldOffset(Offset = "0x20")]
  public bool autoPlaySE;
  [Token(Token = "0x4000A56")]
  [FieldOffset(Offset = "0x24")]
  public float SEDelayTime;

  [Token(Token = "0x6000AD6")]
  [Address(RVA = "0x4BBC108", Offset = "0x4BBC108", VA = "0x4BBC108")]
  private void Start()
  {
  }

  [Token(Token = "0x6000AD7")]
  [Address(RVA = "0x4BBC164", Offset = "0x4BBC164", VA = "0x4BBC164")]
  private bool IsEnablePlay() => new bool();

  [Token(Token = "0x6000AD8")]
  [Address(RVA = "0x4BBC258", Offset = "0x4BBC258", VA = "0x4BBC258")]
  public void PlaySE()
  {
  }

  [Token(Token = "0x6000AD9")]
  [Address(RVA = "0x4BBC11C", Offset = "0x4BBC11C", VA = "0x4BBC11C")]
  public void PlaySE(float delayTime)
  {
  }

  [Token(Token = "0x6000ADA")]
  [Address(RVA = "0x4BBC35C", Offset = "0x4BBC35C", VA = "0x4BBC35C")]
  public IEnumerator PlaySECoroutine(float delayTime) => (IEnumerator) null;

  [Token(Token = "0x6000ADB")]
  [Address(RVA = "0x4BBC3FC", Offset = "0x4BBC3FC", VA = "0x4BBC3FC")]
  public void PlaySEWithDelay()
  {
  }

  [Token(Token = "0x6000ADC")]
  [Address(RVA = "0x4BBC404", Offset = "0x4BBC404", VA = "0x4BBC404")]
  public EffectSEController()
  {
  }
}
