// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFacilityPrepareResponse
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
  [Token(Token = "0x2001E34")]
  [Serializable]
  public class APIStoryFacilityPrepareResponse : ICommonApiResult
  {
    [Token(Token = "0x4008168")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008169")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StoryFacilityPrepareResult facility_prepare_result;

    [Token(Token = "0x17002427")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B2E0"), Address(RVA = "0x22E13D4", Offset = "0x22E13D4", VA = "0x22E13D4", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002428")]
    public StoryFacilityPrepareResult FacilityPrepareResult
    {
      [Token(Token = "0x600B2E1"), Address(RVA = "0x22E13DC", Offset = "0x22E13DC", VA = "0x22E13DC")] get
      {
        return (StoryFacilityPrepareResult) null;
      }
    }

    [Token(Token = "0x600B2E2")]
    [Address(RVA = "0x22E13E4", Offset = "0x22E13E4", VA = "0x22E13E4")]
    public APIStoryFacilityPrepareResponse()
    {
    }
  }
}
