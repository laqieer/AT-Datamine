// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.DLCManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014B9")]
  public class DLCManager : SingletonMonoBehaviour<DLCManager>
  {
    [Token(Token = "0x4005F26")]
    [FieldOffset(Offset = "0x0")]
    public static readonly float TimeOut;
    [Token(Token = "0x4005F27")]
    [FieldOffset(Offset = "0x1C")]
    protected readonly int PARALELL_DOWNLOAD_MAX;
    [Token(Token = "0x4005F28")]
    [FieldOffset(Offset = "0x20")]
    protected readonly int RETRY_COUNT_MAX;
    [Token(Token = "0x4005F29")]
    [FieldOffset(Offset = "0x28")]
    private readonly long TOTAL_FILESIZE_LIMIT;
    [Token(Token = "0x4005F2A")]
    [FieldOffset(Offset = "0x8")]
    public static readonly long REQUIRED_STORAGE_SIZE;
    [Token(Token = "0x4005F2D")]
    [FieldOffset(Offset = "0x40")]
    private List<AssetBundleOperation> inProgressList;
    [Token(Token = "0x4005F32")]
    [FieldOffset(Offset = "0x50")]
    private List<DownloadAssetBundleData> downloadRequestList;
    [Token(Token = "0x4005F33")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<string, DownloadAssetBundleData> downloadingList;
    [Token(Token = "0x4005F34")]
    [FieldOffset(Offset = "0x60")]
    private Dictionary<string, string> downloadErrorList;
    [Token(Token = "0x4005F35")]
    [FieldOffset(Offset = "0x68")]
    private DLCProgress DlcProgress;
    [Token(Token = "0x4005F36")]
    [FieldOffset(Offset = "0x70")]
    private DownloadBufferPool DownloadBuffers;
    [Token(Token = "0x4005F37")]
    [FieldOffset(Offset = "0x78")]
    private long TotalDownloadingFileSize;
    [Token(Token = "0x4005F38")]
    [FieldOffset(Offset = "0x80")]
    private Coroutine removeAssetsCoroutine;
    [Token(Token = "0x4005F39")]
    [FieldOffset(Offset = "0x88")]
    private bool stopRemoveAssetsCoroutine;

    [Token(Token = "0x170011E4")]
    private List<string> CDNUrlList
    {
      [Token(Token = "0x60074AB"), Address(RVA = "0x43F1770", Offset = "0x43F1770", VA = "0x43F1770")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x60074AC"), Address(RVA = "0x43F1778", Offset = "0x43F1778", VA = "0x43F1778")] set
      {
      }
    }

    [Token(Token = "0x170011E5")]
    private int CDNIndex
    {
      [Token(Token = "0x60074AD"), Address(RVA = "0x43F1780", Offset = "0x43F1780", VA = "0x43F1780")] get
      {
        return new int();
      }
      [Token(Token = "0x60074AE"), Address(RVA = "0x43F1788", Offset = "0x43F1788", VA = "0x43F1788")] set
      {
      }
    }

    [Token(Token = "0x170011E6")]
    private bool IsDownload
    {
      [Token(Token = "0x60074AF"), Address(RVA = "0x43F1790", Offset = "0x43F1790", VA = "0x43F1790")] get
      {
        return new bool();
      }
      [Token(Token = "0x60074B0"), Address(RVA = "0x43F1798", Offset = "0x43F1798", VA = "0x43F1798")] set
      {
      }
    }

    [Token(Token = "0x170011E7")]
    private bool DownloadCancel
    {
      [Token(Token = "0x60074B1"), Address(RVA = "0x43F17A4", Offset = "0x43F17A4", VA = "0x43F17A4")] get
      {
        return new bool();
      }
      [Token(Token = "0x60074B2"), Address(RVA = "0x43F17AC", Offset = "0x43F17AC", VA = "0x43F17AC")] set
      {
      }
    }

    [Token(Token = "0x170011E8")]
    private bool DLCError
    {
      [Token(Token = "0x60074B3"), Address(RVA = "0x43F17B8", Offset = "0x43F17B8", VA = "0x43F17B8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60074B4"), Address(RVA = "0x43F17C0", Offset = "0x43F17C0", VA = "0x43F17C0")] set
      {
      }
    }

    [Token(Token = "0x170011E9")]
    private bool DiskFullError
    {
      [Token(Token = "0x60074B5"), Address(RVA = "0x43F17CC", Offset = "0x43F17CC", VA = "0x43F17CC")] get
      {
        return new bool();
      }
      [Token(Token = "0x60074B6"), Address(RVA = "0x43F17D4", Offset = "0x43F17D4", VA = "0x43F17D4")] set
      {
      }
    }

    [Token(Token = "0x170011EA")]
    public string DlcVersion
    {
      [Token(Token = "0x60074B7"), Address(RVA = "0x43F17E0", Offset = "0x43F17E0", VA = "0x43F17E0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60074B8"), Address(RVA = "0x43F17E8", Offset = "0x43F17E8", VA = "0x43F17E8")] private set
      {
      }
    }

    [Token(Token = "0x170011EB")]
    public bool IsCDNURLDownloaded
    {
      [Token(Token = "0x60074B9"), Address(RVA = "0x43F17F0", Offset = "0x43F17F0", VA = "0x43F17F0")] get
      {
        return new bool();
      }
      [Token(Token = "0x60074BA"), Address(RVA = "0x43F17F8", Offset = "0x43F17F8", VA = "0x43F17F8")] private set
      {
      }
    }

    [Token(Token = "0x170011EC")]
    public int DownloadMaxNum
    {
      [Token(Token = "0x60074BB"), Address(RVA = "0x43F1804", Offset = "0x43F1804", VA = "0x43F1804")] get
      {
        return new int();
      }
      [Token(Token = "0x60074BC"), Address(RVA = "0x43F180C", Offset = "0x43F180C", VA = "0x43F180C")] private set
      {
      }
    }

    [Token(Token = "0x170011ED")]
    public int DownloadNowNum
    {
      [Token(Token = "0x60074BD"), Address(RVA = "0x43F1814", Offset = "0x43F1814", VA = "0x43F1814")] get
      {
        return new int();
      }
      [Token(Token = "0x60074BE"), Address(RVA = "0x43F181C", Offset = "0x43F181C", VA = "0x43F181C")] private set
      {
      }
    }

    [Token(Token = "0x170011EE")]
    public string DownloadErrorMsg
    {
      [Token(Token = "0x60074BF"), Address(RVA = "0x43F1824", Offset = "0x43F1824", VA = "0x43F1824")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60074C0"), Address(RVA = "0x43F182C", Offset = "0x43F182C", VA = "0x43F182C")] private set
      {
      }
    }

    [Token(Token = "0x170011EF")]
    public int DownloadRequestCount
    {
      [Token(Token = "0x60074C1"), Address(RVA = "0x43EB28C", Offset = "0x43EB28C", VA = "0x43EB28C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011F0")]
    public int DownloadingCount
    {
      [Token(Token = "0x60074C2"), Address(RVA = "0x43EB37C", Offset = "0x43EB37C", VA = "0x43EB37C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60074C3")]
    [Address(RVA = "0x43F1834", Offset = "0x43F1834", VA = "0x43F1834")]
    public bool IsDownloadingAsset(string fileName) => new bool();

    [Token(Token = "0x170011F1")]
    public long TotalDownloadingSize
    {
      [Token(Token = "0x60074C4"), Address(RVA = "0x43F18A4", Offset = "0x43F18A4", VA = "0x43F18A4")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170011F2")]
    public long FreeDiskSize
    {
      [Token(Token = "0x60074C5"), Address(RVA = "0x43F18AC", Offset = "0x43F18AC", VA = "0x43F18AC")] get
      {
        return new long();
      }
      [Token(Token = "0x60074C6"), Address(RVA = "0x43F18B4", Offset = "0x43F18B4", VA = "0x43F18B4")] private set
      {
      }
    }

    [Token(Token = "0x60074C7")]
    [Address(RVA = "0x43F18BC", Offset = "0x43F18BC", VA = "0x43F18BC")]
    private void DownloadInit()
    {
    }

    [Token(Token = "0x60074C8")]
    [Address(RVA = "0x43F1B44", Offset = "0x43F1B44", VA = "0x43F1B44")]
    private void DownloadAssetBundleFileAsyncSuccessCallback(string fileName)
    {
    }

    [Token(Token = "0x60074C9")]
    [Address(RVA = "0x43F1B54", Offset = "0x43F1B54", VA = "0x43F1B54")]
    private void DownloadAssetBundleFileAsyncFailedCallback(string fileName)
    {
    }

    [Token(Token = "0x60074CA")]
    [Address(RVA = "0x43F1BB4", Offset = "0x43F1BB4", VA = "0x43F1BB4")]
    private DownloadAssetBundleData GetAlreadyDownloadRequest(string fileName)
    {
      return (DownloadAssetBundleData) null;
    }

    [Token(Token = "0x60074CB")]
    [Address(RVA = "0x43F1D38", Offset = "0x43F1D38", VA = "0x43F1D38")]
    private void AddDownloadRequestList(
      string fileName,
      AssetBundleDownloadOperation assetBundleDownloadOp)
    {
    }

    [Token(Token = "0x60074CC")]
    [Address(RVA = "0x43F20DC", Offset = "0x43F20DC", VA = "0x43F20DC")]
    private void Cancel(string fileName)
    {
    }

    [Token(Token = "0x60074CD")]
    [Address(RVA = "0x43F22EC", Offset = "0x43F22EC", VA = "0x43F22EC")]
    private void CancelInternal()
    {
    }

    [Token(Token = "0x60074CE")]
    [Address(RVA = "0x43F2510", Offset = "0x43F2510", VA = "0x43F2510")]
    public IEnumerator DownloadCDNURLs(Action successCallback = null, Action<string> failCallback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60074CF")]
    [Address(RVA = "0x43E99C4", Offset = "0x43E99C4", VA = "0x43E99C4")]
    public string GetCurrentCDNURL() => (string) null;

    [Token(Token = "0x60074D0")]
    [Address(RVA = "0x43E9A8C", Offset = "0x43E9A8C", VA = "0x43E9A8C")]
    public bool AddCDNURLIndex() => new bool();

    [Token(Token = "0x60074D1")]
    [Address(RVA = "0x43F25B4", Offset = "0x43F25B4", VA = "0x43F25B4")]
    public void CDNReset()
    {
    }

    [Token(Token = "0x60074D2")]
    [Address(RVA = "0x43E7FE8", Offset = "0x43E7FE8", VA = "0x43E7FE8")]
    public void DLCRetry()
    {
    }

    [Token(Token = "0x60074D3")]
    [Address(RVA = "0x43F262C", Offset = "0x43F262C", VA = "0x43F262C")]
    public void DLCCancel()
    {
    }

    [Token(Token = "0x60074D4")]
    [Address(RVA = "0x43F268C", Offset = "0x43F268C", VA = "0x43F268C")]
    public void DLCDownloadCancel()
    {
    }

    [Token(Token = "0x60074D5")]
    [Address(RVA = "0x43F1968", Offset = "0x43F1968", VA = "0x43F1968")]
    public long GetDownloadSize() => new long();

    [Token(Token = "0x60074D6")]
    [Address(RVA = "0x43EF478", Offset = "0x43EF478", VA = "0x43EF478")]
    public long GetDownloadAssetBundleFileSize(
      string[] downloadLabels,
      ref Dictionary<string, int> dic,
      bool isDependency = true)
    {
      return new long();
    }

    [Token(Token = "0x60074D7")]
    [Address(RVA = "0x43EFED8", Offset = "0x43EFED8", VA = "0x43EFED8")]
    public IEnumerator GetDownloadAssetBundleFileSizeAsync(
      string[] labelNames,
      UnityAction<long> result)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60074D8")]
    [Address(RVA = "0x43E803C", Offset = "0x43E803C", VA = "0x43E803C")]
    public bool AddDownloadAssetBundleFile(
      string fileName,
      bool isDependency = true,
      Action successCallback = null)
    {
      return new bool();
    }

    [Token(Token = "0x60074D9")]
    [Address(RVA = "0x43F27B4", Offset = "0x43F27B4", VA = "0x43F27B4")]
    public void AddDownloadAssetBundleAsync(string assetBundleLabelName, bool isDependency = true)
    {
    }

    [Token(Token = "0x60074DA")]
    [Address(RVA = "0x43F2878", Offset = "0x43F2878", VA = "0x43F2878")]
    public IEnumerator ShowDownloadPopup(long totalDownloadSize) => (IEnumerator) null;

    [Token(Token = "0x60074DB")]
    [Address(RVA = "0x43EB2D4", Offset = "0x43EB2D4", VA = "0x43EB2D4")]
    public IEnumerator Download(
      Action<DLCProgress> successCallback,
      Action<string, string[]> failedCallback,
      Action cancelCallback,
      Action<DLCProgress> progressCallback,
      Action<DLCProgress> sendLog = null,
      bool background = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60074DC")]
    [Address(RVA = "0x43EB41C", Offset = "0x43EB41C", VA = "0x43EB41C")]
    public IEnumerator ShowDownloadErrorPopup(
      string errorMessage,
      UnityAction<CommonPopup.ButtonType> callback,
      string[] files)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60074DD")]
    [Address(RVA = "0x43F2730", Offset = "0x43F2730", VA = "0x43F2730")]
    public void AddDownloadAssetBundle(AssetBundleDownloadOperation assetBundleDownloadOp)
    {
    }

    [Token(Token = "0x60074DE")]
    [Address(RVA = "0x43F2958", Offset = "0x43F2958", VA = "0x43F2958")]
    public void ClearCache(Action<DLCProgress> progressCallback, UnityAction callback = null)
    {
    }

    [Token(Token = "0x60074DF")]
    [Address(RVA = "0x43F29B4", Offset = "0x43F29B4", VA = "0x43F29B4")]
    private IEnumerator ClearCacheInternal(
      Action<DLCProgress> progressCallback,
      UnityAction callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60074E0")]
    [Address(RVA = "0x43F2A58", Offset = "0x43F2A58", VA = "0x43F2A58")]
    public void RemoveUnusedAssets()
    {
    }

    [Token(Token = "0x60074E1")]
    [Address(RVA = "0x43F2994", Offset = "0x43F2994", VA = "0x43F2994")]
    public void StopRemoveUnusedAssets()
    {
    }

    [Token(Token = "0x60074E2")]
    [Address(RVA = "0x43F2A88", Offset = "0x43F2A88", VA = "0x43F2A88")]
    private IEnumerator RemoveUnusedAssetsCoroutine() => (IEnumerator) null;

    [Token(Token = "0x60074E3")]
    [Address(RVA = "0x43F2B18", Offset = "0x43F2B18", VA = "0x43F2B18")]
    public DLCManager()
    {
    }

    [Token(Token = "0x60074E4")]
    [Address(RVA = "0x43F2D74", Offset = "0x43F2D74", VA = "0x43F2D74")]
    static DLCManager()
    {
    }
  }
}
