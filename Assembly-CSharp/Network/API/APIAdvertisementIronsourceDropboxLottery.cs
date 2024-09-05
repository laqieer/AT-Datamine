// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementIronsourceDropboxLottery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B55")]
  public class APIAdvertisementIronsourceDropboxLottery
  {
    [Token(Token = "0x400752C")]
    public const string DefaultAPIPath = "api/v1/advertisement/ironsource/dropbox/lottery";
    [Token(Token = "0x4007530")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007531")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAdvertisementIronsourceDropboxLotteryResponse> onSuccess;
    [Token(Token = "0x4007532")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D3E")]
    public APIAdvertisementIronsourceDropboxLotteryRequest Request
    {
      [Token(Token = "0x600A078"), Address(RVA = "0x46C47AC", Offset = "0x46C47AC", VA = "0x46C47AC")] private get
      {
        return (APIAdvertisementIronsourceDropboxLotteryRequest) null;
      }
      [Token(Token = "0x600A079"), Address(RVA = "0x46C47B4", Offset = "0x46C47B4", VA = "0x46C47B4")] set
      {
      }
    }

    [Token(Token = "0x17001D3F")]
    public APIAdvertisementIronsourceDropboxLotteryResponse Response
    {
      [Token(Token = "0x600A07A"), Address(RVA = "0x46C47BC", Offset = "0x46C47BC", VA = "0x46C47BC")] get
      {
        return (APIAdvertisementIronsourceDropboxLotteryResponse) null;
      }
      [Token(Token = "0x600A07B"), Address(RVA = "0x46C47C4", Offset = "0x46C47C4", VA = "0x46C47C4")] private set
      {
      }
    }

    [Token(Token = "0x17001D40")]
    public int ResponseCode
    {
      [Token(Token = "0x600A07C"), Address(RVA = "0x46C47CC", Offset = "0x46C47CC", VA = "0x46C47CC")] get
      {
        return new int();
      }
      [Token(Token = "0x600A07D"), Address(RVA = "0x46C47D4", Offset = "0x46C47D4", VA = "0x46C47D4")] private set
      {
      }
    }

    [Token(Token = "0x17001D41")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A07E"), Address(RVA = "0x46C47DC", Offset = "0x46C47DC", VA = "0x46C47DC")] set
      {
      }
      [Token(Token = "0x600A07F"), Address(RVA = "0x46C47F8", Offset = "0x46C47F8", VA = "0x46C47F8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A080")]
    [Address(RVA = "0x46C4814", Offset = "0x46C4814", VA = "0x46C4814")]
    public APIAdvertisementIronsourceDropboxLottery(string apiPath = "api/v1/advertisement/ironsource/dropbox/lottery")
    {
    }

    [Token(Token = "0x600A081")]
    [Address(RVA = "0x46C48AC", Offset = "0x46C48AC", VA = "0x46C48AC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A082")]
    [Address(RVA = "0x46C493C", Offset = "0x46C493C", VA = "0x46C493C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A083")]
    [Address(RVA = "0x46C4948", Offset = "0x46C4948", VA = "0x46C4948")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A084")]
    [Address(RVA = "0x46C4A1C", Offset = "0x46C4A1C", VA = "0x46C4A1C")]
    private void OnSuccess(string json)
    {
    }
  }
}
