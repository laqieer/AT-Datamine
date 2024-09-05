// Decompiled with JetBrains decompiler
// Type: Home.HomeTransitionContoller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using Network.API;
using Story.StoryArchive;
using System;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B4B")]
  public class HomeTransitionContoller
  {
    [Token(Token = "0x40033AD")]
    [FieldOffset(Offset = "0xA8")]
    public Action<int> TransitionNewsEvent;
    [Token(Token = "0x40033AE")]
    [FieldOffset(Offset = "0xB0")]
    public Action<int> OpenPaidCoinShop;

    [Token(Token = "0x17000959")]
    private SceneHandler sceneHandler
    {
      [Token(Token = "0x6004045"), Address(RVA = "0x2A25954", Offset = "0x2A25954", VA = "0x2A25954")] get
      {
        return (SceneHandler) null;
      }
    }

    [Token(Token = "0x1700095A")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataPresentBox
    {
      [Token(Token = "0x6004046"), Address(RVA = "0x2A259C0", Offset = "0x2A259C0", VA = "0x2A259C0")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x1700095B")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataMission
    {
      [Token(Token = "0x6004047"), Address(RVA = "0x2A259CC", Offset = "0x2A259CC", VA = "0x2A259CC")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x1700095C")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataPanelMission
    {
      [Token(Token = "0x6004048"), Address(RVA = "0x2A259D8", Offset = "0x2A259D8", VA = "0x2A259D8")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x1700095D")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataStoryArchive
    {
      [Token(Token = "0x6004049"), Address(RVA = "0x2A259E4", Offset = "0x2A259E4", VA = "0x2A259E4")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x1700095E")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataLoginBonus
    {
      [Token(Token = "0x600404A"), Address(RVA = "0x2A259F0", Offset = "0x2A259F0", VA = "0x2A259F0")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x1700095F")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataArmoury
    {
      [Token(Token = "0x600404B"), Address(RVA = "0x2A259FC", Offset = "0x2A259FC", VA = "0x2A259FC")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x17000960")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataPartyFormation
    {
      [Token(Token = "0x600404C"), Address(RVA = "0x2A25A08", Offset = "0x2A25A08", VA = "0x2A25A08")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x17000961")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataQuestContentsList
    {
      [Token(Token = "0x600404D"), Address(RVA = "0x2A25A14", Offset = "0x2A25A14", VA = "0x2A25A14")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x17000962")]
    private HomeTransitionContoller.SceneTransitionData TransitionDataExpedition
    {
      [Token(Token = "0x600404E"), Address(RVA = "0x2A25A20", Offset = "0x2A25A20", VA = "0x2A25A20")] get
      {
        return new HomeTransitionContoller.SceneTransitionData();
      }
    }

    [Token(Token = "0x17000963")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataChangeCharacter
    {
      [Token(Token = "0x600404F"), Address(RVA = "0x2A25A34", Offset = "0x2A25A34", VA = "0x2A25A34")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x17000964")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataGacha
    {
      [Token(Token = "0x6004050"), Address(RVA = "0x2A25A40", Offset = "0x2A25A40", VA = "0x2A25A40")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x17000965")]
    private HomeTransitionContoller.SubSceneTransitionData TransitionDataStyleRanking
    {
      [Token(Token = "0x6004051"), Address(RVA = "0x2A25A4C", Offset = "0x2A25A4C", VA = "0x2A25A4C")] get
      {
        return new HomeTransitionContoller.SubSceneTransitionData();
      }
    }

    [Token(Token = "0x6004052")]
    [Address(RVA = "0x2A25A58", Offset = "0x2A25A58", VA = "0x2A25A58")]
    private void TransitionSceneSimple(
      HomeTransitionContoller.SceneTransitionData transitionData,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6004053")]
    [Address(RVA = "0x2A25A90", Offset = "0x2A25A90", VA = "0x2A25A90")]
    private void TransitionScene(
      HomeTransitionContoller.SceneTransitionData transitionData,
      SceneHandler.LoadingTips loadingTips,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6004054")]
    [Address(RVA = "0x2A25AD0", Offset = "0x2A25AD0", VA = "0x2A25AD0")]
    private void TransitionSubScene(
      HomeTransitionContoller.SubSceneTransitionData transitionData,
      ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6004055")]
    [Address(RVA = "0x2A2117C", Offset = "0x2A2117C", VA = "0x2A2117C")]
    public void TransitionHomeTop(bool needFadeOnInitialize = false)
    {
    }

    [Token(Token = "0x6004056")]
    [Address(RVA = "0x2A25B0C", Offset = "0x2A25B0C", VA = "0x2A25B0C")]
    public void TransitionPresentBox()
    {
    }

    [Token(Token = "0x6004057")]
    [Address(RVA = "0x2A25B74", Offset = "0x2A25B74", VA = "0x2A25B74")]
    public void TransitionMission()
    {
    }

    [Token(Token = "0x6004058")]
    [Address(RVA = "0x2A25BDC", Offset = "0x2A25BDC", VA = "0x2A25BDC")]
    public void TransitionPanelMission()
    {
    }

    [Token(Token = "0x6004059")]
    [Address(RVA = "0x2A25C94", Offset = "0x2A25C94", VA = "0x2A25C94")]
    public void TransitionMail()
    {
    }

    [Token(Token = "0x600405A")]
    [Address(RVA = "0x2A211E8", Offset = "0x2A211E8", VA = "0x2A211E8")]
    public void TransitionLoginBonus()
    {
    }

    [Token(Token = "0x600405B")]
    [Address(RVA = "0x2A212F0", Offset = "0x2A212F0", VA = "0x2A212F0")]
    public void TransitionQuestContentsList()
    {
    }

    [Token(Token = "0x600405C")]
    [Address(RVA = "0x2A212E0", Offset = "0x2A212E0", VA = "0x2A212E0")]
    public void TransitionStoryArchive(StoryArchiveSubScene.Parameter parameter = null)
    {
    }

    [Token(Token = "0x600405D")]
    [Address(RVA = "0x2A25DFC", Offset = "0x2A25DFC", VA = "0x2A25DFC")]
    public void TransitionEvent()
    {
    }

    [Token(Token = "0x600405E")]
    [Address(RVA = "0x2A25E08", Offset = "0x2A25E08", VA = "0x2A25E08")]
    public void TransitionExpedition(APIExpeditionResponse response)
    {
    }

    [Token(Token = "0x600405F")]
    [Address(RVA = "0x2A25EA0", Offset = "0x2A25EA0", VA = "0x2A25EA0")]
    public void TransitionExpeditionBoss(APIExpeditionResponse response, int selectStage)
    {
    }

    [Token(Token = "0x6004060")]
    [Address(RVA = "0x2A25F6C", Offset = "0x2A25F6C", VA = "0x2A25F6C")]
    public void TransitionArmoury()
    {
    }

    [Token(Token = "0x6004061")]
    [Address(RVA = "0x2A25F78", Offset = "0x2A25F78", VA = "0x2A25F78")]
    public void TransitionPartyFormation()
    {
    }

    [Token(Token = "0x6004062")]
    [Address(RVA = "0x2A2601C", Offset = "0x2A2601C", VA = "0x2A2601C")]
    public void TransitionChangeCharacter()
    {
    }

    [Token(Token = "0x6004063")]
    [Address(RVA = "0x2A26080", Offset = "0x2A26080", VA = "0x2A26080")]
    public void TransitionGacha(int firstViewId = 0)
    {
    }

    [Token(Token = "0x6004064")]
    [Address(RVA = "0x2A26128", Offset = "0x2A26128", VA = "0x2A26128")]
    public void TransitionShop()
    {
    }

    [Token(Token = "0x6004065")]
    [Address(RVA = "0x2A26230", Offset = "0x2A26230", VA = "0x2A26230")]
    public void TransitionStoryShop()
    {
    }

    [Token(Token = "0x6004066")]
    [Address(RVA = "0x2A26A84", Offset = "0x2A26A84", VA = "0x2A26A84")]
    public void TransitionPlayerInfo()
    {
    }

    [Token(Token = "0x6004067")]
    [Address(RVA = "0x2A26B80", Offset = "0x2A26B80", VA = "0x2A26B80")]
    public void TransitionOption()
    {
    }

    [Token(Token = "0x6004068")]
    [Address(RVA = "0x2A26C5C", Offset = "0x2A26C5C", VA = "0x2A26C5C")]
    public void TransitionEventQuest(int firstViewId)
    {
    }

    [Token(Token = "0x6004069")]
    [Address(RVA = "0x2A26C68", Offset = "0x2A26C68", VA = "0x2A26C68")]
    public void RequestTransitionEventQuest(int firstViewId)
    {
    }

    [Token(Token = "0x600406A")]
    [Address(RVA = "0x2A26C74", Offset = "0x2A26C74", VA = "0x2A26C74")]
    public void TransitionScenarioEventQuest(int firstViewId)
    {
    }

    [Token(Token = "0x600406B")]
    [Address(RVA = "0x2A26CD8", Offset = "0x2A26CD8", VA = "0x2A26CD8")]
    public void RequestTransitionScenarioEventQuest(int firstViewId)
    {
    }

    [Token(Token = "0x600406C")]
    [Address(RVA = "0x2A26CDC", Offset = "0x2A26CDC", VA = "0x2A26CDC")]
    public void TransitionNews(int firstViewId)
    {
    }

    [Token(Token = "0x600406D")]
    [Address(RVA = "0x2A26D68", Offset = "0x2A26D68", VA = "0x2A26D68")]
    public void OpenExternalLink(string linkURL)
    {
    }

    [Token(Token = "0x600406E")]
    [Address(RVA = "0x2A26D78", Offset = "0x2A26D78", VA = "0x2A26D78")]
    public void OpenPaidShop(int shopId)
    {
    }

    [Token(Token = "0x600406F")]
    [Address(RVA = "0x2A26E04", Offset = "0x2A26E04", VA = "0x2A26E04")]
    public void TransitionGuild()
    {
    }

    [Token(Token = "0x6004070")]
    [Address(RVA = "0x2A211F4", Offset = "0x2A211F4", VA = "0x2A211F4")]
    public void TryBackOrQuest(QuestTypeEnum questType, int questId, bool isChangeToPrepare = false)
    {
    }

    [Token(Token = "0x6004071")]
    [Address(RVA = "0x2A27078", Offset = "0x2A27078", VA = "0x2A27078")]
    private void TransitionQuestScene(QuestTypeEnum questType, int questId)
    {
    }

    [Token(Token = "0x6004072")]
    [Address(RVA = "0x2A2732C", Offset = "0x2A2732C", VA = "0x2A2732C")]
    public void TransitionStyleRanking()
    {
    }

    [Token(Token = "0x6004073")]
    [Address(RVA = "0x2A27338", Offset = "0x2A27338", VA = "0x2A27338")]
    public void TransitionAreaQuest(int firstViewId)
    {
    }

    [Token(Token = "0x6004074")]
    [Address(RVA = "0x2A2739C", Offset = "0x2A2739C", VA = "0x2A2739C")]
    public void RequestTransitionAreaQuest(int firstViewId)
    {
    }

    [Token(Token = "0x6004075")]
    [Address(RVA = "0x2A20E5C", Offset = "0x2A20E5C", VA = "0x2A20E5C")]
    public HomeTransitionContoller()
    {
    }

    [Token(Token = "0x2000B4C")]
    private struct SceneTransitionData
    {
      [Token(Token = "0x17000966")]
      public readonly string SceneAssetName
      {
        [Token(Token = "0x6004076"), Address(RVA = "0x2A273B4", Offset = "0x2A273B4", VA = "0x2A273B4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000967")]
      public readonly string SubSceneAssetBundleName
      {
        [Token(Token = "0x6004077"), Address(RVA = "0x2A273BC", Offset = "0x2A273BC", VA = "0x2A273BC")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000968")]
      public readonly string SubSceneAssetName
      {
        [Token(Token = "0x6004078"), Address(RVA = "0x2A273C4", Offset = "0x2A273C4", VA = "0x2A273C4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6004079")]
      [Address(RVA = "0x2A273A8", Offset = "0x2A273A8", VA = "0x2A273A8")]
      public SceneTransitionData(
        string sceneAssetName,
        string subSceneAssetBundleName,
        string subSceneAssetName)
      {
      }
    }

    [Token(Token = "0x2000B4D")]
    private struct SubSceneTransitionData
    {
      [Token(Token = "0x17000969")]
      public readonly string AssetBundleName
      {
        [Token(Token = "0x600407A"), Address(RVA = "0x2A273CC", Offset = "0x2A273CC", VA = "0x2A273CC")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700096A")]
      public readonly string AssetName
      {
        [Token(Token = "0x600407B"), Address(RVA = "0x2A273D4", Offset = "0x2A273D4", VA = "0x2A273D4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600407C")]
      [Address(RVA = "0x2A273A0", Offset = "0x2A273A0", VA = "0x2A273A0")]
      public SubSceneTransitionData(string assetBundleName, string assetName)
      {
      }
    }
  }
}
