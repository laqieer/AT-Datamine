// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerApRecoveryItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D85")]
  public class APIPlayerApRecoveryItem
  {
    [Token(Token = "0x4007E11")]
    public const string DefaultAPIPath = "api/v1/player/ap/recovery/item";
    [Token(Token = "0x4007E15")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E16")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerApRecoveryItemResponse> onSuccess;
    [Token(Token = "0x4007E17")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002241")]
    public APIPlayerApRecoveryItemRequest Request
    {
      [Token(Token = "0x600AE3B"), Address(RVA = "0x1A4C598", Offset = "0x1A4C598", VA = "0x1A4C598")] private get
      {
        return (APIPlayerApRecoveryItemRequest) null;
      }
      [Token(Token = "0x600AE3C"), Address(RVA = "0x1A4C5A0", Offset = "0x1A4C5A0", VA = "0x1A4C5A0")] set
      {
      }
    }

    [Token(Token = "0x17002242")]
    public APIPlayerApRecoveryItemResponse Response
    {
      [Token(Token = "0x600AE3D"), Address(RVA = "0x1A4C5A8", Offset = "0x1A4C5A8", VA = "0x1A4C5A8")] get
      {
        return (APIPlayerApRecoveryItemResponse) null;
      }
      [Token(Token = "0x600AE3E"), Address(RVA = "0x1A4C5B0", Offset = "0x1A4C5B0", VA = "0x1A4C5B0")] private set
      {
      }
    }

    [Token(Token = "0x17002243")]
    public int ResponseCode
    {
      [Token(Token = "0x600AE3F"), Address(RVA = "0x1A4C5B8", Offset = "0x1A4C5B8", VA = "0x1A4C5B8")] get
      {
        return new int();
      }
      [Token(Token = "0x600AE40"), Address(RVA = "0x1A4C5C0", Offset = "0x1A4C5C0", VA = "0x1A4C5C0")] private set
      {
      }
    }

    [Token(Token = "0x17002244")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AE41"), Address(RVA = "0x1A4C5C8", Offset = "0x1A4C5C8", VA = "0x1A4C5C8")] set
      {
      }
      [Token(Token = "0x600AE42"), Address(RVA = "0x1A4C5E4", Offset = "0x1A4C5E4", VA = "0x1A4C5E4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AE43")]
    [Address(RVA = "0x1A4C600", Offset = "0x1A4C600", VA = "0x1A4C600")]
    public APIPlayerApRecoveryItem(string apiPath = "api/v1/player/ap/recovery/item")
    {
    }

    [Token(Token = "0x600AE44")]
    [Address(RVA = "0x1A4C698", Offset = "0x1A4C698", VA = "0x1A4C698")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AE45")]
    [Address(RVA = "0x1A4C728", Offset = "0x1A4C728", VA = "0x1A4C728")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AE46")]
    [Address(RVA = "0x1A4C734", Offset = "0x1A4C734", VA = "0x1A4C734")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AE47")]
    [Address(RVA = "0x1A4C808", Offset = "0x1A4C808", VA = "0x1A4C808")]
    private void OnSuccess(string json)
    {
    }
  }
}
