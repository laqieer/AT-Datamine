// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.AdVideoStartPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003980")]
  public class AdVideoStartPopup : PopupBase
  {
    [Token(Token = "0x400FB37")]
    public const string AssetBundleName = "ui_page_gacha_prefab";
    [Token(Token = "0x400FB38")]
    private const string AssetName = "Com_Popup_Advertisement_Note";
    [Token(Token = "0x400FB39")]
    [FieldOffset(Offset = "0x88")]
    [Header("入力制御用")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400FB3A")]
    [FieldOffset(Offset = "0x90")]
    [Space(10f)]
    [SerializeField]
    private TextAccessor titleAccessor;
    [Token(Token = "0x400FB3B")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextAccessor explanation;
    [Token(Token = "0x400FB3C")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextAccessor remainCount;
    [Token(Token = "0x400FB3D")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextAccessor resetTime;
    [Token(Token = "0x400FB3E")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Button buttonDecision;
    [Token(Token = "0x400FB3F")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Button buttonCancel;
    [Token(Token = "0x400FB40")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject textScheduleRoot;
    [Token(Token = "0x400FB41")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text textSchedule;
    [Token(Token = "0x400FB42")]
    [FieldOffset(Offset = "0xD0")]
    public Action OnClickDecision;
    [Token(Token = "0x400FB43")]
    [FieldOffset(Offset = "0xD8")]
    public Action OnClickCancel;
    [Token(Token = "0x400FB44")]
    [FieldOffset(Offset = "0xE0")]
    private IAdVideoStartPopupPresenter presenter;

    [Token(Token = "0x17004A76")]
    public IAdVideoStartPopupPresenter Presenter
    {
      [Token(Token = "0x60169A2"), Address(RVA = "0x42F34F8", Offset = "0x42F34F8", VA = "0x42F34F8")] set
      {
      }
    }

    [Token(Token = "0x60169A3")]
    [Address(RVA = "0x42F359C", Offset = "0x42F359C", VA = "0x42F359C")]
    public static void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60169A4")]
    [Address(RVA = "0x42F361C", Offset = "0x42F361C", VA = "0x42F361C")]
    public static void Create(AssetCachedSpawner spawner, Action<AdVideoStartPopup> onCreate)
    {
    }

    [Token(Token = "0x60169A5")]
    [Address(RVA = "0x42F372C", Offset = "0x42F372C", VA = "0x42F372C")]
    private void Awake()
    {
    }

    [Token(Token = "0x60169A6")]
    [Address(RVA = "0x42F2FA0", Offset = "0x42F2FA0", VA = "0x42F2FA0")]
    public void SetScheduleText(DateTime beginAt, DateTime endAt)
    {
    }

    [Token(Token = "0x60169A7")]
    [Address(RVA = "0x42F31C0", Offset = "0x42F31C0", VA = "0x42F31C0")]
    public void SetInfoText(string title, string explanation, int resetTimeHour, int remainCount)
    {
    }

    [Token(Token = "0x60169A8")]
    [Address(RVA = "0x42F3414", Offset = "0x42F3414", VA = "0x42F3414")]
    public void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x60169A9")]
    [Address(RVA = "0x42F383C", Offset = "0x42F383C", VA = "0x42F383C")]
    public AdVideoStartPopup()
    {
    }
  }
}
