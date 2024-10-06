// Decompiled with JetBrains decompiler
// Type: Network.API.APIHomeHot_deal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D31")]
  public class APIHomeHot_deal
  {
    [Token(Token = "0x4007CB5")]
    public const string DefaultAPIPath = "api/v1/home/hot_deal";
    [Token(Token = "0x4007CB9")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007CBA")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIHomeHot_dealResponse> onSuccess;
    [Token(Token = "0x4007CBB")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002177")]
    public APIHomeHot_dealRequest Request
    {
      [Token(Token = "0x600AC21"), Address(RVA = "0x1A4541C", Offset = "0x1A4541C", VA = "0x1A4541C")] private get
      {
        return (APIHomeHot_dealRequest) null;
      }
      [Token(Token = "0x600AC22"), Address(RVA = "0x1A45424", Offset = "0x1A45424", VA = "0x1A45424")] set
      {
      }
    }

    [Token(Token = "0x17002178")]
    public APIHomeHot_dealResponse Response
    {
      [Token(Token = "0x600AC23"), Address(RVA = "0x1A4542C", Offset = "0x1A4542C", VA = "0x1A4542C")] get
      {
        return (APIHomeHot_dealResponse) null;
      }
      [Token(Token = "0x600AC24"), Address(RVA = "0x1A45434", Offset = "0x1A45434", VA = "0x1A45434")] private set
      {
      }
    }

    [Token(Token = "0x17002179")]
    public int ResponseCode
    {
      [Token(Token = "0x600AC25"), Address(RVA = "0x1A4543C", Offset = "0x1A4543C", VA = "0x1A4543C")] get
      {
        return new int();
      }
      [Token(Token = "0x600AC26"), Address(RVA = "0x1A45444", Offset = "0x1A45444", VA = "0x1A45444")] private set
      {
      }
    }

    [Token(Token = "0x1700217A")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AC27"), Address(RVA = "0x1A4544C", Offset = "0x1A4544C", VA = "0x1A4544C")] set
      {
      }
      [Token(Token = "0x600AC28"), Address(RVA = "0x1A45468", Offset = "0x1A45468", VA = "0x1A45468")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AC29")]
    [Address(RVA = "0x1A45484", Offset = "0x1A45484", VA = "0x1A45484")]
    public APIHomeHot_deal(string apiPath = "api/v1/home/hot_deal")
    {
    }

    [Token(Token = "0x600AC2A")]
    [Address(RVA = "0x1A4551C", Offset = "0x1A4551C", VA = "0x1A4551C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AC2B")]
    [Address(RVA = "0x1A455AC", Offset = "0x1A455AC", VA = "0x1A455AC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AC2C")]
    [Address(RVA = "0x1A455B8", Offset = "0x1A455B8", VA = "0x1A455B8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AC2D")]
    [Address(RVA = "0x1A4568C", Offset = "0x1A4568C", VA = "0x1A4568C")]
    private void OnSuccess(string json)
    {
    }
  }
}
