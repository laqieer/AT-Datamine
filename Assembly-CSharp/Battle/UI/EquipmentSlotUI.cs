// Decompiled with JetBrains decompiler
// Type: Battle.UI.EquipmentSlotUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023A5")]
  [Serializable]
  public class EquipmentSlotUI
  {
    [Token(Token = "0x40097C3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform parent;
    [Token(Token = "0x40097C4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button emptyButton;
    [Token(Token = "0x40097C5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject unlockOnObj;
    [Token(Token = "0x40097C6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject unlockOffObj;
    [Token(Token = "0x40097C7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject select;
    [Token(Token = "0x40097C8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40097C9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image icon;
    [Token(Token = "0x40097CA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private LongPressButton button;

    [Token(Token = "0x600D9E9")]
    [Address(RVA = "0x22D3CFC", Offset = "0x22D3CFC", VA = "0x22D3CFC")]
    public void PlayGrayOut(bool isGrayOut)
    {
    }

    [Token(Token = "0x600D9EA")]
    [Address(RVA = "0x22D3D98", Offset = "0x22D3D98", VA = "0x22D3D98")]
    public void PlaySelect(bool isSelect)
    {
    }

    [Token(Token = "0x600D9EB")]
    [Address(RVA = "0x22D3D70", Offset = "0x22D3D70", VA = "0x22D3D70")]
    private void PlayTween(bool isIn, string inAnim, string outAnim, bool stop = true)
    {
    }

    [Token(Token = "0x600D9EC")]
    [Address(RVA = "0x22D3E0C", Offset = "0x22D3E0C", VA = "0x22D3E0C")]
    public EquipmentSlotUI()
    {
    }
  }
}
