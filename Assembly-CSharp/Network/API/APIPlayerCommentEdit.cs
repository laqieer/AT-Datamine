// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerCommentEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D8D")]
  public class APIPlayerCommentEdit
  {
    [Token(Token = "0x4007E2B")]
    public const string DefaultAPIPath = "api/v1/player/comment/edit";
    [Token(Token = "0x4007E2F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E30")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerCommentEditResponse> onSuccess;
    [Token(Token = "0x4007E31")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700224F")]
    public APIPlayerCommentEditRequest Request
    {
      [Token(Token = "0x600AE69"), Address(RVA = "0x1A4D040", Offset = "0x1A4D040", VA = "0x1A4D040")] private get
      {
        return (APIPlayerCommentEditRequest) null;
      }
      [Token(Token = "0x600AE6A"), Address(RVA = "0x1A4D048", Offset = "0x1A4D048", VA = "0x1A4D048")] set
      {
      }
    }

    [Token(Token = "0x17002250")]
    public APIPlayerCommentEditResponse Response
    {
      [Token(Token = "0x600AE6B"), Address(RVA = "0x1A4D050", Offset = "0x1A4D050", VA = "0x1A4D050")] get
      {
        return (APIPlayerCommentEditResponse) null;
      }
      [Token(Token = "0x600AE6C"), Address(RVA = "0x1A4D058", Offset = "0x1A4D058", VA = "0x1A4D058")] private set
      {
      }
    }

    [Token(Token = "0x17002251")]
    public int ResponseCode
    {
      [Token(Token = "0x600AE6D"), Address(RVA = "0x1A4D060", Offset = "0x1A4D060", VA = "0x1A4D060")] get
      {
        return new int();
      }
      [Token(Token = "0x600AE6E"), Address(RVA = "0x1A4D068", Offset = "0x1A4D068", VA = "0x1A4D068")] private set
      {
      }
    }

    [Token(Token = "0x17002252")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AE6F"), Address(RVA = "0x1A4D070", Offset = "0x1A4D070", VA = "0x1A4D070")] set
      {
      }
      [Token(Token = "0x600AE70"), Address(RVA = "0x1A4D08C", Offset = "0x1A4D08C", VA = "0x1A4D08C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AE71")]
    [Address(RVA = "0x1A4D0A8", Offset = "0x1A4D0A8", VA = "0x1A4D0A8")]
    public APIPlayerCommentEdit(string apiPath = "api/v1/player/comment/edit")
    {
    }

    [Token(Token = "0x600AE72")]
    [Address(RVA = "0x1A4D140", Offset = "0x1A4D140", VA = "0x1A4D140")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AE73")]
    [Address(RVA = "0x1A4D1D0", Offset = "0x1A4D1D0", VA = "0x1A4D1D0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AE74")]
    [Address(RVA = "0x1A4D1DC", Offset = "0x1A4D1DC", VA = "0x1A4D1DC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AE75")]
    [Address(RVA = "0x1A4D2B0", Offset = "0x1A4D2B0", VA = "0x1A4D2B0")]
    private void OnSuccess(string json)
    {
    }
  }
}
