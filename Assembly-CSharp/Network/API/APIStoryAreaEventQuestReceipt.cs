// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryAreaEventQuestReceipt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E2D")]
  public class APIStoryAreaEventQuestReceipt
  {
    [Token(Token = "0x4008140")]
    public const string DefaultAPIPath = "api/v1/story/area_event/receipt";
    [Token(Token = "0x4008144")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008145")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryAreaEventQuestReceiptResponse> onSuccess;
    [Token(Token = "0x4008146")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002411")]
    public APIStoryAreaEventQuestReceiptRequest Request
    {
      [Token(Token = "0x600B2AB"), Address(RVA = "0x22E08F4", Offset = "0x22E08F4", VA = "0x22E08F4")] private get
      {
        return (APIStoryAreaEventQuestReceiptRequest) null;
      }
      [Token(Token = "0x600B2AC"), Address(RVA = "0x22E08FC", Offset = "0x22E08FC", VA = "0x22E08FC")] set
      {
      }
    }

    [Token(Token = "0x17002412")]
    public APIStoryAreaEventQuestReceiptResponse Response
    {
      [Token(Token = "0x600B2AD"), Address(RVA = "0x22E0904", Offset = "0x22E0904", VA = "0x22E0904")] get
      {
        return (APIStoryAreaEventQuestReceiptResponse) null;
      }
      [Token(Token = "0x600B2AE"), Address(RVA = "0x22E090C", Offset = "0x22E090C", VA = "0x22E090C")] private set
      {
      }
    }

    [Token(Token = "0x17002413")]
    public int ResponseCode
    {
      [Token(Token = "0x600B2AF"), Address(RVA = "0x22E0914", Offset = "0x22E0914", VA = "0x22E0914")] get
      {
        return new int();
      }
      [Token(Token = "0x600B2B0"), Address(RVA = "0x22E091C", Offset = "0x22E091C", VA = "0x22E091C")] private set
      {
      }
    }

    [Token(Token = "0x17002414")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B2B1"), Address(RVA = "0x22E0924", Offset = "0x22E0924", VA = "0x22E0924")] set
      {
      }
      [Token(Token = "0x600B2B2"), Address(RVA = "0x22E0940", Offset = "0x22E0940", VA = "0x22E0940")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B2B3")]
    [Address(RVA = "0x22E095C", Offset = "0x22E095C", VA = "0x22E095C")]
    public APIStoryAreaEventQuestReceipt(string apiPath = "api/v1/story/area_event/receipt")
    {
    }

    [Token(Token = "0x600B2B4")]
    [Address(RVA = "0x22E09F4", Offset = "0x22E09F4", VA = "0x22E09F4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B2B5")]
    [Address(RVA = "0x22E0A84", Offset = "0x22E0A84", VA = "0x22E0A84")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B2B6")]
    [Address(RVA = "0x22E0A90", Offset = "0x22E0A90", VA = "0x22E0A90")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B2B7")]
    [Address(RVA = "0x22E0B64", Offset = "0x22E0B64", VA = "0x22E0B64")]
    private void OnSuccess(string json)
    {
    }
  }
}
