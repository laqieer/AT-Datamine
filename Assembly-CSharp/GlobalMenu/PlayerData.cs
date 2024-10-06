// Decompiled with JetBrains decompiler
// Type: GlobalMenu.PlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B96")]
  public class PlayerData : MonoBehaviour
  {
    [Token(Token = "0x40034BD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text playerName;
    [Token(Token = "0x40034BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI lv;
    [Token(Token = "0x40034BF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform tsUnmaskGauge;
    [Token(Token = "0x40034C0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITweenGroup badgeAnimationGroup;
    [Token(Token = "0x40034C1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button buttonInfo;
    [Token(Token = "0x40034C2")]
    [FieldOffset(Offset = "0x40")]
    public Action OnClickInfo;

    [Token(Token = "0x6004222")]
    [Address(RVA = "0x2A33658", Offset = "0x2A33658", VA = "0x2A33658")]
    private void Awake()
    {
    }

    [Token(Token = "0x6004223")]
    [Address(RVA = "0x2A33734", Offset = "0x2A33734", VA = "0x2A33734")]
    public void UpdateData()
    {
    }

    [Token(Token = "0x6004224")]
    [Address(RVA = "0x2A33904", Offset = "0x2A33904", VA = "0x2A33904")]
    public void UpdateBadge()
    {
    }

    [Token(Token = "0x6004225")]
    [Address(RVA = "0x2A33AF4", Offset = "0x2A33AF4", VA = "0x2A33AF4")]
    public PlayerData()
    {
    }
  }
}
