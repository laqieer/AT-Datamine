// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.ProgressPointView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002AAD")]
  public class ProgressPointView : MonoBehaviour
  {
    [Token(Token = "0x400B591")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI _processPointL;
    [Token(Token = "0x400B592")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI _processPointR;
    [Token(Token = "0x400B593")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ProgressResetTimeView _resetTime;
    [Token(Token = "0x400B594")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RectTransform _sliderBlueSoulBox;
    [Token(Token = "0x400B595")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private MissionTreasureBoxList _trasureBoxList;
    [Token(Token = "0x400B596")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private UITweenGroup tg;
    [Token(Token = "0x400B597")]
    [FieldOffset(Offset = "0x48")]
    private int pointL;
    [Token(Token = "0x400B598")]
    [FieldOffset(Offset = "0x4C")]
    private int pointR;
    [Token(Token = "0x400B59A")]
    [FieldOffset(Offset = "0x58")]
    private AssetCachedSpawner _assetCachedSpawner;

    [Token(Token = "0x170039D2")]
    public Action<int> OnClickTreasureBox
    {
      [Token(Token = "0x6010B0E"), Address(RVA = "0x4BD2A64", Offset = "0x4BD2A64", VA = "0x4BD2A64")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6010B0F"), Address(RVA = "0x4BD2A6C", Offset = "0x4BD2A6C", VA = "0x4BD2A6C")] set
      {
      }
    }

    [Token(Token = "0x6010B10")]
    [Address(RVA = "0x4BD2A74", Offset = "0x4BD2A74", VA = "0x4BD2A74")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6010B11")]
    [Address(RVA = "0x4BCBDD8", Offset = "0x4BCBDD8", VA = "0x4BCBDD8")]
    public void ShowHide(bool isShow)
    {
    }

    [Token(Token = "0x6010B12")]
    [Address(RVA = "0x4BD2A7C", Offset = "0x4BD2A7C", VA = "0x4BD2A7C")]
    public void SetPoint(int point)
    {
    }

    [Token(Token = "0x6010B13")]
    [Address(RVA = "0x4BD2AC8", Offset = "0x4BD2AC8", VA = "0x4BD2AC8")]
    public void SetPointMax(int point)
    {
    }

    [Token(Token = "0x6010B14")]
    [Address(RVA = "0x4BD2B14", Offset = "0x4BD2B14", VA = "0x4BD2B14")]
    public void SetGaugeRate(float rate)
    {
    }

    [Token(Token = "0x6010B15")]
    [Address(RVA = "0x4BD2B20", Offset = "0x4BD2B20", VA = "0x4BD2B20")]
    public void SetLabelTweenColor()
    {
    }

    [Token(Token = "0x6010B16")]
    [Address(RVA = "0x4BD2B98", Offset = "0x4BD2B98", VA = "0x4BD2B98")]
    public void ResetTreasureBoxList(List<int> points, int currPoint, int receiveCount)
    {
    }

    [Token(Token = "0x6010B17")]
    [Address(RVA = "0x4BD2D18", Offset = "0x4BD2D18", VA = "0x4BD2D18")]
    public void SetResetTime(int hour)
    {
    }

    [Token(Token = "0x6010B18")]
    [Address(RVA = "0x4BD2D78", Offset = "0x4BD2D78", VA = "0x4BD2D78")]
    public void SetRemainingTime(in TimeSpan time)
    {
    }

    [Token(Token = "0x6010B19")]
    [Address(RVA = "0x4BD2ED8", Offset = "0x4BD2ED8", VA = "0x4BD2ED8")]
    public MissionTreasureBox GetTreasureBox(int index) => (MissionTreasureBox) null;

    [Token(Token = "0x6010B1A")]
    [Address(RVA = "0x4BD2EF0", Offset = "0x4BD2EF0", VA = "0x4BD2EF0")]
    public ProgressPointView()
    {
    }
  }
}
