// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApRecoveryItemRequestor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.API;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x2003953")]
  public class ApRecoveryItemRequestor
  {
    [Token(Token = "0x400FA87")]
    [FieldOffset(Offset = "0x20")]
    private int _nowAp;
    [Token(Token = "0x400FA88")]
    [FieldOffset(Offset = "0x24")]
    private int _recoveryAp;
    [Token(Token = "0x400FA89")]
    [FieldOffset(Offset = "0x28")]
    private RecoveryItemList _recoveryItemList;

    [Token(Token = "0x6016879")]
    [Address(RVA = "0x42ECB74", Offset = "0x42ECB74", VA = "0x42ECB74")]
    public ApRecoveryItemRequestor(int nowAp, int recoveryAp, RecoveryItemList recoveryItemList)
    {
    }

    [Token(Token = "0x17004A17")]
    public Action<APIPlayerApRecoveryItemResponse> OnSuccess
    {
      [Token(Token = "0x601687A"), Address(RVA = "0x42ECBB0", Offset = "0x42ECBB0", VA = "0x42ECBB0")] get
      {
        return (Action<APIPlayerApRecoveryItemResponse>) null;
      }
      [Token(Token = "0x601687B"), Address(RVA = "0x42ECBB8", Offset = "0x42ECBB8", VA = "0x42ECBB8")] set
      {
      }
    }

    [Token(Token = "0x17004A18")]
    public Action OnError
    {
      [Token(Token = "0x601687C"), Address(RVA = "0x42ECBC0", Offset = "0x42ECBC0", VA = "0x42ECBC0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601687D"), Address(RVA = "0x42ECBC8", Offset = "0x42ECBC8", VA = "0x42ECBC8")] set
      {
      }
    }

    [Token(Token = "0x601687E")]
    [Address(RVA = "0x42ECBD0", Offset = "0x42ECBD0", VA = "0x42ECBD0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x601687F")]
    [Address(RVA = "0x42ECC60", Offset = "0x42ECC60", VA = "0x42ECC60")]
    private List<RequestPaymentType> CreateRequestPayments() => (List<RequestPaymentType>) null;

    [Token(Token = "0x6016880")]
    [Address(RVA = "0x42ECFA4", Offset = "0x42ECFA4", VA = "0x42ECFA4")]
    private IEnumerator ApiError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;
  }
}
