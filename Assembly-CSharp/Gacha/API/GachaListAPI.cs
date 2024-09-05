// Decompiled with JetBrains decompiler
// Type: Gacha.API.GachaListAPI
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
namespace Gacha.API
{
  [Token(Token = "0x20015A4")]
  internal class GachaListAPI : IGachaListAPI
  {
    [Token(Token = "0x400632D")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour coroutineRunner;

    [Token(Token = "0x6007A99")]
    [Address(RVA = "0x229E168", Offset = "0x229E168", VA = "0x229E168")]
    public GachaListAPI(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x6007A9A")]
    [Address(RVA = "0x229E740", Offset = "0x229E740", VA = "0x229E740")]
    private Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x6007A9B")]
    [Address(RVA = "0x229E75C", Offset = "0x229E75C", VA = "0x229E75C", Slot = "4")]
    public void RequestGachaList(Action<GachaListInfo> onSuccess, Action onError)
    {
    }

    [Token(Token = "0x6007A9C")]
    [Address(RVA = "0x229E840", Offset = "0x229E840", VA = "0x229E840")]
    private IEnumerator RequestGachaAsync(Action<APIGachaResponse> onSuccess, Action onError)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007A9D")]
    [Address(RVA = "0x229E8E4", Offset = "0x229E8E4", VA = "0x229E8E4")]
    private IEnumerator OnError(NetworkErrorResult networkErrorResult, Action errorCallback)
    {
      return (IEnumerator) null;
    }
  }
}
