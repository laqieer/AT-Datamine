// Decompiled with JetBrains decompiler
// Type: Network.API.APIFggfcMissionAccept
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C45")]
  public class APIFggfcMissionAccept
  {
    [Token(Token = "0x400790F")]
    public const string DefaultAPIPath = "api/v1/fggfc/accept";
    [Token(Token = "0x4007913")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007914")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFggfcMissionAcceptResponse> onSuccess;
    [Token(Token = "0x4007915")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F76")]
    public APIFggfcMissionAcceptRequest Request
    {
      [Token(Token = "0x600A670"), Address(RVA = "0x190AC10", Offset = "0x190AC10", VA = "0x190AC10")] private get
      {
        return (APIFggfcMissionAcceptRequest) null;
      }
      [Token(Token = "0x600A671"), Address(RVA = "0x190AC18", Offset = "0x190AC18", VA = "0x190AC18")] set
      {
      }
    }

    [Token(Token = "0x17001F77")]
    public APIFggfcMissionAcceptResponse Response
    {
      [Token(Token = "0x600A672"), Address(RVA = "0x190AC20", Offset = "0x190AC20", VA = "0x190AC20")] get
      {
        return (APIFggfcMissionAcceptResponse) null;
      }
      [Token(Token = "0x600A673"), Address(RVA = "0x190AC28", Offset = "0x190AC28", VA = "0x190AC28")] private set
      {
      }
    }

    [Token(Token = "0x17001F78")]
    public int ResponseCode
    {
      [Token(Token = "0x600A674"), Address(RVA = "0x190AC30", Offset = "0x190AC30", VA = "0x190AC30")] get
      {
        return new int();
      }
      [Token(Token = "0x600A675"), Address(RVA = "0x190AC38", Offset = "0x190AC38", VA = "0x190AC38")] private set
      {
      }
    }

    [Token(Token = "0x17001F79")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A676"), Address(RVA = "0x190AC40", Offset = "0x190AC40", VA = "0x190AC40")] set
      {
      }
      [Token(Token = "0x600A677"), Address(RVA = "0x190AC5C", Offset = "0x190AC5C", VA = "0x190AC5C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A678")]
    [Address(RVA = "0x190AC78", Offset = "0x190AC78", VA = "0x190AC78")]
    public APIFggfcMissionAccept(string apiPath = "api/v1/fggfc/accept")
    {
    }

    [Token(Token = "0x600A679")]
    [Address(RVA = "0x190AD10", Offset = "0x190AD10", VA = "0x190AD10")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A67A")]
    [Address(RVA = "0x190ADA0", Offset = "0x190ADA0", VA = "0x190ADA0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A67B")]
    [Address(RVA = "0x190ADAC", Offset = "0x190ADAC", VA = "0x190ADAC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A67C")]
    [Address(RVA = "0x190AE80", Offset = "0x190AE80", VA = "0x190AE80")]
    private void OnSuccess(string json)
    {
    }
  }
}
