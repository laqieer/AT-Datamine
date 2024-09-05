// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ShortcutExpeditionTicketConfirmPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C87")]
  public class ShortcutExpeditionTicketConfirmPopup : PopupBase
  {
    [Token(Token = "0x400BDDB")]
    public const string AssetBundleName = "ui_page_expeditionsimulator_popup_prefab";
    [Token(Token = "0x400BDDC")]
    public const string AssetName = "Com_Popup_HighSpeedExpeditionConfirmation_Ticket_Variant";
    [Token(Token = "0x400BDDD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton okButton;
    [Token(Token = "0x400BDDE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400BDDF")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI ticketText;
    [Token(Token = "0x400BDE0")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text ticketNameText;
    [Token(Token = "0x400BDE1")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text ticketCountText;
    [Token(Token = "0x400BDE2")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject ticketImage2h;
    [Token(Token = "0x400BDE3")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GameObject ticketImage5h;
    [Token(Token = "0x400BDE4")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject ticketImage10h;
    [Token(Token = "0x400BDE5")]
    [FieldOffset(Offset = "0xC8")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400BDE6")]
    [FieldOffset(Offset = "0xD0")]
    private Action<Consume> okButtonAction;
    [Token(Token = "0x400BDE7")]
    [FieldOffset(Offset = "0xD8")]
    private Action subSceneCloseAction;
    [Token(Token = "0x400BDE8")]
    [FieldOffset(Offset = "0xE0")]
    private Consume consume;

    [Token(Token = "0x60116C5")]
    [Address(RVA = "0x4E238F0", Offset = "0x4E238F0", VA = "0x4E238F0")]
    public static void SpawnAsync(
      AssetCachedSpawner assetCachedSpawner,
      Action<ShortcutExpeditionTicketConfirmPopup> onFinish)
    {
    }

    [Token(Token = "0x60116C6")]
    [Address(RVA = "0x4E23A00", Offset = "0x4E23A00", VA = "0x4E23A00")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Consume consume,
      Action finishedCallback,
      Action<Consume> okButtonAction,
      Action closeButtonAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60116C7")]
    [Address(RVA = "0x4E23AC8", Offset = "0x4E23AC8", VA = "0x4E23AC8", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x60116C8")]
    [Address(RVA = "0x4E23AFC", Offset = "0x4E23AFC", VA = "0x4E23AFC")]
    private void OnOkButton()
    {
    }

    [Token(Token = "0x60116C9")]
    [Address(RVA = "0x4E23B34", Offset = "0x4E23B34", VA = "0x4E23B34")]
    public ShortcutExpeditionTicketConfirmPopup()
    {
    }
  }
}
