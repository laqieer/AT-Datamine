// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.QuestNodeTreeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A2E")]
  public class QuestNodeTreeController
  {
    [Token(Token = "0x400B378")]
    [FieldOffset(Offset = "0x10")]
    private NodeAssetRecipeContainer assetRecipeContainer;
    [Token(Token = "0x400B379")]
    [FieldOffset(Offset = "0x18")]
    private NodeAssetAccessoryContainer accessoryContainer;
    [Token(Token = "0x400B37A")]
    [FieldOffset(Offset = "0x20")]
    private NodeAssetUnitContainer unitContainer;
    [Token(Token = "0x400B37B")]
    [FieldOffset(Offset = "0x28")]
    private List<QuestNodeSpace.Parameter> nodeParameterList;
    [Token(Token = "0x400B37C")]
    [FieldOffset(Offset = "0x30")]
    private List<QuestNodeSpace> nodeList;
    [Token(Token = "0x400B37D")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner useSpawner;
    [Token(Token = "0x400B37E")]
    [FieldOffset(Offset = "0x40")]
    private Rect movableRange;
    [Token(Token = "0x400B37F")]
    [FieldOffset(Offset = "0x50")]
    private Transform nodeRoot;
    [Token(Token = "0x400B380")]
    [FieldOffset(Offset = "0x58")]
    private Transform treeParent;
    [Token(Token = "0x400B381")]
    [FieldOffset(Offset = "0x60")]
    private int playerUnitStyleId;
    [Token(Token = "0x400B382")]
    [FieldOffset(Offset = "0x68")]
    private QuestNodeUnit playerUnitNode;

    [Token(Token = "0x17003966")]
    public Rect MovableWorldRange
    {
      [Token(Token = "0x601083E"), Address(RVA = "0x4C24034", Offset = "0x4C24034", VA = "0x4C24034")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x17003967")]
    public NodeAssetRecipeContainer AssetRecipeContainer
    {
      [Token(Token = "0x601083F"), Address(RVA = "0x4C24040", Offset = "0x4C24040", VA = "0x4C24040")] get
      {
        return (NodeAssetRecipeContainer) null;
      }
    }

    [Token(Token = "0x17003968")]
    public QuestNodeUnit PlayerUnitNode
    {
      [Token(Token = "0x6010840"), Address(RVA = "0x4C24048", Offset = "0x4C24048", VA = "0x4C24048")] get
      {
        return (QuestNodeUnit) null;
      }
    }

    [Token(Token = "0x6010841")]
    [Address(RVA = "0x4C24050", Offset = "0x4C24050", VA = "0x4C24050")]
    public void Initialize(AssetCachedSpawner spawner, Transform parent)
    {
    }

    [Token(Token = "0x6010842")]
    [Address(RVA = "0x4C24098", Offset = "0x4C24098", VA = "0x4C24098")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6010843")]
    [Address(RVA = "0x4C240E0", Offset = "0x4C240E0", VA = "0x4C240E0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6010844")]
    [Address(RVA = "0x4C24224", Offset = "0x4C24224", VA = "0x4C24224")]
    public int CheckCollision(Vector2 world) => new int();

    [Token(Token = "0x6010845")]
    [Address(RVA = "0x4C243C4", Offset = "0x4C243C4", VA = "0x4C243C4")]
    public void AddNode(
      int id,
      string name,
      int nodeResourceId,
      int accessoryId,
      int unitStyleId,
      NodeStateType stateType,
      Vector2 position,
      int[] next)
    {
    }

    [Token(Token = "0x6010846")]
    [Address(RVA = "0x4C24520", Offset = "0x4C24520", VA = "0x4C24520")]
    public void ChangeNodeState(int nodeId, NodeStateType nodeStateType)
    {
    }

    [Token(Token = "0x6010847")]
    [Address(RVA = "0x4C24670", Offset = "0x4C24670", VA = "0x4C24670")]
    public QuestNodeSpace GetNode(int nodeId) => (QuestNodeSpace) null;

    [Token(Token = "0x6010848")]
    [Address(RVA = "0x4C24750", Offset = "0x4C24750", VA = "0x4C24750")]
    public void SetPlayerUnit(QuestNodeUnit prefab, int styleId)
    {
    }

    [Token(Token = "0x6010849")]
    [Address(RVA = "0x4C24794", Offset = "0x4C24794", VA = "0x4C24794")]
    public IEnumerator CreateTreeAsync() => (IEnumerator) null;

    [Token(Token = "0x601084A")]
    [Address(RVA = "0x4C24824", Offset = "0x4C24824", VA = "0x4C24824")]
    private IEnumerator LoadAssetAsync() => (IEnumerator) null;

    [Token(Token = "0x601084B")]
    [Address(RVA = "0x4C248B4", Offset = "0x4C248B4", VA = "0x4C248B4")]
    private void CreateNodeFromParameters()
    {
    }

    [Token(Token = "0x601084C")]
    [Address(RVA = "0x4C24CA8", Offset = "0x4C24CA8", VA = "0x4C24CA8")]
    private void SetupLine(QuestNodeSpace node, NodeAssetRecipe recipe)
    {
    }

    [Token(Token = "0x601084D")]
    [Address(RVA = "0x4C24FD4", Offset = "0x4C24FD4", VA = "0x4C24FD4")]
    private void SetupAccessory(QuestNodeSpace node, NodeAssetRecipe recipe)
    {
    }

    [Token(Token = "0x601084E")]
    [Address(RVA = "0x4C25020", Offset = "0x4C25020", VA = "0x4C25020")]
    private void SetupUnit(QuestNodeSpace node, NodeAssetRecipe recipe)
    {
    }

    [Token(Token = "0x601084F")]
    [Address(RVA = "0x4C2506C", Offset = "0x4C2506C", VA = "0x4C2506C")]
    public QuestNodeTreeController()
    {
    }
  }
}
