// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerLanguageEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DA1")]
  public class APIPlayerLanguageEdit
  {
    [Token(Token = "0x4007E6D")]
    public const string DefaultAPIPath = "api/v1/player/language/edit";
    [Token(Token = "0x4007E71")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E72")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerLanguageEditResponse> onSuccess;
    [Token(Token = "0x4007E73")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002274")]
    public APIPlayerLanguageEditRequest Request
    {
      [Token(Token = "0x600AEDE"), Address(RVA = "0x1A4EAF4", Offset = "0x1A4EAF4", VA = "0x1A4EAF4")] private get
      {
        return (APIPlayerLanguageEditRequest) null;
      }
      [Token(Token = "0x600AEDF"), Address(RVA = "0x1A4EAFC", Offset = "0x1A4EAFC", VA = "0x1A4EAFC")] set
      {
      }
    }

    [Token(Token = "0x17002275")]
    public APIPlayerLanguageEditResponse Response
    {
      [Token(Token = "0x600AEE0"), Address(RVA = "0x1A4EB04", Offset = "0x1A4EB04", VA = "0x1A4EB04")] get
      {
        return (APIPlayerLanguageEditResponse) null;
      }
      [Token(Token = "0x600AEE1"), Address(RVA = "0x1A4EB0C", Offset = "0x1A4EB0C", VA = "0x1A4EB0C")] private set
      {
      }
    }

    [Token(Token = "0x17002276")]
    public int ResponseCode
    {
      [Token(Token = "0x600AEE2"), Address(RVA = "0x1A4EB14", Offset = "0x1A4EB14", VA = "0x1A4EB14")] get
      {
        return new int();
      }
      [Token(Token = "0x600AEE3"), Address(RVA = "0x1A4EB1C", Offset = "0x1A4EB1C", VA = "0x1A4EB1C")] private set
      {
      }
    }

    [Token(Token = "0x17002277")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AEE4"), Address(RVA = "0x1A4EB24", Offset = "0x1A4EB24", VA = "0x1A4EB24")] set
      {
      }
      [Token(Token = "0x600AEE5"), Address(RVA = "0x1A4EB40", Offset = "0x1A4EB40", VA = "0x1A4EB40")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AEE6")]
    [Address(RVA = "0x1A4EB5C", Offset = "0x1A4EB5C", VA = "0x1A4EB5C")]
    public APIPlayerLanguageEdit(string apiPath = "api/v1/player/language/edit")
    {
    }

    [Token(Token = "0x600AEE7")]
    [Address(RVA = "0x1A4EBF4", Offset = "0x1A4EBF4", VA = "0x1A4EBF4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AEE8")]
    [Address(RVA = "0x1A4EC84", Offset = "0x1A4EC84", VA = "0x1A4EC84")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AEE9")]
    [Address(RVA = "0x1A4EC90", Offset = "0x1A4EC90", VA = "0x1A4EC90")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AEEA")]
    [Address(RVA = "0x1A4ED64", Offset = "0x1A4ED64", VA = "0x1A4ED64")]
    private void OnSuccess(string json)
    {
    }
  }
}
