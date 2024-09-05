// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionBoxLevel_up
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C19")]
  public class APIExpeditionBoxLevel_up
  {
    [Token(Token = "0x400783B")]
    public const string DefaultAPIPath = "api/v1/expedition/box/level_up";
    [Token(Token = "0x400783F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007840")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionBoxLevel_upResponse> onSuccess;
    [Token(Token = "0x4007841")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001EE8")]
    public APIExpeditionBoxLevel_upRequest Request
    {
      [Token(Token = "0x600A532"), Address(RVA = "0x1906F6C", Offset = "0x1906F6C", VA = "0x1906F6C")] private get
      {
        return (APIExpeditionBoxLevel_upRequest) null;
      }
      [Token(Token = "0x600A533"), Address(RVA = "0x1906F74", Offset = "0x1906F74", VA = "0x1906F74")] set
      {
      }
    }

    [Token(Token = "0x17001EE9")]
    public APIExpeditionBoxLevel_upResponse Response
    {
      [Token(Token = "0x600A534"), Address(RVA = "0x1906F7C", Offset = "0x1906F7C", VA = "0x1906F7C")] get
      {
        return (APIExpeditionBoxLevel_upResponse) null;
      }
      [Token(Token = "0x600A535"), Address(RVA = "0x1906F84", Offset = "0x1906F84", VA = "0x1906F84")] private set
      {
      }
    }

    [Token(Token = "0x17001EEA")]
    public int ResponseCode
    {
      [Token(Token = "0x600A536"), Address(RVA = "0x1906F8C", Offset = "0x1906F8C", VA = "0x1906F8C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A537"), Address(RVA = "0x1906F94", Offset = "0x1906F94", VA = "0x1906F94")] private set
      {
      }
    }

    [Token(Token = "0x17001EEB")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A538"), Address(RVA = "0x1906F9C", Offset = "0x1906F9C", VA = "0x1906F9C")] set
      {
      }
      [Token(Token = "0x600A539"), Address(RVA = "0x1906FB8", Offset = "0x1906FB8", VA = "0x1906FB8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A53A")]
    [Address(RVA = "0x1906FD4", Offset = "0x1906FD4", VA = "0x1906FD4")]
    public APIExpeditionBoxLevel_up(string apiPath = "api/v1/expedition/box/level_up")
    {
    }

    [Token(Token = "0x600A53B")]
    [Address(RVA = "0x190706C", Offset = "0x190706C", VA = "0x190706C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A53C")]
    [Address(RVA = "0x19070FC", Offset = "0x19070FC", VA = "0x19070FC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A53D")]
    [Address(RVA = "0x1907108", Offset = "0x1907108", VA = "0x1907108")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A53E")]
    [Address(RVA = "0x19071DC", Offset = "0x19071DC", VA = "0x19071DC")]
    private void OnSuccess(string json)
    {
    }
  }
}
