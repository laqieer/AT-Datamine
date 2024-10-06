// Decompiled with JetBrains decompiler
// Type: GameCore.DownloadProgressPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.DLC;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore
{
  [Token(Token = "0x2000BAF")]
  public class DownloadProgressPanelController : 
    SingletonMonoBehaviour<DownloadProgressPanelController>
  {
    [Token(Token = "0x400354E")]
    private const string PROGRESS_PERCENTAGE_FORMAT = "{0:0}%";
    [Token(Token = "0x400354F")]
    private const string PROGRESS_SIZE_FORMAT = "{0:F2}/{1:F2}MB";
    [Token(Token = "0x4003550")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text progressText;
    [Token(Token = "0x4003551")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text progressCapacityText;
    [Token(Token = "0x4003552")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Slider progressBar;
    [Token(Token = "0x4003553")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject viewTarget;
    [Token(Token = "0x4003554")]
    [FieldOffset(Offset = "0x40")]
    private DLCProgress dlcProgress;
    [Token(Token = "0x4003555")]
    [FieldOffset(Offset = "0x48")]
    private int loadSuccessCount;
    [Token(Token = "0x4003556")]
    [FieldOffset(Offset = "0x4C")]
    private int loadRequestCount;
    [Token(Token = "0x4003557")]
    [FieldOffset(Offset = "0x50")]
    private Coroutine progressBarCoroutine;

    [Token(Token = "0x60042BF")]
    [Address(RVA = "0x363C418", Offset = "0x363C418", VA = "0x363C418")]
    private void Start()
    {
    }

    [Token(Token = "0x60042C0")]
    [Address(RVA = "0x363C588", Offset = "0x363C588", VA = "0x363C588")]
    public void InitFont()
    {
    }

    [Token(Token = "0x60042C1")]
    [Address(RVA = "0x363C618", Offset = "0x363C618", VA = "0x363C618")]
    public void Show(bool showSize = true)
    {
    }

    [Token(Token = "0x60042C2")]
    [Address(RVA = "0x363C6B8", Offset = "0x363C6B8", VA = "0x363C6B8")]
    public void Hide()
    {
    }

    [Token(Token = "0x60042C3")]
    [Address(RVA = "0x363C6E4", Offset = "0x363C6E4", VA = "0x363C6E4")]
    public void UpdateDownloadProgress(DLCProgress dlcProgress)
    {
    }

    [Token(Token = "0x60042C4")]
    [Address(RVA = "0x363C6EC", Offset = "0x363C6EC", VA = "0x363C6EC")]
    public void UpdateLoadProgress(int successCount, int requestCount)
    {
    }

    [Token(Token = "0x60042C5")]
    [Address(RVA = "0x363C440", Offset = "0x363C440", VA = "0x363C440")]
    private void ClearProgress()
    {
    }

    [Token(Token = "0x60042C6")]
    [Address(RVA = "0x363C650", Offset = "0x363C650", VA = "0x363C650")]
    private IEnumerator RefreshProgressBar() => (IEnumerator) null;

    [Token(Token = "0x60042C7")]
    [Address(RVA = "0x363C52C", Offset = "0x363C52C", VA = "0x363C52C")]
    private void SetActiveProgressBar(bool isEnabled)
    {
    }

    [Token(Token = "0x60042C8")]
    [Address(RVA = "0x363C4FC", Offset = "0x363C4FC", VA = "0x363C4FC")]
    private void SetActiveDownloadSize(bool isEnabled)
    {
    }

    [Token(Token = "0x60042C9")]
    [Address(RVA = "0x363C71C", Offset = "0x363C71C", VA = "0x363C71C")]
    public void Report(float progress)
    {
    }

    [Token(Token = "0x60042CA")]
    [Address(RVA = "0x363C800", Offset = "0x363C800", VA = "0x363C800")]
    public DownloadProgressPanelController()
    {
    }
  }
}
