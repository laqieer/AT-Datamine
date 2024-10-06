// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D09")]
  public class APIGuildRaidBattleEnd
  {
    [Token(Token = "0x4007C08")]
    public const string DefaultAPIPath = "api/v1/guild/raid/battle/end";
    [Token(Token = "0x4007C0C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007C0D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildRaidBattleEndResponse> onSuccess;
    [Token(Token = "0x4007C0E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002115")]
    public APIGuildRaidBattleEndRequest Request
    {
      [Token(Token = "0x600AB1F"), Address(RVA = "0x1A41E04", Offset = "0x1A41E04", VA = "0x1A41E04")] private get
      {
        return (APIGuildRaidBattleEndRequest) null;
      }
      [Token(Token = "0x600AB20"), Address(RVA = "0x1A41E0C", Offset = "0x1A41E0C", VA = "0x1A41E0C")] set
      {
      }
    }

    [Token(Token = "0x17002116")]
    public APIGuildRaidBattleEndResponse Response
    {
      [Token(Token = "0x600AB21"), Address(RVA = "0x1A41E14", Offset = "0x1A41E14", VA = "0x1A41E14")] get
      {
        return (APIGuildRaidBattleEndResponse) null;
      }
      [Token(Token = "0x600AB22"), Address(RVA = "0x1A41E1C", Offset = "0x1A41E1C", VA = "0x1A41E1C")] private set
      {
      }
    }

    [Token(Token = "0x17002117")]
    public int ResponseCode
    {
      [Token(Token = "0x600AB23"), Address(RVA = "0x1A41E24", Offset = "0x1A41E24", VA = "0x1A41E24")] get
      {
        return new int();
      }
      [Token(Token = "0x600AB24"), Address(RVA = "0x1A41E2C", Offset = "0x1A41E2C", VA = "0x1A41E2C")] private set
      {
      }
    }

    [Token(Token = "0x17002118")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AB25"), Address(RVA = "0x1A41E34", Offset = "0x1A41E34", VA = "0x1A41E34")] set
      {
      }
      [Token(Token = "0x600AB26"), Address(RVA = "0x1A41E50", Offset = "0x1A41E50", VA = "0x1A41E50")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AB27")]
    [Address(RVA = "0x1A41E6C", Offset = "0x1A41E6C", VA = "0x1A41E6C")]
    public APIGuildRaidBattleEnd(string apiPath = "api/v1/guild/raid/battle/end")
    {
    }

    [Token(Token = "0x600AB28")]
    [Address(RVA = "0x1A41F04", Offset = "0x1A41F04", VA = "0x1A41F04")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AB29")]
    [Address(RVA = "0x1A41F94", Offset = "0x1A41F94", VA = "0x1A41F94")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AB2A")]
    [Address(RVA = "0x1A41FA0", Offset = "0x1A41FA0", VA = "0x1A41FA0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AB2B")]
    [Address(RVA = "0x1A42074", Offset = "0x1A42074", VA = "0x1A42074")]
    private void OnSuccess(string json)
    {
    }
  }
}
