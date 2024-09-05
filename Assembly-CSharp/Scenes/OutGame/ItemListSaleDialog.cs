// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ItemListSaleDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031FE")]
  public class ItemListSaleDialog : MonoBehaviour
  {
    [Token(Token = "0x400D57C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton saleButton;
    [Token(Token = "0x400D57D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400D57E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton MinusButton;
    [Token(Token = "0x400D57F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton MinButton;
    [Token(Token = "0x400D580")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton PlusButton;
    [Token(Token = "0x400D581")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton MaxButton;
    [Token(Token = "0x400D582")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400D583")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text itemNameText;
    [Token(Token = "0x400D584")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text saleItemCountText;
    [Token(Token = "0x400D585")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text saleValueText;
    [Token(Token = "0x400D586")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400D587")]
    [FieldOffset(Offset = "0x70")]
    private Item itemData;
    [Token(Token = "0x400D588")]
    [FieldOffset(Offset = "0x78")]
    private int saleNumber;
    [Token(Token = "0x400D589")]
    [FieldOffset(Offset = "0x7C")]
    private int saleMax;
    [Token(Token = "0x400D58A")]
    [FieldOffset(Offset = "0x80")]
    private bool isConnecting;
    [Token(Token = "0x400D58B")]
    [FieldOffset(Offset = "0x88")]
    private long rewardQuantity;
    [Token(Token = "0x400D58C")]
    [FieldOffset(Offset = "0x90")]
    private Action onSaled;

    [Token(Token = "0x601383B")]
    [Address(RVA = "0x49BE994", Offset = "0x49BE994", VA = "0x49BE994")]
    private void Awake()
    {
    }

    [Token(Token = "0x601383C")]
    [Address(RVA = "0x49BEC20", Offset = "0x49BEC20", VA = "0x49BEC20")]
    public void Open(Item itemData, Action onSaled, AssetCachedSpawner spawner = null)
    {
    }

    [Token(Token = "0x601383D")]
    [Address(RVA = "0x49BEEFC", Offset = "0x49BEEFC", VA = "0x49BEEFC")]
    private void Close()
    {
    }

    [Token(Token = "0x601383E")]
    [Address(RVA = "0x49BEE08", Offset = "0x49BEE08", VA = "0x49BEE08")]
    private void SetSaleParameter(int saleNumber)
    {
    }

    [Token(Token = "0x601383F")]
    [Address(RVA = "0x49BEF20", Offset = "0x49BEF20", VA = "0x49BEF20")]
    private void OnClickClose()
    {
    }

    [Token(Token = "0x6013840")]
    [Address(RVA = "0x49BEF30", Offset = "0x49BEF30", VA = "0x49BEF30")]
    private void OnPlusClick()
    {
    }

    [Token(Token = "0x6013841")]
    [Address(RVA = "0x49BEFA0", Offset = "0x49BEFA0", VA = "0x49BEFA0")]
    private void OnMaxClick()
    {
    }

    [Token(Token = "0x6013842")]
    [Address(RVA = "0x49BEFA8", Offset = "0x49BEFA8", VA = "0x49BEFA8")]
    private void OnMinusClick()
    {
    }

    [Token(Token = "0x6013843")]
    [Address(RVA = "0x49BF018", Offset = "0x49BF018", VA = "0x49BF018")]
    private void OnMinClick()
    {
    }

    [Token(Token = "0x6013844")]
    [Address(RVA = "0x49BF020", Offset = "0x49BF020", VA = "0x49BF020")]
    private void OnSaleClick()
    {
    }

    [Token(Token = "0x6013845")]
    [Address(RVA = "0x49BF050", Offset = "0x49BF050", VA = "0x49BF050")]
    protected IEnumerator ConnectAPIItemSell() => (IEnumerator) null;

    [Token(Token = "0x6013846")]
    [Address(RVA = "0x49BF0E0", Offset = "0x49BF0E0", VA = "0x49BF0E0")]
    public ItemListSaleDialog()
    {
    }
  }
}
