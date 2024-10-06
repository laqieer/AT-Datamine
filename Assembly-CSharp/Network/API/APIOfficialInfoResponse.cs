// Decompiled with JetBrains decompiler
// Type: Network.API.APIOfficialInfoResponse
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
  [Token(Token = "0x2001D78")]
  [Serializable]
  public class APIOfficialInfoResponse
  {
    [Token(Token = "0x4007DE1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<OfficialInformationArticleType> articles;

    [Token(Token = "0x17002225")]
    public List<OfficialInformationArticleType> Articles
    {
      [Token(Token = "0x600ADEE"), Address(RVA = "0x1A4B564", Offset = "0x1A4B564", VA = "0x1A4B564")] get
      {
        return (List<OfficialInformationArticleType>) null;
      }
    }

    [Token(Token = "0x600ADEF")]
    [Address(RVA = "0x1A4B56C", Offset = "0x1A4B56C", VA = "0x1A4B56C")]
    public APIOfficialInfoResponse()
    {
    }
  }
}
