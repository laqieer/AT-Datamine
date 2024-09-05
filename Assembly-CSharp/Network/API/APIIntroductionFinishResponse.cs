// Decompiled with JetBrains decompiler
// Type: Network.API.APIIntroductionFinishResponse
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
  [Token(Token = "0x2001D38")]
  [Serializable]
  public class APIIntroductionFinishResponse
  {
    [Token(Token = "0x4007CCB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerStoryChapterType player_chapter;

    [Token(Token = "0x17002183")]
    public PlayerStoryChapterType PlayerChapter
    {
      [Token(Token = "0x600AC4C"), Address(RVA = "0x1A45EAC", Offset = "0x1A45EAC", VA = "0x1A45EAC")] get
      {
        return (PlayerStoryChapterType) null;
      }
    }

    [Token(Token = "0x600AC4D")]
    [Address(RVA = "0x1A45EB4", Offset = "0x1A45EB4", VA = "0x1A45EB4")]
    public APIIntroductionFinishResponse()
    {
    }
  }
}
