// Decompiled with JetBrains decompiler
// Type: DMM.Games.Client.Sdk.Connection.NetgameApiConnector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DMM.Games.Client.Sdk.Model;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace DMM.Games.Client.Sdk.Connection
{
  [Token(Token = "0x2003FCB")]
  public class NetgameApiConnector
  {
    [Token(Token = "0x401177E")]
    [FieldOffset(Offset = "0x10")]
    protected MonoBehaviour sender;
    [Token(Token = "0x401177F")]
    [FieldOffset(Offset = "0x18")]
    protected string url;
    [Token(Token = "0x4011780")]
    [FieldOffset(Offset = "0x20")]
    protected RequestModel requestModel;

    [Token(Token = "0x6019A76")]
    [Address(RVA = "0x37878D4", Offset = "0x37878D4", VA = "0x37878D4")]
    public static NetgameApiConnector CreateUpdateToken(NetGameApiSdk sdk, RequestModel model)
    {
      return (NetgameApiConnector) null;
    }

    [Token(Token = "0x6019A77")]
    [Address(RVA = "0x3787E7C", Offset = "0x3787E7C", VA = "0x3787E7C")]
    public static NetgameApiConnector CreateRequest(NetGameApiSdk sdk, RequestModel model)
    {
      return (NetgameApiConnector) null;
    }

    [Token(Token = "0x6019A78")]
    [Address(RVA = "0x3788900", Offset = "0x3788900", VA = "0x3788900")]
    public static NetgameApiConnector Create(MonoBehaviour sender, string url)
    {
      return (NetgameApiConnector) null;
    }

    [Token(Token = "0x6019A79")]
    [Address(RVA = "0x3788970", Offset = "0x3788970", VA = "0x3788970")]
    protected NetgameApiConnector(MonoBehaviour sender, string url)
    {
    }

    [Token(Token = "0x6019A7A")]
    [Address(RVA = "0x378899C", Offset = "0x378899C", VA = "0x378899C")]
    public void SetRequestModel(RequestModel model)
    {
    }

    [Token(Token = "0x6019A7B")]
    [Address(RVA = "0x3787954", Offset = "0x3787954", VA = "0x3787954")]
    public void Send(Action<string> onSuccesCallback, Action<string> onFailedCallback)
    {
    }

    [Token(Token = "0x6019A7C")]
    [Address(RVA = "0x37889A4", Offset = "0x37889A4", VA = "0x37889A4")]
    protected IEnumerator SendCoroutine(
      string requestBody,
      Action<string> onSuccesCallback,
      Action<string> onFailedCallback)
    {
      return (IEnumerator) null;
    }
  }
}
