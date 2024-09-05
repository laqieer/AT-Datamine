// Decompiled with JetBrains decompiler
// Type: StaqData.ChartInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200209D")]
  public class ChartInfo
  {
    [Token(Token = "0x17002A26")]
    public ChartInfo.SequenceLogInfo SequenceLog
    {
      [Token(Token = "0x600C53F"), Address(RVA = "0x1A015E4", Offset = "0x1A015E4", VA = "0x1A015E4")] get
      {
        return (ChartInfo.SequenceLogInfo) null;
      }
      [Token(Token = "0x600C540"), Address(RVA = "0x1A015EC", Offset = "0x1A015EC", VA = "0x1A015EC")] private set
      {
      }
    }

    [Token(Token = "0x17002A27")]
    public ChartInfo.LogInfo AdvLog
    {
      [Token(Token = "0x600C541"), Address(RVA = "0x1A015F4", Offset = "0x1A015F4", VA = "0x1A015F4")] get
      {
        return (ChartInfo.LogInfo) null;
      }
      [Token(Token = "0x600C542"), Address(RVA = "0x1A015FC", Offset = "0x1A015FC", VA = "0x1A015FC")] private set
      {
      }
    }

    [Token(Token = "0x17002A28")]
    public ChartInfo.LogInfo AdvOneLog
    {
      [Token(Token = "0x600C543"), Address(RVA = "0x1A01604", Offset = "0x1A01604", VA = "0x1A01604")] get
      {
        return (ChartInfo.LogInfo) null;
      }
      [Token(Token = "0x600C544"), Address(RVA = "0x1A0160C", Offset = "0x1A0160C", VA = "0x1A0160C")] private set
      {
      }
    }

    [Token(Token = "0x17002A29")]
    public ChartInfo.LogInfo UnlockedOptionLog
    {
      [Token(Token = "0x600C545"), Address(RVA = "0x1A01614", Offset = "0x1A01614", VA = "0x1A01614")] get
      {
        return (ChartInfo.LogInfo) null;
      }
      [Token(Token = "0x600C546"), Address(RVA = "0x1A0161C", Offset = "0x1A0161C", VA = "0x1A0161C")] private set
      {
      }
    }

    [Token(Token = "0x17002A2A")]
    public ChartInfo.LogInfo StoryBattleMissionLog
    {
      [Token(Token = "0x600C547"), Address(RVA = "0x1A01624", Offset = "0x1A01624", VA = "0x1A01624")] get
      {
        return (ChartInfo.LogInfo) null;
      }
      [Token(Token = "0x600C548"), Address(RVA = "0x1A0162C", Offset = "0x1A0162C", VA = "0x1A0162C")] private set
      {
      }
    }

    [Token(Token = "0x17002A2B")]
    public List<int> AllAdvAdditionalOptionIds
    {
      [Token(Token = "0x600C549"), Address(RVA = "0x1A01634", Offset = "0x1A01634", VA = "0x1A01634")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600C54A"), Address(RVA = "0x1A0163C", Offset = "0x1A0163C", VA = "0x1A0163C")] private set
      {
      }
    }

    [Token(Token = "0x17002A2C")]
    public List<int> AllEndingSequenceIds
    {
      [Token(Token = "0x600C54B"), Address(RVA = "0x1A01644", Offset = "0x1A01644", VA = "0x1A01644")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600C54C"), Address(RVA = "0x1A0164C", Offset = "0x1A0164C", VA = "0x1A0164C")] private set
      {
      }
    }

    [Token(Token = "0x600C54D")]
    [Address(RVA = "0x1A01654", Offset = "0x1A01654", VA = "0x1A01654")]
    public ChartInfo()
    {
    }

    [Token(Token = "0x600C54E")]
    [Address(RVA = "0x1A01D48", Offset = "0x1A01D48", VA = "0x1A01D48")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600C54F")]
    [Address(RVA = "0x1A01FF8", Offset = "0x1A01FF8", VA = "0x1A01FF8")]
    public ChartInfo(ChartAggregation chartAggregation)
    {
    }

    [Token(Token = "0x600C550")]
    [Address(RVA = "0x1A0213C", Offset = "0x1A0213C", VA = "0x1A0213C")]
    public void Apply(ChartAggregation chartAggregation)
    {
    }

    [Token(Token = "0x600C551")]
    [Address(RVA = "0x1A02784", Offset = "0x1A02784", VA = "0x1A02784")]
    public void ApplyAfterAdvRequestParamNetwork(AdvRequest advRequestParam)
    {
    }

    [Token(Token = "0x600C552")]
    [Address(RVA = "0x1A02C64", Offset = "0x1A02C64", VA = "0x1A02C64")]
    public void ApplyAfterAdvRequestParamNetwork(List<AdvRequest> advRequestParams)
    {
    }

    [Token(Token = "0x600C553")]
    [Address(RVA = "0x1A02DA0", Offset = "0x1A02DA0", VA = "0x1A02DA0")]
    public void AddSequenceLog(int fromSequenceID, int toSequenceID)
    {
    }

    [Token(Token = "0x600C554")]
    [Address(RVA = "0x1A0308C", Offset = "0x1A0308C", VA = "0x1A0308C")]
    public void SequenceLogReset()
    {
    }

    [Token(Token = "0x200209E")]
    public class SequenceLogInfo
    {
      [Token(Token = "0x4008AAB")]
      [FieldOffset(Offset = "0x10")]
      private List<SequenceEdgeLog> currentLogs;
      [Token(Token = "0x4008AAC")]
      [FieldOffset(Offset = "0x18")]
      private List<SequenceEdgeLog> allLogs;
      [Token(Token = "0x4008AAD")]
      [FieldOffset(Offset = "0x20")]
      private readonly ChartInfo owner;

      [Token(Token = "0x17002A2D")]
      public IEnumerable<SequenceEdgeLog> CurrentLogs
      {
        [Token(Token = "0x600C555"), Address(RVA = "0x1A03114", Offset = "0x1A03114", VA = "0x1A03114")] get
        {
          return (IEnumerable<SequenceEdgeLog>) null;
        }
      }

      [Token(Token = "0x17002A2E")]
      public IEnumerable<int> CurrentLogIDs
      {
        [Token(Token = "0x600C556"), Address(RVA = "0x1A0311C", Offset = "0x1A0311C", VA = "0x1A0311C")] get
        {
          return (IEnumerable<int>) null;
        }
      }

      [Token(Token = "0x600C557")]
      [Address(RVA = "0x1A03218", Offset = "0x1A03218", VA = "0x1A03218")]
      public bool PassedTargetAllSequence(int seqeunceId) => new bool();

      [Token(Token = "0x600C558")]
      [Address(RVA = "0x1A01900", Offset = "0x1A01900", VA = "0x1A01900")]
      public SequenceLogInfo(
        List<PlayerMainStorySequenceTransitionType> currentLogs,
        List<PlayerMainStorySequenceTransitionLogType> allLogs,
        ChartInfo owner)
      {
      }

      [Token(Token = "0x600C559")]
      [Address(RVA = "0x1A02F24", Offset = "0x1A02F24", VA = "0x1A02F24")]
      public void Add(int fromSequenceID, int toSequenceID)
      {
      }

      [Token(Token = "0x600C55A")]
      [Address(RVA = "0x1A033DC", Offset = "0x1A033DC", VA = "0x1A033DC")]
      public bool ContainsInCurrentLogs(int sequenceID) => new bool();

      [Token(Token = "0x600C55B")]
      [Address(RVA = "0x1A034FC", Offset = "0x1A034FC", VA = "0x1A034FC")]
      public bool ContainsInAllLogs(int sequenceID) => new bool();

      [Token(Token = "0x600C55C")]
      [Address(RVA = "0x1A0361C", Offset = "0x1A0361C", VA = "0x1A0361C")]
      public bool ContainsInCurrentLogs(int fromsequenceID, int tosequenceID) => new bool();

      [Token(Token = "0x600C55D")]
      [Address(RVA = "0x1A03700", Offset = "0x1A03700", VA = "0x1A03700")]
      public IEnumerable<SequenceEdgeLog> GetListToSequence(int tosequenceID)
      {
        return (IEnumerable<SequenceEdgeLog>) null;
      }

      [Token(Token = "0x600C55E")]
      [Address(RVA = "0x1A030A4", Offset = "0x1A030A4", VA = "0x1A030A4")]
      public void CurrentLogClear()
      {
      }

      [Token(Token = "0x600C55F")]
      [Address(RVA = "0x1A037E0", Offset = "0x1A037E0", VA = "0x1A037E0")]
      public void AllLogClear()
      {
      }

      [Token(Token = "0x600C560")]
      [Address(RVA = "0x1A03850", Offset = "0x1A03850", VA = "0x1A03850")]
      public bool Exsits() => new bool();
    }

    [Token(Token = "0x20020A3")]
    public class LogInfo
    {
      [Token(Token = "0x4008AB6")]
      [FieldOffset(Offset = "0x10")]
      private List<int> currentLog;
      [Token(Token = "0x4008AB7")]
      [FieldOffset(Offset = "0x18")]
      private List<int> allLog;
      [Token(Token = "0x4008AB8")]
      [FieldOffset(Offset = "0x20")]
      private IEnumerable<int> target;

      [Token(Token = "0x17002A2F")]
      public IEnumerable<int> CurrentLog
      {
        [Token(Token = "0x600C56C"), Address(RVA = "0x1A039DC", Offset = "0x1A039DC", VA = "0x1A039DC")] get
        {
          return (IEnumerable<int>) null;
        }
      }

      [Token(Token = "0x17002A30")]
      public IEnumerable<int> AllLog
      {
        [Token(Token = "0x600C56D"), Address(RVA = "0x1A039E4", Offset = "0x1A039E4", VA = "0x1A039E4")] get
        {
          return (IEnumerable<int>) null;
        }
      }

      [Token(Token = "0x600C56E")]
      [Address(RVA = "0x1A01848", Offset = "0x1A01848", VA = "0x1A01848")]
      public LogInfo(List<int> currentLog, List<int> allLog)
      {
      }

      [Token(Token = "0x600C56F")]
      [Address(RVA = "0x1A039EC", Offset = "0x1A039EC", VA = "0x1A039EC")]
      public bool Contains(int id) => new bool();

      [Token(Token = "0x600C570")]
      [Address(RVA = "0x1A02838", Offset = "0x1A02838", VA = "0x1A02838")]
      public void Add(int element)
      {
      }

      [Token(Token = "0x600C571")]
      [Address(RVA = "0x1A0298C", Offset = "0x1A0298C", VA = "0x1A0298C")]
      public void AddRange(IEnumerable<int> elements)
      {
      }

      [Token(Token = "0x600C572")]
      [Address(RVA = "0x1A03A74", Offset = "0x1A03A74", VA = "0x1A03A74")]
      public void TargetIsCurrentLog()
      {
      }

      [Token(Token = "0x600C573")]
      [Address(RVA = "0x1A03A80", Offset = "0x1A03A80", VA = "0x1A03A80")]
      public void TargetIsAllLog()
      {
      }

      [Token(Token = "0x600C574")]
      [Address(RVA = "0x1A03A8C", Offset = "0x1A03A8C", VA = "0x1A03A8C")]
      public void CurrentLogClear()
      {
      }

      [Token(Token = "0x600C575")]
      [Address(RVA = "0x1A03ADC", Offset = "0x1A03ADC", VA = "0x1A03ADC")]
      public void AllLogClear()
      {
      }

      [Token(Token = "0x600C576")]
      [Address(RVA = "0x1A03B2C", Offset = "0x1A03B2C", VA = "0x1A03B2C")]
      public void Clear()
      {
      }
    }
  }
}
