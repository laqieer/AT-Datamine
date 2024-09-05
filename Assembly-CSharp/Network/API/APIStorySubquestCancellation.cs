// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestCancellation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E7D")]
  public class APIStorySubquestCancellation
  {
    [Token(Token = "0x4008307")]
    public const string DefaultAPIPath = "api/v1/story/subquest/cancellation";
    [Token(Token = "0x400830B")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400830C")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStorySubquestCancellationResponse> onSuccess;
    [Token(Token = "0x400830D")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002514")]
    public APIStorySubquestCancellationRequest Request
    {
      [Token(Token = "0x600B4EE"), Address(RVA = "0x22E773C", Offset = "0x22E773C", VA = "0x22E773C")] private get
      {
        return (APIStorySubquestCancellationRequest) null;
      }
      [Token(Token = "0x600B4EF"), Address(RVA = "0x22E7744", Offset = "0x22E7744", VA = "0x22E7744")] set
      {
      }
    }

    [Token(Token = "0x17002515")]
    public APIStorySubquestCancellationResponse Response
    {
      [Token(Token = "0x600B4F0"), Address(RVA = "0x22E774C", Offset = "0x22E774C", VA = "0x22E774C")] get
      {
        return (APIStorySubquestCancellationResponse) null;
      }
      [Token(Token = "0x600B4F1"), Address(RVA = "0x22E7754", Offset = "0x22E7754", VA = "0x22E7754")] private set
      {
      }
    }

    [Token(Token = "0x17002516")]
    public int ResponseCode
    {
      [Token(Token = "0x600B4F2"), Address(RVA = "0x22E775C", Offset = "0x22E775C", VA = "0x22E775C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B4F3"), Address(RVA = "0x22E7764", Offset = "0x22E7764", VA = "0x22E7764")] private set
      {
      }
    }

    [Token(Token = "0x17002517")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B4F4"), Address(RVA = "0x22E776C", Offset = "0x22E776C", VA = "0x22E776C")] set
      {
      }
      [Token(Token = "0x600B4F5"), Address(RVA = "0x22E7788", Offset = "0x22E7788", VA = "0x22E7788")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B4F6")]
    [Address(RVA = "0x22E77A4", Offset = "0x22E77A4", VA = "0x22E77A4")]
    public APIStorySubquestCancellation(string apiPath = "api/v1/story/subquest/cancellation")
    {
    }

    [Token(Token = "0x600B4F7")]
    [Address(RVA = "0x22E783C", Offset = "0x22E783C", VA = "0x22E783C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B4F8")]
    [Address(RVA = "0x22E78CC", Offset = "0x22E78CC", VA = "0x22E78CC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B4F9")]
    [Address(RVA = "0x22E78D8", Offset = "0x22E78D8", VA = "0x22E78D8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B4FA")]
    [Address(RVA = "0x22E79AC", Offset = "0x22E79AC", VA = "0x22E79AC")]
    private void OnSuccess(string json)
    {
    }
  }
}
