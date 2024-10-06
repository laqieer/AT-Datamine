// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.QuestNodeTreeView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A34")]
  public class QuestNodeTreeView : MonoBehaviour
  {
    [Token(Token = "0x400B38C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Camera camera;
    [Token(Token = "0x400B38D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private QuestNodeUnit refNodeUnit;
    [Token(Token = "0x400B38E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private NodeSpaceUnleashEffectDirector spaceUnleashEffectDirector;
    [Token(Token = "0x400B38F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private NodeUnitMoveEffectDirector nodeUnitMoveEffectDirector;
    [Token(Token = "0x400B390")]
    [FieldOffset(Offset = "0x38")]
    private QuestNodeTreeController treeController;
    [Token(Token = "0x400B391")]
    [FieldOffset(Offset = "0x40")]
    private QuestNodeSpace currentNode;

    [Token(Token = "0x1700396D")]
    public Rect MovableWorldRange
    {
      [Token(Token = "0x6010862"), Address(RVA = "0x4C2592C", Offset = "0x4C2592C", VA = "0x4C2592C")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x1700396E")]
    public Camera RenderCamera
    {
      [Token(Token = "0x6010863"), Address(RVA = "0x4C2594C", Offset = "0x4C2594C", VA = "0x4C2594C")] get
      {
        return (Camera) null;
      }
    }

    [Token(Token = "0x6010864")]
    [Address(RVA = "0x4C25954", Offset = "0x4C25954", VA = "0x4C25954")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6010865")]
    [Address(RVA = "0x4C25964", Offset = "0x4C25964", VA = "0x4C25964")]
    public void Initialize(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6010866")]
    [Address(RVA = "0x4C259C8", Offset = "0x4C259C8", VA = "0x4C259C8")]
    public void AddNode(
      int id,
      string name,
      int nodeResourceId,
      int accessoryId,
      NodeStateType stateType,
      Vector2 position,
      int[] next)
    {
    }

    [Token(Token = "0x6010867")]
    [Address(RVA = "0x4C259F8", Offset = "0x4C259F8", VA = "0x4C259F8")]
    public void SetPlayerUnit(int styleId)
    {
    }

    [Token(Token = "0x6010868")]
    [Address(RVA = "0x4C25A1C", Offset = "0x4C25A1C", VA = "0x4C25A1C")]
    public void CreateTree(Action onFinish = null)
    {
    }

    [Token(Token = "0x6010869")]
    [Address(RVA = "0x4C25AB0", Offset = "0x4C25AB0", VA = "0x4C25AB0")]
    public void ClearTree()
    {
    }

    [Token(Token = "0x601086A")]
    [Address(RVA = "0x4C25AEC", Offset = "0x4C25AEC", VA = "0x4C25AEC")]
    public void SetSelectNode(int nodeId)
    {
    }

    [Token(Token = "0x601086B")]
    [Address(RVA = "0x4C25BBC", Offset = "0x4C25BBC", VA = "0x4C25BBC")]
    public void ChangeNodeState(int nodeId, NodeStateType nodeStateType)
    {
    }

    [Token(Token = "0x601086C")]
    [Address(RVA = "0x4C25BD4", Offset = "0x4C25BD4", VA = "0x4C25BD4")]
    public int CheckCollision(Vector2 screenPosition) => new int();

    [Token(Token = "0x601086D")]
    [Address(RVA = "0x4C25C04", Offset = "0x4C25C04", VA = "0x4C25C04")]
    public void SetUnleashEffectNode(int rootNodeId, int targetNodeId)
    {
    }

    [Token(Token = "0x601086E")]
    [Address(RVA = "0x4C25C5C", Offset = "0x4C25C5C", VA = "0x4C25C5C")]
    public void StartUnleashEffect(Action onFinish = null)
    {
    }

    [Token(Token = "0x601086F")]
    [Address(RVA = "0x4C25A3C", Offset = "0x4C25A3C", VA = "0x4C25A3C")]
    private IEnumerator CreateTreeAsync(Action onFinish) => (IEnumerator) null;

    [Token(Token = "0x6010870")]
    [Address(RVA = "0x4C25CB0", Offset = "0x4C25CB0", VA = "0x4C25CB0")]
    public QuestNodeTreeView()
    {
    }
  }
}
