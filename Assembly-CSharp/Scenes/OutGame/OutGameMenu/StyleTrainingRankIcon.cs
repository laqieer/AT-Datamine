// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleTrainingRankIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AC2")]
  public class StyleTrainingRankIcon : MonoBehaviour
  {
    [Token(Token = "0x4010298")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<StyleTrainingRankIcon.RankIconView> rankIcons;
    [Token(Token = "0x4010299")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x401029A")]
    [FieldOffset(Offset = "0x28")]
    private TrainingRankTypeEnum rankType;

    [Token(Token = "0x60171DD")]
    [Address(RVA = "0x2CE532C", Offset = "0x2CE532C", VA = "0x2CE532C")]
    public void Init(Style style)
    {
    }

    [Token(Token = "0x60171DE")]
    [Address(RVA = "0x2CEF758", Offset = "0x2CEF758", VA = "0x2CEF758")]
    private void Show(TrainingRankTypeEnum rankType)
    {
    }

    [Token(Token = "0x60171DF")]
    [Address(RVA = "0x2CEF72C", Offset = "0x2CEF72C", VA = "0x2CEF72C")]
    private void Hide()
    {
    }

    [Token(Token = "0x60171E0")]
    [Address(RVA = "0x2CEF8E0", Offset = "0x2CEF8E0", VA = "0x2CEF8E0")]
    public StyleTrainingRankIcon()
    {
    }

    [Token(Token = "0x2003AC3")]
    [Serializable]
    private struct RankIconView
    {
      [Token(Token = "0x401029B")]
      [FieldOffset(Offset = "0x0")]
      public Sprite sprite;
      [Token(Token = "0x401029C")]
      [FieldOffset(Offset = "0x8")]
      public TrainingRankTypeEnum type;
    }
  }
}
