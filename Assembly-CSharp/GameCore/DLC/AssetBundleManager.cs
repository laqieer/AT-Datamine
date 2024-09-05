// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.AssetBundleManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x2001485")]
  public class AssetBundleManager : SingletonMonoBehaviour<AssetBundleManager>
  {
    [Token(Token = "0x4005E43")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int RetryMax;
    [Token(Token = "0x4005E44")]
    [FieldOffset(Offset = "0x4")]
    public static int ParalellLoadMax;
    [Token(Token = "0x4005E45")]
    [FieldOffset(Offset = "0x20")]
    private readonly string ErrorNotFoundAssetBundle;
    [Token(Token = "0x4005E46")]
    [FieldOffset(Offset = "0x28")]
    private readonly string ErrorNotFoundAssetBundleFileName;
    [Token(Token = "0x4005E47")]
    [FieldOffset(Offset = "0x30")]
    public readonly string JSON_FILE_NAME;
    [Token(Token = "0x4005E48")]
    [FieldOffset(Offset = "0x38")]
    private List<AssetBundleLoadAssetOperation> loadRequestOperationList;
    [Token(Token = "0x4005E49")]
    [FieldOffset(Offset = "0x40")]
    private List<string> loadRequestList;
    [Token(Token = "0x4005E4A")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<string, AssetBundleCreateRequest> loadingList;
    [Token(Token = "0x4005E4B")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<string, LoadedAssetBundle> loadedAssetBundle;
    [Token(Token = "0x4005E4C")]
    [FieldOffset(Offset = "0x58")]
    private List<string> loadSuccessAssetBundleList;
    [Token(Token = "0x4005E4D")]
    [FieldOffset(Offset = "0x60")]
    private Dictionary<string, string> loadAssetBundleErrorDic;
    [Token(Token = "0x4005E4E")]
    [FieldOffset(Offset = "0x68")]
    private Action<List<string>, Dictionary<string, string>> completeCollback;
    [Token(Token = "0x4005E4F")]
    [FieldOffset(Offset = "0x70")]
    private bool isLoadAsync;
    [Token(Token = "0x4005E50")]
    [FieldOffset(Offset = "0x78")]
    private AssetbundleInfoManager assetbundleInfoManager;
    [Token(Token = "0x4005E51")]
    [FieldOffset(Offset = "0x80")]
    private Dictionary<string, bool> downloadedFiles;
    [Token(Token = "0x4005E52")]
    [FieldOffset(Offset = "0x88")]
    private Dictionary<string, string[]> dependencies;
    [Token(Token = "0x4005E55")]
    [FieldOffset(Offset = "0xA0")]
    private Queue<AssetBundleManager.LoadAssetBundleParam> loadRequestParams;
    [Token(Token = "0x4005E56")]
    [FieldOffset(Offset = "0xA8")]
    private Dictionary<string, AssetBundleManager.LoadAssetBundleParam> loadingRequests;
    [Token(Token = "0x4005E57")]
    [FieldOffset(Offset = "0xB0")]
    private List<IEnumerator> loadEnumerators;

    [Token(Token = "0x6007372")]
    [Address(RVA = "0x4058E78", Offset = "0x4058E78", VA = "0x4058E78")]
    private bool IsIgnoreMainMiniDlc(int n) => new bool();

    [Token(Token = "0x6007373")]
    [Address(RVA = "0x4058E84", Offset = "0x4058E84", VA = "0x4058E84")]
    private bool IsIgnoreMainNormalDlc(int n) => new bool();

    [Token(Token = "0x6007374")]
    [Address(RVA = "0x4058E90", Offset = "0x4058E90", VA = "0x4058E90")]
    private bool IsBranchDlc(int n) => new bool();

    [Token(Token = "0x170011B0")]
    public bool IsLoadAsync
    {
      [Token(Token = "0x6007375"), Address(RVA = "0x4058E9C", Offset = "0x4058E9C", VA = "0x4058E9C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170011B1")]
    public bool IsAssetBundleInfoDownloaded
    {
      [Token(Token = "0x6007376"), Address(RVA = "0x4058EA4", Offset = "0x4058EA4", VA = "0x4058EA4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007377"), Address(RVA = "0x4058EAC", Offset = "0x4058EAC", VA = "0x4058EAC")] private set
      {
      }
    }

    [Token(Token = "0x170011B2")]
    public Dictionary<string, string> NeedDLFileDic
    {
      [Token(Token = "0x6007378"), Address(RVA = "0x4058EB8", Offset = "0x4058EB8", VA = "0x4058EB8")] get
      {
        return (Dictionary<string, string>) null;
      }
      [Token(Token = "0x6007379"), Address(RVA = "0x4058EC0", Offset = "0x4058EC0", VA = "0x4058EC0")] private set
      {
      }
    }

    [Token(Token = "0x600737A")]
    [Address(RVA = "0x4058EC8", Offset = "0x4058EC8", VA = "0x4058EC8")]
    private void AddLoadAssetBundle(AssetBundleLoadAssetOperation assetBundleLoadOp)
    {
    }

    [Token(Token = "0x600737B")]
    [Address(RVA = "0x405911C", Offset = "0x405911C", VA = "0x405911C")]
    private void LoadRequest(
      string fileName,
      string filePath,
      Action<string, string> success,
      Action<string, string> error)
    {
    }

    [Token(Token = "0x600737C")]
    [Address(RVA = "0x4059420", Offset = "0x4059420", VA = "0x4059420")]
    private IEnumerator LoadExec() => (IEnumerator) null;

    [Token(Token = "0x600737D")]
    [Address(RVA = "0x4059488", Offset = "0x4059488", VA = "0x4059488")]
    private IEnumerator coLoadAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x600737E")]
    [Address(RVA = "0x40594F0", Offset = "0x40594F0", VA = "0x40594F0")]
    private IEnumerator AssetBundleLoad(
      List<string> loadRequest,
      List<string> successList,
      Dictionary<string, string> errorList)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600737F")]
    [Address(RVA = "0x4059578", Offset = "0x4059578", VA = "0x4059578")]
    private IEnumerator LoadInternal(
      List<string> loadRequest,
      Action<List<string>, Dictionary<string, string>> completeCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007380")]
    [Address(RVA = "0x40595F4", Offset = "0x40595F4", VA = "0x40595F4")]
    private void DownloadSuccess(DLCProgress dlcProgress)
    {
    }

    [Token(Token = "0x6007381")]
    [Address(RVA = "0x40596D0", Offset = "0x40596D0", VA = "0x40596D0")]
    private void DownloadFailed(string message, string[] errorFiles)
    {
    }

    [Token(Token = "0x6007382")]
    [Address(RVA = "0x40596D4", Offset = "0x40596D4", VA = "0x40596D4")]
    private void Restart(string[] errorFiles)
    {
    }

    [Token(Token = "0x6007383")]
    [Address(RVA = "0x40597A4", Offset = "0x40597A4", VA = "0x40597A4")]
    private void DownloadCancel()
    {
    }

    [Token(Token = "0x6007384")]
    [Address(RVA = "0x40597A8", Offset = "0x40597A8", VA = "0x40597A8")]
    private void DownloadProgress(DLCProgress dlcProgress)
    {
    }

    [Token(Token = "0x6007385")]
    [Address(RVA = "0x4059884", Offset = "0x4059884", VA = "0x4059884")]
    private void LoadSuccess()
    {
    }

    [Token(Token = "0x6007386")]
    [Address(RVA = "0x4059A6C", Offset = "0x4059A6C", VA = "0x4059A6C")]
    private void LoadProgress()
    {
    }

    [Token(Token = "0x6007387")]
    [Address(RVA = "0x4059B8C", Offset = "0x4059B8C", VA = "0x4059B8C")]
    private string UnloadAssetBundle(
      string assetBundleName,
      LoadedAssetBundle assetBundle,
      out bool executeUnload)
    {
      return (string) null;
    }

    [Token(Token = "0x6007388")]
    [Address(RVA = "0x4059C90", Offset = "0x4059C90", VA = "0x4059C90")]
    private void UnloadAllLoadedAssetBundle()
    {
    }

    [Token(Token = "0x6007389")]
    [Address(RVA = "0x4059E10", Offset = "0x4059E10", VA = "0x4059E10")]
    private void CheckFileDownloadStateMap()
    {
    }

    [Token(Token = "0x600738A")]
    [Address(RVA = "0x405A3BC", Offset = "0x405A3BC", VA = "0x405A3BC")]
    private void GetDependenciesInternal(string fileName, List<string> list)
    {
    }

    [Token(Token = "0x600738B")]
    public T GetAsset<T>(string assetBundlelName, string assetName) where T : UnityEngine.Object
    {
      return (T) null;
    }

    [Token(Token = "0x600738C")]
    public IAssetLoadOperation<T> LoadAssetAsync<T>(
      string assetBundlname,
      string assetName,
      Action<T> resultCallback)
      where T : UnityEngine.Object
    {
      return (IAssetLoadOperation<T>) null;
    }

    [Token(Token = "0x600738D")]
    [Address(RVA = "0x4058DC8", Offset = "0x4058DC8", VA = "0x4058DC8")]
    public LoadedAssetBundle GetLoadedAssetBundle(string fileName, out string error)
    {
      return (LoadedAssetBundle) null;
    }

    [Token(Token = "0x600738E")]
    [Address(RVA = "0x4055B28", Offset = "0x4055B28", VA = "0x4055B28")]
    public LoadedAssetBundle GetLoadedAssetBundleLabelName(string labelName, out string error)
    {
      return (LoadedAssetBundle) null;
    }

    [Token(Token = "0x600738F")]
    [Address(RVA = "0x4053D2C", Offset = "0x4053D2C", VA = "0x4053D2C")]
    public IEnumerator LoadAsync(
      Action<List<string>, Dictionary<string, string>> cCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007390")]
    [Address(RVA = "0x405A888", Offset = "0x405A888", VA = "0x405A888")]
    public IEnumerator LoadAsync(
      List<string> loadRequest,
      Action<List<string>, Dictionary<string, string>> cCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007391")]
    [Address(RVA = "0x4053C18", Offset = "0x4053C18", VA = "0x4053C18")]
    public void AddLoadAssetBundle(
      string assetBundleLabelName,
      Action<string> successCallback = null,
      Action<string> failedCallback = null,
      bool isDependency = true)
    {
    }

    [Token(Token = "0x6007392")]
    [Address(RVA = "0x4053754", Offset = "0x4053754", VA = "0x4053754")]
    public string UnloadAssetBundle(string assetBundleName, bool isDependency = true)
    {
      return (string) null;
    }

    [Token(Token = "0x6007393")]
    [Address(RVA = "0x405A904", Offset = "0x405A904", VA = "0x405A904")]
    public IEnumerator LoadCancel() => (IEnumerator) null;

    [Token(Token = "0x6007394")]
    [Address(RVA = "0x40599EC", Offset = "0x40599EC", VA = "0x40599EC")]
    public int RequestCount() => new int();

    [Token(Token = "0x6007395")]
    [Address(RVA = "0x40599A4", Offset = "0x40599A4", VA = "0x40599A4")]
    public int SuccessCount() => new int();

    [Token(Token = "0x6007396")]
    [Address(RVA = "0x405A96C", Offset = "0x405A96C", VA = "0x405A96C")]
    public float Progress() => new float();

    [Token(Token = "0x6007397")]
    [Address(RVA = "0x405A9D8", Offset = "0x405A9D8", VA = "0x405A9D8")]
    public void Clear()
    {
    }

    [Token(Token = "0x6007398")]
    [Address(RVA = "0x405AB98", Offset = "0x405AB98", VA = "0x405AB98")]
    public void FinishDownloadAssetBundleInfo(Action successCallback = null)
    {
    }

    [Token(Token = "0x6007399")]
    [Address(RVA = "0x405ABD4", Offset = "0x405ABD4", VA = "0x405ABD4")]
    public string GetFileListPath() => (string) null;

    [Token(Token = "0x600739A")]
    [Address(RVA = "0x405ACA4", Offset = "0x405ACA4", VA = "0x405ACA4")]
    public IEnumerator DownloadAssetBundleInfo(
      Action successCallback = null,
      Func<string, IEnumerator> failCallback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600739B")]
    [Address(RVA = "0x405AD20", Offset = "0x405AD20", VA = "0x405AD20")]
    public bool IsFileDownloaded(string fileName) => new bool();

    [Token(Token = "0x600739C")]
    [Address(RVA = "0x405ADB8", Offset = "0x405ADB8", VA = "0x405ADB8")]
    public bool IsAssetBundleDownloaded(string assetBundleName) => new bool();

    [Token(Token = "0x600739D")]
    [Address(RVA = "0x405ADF8", Offset = "0x405ADF8", VA = "0x405ADF8")]
    public string GetAssetBundleName(string assetBundleName) => (string) null;

    [Token(Token = "0x600739E")]
    [Address(RVA = "0x405B11C", Offset = "0x405B11C", VA = "0x405B11C")]
    public bool IsExistAssetBundleIndex(string assetBundleName) => new bool();

    [Token(Token = "0x600739F")]
    [Address(RVA = "0x405B43C", Offset = "0x405B43C", VA = "0x405B43C")]
    public void SetFileDownloadState(string fileName, bool isDownloaded)
    {
    }

    [Token(Token = "0x60073A0")]
    [Address(RVA = "0x405B4A4", Offset = "0x405B4A4", VA = "0x405B4A4")]
    public void SetNeedDownloadFileList()
    {
    }

    [Token(Token = "0x60073A1")]
    [Address(RVA = "0x405B8F4", Offset = "0x405B8F4", VA = "0x405B8F4")]
    public string[] GetSplitDownloadFileList(
      AssetBundleManager.DlcSplitNumber splitNum,
      bool includeBranch = false)
    {
      return (string[]) null;
    }

    [Token(Token = "0x60073A2")]
    [Address(RVA = "0x405C680", Offset = "0x405C680", VA = "0x405C680")]
    public string[] GetServicsClosedDownloadFileList() => (string[]) null;

    [Token(Token = "0x60073A3")]
    [Address(RVA = "0x405C78C", Offset = "0x405C78C", VA = "0x405C78C")]
    public IEnumerator GetNeedDownloadAssetBundleList(Action<string[]> callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60073A4")]
    [Address(RVA = "0x405C800", Offset = "0x405C800", VA = "0x405C800")]
    public IEnumerator GetAllFileList(Action<string[]> callback) => (IEnumerator) null;

    [Token(Token = "0x60073A5")]
    [Address(RVA = "0x405C874", Offset = "0x405C874", VA = "0x405C874")]
    public IEnumerator GetNeedlessFileList(Action<string[]> callback) => (IEnumerator) null;

    [Token(Token = "0x60073A6")]
    [Address(RVA = "0x405A530", Offset = "0x405A530", VA = "0x405A530")]
    public string GetAssetBundleFileNameFromAssetBundleName(string assetBundleLabelName)
    {
      return (string) null;
    }

    [Token(Token = "0x60073A7")]
    [Address(RVA = "0x405C8E8", Offset = "0x405C8E8", VA = "0x405C8E8")]
    public int GetFileSize(string fileName) => new int();

    [Token(Token = "0x60073A8")]
    [Address(RVA = "0x405C978", Offset = "0x405C978", VA = "0x405C978")]
    public long GetFileSizeTotal(string[] fileList) => new long();

    [Token(Token = "0x60073A9")]
    [Address(RVA = "0x405CA5C", Offset = "0x405CA5C", VA = "0x405CA5C")]
    public long GetFileNamesAndSizes(string[] downloadLabels, ref Dictionary<string, int> dic)
    {
      return new long();
    }

    [Token(Token = "0x60073AA")]
    [Address(RVA = "0x4058918", Offset = "0x4058918", VA = "0x4058918")]
    public string[] GetDependencies(string fileName) => (string[]) null;

    [Token(Token = "0x60073AB")]
    [Address(RVA = "0x405CBE8", Offset = "0x405CBE8", VA = "0x405CBE8")]
    public string GetCheckSum(string fileName) => (string) null;

    [Token(Token = "0x60073AC")]
    [Address(RVA = "0x405CCA4", Offset = "0x405CCA4", VA = "0x405CCA4")]
    public void DeleteAssetBundle(string fileName)
    {
    }

    [Token(Token = "0x60073AD")]
    [Address(RVA = "0x405CE8C", Offset = "0x405CE8C", VA = "0x405CE8C")]
    public void DeleteAssetBundles(IEnumerable<string> assetLables)
    {
    }

    [Token(Token = "0x60073AE")]
    [Address(RVA = "0x405D1DC", Offset = "0x405D1DC", VA = "0x405D1DC")]
    public void DeleteLocalAssetBundleDirectory()
    {
    }

    [Token(Token = "0x60073AF")]
    [Address(RVA = "0x405D298", Offset = "0x405D298", VA = "0x405D298")]
    public List<string> GetDownloadedPrologueOnlyAssetLabels() => (List<string>) null;

    [Token(Token = "0x60073B0")]
    [Address(RVA = "0x405D48C", Offset = "0x405D48C", VA = "0x405D48C")]
    public List<string> GetCandidateForDeletions() => (List<string>) null;

    [Token(Token = "0x60073B1")]
    [Address(RVA = "0x405D550", Offset = "0x405D550", VA = "0x405D550")]
    public bool ContainsKeyInAssetBundleInfoLabelDic(string key) => new bool();

    [Token(Token = "0x60073B2")]
    [Address(RVA = "0x405D5B0", Offset = "0x405D5B0", VA = "0x405D5B0")]
    public bool ContainsKeyInAssetBundleInfoLocalizeLabelDic(string key) => new bool();

    [Token(Token = "0x60073B3")]
    [Address(RVA = "0x405D7D4", Offset = "0x405D7D4", VA = "0x405D7D4")]
    public AssetBundleManager()
    {
    }

    [Token(Token = "0x60073B4")]
    [Address(RVA = "0x405DBBC", Offset = "0x405DBBC", VA = "0x405DBBC")]
    static AssetBundleManager()
    {
    }

    [Token(Token = "0x2001486")]
    public enum DlcSplitNumber
    {
      [Token(Token = "0x4005E59")] All = 0,
      [Token(Token = "0x4005E5A")] Logo = 1,
      [Token(Token = "0x4005E5B")] Prologue = 2,
      [Token(Token = "0x4005E5C")] Main = 3,
      [Token(Token = "0x4005E5D")] MainNormalMode = 10, // 0x0000000A
      [Token(Token = "0x4005E5F")] Max = 11, // 0x0000000B
      [Token(Token = "0x4005E5E")] IgnoreMain = 20, // 0x00000014
    }

    [Token(Token = "0x2001487")]
    public enum DlcCandidateForDeletionCategory
    {
      [Token(Token = "0x4005E61")] PrologueOnly = 1,
    }

    [Token(Token = "0x2001488")]
    private class LoadAssetBundleParam
    {
      [Token(Token = "0x170011B3")]
      public string FilePath
      {
        [Token(Token = "0x60073B9"), Address(RVA = "0x43E7244", Offset = "0x43E7244", VA = "0x43E7244")] get
        {
          return (string) null;
        }
        [Token(Token = "0x60073BA"), Address(RVA = "0x43E724C", Offset = "0x43E724C", VA = "0x43E724C")] private set
        {
        }
      }

      [Token(Token = "0x170011B4")]
      public string FileName
      {
        [Token(Token = "0x60073BB"), Address(RVA = "0x43E7254", Offset = "0x43E7254", VA = "0x43E7254")] get
        {
          return (string) null;
        }
        [Token(Token = "0x60073BC"), Address(RVA = "0x43E725C", Offset = "0x43E725C", VA = "0x43E725C")] private set
        {
        }
      }

      [Token(Token = "0x140000F6")]
      private event Action<string, string> SuccessCallback
      {
        [Token(Token = "0x60073BD"), Address(RVA = "0x43E7264", Offset = "0x43E7264", VA = "0x43E7264")] add
        {
        }
        [Token(Token = "0x60073BE"), Address(RVA = "0x43E7314", Offset = "0x43E7314", VA = "0x43E7314")] remove
        {
        }
      }

      [Token(Token = "0x140000F7")]
      private event Action<string, string> ErrorCallback
      {
        [Token(Token = "0x60073BF"), Address(RVA = "0x43E73C4", Offset = "0x43E73C4", VA = "0x43E73C4")] add
        {
        }
        [Token(Token = "0x60073C0"), Address(RVA = "0x43E7474", Offset = "0x43E7474", VA = "0x43E7474")] remove
        {
        }
      }

      [Token(Token = "0x170011B5")]
      public int RequestCount
      {
        [Token(Token = "0x60073C1"), Address(RVA = "0x43E7524", Offset = "0x43E7524", VA = "0x43E7524")] get
        {
          return new int();
        }
        [Token(Token = "0x60073C2"), Address(RVA = "0x43E752C", Offset = "0x43E752C", VA = "0x43E752C")] private set
        {
        }
      }

      [Token(Token = "0x60073C3")]
      [Address(RVA = "0x43E7534", Offset = "0x43E7534", VA = "0x43E7534")]
      public LoadAssetBundleParam(string fileName, string filePath)
      {
      }

      [Token(Token = "0x60073C4")]
      [Address(RVA = "0x43E75A4", Offset = "0x43E75A4", VA = "0x43E75A4")]
      public void Success(string assetBundleName)
      {
      }

      [Token(Token = "0x60073C5")]
      [Address(RVA = "0x43E75C8", Offset = "0x43E75C8", VA = "0x43E75C8")]
      public void Error(string error)
      {
      }

      [Token(Token = "0x60073C6")]
      [Address(RVA = "0x43E75EC", Offset = "0x43E75EC", VA = "0x43E75EC")]
      public void AddRequest(Action<string, string> success, Action<string, string> error)
      {
      }
    }
  }
}
