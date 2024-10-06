// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D75")]
  public class APIMissionList
  {
    [Token(Token = "0x4007DD6")]
    public const string DefaultAPIPath = "api/v1/mission/list";
    [Token(Token = "0x4007DDA")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007DDB")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIMissionListResponse> onSuccess;
    [Token(Token = "0x4007DDC")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700221F")]
    public APIMissionListRequest Request
    {
      [Token(Token = "0x600ADD9"), Address(RVA = "0x1A4B028", Offset = "0x1A4B028", VA = "0x1A4B028")] private get
      {
        return (APIMissionListRequest) null;
      }
      [Token(Token = "0x600ADDA"), Address(RVA = "0x1A4B030", Offset = "0x1A4B030", VA = "0x1A4B030")] set
      {
      }
    }

    [Token(Token = "0x17002220")]
    public APIMissionListResponse Response
    {
      [Token(Token = "0x600ADDB"), Address(RVA = "0x1A4B038", Offset = "0x1A4B038", VA = "0x1A4B038")] get
      {
        return (APIMissionListResponse) null;
      }
      [Token(Token = "0x600ADDC"), Address(RVA = "0x1A4B040", Offset = "0x1A4B040", VA = "0x1A4B040")] private set
      {
      }
    }

    [Token(Token = "0x17002221")]
    public int ResponseCode
    {
      [Token(Token = "0x600ADDD"), Address(RVA = "0x1A4B048", Offset = "0x1A4B048", VA = "0x1A4B048")] get
      {
        return new int();
      }
      [Token(Token = "0x600ADDE"), Address(RVA = "0x1A4B050", Offset = "0x1A4B050", VA = "0x1A4B050")] private set
      {
      }
    }

    [Token(Token = "0x17002222")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ADDF"), Address(RVA = "0x1A4B058", Offset = "0x1A4B058", VA = "0x1A4B058")] set
      {
      }
      [Token(Token = "0x600ADE0"), Address(RVA = "0x1A4B074", Offset = "0x1A4B074", VA = "0x1A4B074")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ADE1")]
    [Address(RVA = "0x1A4B090", Offset = "0x1A4B090", VA = "0x1A4B090")]
    public APIMissionList(string apiPath = "api/v1/mission/list")
    {
    }

    [Token(Token = "0x600ADE2")]
    [Address(RVA = "0x1A4B128", Offset = "0x1A4B128", VA = "0x1A4B128")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ADE3")]
    [Address(RVA = "0x1A4B1B8", Offset = "0x1A4B1B8", VA = "0x1A4B1B8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ADE4")]
    [Address(RVA = "0x1A4B1C4", Offset = "0x1A4B1C4", VA = "0x1A4B1C4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ADE5")]
    [Address(RVA = "0x1A4B298", Offset = "0x1A4B298", VA = "0x1A4B298")]
    private void OnSuccess(string json)
    {
    }
  }
}
