// Decompiled with JetBrains decompiler
// Type: Network.API.APIFggfcMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C41")]
  public class APIFggfcMission
  {
    [Token(Token = "0x40078FE")]
    public const string DefaultAPIPath = "api/v1/fggfc";
    [Token(Token = "0x4007902")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007903")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFggfcMissionResponse> onSuccess;
    [Token(Token = "0x4007904")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F6C")]
    public APIFggfcMissionRequest Request
    {
      [Token(Token = "0x600A656"), Address(RVA = "0x190A6A4", Offset = "0x190A6A4", VA = "0x190A6A4")] private get
      {
        return (APIFggfcMissionRequest) null;
      }
      [Token(Token = "0x600A657"), Address(RVA = "0x190A6AC", Offset = "0x190A6AC", VA = "0x190A6AC")] set
      {
      }
    }

    [Token(Token = "0x17001F6D")]
    public APIFggfcMissionResponse Response
    {
      [Token(Token = "0x600A658"), Address(RVA = "0x190A6B4", Offset = "0x190A6B4", VA = "0x190A6B4")] get
      {
        return (APIFggfcMissionResponse) null;
      }
      [Token(Token = "0x600A659"), Address(RVA = "0x190A6BC", Offset = "0x190A6BC", VA = "0x190A6BC")] private set
      {
      }
    }

    [Token(Token = "0x17001F6E")]
    public int ResponseCode
    {
      [Token(Token = "0x600A65A"), Address(RVA = "0x190A6C4", Offset = "0x190A6C4", VA = "0x190A6C4")] get
      {
        return new int();
      }
      [Token(Token = "0x600A65B"), Address(RVA = "0x190A6CC", Offset = "0x190A6CC", VA = "0x190A6CC")] private set
      {
      }
    }

    [Token(Token = "0x17001F6F")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A65C"), Address(RVA = "0x190A6D4", Offset = "0x190A6D4", VA = "0x190A6D4")] set
      {
      }
      [Token(Token = "0x600A65D"), Address(RVA = "0x190A6F0", Offset = "0x190A6F0", VA = "0x190A6F0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A65E")]
    [Address(RVA = "0x190A70C", Offset = "0x190A70C", VA = "0x190A70C")]
    public APIFggfcMission(string apiPath = "api/v1/fggfc")
    {
    }

    [Token(Token = "0x600A65F")]
    [Address(RVA = "0x190A7A4", Offset = "0x190A7A4", VA = "0x190A7A4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A660")]
    [Address(RVA = "0x190A834", Offset = "0x190A834", VA = "0x190A834")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A661")]
    [Address(RVA = "0x190A840", Offset = "0x190A840", VA = "0x190A840")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A662")]
    [Address(RVA = "0x190A914", Offset = "0x190A914", VA = "0x190A914")]
    private void OnSuccess(string json)
    {
    }
  }
}
