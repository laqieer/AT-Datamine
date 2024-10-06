// Decompiled with JetBrains decompiler
// Type: Network.API.APILocations
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D4D")]
  public class APILocations
  {
    [Token(Token = "0x4007D2D")]
    public const string DefaultAPIPath = "pass/dlc/locations";
    [Token(Token = "0x4007D31")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007D32")]
    [FieldOffset(Offset = "0x30")]
    public Action<APILocationsResponse> onSuccess;
    [Token(Token = "0x4007D33")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170021B7")]
    public APILocationsRequest Request
    {
      [Token(Token = "0x600ACD1"), Address(RVA = "0x1A479D8", Offset = "0x1A479D8", VA = "0x1A479D8")] private get
      {
        return (APILocationsRequest) null;
      }
      [Token(Token = "0x600ACD2"), Address(RVA = "0x1A479E0", Offset = "0x1A479E0", VA = "0x1A479E0")] set
      {
      }
    }

    [Token(Token = "0x170021B8")]
    public APILocationsResponse Response
    {
      [Token(Token = "0x600ACD3"), Address(RVA = "0x1A479E8", Offset = "0x1A479E8", VA = "0x1A479E8")] get
      {
        return (APILocationsResponse) null;
      }
      [Token(Token = "0x600ACD4"), Address(RVA = "0x1A479F0", Offset = "0x1A479F0", VA = "0x1A479F0")] private set
      {
      }
    }

    [Token(Token = "0x170021B9")]
    public int ResponseCode
    {
      [Token(Token = "0x600ACD5"), Address(RVA = "0x1A479F8", Offset = "0x1A479F8", VA = "0x1A479F8")] get
      {
        return new int();
      }
      [Token(Token = "0x600ACD6"), Address(RVA = "0x1A47A00", Offset = "0x1A47A00", VA = "0x1A47A00")] private set
      {
      }
    }

    [Token(Token = "0x170021BA")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ACD7"), Address(RVA = "0x1A47A08", Offset = "0x1A47A08", VA = "0x1A47A08")] set
      {
      }
      [Token(Token = "0x600ACD8"), Address(RVA = "0x1A47A24", Offset = "0x1A47A24", VA = "0x1A47A24")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ACD9")]
    [Address(RVA = "0x1A47A40", Offset = "0x1A47A40", VA = "0x1A47A40")]
    public APILocations(string apiPath = "pass/dlc/locations")
    {
    }

    [Token(Token = "0x600ACDA")]
    [Address(RVA = "0x1A47AD8", Offset = "0x1A47AD8", VA = "0x1A47AD8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ACDB")]
    [Address(RVA = "0x1A47B68", Offset = "0x1A47B68", VA = "0x1A47B68")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ACDC")]
    [Address(RVA = "0x1A47B74", Offset = "0x1A47B74", VA = "0x1A47B74")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ACDD")]
    [Address(RVA = "0x1A47C48", Offset = "0x1A47C48", VA = "0x1A47C48")]
    private void OnSuccess(string json)
    {
    }
  }
}
