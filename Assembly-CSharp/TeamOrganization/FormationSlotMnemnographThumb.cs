// Decompiled with JetBrains decompiler
// Type: TeamOrganization.FormationSlotMnemnographThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200081F")]
  public class FormationSlotMnemnographThumb : MonoBehaviour, IFormationSlotEquipmentThumb
  {
    [Token(Token = "0x4002684")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image iconImage;
    [Token(Token = "0x4002685")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x4002686")]
    [FieldOffset(Offset = "0x28")]
    private Action onClick;
    [Token(Token = "0x4002687")]
    [FieldOffset(Offset = "0x30")]
    private Action onLongPress;
    [Token(Token = "0x4002688")]
    [FieldOffset(Offset = "0x38")]
    private EquipmentSlotThumbModel model;
    [Token(Token = "0x4002689")]
    [FieldOffset(Offset = "0x40")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6002E9C")]
    [Address(RVA = "0x3E6682C", Offset = "0x3E6682C", VA = "0x3E6682C", Slot = "4")]
    public void Initialize(
      CommonButton button,
      CommonButton lockButton,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E9D")]
    [Address(RVA = "0x3E668D0", Offset = "0x3E668D0", VA = "0x3E668D0", Slot = "5")]
    public void SetAction(Action onClick = null, Action onLongPress = null)
    {
    }

    [Token(Token = "0x6002E9E")]
    [Address(RVA = "0x3E67264", Offset = "0x3E67264", VA = "0x3E67264", Slot = "6")]
    public void UpdateView(EquipmentSlotThumbModel model)
    {
    }

    [Token(Token = "0x6002E9F")]
    [Address(RVA = "0x3E672A0", Offset = "0x3E672A0", VA = "0x3E672A0")]
    private void Empty()
    {
    }

    [Token(Token = "0x6002EA0")]
    [Address(RVA = "0x3E672C4", Offset = "0x3E672C4", VA = "0x3E672C4")]
    private void Default()
    {
    }

    [Token(Token = "0x6002EA1")]
    [Address(RVA = "0x3E674C0", Offset = "0x3E674C0", VA = "0x3E674C0")]
    public FormationSlotMnemnographThumb()
    {
    }
  }
}
