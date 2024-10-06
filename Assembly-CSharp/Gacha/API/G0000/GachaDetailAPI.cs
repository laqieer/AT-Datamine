// Decompiled with JetBrains decompiler
// Type: Gacha.API.G0000.GachaDetailAPI
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
namespace Gacha.API.G0000
{
  [Token(Token = "0x20015C6")]
  internal class GachaDetailAPI : IGachaDetailAPI
  {
    [Token(Token = "0x400637C")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour coroutineRunner;

    [Token(Token = "0x6007B2A")]
    [Address(RVA = "0x229E190", Offset = "0x229E190", VA = "0x229E190")]
    public GachaDetailAPI(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x6007B2B")]
    [Address(RVA = "0x22A0490", Offset = "0x22A0490", VA = "0x22A0490")]
    private Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x6007B2C")]
    [Address(RVA = "0x22A04AC", Offset = "0x22A04AC", VA = "0x22A04AC", Slot = "4")]
    public void RequestGachaDetail(
      GachaDetailRequest reequest,
      Action<GachaDetailGroupInfo> onSuccess,
      Action onError)
    {
    }

    [Token(Token = "0x6007B2D")]
    [Address(RVA = "0x22A05A0", Offset = "0x22A05A0", VA = "0x22A05A0")]
    private IEnumerator RequestStoryGachaDetailAsync(
      GachaDetailRequest reequest,
      Action<APIG0000DetailResponse> onSuccess,
      Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007B2E")]
    [Address(RVA = "0x22A0650", Offset = "0x22A0650", VA = "0x22A0650")]
    private IEnumerator OnError(NetworkErrorResult networkErrorResult, Action errorCallback)
    {
      return (IEnumerator) null;
    }
  }
}
