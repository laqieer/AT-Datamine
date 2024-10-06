// Decompiled with JetBrains decompiler
// Type: StaqData.AreaQuest.AreaQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using System.Collections.Generic;

#nullable disable
namespace StaqData.AreaQuest
{
  [Token(Token = "0x20021C5")]
  public class AreaQuestData
  {
    [Token(Token = "0x4008F10")]
    [FieldOffset(Offset = "0x10")]
    private List<int> claeredAreaNodeListRaw;

    [Token(Token = "0x17002D0B")]
    public int BattleAreaQuestNodeID
    {
      [Token(Token = "0x600CE4E"), Address(RVA = "0x4B6250C", Offset = "0x4B6250C", VA = "0x4B6250C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600CE4F")]
    [Address(RVA = "0x4B62590", Offset = "0x4B62590", VA = "0x4B62590")]
    public void ApplyBattleEndResponse(APIAreaQuestBattleEndResponse response)
    {
    }

    [Token(Token = "0x600CE50")]
    [Address(RVA = "0x4B62684", Offset = "0x4B62684", VA = "0x4B62684")]
    public void ApplySinginResponse(APIPlayerSigninResponse signinResponse)
    {
    }

    [Token(Token = "0x600CE51")]
    [Address(RVA = "0x4B62884", Offset = "0x4B62884", VA = "0x4B62884")]
    public bool IsClearedAreaNode(int areanodeid) => new bool();

    [Token(Token = "0x600CE52")]
    [Address(RVA = "0x4B628E0", Offset = "0x4B628E0", VA = "0x4B628E0")]
    public bool IsPlayableAdv(int areaNodeid) => new bool();

    [Token(Token = "0x600CE53")]
    [Address(RVA = "0x4B62A18", Offset = "0x4B62A18", VA = "0x4B62A18")]
    public bool IsClearAreaNodeQuest(int nodeId, QuestDifficultyTypeEnum difficult) => new bool();

    [Token(Token = "0x600CE54")]
    [Address(RVA = "0x4B62AF8", Offset = "0x4B62AF8", VA = "0x4B62AF8")]
    public bool IsPlayableAreaNode(int areaNodeId) => new bool();

    [Token(Token = "0x600CE55")]
    [Address(RVA = "0x4B6345C", Offset = "0x4B6345C", VA = "0x4B6345C")]
    public bool IsPlayableArea(int areaId) => new bool();

    [Token(Token = "0x600CE56")]
    [Address(RVA = "0x4B6352C", Offset = "0x4B6352C", VA = "0x4B6352C")]
    public bool IsPlayableAreaGroup(int areaGroupId) => new bool();

    [Token(Token = "0x600CE57")]
    [Address(RVA = "0x4B632F8", Offset = "0x4B632F8", VA = "0x4B632F8")]
    private bool IsPlayableAreaGroupSelf(int areaGroupId) => new bool();

    [Token(Token = "0x600CE58")]
    [Address(RVA = "0x4B63130", Offset = "0x4B63130", VA = "0x4B63130")]
    private bool IsPlayableAreaSelf(int areaId) => new bool();

    [Token(Token = "0x600CE59")]
    [Address(RVA = "0x4B62C3C", Offset = "0x4B62C3C", VA = "0x4B62C3C")]
    private bool IsPlayableAreaNodeSelf(int areaNodeId) => new bool();

    [Token(Token = "0x600CE5A")]
    [Address(RVA = "0x4B62888", Offset = "0x4B62888", VA = "0x4B62888")]
    private bool IsClearedAreaNodeInternal(int areanodeid) => new bool();

    [Token(Token = "0x600CE5B")]
    [Address(RVA = "0x4B638BC", Offset = "0x4B638BC", VA = "0x4B638BC")]
    private int GetStoryLoopNum(int chapterId) => new int();

    [Token(Token = "0x600CE5C")]
    [Address(RVA = "0x4B63978", Offset = "0x4B63978", VA = "0x4B63978")]
    public void SaveLastSelectAreaQuestParam(
      int areaGroupId,
      int areaId,
      int areaNodeId,
      QuestDifficultyTypeEnum diff)
    {
    }

    [Token(Token = "0x600CE5D")]
    [Address(RVA = "0x4B63B2C", Offset = "0x4B63B2C", VA = "0x4B63B2C")]
    public void GetLastSelectAreaQuestParam(
      out int areaGroupId,
      out int areaId,
      out int areaNodeId,
      out QuestDifficultyTypeEnum defDiff)
    {
    }

    [Token(Token = "0x600CE5E")]
    [Address(RVA = "0x4B63CAC", Offset = "0x4B63CAC", VA = "0x4B63CAC")]
    public void ResetLastSeletAreaQuestParam()
    {
    }

    [Token(Token = "0x600CE5F")]
    [Address(RVA = "0x4B63CC0", Offset = "0x4B63CC0", VA = "0x4B63CC0")]
    public void SaveQuestDifficultySelectCache(QuestDifficultyTypeEnum diff)
    {
    }

    [Token(Token = "0x600CE60")]
    [Address(RVA = "0x4B63D8C", Offset = "0x4B63D8C", VA = "0x4B63D8C")]
    public QuestDifficultyTypeEnum GetSaveQuestDifficultySelectCache()
    {
      return new QuestDifficultyTypeEnum();
    }

    [Token(Token = "0x600CE61")]
    [Address(RVA = "0x4B63ED0", Offset = "0x4B63ED0", VA = "0x4B63ED0")]
    public AreaQuestData()
    {
    }

    [Token(Token = "0x20021C6")]
    public class NewOpenAreaGroupData
    {
      [Token(Token = "0x17002D0C")]
      public IReadOnlyList<int> AreaGroupIds
      {
        [Token(Token = "0x600CE62"), Address(RVA = "0x4B63F4C", Offset = "0x4B63F4C", VA = "0x4B63F4C")] get
        {
          return (IReadOnlyList<int>) null;
        }
        [Token(Token = "0x600CE63"), Address(RVA = "0x4B63F54", Offset = "0x4B63F54", VA = "0x4B63F54")] private set
        {
        }
      }

      [Token(Token = "0x600CE64")]
      [Address(RVA = "0x4B63F5C", Offset = "0x4B63F5C", VA = "0x4B63F5C")]
      public NewOpenAreaGroupData(IReadOnlyList<int> areaGroupIds)
      {
      }
    }
  }
}
