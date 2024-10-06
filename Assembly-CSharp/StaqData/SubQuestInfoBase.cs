// Decompiled with JetBrains decompiler
// Type: StaqData.SubQuestInfoBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002064")]
  public abstract class SubQuestInfoBase : QuestInfo, StroySubQuestStoryParam
  {
    [Token(Token = "0x17002955")]
    public int SubQuestTaskId
    {
      [Token(Token = "0x600C36F"), Address(RVA = "0x19F2E44", Offset = "0x19F2E44", VA = "0x19F2E44", Slot = "27")] get
      {
        return new int();
      }
      [Token(Token = "0x600C370"), Address(RVA = "0x19F2E4C", Offset = "0x19F2E4C", VA = "0x19F2E4C")] private set
      {
      }
    }

    [Token(Token = "0x600C371")]
    [Address(RVA = "0x19F2E54", Offset = "0x19F2E54", VA = "0x19F2E54")]
    public SubQuestInfoBase(int questId, int subQuestTaskId)
    {
    }
  }
}
