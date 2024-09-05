// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaNodeMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010FA")]
  [Serializable]
  public sealed class AreaQuestAreaNodeMaster : BaseMaster<AreaQuestAreaNodeData>
  {
    [Token(Token = "0x40052E4")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, AreaQuestAreaNodeMaster.AreaNodes> nodesByArea;
    [Token(Token = "0x40052E5")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, AreaQuestAreaNodeData> dictByAreaNodeNormalId;

    [Token(Token = "0x60061E0")]
    [Address(RVA = "0x4AD906C", Offset = "0x4AD906C", VA = "0x4AD906C")]
    public IReadOnlyDictionary<int, AreaQuestAreaNodeData> GetEntities()
    {
      return (IReadOnlyDictionary<int, AreaQuestAreaNodeData>) null;
    }

    [Token(Token = "0x60061E1")]
    [Address(RVA = "0x4AD9074", Offset = "0x4AD9074", VA = "0x4AD9074", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60061E2")]
    [Address(RVA = "0x4AD9138", Offset = "0x4AD9138", VA = "0x4AD9138", Slot = "5")]
    protected override AreaQuestAreaNodeData LoadEntity(IMasterDataReader reader)
    {
      return (AreaQuestAreaNodeData) null;
    }

    [Token(Token = "0x60061E3")]
    [Address(RVA = "0x4AD90E4", Offset = "0x4AD90E4", VA = "0x4AD90E4")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x60061E4")]
    [Address(RVA = "0x4AD91A8", Offset = "0x4AD91A8", VA = "0x4AD91A8")]
    private void OnLoadEntity(AreaQuestAreaNodeData entity)
    {
    }

    [Token(Token = "0x60061E5")]
    [Address(RVA = "0x4AD9134", Offset = "0x4AD9134", VA = "0x4AD9134")]
    private void OnCompletedLoading()
    {
    }

    [Token(Token = "0x60061E6")]
    [Address(RVA = "0x4AD9900", Offset = "0x4AD9900", VA = "0x4AD9900")]
    public AreaQuestAreaNodeData GetDataByAreaNodeNormalId(int areaNodeNormalId)
    {
      return (AreaQuestAreaNodeData) null;
    }

    [Token(Token = "0x60061E7")]
    [Address(RVA = "0x4AD9978", Offset = "0x4AD9978", VA = "0x4AD9978")]
    public IReadOnlyList<int> GetAreaNodeIds(int areaId) => (IReadOnlyList<int>) null;

    [Token(Token = "0x60061E8")]
    [Address(RVA = "0x4AD9A84", Offset = "0x4AD9A84", VA = "0x4AD9A84")]
    public IReadOnlyList<int> GetParentNodeIds(int areaNodeId) => (IReadOnlyList<int>) null;

    [Token(Token = "0x60061E9")]
    [Address(RVA = "0x4AD9DC0", Offset = "0x4AD9DC0", VA = "0x4AD9DC0")]
    public IReadOnlyList<int> GetChildNodeIds(int areaNodeId) => (IReadOnlyList<int>) null;

    [Token(Token = "0x60061EA")]
    [Address(RVA = "0x4AD924C", Offset = "0x4AD924C", VA = "0x4AD924C")]
    private void CreateDataIfNeeded()
    {
    }

    [Token(Token = "0x60061EB")]
    [Address(RVA = "0x4ADA0FC", Offset = "0x4ADA0FC", VA = "0x4ADA0FC")]
    private void CreateAreaNode(out AreaQuestAreaNodeMaster.AreaNodes data, List<int> areanodes)
    {
    }

    [Token(Token = "0x60061EC")]
    [Address(RVA = "0x4ADAAC8", Offset = "0x4ADAAC8", VA = "0x4ADAAC8")]
    public AreaQuestAreaNodeMaster()
    {
    }

    [Token(Token = "0x20010FB")]
    private class AreaNodes
    {
      [Token(Token = "0x40052E6")]
      [FieldOffset(Offset = "0x10")]
      public AreaQuestAreaNodeMaster.LinkNodeTree Tree;
      [Token(Token = "0x40052E7")]
      [FieldOffset(Offset = "0x18")]
      public Dictionary<int, AreaQuestAreaNodeMaster.LinkNodeTree.Node> DictByAreaId;

      [Token(Token = "0x60061ED")]
      [Address(RVA = "0x4ADA778", Offset = "0x4ADA778", VA = "0x4ADA778")]
      public AreaNodes()
      {
      }
    }

    [Token(Token = "0x20010FC")]
    private class LinkNodeTree
    {
      [Token(Token = "0x40052E8")]
      [FieldOffset(Offset = "0x10")]
      private List<AreaQuestAreaNodeMaster.LinkNodeTree.Node> nodes;

      [Token(Token = "0x60061EE")]
      [Address(RVA = "0x4ADA89C", Offset = "0x4ADA89C", VA = "0x4ADA89C")]
      public AreaQuestAreaNodeMaster.LinkNodeTree.Node CreateNode(int areanode)
      {
        return (AreaQuestAreaNodeMaster.LinkNodeTree.Node) null;
      }

      [Token(Token = "0x60061EF")]
      [Address(RVA = "0x4ADA820", Offset = "0x4ADA820", VA = "0x4ADA820")]
      public LinkNodeTree()
      {
      }

      [Token(Token = "0x20010FD")]
      public class Node
      {
        [Token(Token = "0x60061F0")]
        [Address(RVA = "0x4ADAB9C", Offset = "0x4ADAB9C", VA = "0x4ADAB9C")]
        public Node(int aranodeId)
        {
        }

        [Token(Token = "0x60061F1")]
        [Address(RVA = "0x4ADAA20", Offset = "0x4ADAA20", VA = "0x4ADAA20")]
        public void AddParentRef(AreaQuestAreaNodeMaster.LinkNodeTree.Node ele)
        {
        }

        [Token(Token = "0x60061F2")]
        [Address(RVA = "0x4ADA978", Offset = "0x4ADA978", VA = "0x4ADA978")]
        public void AddChildRef(AreaQuestAreaNodeMaster.LinkNodeTree.Node ele)
        {
        }

        [Token(Token = "0x17000E99")]
        public int AreaNodeId
        {
          [Token(Token = "0x60061F3"), Address(RVA = "0x4ADAC48", Offset = "0x4ADAC48", VA = "0x4ADAC48")] get
          {
            return new int();
          }
          [Token(Token = "0x60061F4"), Address(RVA = "0x4ADAC50", Offset = "0x4ADAC50", VA = "0x4ADAC50")] private set
          {
          }
        }

        [Token(Token = "0x17000E9A")]
        public List<AreaQuestAreaNodeMaster.LinkNodeTree.Node> Parents
        {
          [Token(Token = "0x60061F5"), Address(RVA = "0x4ADAC58", Offset = "0x4ADAC58", VA = "0x4ADAC58")] get
          {
            return (List<AreaQuestAreaNodeMaster.LinkNodeTree.Node>) null;
          }
          [Token(Token = "0x60061F6"), Address(RVA = "0x4ADAC60", Offset = "0x4ADAC60", VA = "0x4ADAC60")] private set
          {
          }
        }

        [Token(Token = "0x17000E9B")]
        public List<AreaQuestAreaNodeMaster.LinkNodeTree.Node> Childs
        {
          [Token(Token = "0x60061F7"), Address(RVA = "0x4ADAC68", Offset = "0x4ADAC68", VA = "0x4ADAC68")] get
          {
            return (List<AreaQuestAreaNodeMaster.LinkNodeTree.Node>) null;
          }
          [Token(Token = "0x60061F8"), Address(RVA = "0x4ADAC70", Offset = "0x4ADAC70", VA = "0x4ADAC70")] private set
          {
          }
        }

        [Token(Token = "0x60061F9")]
        [Address(RVA = "0x4AD9BBC", Offset = "0x4AD9BBC", VA = "0x4AD9BBC")]
        public IReadOnlyList<int> GetParentAreaNodeIds() => (IReadOnlyList<int>) null;

        [Token(Token = "0x60061FA")]
        [Address(RVA = "0x4AD9EF8", Offset = "0x4AD9EF8", VA = "0x4AD9EF8")]
        public IReadOnlyList<int> GetChildAreaNodeIds() => (IReadOnlyList<int>) null;
      }
    }
  }
}
