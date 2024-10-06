// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.ExpeditionBox.ExpeditionBoxItemScrollCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.ExpeditionBox
{
  [Token(Token = "0x2002CFB")]
  public class ExpeditionBoxItemScrollCell : UIScrollGridItem
  {
    [Token(Token = "0x400C0AE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400C0AF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ItemIcon icon;
    [Token(Token = "0x400C0B0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject itemNum;

    [Token(Token = "0x60119B0")]
    [Address(RVA = "0x46A6DBC", Offset = "0x46A6DBC", VA = "0x46A6DBC")]
    public void UpdateCell(PlayerExpeditionBoxType item)
    {
    }

    [Token(Token = "0x60119B1")]
    [Address(RVA = "0x46A6FEC", Offset = "0x46A6FEC", VA = "0x46A6FEC")]
    public void SetButtonAction(Action buttonAction = null)
    {
    }

    [Token(Token = "0x60119B2")]
    [Address(RVA = "0x46A70DC", Offset = "0x46A70DC", VA = "0x46A70DC")]
    public void SetLongPressAction(Action longPressAction = null)
    {
    }

    [Token(Token = "0x60119B3")]
    [Address(RVA = "0x46A71CC", Offset = "0x46A71CC", VA = "0x46A71CC")]
    public ExpeditionBoxItemScrollCell()
    {
    }
  }
}
