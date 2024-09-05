// Decompiled with JetBrains decompiler
// Type: Network.API.APIGachaResponse
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
  [Token(Token = "0x2001C94")]
  [Serializable]
  public class APIGachaResponse
  {
    [Token(Token = "0x4007A39")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GachaModuleType> gacha_modules;
    [Token(Token = "0x4007A3A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<StoryGachaInfoType> story_gacha_infos;

    [Token(Token = "0x17002019")]
    public List<GachaModuleType> GachaModules
    {
      [Token(Token = "0x600A852"), Address(RVA = "0x1911750", Offset = "0x1911750", VA = "0x1911750")] get
      {
        return (List<GachaModuleType>) null;
      }
    }

    [Token(Token = "0x1700201A")]
    public List<StoryGachaInfoType> StoryGachaInfos
    {
      [Token(Token = "0x600A853"), Address(RVA = "0x1911758", Offset = "0x1911758", VA = "0x1911758")] get
      {
        return (List<StoryGachaInfoType>) null;
      }
    }

    [Token(Token = "0x600A854")]
    [Address(RVA = "0x1911760", Offset = "0x1911760", VA = "0x1911760")]
    public APIGachaResponse()
    {
    }
  }
}
