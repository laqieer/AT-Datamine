// Decompiled with JetBrains decompiler
// Type: Scenes.BuyConfirmStonePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UI.SortFilter;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x2002883")]
  public class BuyConfirmStonePopup : PopupBase
  {
    [Token(Token = "0x400ACD6")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text allStoneValue;
    [Token(Token = "0x400ACD7")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text paidStoneValue;
    [Token(Token = "0x400ACD8")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text freeStoneValue;
    [Token(Token = "0x400ACD9")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Button cancelButton;
    [Token(Token = "0x400ACDA")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private BtnCoin btnCoin;
    [Token(Token = "0x400ACDB")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x600FF49")]
    [Address(RVA = "0x40F84C0", Offset = "0x40F84C0", VA = "0x40F84C0")]
    public static AssetSpawnOperation<GameObject> Request(
      AssetCachedSpawner assetCachedSpawner,
      Action<BuyConfirmStonePopup> callback = null,
      bool isStartRequest = false,
      RectTransform buttonRectTransform = null,
      bool isActiveBtnCoinV2 = false)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x600FF4A")]
    [Address(RVA = "0x40F8610", Offset = "0x40F8610", VA = "0x40F8610")]
    public static AssetSpawnOperation<GameObject> RequestNonButton(
      AssetCachedSpawner assetCachedSpawner,
      bool isStartRequest = false,
      RectTransform buttonRectTransform = null)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x17003825")]
    public Action OnSuccessPurchase
    {
      [Token(Token = "0x600FF4B"), Address(RVA = "0x40F8744", Offset = "0x40F8744", VA = "0x40F8744")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600FF4C"), Address(RVA = "0x40F874C", Offset = "0x40F874C", VA = "0x40F874C")] set
      {
      }
    }

    [Token(Token = "0x600FF4D")]
    [Address(RVA = "0x40F8754", Offset = "0x40F8754", VA = "0x40F8754")]
    private void Awake()
    {
    }

    [Token(Token = "0x600FF4E")]
    [Address(RVA = "0x40F8AD0", Offset = "0x40F8AD0", VA = "0x40F8AD0", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x600FF4F")]
    [Address(RVA = "0x40F8B74", Offset = "0x40F8B74", VA = "0x40F8B74")]
    public void OnOpenPaidCoinShop()
    {
    }

    [Token(Token = "0x600FF50")]
    [Address(RVA = "0x40F8D74", Offset = "0x40F8D74", VA = "0x40F8D74")]
    public BuyConfirmStonePopup()
    {
    }
  }
}
