// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EventQuest.EventQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.QuestSelect;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EventQuest
{
  [Token(Token = "0x2003664")]
  public class EventQuest : MonoBehaviour
  {
    [Token(Token = "0x400ECA3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400ECA4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform questTypeGroup;
    [Token(Token = "0x400ECA5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ChapterButtonList chapterButtonList;
    [Token(Token = "0x400ECA6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RouteButtonList routeButtonList;
    [Token(Token = "0x400ECA7")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private DifficultyButtonList difficultyButtonList;
    [Token(Token = "0x400ECA8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private QuestSelectList questSelectList;
    [Token(Token = "0x400ECAA")]
    [FieldOffset(Offset = "0x50")]
    private Scenes.OutGame.EventQuest.EventQuest.ViewType viewType;
    [Token(Token = "0x400ECAB")]
    [FieldOffset(Offset = "0x54")]
    private int routeId;
    [Token(Token = "0x400ECAC")]
    [FieldOffset(Offset = "0x58")]
    private GameObject questListItem;

    [Token(Token = "0x17004722")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6015697"), Address(RVA = "0x18DD688", Offset = "0x18DD688", VA = "0x18DD688")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17004723")]
    public Action<int, bool> OnLoadMapAction
    {
      [Token(Token = "0x6015698"), Address(RVA = "0x18DD690", Offset = "0x18DD690", VA = "0x18DD690")] get
      {
        return (Action<int, bool>) null;
      }
      [Token(Token = "0x6015699"), Address(RVA = "0x18DD698", Offset = "0x18DD698", VA = "0x18DD698")] set
      {
      }
    }

    [Token(Token = "0x17004724")]
    public Scenes.OutGame.EventQuest.EventQuest.ViewType NowViewType
    {
      [Token(Token = "0x601569A"), Address(RVA = "0x18DD6A0", Offset = "0x18DD6A0", VA = "0x18DD6A0")] get
      {
        return new Scenes.OutGame.EventQuest.EventQuest.ViewType();
      }
    }

    [Token(Token = "0x17004725")]
    public Action ResetMapObjectAction
    {
      [Token(Token = "0x601569B"), Address(RVA = "0x18DD6A8", Offset = "0x18DD6A8", VA = "0x18DD6A8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601569C"), Address(RVA = "0x18DD6B0", Offset = "0x18DD6B0", VA = "0x18DD6B0")] set
      {
      }
    }

    [Token(Token = "0x17004726")]
    public Action<int> OnClickToQuestDetail
    {
      [Token(Token = "0x601569D"), Address(RVA = "0x18DD6B8", Offset = "0x18DD6B8", VA = "0x18DD6B8")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x601569E"), Address(RVA = "0x18DD6C0", Offset = "0x18DD6C0", VA = "0x18DD6C0")] set
      {
      }
    }

    [Token(Token = "0x17004727")]
    public Action<int> OnClickToQuestList
    {
      [Token(Token = "0x601569F"), Address(RVA = "0x18DD6C8", Offset = "0x18DD6C8", VA = "0x18DD6C8")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x60156A0"), Address(RVA = "0x18DD6D0", Offset = "0x18DD6D0", VA = "0x18DD6D0")] set
      {
      }
    }

    [Token(Token = "0x17004728")]
    public Action<IList<QuestInfo>> OnSetupPositionAction
    {
      [Token(Token = "0x60156A1"), Address(RVA = "0x18DD6D8", Offset = "0x18DD6D8", VA = "0x18DD6D8")] get
      {
        return (Action<IList<QuestInfo>>) null;
      }
      [Token(Token = "0x60156A2"), Address(RVA = "0x18DD6E0", Offset = "0x18DD6E0", VA = "0x18DD6E0")] set
      {
      }
    }

    [Token(Token = "0x60156A3")]
    [Address(RVA = "0x18DB71C", Offset = "0x18DB71C", VA = "0x18DB71C")]
    public void InitializeByFreeQuest()
    {
    }

    [Token(Token = "0x60156A4")]
    [Address(RVA = "0x18DB724", Offset = "0x18DB724", VA = "0x18DB724")]
    public void SetQuestListItem(GameObject listItem)
    {
    }

    [Token(Token = "0x60156A5")]
    [Address(RVA = "0x18DD954", Offset = "0x18DD954", VA = "0x18DD954")]
    public void OnClickToFreeQuest()
    {
    }

    [Token(Token = "0x60156A6")]
    [Address(RVA = "0x18DDB6C", Offset = "0x18DDB6C", VA = "0x18DDB6C")]
    public void OnClickToChapter(StoryChapterData chapter)
    {
    }

    [Token(Token = "0x60156A7")]
    [Address(RVA = "0x18DE3A4", Offset = "0x18DE3A4", VA = "0x18DE3A4")]
    public void OnClickToRoute(StoryRouteData routeData)
    {
    }

    [Token(Token = "0x60156A8")]
    [Address(RVA = "0x18DE448", Offset = "0x18DE448", VA = "0x18DE448")]
    public void OnClickToDifficulty(int routeId, QuestDifficultyTypeEnum questDifficultyType)
    {
    }

    [Token(Token = "0x60156A9")]
    [Address(RVA = "0x18DE99C", Offset = "0x18DE99C", VA = "0x18DE99C")]
    public void OnClickToBack()
    {
    }

    [Token(Token = "0x60156AA")]
    [Address(RVA = "0x18DD6E8", Offset = "0x18DD6E8", VA = "0x18DD6E8")]
    private void ChangeView()
    {
    }

    [Token(Token = "0x60156AB")]
    [Address(RVA = "0x18DBFC0", Offset = "0x18DBFC0", VA = "0x18DBFC0")]
    public void DeactiveObject()
    {
    }

    [Token(Token = "0x60156AC")]
    [Address(RVA = "0x18DC178", Offset = "0x18DC178", VA = "0x18DC178")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60156AD")]
    [Address(RVA = "0x18DEA84", Offset = "0x18DEA84", VA = "0x18DEA84")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60156AE")]
    [Address(RVA = "0x18DEB28", Offset = "0x18DEB28", VA = "0x18DEB28")]
    public EventQuest()
    {
    }

    [Token(Token = "0x2003665")]
    public enum ViewType
    {
      [Token(Token = "0x400ECB2")] QuestType,
      [Token(Token = "0x400ECB3")] Chapter,
      [Token(Token = "0x400ECB4")] Route,
      [Token(Token = "0x400ECB5")] Difficulty,
      [Token(Token = "0x400ECB6")] QuestList,
    }
  }
}
