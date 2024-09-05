// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.NodeAssetRecipe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A17")]
  [CreateAssetMenu(menuName = "staq/AreaQuest/Node Asset Recipe")]
  public class NodeAssetRecipe : ScriptableObject
  {
    [Token(Token = "0x400B318")]
    [FieldOffset(Offset = "0x18")]
    [Header("Nodeの土台アセット")]
    public GameObject NodeSpaceAsset;
    [Token(Token = "0x400B319")]
    [FieldOffset(Offset = "0x20")]
    [Header("NodeのLineアセット")]
    public GameObject LineAsset;
    [Token(Token = "0x400B31A")]
    [FieldOffset(Offset = "0x28")]
    [Header("NodeのLineエフェクトアセット")]
    public GameObject LineEffectAsset;
    [Token(Token = "0x400B31B")]
    [FieldOffset(Offset = "0x30")]
    [Header("Nodeの選択マーク")]
    public GameObject StageSelectMarkAsset;
    [Token(Token = "0x400B31C")]
    [FieldOffset(Offset = "0x38")]
    [Header("Nodeの解放エフェクト")]
    public GameObject NodeLockEffect;
    [Token(Token = "0x400B31D")]
    [FieldOffset(Offset = "0x40")]
    [Header("ユニット移動inエフェクト")]
    public GameObject JumpInAsset;
    [Token(Token = "0x400B31E")]
    [FieldOffset(Offset = "0x48")]
    [Header("ユニット移動outエフェクト")]
    public GameObject JumpOutAsset;

    [Token(Token = "0x60107C1")]
    [Address(RVA = "0x489567C", Offset = "0x489567C", VA = "0x489567C")]
    public NodeAssetRecipe()
    {
    }
  }
}
