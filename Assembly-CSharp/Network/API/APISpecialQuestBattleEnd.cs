// Decompiled with JetBrains decompiler
// Type: Network.API.APISpecialQuestBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E1D")]
  public class APISpecialQuestBattleEnd
  {
    [Token(Token = "0x40080EB")]
    public const string DefaultAPIPath = "api/v1/battle/specialquest/end";
    [Token(Token = "0x40080EF")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40080F0")]
    [FieldOffset(Offset = "0x30")]
    public Action<APISpecialQuestBattleEndResponse> onSuccess;
    [Token(Token = "0x40080F1")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170023DC")]
    public APISpecialQuestBattleEndRequest Request
    {
      [Token(Token = "0x600B236"), Address(RVA = "0x22DF2DC", Offset = "0x22DF2DC", VA = "0x22DF2DC")] private get
      {
        return (APISpecialQuestBattleEndRequest) null;
      }
      [Token(Token = "0x600B237"), Address(RVA = "0x22DF2E4", Offset = "0x22DF2E4", VA = "0x22DF2E4")] set
      {
      }
    }

    [Token(Token = "0x170023DD")]
    public APISpecialQuestBattleEndResponse Response
    {
      [Token(Token = "0x600B238"), Address(RVA = "0x22DF2EC", Offset = "0x22DF2EC", VA = "0x22DF2EC")] get
      {
        return (APISpecialQuestBattleEndResponse) null;
      }
      [Token(Token = "0x600B239"), Address(RVA = "0x22DF2F4", Offset = "0x22DF2F4", VA = "0x22DF2F4")] private set
      {
      }
    }

    [Token(Token = "0x170023DE")]
    public int ResponseCode
    {
      [Token(Token = "0x600B23A"), Address(RVA = "0x22DF2FC", Offset = "0x22DF2FC", VA = "0x22DF2FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600B23B"), Address(RVA = "0x22DF304", Offset = "0x22DF304", VA = "0x22DF304")] private set
      {
      }
    }

    [Token(Token = "0x170023DF")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B23C"), Address(RVA = "0x22DF30C", Offset = "0x22DF30C", VA = "0x22DF30C")] set
      {
      }
      [Token(Token = "0x600B23D"), Address(RVA = "0x22DF328", Offset = "0x22DF328", VA = "0x22DF328")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B23E")]
    [Address(RVA = "0x22DF344", Offset = "0x22DF344", VA = "0x22DF344")]
    public APISpecialQuestBattleEnd(string apiPath = "api/v1/battle/specialquest/end")
    {
    }

    [Token(Token = "0x600B23F")]
    [Address(RVA = "0x22DF3DC", Offset = "0x22DF3DC", VA = "0x22DF3DC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B240")]
    [Address(RVA = "0x22DF46C", Offset = "0x22DF46C", VA = "0x22DF46C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B241")]
    [Address(RVA = "0x22DF478", Offset = "0x22DF478", VA = "0x22DF478")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B242")]
    [Address(RVA = "0x22DF54C", Offset = "0x22DF54C", VA = "0x22DF54C")]
    private void OnSuccess(string json)
    {
    }
  }
}
