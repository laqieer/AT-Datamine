// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.NodeSpaceUnleashEffectDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A1D")]
  public class NodeSpaceUnleashEffectDirector : MonoBehaviour
  {
    [Token(Token = "0x400B32B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float startDelayTime;
    [Token(Token = "0x400B32C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float effectForSeconds;
    [Token(Token = "0x400B32D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AnimationCurve Curve;
    [Token(Token = "0x400B32E")]
    [FieldOffset(Offset = "0x28")]
    private NodeAnimationCurve animCurve;
    [Token(Token = "0x400B32F")]
    [FieldOffset(Offset = "0x30")]
    private List<NodeSpaceUnleashEffectDirector.EffectParameter> effectList;
    [Token(Token = "0x400B330")]
    [FieldOffset(Offset = "0x38")]
    private NodeAssetRecipeContainer assetContainer;
    [Token(Token = "0x400B331")]
    [FieldOffset(Offset = "0x40")]
    private bool isFinished;

    [Token(Token = "0x60107DA")]
    [Address(RVA = "0x4C20AE8", Offset = "0x4C20AE8", VA = "0x4C20AE8")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60107DB")]
    [Address(RVA = "0x4C20C48", Offset = "0x4C20C48", VA = "0x4C20C48")]
    public void Initialize(NodeAssetRecipeContainer assetContainer)
    {
    }

    [Token(Token = "0x60107DC")]
    [Address(RVA = "0x4C20C50", Offset = "0x4C20C50", VA = "0x4C20C50")]
    public void Clear()
    {
    }

    [Token(Token = "0x60107DD")]
    [Address(RVA = "0x4C20CC0", Offset = "0x4C20CC0", VA = "0x4C20CC0")]
    public void AddEffectNode(QuestNodeSpace rootNode, QuestNodeSpace nextNode)
    {
    }

    [Token(Token = "0x60107DE")]
    [Address(RVA = "0x4C21220", Offset = "0x4C21220", VA = "0x4C21220")]
    public void StartEffect(Action onFinish = null)
    {
    }

    [Token(Token = "0x60107DF")]
    [Address(RVA = "0x4C21240", Offset = "0x4C21240", VA = "0x4C21240")]
    private IEnumerator Effective(Action onFinish = null) => (IEnumerator) null;

    [Token(Token = "0x60107E0")]
    [Address(RVA = "0x4C212DC", Offset = "0x4C212DC", VA = "0x4C212DC")]
    public NodeSpaceUnleashEffectDirector()
    {
    }

    [Token(Token = "0x2002A1E")]
    private class EffectParameter
    {
      [Token(Token = "0x400B332")]
      [FieldOffset(Offset = "0x10")]
      public QuestNodeConnectingLine Line;
      [Token(Token = "0x400B333")]
      [FieldOffset(Offset = "0x18")]
      public GameObject UnleashAsset;
      [Token(Token = "0x400B334")]
      [FieldOffset(Offset = "0x20")]
      public GameObject LineEffectAsset;

      [Token(Token = "0x60107E1")]
      [Address(RVA = "0x4C20EE8", Offset = "0x4C20EE8", VA = "0x4C20EE8")]
      public EffectParameter()
      {
      }
    }
  }
}
