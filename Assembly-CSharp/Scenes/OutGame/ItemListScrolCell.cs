// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ItemListScrolCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003200")]
  public class ItemListScrolCell : MonoBehaviour
  {
    [Token(Token = "0x400D593")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private LongPressButton longPressbutton;
    [Token(Token = "0x400D594")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text amountText;
    [Token(Token = "0x400D595")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text amountMaxText;
    [Token(Token = "0x400D596")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image itemIconImage;
    [Token(Token = "0x400D597")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject itemBLKFilter;
    [Token(Token = "0x400D598")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject sellObj;
    [Token(Token = "0x400D599")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text sellAmountText;
    [Token(Token = "0x400D59A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text sellPriceText;
    [Token(Token = "0x400D59B")]
    [FieldOffset(Offset = "0x58")]
    private Action<ItemListData> OnClickAction;

    [Token(Token = "0x17004113")]
    public int Index
    {
      [Token(Token = "0x601384D"), Address(RVA = "0x49BF4A8", Offset = "0x49BF4A8", VA = "0x49BF4A8")] get
      {
        return new int();
      }
      [Token(Token = "0x601384E"), Address(RVA = "0x49BF4B0", Offset = "0x49BF4B0", VA = "0x49BF4B0")] private set
      {
      }
    }

    [Token(Token = "0x17004114")]
    public ItemListData Data
    {
      [Token(Token = "0x601384F"), Address(RVA = "0x49BF4B8", Offset = "0x49BF4B8", VA = "0x49BF4B8")] get
      {
        return (ItemListData) null;
      }
      [Token(Token = "0x6013850"), Address(RVA = "0x49BF4C0", Offset = "0x49BF4C0", VA = "0x49BF4C0")] private set
      {
      }
    }

    [Token(Token = "0x6013851")]
    [Address(RVA = "0x49BD96C", Offset = "0x49BD96C", VA = "0x49BD96C")]
    public void Initialize(Action<ItemListData> action)
    {
    }

    [Token(Token = "0x6013852")]
    [Address(RVA = "0x49B9E74", Offset = "0x49B9E74", VA = "0x49B9E74")]
    public void Modify(ItemListData data, int index, bool isSellMode)
    {
    }

    [Token(Token = "0x6013853")]
    [Address(RVA = "0x49BA1AC", Offset = "0x49BA1AC", VA = "0x49BA1AC")]
    public void ResetData()
    {
    }

    [Token(Token = "0x6013854")]
    [Address(RVA = "0x49BD064", Offset = "0x49BD064", VA = "0x49BD064")]
    public void ResetSellCount()
    {
    }

    [Token(Token = "0x6013855")]
    [Address(RVA = "0x49BD2A4", Offset = "0x49BD2A4", VA = "0x49BD2A4")]
    public void ChangeSellMode(bool isSellMode)
    {
    }

    [Token(Token = "0x6013856")]
    [Address(RVA = "0x49BD080", Offset = "0x49BD080", VA = "0x49BD080")]
    public void UpdataSellAmountUI(bool isSellMode)
    {
    }

    [Token(Token = "0x6013857")]
    [Address(RVA = "0x49BF4C8", Offset = "0x49BF4C8", VA = "0x49BF4C8")]
    private void OnClickButton()
    {
    }

    [Token(Token = "0x6013858")]
    [Address(RVA = "0x49BF4E8", Offset = "0x49BF4E8", VA = "0x49BF4E8")]
    public ItemListScrolCell()
    {
    }
  }
}
