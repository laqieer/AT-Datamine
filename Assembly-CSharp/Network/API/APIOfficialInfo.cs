// Decompiled with JetBrains decompiler
// Type: Network.API.APIOfficialInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D79")]
  public class APIOfficialInfo
  {
    [Token(Token = "0x4007DE2")]
    public const string DefaultAPIPath = "api/v1/officialinfo";
    [Token(Token = "0x4007DE6")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007DE7")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIOfficialInfoResponse> onSuccess;
    [Token(Token = "0x4007DE8")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002226")]
    public APIOfficialInfoRequest Request
    {
      [Token(Token = "0x600ADF0"), Address(RVA = "0x1A4B574", Offset = "0x1A4B574", VA = "0x1A4B574")] private get
      {
        return (APIOfficialInfoRequest) null;
      }
      [Token(Token = "0x600ADF1"), Address(RVA = "0x1A4B57C", Offset = "0x1A4B57C", VA = "0x1A4B57C")] set
      {
      }
    }

    [Token(Token = "0x17002227")]
    public APIOfficialInfoResponse Response
    {
      [Token(Token = "0x600ADF2"), Address(RVA = "0x1A4B584", Offset = "0x1A4B584", VA = "0x1A4B584")] get
      {
        return (APIOfficialInfoResponse) null;
      }
      [Token(Token = "0x600ADF3"), Address(RVA = "0x1A4B58C", Offset = "0x1A4B58C", VA = "0x1A4B58C")] private set
      {
      }
    }

    [Token(Token = "0x17002228")]
    public int ResponseCode
    {
      [Token(Token = "0x600ADF4"), Address(RVA = "0x1A4B594", Offset = "0x1A4B594", VA = "0x1A4B594")] get
      {
        return new int();
      }
      [Token(Token = "0x600ADF5"), Address(RVA = "0x1A4B59C", Offset = "0x1A4B59C", VA = "0x1A4B59C")] private set
      {
      }
    }

    [Token(Token = "0x17002229")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ADF6"), Address(RVA = "0x1A4B5A4", Offset = "0x1A4B5A4", VA = "0x1A4B5A4")] set
      {
      }
      [Token(Token = "0x600ADF7"), Address(RVA = "0x1A4B5C0", Offset = "0x1A4B5C0", VA = "0x1A4B5C0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ADF8")]
    [Address(RVA = "0x1A4B5DC", Offset = "0x1A4B5DC", VA = "0x1A4B5DC")]
    public APIOfficialInfo(string apiPath = "api/v1/officialinfo")
    {
    }

    [Token(Token = "0x600ADF9")]
    [Address(RVA = "0x1A4B674", Offset = "0x1A4B674", VA = "0x1A4B674")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ADFA")]
    [Address(RVA = "0x1A4B704", Offset = "0x1A4B704", VA = "0x1A4B704")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ADFB")]
    [Address(RVA = "0x1A4B710", Offset = "0x1A4B710", VA = "0x1A4B710")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ADFC")]
    [Address(RVA = "0x1A4B7E4", Offset = "0x1A4B7E4", VA = "0x1A4B7E4")]
    private void OnSuccess(string json)
    {
    }
  }
}
