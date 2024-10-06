// Decompiled with JetBrains decompiler
// Type: Network.Param.RequestPlayerExpeditionStageBossPartyUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B0B")]
  [Serializable]
  public class RequestPlayerExpeditionStageBossPartyUnit
  {
    [Token(Token = "0x400742F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007430")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string player_unit_id;

    [Token(Token = "0x17001C91")]
    public string Id
    {
      [Token(Token = "0x6009E98"), Address(RVA = "0x48F359C", Offset = "0x48F359C", VA = "0x48F359C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009E99"), Address(RVA = "0x48F35A4", Offset = "0x48F35A4", VA = "0x48F35A4")] set
      {
      }
    }

    [Token(Token = "0x17001C92")]
    public string PlayerUnitId
    {
      [Token(Token = "0x6009E9A"), Address(RVA = "0x48F35AC", Offset = "0x48F35AC", VA = "0x48F35AC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009E9B"), Address(RVA = "0x48F35B4", Offset = "0x48F35B4", VA = "0x48F35B4")] set
      {
      }
    }

    [Token(Token = "0x6009E9C")]
    [Address(RVA = "0x48F35BC", Offset = "0x48F35BC", VA = "0x48F35BC")]
    public RequestPlayerExpeditionStageBossPartyUnit()
    {
    }
  }
}
