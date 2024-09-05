// Decompiled with JetBrains decompiler
// Type: Network.API.APIFreeQuestBattleEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C49")]
  public class APIFreeQuestBattleEnd
  {
    [Token(Token = "0x400792A")]
    public const string DefaultAPIPath = "api/v1/battle/freequest/end";
    [Token(Token = "0x400792E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400792F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFreeQuestBattleEndResponse> onSuccess;
    [Token(Token = "0x4007930")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F80")]
    public APIFreeQuestBattleEndRequest Request
    {
      [Token(Token = "0x600A68A"), Address(RVA = "0x190B17C", Offset = "0x190B17C", VA = "0x190B17C")] private get
      {
        return (APIFreeQuestBattleEndRequest) null;
      }
      [Token(Token = "0x600A68B"), Address(RVA = "0x190B184", Offset = "0x190B184", VA = "0x190B184")] set
      {
      }
    }

    [Token(Token = "0x17001F81")]
    public APIFreeQuestBattleEndResponse Response
    {
      [Token(Token = "0x600A68C"), Address(RVA = "0x190B18C", Offset = "0x190B18C", VA = "0x190B18C")] get
      {
        return (APIFreeQuestBattleEndResponse) null;
      }
      [Token(Token = "0x600A68D"), Address(RVA = "0x190B194", Offset = "0x190B194", VA = "0x190B194")] private set
      {
      }
    }

    [Token(Token = "0x17001F82")]
    public int ResponseCode
    {
      [Token(Token = "0x600A68E"), Address(RVA = "0x190B19C", Offset = "0x190B19C", VA = "0x190B19C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A68F"), Address(RVA = "0x190B1A4", Offset = "0x190B1A4", VA = "0x190B1A4")] private set
      {
      }
    }

    [Token(Token = "0x17001F83")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A690"), Address(RVA = "0x190B1AC", Offset = "0x190B1AC", VA = "0x190B1AC")] set
      {
      }
      [Token(Token = "0x600A691"), Address(RVA = "0x190B1C8", Offset = "0x190B1C8", VA = "0x190B1C8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A692")]
    [Address(RVA = "0x190B1E4", Offset = "0x190B1E4", VA = "0x190B1E4")]
    public APIFreeQuestBattleEnd(string apiPath = "api/v1/battle/freequest/end")
    {
    }

    [Token(Token = "0x600A693")]
    [Address(RVA = "0x190B27C", Offset = "0x190B27C", VA = "0x190B27C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A694")]
    [Address(RVA = "0x190B30C", Offset = "0x190B30C", VA = "0x190B30C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A695")]
    [Address(RVA = "0x190B318", Offset = "0x190B318", VA = "0x190B318")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A696")]
    [Address(RVA = "0x190B3EC", Offset = "0x190B3EC", VA = "0x190B3EC")]
    private void OnSuccess(string json)
    {
    }
  }
}
