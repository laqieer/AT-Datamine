// Decompiled with JetBrains decompiler
// Type: Network.API.APIPresentList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DC5")]
  public class APIPresentList
  {
    [Token(Token = "0x4007F2C")]
    public const string DefaultAPIPath = "api/v1/present/list";
    [Token(Token = "0x4007F30")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007F31")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPresentListResponse> onSuccess;
    [Token(Token = "0x4007F32")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170022F8")]
    public APIPresentListRequest Request
    {
      [Token(Token = "0x600AFF2"), Address(RVA = "0x1A51D00", Offset = "0x1A51D00", VA = "0x1A51D00")] private get
      {
        return (APIPresentListRequest) null;
      }
      [Token(Token = "0x600AFF3"), Address(RVA = "0x1A51D08", Offset = "0x1A51D08", VA = "0x1A51D08")] set
      {
      }
    }

    [Token(Token = "0x170022F9")]
    public APIPresentListResponse Response
    {
      [Token(Token = "0x600AFF4"), Address(RVA = "0x1A51D10", Offset = "0x1A51D10", VA = "0x1A51D10")] get
      {
        return (APIPresentListResponse) null;
      }
      [Token(Token = "0x600AFF5"), Address(RVA = "0x1A51D18", Offset = "0x1A51D18", VA = "0x1A51D18")] private set
      {
      }
    }

    [Token(Token = "0x170022FA")]
    public int ResponseCode
    {
      [Token(Token = "0x600AFF6"), Address(RVA = "0x1A51D20", Offset = "0x1A51D20", VA = "0x1A51D20")] get
      {
        return new int();
      }
      [Token(Token = "0x600AFF7"), Address(RVA = "0x1A51D28", Offset = "0x1A51D28", VA = "0x1A51D28")] private set
      {
      }
    }

    [Token(Token = "0x170022FB")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AFF8"), Address(RVA = "0x1A51D30", Offset = "0x1A51D30", VA = "0x1A51D30")] set
      {
      }
      [Token(Token = "0x600AFF9"), Address(RVA = "0x1A51D4C", Offset = "0x1A51D4C", VA = "0x1A51D4C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AFFA")]
    [Address(RVA = "0x1A51D68", Offset = "0x1A51D68", VA = "0x1A51D68")]
    public APIPresentList(string apiPath = "api/v1/present/list")
    {
    }

    [Token(Token = "0x600AFFB")]
    [Address(RVA = "0x1A51E00", Offset = "0x1A51E00", VA = "0x1A51E00")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AFFC")]
    [Address(RVA = "0x1A51E90", Offset = "0x1A51E90", VA = "0x1A51E90")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AFFD")]
    [Address(RVA = "0x1A51E9C", Offset = "0x1A51E9C", VA = "0x1A51E9C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AFFE")]
    [Address(RVA = "0x1A51F70", Offset = "0x1A51F70", VA = "0x1A51F70")]
    private void OnSuccess(string json)
    {
    }
  }
}
