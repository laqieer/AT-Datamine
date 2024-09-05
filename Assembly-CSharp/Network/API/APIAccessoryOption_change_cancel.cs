// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryOption_change_cancel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B41")]
  public class APIAccessoryOption_change_cancel
  {
    [Token(Token = "0x40074E4")]
    public const string DefaultAPIPath = "api/v1/accessory/option_change_cancel";
    [Token(Token = "0x40074E8")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40074E9")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAccessoryOption_change_cancelResponse> onSuccess;
    [Token(Token = "0x40074EA")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D15")]
    public APIAccessoryOption_change_cancelRequest Request
    {
      [Token(Token = "0x6009FFF"), Address(RVA = "0x46C2CD8", Offset = "0x46C2CD8", VA = "0x46C2CD8")] private get
      {
        return (APIAccessoryOption_change_cancelRequest) null;
      }
      [Token(Token = "0x600A000"), Address(RVA = "0x46C2CE0", Offset = "0x46C2CE0", VA = "0x46C2CE0")] set
      {
      }
    }

    [Token(Token = "0x17001D16")]
    public APIAccessoryOption_change_cancelResponse Response
    {
      [Token(Token = "0x600A001"), Address(RVA = "0x46C2CE8", Offset = "0x46C2CE8", VA = "0x46C2CE8")] get
      {
        return (APIAccessoryOption_change_cancelResponse) null;
      }
      [Token(Token = "0x600A002"), Address(RVA = "0x46C2CF0", Offset = "0x46C2CF0", VA = "0x46C2CF0")] private set
      {
      }
    }

    [Token(Token = "0x17001D17")]
    public int ResponseCode
    {
      [Token(Token = "0x600A003"), Address(RVA = "0x46C2CF8", Offset = "0x46C2CF8", VA = "0x46C2CF8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A004"), Address(RVA = "0x46C2D00", Offset = "0x46C2D00", VA = "0x46C2D00")] private set
      {
      }
    }

    [Token(Token = "0x17001D18")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A005"), Address(RVA = "0x46C2D08", Offset = "0x46C2D08", VA = "0x46C2D08")] set
      {
      }
      [Token(Token = "0x600A006"), Address(RVA = "0x46C2D24", Offset = "0x46C2D24", VA = "0x46C2D24")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A007")]
    [Address(RVA = "0x46C2D40", Offset = "0x46C2D40", VA = "0x46C2D40")]
    public APIAccessoryOption_change_cancel(string apiPath = "api/v1/accessory/option_change_cancel")
    {
    }

    [Token(Token = "0x600A008")]
    [Address(RVA = "0x46C2DD8", Offset = "0x46C2DD8", VA = "0x46C2DD8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A009")]
    [Address(RVA = "0x46C2E68", Offset = "0x46C2E68", VA = "0x46C2E68")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A00A")]
    [Address(RVA = "0x46C2E74", Offset = "0x46C2E74", VA = "0x46C2E74")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A00B")]
    [Address(RVA = "0x46C2F48", Offset = "0x46C2F48", VA = "0x46C2F48")]
    private void OnSuccess(string json)
    {
    }
  }
}
