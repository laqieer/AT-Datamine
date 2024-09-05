// Decompiled with JetBrains decompiler
// Type: Scenes.Title.TitleMenuPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028ED")]
  public class TitleMenuPopup : MonoBehaviour
  {
    [Token(Token = "0x400AE80")]
    private const string TITLEMENU_TWEEN_IN = "Popup_In";
    [Token(Token = "0x400AE81")]
    private const string TITLEMENU_TWEEN_OUT = "Popup_Out";
    [Token(Token = "0x400AE82")]
    private const string POPUP_TWEEN_IN = "In";
    [Token(Token = "0x400AE83")]
    private const string POPUP_TWEEN_OUT = "Out";
    [Token(Token = "0x400AE84")]
    private const string StartupUIAssetBundleName = "2dassets_ui_startup";
    [Token(Token = "0x400AE85")]
    public const string PrivacyPolicyPopupPrefabName = "Com_Popup_PrivacyPolicy";
    [Token(Token = "0x400AE86")]
    public const string ContactPopupPrefabName = "Com_Popup_Contact";
    [Token(Token = "0x400AE87")]
    private const string LOADING_COM_POPUP_ROOT = "Prefabs";
    [Token(Token = "0x400AE88")]
    private const string LOADING_COM_POPUP_PREFAB_NAME = "Com_Popup";
    [Token(Token = "0x400AE89")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup uiTweenGroup;
    [Token(Token = "0x400AE8A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollRect menuScrollRect;
    [Token(Token = "0x400AE8B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TitlePrivacyPolicyPopup titlePrivacyPolicyPopupPrefab;
    [Token(Token = "0x400AE8C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TitlePrivacyPolicyPopup titlePrivacyPolicyPopup;
    [Token(Token = "0x400AE8D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TitleComPopup titleContactPopupPrefab;
    [Token(Token = "0x400AE8E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TitleComPopup titleContactPopup;
    [Token(Token = "0x400AE8F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonPopup commonPopupPrefab;
    [Token(Token = "0x400AE90")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonPopup commonPopup;
    [Token(Token = "0x400AE91")]
    [FieldOffset(Offset = "0x58")]
    private DLCProcess DlcProcess;

    [Token(Token = "0x601018E")]
    [Address(RVA = "0x4170B38", Offset = "0x4170B38", VA = "0x4170B38")]
    public void ShowTitleMenu()
    {
    }

    [Token(Token = "0x601018F")]
    [Address(RVA = "0x4170C0C", Offset = "0x4170C0C", VA = "0x4170C0C")]
    private void FinishedMenuInAnime()
    {
    }

    [Token(Token = "0x6010190")]
    [Address(RVA = "0x4170CAC", Offset = "0x4170CAC", VA = "0x4170CAC")]
    public void CloseTitleMenu()
    {
    }

    [Token(Token = "0x6010191")]
    [Address(RVA = "0x4170D64", Offset = "0x4170D64", VA = "0x4170D64")]
    private void FinishedOutAnime()
    {
    }

    [Token(Token = "0x6010192")]
    [Address(RVA = "0x4170E0C", Offset = "0x4170E0C", VA = "0x4170E0C")]
    public void OnPrivacyPolicyButton()
    {
    }

    [Token(Token = "0x6010193")]
    [Address(RVA = "0x4171070", Offset = "0x4171070", VA = "0x4171070")]
    public void OnClearCacheButton()
    {
    }

    [Token(Token = "0x6010194")]
    [Address(RVA = "0x4171358", Offset = "0x4171358", VA = "0x4171358")]
    public void OnHelpButton()
    {
    }

    [Token(Token = "0x6010195")]
    [Address(RVA = "0x417135C", Offset = "0x417135C", VA = "0x417135C")]
    public void OnOptionButton()
    {
    }

    [Token(Token = "0x6010196")]
    [Address(RVA = "0x4171360", Offset = "0x4171360", VA = "0x4171360")]
    public void OnOpMoveButton()
    {
    }

    [Token(Token = "0x6010197")]
    [Address(RVA = "0x4171364", Offset = "0x4171364", VA = "0x4171364")]
    public void OnDownloadButton()
    {
    }

    [Token(Token = "0x6010198")]
    [Address(RVA = "0x417164C", Offset = "0x417164C", VA = "0x417164C")]
    public void OnContactButton()
    {
    }

    [Token(Token = "0x6010199")]
    [Address(RVA = "0x41717DC", Offset = "0x41717DC", VA = "0x41717DC")]
    public void OnNoticeButton()
    {
    }

    [Token(Token = "0x601019A")]
    [Address(RVA = "0x41717E0", Offset = "0x41717E0", VA = "0x41717E0")]
    private IEnumerator DownloadAssetBundles(Action endAction) => (IEnumerator) null;

    [Token(Token = "0x601019B")]
    [Address(RVA = "0x417187C", Offset = "0x417187C", VA = "0x417187C")]
    public TitleMenuPopup()
    {
    }
  }
}
