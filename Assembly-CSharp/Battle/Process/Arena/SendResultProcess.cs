// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.SendResultProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using System.Collections;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026D4")]
  public abstract class SendResultProcess : BattleProcessBase
  {
    [Token(Token = "0x400A635")]
    [FieldOffset(Offset = "0x21")]
    protected bool webConnecting;

    [Token(Token = "0x600F045")]
    [Address(RVA = "0x40E40A8", Offset = "0x40E40A8", VA = "0x40E40A8")]
    protected IEnumerator CallArenaEndAPI() => (IEnumerator) null;

    [Token(Token = "0x600F046")]
    [Address(RVA = "0x40EACAC", Offset = "0x40EACAC", VA = "0x40EACAC")]
    private IEnumerator OnUpdateArenaRanking(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600F047")]
    [Address(RVA = "0x40E407C", Offset = "0x40E407C", VA = "0x40E407C")]
    protected void SendLog()
    {
    }

    [Token(Token = "0x600F048")]
    [Address(RVA = "0x40E4110", Offset = "0x40E4110", VA = "0x40E4110")]
    protected SendResultProcess()
    {
    }
  }
}
