// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.NodeUnitMoveEffectDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A20")]
  public class NodeUnitMoveEffectDirector : MonoBehaviour
  {
    [Token(Token = "0x400B33B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float unitOutDelayTime;
    [Token(Token = "0x400B33C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float unitRenderDelayTime;
    [Token(Token = "0x400B33D")]
    [FieldOffset(Offset = "0x20")]
    private Coroutine coroutine;
    [Token(Token = "0x400B33E")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<int, QuestNodeSelectedMark> markDic;
    [Token(Token = "0x400B33F")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<int, GameObject> jumpInDic;
    [Token(Token = "0x400B340")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, GameObject> jumpOutDic;
    [Token(Token = "0x400B341")]
    [FieldOffset(Offset = "0x40")]
    private GameObject currentInEffect;
    [Token(Token = "0x400B342")]
    [FieldOffset(Offset = "0x48")]
    private GameObject currentOutEffect;
    [Token(Token = "0x400B343")]
    [FieldOffset(Offset = "0x50")]
    private QuestNodeSelectedMark currentMark;
    [Token(Token = "0x400B344")]
    [FieldOffset(Offset = "0x58")]
    private NodeAssetRecipeContainer assetContainer;

    [Token(Token = "0x60107E8")]
    [Address(RVA = "0x4C21954", Offset = "0x4C21954", VA = "0x4C21954")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60107E9")]
    [Address(RVA = "0x4C21A18", Offset = "0x4C21A18", VA = "0x4C21A18")]
    public void Initialize(NodeAssetRecipeContainer assetContainer)
    {
    }

    [Token(Token = "0x60107EA")]
    [Address(RVA = "0x4C21A20", Offset = "0x4C21A20", VA = "0x4C21A20")]
    public void Clear()
    {
    }

    [Token(Token = "0x60107EB")]
    [Address(RVA = "0x4C21AC4", Offset = "0x4C21AC4", VA = "0x4C21AC4")]
    public void StartEffect(
      QuestNodeUnit unitNode,
      QuestNodeSpace rootNode,
      QuestNodeSpace nextNode)
    {
    }

    [Token(Token = "0x60107EC")]
    [Address(RVA = "0x4C21BDC", Offset = "0x4C21BDC", VA = "0x4C21BDC")]
    private IEnumerator Effective(
      QuestNodeUnit unitNode,
      QuestNodeSpace rootNode,
      QuestNodeSpace nextNode)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60107ED")]
    [Address(RVA = "0x4C21C8C", Offset = "0x4C21C8C", VA = "0x4C21C8C")]
    private void SetJumpInAsset(QuestNodeSpace node)
    {
    }

    [Token(Token = "0x60107EE")]
    [Address(RVA = "0x4C21E74", Offset = "0x4C21E74", VA = "0x4C21E74")]
    private void SetJumpOutAsset(QuestNodeSpace node)
    {
    }

    [Token(Token = "0x60107EF")]
    [Address(RVA = "0x4C2205C", Offset = "0x4C2205C", VA = "0x4C2205C")]
    private void SetSelectMarkAsset(QuestNodeSpace node)
    {
    }

    [Token(Token = "0x60107F0")]
    [Address(RVA = "0x4C22274", Offset = "0x4C22274", VA = "0x4C22274")]
    public NodeUnitMoveEffectDirector()
    {
    }
  }
}
