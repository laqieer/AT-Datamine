// Decompiled with JetBrains decompiler
// Type: TitleTrackingPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002B5")]
public class TitleTrackingPopup : PopupBase
{
  [Token(Token = "0x4000FF3")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private CommonButton closeButton;

  [Token(Token = "0x60010EF")]
  [Address(RVA = "0x1BEBB08", Offset = "0x1BEBB08", VA = "0x1BEBB08")]
  public IEnumerator InitaializeAsync(Action close) => (IEnumerator) null;

  [Token(Token = "0x60010F0")]
  [Address(RVA = "0x1BEBBA4", Offset = "0x1BEBBA4", VA = "0x1BEBBA4")]
  public TitleTrackingPopup()
  {
  }
}
