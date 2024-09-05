// Decompiled with JetBrains decompiler
// Type: Network.API.APIDebugSerialList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BF5")]
  public class APIDebugSerialList
  {
    [Token(Token = "0x40077B2")]
    public const string DefaultAPIPath = "api/v1/debug/serial/list";
    [Token(Token = "0x40077B6")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40077B7")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDebugSerialListResponse> onSuccess;
    [Token(Token = "0x40077B8")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E9F")]
    public APIDebugSerialListRequest Request
    {
      [Token(Token = "0x600A459"), Address(RVA = "0x46D1F14", Offset = "0x46D1F14", VA = "0x46D1F14")] private get
      {
        return (APIDebugSerialListRequest) null;
      }
      [Token(Token = "0x600A45A"), Address(RVA = "0x46D1F1C", Offset = "0x46D1F1C", VA = "0x46D1F1C")] set
      {
      }
    }

    [Token(Token = "0x17001EA0")]
    public APIDebugSerialListResponse Response
    {
      [Token(Token = "0x600A45B"), Address(RVA = "0x46D1F24", Offset = "0x46D1F24", VA = "0x46D1F24")] get
      {
        return (APIDebugSerialListResponse) null;
      }
      [Token(Token = "0x600A45C"), Address(RVA = "0x46D1F2C", Offset = "0x46D1F2C", VA = "0x46D1F2C")] private set
      {
      }
    }

    [Token(Token = "0x17001EA1")]
    public int ResponseCode
    {
      [Token(Token = "0x600A45D"), Address(RVA = "0x46D1F34", Offset = "0x46D1F34", VA = "0x46D1F34")] get
      {
        return new int();
      }
      [Token(Token = "0x600A45E"), Address(RVA = "0x46D1F3C", Offset = "0x46D1F3C", VA = "0x46D1F3C")] private set
      {
      }
    }

    [Token(Token = "0x17001EA2")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A45F"), Address(RVA = "0x46D1F44", Offset = "0x46D1F44", VA = "0x46D1F44")] set
      {
      }
      [Token(Token = "0x600A460"), Address(RVA = "0x46D1F60", Offset = "0x46D1F60", VA = "0x46D1F60")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A461")]
    [Address(RVA = "0x46D1F7C", Offset = "0x46D1F7C", VA = "0x46D1F7C")]
    public APIDebugSerialList(string apiPath = "api/v1/debug/serial/list")
    {
    }

    [Token(Token = "0x600A462")]
    [Address(RVA = "0x46D2014", Offset = "0x46D2014", VA = "0x46D2014")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A463")]
    [Address(RVA = "0x46D20A4", Offset = "0x46D20A4", VA = "0x46D20A4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A464")]
    [Address(RVA = "0x46D20B0", Offset = "0x46D20B0", VA = "0x46D20B0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A465")]
    [Address(RVA = "0x46D2184", Offset = "0x46D2184", VA = "0x46D2184")]
    private void OnSuccess(string json)
    {
    }
  }
}
