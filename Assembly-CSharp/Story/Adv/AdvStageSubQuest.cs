// Decompiled with JetBrains decompiler
// Type: Story.Adv.AdvStageSubQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData.SubQuest;

#nullable disable
namespace Story.Adv
{
  [Token(Token = "0x2000752")]
  public class AdvStageSubQuest : AdvStage
  {
    [Token(Token = "0x1700061E")]
    public SubQuestLuaFunction LuaFunction
    {
      [Token(Token = "0x6002900"), Address(RVA = "0x367A424", Offset = "0x367A424", VA = "0x367A424")] get
      {
        return (SubQuestLuaFunction) null;
      }
      [Token(Token = "0x6002901"), Address(RVA = "0x367A42C", Offset = "0x367A42C", VA = "0x367A42C")] private set
      {
      }
    }

    [Token(Token = "0x6002902")]
    [Address(RVA = "0x367A434", Offset = "0x367A434", VA = "0x367A434")]
    public AdvStageSubQuest(AdvDemoInfoData demoInfo)
    {
    }

    [Token(Token = "0x6002903")]
    [Address(RVA = "0x367A444", Offset = "0x367A444", VA = "0x367A444")]
    public void Initialize(int subquestTaskID)
    {
    }
  }
}
