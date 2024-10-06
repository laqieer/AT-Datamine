// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackRuleResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E04")]
  [Serializable]
  public class APIScoreAttackRuleResponse
  {
    [Token(Token = "0x4008082")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private OfficialInformationArticleType article;

    [Token(Token = "0x170023A2")]
    public OfficialInformationArticleType Article
    {
      [Token(Token = "0x600B19B"), Address(RVA = "0x22DD25C", Offset = "0x22DD25C", VA = "0x22DD25C")] get
      {
        return (OfficialInformationArticleType) null;
      }
    }

    [Token(Token = "0x600B19C")]
    [Address(RVA = "0x22DD264", Offset = "0x22DD264", VA = "0x22DD264")]
    public APIScoreAttackRuleResponse()
    {
    }
  }
}
