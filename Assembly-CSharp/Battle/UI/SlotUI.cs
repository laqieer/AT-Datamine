// Decompiled with JetBrains decompiler
// Type: Battle.UI.SlotUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023A3")]
  [Serializable]
  public class SlotUI
  {
    [Token(Token = "0x40097B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject[] UnitTags;
    [Token(Token = "0x40097B1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image UnitNumber1;
    [Token(Token = "0x40097B2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image UnitNumber2;
    [Token(Token = "0x40097B3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button styleThumbButton;
    [Token(Token = "0x40097B4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform styleThumbParent;
    [Token(Token = "0x40097B5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject[] styleSlotObjs;
    [Token(Token = "0x40097B6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button styleDetailButton;

    [Token(Token = "0x600D9E7")]
    [Address(RVA = "0x22D3CEC", Offset = "0x22D3CEC", VA = "0x22D3CEC")]
    public SlotUI()
    {
    }
  }
}
