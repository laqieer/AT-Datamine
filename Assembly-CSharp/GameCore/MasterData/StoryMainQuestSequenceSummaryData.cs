// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestSequenceSummaryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012A8")]
  [Serializable]
  public sealed class StoryMainQuestSequenceSummaryData : IMasterDataEntity
  {
    [Token(Token = "0x40058E3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058E4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int calendarId;

    [Token(Token = "0x17000FFD")]
    public int Key
    {
      [Token(Token = "0x60069E7"), Address(RVA = "0x48D41A0", Offset = "0x48D41A0", VA = "0x48D41A0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60069E8")]
    [Address(RVA = "0x48D41A8", Offset = "0x48D41A8", VA = "0x48D41A8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60069E9")]
    [Address(RVA = "0x48D42B4", Offset = "0x48D42B4", VA = "0x48D42B4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000FFE")]
    public string SummaryTitleText
    {
      [Token(Token = "0x60069EA"), Address(RVA = "0x48D4338", Offset = "0x48D4338", VA = "0x48D4338")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FFF")]
    public string SummaryPlanText
    {
      [Token(Token = "0x60069EB"), Address(RVA = "0x48D4414", Offset = "0x48D4414", VA = "0x48D4414")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001000")]
    public string SumamryDescriptionText
    {
      [Token(Token = "0x60069EC"), Address(RVA = "0x48D44F0", Offset = "0x48D44F0", VA = "0x48D44F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001001")]
    public string SummaryTaskText
    {
      [Token(Token = "0x60069ED"), Address(RVA = "0x48D45CC", Offset = "0x48D45CC", VA = "0x48D45CC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60069EE")]
    [Address(RVA = "0x48D46A8", Offset = "0x48D46A8", VA = "0x48D46A8")]
    public StoryMainQuestSequenceSummaryData()
    {
    }
  }
}
