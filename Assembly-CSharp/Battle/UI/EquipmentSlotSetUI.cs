// Decompiled with JetBrains decompiler
// Type: Battle.UI.EquipmentSlotSetUI
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
  [Token(Token = "0x20023A4")]
  [Serializable]
  public class EquipmentSlotSetUI
  {
    [Token(Token = "0x40097B7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform[] equipmentWeaponSlotParents;
    [Token(Token = "0x40097B8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform equipmentAccessoriesSlotParent;
    [Token(Token = "0x40097B9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform equipmentTrustSlotParent;
    [Token(Token = "0x40097BA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform euqipmentMnemnographSlotParent;
    [Token(Token = "0x40097BB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button[] equipmentWeaponSlotButtons;
    [Token(Token = "0x40097BC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button equipmentAccessoriesSlotButton;
    [Token(Token = "0x40097BD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button equipmentTrustSlotButton;
    [Token(Token = "0x40097BE")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button equipmentMnemnographSlotButton;
    [Token(Token = "0x40097BF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject[] equipmentAttentionIconObjs;
    [Token(Token = "0x40097C0")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject[] equipmentUnlockOnObjs;
    [Token(Token = "0x40097C1")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject[] equipmentUnlockOffObjs;
    [Token(Token = "0x40097C2")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject[] selectObjs;

    [Token(Token = "0x600D9E8")]
    [Address(RVA = "0x22D3CF4", Offset = "0x22D3CF4", VA = "0x22D3CF4")]
    public EquipmentSlotSetUI()
    {
    }
  }
}
