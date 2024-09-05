// Decompiled with JetBrains decompiler
// Type: CommonOptionChatFixedPhraseItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000296")]
public class CommonOptionChatFixedPhraseItem : MonoBehaviour
{
  [Token(Token = "0x4000F40")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private InputField phraseInput;
  [Token(Token = "0x4000F41")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Button okBtn;
  [Token(Token = "0x4000F42")]
  [FieldOffset(Offset = "0x28")]
  private Action OnFixedPhraseSettingFinnish;
  [Token(Token = "0x4000F43")]
  [FieldOffset(Offset = "0x30")]
  private int slot;
  [Token(Token = "0x4000F44")]
  [FieldOffset(Offset = "0x38")]
  private string content;

  [Token(Token = "0x600100C")]
  [Address(RVA = "0x1BE4CA8", Offset = "0x1BE4CA8", VA = "0x1BE4CA8")]
  private void Awake()
  {
  }

  [Token(Token = "0x600100D")]
  [Address(RVA = "0x1BE457C", Offset = "0x1BE457C", VA = "0x1BE457C")]
  public void SetData(PlayerChatPhraseType phraseType)
  {
  }

  [Token(Token = "0x600100E")]
  [Address(RVA = "0x1BE4D54", Offset = "0x1BE4D54", VA = "0x1BE4D54")]
  public IEnumerator RequestChatLogList() => (IEnumerator) null;

  [Token(Token = "0x600100F")]
  [Address(RVA = "0x1BE4DE4", Offset = "0x1BE4DE4", VA = "0x1BE4DE4")]
  public void SetCallBack(Action act)
  {
  }

  [Token(Token = "0x6001010")]
  [Address(RVA = "0x1BE4DEC", Offset = "0x1BE4DEC", VA = "0x1BE4DEC")]
  public CommonOptionChatFixedPhraseItem()
  {
  }
}
