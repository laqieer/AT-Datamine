// Decompiled with JetBrains decompiler
// Type: Network.API.APITotal_missionListResponse
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
  [Token(Token = "0x2001E88")]
  [Serializable]
  public class APITotal_missionListResponse
  {
    [Token(Token = "0x4008333")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<TotalMissionTabType> tab_infos;

    [Token(Token = "0x1700252F")]
    public List<TotalMissionTabType> TabInfos
    {
      [Token(Token = "0x600B538"), Address(RVA = "0x22E8760", Offset = "0x22E8760", VA = "0x22E8760")] get
      {
        return (List<TotalMissionTabType>) null;
      }
    }

    [Token(Token = "0x600B539")]
    [Address(RVA = "0x22E8768", Offset = "0x22E8768", VA = "0x22E8768")]
    public APITotal_missionListResponse()
    {
    }
  }
}
