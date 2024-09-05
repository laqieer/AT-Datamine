// Decompiled with JetBrains decompiler
// Type: StaqData.AreaEvent.AreaEventQuestManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData.AreaEvent
{
  [Token(Token = "0x2002157")]
  public class AreaEventQuestManager
  {
    [Token(Token = "0x4008D55")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, AreaEventQuestData> entities;

    [Token(Token = "0x17002CC3")]
    private int CurrentSequenceID
    {
      [Token(Token = "0x600CC54"), Address(RVA = "0x1BAE05C", Offset = "0x1BAE05C", VA = "0x1BAE05C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CC4")]
    public IEnumerable<AreaEventQuestData> List
    {
      [Token(Token = "0x600CC55"), Address(RVA = "0x1BAE0C4", Offset = "0x1BAE0C4", VA = "0x1BAE0C4")] get
      {
        return (IEnumerable<AreaEventQuestData>) null;
      }
    }

    [Token(Token = "0x600CC56")]
    [Address(RVA = "0x1BAE114", Offset = "0x1BAE114", VA = "0x1BAE114")]
    public IEnumerable<AreaEventQuestData> ListWhereSequence(int sequenceID)
    {
      return (IEnumerable<AreaEventQuestData>) null;
    }

    [Token(Token = "0x17002CC5")]
    public IEnumerable<AreaEventQuestData> ReceiptableList
    {
      [Token(Token = "0x600CC57"), Address(RVA = "0x1BAE200", Offset = "0x1BAE200", VA = "0x1BAE200")] get
      {
        return (IEnumerable<AreaEventQuestData>) null;
      }
    }

    [Token(Token = "0x17002CC6")]
    public IEnumerable<AreaEventQuestData> ReceiptedList
    {
      [Token(Token = "0x600CC58"), Address(RVA = "0x1BAE314", Offset = "0x1BAE314", VA = "0x1BAE314")] get
      {
        return (IEnumerable<AreaEventQuestData>) null;
      }
    }

    [Token(Token = "0x17002CC7")]
    public IEnumerable<AreaEventQuestData> CompletedList
    {
      [Token(Token = "0x600CC59"), Address(RVA = "0x1BAE428", Offset = "0x1BAE428", VA = "0x1BAE428")] get
      {
        return (IEnumerable<AreaEventQuestData>) null;
      }
    }

    [Token(Token = "0x600CC5A")]
    [Address(RVA = "0x1BAE53C", Offset = "0x1BAE53C", VA = "0x1BAE53C")]
    public AreaEventQuestData Get(int areaeventquestID) => (AreaEventQuestData) null;

    [Token(Token = "0x600CC5B")]
    [Address(RVA = "0x1BAE5D0", Offset = "0x1BAE5D0", VA = "0x1BAE5D0")]
    public AreaEventQuestTask GetTask(int areaeventquestTaskID) => (AreaEventQuestTask) null;

    [Token(Token = "0x600CC5C")]
    [Address(RVA = "0x1BAE73C", Offset = "0x1BAE73C", VA = "0x1BAE73C")]
    public AreaEventQuestData GetCurrent() => (AreaEventQuestData) null;

    [Token(Token = "0x600CC5D")]
    [Address(RVA = "0x1BAEB64", Offset = "0x1BAEB64", VA = "0x1BAEB64")]
    public bool IsCompleted(int sequenceID) => new bool();

    [Token(Token = "0x600CC5E")]
    [Address(RVA = "0x1BAECA0", Offset = "0x1BAECA0", VA = "0x1BAECA0")]
    public void Setup()
    {
    }

    [Token(Token = "0x600CC5F")]
    [Address(RVA = "0x1BAF59C", Offset = "0x1BAF59C", VA = "0x1BAF59C")]
    public void Initialize(System.Collections.Generic.List<PlayerStoryAreaEventQuestType> responses)
    {
    }

    [Token(Token = "0x600CC60")]
    [Address(RVA = "0x1BAF604", Offset = "0x1BAF604", VA = "0x1BAF604")]
    public void Apply(System.Collections.Generic.List<PlayerStoryAreaEventQuestType> responses)
    {
    }

    [Token(Token = "0x600CC61")]
    [Address(RVA = "0x1BAF740", Offset = "0x1BAF740", VA = "0x1BAF740")]
    public void Apply(PlayerStoryAreaEventQuestType response)
    {
    }

    [Token(Token = "0x600CC62")]
    [Address(RVA = "0x1BAF44C", Offset = "0x1BAF44C", VA = "0x1BAF44C")]
    private void ChainNextQuest()
    {
    }

    [Token(Token = "0x600CC63")]
    [Address(RVA = "0x1BAF844", Offset = "0x1BAF844", VA = "0x1BAF844")]
    private void ChainNextQuest(AreaEventQuestData quest)
    {
    }

    [Token(Token = "0x600CC64")]
    [Address(RVA = "0x1BAF8CC", Offset = "0x1BAF8CC", VA = "0x1BAF8CC")]
    public void Reset()
    {
    }

    [Token(Token = "0x600CC65")]
    [Address(RVA = "0x1BAF91C", Offset = "0x1BAF91C", VA = "0x1BAF91C")]
    public AreaEventQuestManager()
    {
    }
  }
}
