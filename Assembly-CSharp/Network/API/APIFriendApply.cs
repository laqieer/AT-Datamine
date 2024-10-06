// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendApply
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C55")]
  public class APIFriendApply
  {
    [Token(Token = "0x400795D")]
    public const string DefaultAPIPath = "api/v1/friend/apply";
    [Token(Token = "0x4007961")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007962")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFriendApplyResponse> onSuccess;
    [Token(Token = "0x4007963")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F9B")]
    public APIFriendApplyRequest Request
    {
      [Token(Token = "0x600A6D5"), Address(RVA = "0x190C1A8", Offset = "0x190C1A8", VA = "0x190C1A8")] private get
      {
        return (APIFriendApplyRequest) null;
      }
      [Token(Token = "0x600A6D6"), Address(RVA = "0x190C1B0", Offset = "0x190C1B0", VA = "0x190C1B0")] set
      {
      }
    }

    [Token(Token = "0x17001F9C")]
    public APIFriendApplyResponse Response
    {
      [Token(Token = "0x600A6D7"), Address(RVA = "0x190C1B8", Offset = "0x190C1B8", VA = "0x190C1B8")] get
      {
        return (APIFriendApplyResponse) null;
      }
      [Token(Token = "0x600A6D8"), Address(RVA = "0x190C1C0", Offset = "0x190C1C0", VA = "0x190C1C0")] private set
      {
      }
    }

    [Token(Token = "0x17001F9D")]
    public int ResponseCode
    {
      [Token(Token = "0x600A6D9"), Address(RVA = "0x190C1C8", Offset = "0x190C1C8", VA = "0x190C1C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A6DA"), Address(RVA = "0x190C1D0", Offset = "0x190C1D0", VA = "0x190C1D0")] private set
      {
      }
    }

    [Token(Token = "0x17001F9E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A6DB"), Address(RVA = "0x190C1D8", Offset = "0x190C1D8", VA = "0x190C1D8")] set
      {
      }
      [Token(Token = "0x600A6DC"), Address(RVA = "0x190C1F4", Offset = "0x190C1F4", VA = "0x190C1F4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A6DD")]
    [Address(RVA = "0x190C210", Offset = "0x190C210", VA = "0x190C210")]
    public APIFriendApply(string apiPath = "api/v1/friend/apply")
    {
    }

    [Token(Token = "0x600A6DE")]
    [Address(RVA = "0x190C2A8", Offset = "0x190C2A8", VA = "0x190C2A8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A6DF")]
    [Address(RVA = "0x190C338", Offset = "0x190C338", VA = "0x190C338")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A6E0")]
    [Address(RVA = "0x190C344", Offset = "0x190C344", VA = "0x190C344")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A6E1")]
    [Address(RVA = "0x190C418", Offset = "0x190C418", VA = "0x190C418")]
    private void OnSuccess(string json)
    {
    }
  }
}
