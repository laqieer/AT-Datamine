// Decompiled with JetBrains decompiler
// Type: Story.Chart.UI.StoryChartStraightLineUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.Chart.UI
{
  [Token(Token = "0x200070E")]
  public class StoryChartStraightLineUI : MonoBehaviour, ILine
  {
    [Token(Token = "0x40020DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform line;
    [Token(Token = "0x40020E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StoryChartLinePointUI point;
    [Token(Token = "0x40020E1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform locked;
    [Token(Token = "0x40020E2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Vector2 lockIconOffset;
    [Token(Token = "0x40020E3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private StoryChartStraightLineUI.ViewSet onNormal;
    [Token(Token = "0x40020E4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private StoryChartStraightLineUI.ViewSet onPassed;
    [Token(Token = "0x40020E5")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private StoryChartStraightLineUI.ViewSet onEffect;
    [Token(Token = "0x40020E7")]
    [FieldOffset(Offset = "0x58")]
    private StoryChartStraightLineUI.State current;

    [Token(Token = "0x170005E9")]
    public bool IsTail
    {
      [Token(Token = "0x60027D4"), Address(RVA = "0x3671060", Offset = "0x3671060", VA = "0x3671060")] get
      {
        return new bool();
      }
      [Token(Token = "0x60027D5"), Address(RVA = "0x3671068", Offset = "0x3671068", VA = "0x3671068")] set
      {
      }
    }

    [Token(Token = "0x60027D6")]
    [Address(RVA = "0x366ED34", Offset = "0x366ED34", VA = "0x366ED34", Slot = "4")]
    public void Set(Vector2 from, Vector2 to)
    {
    }

    [Token(Token = "0x60027D7")]
    [Address(RVA = "0x366F708", Offset = "0x366F708", VA = "0x366F708")]
    public void Rotate(float angle)
    {
    }

    [Token(Token = "0x60027D8")]
    [Address(RVA = "0x3671074", Offset = "0x3671074", VA = "0x3671074")]
    private void ChangeState(StoryChartStraightLineUI.State state)
    {
    }

    [Token(Token = "0x60027D9")]
    [Address(RVA = "0x366F518", Offset = "0x366F518", VA = "0x366F518", Slot = "5")]
    public void ChangeStateNormal()
    {
    }

    [Token(Token = "0x60027DA")]
    [Address(RVA = "0x366F59C", Offset = "0x366F59C", VA = "0x366F59C", Slot = "6")]
    public void ChangeStatePassed()
    {
    }

    [Token(Token = "0x60027DB")]
    [Address(RVA = "0x366F494", Offset = "0x366F494", VA = "0x366F494", Slot = "7")]
    public void ChangeStateEffect()
    {
    }

    [Token(Token = "0x60027DC")]
    [Address(RVA = "0x366F144", Offset = "0x366F144", VA = "0x366F144", Slot = "8")]
    public void Locked(bool locked)
    {
    }

    [Token(Token = "0x60027DD")]
    [Address(RVA = "0x367113C", Offset = "0x367113C", VA = "0x367113C")]
    public StoryChartStraightLineUI()
    {
    }

    [Token(Token = "0x200070F")]
    [Serializable]
    public class ViewSet
    {
      [Token(Token = "0x40020E8")]
      [FieldOffset(Offset = "0x10")]
      public GameObject[] Line;
      [Token(Token = "0x40020E9")]
      [FieldOffset(Offset = "0x18")]
      public GameObject[] Point;

      [Token(Token = "0x60027DE")]
      [Address(RVA = "0x3671144", Offset = "0x3671144", VA = "0x3671144")]
      public void Activate(bool active)
      {
      }

      [Token(Token = "0x60027DF")]
      [Address(RVA = "0x36712A0", Offset = "0x36712A0", VA = "0x36712A0")]
      public ViewSet()
      {
      }
    }

    [Token(Token = "0x2000710")]
    public abstract class State
    {
      [Token(Token = "0x40020EA")]
      [FieldOffset(Offset = "0x10")]
      protected StoryChartStraightLineUI entity;

      [Token(Token = "0x60027E0")]
      [Address(RVA = "0x36712A8", Offset = "0x36712A8", VA = "0x36712A8")]
      public State(StoryChartStraightLineUI entity)
      {
      }

      [Token(Token = "0x60027E1")]
      public abstract void Enter();

      [Token(Token = "0x60027E2")]
      public abstract void Exit();
    }

    [Token(Token = "0x2000711")]
    public class StateNormal : StoryChartStraightLineUI.State
    {
      [Token(Token = "0x60027E3")]
      [Address(RVA = "0x36710C4", Offset = "0x36710C4", VA = "0x36710C4")]
      public StateNormal(StoryChartStraightLineUI entity)
      {
      }

      [Token(Token = "0x60027E4")]
      [Address(RVA = "0x36712D0", Offset = "0x36712D0", VA = "0x36712D0", Slot = "4")]
      public override void Enter()
      {
      }

      [Token(Token = "0x60027E5")]
      [Address(RVA = "0x36712F4", Offset = "0x36712F4", VA = "0x36712F4", Slot = "5")]
      public override void Exit()
      {
      }
    }

    [Token(Token = "0x2000712")]
    public class StatePassed : StoryChartStraightLineUI.State
    {
      [Token(Token = "0x60027E6")]
      [Address(RVA = "0x36710EC", Offset = "0x36710EC", VA = "0x36710EC")]
      public StatePassed(StoryChartStraightLineUI entity)
      {
      }

      [Token(Token = "0x60027E7")]
      [Address(RVA = "0x3671318", Offset = "0x3671318", VA = "0x3671318", Slot = "4")]
      public override void Enter()
      {
      }

      [Token(Token = "0x60027E8")]
      [Address(RVA = "0x367133C", Offset = "0x367133C", VA = "0x367133C", Slot = "5")]
      public override void Exit()
      {
      }
    }

    [Token(Token = "0x2000713")]
    public class StateEffect : StoryChartStraightLineUI.State
    {
      [Token(Token = "0x60027E9")]
      [Address(RVA = "0x3671114", Offset = "0x3671114", VA = "0x3671114")]
      public StateEffect(StoryChartStraightLineUI entity)
      {
      }

      [Token(Token = "0x60027EA")]
      [Address(RVA = "0x3671360", Offset = "0x3671360", VA = "0x3671360", Slot = "4")]
      public override void Enter()
      {
      }

      [Token(Token = "0x60027EB")]
      [Address(RVA = "0x3671384", Offset = "0x3671384", VA = "0x3671384", Slot = "5")]
      public override void Exit()
      {
      }
    }
  }
}
