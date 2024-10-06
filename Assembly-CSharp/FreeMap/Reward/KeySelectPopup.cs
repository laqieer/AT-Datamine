// Decompiled with JetBrains decompiler
// Type: FreeMap.Reward.KeySelectPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.Reward
{
  [Token(Token = "0x2001850")]
  public class KeySelectPopup : PopupBase
  {
    [Token(Token = "0x40069FC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform itemIconParent;
    [Token(Token = "0x40069FD")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text message;
    [Token(Token = "0x40069FE")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x40069FF")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text beforeNum;
    [Token(Token = "0x4006A00")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text afterNum;
    [Token(Token = "0x4006A01")]
    [FieldOffset(Offset = "0xB0")]
    private Action OnClickPositiveAction;
    [Token(Token = "0x4006A02")]
    private const int USEITEM_COUNT = 1;

    [Token(Token = "0x600897A")]
    [Address(RVA = "0x43E52D4", Offset = "0x43E52D4", VA = "0x43E52D4")]
    public void Initialize(
      GameObject itemIconPrefab,
      ItemUtility.Parameter param,
      ChestKeyData keyData)
    {
    }

    [Token(Token = "0x600897B")]
    [Address(RVA = "0x43E5500", Offset = "0x43E5500", VA = "0x43E5500")]
    public void RegistPositiveAction(Action action)
    {
    }

    [Token(Token = "0x600897C")]
    [Address(RVA = "0x43E5508", Offset = "0x43E5508", VA = "0x43E5508")]
    public void OnClickPositive()
    {
    }

    [Token(Token = "0x600897D")]
    [Address(RVA = "0x43E5524", Offset = "0x43E5524", VA = "0x43E5524")]
    public KeySelectPopup()
    {
    }
  }
}
