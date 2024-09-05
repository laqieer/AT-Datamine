// Decompiled with JetBrains decompiler
// Type: Gacha.API.G0001.SelectGachaSetTargetAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Gacha.API.G0001
{
  [Token(Token = "0x20015C3")]
  internal class SelectGachaSetTargetAPI : ISelectGachaSetTargetAPI
  {
    [Token(Token = "0x4006375")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour coroutineRunner;

    [Token(Token = "0x6007B1E")]
    [Address(RVA = "0x229E280", Offset = "0x229E280", VA = "0x229E280")]
    public SelectGachaSetTargetAPI(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x6007B1F")]
    [Address(RVA = "0x22A0144", Offset = "0x22A0144", VA = "0x22A0144")]
    private Coroutine StartCoroutine(IEnumerator routine) => (Coroutine) null;

    [Token(Token = "0x6007B20")]
    [Address(RVA = "0x22A0160", Offset = "0x22A0160", VA = "0x22A0160", Slot = "4")]
    public void RequestSelectGachaSetTarget(
      SelectGachaRequest reequest,
      Action<SelectGachaSetTargetResult> onSuccess)
    {
    }

    [Token(Token = "0x6007B21")]
    [Address(RVA = "0x22A0240", Offset = "0x22A0240", VA = "0x22A0240")]
    private IEnumerator RequestSelectGachaSetTargetAsync(
      SelectGachaRequest reequest,
      Action<APIG0001Set_targetResponse> onSuccess)
    {
      return (IEnumerator) null;
    }
  }
}
