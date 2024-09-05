// Decompiled with JetBrains decompiler
// Type: Story.Chart.ChartViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Story.Chart.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006BE")]
  public class ChartViewer
  {
    [Token(Token = "0x400201F")]
    private const int PRESERVE_NODE_COUNT = 25;
    [Token(Token = "0x4002020")]
    [FieldOffset(Offset = "0x28")]
    private ViewportMarginRect calculator;
    [Token(Token = "0x4002021")]
    [FieldOffset(Offset = "0x30")]
    private ChartViewer.NodeDepthCut depthCutting;
    [Token(Token = "0x4002022")]
    [FieldOffset(Offset = "0x38")]
    private ChartViewer.MovableRangeX xRange;
    [Token(Token = "0x4002023")]
    [FieldOffset(Offset = "0x40")]
    private ChartViewer.MovableRangeY yRange;
    [Token(Token = "0x4002024")]
    [FieldOffset(Offset = "0x48")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x4002025")]
    [FieldOffset(Offset = "0x50")]
    private NodeObjectProvider nodeObjectProvider;
    [Token(Token = "0x4002026")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<Node, StoryChartNodeUI> showItems;
    [Token(Token = "0x4002027")]
    [FieldOffset(Offset = "0x60")]
    private Popup popup;
    [Token(Token = "0x4002028")]
    [FieldOffset(Offset = "0x68")]
    private StoryTerningPointConditionPopupContent terningPointConditionPopupContent;
    [Token(Token = "0x4002029")]
    [FieldOffset(Offset = "0x70")]
    private StoryConditionPopupContent conditionPopupContent;
    [Token(Token = "0x400202A")]
    [FieldOffset(Offset = "0x78")]
    private Chapter chapter;
    [Token(Token = "0x400202B")]
    [FieldOffset(Offset = "0x80")]
    private IEnumerable<Node> depthOrderedNodeList;

    [Token(Token = "0x170005A1")]
    public ChartUI ChartUI
    {
      [Token(Token = "0x6002625"), Address(RVA = "0x2F41064", Offset = "0x2F41064", VA = "0x2F41064")] get
      {
        return (ChartUI) null;
      }
      [Token(Token = "0x6002626"), Address(RVA = "0x2F4106C", Offset = "0x2F4106C", VA = "0x2F4106C")] set
      {
      }
    }

    [Token(Token = "0x170005A2")]
    public ChartParameter ChartParameter
    {
      [Token(Token = "0x6002627"), Address(RVA = "0x2F41074", Offset = "0x2F41074", VA = "0x2F41074")] get
      {
        return (ChartParameter) null;
      }
      [Token(Token = "0x6002628"), Address(RVA = "0x2F4107C", Offset = "0x2F4107C", VA = "0x2F4107C")] set
      {
      }
    }

    [Token(Token = "0x170005A3")]
    public bool EndingEffect
    {
      [Token(Token = "0x6002629"), Address(RVA = "0x2F41084", Offset = "0x2F41084", VA = "0x2F41084")] get
      {
        return new bool();
      }
      [Token(Token = "0x600262A"), Address(RVA = "0x2F4108C", Offset = "0x2F4108C", VA = "0x2F4108C")] set
      {
      }
    }

    [Token(Token = "0x600262B")]
    [Address(RVA = "0x2F41098", Offset = "0x2F41098", VA = "0x2F41098")]
    private Coroutine StartCoroutine(IEnumerator process) => (Coroutine) null;

    [Token(Token = "0x600262C")]
    [Address(RVA = "0x2F41124", Offset = "0x2F41124", VA = "0x2F41124")]
    public IEnumerator Load(AssetCachedSpawner spawner) => (IEnumerator) null;

    [Token(Token = "0x600262D")]
    [Address(RVA = "0x2F411C0", Offset = "0x2F411C0", VA = "0x2F411C0")]
    private IEnumerator OnLoadedNode(GameObject asset) => (IEnumerator) null;

    [Token(Token = "0x600262E")]
    [Address(RVA = "0x2F4125C", Offset = "0x2F4125C", VA = "0x2F4125C")]
    public void Destroy()
    {
    }

    [Token(Token = "0x600262F")]
    [Address(RVA = "0x2F412D0", Offset = "0x2F412D0", VA = "0x2F412D0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x6002630")]
    [Address(RVA = "0x2F4168C", Offset = "0x2F4168C", VA = "0x2F4168C")]
    public void Setup(Chapter chapter, INodeStatus nodeStatus = null)
    {
    }

    [Token(Token = "0x6002631")]
    [Address(RVA = "0x2F419F4", Offset = "0x2F419F4", VA = "0x2F419F4")]
    public void OnScrollChangeValue(Vector2 changedValue)
    {
    }

    [Token(Token = "0x6002632")]
    [Address(RVA = "0x2F41FC0", Offset = "0x2F41FC0", VA = "0x2F41FC0")]
    public void Jump(Node node)
    {
    }

    [Token(Token = "0x6002633")]
    [Address(RVA = "0x2F42070", Offset = "0x2F42070", VA = "0x2F42070")]
    private IEnumerator Scroll(Node node) => (IEnumerator) null;

    [Token(Token = "0x6002634")]
    [Address(RVA = "0x2F4210C", Offset = "0x2F4210C", VA = "0x2F4210C")]
    public Node GetCurrentNode() => (Node) null;

    [Token(Token = "0x6002635")]
    [Address(RVA = "0x2F419F8", Offset = "0x2F419F8", VA = "0x2F419F8")]
    public void Show()
    {
    }

    [Token(Token = "0x6002636")]
    [Address(RVA = "0x2F426F0", Offset = "0x2F426F0", VA = "0x2F426F0")]
    private StoryChartNodeUI Show(Node node) => (StoryChartNodeUI) null;

    [Token(Token = "0x6002637")]
    [Address(RVA = "0x2F42A94", Offset = "0x2F42A94", VA = "0x2F42A94")]
    private StoryChartNodeUI Concreate(Node node) => (StoryChartNodeUI) null;

    [Token(Token = "0x6002638")]
    [Address(RVA = "0x2F427F0", Offset = "0x2F427F0", VA = "0x2F427F0")]
    private void ShowLines(Node node, StoryChartNodeUI instance)
    {
    }

    [Token(Token = "0x6002639")]
    [Address(RVA = "0x2F42030", Offset = "0x2F42030", VA = "0x2F42030")]
    public Vector2 NodePosition(Node node) => new Vector2();

    [Token(Token = "0x600263A")]
    [Address(RVA = "0x2F429DC", Offset = "0x2F429DC", VA = "0x2F429DC")]
    private void Release(Node node)
    {
    }

    [Token(Token = "0x600263B")]
    [Address(RVA = "0x2F4303C", Offset = "0x2F4303C", VA = "0x2F4303C")]
    private void OnClickNode(Node node)
    {
    }

    [Token(Token = "0x600263C")]
    [Address(RVA = "0x2F43568", Offset = "0x2F43568", VA = "0x2F43568")]
    public ChartViewer()
    {
    }

    [Token(Token = "0x20006BF")]
    public class MovableRange
    {
      [Token(Token = "0x400202E")]
      [FieldOffset(Offset = "0x18")]
      public ChartViewer.MovableRange.GetNodePosition NodePosition;

      [Token(Token = "0x170005A4")]
      public float Ceil
      {
        [Token(Token = "0x600263D"), Address(RVA = "0x2F436D4", Offset = "0x2F436D4", VA = "0x2F436D4")] get
        {
          return new float();
        }
        [Token(Token = "0x600263E"), Address(RVA = "0x2F436DC", Offset = "0x2F436DC", VA = "0x2F436DC")] set
        {
        }
      }

      [Token(Token = "0x170005A5")]
      public float Floor
      {
        [Token(Token = "0x600263F"), Address(RVA = "0x2F436E4", Offset = "0x2F436E4", VA = "0x2F436E4")] get
        {
          return new float();
        }
        [Token(Token = "0x6002640"), Address(RVA = "0x2F436EC", Offset = "0x2F436EC", VA = "0x2F436EC")] set
        {
        }
      }

      [Token(Token = "0x6002641")]
      [Address(RVA = "0x2F436F4", Offset = "0x2F436F4", VA = "0x2F436F4")]
      public MovableRange()
      {
      }

      [Token(Token = "0x20006C0")]
      public delegate Vector2 GetNodePosition(Node node);
    }

    [Token(Token = "0x20006C2")]
    public class MovableRangeX : ChartViewer.MovableRange
    {
      [Token(Token = "0x6002649")]
      [Address(RVA = "0x2F416EC", Offset = "0x2F416EC", VA = "0x2F416EC")]
      public void Calculate(IEnumerable<Node> showItems)
      {
      }

      [Token(Token = "0x600264A")]
      [Address(RVA = "0x2F436BC", Offset = "0x2F436BC", VA = "0x2F436BC")]
      public MovableRangeX()
      {
      }
    }

    [Token(Token = "0x20006C3")]
    public class MovableRangeY : ChartViewer.MovableRange
    {
      [Token(Token = "0x600264B")]
      [Address(RVA = "0x2F42124", Offset = "0x2F42124", VA = "0x2F42124")]
      public void Calculate(IEnumerable<Node> showItems)
      {
      }

      [Token(Token = "0x600264C")]
      [Address(RVA = "0x2F436C0", Offset = "0x2F436C0", VA = "0x2F436C0")]
      public MovableRangeY()
      {
      }
    }

    [Token(Token = "0x20006C4")]
    private class NodeDepthCut
    {
      [Token(Token = "0x170005A6")]
      public Node LastShowNode
      {
        [Token(Token = "0x600264D"), Address(RVA = "0x2F438E0", Offset = "0x2F438E0", VA = "0x2F438E0")] get
        {
          return (Node) null;
        }
        [Token(Token = "0x600264E"), Address(RVA = "0x2F438E8", Offset = "0x2F438E8", VA = "0x2F438E8")] set
        {
        }
      }

      [Token(Token = "0x170005A7")]
      public int Range
      {
        [Token(Token = "0x600264F"), Address(RVA = "0x2F438F0", Offset = "0x2F438F0", VA = "0x2F438F0")] get
        {
          return new int();
        }
        [Token(Token = "0x6002650"), Address(RVA = "0x2F438F8", Offset = "0x2F438F8", VA = "0x2F438F8")] set
        {
        }
      }

      [Token(Token = "0x170005A8")]
      public int ShowableItemsMin
      {
        [Token(Token = "0x6002651"), Address(RVA = "0x2F43900", Offset = "0x2F43900", VA = "0x2F43900")] get
        {
          return new int();
        }
        [Token(Token = "0x6002652"), Address(RVA = "0x2F43908", Offset = "0x2F43908", VA = "0x2F43908")] set
        {
        }
      }

      [Token(Token = "0x170005A9")]
      public int ShowableItems
      {
        [Token(Token = "0x6002653"), Address(RVA = "0x2F43910", Offset = "0x2F43910", VA = "0x2F43910")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6002654")]
      [Address(RVA = "0x2F426A4", Offset = "0x2F426A4", VA = "0x2F426A4")]
      public bool Cuttable(Node node) => new bool();

      [Token(Token = "0x6002655")]
      [Address(RVA = "0x2F436AC", Offset = "0x2F436AC", VA = "0x2F436AC")]
      public NodeDepthCut()
      {
      }
    }
  }
}
