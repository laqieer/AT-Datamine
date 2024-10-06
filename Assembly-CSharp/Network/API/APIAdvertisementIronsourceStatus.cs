// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementIronsourceStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B59")]
  public class APIAdvertisementIronsourceStatus
  {
    [Token(Token = "0x400753A")]
    public const string DefaultAPIPath = "api/v1/advertisement/ironsource/status";
    [Token(Token = "0x400753E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400753F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAdvertisementIronsourceStatusResponse> onSuccess;
    [Token(Token = "0x4007540")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D45")]
    public APIAdvertisementIronsourceStatusRequest Request
    {
      [Token(Token = "0x600A08F"), Address(RVA = "0x46C4D00", Offset = "0x46C4D00", VA = "0x46C4D00")] private get
      {
        return (APIAdvertisementIronsourceStatusRequest) null;
      }
      [Token(Token = "0x600A090"), Address(RVA = "0x46C4D08", Offset = "0x46C4D08", VA = "0x46C4D08")] set
      {
      }
    }

    [Token(Token = "0x17001D46")]
    public APIAdvertisementIronsourceStatusResponse Response
    {
      [Token(Token = "0x600A091"), Address(RVA = "0x46C4D10", Offset = "0x46C4D10", VA = "0x46C4D10")] get
      {
        return (APIAdvertisementIronsourceStatusResponse) null;
      }
      [Token(Token = "0x600A092"), Address(RVA = "0x46C4D18", Offset = "0x46C4D18", VA = "0x46C4D18")] private set
      {
      }
    }

    [Token(Token = "0x17001D47")]
    public int ResponseCode
    {
      [Token(Token = "0x600A093"), Address(RVA = "0x46C4D20", Offset = "0x46C4D20", VA = "0x46C4D20")] get
      {
        return new int();
      }
      [Token(Token = "0x600A094"), Address(RVA = "0x46C4D28", Offset = "0x46C4D28", VA = "0x46C4D28")] private set
      {
      }
    }

    [Token(Token = "0x17001D48")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A095"), Address(RVA = "0x46C4D30", Offset = "0x46C4D30", VA = "0x46C4D30")] set
      {
      }
      [Token(Token = "0x600A096"), Address(RVA = "0x46C4D4C", Offset = "0x46C4D4C", VA = "0x46C4D4C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A097")]
    [Address(RVA = "0x46C4D68", Offset = "0x46C4D68", VA = "0x46C4D68")]
    public APIAdvertisementIronsourceStatus(string apiPath = "api/v1/advertisement/ironsource/status")
    {
    }

    [Token(Token = "0x600A098")]
    [Address(RVA = "0x46C4E00", Offset = "0x46C4E00", VA = "0x46C4E00")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A099")]
    [Address(RVA = "0x46C4E90", Offset = "0x46C4E90", VA = "0x46C4E90")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A09A")]
    [Address(RVA = "0x46C4E9C", Offset = "0x46C4E9C", VA = "0x46C4E9C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A09B")]
    [Address(RVA = "0x46C4F70", Offset = "0x46C4F70", VA = "0x46C4F70")]
    private void OnSuccess(string json)
    {
    }
  }
}
