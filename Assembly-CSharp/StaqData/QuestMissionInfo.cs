// Decompiled with JetBrains decompiler
// Type: StaqData.QuestMissionInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002074")]
  public class QuestMissionInfo
  {
    [Token(Token = "0x4008A33")]
    [FieldOffset(Offset = "0x10")]
    private QuestMissionInfo.IPlayMissionState playDataAccess;

    [Token(Token = "0x600C44F")]
    [Address(RVA = "0x19F6800", Offset = "0x19F6800", VA = "0x19F6800")]
    public QuestMissionInfo(
      BattleMissionData data,
      QuestMissionInfo.IPlayMissionState playDataAccess)
    {
    }

    [Token(Token = "0x170029E6")]
    public bool IsCleard
    {
      [Token(Token = "0x600C450"), Address(RVA = "0x19F01E0", Offset = "0x19F01E0", VA = "0x19F01E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170029E7")]
    public BattleMissionData RawMasterData
    {
      [Token(Token = "0x600C451"), Address(RVA = "0x19F682C", Offset = "0x19F682C", VA = "0x19F682C")] get
      {
        return (BattleMissionData) null;
      }
      [Token(Token = "0x600C452"), Address(RVA = "0x19F6834", Offset = "0x19F6834", VA = "0x19F6834")] private set
      {
      }
    }

    [Token(Token = "0x2002075")]
    public interface IPlayMissionState
    {
      [Token(Token = "0x600C453")]
      bool IsCleard();
    }
  }
}
