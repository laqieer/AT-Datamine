// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E75")]
  public class APIStorySubquestBattleEnd
  {
    [Token(Token = "0x40082DD")]
    public const string DefaultAPIPath = "api/v1/story/subquest/battle/end";
    [Token(Token = "0x40082E1")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40082E2")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStorySubquestBattleEndResponse> onSuccess;
    [Token(Token = "0x40082E3")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170024FD")]
    public APIStorySubquestBattleEndRequest Request
    {
      [Token(Token = "0x600B4B7"), Address(RVA = "0x22E6C4C", Offset = "0x22E6C4C", VA = "0x22E6C4C")] private get
      {
        return (APIStorySubquestBattleEndRequest) null;
      }
      [Token(Token = "0x600B4B8"), Address(RVA = "0x22E6C54", Offset = "0x22E6C54", VA = "0x22E6C54")] set
      {
      }
    }

    [Token(Token = "0x170024FE")]
    public APIStorySubquestBattleEndResponse Response
    {
      [Token(Token = "0x600B4B9"), Address(RVA = "0x22E6C5C", Offset = "0x22E6C5C", VA = "0x22E6C5C")] get
      {
        return (APIStorySubquestBattleEndResponse) null;
      }
      [Token(Token = "0x600B4BA"), Address(RVA = "0x22E6C64", Offset = "0x22E6C64", VA = "0x22E6C64")] private set
      {
      }
    }

    [Token(Token = "0x170024FF")]
    public int ResponseCode
    {
      [Token(Token = "0x600B4BB"), Address(RVA = "0x22E6C6C", Offset = "0x22E6C6C", VA = "0x22E6C6C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B4BC"), Address(RVA = "0x22E6C74", Offset = "0x22E6C74", VA = "0x22E6C74")] private set
      {
      }
    }

    [Token(Token = "0x17002500")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B4BD"), Address(RVA = "0x22E6C7C", Offset = "0x22E6C7C", VA = "0x22E6C7C")] set
      {
      }
      [Token(Token = "0x600B4BE"), Address(RVA = "0x22E6C98", Offset = "0x22E6C98", VA = "0x22E6C98")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B4BF")]
    [Address(RVA = "0x22E6CB4", Offset = "0x22E6CB4", VA = "0x22E6CB4")]
    public APIStorySubquestBattleEnd(string apiPath = "api/v1/story/subquest/battle/end")
    {
    }

    [Token(Token = "0x600B4C0")]
    [Address(RVA = "0x22E6D4C", Offset = "0x22E6D4C", VA = "0x22E6D4C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B4C1")]
    [Address(RVA = "0x22E6DDC", Offset = "0x22E6DDC", VA = "0x22E6DDC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B4C2")]
    [Address(RVA = "0x22E6DE8", Offset = "0x22E6DE8", VA = "0x22E6DE8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B4C3")]
    [Address(RVA = "0x22E6EBC", Offset = "0x22E6EBC", VA = "0x22E6EBC")]
    private void OnSuccess(string json)
    {
    }
  }
}
