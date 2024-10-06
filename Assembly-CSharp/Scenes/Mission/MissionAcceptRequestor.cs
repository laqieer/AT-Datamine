// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionAcceptRequestor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network;
using Network.API;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002A77")]
  public class MissionAcceptRequestor
  {
    [Token(Token = "0x400B4C5")]
    [FieldOffset(Offset = "0x10")]
    private int _missionGroupId;
    [Token(Token = "0x400B4C6")]
    [FieldOffset(Offset = "0x18")]
    private List<int> _missionIds;

    [Token(Token = "0x60109F3")]
    [Address(RVA = "0x4C3453C", Offset = "0x4C3453C", VA = "0x4C3453C")]
    public MissionAcceptRequestor(int missionGroupId, List<int> missionIds)
    {
    }

    [Token(Token = "0x60109F4")]
    [Address(RVA = "0x4C3456C", Offset = "0x4C3456C", VA = "0x4C3456C")]
    public IEnumerator Connect(
      Action<APIMissionAcceptResponse> successCallback,
      Func<NetworkErrorResult, IEnumerator> errorCallback)
    {
      return (IEnumerator) null;
    }
  }
}
