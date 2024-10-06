// Decompiled with JetBrains decompiler
// Type: DataLinkage.DataLinkConnectorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F84")]
  public class DataLinkConnectorBase
  {
    [Token(Token = "0x40086DB")]
    [FieldOffset(Offset = "0x10")]
    protected MonoBehaviour coroutineRunner;

    [Token(Token = "0x600BB22")]
    [Address(RVA = "0x1E4B7CC", Offset = "0x1E4B7CC", VA = "0x1E4B7CC")]
    protected Coroutine StartCoroutine(IEnumerator enumerator) => (Coroutine) null;

    [Token(Token = "0x600BB23")]
    [Address(RVA = "0x1E4B7E8", Offset = "0x1E4B7E8", VA = "0x1E4B7E8")]
    public void RequestUpdatePlayerData(Action onFinished)
    {
    }

    [Token(Token = "0x600BB24")]
    [Address(RVA = "0x1E4B814", Offset = "0x1E4B814", VA = "0x1E4B814")]
    private IEnumerator RequestUpdatePlayerDataAsync(Action onFinished) => (IEnumerator) null;

    [Token(Token = "0x600BB25")]
    [Address(RVA = "0x1E4B8A4", Offset = "0x1E4B8A4", VA = "0x1E4B8A4")]
    protected IEnumerator RequestAPIMissionDatalinkAsync(
      DataLinkTypeEnum dataLinkTypeEnum,
      Action<APIMissionData_linkResponse> onSuccess)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600BB26")]
    [Address(RVA = "0x1E4B944", Offset = "0x1E4B944", VA = "0x1E4B944")]
    private IEnumerator OnAddDeviceError(string errorText, string errorCode) => (IEnumerator) null;

    [Token(Token = "0x600BB27")]
    [Address(RVA = "0x1E4B9CC", Offset = "0x1E4B9CC", VA = "0x1E4B9CC")]
    public DataLinkConnectorBase()
    {
    }
  }
}
