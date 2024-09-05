// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestBattleStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E79")]
  public class APIStorySubquestBattleStart
  {
    [Token(Token = "0x40082F7")]
    public const string DefaultAPIPath = "api/v1/story/subquest/battle/start";
    [Token(Token = "0x40082FB")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40082FC")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStorySubquestBattleStartResponse> onSuccess;
    [Token(Token = "0x40082FD")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700250A")]
    public APIStorySubquestBattleStartRequest Request
    {
      [Token(Token = "0x600B4D4"), Address(RVA = "0x22E71D0", Offset = "0x22E71D0", VA = "0x22E71D0")] private get
      {
        return (APIStorySubquestBattleStartRequest) null;
      }
      [Token(Token = "0x600B4D5"), Address(RVA = "0x22E71D8", Offset = "0x22E71D8", VA = "0x22E71D8")] set
      {
      }
    }

    [Token(Token = "0x1700250B")]
    public APIStorySubquestBattleStartResponse Response
    {
      [Token(Token = "0x600B4D6"), Address(RVA = "0x22E71E0", Offset = "0x22E71E0", VA = "0x22E71E0")] get
      {
        return (APIStorySubquestBattleStartResponse) null;
      }
      [Token(Token = "0x600B4D7"), Address(RVA = "0x22E71E8", Offset = "0x22E71E8", VA = "0x22E71E8")] private set
      {
      }
    }

    [Token(Token = "0x1700250C")]
    public int ResponseCode
    {
      [Token(Token = "0x600B4D8"), Address(RVA = "0x22E71F0", Offset = "0x22E71F0", VA = "0x22E71F0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B4D9"), Address(RVA = "0x22E71F8", Offset = "0x22E71F8", VA = "0x22E71F8")] private set
      {
      }
    }

    [Token(Token = "0x1700250D")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B4DA"), Address(RVA = "0x22E7200", Offset = "0x22E7200", VA = "0x22E7200")] set
      {
      }
      [Token(Token = "0x600B4DB"), Address(RVA = "0x22E721C", Offset = "0x22E721C", VA = "0x22E721C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B4DC")]
    [Address(RVA = "0x22E7238", Offset = "0x22E7238", VA = "0x22E7238")]
    public APIStorySubquestBattleStart(string apiPath = "api/v1/story/subquest/battle/start")
    {
    }

    [Token(Token = "0x600B4DD")]
    [Address(RVA = "0x22E72D0", Offset = "0x22E72D0", VA = "0x22E72D0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B4DE")]
    [Address(RVA = "0x22E7360", Offset = "0x22E7360", VA = "0x22E7360")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B4DF")]
    [Address(RVA = "0x22E736C", Offset = "0x22E736C", VA = "0x22E736C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B4E0")]
    [Address(RVA = "0x22E7440", Offset = "0x22E7440", VA = "0x22E7440")]
    private void OnSuccess(string json)
    {
    }
  }
}
