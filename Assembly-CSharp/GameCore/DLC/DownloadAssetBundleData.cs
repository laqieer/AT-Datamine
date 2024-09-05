// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.DownloadAssetBundleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine.Networking;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014D3")]
  public class DownloadAssetBundleData
  {
    [Token(Token = "0x4005FD8")]
    [FieldOffset(Offset = "0x28")]
    private List<AssetBundleDownloadOperation> observerList;

    [Token(Token = "0x17001216")]
    public string FileName
    {
      [Token(Token = "0x6007570"), Address(RVA = "0x43F9668", Offset = "0x43F9668", VA = "0x43F9668")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007571"), Address(RVA = "0x43F9670", Offset = "0x43F9670", VA = "0x43F9670")] set
      {
      }
    }

    [Token(Token = "0x17001217")]
    public UnityWebRequest WebRequest
    {
      [Token(Token = "0x6007572"), Address(RVA = "0x43F9678", Offset = "0x43F9678", VA = "0x43F9678")] get
      {
        return (UnityWebRequest) null;
      }
      [Token(Token = "0x6007573"), Address(RVA = "0x43F9680", Offset = "0x43F9680", VA = "0x43F9680")] set
      {
      }
    }

    [Token(Token = "0x17001218")]
    public int RetryCount
    {
      [Token(Token = "0x6007574"), Address(RVA = "0x43F9688", Offset = "0x43F9688", VA = "0x43F9688")] get
      {
        return new int();
      }
      [Token(Token = "0x6007575"), Address(RVA = "0x43F9690", Offset = "0x43F9690", VA = "0x43F9690")] set
      {
      }
    }

    [Token(Token = "0x6007576")]
    [Address(RVA = "0x43F1F60", Offset = "0x43F1F60", VA = "0x43F1F60")]
    public void AddObserver(AssetBundleDownloadOperation observer)
    {
    }

    [Token(Token = "0x6007577")]
    [Address(RVA = "0x43F9698", Offset = "0x43F9698", VA = "0x43F9698")]
    public void RemoveObserver(AssetBundleDownloadOperation observer)
    {
    }

    [Token(Token = "0x6007578")]
    [Address(RVA = "0x43F1228", Offset = "0x43F1228", VA = "0x43F1228")]
    public void OnDownloadSucceed(string fileName)
    {
    }

    [Token(Token = "0x6007579")]
    [Address(RVA = "0x43F0BB8", Offset = "0x43F0BB8", VA = "0x43F0BB8")]
    public void OnDownloadFailed(string fileName, string error)
    {
    }

    [Token(Token = "0x600757A")]
    [Address(RVA = "0x43F2238", Offset = "0x43F2238", VA = "0x43F2238")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600757B")]
    [Address(RVA = "0x43F2034", Offset = "0x43F2034", VA = "0x43F2034")]
    public DownloadAssetBundleData()
    {
    }
  }
}
