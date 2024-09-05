// Decompiled with JetBrains decompiler
// Type: Battle.UI.ItemListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore;
using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023E3")]
  public class ItemListItem : MonoBehaviour
  {
    [Token(Token = "0x4009937")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x4009938")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x4009939")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x400993A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text itemDiscription;
    [Token(Token = "0x400993B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image grayImage;
    [Token(Token = "0x400993C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject selectButton;
    [Token(Token = "0x400993D")]
    [FieldOffset(Offset = "0x48")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400993E")]
    [FieldOffset(Offset = "0x50")]
    public bool hasItem;

    [Token(Token = "0x17002F5B")]
    public Button Button
    {
      [Token(Token = "0x600DBF5"), Address(RVA = "0x2152B10", Offset = "0x2152B10", VA = "0x2152B10")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x600DBF6")]
    [Address(RVA = "0x2151D48", Offset = "0x2151D48", VA = "0x2151D48")]
    public void Set(ItemParameterData item)
    {
    }

    [Token(Token = "0x600DBF7")]
    [Address(RVA = "0x2152B18", Offset = "0x2152B18", VA = "0x2152B18")]
    private void SetGrayImage(IItemData item)
    {
    }

    [Token(Token = "0x600DBF8")]
    [Address(RVA = "0x2152C00", Offset = "0x2152C00", VA = "0x2152C00")]
    private string GetItemName(IItemData item) => (string) null;

    [Token(Token = "0x600DBF9")]
    [Address(RVA = "0x2152088", Offset = "0x2152088", VA = "0x2152088")]
    public void OnSelectItemButton()
    {
    }

    [Token(Token = "0x600DBFA")]
    [Address(RVA = "0x21521F4", Offset = "0x21521F4", VA = "0x21521F4")]
    public void HideSelectButton()
    {
    }

    [Token(Token = "0x600DBFB")]
    [Address(RVA = "0x2152CA0", Offset = "0x2152CA0", VA = "0x2152CA0")]
    public ItemListItem()
    {
    }
  }
}
