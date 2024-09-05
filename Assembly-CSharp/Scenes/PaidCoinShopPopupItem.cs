// Decompiled with JetBrains decompiler
// Type: Scenes.PaidCoinShopPopupItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x20028A7")]
  public class PaidCoinShopPopupItem : MonoBehaviour
  {
    [Token(Token = "0x400AD83")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RawImage imageBanner;
    [Token(Token = "0x400AD84")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject infoLabelParent;
    [Token(Token = "0x400AD85")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text purchaseLimit;
    [Token(Token = "0x400AD86")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text getCount;
    [Token(Token = "0x400AD87")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI itemName;
    [Token(Token = "0x400AD88")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text price;
    [Token(Token = "0x400AD89")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject soldOut;
    [Token(Token = "0x400AD8A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton confirmButton;
    [Token(Token = "0x400AD8B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject daysPass;
    [Token(Token = "0x400AD8C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text textDaysPass;
    [Token(Token = "0x400AD8D")]
    [FieldOffset(Offset = "0x68")]
    private PaidCoinShopPopup paidCoinShopPopup;
    [Token(Token = "0x400AD8E")]
    [FieldOffset(Offset = "0x70")]
    private PaidCoinShopPopupItemInfo info;
    [Token(Token = "0x400AD8F")]
    [FieldOffset(Offset = "0x78")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400AD90")]
    [FieldOffset(Offset = "0x80")]
    public bool isCreated;
    [Token(Token = "0x400AD91")]
    [FieldOffset(Offset = "0x84")]
    public PaidCoinShopPopup.ItemType itemType;

    [Token(Token = "0x6010002")]
    [Address(RVA = "0x40FD870", Offset = "0x40FD870", VA = "0x40FD870")]
    public void Init(
      AssetCachedSpawner spawner,
      PaidCoinShopPopup paidCoinShopPopup,
      PaidCoinShopPopupItemInfo info)
    {
    }

    [Token(Token = "0x6010003")]
    [Address(RVA = "0x40FD87C", Offset = "0x40FD87C", VA = "0x40FD87C")]
    public void Create()
    {
    }

    [Token(Token = "0x6010004")]
    [Address(RVA = "0x410177C", Offset = "0x410177C", VA = "0x410177C")]
    private IEnumerator SetRawImage() => (IEnumerator) null;

    [Token(Token = "0x6010005")]
    [Address(RVA = "0x4101824", Offset = "0x4101824", VA = "0x4101824")]
    private void OnConfirm()
    {
    }

    [Token(Token = "0x6010006")]
    [Address(RVA = "0x41016F4", Offset = "0x41016F4", VA = "0x41016F4")]
    private PaidCoinShopPopup.ItemType GetItemType(PaidCoinShopPopupItemInfo info)
    {
      return new PaidCoinShopPopup.ItemType();
    }

    [Token(Token = "0x6010007")]
    [Address(RVA = "0x41017E4", Offset = "0x41017E4", VA = "0x41017E4")]
    private bool IsSoldOut(PaidCoinShopPopupItemInfo info) => new bool();

    [Token(Token = "0x6010008")]
    [Address(RVA = "0x41019CC", Offset = "0x41019CC", VA = "0x41019CC")]
    public PaidCoinShopPopupItem()
    {
    }
  }
}
