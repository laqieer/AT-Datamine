// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackHowToPlayResponse
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
  [Token(Token = "0x2001DFC")]
  [Serializable]
  public class APIScoreAttackHowToPlayResponse
  {
    [Token(Token = "0x4008068")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private OfficialInformationArticleType article;

    [Token(Token = "0x17002394")]
    public OfficialInformationArticleType Article
    {
      [Token(Token = "0x600B16D"), Address(RVA = "0x22DC7B4", Offset = "0x22DC7B4", VA = "0x22DC7B4")] get
      {
        return (OfficialInformationArticleType) null;
      }
    }

    [Token(Token = "0x600B16E")]
    [Address(RVA = "0x22DC7BC", Offset = "0x22DC7BC", VA = "0x22DC7BC")]
    public APIScoreAttackHowToPlayResponse()
    {
    }
  }
}
