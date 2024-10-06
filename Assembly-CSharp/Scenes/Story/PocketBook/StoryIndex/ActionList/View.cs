// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ActionList.View
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.Parameter.UIParam.SubQuest;
using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.ActionList.UI;
using System;
using System.Collections.Generic;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ActionList
{
  [Token(Token = "0x2002E40")]
  public class View
  {
    [Token(Token = "0x400C674")]
    [FieldOffset(Offset = "0x30")]
    private InstanceHandler<ActionListElement> facilityInstanceHandler;
    [Token(Token = "0x400C675")]
    [FieldOffset(Offset = "0x38")]
    private InstanceHandler<ActionListElement> communicationInstanceHandler;
    [Token(Token = "0x400C676")]
    [FieldOffset(Offset = "0x40")]
    private InstanceHandler<ActionListElement> subquestInstanceHandler;
    [Token(Token = "0x400C677")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<FreeMapUIParamBase, Action<bool>> showHideCallbacks;

    [Token(Token = "0x17003D80")]
    public ActionListUI UI
    {
      [Token(Token = "0x6012155"), Address(RVA = "0x43840D8", Offset = "0x43840D8", VA = "0x43840D8")] get
      {
        return (ActionListUI) null;
      }
      [Token(Token = "0x6012156"), Address(RVA = "0x43840E0", Offset = "0x43840E0", VA = "0x43840E0")] set
      {
      }
    }

    [Token(Token = "0x17003D81")]
    public SpriteAtlas IconAtlas
    {
      [Token(Token = "0x6012157"), Address(RVA = "0x43840E8", Offset = "0x43840E8", VA = "0x43840E8")] get
      {
        return (SpriteAtlas) null;
      }
      [Token(Token = "0x6012158"), Address(RVA = "0x43840F0", Offset = "0x43840F0", VA = "0x43840F0")] set
      {
      }
    }

    [Token(Token = "0x17003D82")]
    public SpriteAtlas CharaIconAtlas
    {
      [Token(Token = "0x6012159"), Address(RVA = "0x43840F8", Offset = "0x43840F8", VA = "0x43840F8")] get
      {
        return (SpriteAtlas) null;
      }
      [Token(Token = "0x601215A"), Address(RVA = "0x4384100", Offset = "0x4384100", VA = "0x4384100")] set
      {
      }
    }

    [Token(Token = "0x1400017F")]
    public event Action<FreeMapUIParamBase> OnClickIcon
    {
      [Token(Token = "0x601215B"), Address(RVA = "0x4382618", Offset = "0x4382618", VA = "0x4382618")] add
      {
      }
      [Token(Token = "0x601215C"), Address(RVA = "0x4384108", Offset = "0x4384108", VA = "0x4384108")] remove
      {
      }
    }

    [Token(Token = "0x601215D")]
    [Address(RVA = "0x43841B8", Offset = "0x43841B8", VA = "0x43841B8")]
    public void Show(Presenter.IsShow isShow)
    {
    }

    [Token(Token = "0x601215E")]
    [Address(RVA = "0x43828F4", Offset = "0x43828F4", VA = "0x43828F4")]
    public void SetupInstances(IEnumerable<FreeMapFacilityEventUIParam> uiParams)
    {
    }

    [Token(Token = "0x601215F")]
    [Address(RVA = "0x4382CFC", Offset = "0x4382CFC", VA = "0x4382CFC")]
    public void SetupInstances(
      IEnumerable<FreeMapCommunicationEventUIParam> uiParams)
    {
    }

    [Token(Token = "0x6012160")]
    [Address(RVA = "0x4383104", Offset = "0x4383104", VA = "0x4383104")]
    public void SetupInstances(IEnumerable<FreeMapSubQuestEventUIParam> uiParams)
    {
    }

    [Token(Token = "0x6012161")]
    [Address(RVA = "0x4384370", Offset = "0x4384370", VA = "0x4384370")]
    private void SetupInstance(ActionListElement instance, FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6012162")]
    [Address(RVA = "0x43844DC", Offset = "0x43844DC", VA = "0x43844DC")]
    public void Release()
    {
    }

    [Token(Token = "0x6012163")]
    [Address(RVA = "0x4384570", Offset = "0x4384570", VA = "0x4384570")]
    public View()
    {
    }

    [Token(Token = "0x2002E41")]
    private sealed class Handler<TParam> where TParam : FreeMapUIParamBase
    {
      [Token(Token = "0x400C678")]
      [FieldOffset(Offset = "0x0")]
      private ActionListElement instance;
      [Token(Token = "0x400C679")]
      [FieldOffset(Offset = "0x0")]
      private View view;
      [Token(Token = "0x400C67A")]
      [FieldOffset(Offset = "0x0")]
      private TParam param;
      [Token(Token = "0x400C67B")]
      [FieldOffset(Offset = "0x0")]
      private View.Handler<TParam>.IBuilder builder;

      [Token(Token = "0x6012164")]
      public Handler(View view, TParam param, View.Handler<TParam>.IBuilder builder)
      {
      }

      [Token(Token = "0x6012165")]
      public void Show(bool show)
      {
      }

      [Token(Token = "0x2002E42")]
      public interface IBuilder
      {
        [Token(Token = "0x6012166")]
        ActionListElement CreateInstance(View view, TParam param);
      }
    }

    [Token(Token = "0x2002E43")]
    private class FacilityBuilder : View.Handler<FreeMapFacilityEventUIParam>.IBuilder
    {
      [Token(Token = "0x6012167")]
      [Address(RVA = "0x4384670", Offset = "0x4384670", VA = "0x4384670", Slot = "4")]
      private ActionListElement Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EActionList\u002EView\u002EHandler\u003CFreeMap\u002EParameter\u002EUIParam\u002EFreeMapFacilityEventUIParam\u003E\u002EIBuilder\u002ECreateInstance(
        View view,
        FreeMapFacilityEventUIParam param)
      {
        return (ActionListElement) null;
      }

      [Token(Token = "0x6012168")]
      [Address(RVA = "0x4384358", Offset = "0x4384358", VA = "0x4384358")]
      public FacilityBuilder()
      {
      }
    }

    [Token(Token = "0x2002E44")]
    private class CommunicationBuilder : View.Handler<FreeMapCommunicationEventUIParam>.IBuilder
    {
      [Token(Token = "0x6012169")]
      [Address(RVA = "0x43848A8", Offset = "0x43848A8", VA = "0x43848A8", Slot = "4")]
      private ActionListElement Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EActionList\u002EView\u002EHandler\u003CFreeMap\u002EParameter\u002EUIParam\u002EFreeMapCommunicationEventUIParam\u003E\u002EIBuilder\u002ECreateInstance(
        View view,
        FreeMapCommunicationEventUIParam param)
      {
        return (ActionListElement) null;
      }

      [Token(Token = "0x601216A")]
      [Address(RVA = "0x4384360", Offset = "0x4384360", VA = "0x4384360")]
      public CommunicationBuilder()
      {
      }
    }

    [Token(Token = "0x2002E45")]
    private class SubQuestBuilder : View.Handler<FreeMapSubQuestEventUIParam>.IBuilder
    {
      [Token(Token = "0x601216B")]
      [Address(RVA = "0x43849AC", Offset = "0x43849AC", VA = "0x43849AC", Slot = "4")]
      private ActionListElement Scenes\u002EStory\u002EPocketBook\u002EStoryIndex\u002EActionList\u002EView\u002EHandler\u003CFreeMap\u002EParameter\u002EUIParam\u002ESubQuest\u002EFreeMapSubQuestEventUIParam\u003E\u002EIBuilder\u002ECreateInstance(
        View view,
        FreeMapSubQuestEventUIParam param)
      {
        return (ActionListElement) null;
      }

      [Token(Token = "0x601216C")]
      [Address(RVA = "0x4384368", Offset = "0x4384368", VA = "0x4384368")]
      public SubQuestBuilder()
      {
      }
    }
  }
}
