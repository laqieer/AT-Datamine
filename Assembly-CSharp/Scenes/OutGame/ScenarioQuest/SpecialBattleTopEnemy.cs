// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ScenarioQuest.SpecialBattleTopEnemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using UI.Utilities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.ScenarioQuest
{
  [Token(Token = "0x20034FA")]
  [AddComponentMenu("Scenes/OutGame/SpecialBattle/SpecialBattleTopEnemy")]
  public class SpecialBattleTopEnemy : MonoBehaviour
  {
    [Token(Token = "0x400E691")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SpecialBattleTopEnemy.Unit[] units;
    [Token(Token = "0x400E692")]
    [FieldOffset(Offset = "0x20")]
    private int countRequest;

    [Token(Token = "0x170044EC")]
    public SpecialBattleTop.BossType BossType
    {
      [Token(Token = "0x6014C8A"), Address(RVA = "0x1D73D3C", Offset = "0x1D73D3C", VA = "0x1D73D3C")] get
      {
        return new SpecialBattleTop.BossType();
      }
    }

    [Token(Token = "0x170044ED")]
    public bool IsLoadingResources
    {
      [Token(Token = "0x6014C8B"), Address(RVA = "0x1D76AD4", Offset = "0x1D76AD4", VA = "0x1D76AD4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6014C8C")]
    [Address(RVA = "0x1D73D58", Offset = "0x1D73D58", VA = "0x1D73D58")]
    public void Initialize(AssetCachedSpawner cachedSpawner, int[] styleIds)
    {
    }

    [Token(Token = "0x6014C8D")]
    [Address(RVA = "0x1D76FBC", Offset = "0x1D76FBC", VA = "0x1D76FBC")]
    private void RequestLoadResources(AssetCachedSpawner cachedSpawner, int index, int styleId)
    {
    }

    [Token(Token = "0x6014C8E")]
    [Address(RVA = "0x1D772E0", Offset = "0x1D772E0", VA = "0x1D772E0")]
    public SpecialBattleTopEnemy()
    {
    }

    [Token(Token = "0x20034FB")]
    [Serializable]
    private class Unit
    {
      [Token(Token = "0x400E693")]
      [FieldOffset(Offset = "0x10")]
      public Image element;
      [Token(Token = "0x400E694")]
      [FieldOffset(Offset = "0x18")]
      public ImageAdjustController illustration;

      [Token(Token = "0x6014C8F")]
      [Address(RVA = "0x1D772E8", Offset = "0x1D772E8", VA = "0x1D772E8")]
      public Unit()
      {
      }
    }
  }
}
