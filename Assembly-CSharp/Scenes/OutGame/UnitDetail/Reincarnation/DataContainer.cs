// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.Reincarnation.DataContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.Reincarnation
{
  [Token(Token = "0x20032DC")]
  public class DataContainer : MonoBehaviour
  {
    [Token(Token = "0x400DB65")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ParameterGroup parameterGroup;
    [Token(Token = "0x400DB66")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image[] rarityIcons;
    [Token(Token = "0x400DB67")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text totalBattlePower;
    [Token(Token = "0x400DB68")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Toggle[] limitBreakToggles;
    [Token(Token = "0x400DB69")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image[] releaseIcons;
    [Token(Token = "0x400DB6A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text nowLv;
    [Token(Token = "0x400DB6B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text maxLv;
    [Token(Token = "0x400DB6C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private RectTransform expSlider;
    [Token(Token = "0x400DB6D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text totalPinAverage;

    [Token(Token = "0x17004308")]
    public ParameterTypeEnum SelectPinParam
    {
      [Token(Token = "0x6013FAB"), Address(RVA = "0x23463EC", Offset = "0x23463EC", VA = "0x23463EC")] get
      {
        return new ParameterTypeEnum();
      }
      [Token(Token = "0x6013FAC"), Address(RVA = "0x23463F4", Offset = "0x23463F4", VA = "0x23463F4")] private set
      {
      }
    }

    [Token(Token = "0x17004309")]
    public bool IsAllOff
    {
      [Token(Token = "0x6013FAD"), Address(RVA = "0x23463FC", Offset = "0x23463FC", VA = "0x23463FC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6013FAE")]
    [Address(RVA = "0x2346510", Offset = "0x2346510", VA = "0x2346510")]
    public void InitializeByBefore(Style style)
    {
    }

    [Token(Token = "0x6013FAF")]
    [Address(RVA = "0x2346E78", Offset = "0x2346E78", VA = "0x2346E78")]
    public void InitializeByAfter(Style style)
    {
    }

    [Token(Token = "0x6013FB0")]
    [Address(RVA = "0x2347420", Offset = "0x2347420", VA = "0x2347420")]
    private int AfterBattlePower(
      ParameterGroup.Parameter parameter,
      IBattleParameter masterBonus,
      StyleData styleData)
    {
      return new int();
    }

    [Token(Token = "0x6013FB1")]
    [Address(RVA = "0x2346CE0", Offset = "0x2346CE0", VA = "0x2346CE0")]
    private void InitializeByCommon(Style style)
    {
    }

    [Token(Token = "0x6013FB2")]
    [Address(RVA = "0x23475DC", Offset = "0x23475DC", VA = "0x23475DC")]
    public DataContainer()
    {
    }
  }
}
