// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GachaStartPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039E5")]
  public class GachaStartPopup : PopupBase
  {
    [Token(Token = "0x400FD4A")]
    public const string AssetBundleName = "ui_page_gacha_prefab";
    [Token(Token = "0x400FD4B")]
    private const string AssetName = "Container_Popup_GachaStart";
    [Token(Token = "0x400FD4C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    [Header("入力制御用")]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400FD4D")]
    [FieldOffset(Offset = "0x90")]
    [Space(10f)]
    [SerializeField]
    private Text gachaName;
    [Token(Token = "0x400FD4E")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GachaPaymentContents diaPaid;
    [Token(Token = "0x400FD4F")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GachaPaymentContents dia;
    [Token(Token = "0x400FD50")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GachaTicketPaymentContents ticket;
    [Token(Token = "0x400FD51")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GachaPaymentContents zeny;
    [Token(Token = "0x400FD52")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Button buttonDecision;
    [Token(Token = "0x400FD53")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Button buttonCancel;
    [Token(Token = "0x400FD54")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Button buttonSpecifiedCommercial;
    [Token(Token = "0x400FD55")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text textSchedule;
    [Token(Token = "0x400FD56")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text textResetTime;
    [Token(Token = "0x400FD57")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject objectTimerIcon;
    [Token(Token = "0x400FD58")]
    [FieldOffset(Offset = "0xE8")]
    public Action OnClickDecision;
    [Token(Token = "0x400FD59")]
    [FieldOffset(Offset = "0xF0")]
    public Action OnClickCancel;
    [Token(Token = "0x400FD5A")]
    [FieldOffset(Offset = "0xF8")]
    public Action OnClickSpecifiedCommercial;
    [Token(Token = "0x400FD5B")]
    [FieldOffset(Offset = "0x100")]
    private IGachaStartPopupPresenter presenter;

    [Token(Token = "0x17004AB8")]
    public IGachaStartPopupPresenter Presenter
    {
      [Token(Token = "0x6016BBB"), Address(RVA = "0x3F6F7D0", Offset = "0x3F6F7D0", VA = "0x3F6F7D0")] set
      {
      }
    }

    [Token(Token = "0x6016BBC")]
    [Address(RVA = "0x3F6F91C", Offset = "0x3F6F91C", VA = "0x3F6F91C")]
    public static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6016BBD")]
    [Address(RVA = "0x3F6F99C", Offset = "0x3F6F99C", VA = "0x3F6F99C")]
    public static void Create(AssetCachedSpawner spawner, Action<GachaStartPopup> onCreate)
    {
    }

    [Token(Token = "0x6016BBE")]
    [Address(RVA = "0x3F6FAAC", Offset = "0x3F6FAAC", VA = "0x3F6FAAC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6016BBF")]
    [Address(RVA = "0x3F6F3C0", Offset = "0x3F6F3C0", VA = "0x3F6F3C0")]
    public void SetPaymentInfo(
      PaymentTypeEnum paymentType,
      int paymentId,
      int paymentAmount,
      int pickCount)
    {
    }

    [Token(Token = "0x6016BC0")]
    [Address(RVA = "0x3F6F5B8", Offset = "0x3F6F5B8", VA = "0x3F6F5B8")]
    public void SetScheduleText(DateTime beginAt, DateTime endAt)
    {
    }

    [Token(Token = "0x6016BC1")]
    [Address(RVA = "0x3F6F58C", Offset = "0x3F6F58C", VA = "0x3F6F58C")]
    public void ActiveResetTime()
    {
    }

    [Token(Token = "0x6016BC2")]
    [Address(RVA = "0x3F6FD48", Offset = "0x3F6FD48", VA = "0x3F6FD48")]
    public void SetResetTimeActive(bool isActive)
    {
    }

    [Token(Token = "0x6016BC3")]
    [Address(RVA = "0x3F6FCA4", Offset = "0x3F6FCA4", VA = "0x3F6FCA4")]
    public void SetTimerIconActive(bool isActive)
    {
    }

    [Token(Token = "0x6016BC4")]
    [Address(RVA = "0x3F6FC00", Offset = "0x3F6FC00", VA = "0x3F6FC00")]
    public void SetScheduleTextActive(bool isActive)
    {
    }

    [Token(Token = "0x6016BC5")]
    [Address(RVA = "0x3F6F55C", Offset = "0x3F6F55C", VA = "0x3F6F55C")]
    public void SetSpecifiedCommercialButtonActive(bool isActive)
    {
    }

    [Token(Token = "0x6016BC6")]
    [Address(RVA = "0x3F6F674", Offset = "0x3F6F674", VA = "0x3F6F674")]
    public void SetNameText(string name)
    {
    }

    [Token(Token = "0x6016BC7")]
    [Address(RVA = "0x3F6F6EC", Offset = "0x3F6F6EC", VA = "0x3F6F6EC")]
    public void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6016BC8")]
    [Address(RVA = "0x3F6FDEC", Offset = "0x3F6FDEC", VA = "0x3F6FDEC")]
    public GachaStartPopup()
    {
    }
  }
}
