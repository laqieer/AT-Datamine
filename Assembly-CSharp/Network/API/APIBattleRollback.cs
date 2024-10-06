// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleRollback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BB1")]
  public class APIBattleRollback
  {
    [Token(Token = "0x40076B7")]
    public const string DefaultAPIPath = "api/v1/battle/rollback";
    [Token(Token = "0x40076BB")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40076BC")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIBattleRollbackResponse> onSuccess;
    [Token(Token = "0x40076BD")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E12")]
    public APIBattleRollbackRequest Request
    {
      [Token(Token = "0x600A2BC"), Address(RVA = "0x46CC3D0", Offset = "0x46CC3D0", VA = "0x46CC3D0")] private get
      {
        return (APIBattleRollbackRequest) null;
      }
      [Token(Token = "0x600A2BD"), Address(RVA = "0x46CC3D8", Offset = "0x46CC3D8", VA = "0x46CC3D8")] set
      {
      }
    }

    [Token(Token = "0x17001E13")]
    public APIBattleRollbackResponse Response
    {
      [Token(Token = "0x600A2BE"), Address(RVA = "0x46CC3E0", Offset = "0x46CC3E0", VA = "0x46CC3E0")] get
      {
        return (APIBattleRollbackResponse) null;
      }
      [Token(Token = "0x600A2BF"), Address(RVA = "0x46CC3E8", Offset = "0x46CC3E8", VA = "0x46CC3E8")] private set
      {
      }
    }

    [Token(Token = "0x17001E14")]
    public int ResponseCode
    {
      [Token(Token = "0x600A2C0"), Address(RVA = "0x46CC3F0", Offset = "0x46CC3F0", VA = "0x46CC3F0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A2C1"), Address(RVA = "0x46CC3F8", Offset = "0x46CC3F8", VA = "0x46CC3F8")] private set
      {
      }
    }

    [Token(Token = "0x17001E15")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A2C2"), Address(RVA = "0x46CC400", Offset = "0x46CC400", VA = "0x46CC400")] set
      {
      }
      [Token(Token = "0x600A2C3"), Address(RVA = "0x46CC41C", Offset = "0x46CC41C", VA = "0x46CC41C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A2C4")]
    [Address(RVA = "0x46CC438", Offset = "0x46CC438", VA = "0x46CC438")]
    public APIBattleRollback(string apiPath = "api/v1/battle/rollback")
    {
    }

    [Token(Token = "0x600A2C5")]
    [Address(RVA = "0x46CC4D0", Offset = "0x46CC4D0", VA = "0x46CC4D0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A2C6")]
    [Address(RVA = "0x46CC560", Offset = "0x46CC560", VA = "0x46CC560")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A2C7")]
    [Address(RVA = "0x46CC56C", Offset = "0x46CC56C", VA = "0x46CC56C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A2C8")]
    [Address(RVA = "0x46CC640", Offset = "0x46CC640", VA = "0x46CC640")]
    private void OnSuccess(string json)
    {
    }
  }
}
