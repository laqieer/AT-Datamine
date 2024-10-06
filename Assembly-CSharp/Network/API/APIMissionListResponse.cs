// Decompiled with JetBrains decompiler
// Type: Network.API.APIMissionListResponse
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
  [Token(Token = "0x2001D74")]
  [Serializable]
  public class APIMissionListResponse
  {
    [Token(Token = "0x4007DD4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerMissionProgressType> player_mission_progresses;
    [Token(Token = "0x4007DD5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<int> accept_mission_progress_reward_ids;

    [Token(Token = "0x1700221D")]
    public List<PlayerMissionProgressType> PlayerMissionProgresses
    {
      [Token(Token = "0x600ADD6"), Address(RVA = "0x1A4B010", Offset = "0x1A4B010", VA = "0x1A4B010")] get
      {
        return (List<PlayerMissionProgressType>) null;
      }
    }

    [Token(Token = "0x1700221E")]
    public List<int> AcceptMissionProgressRewardIds
    {
      [Token(Token = "0x600ADD7"), Address(RVA = "0x1A4B018", Offset = "0x1A4B018", VA = "0x1A4B018")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600ADD8")]
    [Address(RVA = "0x1A4B020", Offset = "0x1A4B020", VA = "0x1A4B020")]
    public APIMissionListResponse()
    {
    }
  }
}
