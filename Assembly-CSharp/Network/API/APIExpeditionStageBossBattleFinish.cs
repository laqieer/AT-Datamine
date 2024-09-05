// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionStageBossBattleFinish
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C39")]
  public class APIExpeditionStageBossBattleFinish
  {
    [Token(Token = "0x40078E1")]
    public const string DefaultAPIPath = "api/v1/expedition/stage/boss/battle/finish";
    [Token(Token = "0x40078E5")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40078E6")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionStageBossBattleFinishResponse> onSuccess;
    [Token(Token = "0x40078E7")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F5A")]
    public APIExpeditionStageBossBattleFinishRequest Request
    {
      [Token(Token = "0x600A624"), Address(RVA = "0x1909BDC", Offset = "0x1909BDC", VA = "0x1909BDC")] private get
      {
        return (APIExpeditionStageBossBattleFinishRequest) null;
      }
      [Token(Token = "0x600A625"), Address(RVA = "0x1909BE4", Offset = "0x1909BE4", VA = "0x1909BE4")] set
      {
      }
    }

    [Token(Token = "0x17001F5B")]
    public APIExpeditionStageBossBattleFinishResponse Response
    {
      [Token(Token = "0x600A626"), Address(RVA = "0x1909BEC", Offset = "0x1909BEC", VA = "0x1909BEC")] get
      {
        return (APIExpeditionStageBossBattleFinishResponse) null;
      }
      [Token(Token = "0x600A627"), Address(RVA = "0x1909BF4", Offset = "0x1909BF4", VA = "0x1909BF4")] private set
      {
      }
    }

    [Token(Token = "0x17001F5C")]
    public int ResponseCode
    {
      [Token(Token = "0x600A628"), Address(RVA = "0x1909BFC", Offset = "0x1909BFC", VA = "0x1909BFC")] get
      {
        return new int();
      }
      [Token(Token = "0x600A629"), Address(RVA = "0x1909C04", Offset = "0x1909C04", VA = "0x1909C04")] private set
      {
      }
    }

    [Token(Token = "0x17001F5D")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A62A"), Address(RVA = "0x1909C0C", Offset = "0x1909C0C", VA = "0x1909C0C")] set
      {
      }
      [Token(Token = "0x600A62B"), Address(RVA = "0x1909C28", Offset = "0x1909C28", VA = "0x1909C28")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A62C")]
    [Address(RVA = "0x1909C44", Offset = "0x1909C44", VA = "0x1909C44")]
    public APIExpeditionStageBossBattleFinish(string apiPath = "api/v1/expedition/stage/boss/battle/finish")
    {
    }

    [Token(Token = "0x600A62D")]
    [Address(RVA = "0x1909CDC", Offset = "0x1909CDC", VA = "0x1909CDC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A62E")]
    [Address(RVA = "0x1909D6C", Offset = "0x1909D6C", VA = "0x1909D6C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A62F")]
    [Address(RVA = "0x1909D78", Offset = "0x1909D78", VA = "0x1909D78")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A630")]
    [Address(RVA = "0x1909E4C", Offset = "0x1909E4C", VA = "0x1909E4C")]
    private void OnSuccess(string json)
    {
    }
  }
}
