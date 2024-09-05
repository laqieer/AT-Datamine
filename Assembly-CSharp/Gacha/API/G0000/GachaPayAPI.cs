// Decompiled with JetBrains decompiler
// Type: Gacha.API.G0000.GachaPayAPI
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
namespace Gacha.API.G0000
{
  [Token(Token = "0x20015CB")]
  internal class GachaPayAPI : IGachaPayAPI
  {
    [Token(Token = "0x400638A")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour coroutineRunner;

    [Token(Token = "0x6007B3F")]
    [Address(RVA = "0x229E1B8", Offset = "0x229E1B8", VA = "0x229E1B8")]
    public GachaPayAPI(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x6007B40")]
    [Address(RVA = "0x22A09D0", Offset = "0x22A09D0", VA = "0x22A09D0")]
    private Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x6007B41")]
    [Address(RVA = "0x22A09EC", Offset = "0x22A09EC", VA = "0x22A09EC", Slot = "4")]
    public void RequestGachaPay(GachaPayRequest reequest, Action<GachaPayResult> onSuccess)
    {
    }

    [Token(Token = "0x6007B42")]
    [Address(RVA = "0x22A0ACC", Offset = "0x22A0ACC", VA = "0x22A0ACC")]
    private IEnumerator RequestStoryGachaPayAsync(
      GachaPayRequest reequest,
      Action<APIG0000PayResponse> onSuccess)
    {
      return (IEnumerator) null;
    }
  }
}
