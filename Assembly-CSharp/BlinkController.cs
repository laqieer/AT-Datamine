// Decompiled with JetBrains decompiler
// Type: BlinkController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x200021D")]
public class BlinkController : MonoBehaviour
{
  [Token(Token = "0x4000C9C")]
  [FieldOffset(Offset = "0x18")]
  private FacialAnimation facialAnimation;
  [Token(Token = "0x4000C9D")]
  [FieldOffset(Offset = "0x20")]
  private float frequencyMin;
  [Token(Token = "0x4000C9E")]
  [FieldOffset(Offset = "0x24")]
  private float frequencyMax;
  [Token(Token = "0x4000C9F")]
  [FieldOffset(Offset = "0x28")]
  private float nextTime;
  [Token(Token = "0x4000CA0")]
  [FieldOffset(Offset = "0x2C")]
  private float timer;
  [Token(Token = "0x4000CA1")]
  [FieldOffset(Offset = "0x30")]
  private Coroutine coroutine;
  [Token(Token = "0x4000CA2")]
  [FieldOffset(Offset = "0x38")]
  private bool isValidBlink;

  [Token(Token = "0x6000D56")]
  [Address(RVA = "0x1C85BD4", Offset = "0x1C85BD4", VA = "0x1C85BD4")]
  public void Initialize(FacialAnimation facialAnimation)
  {
  }

  [Token(Token = "0x6000D57")]
  [Address(RVA = "0x1C85BDC", Offset = "0x1C85BDC", VA = "0x1C85BDC")]
  public void SetBlinkFrequency(float min, float max)
  {
  }

  [Token(Token = "0x6000D58")]
  [Address(RVA = "0x1C85C00", Offset = "0x1C85C00", VA = "0x1C85C00")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000D59")]
  [Address(RVA = "0x1C85C24", Offset = "0x1C85C24", VA = "0x1C85C24")]
  private void Update()
  {
  }

  [Token(Token = "0x6000D5A")]
  [Address(RVA = "0x1C85CAC", Offset = "0x1C85CAC", VA = "0x1C85CAC")]
  private IEnumerator Blink() => (IEnumerator) null;

  [Token(Token = "0x6000D5B")]
  [Address(RVA = "0x1C85D3C", Offset = "0x1C85D3C", VA = "0x1C85D3C")]
  public void Reset()
  {
  }

  [Token(Token = "0x6000D5C")]
  [Address(RVA = "0x1C85EBC", Offset = "0x1C85EBC", VA = "0x1C85EBC")]
  public void SetValidBlink(bool state)
  {
  }

  [Token(Token = "0x6000D5D")]
  [Address(RVA = "0x1C85F0C", Offset = "0x1C85F0C", VA = "0x1C85F0C")]
  private IEnumerator SingleBlink() => (IEnumerator) null;

  [Token(Token = "0x6000D5E")]
  [Address(RVA = "0x1C85F9C", Offset = "0x1C85F9C", VA = "0x1C85F9C")]
  private IEnumerator DoubleBlink() => (IEnumerator) null;

  [Token(Token = "0x6000D5F")]
  [Address(RVA = "0x1C8602C", Offset = "0x1C8602C", VA = "0x1C8602C")]
  public BlinkController()
  {
  }
}
