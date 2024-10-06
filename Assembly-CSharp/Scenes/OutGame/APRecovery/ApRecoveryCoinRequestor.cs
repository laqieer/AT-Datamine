// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.APRecovery.ApRecoveryCoinRequestor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.API;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.APRecovery
{
  [Token(Token = "0x200394D")]
  public class ApRecoveryCoinRequestor
  {
    [Token(Token = "0x400FA6C")]
    public const int AppErrorCode = 499;
    [Token(Token = "0x400FA6F")]
    [FieldOffset(Offset = "0x20")]
    private int _nowAp;
    [Token(Token = "0x400FA70")]
    [FieldOffset(Offset = "0x24")]
    private int _recoveryAp;

    [Token(Token = "0x6016854")]
    [Address(RVA = "0x42EBFF8", Offset = "0x42EBFF8", VA = "0x42EBFF8")]
    public ApRecoveryCoinRequestor(int nowAp, int recoveryAp)
    {
    }

    [Token(Token = "0x17004A0E")]
    public Action<APIPlayerApRecoveryCoinResponse> OnSuccess
    {
      [Token(Token = "0x6016855"), Address(RVA = "0x42EC024", Offset = "0x42EC024", VA = "0x42EC024")] get
      {
        return (Action<APIPlayerApRecoveryCoinResponse>) null;
      }
      [Token(Token = "0x6016856"), Address(RVA = "0x42EC02C", Offset = "0x42EC02C", VA = "0x42EC02C")] set
      {
      }
    }

    [Token(Token = "0x17004A0F")]
    public Action OnError
    {
      [Token(Token = "0x6016857"), Address(RVA = "0x42EC034", Offset = "0x42EC034", VA = "0x42EC034")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6016858"), Address(RVA = "0x42EC03C", Offset = "0x42EC03C", VA = "0x42EC03C")] set
      {
      }
    }

    [Token(Token = "0x6016859")]
    [Address(RVA = "0x42EC044", Offset = "0x42EC044", VA = "0x42EC044")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x601685A")]
    [Address(RVA = "0x42EC0D4", Offset = "0x42EC0D4", VA = "0x42EC0D4")]
    private IEnumerator ApiError(NetworkErrorResult networkErrorResult) => (IEnumerator) null;
  }
}
