// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestSelectSubSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033F7")]
  public class QuestSelectSubSceneParameter : ChangeSceneParameter
  {
    [Token(Token = "0x1700440B")]
    public int[] QuestIds
    {
      [Token(Token = "0x60146C8"), Address(RVA = "0x188F4F4", Offset = "0x188F4F4", VA = "0x188F4F4")] get
      {
        return (int[]) null;
      }
      [Token(Token = "0x60146C9"), Address(RVA = "0x188F4FC", Offset = "0x188F4FC", VA = "0x188F4FC")] protected set
      {
      }
    }

    [Token(Token = "0x1700440C")]
    public QuestTypeEnum QuestType
    {
      [Token(Token = "0x60146CA"), Address(RVA = "0x188F504", Offset = "0x188F504", VA = "0x188F504")] get
      {
        return new QuestTypeEnum();
      }
      [Token(Token = "0x60146CB"), Address(RVA = "0x188F50C", Offset = "0x188F50C", VA = "0x188F50C")] protected set
      {
      }
    }

    [Token(Token = "0x1700440D")]
    public bool ShowHeader
    {
      [Token(Token = "0x60146CC"), Address(RVA = "0x188F514", Offset = "0x188F514", VA = "0x188F514")] get
      {
        return new bool();
      }
      [Token(Token = "0x60146CD"), Address(RVA = "0x188F51C", Offset = "0x188F51C", VA = "0x188F51C")] protected set
      {
      }
    }

    [Token(Token = "0x1700440E")]
    protected virtual bool showHeader
    {
      [Token(Token = "0x60146CE"), Address(RVA = "0x188F528", Offset = "0x188F528", VA = "0x188F528", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700440F")]
    public int? InitQuestId
    {
      [Token(Token = "0x60146CF"), Address(RVA = "0x188F530", Offset = "0x188F530", VA = "0x188F530")] get
      {
        return new int?();
      }
      [Token(Token = "0x60146D0"), Address(RVA = "0x188F538", Offset = "0x188F538", VA = "0x188F538")] protected set
      {
      }
    }

    [Token(Token = "0x17004410")]
    public bool NeedFadeOnInitialize
    {
      [Token(Token = "0x60146D1"), Address(RVA = "0x188F540", Offset = "0x188F540", VA = "0x188F540")] get
      {
        return new bool();
      }
      [Token(Token = "0x60146D2"), Address(RVA = "0x188F548", Offset = "0x188F548", VA = "0x188F548")] set
      {
      }
    }

    [Token(Token = "0x60146D3")]
    [Address(RVA = "0x188C568", Offset = "0x188C568", VA = "0x188C568")]
    public QuestSelectSubSceneParameter(int[] questIds, QuestTypeEnum questType, int? initQuestId = null)
    {
    }

    [Token(Token = "0x60146D4")]
    [Address(RVA = "0x188F554", Offset = "0x188F554", VA = "0x188F554")]
    public QuestSelectSubSceneParameter(
      int[] questIds,
      QuestTypeEnum questType,
      bool showHeader,
      int? initQuestId = null)
    {
    }
  }
}
