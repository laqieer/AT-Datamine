// Decompiled with JetBrains decompiler
// Type: UnitDetail.UnitDetailItemIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x20004A1")]
  [Serializable]
  public class UnitDetailItemIcon : UnitDetailViewBase<ItemInfoBase>
  {
    [Token(Token = "0x4001881")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject rootObject;
    [Token(Token = "0x4001882")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x4001883")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private LongPressButton longPressbutton;

    [Token(Token = "0x17000324")]
    public LongPressButton.LongPressEvent LongPressEvent
    {
      [Token(Token = "0x60019DF"), Address(RVA = "0x2C243B0", Offset = "0x2C243B0", VA = "0x2C243B0")] get
      {
        return (LongPressButton.LongPressEvent) null;
      }
    }

    [Token(Token = "0x60019E0")]
    [Address(RVA = "0x2C243CC", Offset = "0x2C243CC", VA = "0x2C243CC", Slot = "5")]
    protected override void UpdateViewImpl()
    {
    }

    [Token(Token = "0x60019E1")]
    [Address(RVA = "0x2C243D0", Offset = "0x2C243D0", VA = "0x2C243D0")]
    public void Show()
    {
    }

    [Token(Token = "0x60019E2")]
    [Address(RVA = "0x2C243F0", Offset = "0x2C243F0", VA = "0x2C243F0")]
    public void Hide()
    {
    }

    [Token(Token = "0x60019E3")]
    [Address(RVA = "0x2C24410", Offset = "0x2C24410", VA = "0x2C24410")]
    public UnitDetailItemIcon()
    {
    }
  }
}
