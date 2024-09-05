// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E49")]
  public class APIStoryMainquestBattleEnd
  {
    [Token(Token = "0x40081DA")]
    public const string DefaultAPIPath = "api/v1/story/mainquest/battle/end";
    [Token(Token = "0x40081DE")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40081DF")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryMainquestBattleEndResponse> onSuccess;
    [Token(Token = "0x40081E0")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002469")]
    public APIStoryMainquestBattleEndRequest Request
    {
      [Token(Token = "0x600B373"), Address(RVA = "0x22E2F78", Offset = "0x22E2F78", VA = "0x22E2F78")] private get
      {
        return (APIStoryMainquestBattleEndRequest) null;
      }
      [Token(Token = "0x600B374"), Address(RVA = "0x22E2F80", Offset = "0x22E2F80", VA = "0x22E2F80")] set
      {
      }
    }

    [Token(Token = "0x1700246A")]
    public APIStoryMainquestBattleEndResponse Response
    {
      [Token(Token = "0x600B375"), Address(RVA = "0x22E2F88", Offset = "0x22E2F88", VA = "0x22E2F88")] get
      {
        return (APIStoryMainquestBattleEndResponse) null;
      }
      [Token(Token = "0x600B376"), Address(RVA = "0x22E2F90", Offset = "0x22E2F90", VA = "0x22E2F90")] private set
      {
      }
    }

    [Token(Token = "0x1700246B")]
    public int ResponseCode
    {
      [Token(Token = "0x600B377"), Address(RVA = "0x22E2F98", Offset = "0x22E2F98", VA = "0x22E2F98")] get
      {
        return new int();
      }
      [Token(Token = "0x600B378"), Address(RVA = "0x22E2FA0", Offset = "0x22E2FA0", VA = "0x22E2FA0")] private set
      {
      }
    }

    [Token(Token = "0x1700246C")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B379"), Address(RVA = "0x22E2FA8", Offset = "0x22E2FA8", VA = "0x22E2FA8")] set
      {
      }
      [Token(Token = "0x600B37A"), Address(RVA = "0x22E2FC4", Offset = "0x22E2FC4", VA = "0x22E2FC4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B37B")]
    [Address(RVA = "0x22E2FE0", Offset = "0x22E2FE0", VA = "0x22E2FE0")]
    public APIStoryMainquestBattleEnd(string apiPath = "api/v1/story/mainquest/battle/end")
    {
    }

    [Token(Token = "0x600B37C")]
    [Address(RVA = "0x22E3078", Offset = "0x22E3078", VA = "0x22E3078")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B37D")]
    [Address(RVA = "0x22E3108", Offset = "0x22E3108", VA = "0x22E3108")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B37E")]
    [Address(RVA = "0x22E3114", Offset = "0x22E3114", VA = "0x22E3114")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B37F")]
    [Address(RVA = "0x22E31E8", Offset = "0x22E31E8", VA = "0x22E31E8")]
    private void OnSuccess(string json)
    {
    }
  }
}
