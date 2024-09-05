// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.MissionCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003743")]
  public sealed class MissionCell : MonoBehaviour
  {
    [Token(Token = "0x400F14B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string stampOffName;
    [Token(Token = "0x400F14C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string stampOnName;
    [Token(Token = "0x400F14D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string stampingName;
    [Token(Token = "0x400F14E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text missionName;
    [Token(Token = "0x400F14F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text rewardItemName;
    [Token(Token = "0x400F150")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ItemIcon icon;
    [Token(Token = "0x400F151")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private LongPressButton button;
    [Token(Token = "0x400F152")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UITweenGroup tweenGroup;

    [Token(Token = "0x1400021A")]
    public event Action<RewardTypeEnum, int> onLongPress
    {
      [Token(Token = "0x6015C3C"), Address(RVA = "0x1B27A30", Offset = "0x1B27A30", VA = "0x1B27A30")] add
      {
      }
      [Token(Token = "0x6015C3D"), Address(RVA = "0x1B27AE0", Offset = "0x1B27AE0", VA = "0x1B27AE0")] remove
      {
      }
    }

    [Token(Token = "0x6015C3E")]
    [Address(RVA = "0x1B27B90", Offset = "0x1B27B90", VA = "0x1B27B90")]
    public void Show(RewardTypeEnum itemType, int itemId, int amount, string missionName)
    {
    }

    [Token(Token = "0x6015C3F")]
    [Address(RVA = "0x1B27DB4", Offset = "0x1B27DB4", VA = "0x1B27DB4")]
    public void ShowStamp()
    {
    }

    [Token(Token = "0x6015C40")]
    [Address(RVA = "0x1B27DDC", Offset = "0x1B27DDC", VA = "0x1B27DDC")]
    public void HideStamp()
    {
    }

    [Token(Token = "0x6015C41")]
    [Address(RVA = "0x1B27E04", Offset = "0x1B27E04", VA = "0x1B27E04")]
    public void Stamping()
    {
    }

    [Token(Token = "0x6015C42")]
    [Address(RVA = "0x1B27E2C", Offset = "0x1B27E2C", VA = "0x1B27E2C")]
    public MissionCell()
    {
    }
  }
}
