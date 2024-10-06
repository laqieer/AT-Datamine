// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryAreaEventQuestAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E29")]
  public class APIStoryAreaEventQuestAction
  {
    [Token(Token = "0x400812F")]
    public const string DefaultAPIPath = "api/v1/story/area_event/action";
    [Token(Token = "0x4008133")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008134")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryAreaEventQuestActionResponse> onSuccess;
    [Token(Token = "0x4008135")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002407")]
    public APIStoryAreaEventQuestActionRequest Request
    {
      [Token(Token = "0x600B291"), Address(RVA = "0x22E0388", Offset = "0x22E0388", VA = "0x22E0388")] private get
      {
        return (APIStoryAreaEventQuestActionRequest) null;
      }
      [Token(Token = "0x600B292"), Address(RVA = "0x22E0390", Offset = "0x22E0390", VA = "0x22E0390")] set
      {
      }
    }

    [Token(Token = "0x17002408")]
    public APIStoryAreaEventQuestActionResponse Response
    {
      [Token(Token = "0x600B293"), Address(RVA = "0x22E0398", Offset = "0x22E0398", VA = "0x22E0398")] get
      {
        return (APIStoryAreaEventQuestActionResponse) null;
      }
      [Token(Token = "0x600B294"), Address(RVA = "0x22E03A0", Offset = "0x22E03A0", VA = "0x22E03A0")] private set
      {
      }
    }

    [Token(Token = "0x17002409")]
    public int ResponseCode
    {
      [Token(Token = "0x600B295"), Address(RVA = "0x22E03A8", Offset = "0x22E03A8", VA = "0x22E03A8")] get
      {
        return new int();
      }
      [Token(Token = "0x600B296"), Address(RVA = "0x22E03B0", Offset = "0x22E03B0", VA = "0x22E03B0")] private set
      {
      }
    }

    [Token(Token = "0x1700240A")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B297"), Address(RVA = "0x22E03B8", Offset = "0x22E03B8", VA = "0x22E03B8")] set
      {
      }
      [Token(Token = "0x600B298"), Address(RVA = "0x22E03D4", Offset = "0x22E03D4", VA = "0x22E03D4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B299")]
    [Address(RVA = "0x22E03F0", Offset = "0x22E03F0", VA = "0x22E03F0")]
    public APIStoryAreaEventQuestAction(string apiPath = "api/v1/story/area_event/action")
    {
    }

    [Token(Token = "0x600B29A")]
    [Address(RVA = "0x22E0488", Offset = "0x22E0488", VA = "0x22E0488")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B29B")]
    [Address(RVA = "0x22E0518", Offset = "0x22E0518", VA = "0x22E0518")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B29C")]
    [Address(RVA = "0x22E0524", Offset = "0x22E0524", VA = "0x22E0524")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B29D")]
    [Address(RVA = "0x22E05F8", Offset = "0x22E05F8", VA = "0x22E05F8")]
    private void OnSuccess(string json)
    {
    }
  }
}
