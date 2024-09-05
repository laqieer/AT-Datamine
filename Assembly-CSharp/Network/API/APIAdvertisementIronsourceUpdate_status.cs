// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementIronsourceUpdate_status
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B5D")]
  public class APIAdvertisementIronsourceUpdate_status
  {
    [Token(Token = "0x400754B")]
    public const string DefaultAPIPath = "api/v1/advertisement/ironsource/update_status";
    [Token(Token = "0x400754F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007550")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAdvertisementIronsourceUpdate_statusResponse> onSuccess;
    [Token(Token = "0x4007551")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D4D")]
    public APIAdvertisementIronsourceUpdate_statusRequest Request
    {
      [Token(Token = "0x600A0A7"), Address(RVA = "0x46C525C", Offset = "0x46C525C", VA = "0x46C525C")] private get
      {
        return (APIAdvertisementIronsourceUpdate_statusRequest) null;
      }
      [Token(Token = "0x600A0A8"), Address(RVA = "0x46C5264", Offset = "0x46C5264", VA = "0x46C5264")] set
      {
      }
    }

    [Token(Token = "0x17001D4E")]
    public APIAdvertisementIronsourceUpdate_statusResponse Response
    {
      [Token(Token = "0x600A0A9"), Address(RVA = "0x46C526C", Offset = "0x46C526C", VA = "0x46C526C")] get
      {
        return (APIAdvertisementIronsourceUpdate_statusResponse) null;
      }
      [Token(Token = "0x600A0AA"), Address(RVA = "0x46C5274", Offset = "0x46C5274", VA = "0x46C5274")] private set
      {
      }
    }

    [Token(Token = "0x17001D4F")]
    public int ResponseCode
    {
      [Token(Token = "0x600A0AB"), Address(RVA = "0x46C527C", Offset = "0x46C527C", VA = "0x46C527C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A0AC"), Address(RVA = "0x46C5284", Offset = "0x46C5284", VA = "0x46C5284")] private set
      {
      }
    }

    [Token(Token = "0x17001D50")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A0AD"), Address(RVA = "0x46C528C", Offset = "0x46C528C", VA = "0x46C528C")] set
      {
      }
      [Token(Token = "0x600A0AE"), Address(RVA = "0x46C52A8", Offset = "0x46C52A8", VA = "0x46C52A8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A0AF")]
    [Address(RVA = "0x46C52C4", Offset = "0x46C52C4", VA = "0x46C52C4")]
    public APIAdvertisementIronsourceUpdate_status(string apiPath = "api/v1/advertisement/ironsource/update_status")
    {
    }

    [Token(Token = "0x600A0B0")]
    [Address(RVA = "0x46C535C", Offset = "0x46C535C", VA = "0x46C535C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A0B1")]
    [Address(RVA = "0x46C53EC", Offset = "0x46C53EC", VA = "0x46C53EC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A0B2")]
    [Address(RVA = "0x46C53F8", Offset = "0x46C53F8", VA = "0x46C53F8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A0B3")]
    [Address(RVA = "0x46C54CC", Offset = "0x46C54CC", VA = "0x46C54CC")]
    private void OnSuccess(string json)
    {
    }
  }
}
