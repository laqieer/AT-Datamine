// Decompiled with JetBrains decompiler
// Type: Story.Adv.AdvStageRead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv.StoryMainQuest;

#nullable disable
namespace Story.Adv
{
  [Token(Token = "0x2000751")]
  public class AdvStageRead : AdvStage
  {
    [Token(Token = "0x1700061D")]
    public ReadBookAdvLuaFunction LuaFunction
    {
      [Token(Token = "0x60028FE"), Address(RVA = "0x367A32C", Offset = "0x367A32C", VA = "0x367A32C")] get
      {
        return (ReadBookAdvLuaFunction) null;
      }
    }

    [Token(Token = "0x60028FF")]
    [Address(RVA = "0x367A334", Offset = "0x367A334", VA = "0x367A334")]
    public AdvStageRead(AdvDemoInfoData demoInfo)
    {
    }
  }
}
