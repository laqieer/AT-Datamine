// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.ArmouryDisplayLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UI.Common;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x2003809")]
  [Serializable]
  internal class ArmouryDisplayLevel
  {
    [Token(Token = "0x400F4C3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject root;
    [Token(Token = "0x400F4C4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI levelNumText;
    [Token(Token = "0x400F4C5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private LimitBreakIcons limitBreakIcons;
    [Token(Token = "0x400F4C6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform canLimitBreakBadge;

    [Token(Token = "0x60160BD")]
    [Address(RVA = "0x20EE014", Offset = "0x20EE014", VA = "0x20EE014")]
    public void SetLevelAndLimitBreakCount(int level, int limitBreakCount)
    {
    }

    [Token(Token = "0x60160BE")]
    [Address(RVA = "0x20EE0E0", Offset = "0x20EE0E0", VA = "0x20EE0E0")]
    public void SetActiveCanLimitBreakBadge(bool isActive)
    {
    }

    [Token(Token = "0x60160BF")]
    [Address(RVA = "0x20EE110", Offset = "0x20EE110", VA = "0x20EE110")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x60160C0")]
    [Address(RVA = "0x20EE160", Offset = "0x20EE160", VA = "0x20EE160")]
    public ArmouryDisplayLevel()
    {
    }
  }
}
