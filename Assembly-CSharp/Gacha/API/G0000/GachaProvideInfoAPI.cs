// Decompiled with JetBrains decompiler
// Type: Gacha.API.G0000.GachaProvideInfoAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Gacha.API.G0000
{
  [Token(Token = "0x20015CE")]
  public class GachaProvideInfoAPI : IGachaProvideInfoAPI
  {
    [Token(Token = "0x4006391")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour coroutineRunner;

    [Token(Token = "0x6007B4B")]
    [Address(RVA = "0x229E1E0", Offset = "0x229E1E0", VA = "0x229E1E0")]
    public GachaProvideInfoAPI(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x6007B4C")]
    [Address(RVA = "0x22A0D20", Offset = "0x22A0D20", VA = "0x22A0D20")]
    private Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x6007B4D")]
    [Address(RVA = "0x22A0D3C", Offset = "0x22A0D3C", VA = "0x22A0D3C", Slot = "4")]
    public void RequestProvideInfo(
      GachaProvideInfoRequest request,
      Action<string, string> onSuccess)
    {
    }

    [Token(Token = "0x6007B4E")]
    [Address(RVA = "0x22A0D68", Offset = "0x22A0D68", VA = "0x22A0D68")]
    public IEnumerator RequestProvideInfoAsync(
      GachaProvideInfoRequest request,
      Action<string, string> onSuccess)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007B4F")]
    [Address(RVA = "0x22A0E0C", Offset = "0x22A0E0C", VA = "0x22A0E0C")]
    public IEnumerator RequestRatio(GachaProvideInfoRequest request, Action<string> onSuccess)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007B50")]
    [Address(RVA = "0x22A0EA8", Offset = "0x22A0EA8", VA = "0x22A0EA8")]
    public IEnumerator RequestDetail(GachaProvideInfoRequest request, Action<string> onSuccess)
    {
      return (IEnumerator) null;
    }
  }
}
