// Decompiled with JetBrains decompiler
// Type: Gacha.API.G0001.GachaPayAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using StaqData;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Gacha.API.G0001
{
  [Token(Token = "0x20015B9")]
  internal class GachaPayAPI : IGachaPayAPI
  {
    [Token(Token = "0x4006359")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour coroutineRunner;

    [Token(Token = "0x6007AF3")]
    [Address(RVA = "0x229E230", Offset = "0x229E230", VA = "0x229E230")]
    public GachaPayAPI(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x6007AF4")]
    [Address(RVA = "0x229F524", Offset = "0x229F524", VA = "0x229F524")]
    private Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x6007AF5")]
    [Address(RVA = "0x229F540", Offset = "0x229F540", VA = "0x229F540", Slot = "4")]
    public void RequestGachaPay(GachaPayRequest reequest, Action<GachaPayResult> onSuccess)
    {
    }

    [Token(Token = "0x6007AF6")]
    [Address(RVA = "0x229F620", Offset = "0x229F620", VA = "0x229F620")]
    private IEnumerator RequestStoryGachaPayAsync(
      GachaPayRequest reequest,
      Action<APIG0001PayResponse> onSuccess)
    {
      return (IEnumerator) null;
    }
  }
}
