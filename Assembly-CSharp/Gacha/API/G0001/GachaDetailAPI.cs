// Decompiled with JetBrains decompiler
// Type: Gacha.API.G0001.GachaDetailAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.API;
using StaqData;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Gacha.API.G0001
{
  [Token(Token = "0x20015B4")]
  internal class GachaDetailAPI : IGachaDetailAPI
  {
    [Token(Token = "0x400634B")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour coroutineRunner;

    [Token(Token = "0x6007ADE")]
    [Address(RVA = "0x229E208", Offset = "0x229E208", VA = "0x229E208")]
    public GachaDetailAPI(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x6007ADF")]
    [Address(RVA = "0x229EFE4", Offset = "0x229EFE4", VA = "0x229EFE4")]
    private Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x6007AE0")]
    [Address(RVA = "0x229F000", Offset = "0x229F000", VA = "0x229F000", Slot = "4")]
    public void RequestGachaDetail(
      GachaDetailRequest reequest,
      Action<GachaDetailGroupInfo> onSuccess,
      Action onError)
    {
    }

    [Token(Token = "0x6007AE1")]
    [Address(RVA = "0x229F0F4", Offset = "0x229F0F4", VA = "0x229F0F4")]
    private IEnumerator RequestStoryGachaDetailAsync(
      GachaDetailRequest reequest,
      Action<APIG0001DetailResponse> onSuccess,
      Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007AE2")]
    [Address(RVA = "0x229F1A4", Offset = "0x229F1A4", VA = "0x229F1A4")]
    private IEnumerator OnError(NetworkErrorResult networkErrorResult, Action errorCallback)
    {
      return (IEnumerator) null;
    }
  }
}
