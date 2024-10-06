// Decompiled with JetBrains decompiler
// Type: SampleRubyTMP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
[Token(Token = "0x200035A")]
[RequireComponent(typeof (RubyTextMeshPro))]
public class SampleRubyTMP : MonoBehaviour
{
  [Token(Token = "0x40013D5")]
  [FieldOffset(Offset = "0x18")]
  public float span;
  [Token(Token = "0x40013D6")]
  [FieldOffset(Offset = "0x20")]
  private RubyTextMeshPro rubyTextMeshPro;
  [Token(Token = "0x40013D7")]
  [FieldOffset(Offset = "0x28")]
  private string[] strArray;
  [Token(Token = "0x40013D8")]
  [FieldOffset(Offset = "0x30")]
  private int strIndex;

  [Token(Token = "0x600134C")]
  [Address(RVA = "0x2868970", Offset = "0x2868970", VA = "0x2868970")]
  private void Start()
  {
  }

  [Token(Token = "0x600134D")]
  [Address(RVA = "0x28689D4", Offset = "0x28689D4", VA = "0x28689D4")]
  private IEnumerator TimeUpdate() => (IEnumerator) null;

  [Token(Token = "0x600134E")]
  [Address(RVA = "0x2868A64", Offset = "0x2868A64", VA = "0x2868A64")]
  private void UpdateText()
  {
  }

  [Token(Token = "0x600134F")]
  [Address(RVA = "0x2868AD0", Offset = "0x2868AD0", VA = "0x2868AD0")]
  public SampleRubyTMP()
  {
  }
}
