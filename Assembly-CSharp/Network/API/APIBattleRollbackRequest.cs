// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleRollbackRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BAF")]
  [Serializable]
  public class APIBattleRollbackRequest
  {
    [Token(Token = "0x40076B5")]
    [FieldOffset(Offset = "0x10")]
    public int rollback_index;

    [Token(Token = "0x600A2B8")]
    [Address(RVA = "0x46CC370", Offset = "0x46CC370", VA = "0x46CC370")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A2B9")]
    [Address(RVA = "0x46CC3B8", Offset = "0x46CC3B8", VA = "0x46CC3B8")]
    public APIBattleRollbackRequest()
    {
    }
  }
}
