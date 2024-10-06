// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ShortcutExpeditionPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C82")]
  public class ShortcutExpeditionPopup : PopupBase
  {
    [Token(Token = "0x400BDAE")]
    public const string AssetBundleName = "ui_page_expeditionsimulator_popup_prefab";
    [Token(Token = "0x400BDAF")]
    public const string AssetName = "Com_Popup_HighSpeedExpeditionDialog_Variant";
    [Token(Token = "0x400BDB0")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400BDB1")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI coinText;
    [Token(Token = "0x400BDB2")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI coinCounterText;
    [Token(Token = "0x400BDB3")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text freeCoinText;
    [Token(Token = "0x400BDB4")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text paidCoinText;
    [Token(Token = "0x400BDB5")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private TextMeshProUGUI ticketCounterText;
    [Token(Token = "0x400BDB6")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text ticket2hText;
    [Token(Token = "0x400BDB7")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text ticket5hText;
    [Token(Token = "0x400BDB8")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text ticket10hText;
    [Token(Token = "0x400BDB9")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private CommonButton coinButton;
    [Token(Token = "0x400BDBA")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private CommonButton ticket2Button;
    [Token(Token = "0x400BDBB")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CommonButton ticket5Button;
    [Token(Token = "0x400BDBC")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CommonButton ticket10Button;
    [Token(Token = "0x400BDBD")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private UITweenGroup freeCoinTweenGroup;
    [Token(Token = "0x400BDBE")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private UITweenGroup paidCoinTweenGroup;
    [Token(Token = "0x400BDBF")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private UITweenGroup ticket2TweenGroup;
    [Token(Token = "0x400BDC0")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private UITweenGroup ticket5TweenGroup;
    [Token(Token = "0x400BDC1")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private UITweenGroup ticket10TweenGroup;
    [Token(Token = "0x400BDC2")]
    private const string NORMAL_VALUE_COLOR_TWEEN = "NormalValueColor";
    [Token(Token = "0x400BDC3")]
    private const string MINUS_VALUE_COLOR_TWEEN = "MinusValueColor";
    [Token(Token = "0x400BDC6")]
    [FieldOffset(Offset = "0x128")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400BDC7")]
    [FieldOffset(Offset = "0x130")]
    private bool isCoinCounterEmpty;
    [Token(Token = "0x400BDC8")]
    [FieldOffset(Offset = "0x131")]
    private bool isCoinShortage;
    [Token(Token = "0x400BDC9")]
    [FieldOffset(Offset = "0x132")]
    private bool isTicketCounterEmpty;
    [Token(Token = "0x400BDCA")]
    [FieldOffset(Offset = "0x133")]
    private bool isTicket2hShortage;
    [Token(Token = "0x400BDCB")]
    [FieldOffset(Offset = "0x134")]
    private bool isTicket5hShortage;
    [Token(Token = "0x400BDCC")]
    [FieldOffset(Offset = "0x135")]
    private bool isTicket10hShortage;

    [Token(Token = "0x17003C04")]
    public Action<Consume> CallbackConsume
    {
      [Token(Token = "0x60116A9"), Address(RVA = "0x4E225CC", Offset = "0x4E225CC", VA = "0x4E225CC")] get
      {
        return (Action<Consume>) null;
      }
      [Token(Token = "0x60116AA"), Address(RVA = "0x4E225D4", Offset = "0x4E225D4", VA = "0x4E225D4")] set
      {
      }
    }

    [Token(Token = "0x17003C05")]
    public Action CallbackCancel
    {
      [Token(Token = "0x60116AB"), Address(RVA = "0x4E225DC", Offset = "0x4E225DC", VA = "0x4E225DC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60116AC"), Address(RVA = "0x4E225E4", Offset = "0x4E225E4", VA = "0x4E225E4")] set
      {
      }
    }

    [Token(Token = "0x60116AD")]
    [Address(RVA = "0x4E225EC", Offset = "0x4E225EC", VA = "0x4E225EC")]
    public static void SpawnAsync(
      AssetCachedSpawner assetCachedSpawner,
      Action<ShortcutExpeditionPopup> onFinish)
    {
    }

    [Token(Token = "0x60116AE")]
    [Address(RVA = "0x4E226FC", Offset = "0x4E226FC", VA = "0x4E226FC")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Action finishedCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60116AF")]
    [Address(RVA = "0x4E227A0", Offset = "0x4E227A0", VA = "0x4E227A0")]
    public void SetData(PlayerExpeditionType playerExpedition)
    {
    }

    [Token(Token = "0x60116B0")]
    [Address(RVA = "0x4E22DF0", Offset = "0x4E22DF0", VA = "0x4E22DF0")]
    private void UpdateCoinView(ExpeditionRapidCoinRequiredAmountData rapidData)
    {
    }

    [Token(Token = "0x60116B1")]
    [Address(RVA = "0x4E22FCC", Offset = "0x4E22FCC", VA = "0x4E22FCC")]
    private void OnButtonAction(Consume consume)
    {
    }

    [Token(Token = "0x60116B2")]
    [Address(RVA = "0x4E23248", Offset = "0x4E23248", VA = "0x4E23248", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x60116B3")]
    [Address(RVA = "0x4E23264", Offset = "0x4E23264", VA = "0x4E23264")]
    public ShortcutExpeditionPopup()
    {
    }
  }
}
