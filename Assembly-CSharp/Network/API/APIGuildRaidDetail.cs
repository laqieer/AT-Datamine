// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D11")]
  public class APIGuildRaidDetail
  {
    [Token(Token = "0x4007C30")]
    public const string DefaultAPIPath = "api/v1/guild/raid/detail";
    [Token(Token = "0x4007C34")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007C35")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildRaidDetailResponse> onSuccess;
    [Token(Token = "0x4007C36")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002129")]
    public APIGuildRaidDetailRequest Request
    {
      [Token(Token = "0x600AB53"), Address(RVA = "0x1A428DC", Offset = "0x1A428DC", VA = "0x1A428DC")] private get
      {
        return (APIGuildRaidDetailRequest) null;
      }
      [Token(Token = "0x600AB54"), Address(RVA = "0x1A428E4", Offset = "0x1A428E4", VA = "0x1A428E4")] set
      {
      }
    }

    [Token(Token = "0x1700212A")]
    public APIGuildRaidDetailResponse Response
    {
      [Token(Token = "0x600AB55"), Address(RVA = "0x1A428EC", Offset = "0x1A428EC", VA = "0x1A428EC")] get
      {
        return (APIGuildRaidDetailResponse) null;
      }
      [Token(Token = "0x600AB56"), Address(RVA = "0x1A428F4", Offset = "0x1A428F4", VA = "0x1A428F4")] private set
      {
      }
    }

    [Token(Token = "0x1700212B")]
    public int ResponseCode
    {
      [Token(Token = "0x600AB57"), Address(RVA = "0x1A428FC", Offset = "0x1A428FC", VA = "0x1A428FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600AB58"), Address(RVA = "0x1A42904", Offset = "0x1A42904", VA = "0x1A42904")] private set
      {
      }
    }

    [Token(Token = "0x1700212C")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AB59"), Address(RVA = "0x1A4290C", Offset = "0x1A4290C", VA = "0x1A4290C")] set
      {
      }
      [Token(Token = "0x600AB5A"), Address(RVA = "0x1A42928", Offset = "0x1A42928", VA = "0x1A42928")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AB5B")]
    [Address(RVA = "0x1A42944", Offset = "0x1A42944", VA = "0x1A42944")]
    public APIGuildRaidDetail(string apiPath = "api/v1/guild/raid/detail")
    {
    }

    [Token(Token = "0x600AB5C")]
    [Address(RVA = "0x1A429DC", Offset = "0x1A429DC", VA = "0x1A429DC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AB5D")]
    [Address(RVA = "0x1A42A6C", Offset = "0x1A42A6C", VA = "0x1A42A6C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AB5E")]
    [Address(RVA = "0x1A42A78", Offset = "0x1A42A78", VA = "0x1A42A78")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AB5F")]
    [Address(RVA = "0x1A42B4C", Offset = "0x1A42B4C", VA = "0x1A42B4C")]
    private void OnSuccess(string json)
    {
    }
  }
}
