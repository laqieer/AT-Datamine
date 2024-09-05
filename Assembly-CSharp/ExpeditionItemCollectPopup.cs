// Decompiled with JetBrains decompiler
// Type: ExpeditionItemCollectPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000261")]
public class ExpeditionItemCollectPopup : PopupBase
{
  [Token(Token = "0x4000E1A")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private Text blueSoulText;
  [Token(Token = "0x4000E1B")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private Text redSoulText;
  [Token(Token = "0x4000E1C")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private GameObject itemIcon;
  [Token(Token = "0x4000E1D")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private Transform parent;
  [Token(Token = "0x4000E1E")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  private GameObject scrollView;
  [Token(Token = "0x4000E1F")]
  [FieldOffset(Offset = "0xB0")]
  private List<int> itemList;
  [Token(Token = "0x4000E20")]
  [FieldOffset(Offset = "0xB8")]
  private Action styleExpAction;
  [Token(Token = "0x4000E21")]
  [FieldOffset(Offset = "0xC0")]
  private bool isPlayStyleExpPopup;

  [Token(Token = "0x6000EF3")]
  [Address(RVA = "0x1C93AD8", Offset = "0x1C93AD8", VA = "0x1C93AD8")]
  private void Start()
  {
  }

  [Token(Token = "0x6000EF4")]
  [Address(RVA = "0x1C93ADC", Offset = "0x1C93ADC", VA = "0x1C93ADC")]
  public void SetData(
    int blueSoul,
    int redSoul,
    List<int> boxItems,
    bool isPlayStyleExpPopup,
    Action styleExpAction)
  {
  }

  [Token(Token = "0x6000EF5")]
  [Address(RVA = "0x1C93B84", Offset = "0x1C93B84", VA = "0x1C93B84")]
  private void SetGetItem()
  {
  }

  [Token(Token = "0x6000EF6")]
  [Address(RVA = "0x1C93E90", Offset = "0x1C93E90", VA = "0x1C93E90")]
  public void OnTapNext()
  {
  }

  [Token(Token = "0x6000EF7")]
  [Address(RVA = "0x1C93F50", Offset = "0x1C93F50", VA = "0x1C93F50")]
  public void Back()
  {
  }

  [Token(Token = "0x6000EF8")]
  [Address(RVA = "0x1C93F60", Offset = "0x1C93F60", VA = "0x1C93F60")]
  public ExpeditionItemCollectPopup()
  {
  }
}
