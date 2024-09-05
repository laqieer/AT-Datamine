// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionPartyEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C21")]
  public class APIExpeditionPartyEdit
  {
    [Token(Token = "0x4007868")]
    public const string DefaultAPIPath = "api/v1/expedition/party/edit";
    [Token(Token = "0x400786C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400786D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionPartyEditResponse> onSuccess;
    [Token(Token = "0x400786E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F0A")]
    public APIExpeditionPartyEditRequest Request
    {
      [Token(Token = "0x600A574"), Address(RVA = "0x1907AB4", Offset = "0x1907AB4", VA = "0x1907AB4")] private get
      {
        return (APIExpeditionPartyEditRequest) null;
      }
      [Token(Token = "0x600A575"), Address(RVA = "0x1907ABC", Offset = "0x1907ABC", VA = "0x1907ABC")] set
      {
      }
    }

    [Token(Token = "0x17001F0B")]
    public APIExpeditionPartyEditResponse Response
    {
      [Token(Token = "0x600A576"), Address(RVA = "0x1907AC4", Offset = "0x1907AC4", VA = "0x1907AC4")] get
      {
        return (APIExpeditionPartyEditResponse) null;
      }
      [Token(Token = "0x600A577"), Address(RVA = "0x1907ACC", Offset = "0x1907ACC", VA = "0x1907ACC")] private set
      {
      }
    }

    [Token(Token = "0x17001F0C")]
    public int ResponseCode
    {
      [Token(Token = "0x600A578"), Address(RVA = "0x1907AD4", Offset = "0x1907AD4", VA = "0x1907AD4")] get
      {
        return new int();
      }
      [Token(Token = "0x600A579"), Address(RVA = "0x1907ADC", Offset = "0x1907ADC", VA = "0x1907ADC")] private set
      {
      }
    }

    [Token(Token = "0x17001F0D")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A57A"), Address(RVA = "0x1907AE4", Offset = "0x1907AE4", VA = "0x1907AE4")] set
      {
      }
      [Token(Token = "0x600A57B"), Address(RVA = "0x1907B00", Offset = "0x1907B00", VA = "0x1907B00")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A57C")]
    [Address(RVA = "0x1907B1C", Offset = "0x1907B1C", VA = "0x1907B1C")]
    public APIExpeditionPartyEdit(string apiPath = "api/v1/expedition/party/edit")
    {
    }

    [Token(Token = "0x600A57D")]
    [Address(RVA = "0x1907BB4", Offset = "0x1907BB4", VA = "0x1907BB4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A57E")]
    [Address(RVA = "0x1907C44", Offset = "0x1907C44", VA = "0x1907C44")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A57F")]
    [Address(RVA = "0x1907C50", Offset = "0x1907C50", VA = "0x1907C50")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A580")]
    [Address(RVA = "0x1907D24", Offset = "0x1907D24", VA = "0x1907D24")]
    private void OnSuccess(string json)
    {
    }
  }
}
