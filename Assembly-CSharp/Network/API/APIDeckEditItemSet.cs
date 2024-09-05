// Decompiled with JetBrains decompiler
// Type: Network.API.APIDeckEditItemSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BFD")]
  public class APIDeckEditItemSet
  {
    [Token(Token = "0x40077D1")]
    public const string DefaultAPIPath = "api/v1/deck/edit_item_set";
    [Token(Token = "0x40077D5")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40077D6")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDeckEditItemSetResponse> onSuccess;
    [Token(Token = "0x40077D7")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001EAE")]
    public APIDeckEditItemSetRequest Request
    {
      [Token(Token = "0x600A488"), Address(RVA = "0x46D29C4", Offset = "0x46D29C4", VA = "0x46D29C4")] private get
      {
        return (APIDeckEditItemSetRequest) null;
      }
      [Token(Token = "0x600A489"), Address(RVA = "0x46D29CC", Offset = "0x46D29CC", VA = "0x46D29CC")] set
      {
      }
    }

    [Token(Token = "0x17001EAF")]
    public APIDeckEditItemSetResponse Response
    {
      [Token(Token = "0x600A48A"), Address(RVA = "0x46D29D4", Offset = "0x46D29D4", VA = "0x46D29D4")] get
      {
        return (APIDeckEditItemSetResponse) null;
      }
      [Token(Token = "0x600A48B"), Address(RVA = "0x46D29DC", Offset = "0x46D29DC", VA = "0x46D29DC")] private set
      {
      }
    }

    [Token(Token = "0x17001EB0")]
    public int ResponseCode
    {
      [Token(Token = "0x600A48C"), Address(RVA = "0x46D29E4", Offset = "0x46D29E4", VA = "0x46D29E4")] get
      {
        return new int();
      }
      [Token(Token = "0x600A48D"), Address(RVA = "0x46D29EC", Offset = "0x46D29EC", VA = "0x46D29EC")] private set
      {
      }
    }

    [Token(Token = "0x17001EB1")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A48E"), Address(RVA = "0x46D29F4", Offset = "0x46D29F4", VA = "0x46D29F4")] set
      {
      }
      [Token(Token = "0x600A48F"), Address(RVA = "0x46D2A10", Offset = "0x46D2A10", VA = "0x46D2A10")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A490")]
    [Address(RVA = "0x46D2A2C", Offset = "0x46D2A2C", VA = "0x46D2A2C")]
    public APIDeckEditItemSet(string apiPath = "api/v1/deck/edit_item_set")
    {
    }

    [Token(Token = "0x600A491")]
    [Address(RVA = "0x46D2AC4", Offset = "0x46D2AC4", VA = "0x46D2AC4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A492")]
    [Address(RVA = "0x46D2B54", Offset = "0x46D2B54", VA = "0x46D2B54")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A493")]
    [Address(RVA = "0x46D2B60", Offset = "0x46D2B60", VA = "0x46D2B60")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A494")]
    [Address(RVA = "0x46D2C34", Offset = "0x46D2C34", VA = "0x46D2C34")]
    private void OnSuccess(string json)
    {
    }
  }
}
