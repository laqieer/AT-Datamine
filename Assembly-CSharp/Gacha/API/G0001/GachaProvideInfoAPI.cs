// Decompiled with JetBrains decompiler
// Type: Gacha.API.G0001.GachaProvideInfoAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Gacha.API.G0001
{
  [Token(Token = "0x20015BC")]
  public class GachaProvideInfoAPI : IGachaProvideInfoAPI
  {
    [Token(Token = "0x4006360")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour coroutineRunner;

    [Token(Token = "0x6007AFF")]
    [Address(RVA = "0x229E258", Offset = "0x229E258", VA = "0x229E258")]
    public GachaProvideInfoAPI(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x6007B00")]
    [Address(RVA = "0x229F874", Offset = "0x229F874", VA = "0x229F874")]
    private Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x6007B01")]
    [Address(RVA = "0x229F890", Offset = "0x229F890", VA = "0x229F890", Slot = "4")]
    public void RequestProvideInfo(
      GachaProvideInfoRequest request,
      Action<string, string> onSuccess)
    {
    }

    [Token(Token = "0x6007B02")]
    [Address(RVA = "0x229F8BC", Offset = "0x229F8BC", VA = "0x229F8BC")]
    public IEnumerator RequestProvideInfoAsync(
      GachaProvideInfoRequest request,
      Action<string, string> onSuccess)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007B03")]
    [Address(RVA = "0x229F960", Offset = "0x229F960", VA = "0x229F960")]
    public IEnumerator RequestRatio(GachaProvideInfoRequest request, Action<string> onSuccess)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007B04")]
    [Address(RVA = "0x229F9FC", Offset = "0x229F9FC", VA = "0x229F9FC")]
    public IEnumerator RequestDetail(GachaProvideInfoRequest request, Action<string> onSuccess)
    {
      return (IEnumerator) null;
    }
  }
}
