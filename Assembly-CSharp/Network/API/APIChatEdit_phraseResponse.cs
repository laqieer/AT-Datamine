// Decompiled with JetBrains decompiler
// Type: Network.API.APIChatEdit_phraseResponse
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
  [Token(Token = "0x2001BC8")]
  [Serializable]
  public class APIChatEdit_phraseResponse
  {
    [Token(Token = "0x400770B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerChatPhraseType> phrases;

    [Token(Token = "0x17001E40")]
    public List<PlayerChatPhraseType> Phrases
    {
      [Token(Token = "0x600A349"), Address(RVA = "0x46CE3E0", Offset = "0x46CE3E0", VA = "0x46CE3E0")] get
      {
        return (List<PlayerChatPhraseType>) null;
      }
    }

    [Token(Token = "0x600A34A")]
    [Address(RVA = "0x46CE3E8", Offset = "0x46CE3E8", VA = "0x46CE3E8")]
    public APIChatEdit_phraseResponse()
    {
    }
  }
}
