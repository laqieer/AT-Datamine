// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.Data.MissionDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Mission.Data
{
  [Token(Token = "0x2002AAF")]
  public class MissionDataManager
  {
    [Token(Token = "0x400B59E")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<int, MissionData> missionMaster;

    [Token(Token = "0x6010B1F")]
    [Address(RVA = "0x4BCF730", Offset = "0x4BCF730", VA = "0x4BCF730")]
    public void Init()
    {
    }

    [Token(Token = "0x6010B20")]
    [Address(RVA = "0x4BCEF5C", Offset = "0x4BCEF5C", VA = "0x4BCEF5C")]
    public List<MissionRewardData> GetMissionRewardList(int missionID)
    {
      return (List<MissionRewardData>) null;
    }

    [Token(Token = "0x6010B21")]
    [Address(RVA = "0x4BD2F84", Offset = "0x4BD2F84", VA = "0x4BD2F84")]
    public MissionDataManager()
    {
    }
  }
}
