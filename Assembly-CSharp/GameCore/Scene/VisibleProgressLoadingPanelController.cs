// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.VisibleProgressLoadingPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.Title;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000CA0")]
  public class VisibleProgressLoadingPanelController : LoadingPanelController
  {
    [Token(Token = "0x40038EA")]
    private const string PROGRESS_PERCENTAGE_FORMAT = "{0:0}%";
    [Token(Token = "0x40038EB")]
    private const string PROGRESS_SIZE_FORMAT = "{0:F2}/{1:F2}MB";
    [Token(Token = "0x40038EC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text progressText;
    [Token(Token = "0x40038ED")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text progressCapacityText;
    [Token(Token = "0x40038EE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Slider progressBar;
    [Token(Token = "0x40038EF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text tipsText;
    [Token(Token = "0x40038F0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TitleMoviePlayer moviePlayer;
    [Token(Token = "0x40038F1")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject bgImage;
    [Token(Token = "0x40038F2")]
    [FieldOffset(Offset = "0x58")]
    private DLCProgress dlcProgress;
    [Token(Token = "0x40038F3")]
    [FieldOffset(Offset = "0x60")]
    private int loadSuccessCount;
    [Token(Token = "0x40038F4")]
    [FieldOffset(Offset = "0x64")]
    private int loadRequestCount;
    [Token(Token = "0x40038F5")]
    [FieldOffset(Offset = "0x68")]
    private Coroutine progressBarCoroutine;
    [Token(Token = "0x40038F6")]
    [FieldOffset(Offset = "0x70")]
    private float duration;
    [Token(Token = "0x40038F7")]
    [FieldOffset(Offset = "0x74")]
    private VisibleProgressLoadingPanelController.TipsCategory tipsCategory;
    [Token(Token = "0x40038F8")]
    [FieldOffset(Offset = "0x78")]
    private bool isEnabledVideo;

    [Token(Token = "0x60048E5")]
    [Address(RVA = "0x3133758", Offset = "0x3133758", VA = "0x3133758")]
    private void Start()
    {
    }

    [Token(Token = "0x60048E6")]
    [Address(RVA = "0x31337E0", Offset = "0x31337E0", VA = "0x31337E0", Slot = "4")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x60048E7")]
    [Address(RVA = "0x31338D4", Offset = "0x31338D4", VA = "0x31338D4")]
    public void InitFont()
    {
    }

    [Token(Token = "0x60048E8")]
    [Address(RVA = "0x313398C", Offset = "0x313398C", VA = "0x313398C")]
    public void SetTipsCategory(
      VisibleProgressLoadingPanelController.TipsCategory tipsCategory)
    {
    }

    [Token(Token = "0x60048E9")]
    [Address(RVA = "0x3133994", Offset = "0x3133994", VA = "0x3133994")]
    public void SetActiveVideo(bool isEnabled)
    {
    }

    [Token(Token = "0x60048EA")]
    [Address(RVA = "0x312F1A8", Offset = "0x312F1A8", VA = "0x312F1A8")]
    public void SetActiveBG(bool isEnabled)
    {
    }

    [Token(Token = "0x60048EB")]
    [Address(RVA = "0x31339A0", Offset = "0x31339A0", VA = "0x31339A0", Slot = "8")]
    protected override void ShowImpl()
    {
    }

    [Token(Token = "0x60048EC")]
    [Address(RVA = "0x3133CD4", Offset = "0x3133CD4", VA = "0x3133CD4", Slot = "10")]
    protected override void HideImpl()
    {
    }

    [Token(Token = "0x60048ED")]
    [Address(RVA = "0x3133D7C", Offset = "0x3133D7C", VA = "0x3133D7C", Slot = "11")]
    public override void UpdateDownloadProgress(DLCProgress dlcProgress)
    {
    }

    [Token(Token = "0x60048EE")]
    [Address(RVA = "0x3133D84", Offset = "0x3133D84", VA = "0x3133D84", Slot = "12")]
    public override void UpdateLoadProgress(int successCount, int requestCount)
    {
    }

    [Token(Token = "0x60048EF")]
    [Address(RVA = "0x3133D8C", Offset = "0x3133D8C", VA = "0x3133D8C")]
    public IEnumerator PlayVideo() => (IEnumerator) null;

    [Token(Token = "0x60048F0")]
    [Address(RVA = "0x3133AA0", Offset = "0x3133AA0", VA = "0x3133AA0")]
    private IEnumerator RefreshProgressBar() => (IEnumerator) null;

    [Token(Token = "0x60048F1")]
    [Address(RVA = "0x3133784", Offset = "0x3133784", VA = "0x3133784")]
    private void SetActiveProgressBar(bool isEnabled)
    {
    }

    [Token(Token = "0x60048F2")]
    [Address(RVA = "0x3133E44", Offset = "0x3133E44", VA = "0x3133E44")]
    private void SetActiveDownloadSize(bool isEnabled)
    {
    }

    [Token(Token = "0x60048F3")]
    [Address(RVA = "0x3133B08", Offset = "0x3133B08", VA = "0x3133B08")]
    private static string ExtractTipsId(
      VisibleProgressLoadingPanelController.TipsCategory tipsCategory)
    {
      return (string) null;
    }

    [Token(Token = "0x60048F4")]
    [Address(RVA = "0x3133E7C", Offset = "0x3133E7C", VA = "0x3133E7C")]
    private static bool IsEnabledTipsCondition(
      TipsLoadingData x,
      VisibleProgressLoadingPanelController.TipsCategory tipsCategory)
    {
      return new bool();
    }

    [Token(Token = "0x60048F5")]
    [Address(RVA = "0x3134014", Offset = "0x3134014", VA = "0x3134014")]
    public VisibleProgressLoadingPanelController()
    {
    }

    [Token(Token = "0x2000CA1")]
    public enum TipsCategory
    {
      [Token(Token = "0x40038FA")] None,
      [Token(Token = "0x40038FB")] Story,
      [Token(Token = "0x40038FC")] Battle,
      [Token(Token = "0x40038FD")] Other,
    }
  }
}
