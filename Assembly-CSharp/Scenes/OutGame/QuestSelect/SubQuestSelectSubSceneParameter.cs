// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.SubQuestSelectSubSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033F9")]
  public class SubQuestSelectSubSceneParameter : QuestSelectSubSceneParameter
  {
    [Token(Token = "0x17004412")]
    protected override bool showHeader
    {
      [Token(Token = "0x60146D7"), Address(RVA = "0x188F5FC", Offset = "0x188F5FC", VA = "0x188F5FC", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004413")]
    public int[] SubQuestIds
    {
      [Token(Token = "0x60146D8"), Address(RVA = "0x188F604", Offset = "0x188F604", VA = "0x188F604")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60146D9"), Address(RVA = "0x188F60C", Offset = "0x188F60C", VA = "0x188F60C")] private set
      {
      }
    }

    [Token(Token = "0x17004414")]
    public int[] SubQuestTaskIds
    {
      [Token(Token = "0x60146DA"), Address(RVA = "0x188F614", Offset = "0x188F614", VA = "0x188F614")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60146DB"), Address(RVA = "0x188F61C", Offset = "0x188F61C", VA = "0x188F61C")] private set
      {
      }
    }

    [Token(Token = "0x60146DC")]
    [Address(RVA = "0x188F624", Offset = "0x188F624", VA = "0x188F624")]
    public SubQuestSelectSubSceneParameter(
      QuestTypeEnum questType,
      int[] questIds,
      int[] subQuestIds,
      int[] subQuestTaskIds)
    {
    }
  }
}
