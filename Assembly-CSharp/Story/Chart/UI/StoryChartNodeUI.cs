// Decompiled with JetBrains decompiler
// Type: Story.Chart.UI.StoryChartNodeUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UI;
using UnityEngine;

#nullable disable
namespace Story.Chart.UI
{
  [Token(Token = "0x20006FB")]
  public class StoryChartNodeUI : MonoBehaviour
  {
    [Token(Token = "0x40020C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Canvas[] canvases;
    [Token(Token = "0x40020C7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Canvas nodeCanvas;
    [Token(Token = "0x40020C8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Canvas freeactionCanvas;
    [Token(Token = "0x40020C9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Canvas lineCanvas;
    [Token(Token = "0x40020CA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup tweengroup;
    [Token(Token = "0x40020CB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject inactiveTxt;
    [Token(Token = "0x40020CC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextAccessor initial;
    [Token(Token = "0x40020CD")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextAccessor header;
    [Token(Token = "0x40020CE")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x40020CF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject cursol;
    [Token(Token = "0x40020D0")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject passed;
    [Token(Token = "0x40020D1")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject battle;
    [Token(Token = "0x40020D2")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject areaevent;
    [Token(Token = "0x40020D3")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject adv;
    [Token(Token = "0x40020D4")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject inactive;
    [Token(Token = "0x40020D5")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private StoryChartFreeActionPointUI freeactionPoint;
    [Token(Token = "0x40020D6")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private StoryChartLineUI[] lineUIs;
    [Token(Token = "0x40020D7")]
    [FieldOffset(Offset = "0xA0")]
    private ObjectPool<StoryChartLineUI> linePool;
    [Token(Token = "0x40020D8")]
    [FieldOffset(Offset = "0xA8")]
    private List<StoryChartLineUI> showLines;
    [Token(Token = "0x40020D9")]
    [FieldOffset(Offset = "0xB0")]
    public Action OnClickEventNode;
    [Token(Token = "0x40020DA")]
    [FieldOffset(Offset = "0xB8")]
    private StoryChartNodeUI.State current;

    [Token(Token = "0x170005E3")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6002788"), Address(RVA = "0x366F7FC", Offset = "0x366F7FC", VA = "0x366F7FC")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6002789")]
    [Address(RVA = "0x366F85C", Offset = "0x366F85C", VA = "0x366F85C")]
    public void Show(bool active)
    {
    }

    [Token(Token = "0x600278A")]
    [Address(RVA = "0x366F8C4", Offset = "0x366F8C4", VA = "0x366F8C4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600278B")]
    [Address(RVA = "0x366F9E8", Offset = "0x366F9E8", VA = "0x366F9E8")]
    public void ChangeLineHierarchy(Transform root)
    {
    }

    [Token(Token = "0x600278C")]
    [Address(RVA = "0x366FA1C", Offset = "0x366FA1C", VA = "0x366FA1C")]
    public void OnShowItemUpdate()
    {
    }

    [Token(Token = "0x600278D")]
    [Address(RVA = "0x366FAA4", Offset = "0x366FAA4", VA = "0x366FAA4")]
    public StoryChartLineUI SetLine(Vector2 from, Vector2 to) => (StoryChartLineUI) null;

    [Token(Token = "0x600278E")]
    [Address(RVA = "0x366FC70", Offset = "0x366FC70", VA = "0x366FC70")]
    public void HideLine()
    {
    }

    [Token(Token = "0x600278F")]
    [Address(RVA = "0x366FE40", Offset = "0x366FE40", VA = "0x366FE40")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x6002790")]
    [Address(RVA = "0x366FE5C", Offset = "0x366FE5C", VA = "0x366FE5C")]
    public void SetHeader(string header)
    {
    }

    [Token(Token = "0x6002791")]
    [Address(RVA = "0x366FED8", Offset = "0x366FED8", VA = "0x366FED8")]
    private void ChangeState(StoryChartNodeUI.State state)
    {
    }

    [Token(Token = "0x6002792")]
    [Address(RVA = "0x366FF48", Offset = "0x366FF48", VA = "0x366FF48")]
    public void ChangeStateInactive(bool locked)
    {
    }

    [Token(Token = "0x6002793")]
    [Address(RVA = "0x366FFEC", Offset = "0x366FFEC", VA = "0x366FFEC")]
    public void ChangeStateBattle(bool cursol, bool passed)
    {
    }

    [Token(Token = "0x6002794")]
    [Address(RVA = "0x3670128", Offset = "0x3670128", VA = "0x3670128")]
    public void ChangeStateAreaEvent(bool cursol, bool passed)
    {
    }

    [Token(Token = "0x6002795")]
    [Address(RVA = "0x36701D8", Offset = "0x36701D8", VA = "0x36701D8")]
    public void ChangeStateAdv(bool cursol, bool passed)
    {
    }

    [Token(Token = "0x6002796")]
    [Address(RVA = "0x3670288", Offset = "0x3670288", VA = "0x3670288")]
    public void ChangeStateFreeActionDay(bool cursol, bool passed)
    {
    }

    [Token(Token = "0x6002797")]
    [Address(RVA = "0x36703C4", Offset = "0x36703C4", VA = "0x36703C4")]
    public void ChangeStateFreeActionNight(bool cursol, bool passed)
    {
    }

    [Token(Token = "0x6002798")]
    [Address(RVA = "0x3670474", Offset = "0x3670474", VA = "0x3670474")]
    public void OnClickNode()
    {
    }

    [Token(Token = "0x6002799")]
    [Address(RVA = "0x3670490", Offset = "0x3670490", VA = "0x3670490")]
    public StoryChartNodeUI()
    {
    }

    [Token(Token = "0x20006FC")]
    private class LinePoolHandler : ObjectPool<StoryChartLineUI>.IHandler
    {
      [Token(Token = "0x600279A")]
      [Address(RVA = "0x3670538", Offset = "0x3670538", VA = "0x3670538", Slot = "4")]
      private void Story\u002EChart\u002EObjectPool\u003CStory\u002EChart\u002EUI\u002EStoryChartLineUI\u003E\u002EIHandler\u002EActivate(
        StoryChartLineUI instance)
      {
      }

      [Token(Token = "0x600279B")]
      [Address(RVA = "0x367053C", Offset = "0x367053C", VA = "0x367053C", Slot = "5")]
      private void Story\u002EChart\u002EObjectPool\u003CStory\u002EChart\u002EUI\u002EStoryChartLineUI\u003E\u002EIHandler\u002EDeactivate(
        StoryChartLineUI instance)
      {
      }

      [Token(Token = "0x600279C")]
      [Address(RVA = "0x366F9E0", Offset = "0x366F9E0", VA = "0x366F9E0")]
      public LinePoolHandler()
      {
      }
    }

    [Token(Token = "0x20006FD")]
    private static class Tween
    {
      [Token(Token = "0x600279D")]
      [Address(RVA = "0x3670540", Offset = "0x3670540", VA = "0x3670540")]
      public static void Passed(UITweenGroup tweenAnimation)
      {
      }

      [Token(Token = "0x600279E")]
      [Address(RVA = "0x3670598", Offset = "0x3670598", VA = "0x3670598")]
      public static void Normal(UITweenGroup tweenAnimation)
      {
      }

      [Token(Token = "0x600279F")]
      [Address(RVA = "0x36705F0", Offset = "0x36705F0", VA = "0x36705F0")]
      public static void Inactive(UITweenGroup tweenAnimation)
      {
      }

      [Token(Token = "0x60027A0")]
      [Address(RVA = "0x3670648", Offset = "0x3670648", VA = "0x3670648")]
      public static void Cursor(UITweenGroup tweenAnimation)
      {
      }

      [Token(Token = "0x60027A1")]
      [Address(RVA = "0x36706A0", Offset = "0x36706A0", VA = "0x36706A0")]
      public static void Story(UITweenGroup tweenAnimation, bool highlight)
      {
      }

      [Token(Token = "0x60027A2")]
      [Address(RVA = "0x3670718", Offset = "0x3670718", VA = "0x3670718")]
      public static void Battle(UITweenGroup tweenAnimation, bool highlight)
      {
      }

      [Token(Token = "0x60027A3")]
      [Address(RVA = "0x3670790", Offset = "0x3670790", VA = "0x3670790")]
      public static void Area(UITweenGroup tweenAnimation, bool highlight)
      {
      }
    }

    [Token(Token = "0x20006FE")]
    public abstract class SubState
    {
      [Token(Token = "0x170005E4")]
      public bool Cursol
      {
        [Token(Token = "0x60027A4"), Address(RVA = "0x3670808", Offset = "0x3670808", VA = "0x3670808")] get
        {
          return new bool();
        }
        [Token(Token = "0x60027A5"), Address(RVA = "0x3670810", Offset = "0x3670810", VA = "0x3670810")] set
        {
        }
      }

      [Token(Token = "0x60027A6")]
      public abstract void OnShow(StoryChartNodeUI entity);

      [Token(Token = "0x60027A7")]
      [Address(RVA = "0x367081C", Offset = "0x367081C", VA = "0x367081C")]
      protected SubState()
      {
      }

      [Token(Token = "0x20006FF")]
      public interface IHighlight
      {
      }

      [Token(Token = "0x2000700")]
      public interface IPassed
      {
      }
    }

    [Token(Token = "0x2000701")]
    public class NodeSubStatePassed : StoryChartNodeUI.SubState, StoryChartNodeUI.SubState.IPassed
    {
      [Token(Token = "0x60027A8")]
      [Address(RVA = "0x3670824", Offset = "0x3670824", VA = "0x3670824", Slot = "4")]
      public override void OnShow(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027A9")]
      [Address(RVA = "0x3670880", Offset = "0x3670880", VA = "0x3670880")]
      public NodeSubStatePassed()
      {
      }
    }

    [Token(Token = "0x2000702")]
    public class NodeSubStateNormal : StoryChartNodeUI.SubState, StoryChartNodeUI.SubState.IHighlight
    {
      [Token(Token = "0x60027AA")]
      [Address(RVA = "0x3670888", Offset = "0x3670888", VA = "0x3670888", Slot = "4")]
      public override void OnShow(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027AB")]
      [Address(RVA = "0x36708E4", Offset = "0x36708E4", VA = "0x36708E4")]
      public NodeSubStateNormal()
      {
      }
    }

    [Token(Token = "0x2000703")]
    public class FreeActionSubStateNormal : 
      StoryChartNodeUI.SubState,
      StoryChartNodeUI.SubState.IHighlight
    {
      [Token(Token = "0x60027AC")]
      [Address(RVA = "0x36708EC", Offset = "0x36708EC", VA = "0x36708EC", Slot = "4")]
      public override void OnShow(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027AD")]
      [Address(RVA = "0x3670940", Offset = "0x3670940", VA = "0x3670940")]
      public FreeActionSubStateNormal()
      {
      }
    }

    [Token(Token = "0x2000704")]
    public class FreeActionSubStatePassed : 
      StoryChartNodeUI.SubState,
      StoryChartNodeUI.SubState.IPassed
    {
      [Token(Token = "0x60027AE")]
      [Address(RVA = "0x3670948", Offset = "0x3670948", VA = "0x3670948", Slot = "4")]
      public override void OnShow(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027AF")]
      [Address(RVA = "0x367099C", Offset = "0x367099C", VA = "0x367099C")]
      public FreeActionSubStatePassed()
      {
      }
    }

    [Token(Token = "0x2000705")]
    public abstract class State
    {
      [Token(Token = "0x40020DE")]
      [FieldOffset(Offset = "0x20")]
      protected StoryChartNodeUI entity;

      [Token(Token = "0x170005E5")]
      public StoryChartNodeUI.SubState SubState
      {
        [Token(Token = "0x60027B0"), Address(RVA = "0x36709A4", Offset = "0x36709A4", VA = "0x36709A4")] get
        {
          return (StoryChartNodeUI.SubState) null;
        }
        [Token(Token = "0x60027B1"), Address(RVA = "0x36709AC", Offset = "0x36709AC", VA = "0x36709AC")] set
        {
        }
      }

      [Token(Token = "0x170005E6")]
      public bool Locked
      {
        [Token(Token = "0x60027B2"), Address(RVA = "0x36709B4", Offset = "0x36709B4", VA = "0x36709B4")] get
        {
          return new bool();
        }
        [Token(Token = "0x60027B3"), Address(RVA = "0x36709BC", Offset = "0x36709BC", VA = "0x36709BC")] set
        {
        }
      }

      [Token(Token = "0x170005E7")]
      public bool Highlight
      {
        [Token(Token = "0x60027B4"), Address(RVA = "0x36709C8", Offset = "0x36709C8", VA = "0x36709C8")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x170005E8")]
      public bool Passed
      {
        [Token(Token = "0x60027B5"), Address(RVA = "0x3670A1C", Offset = "0x3670A1C", VA = "0x3670A1C")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x60027B6")]
      [Address(RVA = "0x3670A70", Offset = "0x3670A70", VA = "0x3670A70")]
      public State(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027B7")]
      public abstract void Enter();

      [Token(Token = "0x60027B8")]
      public abstract void Exit();

      [Token(Token = "0x60027B9")]
      [Address(RVA = "0x3670A98", Offset = "0x3670A98", VA = "0x3670A98")]
      protected void NodeTitle(bool active)
      {
      }

      [Token(Token = "0x60027BA")]
      [Address(RVA = "0x3670B24", Offset = "0x3670B24", VA = "0x3670B24")]
      protected void ToggleOnNodeCanvas()
      {
      }

      [Token(Token = "0x60027BB")]
      [Address(RVA = "0x3670B6C", Offset = "0x3670B6C", VA = "0x3670B6C")]
      protected void ToggleOnFreeActionCanvas()
      {
      }
    }

    [Token(Token = "0x2000706")]
    public abstract class StateNode : StoryChartNodeUI.State
    {
      [Token(Token = "0x60027BC")]
      [Address(RVA = "0x3670BB4", Offset = "0x3670BB4", VA = "0x3670BB4")]
      public StateNode(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027BD")]
      [Address(RVA = "0x367009C", Offset = "0x367009C", VA = "0x367009C")]
      public static StoryChartNodeUI.SubState CreateSubState(bool cursol, bool passed)
      {
        return (StoryChartNodeUI.SubState) null;
      }
    }

    [Token(Token = "0x2000707")]
    public class StateBattle : StoryChartNodeUI.StateNode
    {
      [Token(Token = "0x60027BE")]
      [Address(RVA = "0x3670074", Offset = "0x3670074", VA = "0x3670074")]
      public StateBattle(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027BF")]
      [Address(RVA = "0x3670BDC", Offset = "0x3670BDC", VA = "0x3670BDC", Slot = "4")]
      public override void Enter()
      {
      }

      [Token(Token = "0x60027C0")]
      [Address(RVA = "0x3670C98", Offset = "0x3670C98", VA = "0x3670C98", Slot = "5")]
      public override void Exit()
      {
      }
    }

    [Token(Token = "0x2000708")]
    public class StateAdv : StoryChartNodeUI.StateNode
    {
      [Token(Token = "0x60027C1")]
      [Address(RVA = "0x3670260", Offset = "0x3670260", VA = "0x3670260")]
      public StateAdv(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027C2")]
      [Address(RVA = "0x3670CF8", Offset = "0x3670CF8", VA = "0x3670CF8", Slot = "4")]
      public override void Enter()
      {
      }

      [Token(Token = "0x60027C3")]
      [Address(RVA = "0x3670DB4", Offset = "0x3670DB4", VA = "0x3670DB4", Slot = "5")]
      public override void Exit()
      {
      }
    }

    [Token(Token = "0x2000709")]
    public class StateAreaEvent : StoryChartNodeUI.StateNode
    {
      [Token(Token = "0x60027C4")]
      [Address(RVA = "0x36701B0", Offset = "0x36701B0", VA = "0x36701B0")]
      public StateAreaEvent(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027C5")]
      [Address(RVA = "0x3670E14", Offset = "0x3670E14", VA = "0x3670E14", Slot = "4")]
      public override void Enter()
      {
      }

      [Token(Token = "0x60027C6")]
      [Address(RVA = "0x3670ED0", Offset = "0x3670ED0", VA = "0x3670ED0", Slot = "5")]
      public override void Exit()
      {
      }
    }

    [Token(Token = "0x200070A")]
    public abstract class StateFreeAction : StoryChartNodeUI.State
    {
      [Token(Token = "0x60027C7")]
      [Address(RVA = "0x3670F30", Offset = "0x3670F30", VA = "0x3670F30")]
      public StateFreeAction(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027C8")]
      [Address(RVA = "0x3670F58", Offset = "0x3670F58", VA = "0x3670F58", Slot = "4")]
      public override void Enter()
      {
      }

      [Token(Token = "0x60027C9")]
      [Address(RVA = "0x3670F5C", Offset = "0x3670F5C", VA = "0x3670F5C", Slot = "5")]
      public override void Exit()
      {
      }

      [Token(Token = "0x60027CA")]
      [Address(RVA = "0x3670338", Offset = "0x3670338", VA = "0x3670338")]
      public static StoryChartNodeUI.SubState CreateSubState(bool cursol, bool passed)
      {
        return (StoryChartNodeUI.SubState) null;
      }
    }

    [Token(Token = "0x200070B")]
    public class StateFreeActionDaytime : StoryChartNodeUI.StateFreeAction
    {
      [Token(Token = "0x60027CB")]
      [Address(RVA = "0x3670310", Offset = "0x3670310", VA = "0x3670310")]
      public StateFreeActionDaytime(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027CC")]
      [Address(RVA = "0x3670F7C", Offset = "0x3670F7C", VA = "0x3670F7C", Slot = "4")]
      public override void Enter()
      {
      }

      [Token(Token = "0x60027CD")]
      [Address(RVA = "0x3670FA4", Offset = "0x3670FA4", VA = "0x3670FA4", Slot = "5")]
      public override void Exit()
      {
      }
    }

    [Token(Token = "0x200070C")]
    public class StateFreeActionNight : StoryChartNodeUI.StateFreeAction
    {
      [Token(Token = "0x60027CE")]
      [Address(RVA = "0x367044C", Offset = "0x367044C", VA = "0x367044C")]
      public StateFreeActionNight(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027CF")]
      [Address(RVA = "0x3670FA8", Offset = "0x3670FA8", VA = "0x3670FA8", Slot = "4")]
      public override void Enter()
      {
      }

      [Token(Token = "0x60027D0")]
      [Address(RVA = "0x3670FD0", Offset = "0x3670FD0", VA = "0x3670FD0", Slot = "5")]
      public override void Exit()
      {
      }
    }

    [Token(Token = "0x200070D")]
    public class StateInactive : StoryChartNodeUI.StateNode
    {
      [Token(Token = "0x60027D1")]
      [Address(RVA = "0x366FFC4", Offset = "0x366FFC4", VA = "0x366FFC4")]
      public StateInactive(StoryChartNodeUI entity)
      {
      }

      [Token(Token = "0x60027D2")]
      [Address(RVA = "0x3670FD4", Offset = "0x3670FD4", VA = "0x3670FD4", Slot = "4")]
      public override void Enter()
      {
      }

      [Token(Token = "0x60027D3")]
      [Address(RVA = "0x367102C", Offset = "0x367102C", VA = "0x367102C", Slot = "5")]
      public override void Exit()
      {
      }
    }
  }
}
