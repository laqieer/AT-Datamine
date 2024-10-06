// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.DownloadProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014B6")]
  public class DownloadProcess
  {
    [Token(Token = "0x4005F13")]
    [FieldOffset(Offset = "0x10")]
    private DownloadAssetBundleData downloadAssetBundleData;
    [Token(Token = "0x4005F14")]
    [FieldOffset(Offset = "0x18")]
    private string assetBundleUrl;
    [Token(Token = "0x4005F15")]
    [FieldOffset(Offset = "0x20")]
    private byte[] downloadBuffer;
    [Token(Token = "0x4005F16")]
    [FieldOffset(Offset = "0x28")]
    private string path;
    [Token(Token = "0x4005F17")]
    [FieldOffset(Offset = "0x30")]
    private string dirName;
    [Token(Token = "0x4005F18")]
    [FieldOffset(Offset = "0x38")]
    private string tempPath;
    [Token(Token = "0x4005F19")]
    [FieldOffset(Offset = "0x40")]
    private int index;
    [Token(Token = "0x4005F1A")]
    [FieldOffset(Offset = "0x44")]
    protected readonly int RETRY_COUNT_MAX;

    [Token(Token = "0x6007497")]
    [Address(RVA = "0x43EFF9C", Offset = "0x43EFF9C", VA = "0x43EFF9C")]
    public bool Setup(
      int index,
      byte[] downloadBuffer,
      DownloadAssetBundleData downloadAssetBundleData,
      string assetBundleUrl)
    {
      return new bool();
    }

    [Token(Token = "0x6007498")]
    [Address(RVA = "0x43F02E4", Offset = "0x43F02E4", VA = "0x43F02E4")]
    public DownloadProcess.StateType State() => new DownloadProcess.StateType();

    [Token(Token = "0x170011DF")]
    public int Index
    {
      [Token(Token = "0x6007499"), Address(RVA = "0x43F09F8", Offset = "0x43F09F8", VA = "0x43F09F8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011E0")]
    public string FileName
    {
      [Token(Token = "0x600749A"), Address(RVA = "0x43F0A00", Offset = "0x43F0A00", VA = "0x43F0A00")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011E1")]
    public string FilePath
    {
      [Token(Token = "0x600749B"), Address(RVA = "0x43F0A1C", Offset = "0x43F0A1C", VA = "0x43F0A1C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600749C")]
    [Address(RVA = "0x43F0A24", Offset = "0x43F0A24", VA = "0x43F0A24")]
    public string WebRequestError() => (string) null;

    [Token(Token = "0x170011E2")]
    public long DownloadedBytes
    {
      [Token(Token = "0x600749D"), Address(RVA = "0x43F0A48", Offset = "0x43F0A48", VA = "0x43F0A48")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170011E3")]
    public DownloadAssetBundleData AssetBundleData
    {
      [Token(Token = "0x600749E"), Address(RVA = "0x43F0A6C", Offset = "0x43F0A6C", VA = "0x43F0A6C")] get
      {
        return (DownloadAssetBundleData) null;
      }
    }

    [Token(Token = "0x600749F")]
    [Address(RVA = "0x43F0A74", Offset = "0x43F0A74", VA = "0x43F0A74")]
    public void Dispose()
    {
    }

    [Token(Token = "0x60074A0")]
    [Address(RVA = "0x43F0B00", Offset = "0x43F0B00", VA = "0x43F0B00")]
    public void OnDownloadFailed()
    {
    }

    [Token(Token = "0x60074A1")]
    [Address(RVA = "0x43F0D0C", Offset = "0x43F0D0C", VA = "0x43F0D0C")]
    public void OnDownloadFailed(string message)
    {
    }

    [Token(Token = "0x60074A2")]
    [Address(RVA = "0x43F0DB0", Offset = "0x43F0DB0", VA = "0x43F0DB0")]
    public void SaveRetry(string message)
    {
    }

    [Token(Token = "0x60074A3")]
    [Address(RVA = "0x43F0E7C", Offset = "0x43F0E7C", VA = "0x43F0E7C")]
    public void Retry()
    {
    }

    [Token(Token = "0x60074A4")]
    [Address(RVA = "0x43F0580", Offset = "0x43F0580", VA = "0x43F0580")]
    private bool HashCheck() => new bool();

    [Token(Token = "0x60074A5")]
    [Address(RVA = "0x43F1094", Offset = "0x43F1094", VA = "0x43F1094")]
    public void OnDownloadSucceed()
    {
    }

    [Token(Token = "0x60074A6")]
    [Address(RVA = "0x43F137C", Offset = "0x43F137C", VA = "0x43F137C")]
    public DownloadProcess()
    {
    }

    [Token(Token = "0x20014B7")]
    public enum StateType
    {
      [Token(Token = "0x4005F1C")] Continue,
      [Token(Token = "0x4005F1D")] Done,
      [Token(Token = "0x4005F1E")] Error,
      [Token(Token = "0x4005F1F")] WriteError,
      [Token(Token = "0x4005F20")] CheckSumError,
      [Token(Token = "0x4005F21")] Retry,
    }
  }
}
