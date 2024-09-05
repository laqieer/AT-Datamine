// Decompiled with JetBrains decompiler
// Type: Network.API.APIGachaPrevious_resultResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C98")]
  [Serializable]
  public class APIGachaPrevious_resultResponse
  {
    [Token(Token = "0x4007A46")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string gacha_title;
    [Token(Token = "0x4007A47")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string executed_at;
    [Token(Token = "0x4007A48")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GachaResultHistoryEntityType> results;

    [Token(Token = "0x17002021")]
    public string GachaTitle
    {
      [Token(Token = "0x600A86A"), Address(RVA = "0x1911CAC", Offset = "0x1911CAC", VA = "0x1911CAC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002022")]
    public string ExecutedAt
    {
      [Token(Token = "0x600A86B"), Address(RVA = "0x1911CB4", Offset = "0x1911CB4", VA = "0x1911CB4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002023")]
    public List<GachaResultHistoryEntityType> Results
    {
      [Token(Token = "0x600A86C"), Address(RVA = "0x1911CBC", Offset = "0x1911CBC", VA = "0x1911CBC")] get
      {
        return (List<GachaResultHistoryEntityType>) null;
      }
    }

    [Token(Token = "0x600A86D")]
    [Address(RVA = "0x1911CC4", Offset = "0x1911CC4", VA = "0x1911CC4")]
    public APIGachaPrevious_resultResponse()
    {
    }
  }
}
