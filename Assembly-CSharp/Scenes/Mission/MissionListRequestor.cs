// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionListRequestor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002A97")]
  public class MissionListRequestor
  {
    [Token(Token = "0x400B543")]
    [FieldOffset(Offset = "0x10")]
    private List<int> _missionGroupIds;

    [Token(Token = "0x6010AA2")]
    [Address(RVA = "0x4BCCF2C", Offset = "0x4BCCF2C", VA = "0x4BCCF2C")]
    public MissionListRequestor(int missionGroupId)
    {
    }

    [Token(Token = "0x6010AA3")]
    [Address(RVA = "0x4BCF2C0", Offset = "0x4BCF2C0", VA = "0x4BCF2C0")]
    public MissionListRequestor(List<int> missionGroupIds)
    {
    }

    [Token(Token = "0x6010AA4")]
    [Address(RVA = "0x4BCD028", Offset = "0x4BCD028", VA = "0x4BCD028")]
    public IEnumerator Connect(Action<APIMissionListResponse> callback) => (IEnumerator) null;
  }
}
