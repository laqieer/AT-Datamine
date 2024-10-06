// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D0D")]
  public class APIGuildRaidBattleStart
  {
    [Token(Token = "0x4007C1F")]
    public const string DefaultAPIPath = "api/v1/guild/raid/battle/start";
    [Token(Token = "0x4007C23")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007C24")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildRaidBattleStartResponse> onSuccess;
    [Token(Token = "0x4007C25")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002120")]
    public APIGuildRaidBattleStartRequest Request
    {
      [Token(Token = "0x600AB3A"), Address(RVA = "0x1A42378", Offset = "0x1A42378", VA = "0x1A42378")] private get
      {
        return (APIGuildRaidBattleStartRequest) null;
      }
      [Token(Token = "0x600AB3B"), Address(RVA = "0x1A42380", Offset = "0x1A42380", VA = "0x1A42380")] set
      {
      }
    }

    [Token(Token = "0x17002121")]
    public APIGuildRaidBattleStartResponse Response
    {
      [Token(Token = "0x600AB3C"), Address(RVA = "0x1A42388", Offset = "0x1A42388", VA = "0x1A42388")] get
      {
        return (APIGuildRaidBattleStartResponse) null;
      }
      [Token(Token = "0x600AB3D"), Address(RVA = "0x1A42390", Offset = "0x1A42390", VA = "0x1A42390")] private set
      {
      }
    }

    [Token(Token = "0x17002122")]
    public int ResponseCode
    {
      [Token(Token = "0x600AB3E"), Address(RVA = "0x1A42398", Offset = "0x1A42398", VA = "0x1A42398")] get
      {
        return new int();
      }
      [Token(Token = "0x600AB3F"), Address(RVA = "0x1A423A0", Offset = "0x1A423A0", VA = "0x1A423A0")] private set
      {
      }
    }

    [Token(Token = "0x17002123")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AB40"), Address(RVA = "0x1A423A8", Offset = "0x1A423A8", VA = "0x1A423A8")] set
      {
      }
      [Token(Token = "0x600AB41"), Address(RVA = "0x1A423C4", Offset = "0x1A423C4", VA = "0x1A423C4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AB42")]
    [Address(RVA = "0x1A423E0", Offset = "0x1A423E0", VA = "0x1A423E0")]
    public APIGuildRaidBattleStart(string apiPath = "api/v1/guild/raid/battle/start")
    {
    }

    [Token(Token = "0x600AB43")]
    [Address(RVA = "0x1A42478", Offset = "0x1A42478", VA = "0x1A42478")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AB44")]
    [Address(RVA = "0x1A42508", Offset = "0x1A42508", VA = "0x1A42508")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AB45")]
    [Address(RVA = "0x1A42514", Offset = "0x1A42514", VA = "0x1A42514")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AB46")]
    [Address(RVA = "0x1A425E8", Offset = "0x1A425E8", VA = "0x1A425E8")]
    private void OnSuccess(string json)
    {
    }
  }
}
