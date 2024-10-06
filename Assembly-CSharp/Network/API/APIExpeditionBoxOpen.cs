// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionBoxOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C1D")]
  public class APIExpeditionBoxOpen
  {
    [Token(Token = "0x4007851")]
    public const string DefaultAPIPath = "api/v1/expedition/box/open";
    [Token(Token = "0x4007855")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007856")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionBoxOpenResponse> onSuccess;
    [Token(Token = "0x4007857")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001EF9")]
    public APIExpeditionBoxOpenRequest Request
    {
      [Token(Token = "0x600A553"), Address(RVA = "0x1907510", Offset = "0x1907510", VA = "0x1907510")] private get
      {
        return (APIExpeditionBoxOpenRequest) null;
      }
      [Token(Token = "0x600A554"), Address(RVA = "0x1907518", Offset = "0x1907518", VA = "0x1907518")] set
      {
      }
    }

    [Token(Token = "0x17001EFA")]
    public APIExpeditionBoxOpenResponse Response
    {
      [Token(Token = "0x600A555"), Address(RVA = "0x1907520", Offset = "0x1907520", VA = "0x1907520")] get
      {
        return (APIExpeditionBoxOpenResponse) null;
      }
      [Token(Token = "0x600A556"), Address(RVA = "0x1907528", Offset = "0x1907528", VA = "0x1907528")] private set
      {
      }
    }

    [Token(Token = "0x17001EFB")]
    public int ResponseCode
    {
      [Token(Token = "0x600A557"), Address(RVA = "0x1907530", Offset = "0x1907530", VA = "0x1907530")] get
      {
        return new int();
      }
      [Token(Token = "0x600A558"), Address(RVA = "0x1907538", Offset = "0x1907538", VA = "0x1907538")] private set
      {
      }
    }

    [Token(Token = "0x17001EFC")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A559"), Address(RVA = "0x1907540", Offset = "0x1907540", VA = "0x1907540")] set
      {
      }
      [Token(Token = "0x600A55A"), Address(RVA = "0x190755C", Offset = "0x190755C", VA = "0x190755C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A55B")]
    [Address(RVA = "0x1907578", Offset = "0x1907578", VA = "0x1907578")]
    public APIExpeditionBoxOpen(string apiPath = "api/v1/expedition/box/open")
    {
    }

    [Token(Token = "0x600A55C")]
    [Address(RVA = "0x1907610", Offset = "0x1907610", VA = "0x1907610")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A55D")]
    [Address(RVA = "0x19076A0", Offset = "0x19076A0", VA = "0x19076A0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A55E")]
    [Address(RVA = "0x19076AC", Offset = "0x19076AC", VA = "0x19076AC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A55F")]
    [Address(RVA = "0x1907780", Offset = "0x1907780", VA = "0x1907780")]
    private void OnSuccess(string json)
    {
    }
  }
}
