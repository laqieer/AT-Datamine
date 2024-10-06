// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRoleReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D1D")]
  public class APIGuildRoleReward
  {
    [Token(Token = "0x4007C5A")]
    public const string DefaultAPIPath = "api/v1/guild/role/reward";
    [Token(Token = "0x4007C5E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007C5F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildRoleRewardResponse> onSuccess;
    [Token(Token = "0x4007C60")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002142")]
    public APIGuildRoleRewardRequest Request
    {
      [Token(Token = "0x600AB9C"), Address(RVA = "0x1A438F8", Offset = "0x1A438F8", VA = "0x1A438F8")] private get
      {
        return (APIGuildRoleRewardRequest) null;
      }
      [Token(Token = "0x600AB9D"), Address(RVA = "0x1A43900", Offset = "0x1A43900", VA = "0x1A43900")] set
      {
      }
    }

    [Token(Token = "0x17002143")]
    public APIGuildRoleRewardResponse Response
    {
      [Token(Token = "0x600AB9E"), Address(RVA = "0x1A43908", Offset = "0x1A43908", VA = "0x1A43908")] get
      {
        return (APIGuildRoleRewardResponse) null;
      }
      [Token(Token = "0x600AB9F"), Address(RVA = "0x1A43910", Offset = "0x1A43910", VA = "0x1A43910")] private set
      {
      }
    }

    [Token(Token = "0x17002144")]
    public int ResponseCode
    {
      [Token(Token = "0x600ABA0"), Address(RVA = "0x1A43918", Offset = "0x1A43918", VA = "0x1A43918")] get
      {
        return new int();
      }
      [Token(Token = "0x600ABA1"), Address(RVA = "0x1A43920", Offset = "0x1A43920", VA = "0x1A43920")] private set
      {
      }
    }

    [Token(Token = "0x17002145")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ABA2"), Address(RVA = "0x1A43928", Offset = "0x1A43928", VA = "0x1A43928")] set
      {
      }
      [Token(Token = "0x600ABA3"), Address(RVA = "0x1A43944", Offset = "0x1A43944", VA = "0x1A43944")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ABA4")]
    [Address(RVA = "0x1A43960", Offset = "0x1A43960", VA = "0x1A43960")]
    public APIGuildRoleReward(string apiPath = "api/v1/guild/role/reward")
    {
    }

    [Token(Token = "0x600ABA5")]
    [Address(RVA = "0x1A439F8", Offset = "0x1A439F8", VA = "0x1A439F8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ABA6")]
    [Address(RVA = "0x1A43A88", Offset = "0x1A43A88", VA = "0x1A43A88")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ABA7")]
    [Address(RVA = "0x1A43A94", Offset = "0x1A43A94", VA = "0x1A43A94")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ABA8")]
    [Address(RVA = "0x1A43B68", Offset = "0x1A43B68", VA = "0x1A43B68")]
    private void OnSuccess(string json)
    {
    }
  }
}
