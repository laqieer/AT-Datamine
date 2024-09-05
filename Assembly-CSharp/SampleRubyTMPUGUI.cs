// Decompiled with JetBrains decompiler
// Type: SampleRubyTMPUGUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
[Token(Token = "0x200035C")]
[RequireComponent(typeof (RubyTextMeshProUGUI))]
public class SampleRubyTMPUGUI : MonoBehaviour
{
  [Token(Token = "0x40013DC")]
  [FieldOffset(Offset = "0x18")]
  public float span;
  [Token(Token = "0x40013DD")]
  [FieldOffset(Offset = "0x20")]
  private RubyTextMeshProUGUI rubyTextMeshPro;
  [Token(Token = "0x40013DE")]
  [FieldOffset(Offset = "0x28")]
  private string[] strArray;
  [Token(Token = "0x40013DF")]
  [FieldOffset(Offset = "0x30")]
  private int strIndex;

  [Token(Token = "0x6001356")]
  [Address(RVA = "0x2868ED4", Offset = "0x2868ED4", VA = "0x2868ED4")]
  private void Start()
  {
  }

  [Token(Token = "0x6001357")]
  [Address(RVA = "0x2868F38", Offset = "0x2868F38", VA = "0x2868F38")]
  private IEnumerator TimeUpdate() => (IEnumerator) null;

  [Token(Token = "0x6001358")]
  [Address(RVA = "0x2868FC8", Offset = "0x2868FC8", VA = "0x2868FC8")]
  private void UpdateText()
  {
  }

  [Token(Token = "0x6001359")]
  [Address(RVA = "0x2869034", Offset = "0x2869034", VA = "0x2869034")]
  public SampleRubyTMPUGUI()
  {
  }
}
