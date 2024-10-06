// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerNameEdit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DA5")]
  public class APIPlayerNameEdit
  {
    [Token(Token = "0x4007E7A")]
    public const string DefaultAPIPath = "api/v1/player/name/edit";
    [Token(Token = "0x4007E7E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E7F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerNameEditResponse> onSuccess;
    [Token(Token = "0x4007E80")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700227B")]
    public APIPlayerNameEditRequest Request
    {
      [Token(Token = "0x600AEF5"), Address(RVA = "0x1A4F048", Offset = "0x1A4F048", VA = "0x1A4F048")] private get
      {
        return (APIPlayerNameEditRequest) null;
      }
      [Token(Token = "0x600AEF6"), Address(RVA = "0x1A4F050", Offset = "0x1A4F050", VA = "0x1A4F050")] set
      {
      }
    }

    [Token(Token = "0x1700227C")]
    public APIPlayerNameEditResponse Response
    {
      [Token(Token = "0x600AEF7"), Address(RVA = "0x1A4F058", Offset = "0x1A4F058", VA = "0x1A4F058")] get
      {
        return (APIPlayerNameEditResponse) null;
      }
      [Token(Token = "0x600AEF8"), Address(RVA = "0x1A4F060", Offset = "0x1A4F060", VA = "0x1A4F060")] private set
      {
      }
    }

    [Token(Token = "0x1700227D")]
    public int ResponseCode
    {
      [Token(Token = "0x600AEF9"), Address(RVA = "0x1A4F068", Offset = "0x1A4F068", VA = "0x1A4F068")] get
      {
        return new int();
      }
      [Token(Token = "0x600AEFA"), Address(RVA = "0x1A4F070", Offset = "0x1A4F070", VA = "0x1A4F070")] private set
      {
      }
    }

    [Token(Token = "0x1700227E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AEFB"), Address(RVA = "0x1A4F078", Offset = "0x1A4F078", VA = "0x1A4F078")] set
      {
      }
      [Token(Token = "0x600AEFC"), Address(RVA = "0x1A4F094", Offset = "0x1A4F094", VA = "0x1A4F094")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AEFD")]
    [Address(RVA = "0x1A4F0B0", Offset = "0x1A4F0B0", VA = "0x1A4F0B0")]
    public APIPlayerNameEdit(string apiPath = "api/v1/player/name/edit")
    {
    }

    [Token(Token = "0x600AEFE")]
    [Address(RVA = "0x1A4F148", Offset = "0x1A4F148", VA = "0x1A4F148")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AEFF")]
    [Address(RVA = "0x1A4F1D8", Offset = "0x1A4F1D8", VA = "0x1A4F1D8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AF00")]
    [Address(RVA = "0x1A4F1E4", Offset = "0x1A4F1E4", VA = "0x1A4F1E4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AF01")]
    [Address(RVA = "0x1A4F2B8", Offset = "0x1A4F2B8", VA = "0x1A4F2B8")]
    private void OnSuccess(string json)
    {
    }
  }
}
