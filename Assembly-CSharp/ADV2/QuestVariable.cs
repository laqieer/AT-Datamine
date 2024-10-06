// Decompiled with JetBrains decompiler
// Type: ADV2.QuestVariable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E4F")]
  public class QuestVariable : 
    Adv2Manager.LocalProcessBuffer.VariableBase<QuestVariable.Type, string, int>
  {
    [Token(Token = "0x60191A1")]
    [Address(RVA = "0x2975D20", Offset = "0x2975D20", VA = "0x2975D20")]
    public QuestVariable()
    {
    }

    [Token(Token = "0x2003E50")]
    public enum Type
    {
      [Token(Token = "0x401119E")] SubQuest,
    }

    [Token(Token = "0x2003E51")]
    public static class Keys
    {
      [Token(Token = "0x401119F")]
      public const string QUEST_TASK_ID = "QuestTaskID";
    }
  }
}
