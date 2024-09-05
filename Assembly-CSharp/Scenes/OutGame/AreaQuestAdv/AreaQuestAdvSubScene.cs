// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestAdv.AreaQuestAdvSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using StaqData;
using Story.Adv;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;

#nullable disable
namespace Scenes.OutGame.AreaQuestAdv
{
  [Token(Token = "0x2003908")]
  public class AreaQuestAdvSubScene : SubScene
  {
    [Token(Token = "0x400F959")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AB_LABEL;
    [Token(Token = "0x400F95A")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string AB_NAME;

    [Token(Token = "0x170049B4")]
    private AreaQuestAdvSubScene.SceneParam Param
    {
      [Token(Token = "0x60166A8"), Address(RVA = "0x20848A8", Offset = "0x20848A8", VA = "0x20848A8")] get
      {
        return (AreaQuestAdvSubScene.SceneParam) null;
      }
      [Token(Token = "0x60166A9"), Address(RVA = "0x20848B0", Offset = "0x20848B0", VA = "0x20848B0")] set
      {
      }
    }

    [Token(Token = "0x60166AA")]
    [Address(RVA = "0x20848B8", Offset = "0x20848B8", VA = "0x20848B8")]
    public static void ChangeSceneNextBattle(QuestInfo questInfo, OrganizationTeam team)
    {
    }

    [Token(Token = "0x60166AB")]
    [Address(RVA = "0x2084B1C", Offset = "0x2084B1C", VA = "0x2084B1C")]
    public static void ChangeSubSceneNextAreaQuestBoard(int nodeId, bool playClearedNode)
    {
    }

    [Token(Token = "0x60166AC")]
    [Address(RVA = "0x20744BC", Offset = "0x20744BC", VA = "0x20744BC")]
    public static void ChangeSubSceneAreaQuestAdv(int nodeId)
    {
    }

    [Token(Token = "0x60166AD")]
    [Address(RVA = "0x2084D58", Offset = "0x2084D58", VA = "0x2084D58", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60166AE")]
    [Address(RVA = "0x2084DE4", Offset = "0x2084DE4", VA = "0x2084DE4", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60166AF")]
    [Address(RVA = "0x2084E74", Offset = "0x2084E74", VA = "0x2084E74")]
    public IEnumerator Play() => (IEnumerator) null;

    [Token(Token = "0x60166B0")]
    [Address(RVA = "0x2084F04", Offset = "0x2084F04", VA = "0x2084F04")]
    private List<int> GetAdvList(int nodeId, AreaQuestAdvSubScene.SceneType scene)
    {
      return (List<int>) null;
    }

    [Token(Token = "0x60166B1")]
    [Address(RVA = "0x20850D4", Offset = "0x20850D4", VA = "0x20850D4")]
    public AreaQuestAdvSubScene()
    {
    }

    [Token(Token = "0x60166B2")]
    [Address(RVA = "0x20850DC", Offset = "0x20850DC", VA = "0x20850DC")]
    static AreaQuestAdvSubScene()
    {
    }

    [Token(Token = "0x2003909")]
    public enum SceneType
    {
      [Token(Token = "0x400F95D")] PreBattleAdv,
      [Token(Token = "0x400F95E")] AfterBattleAdv,
      [Token(Token = "0x400F95F")] PlayAdv,
    }

    [Token(Token = "0x200390A")]
    public class SceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x170049B5")]
      public QuestInfo Quest
      {
        [Token(Token = "0x60166B3"), Address(RVA = "0x2085168", Offset = "0x2085168", VA = "0x2085168")] get
        {
          return (QuestInfo) null;
        }
        [Token(Token = "0x60166B4"), Address(RVA = "0x2085170", Offset = "0x2085170", VA = "0x2085170")] private set
        {
        }
      }

      [Token(Token = "0x170049B6")]
      public OrganizationTeam Team
      {
        [Token(Token = "0x60166B5"), Address(RVA = "0x2085178", Offset = "0x2085178", VA = "0x2085178")] get
        {
          return (OrganizationTeam) null;
        }
        [Token(Token = "0x60166B6"), Address(RVA = "0x2085180", Offset = "0x2085180", VA = "0x2085180")] private set
        {
        }
      }

      [Token(Token = "0x170049B7")]
      public int areaQuestNodeId
      {
        [Token(Token = "0x60166B7"), Address(RVA = "0x2085188", Offset = "0x2085188", VA = "0x2085188")] get
        {
          return new int();
        }
        [Token(Token = "0x60166B8"), Address(RVA = "0x2085190", Offset = "0x2085190", VA = "0x2085190")] private set
        {
        }
      }

      [Token(Token = "0x170049B8")]
      public AreaQuestAdvSubScene.SceneType NextScene
      {
        [Token(Token = "0x60166B9"), Address(RVA = "0x2085198", Offset = "0x2085198", VA = "0x2085198")] get
        {
          return new AreaQuestAdvSubScene.SceneType();
        }
        [Token(Token = "0x60166BA"), Address(RVA = "0x20851A0", Offset = "0x20851A0", VA = "0x20851A0")] private set
        {
        }
      }

      [Token(Token = "0x170049B9")]
      public bool isPlayAdv
      {
        [Token(Token = "0x60166BB"), Address(RVA = "0x20851A8", Offset = "0x20851A8", VA = "0x20851A8")] get
        {
          return new bool();
        }
        [Token(Token = "0x60166BC"), Address(RVA = "0x20851B0", Offset = "0x20851B0", VA = "0x20851B0")] private set
        {
        }
      }

      [Token(Token = "0x60166BD")]
      [Address(RVA = "0x20851BC", Offset = "0x20851BC", VA = "0x20851BC")]
      private SceneParam()
      {
      }

      [Token(Token = "0x60166BE")]
      [Address(RVA = "0x20849B4", Offset = "0x20849B4", VA = "0x20849B4")]
      public static AreaQuestAdvSubScene.SceneParam CreateBeforeBattle(
        QuestInfo info,
        OrganizationTeam team)
      {
        return (AreaQuestAdvSubScene.SceneParam) null;
      }

      [Token(Token = "0x60166BF")]
      [Address(RVA = "0x2084BFC", Offset = "0x2084BFC", VA = "0x2084BFC")]
      public static AreaQuestAdvSubScene.SceneParam CreateAfterBattle(
        int areaQuestNodeId,
        bool playClearedNode)
      {
        return (AreaQuestAdvSubScene.SceneParam) null;
      }

      [Token(Token = "0x60166C0")]
      [Address(RVA = "0x2084CE0", Offset = "0x2084CE0", VA = "0x2084CE0")]
      public static AreaQuestAdvSubScene.SceneParam CreateScenarioOnly(int areaQuestNodeId)
      {
        return (AreaQuestAdvSubScene.SceneParam) null;
      }
    }

    [Token(Token = "0x200390B")]
    private class AreaQuestAdvStage : 
      AdvStageBase,
      HaveStoryAlreadyRead,
      HaveStoryAlreadyReadAdvOption
    {
      [Token(Token = "0x60166C1")]
      [Address(RVA = "0x20851D0", Offset = "0x20851D0", VA = "0x20851D0")]
      public AreaQuestAdvStage(AdvDemoInfoData demoInfo)
      {
      }
    }
  }
}
