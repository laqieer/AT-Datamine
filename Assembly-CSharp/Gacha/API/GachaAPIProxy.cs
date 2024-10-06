// Decompiled with JetBrains decompiler
// Type: Gacha.API.GachaAPIProxy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Gacha.API
{
  [Token(Token = "0x20015A3")]
  internal class GachaAPIProxy : IGachaListAPI
  {
    [Token(Token = "0x4006328")]
    [FieldOffset(Offset = "0x10")]
    private IGachaListAPI gachaListAPI;
    [Token(Token = "0x4006329")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, IGachaDetailAPI> gachaDetailAPI;
    [Token(Token = "0x400632A")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, IGachaPayAPI> gachaPayAPI;
    [Token(Token = "0x400632B")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<string, IGachaProvideInfoAPI> gachaProvideAPI;
    [Token(Token = "0x400632C")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<string, ISelectGachaSetTargetAPI> selectGachaSetTargetAPI;

    [Token(Token = "0x6007A93")]
    [Address(RVA = "0x229DD44", Offset = "0x229DD44", VA = "0x229DD44")]
    public GachaAPIProxy(MonoBehaviour coroutineRunner)
    {
    }

    [Token(Token = "0x6007A94")]
    [Address(RVA = "0x229E2A8", Offset = "0x229E2A8", VA = "0x229E2A8", Slot = "4")]
    public void RequestGachaList(Action<GachaListInfo> onSuccess, Action onError)
    {
    }

    [Token(Token = "0x6007A95")]
    [Address(RVA = "0x229E360", Offset = "0x229E360", VA = "0x229E360")]
    public void RequestGachaDetail(
      GachaDetailRequest request,
      Action<GachaDetailGroupInfo> onSuccess,
      Action onError)
    {
    }

    [Token(Token = "0x6007A96")]
    [Address(RVA = "0x229E464", Offset = "0x229E464", VA = "0x229E464")]
    public void RequestGachaPay(GachaPayRequest request, Action<GachaPayResult> onSuccess)
    {
    }

    [Token(Token = "0x6007A97")]
    [Address(RVA = "0x229E558", Offset = "0x229E558", VA = "0x229E558")]
    public void RequestGachaProvideInfo(
      GachaProvideInfoRequest request,
      Action<string, string> onSuccess)
    {
    }

    [Token(Token = "0x6007A98")]
    [Address(RVA = "0x229E64C", Offset = "0x229E64C", VA = "0x229E64C")]
    public void RequestSelectGachaSetTarget(
      SelectGachaRequest request,
      Action<SelectGachaSetTargetResult> onSuccess)
    {
    }
  }
}
