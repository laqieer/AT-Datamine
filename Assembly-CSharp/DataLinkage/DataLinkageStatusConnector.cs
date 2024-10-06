// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkageStatusConnector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F7F")]
  public class DataLinkageStatusConnector
  {
    [Token(Token = "0x40086CE")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour coroutineRunner;

    [Token(Token = "0x600BAFE")]
    [Address(RVA = "0x1E4AA44", Offset = "0x1E4AA44", VA = "0x1E4AA44")]
    public DataLinkageStatusConnector(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x600BAFF")]
    [Address(RVA = "0x1E4B040", Offset = "0x1E4B040", VA = "0x1E4B040")]
    private Coroutine StartCoroutine(IEnumerator enumerator) => (Coroutine) null;

    [Token(Token = "0x600BB00")]
    [Address(RVA = "0x1E48C40", Offset = "0x1E48C40", VA = "0x1E48C40")]
    public void RequestDasConnectList(
      string secretKey,
      string deviceID,
      Action<APIDasConnectListResponse> onSuccess,
      Action onError)
    {
    }

    [Token(Token = "0x600BB01")]
    [Address(RVA = "0x1E4B05C", Offset = "0x1E4B05C", VA = "0x1E4B05C")]
    private IEnumerator RequestDasConnectListAsync(
      string secretKey,
      string deviceID,
      Action<APIDasConnectListResponse> onSuccess,
      Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BB02")]
    [Address(RVA = "0x1E4B114", Offset = "0x1E4B114", VA = "0x1E4B114")]
    private IEnumerator OnError(NetworkErrorResult networkErrorResult, Action errorCallback)
    {
      return (IEnumerator) null;
    }
  }
}
