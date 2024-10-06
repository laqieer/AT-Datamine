// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatHistory_pin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BCD")]
  public class APIChatHistory_pin
  {
    [Token(Token = "0x400771A")]
    public const string DefaultAPIPath = "api/v1/chat/history_pin";
    [Token(Token = "0x400771E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400771F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIChatHistory_pinResponse> onSuccess;
    [Token(Token = "0x4007720")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E48")]
    public APIChatHistory_pinRequest Request
    {
      [Token(Token = "0x600A362"), Address(RVA = "0x46CE944", Offset = "0x46CE944", VA = "0x46CE944")] private get
      {
        return (APIChatHistory_pinRequest) null;
      }
      [Token(Token = "0x600A363"), Address(RVA = "0x46CE94C", Offset = "0x46CE94C", VA = "0x46CE94C")] set
      {
      }
    }

    [Token(Token = "0x17001E49")]
    public APIChatHistory_pinResponse Response
    {
      [Token(Token = "0x600A364"), Address(RVA = "0x46CE954", Offset = "0x46CE954", VA = "0x46CE954")] get
      {
        return (APIChatHistory_pinResponse) null;
      }
      [Token(Token = "0x600A365"), Address(RVA = "0x46CE95C", Offset = "0x46CE95C", VA = "0x46CE95C")] private set
      {
      }
    }

    [Token(Token = "0x17001E4A")]
    public int ResponseCode
    {
      [Token(Token = "0x600A366"), Address(RVA = "0x46CE964", Offset = "0x46CE964", VA = "0x46CE964")] get
      {
        return new int();
      }
      [Token(Token = "0x600A367"), Address(RVA = "0x46CE96C", Offset = "0x46CE96C", VA = "0x46CE96C")] private set
      {
      }
    }

    [Token(Token = "0x17001E4B")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A368"), Address(RVA = "0x46CE974", Offset = "0x46CE974", VA = "0x46CE974")] set
      {
      }
      [Token(Token = "0x600A369"), Address(RVA = "0x46CE990", Offset = "0x46CE990", VA = "0x46CE990")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A36A")]
    [Address(RVA = "0x46CE9AC", Offset = "0x46CE9AC", VA = "0x46CE9AC")]
    public APIChatHistory_pin(string apiPath = "api/v1/chat/history_pin")
    {
    }

    [Token(Token = "0x600A36B")]
    [Address(RVA = "0x46CEA44", Offset = "0x46CEA44", VA = "0x46CEA44")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A36C")]
    [Address(RVA = "0x46CEAD4", Offset = "0x46CEAD4", VA = "0x46CEAD4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A36D")]
    [Address(RVA = "0x46CEAE0", Offset = "0x46CEAE0", VA = "0x46CEAE0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A36E")]
    [Address(RVA = "0x46CEBB4", Offset = "0x46CEBB4", VA = "0x46CEBB4")]
    private void OnSuccess(string json)
    {
    }
  }
}
