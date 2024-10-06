// Decompiled with JetBrains decompiler
// Type: SoulBoxForcementEffectPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000266")]
public class SoulBoxForcementEffectPopup : PopupBase
{
  [Token(Token = "0x4000E33")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private TextMeshProUGUI soulBoxBeforeStorageText;
  [Token(Token = "0x4000E34")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private Text soulBoxCurrentStorageText;
  [Token(Token = "0x4000E35")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private CommonButton closeBtn;
  [Token(Token = "0x4000E36")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private CommonButton bgBtn;
  [Token(Token = "0x4000E37")]
  [FieldOffset(Offset = "0xA8")]
  private bool isClose;

  [Token(Token = "0x6000F0A")]
  [Address(RVA = "0x1C94594", Offset = "0x1C94594", VA = "0x1C94594")]
  private void Start()
  {
  }

  [Token(Token = "0x6000F0B")]
  [Address(RVA = "0x1C94598", Offset = "0x1C94598", VA = "0x1C94598")]
  public IEnumerator Init(int boxLevel, Action action) => (IEnumerator) null;

  [Token(Token = "0x6000F0C")]
  [Address(RVA = "0x1C9463C", Offset = "0x1C9463C", VA = "0x1C9463C")]
  public SoulBoxForcementEffectPopup()
  {
  }
}
