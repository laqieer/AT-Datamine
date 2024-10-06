// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ShortcutExpeditionCoinConfirmPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C7C")]
  public class ShortcutExpeditionCoinConfirmPopup : PopupBase
  {
    [Token(Token = "0x400BD8C")]
    public const string AssetBundleName = "ui_page_expeditionsimulator_popup_prefab";
    [Token(Token = "0x400BD8D")]
    public const string AssetName = "Com_Popup_HighSpeedExpeditionConfirmation_Diamond_Variant";
    [Token(Token = "0x400BD8E")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton okButton;
    [Token(Token = "0x400BD8F")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400BD90")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton lawButton;
    [Token(Token = "0x400BD91")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI coinText;
    [Token(Token = "0x400BD92")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text freeCoinText;
    [Token(Token = "0x400BD93")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text paidCoinText;
    [Token(Token = "0x400BD94")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private UITweenGroup freeCoinTweenGroup;
    [Token(Token = "0x400BD95")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private UITweenGroup paidCoinTweenGroup;
    [Token(Token = "0x400BD96")]
    private const string NORMAL_VALUE_COLOR_TWEEN = "NormalValueColor";
    [Token(Token = "0x400BD97")]
    private const string MINUS_VALUE_COLOR_TWEEN = "MinusValueColor";
    [Token(Token = "0x400BD98")]
    [FieldOffset(Offset = "0xC8")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400BD99")]
    [FieldOffset(Offset = "0xD0")]
    private Action<Consume> okButtonAction;
    [Token(Token = "0x400BD9A")]
    [FieldOffset(Offset = "0xD8")]
    private Action subSceneCloseAction;

    [Token(Token = "0x6011695")]
    [Address(RVA = "0x4E219A4", Offset = "0x4E219A4", VA = "0x4E219A4")]
    public static void SpawnAsync(
      AssetCachedSpawner assetCachedSpawner,
      Action<ShortcutExpeditionCoinConfirmPopup> onFinish)
    {
    }

    [Token(Token = "0x6011696")]
    [Address(RVA = "0x4E21AB4", Offset = "0x4E21AB4", VA = "0x4E21AB4")]
    public IEnumerator InitializeAsync(
      AssetCachedSpawner assetCachedSpawner,
      Action finishedCallback,
      Action<Consume> okButtonAction,
      Action closeButtonAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011697")]
    [Address(RVA = "0x4E21B6C", Offset = "0x4E21B6C", VA = "0x4E21B6C", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6011698")]
    [Address(RVA = "0x4E21BA0", Offset = "0x4E21BA0", VA = "0x4E21BA0")]
    private void OnOkButton()
    {
    }

    [Token(Token = "0x6011699")]
    [Address(RVA = "0x4E21BD8", Offset = "0x4E21BD8", VA = "0x4E21BD8")]
    public ShortcutExpeditionCoinConfirmPopup()
    {
    }
  }
}
