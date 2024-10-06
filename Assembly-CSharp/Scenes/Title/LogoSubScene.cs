// Decompiled with JetBrains decompiler
// Type: Scenes.Title.LogoSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028CD")]
  public class LogoSubScene : SubScene
  {
    [Token(Token = "0x400ADFB")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string SOUNDBANKNAME;
    [Token(Token = "0x400ADFC")]
    [FieldOffset(Offset = "0x8")]
    public static readonly string[] SOUNDPACKNAMES;
    [Token(Token = "0x400ADFD")]
    private const string LOGO_TWEEN_IN = "in";
    [Token(Token = "0x400ADFE")]
    private const string ANNOUNCE_TWEEN_IN = "in";
    [Token(Token = "0x400ADFF")]
    private const string ANNOUNCE_TWEEN_OUT = "out";
    [Token(Token = "0x400AE00")]
    private const string TitleSubSceneAssetBundleName = "ui_page_title_staq_prefab";
    [Token(Token = "0x400AE01")]
    private const string TitleSubScenePrefabName = "TitleSubScene";
    [Token(Token = "0x400AE02")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UITweenGroup logoTweenGroup;
    [Token(Token = "0x400AE03")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UITweenGroup announceTweenGroup;
    [Token(Token = "0x400AE04")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CanvasGroup announceCanvasGroup;
    [Token(Token = "0x400AE05")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UITweenGroup bgTweenGroup;
    [Token(Token = "0x400AE06")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TitleMenuCacheClearPopup cacheClearPopup;
    [Token(Token = "0x400AE07")]
    [FieldOffset(Offset = "0x80")]
    private CommonPopup CommonPopupPrefab;
    [Token(Token = "0x400AE08")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton skipBtn;
    [Token(Token = "0x400AE09")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton cacheClearBtn;
    [Token(Token = "0x400AE0A")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject cacheClearBtnRoot;
    [Token(Token = "0x400AE0B")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject logoTitle;
    [Token(Token = "0x400AE0C")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Canvas logoTileCanvas;
    [Token(Token = "0x400AE0D")]
    [FieldOffset(Offset = "0xB0")]
    private bool isCallTitleDownload;
    [Token(Token = "0x400AE0E")]
    [FieldOffset(Offset = "0xB1")]
    private bool isShowLogoAnnounceStage;
    [Token(Token = "0x400AE0F")]
    [FieldOffset(Offset = "0xB2")]
    private bool isSubsceneSelfProcessInitialized;
    [Token(Token = "0x400AE10")]
    [FieldOffset(Offset = "0xB3")]
    private bool isOpenCacheClearPopup;
    [Token(Token = "0x400AE11")]
    [FieldOffset(Offset = "0xB4")]
    private bool isDecideCacheClear;
    [Token(Token = "0x400AE12")]
    [FieldOffset(Offset = "0xB8")]
    private string[] downloadTitleLabels;
    [Token(Token = "0x400AE13")]
    [FieldOffset(Offset = "0xC0")]
    private long totalSizeMinimum;
    [Token(Token = "0x400AE14")]
    [FieldOffset(Offset = "0xC8")]
    private long totalSizeMaximum;

    [Token(Token = "0x60100D0")]
    [Address(RVA = "0x4169434", Offset = "0x4169434", VA = "0x4169434", Slot = "6")]
    public override void Initialize(ChangeSceneParameter parameter)
    {
    }

    [Token(Token = "0x60100D1")]
    [Address(RVA = "0x4169910", Offset = "0x4169910", VA = "0x4169910", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60100D2")]
    [Address(RVA = "0x41699A0", Offset = "0x41699A0", VA = "0x41699A0", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x60100D3")]
    [Address(RVA = "0x41699A8", Offset = "0x41699A8", VA = "0x41699A8")]
    private void StartLogoAnime()
    {
    }

    [Token(Token = "0x60100D4")]
    [Address(RVA = "0x4169D40", Offset = "0x4169D40", VA = "0x4169D40")]
    private void FinishedLogoAnime()
    {
    }

    [Token(Token = "0x60100D5")]
    [Address(RVA = "0x4169EA4", Offset = "0x4169EA4", VA = "0x4169EA4")]
    private void FinishedAnnounceAnime()
    {
    }

    [Token(Token = "0x60100D6")]
    [Address(RVA = "0x4169F98", Offset = "0x4169F98", VA = "0x4169F98")]
    private IEnumerator OpenCacheClearPopup() => (IEnumerator) null;

    [Token(Token = "0x60100D7")]
    [Address(RVA = "0x4169F60", Offset = "0x4169F60", VA = "0x4169F60")]
    private void TitleSystemSetupStart()
    {
    }

    [Token(Token = "0x60100D8")]
    [Address(RVA = "0x416A028", Offset = "0x416A028", VA = "0x416A028")]
    private IEnumerator TitleSystemSequence() => (IEnumerator) null;

    [Token(Token = "0x60100D9")]
    [Address(RVA = "0x416A0B8", Offset = "0x416A0B8", VA = "0x416A0B8")]
    private IEnumerator SetupAssetBundles() => (IEnumerator) null;

    [Token(Token = "0x60100DA")]
    [Address(RVA = "0x416A148", Offset = "0x416A148", VA = "0x416A148")]
    private void Restart(string[] errorFiles)
    {
    }

    [Token(Token = "0x60100DB")]
    [Address(RVA = "0x416A254", Offset = "0x416A254", VA = "0x416A254")]
    private IEnumerator ChangeTitle() => (IEnumerator) null;

    [Token(Token = "0x60100DC")]
    [Address(RVA = "0x416A2E4", Offset = "0x416A2E4", VA = "0x416A2E4")]
    public void OnLogoSkipButton()
    {
    }

    [Token(Token = "0x60100DD")]
    [Address(RVA = "0x416A318", Offset = "0x416A318", VA = "0x416A318")]
    public void OnClickCacheClear()
    {
    }

    [Token(Token = "0x60100DE")]
    [Address(RVA = "0x416A350", Offset = "0x416A350", VA = "0x416A350", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x60100DF")]
    [Address(RVA = "0x416A3E0", Offset = "0x416A3E0", VA = "0x416A3E0")]
    private IEnumerator LoadTextAsset() => (IEnumerator) null;

    [Token(Token = "0x60100E0")]
    [Address(RVA = "0x4169848", Offset = "0x4169848", VA = "0x4169848")]
    private void SetupReferenceFontAssets()
    {
    }

    [Token(Token = "0x60100E1")]
    [Address(RVA = "0x416A468", Offset = "0x416A468", VA = "0x416A468")]
    private IEnumerator TitleDownload() => (IEnumerator) null;

    [Token(Token = "0x60100E2")]
    [Address(RVA = "0x416A4F8", Offset = "0x416A4F8", VA = "0x416A4F8")]
    private IEnumerator PerformConfiguredDownloads(Action callback = null) => (IEnumerator) null;

    [Token(Token = "0x60100E3")]
    [Address(RVA = "0x416A598", Offset = "0x416A598", VA = "0x416A598")]
    private long GetTitleDownloadFileList(ref Dictionary<string, int> downloadFiles) => new long();

    [Token(Token = "0x60100E4")]
    [Address(RVA = "0x416A8E4", Offset = "0x416A8E4", VA = "0x416A8E4")]
    private long GetTitleDownloadFileListNotInServics(ref Dictionary<string, int> downloadFiles)
    {
      return new long();
    }

    [Token(Token = "0x60100E5")]
    [Address(RVA = "0x416AAD8", Offset = "0x416AAD8", VA = "0x416AAD8")]
    private IEnumerator BeforeDownloadTitleAssets(long totalDownloadSize) => (IEnumerator) null;

    [Token(Token = "0x60100E6")]
    [Address(RVA = "0x416AB74", Offset = "0x416AB74", VA = "0x416AB74")]
    private IEnumerator ShowBackgroundDownloadConfirmDialog() => (IEnumerator) null;

    [Token(Token = "0x60100E7")]
    [Address(RVA = "0x416ABFC", Offset = "0x416ABFC", VA = "0x416ABFC")]
    public LogoSubScene()
    {
    }

    [Token(Token = "0x60100E8")]
    [Address(RVA = "0x416AC14", Offset = "0x416AC14", VA = "0x416AC14")]
    static LogoSubScene()
    {
    }
  }
}
