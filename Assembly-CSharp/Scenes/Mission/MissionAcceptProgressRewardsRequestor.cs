// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionAcceptProgressRewardsRequestor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.API;
using System;
using System.Collections;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002A74")]
  public class MissionAcceptProgressRewardsRequestor
  {
    [Token(Token = "0x400B4BD")]
    [FieldOffset(Offset = "0x10")]
    private int _missionGroupId;

    [Token(Token = "0x60109E9")]
    [Address(RVA = "0x4C3419C", Offset = "0x4C3419C", VA = "0x4C3419C")]
    public MissionAcceptProgressRewardsRequestor(int missionGroupId)
    {
    }

    [Token(Token = "0x60109EA")]
    [Address(RVA = "0x4C341C4", Offset = "0x4C341C4", VA = "0x4C341C4")]
    public IEnumerator Connect(
      Action<APIMissionAccept_progress_rewardsResponse> successCallback,
      Func<NetworkErrorResult, IEnumerator> errorCallback)
    {
      return (IEnumerator) null;
    }
  }
}
