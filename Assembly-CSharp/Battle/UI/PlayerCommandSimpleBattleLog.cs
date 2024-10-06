// Decompiled with JetBrains decompiler
// Type: Battle.UI.PlayerCommandSimpleBattleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002335")]
  public class PlayerCommandSimpleBattleLog : MonoBehaviour
  {
    [Token(Token = "0x4009567")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI logText;
    [Token(Token = "0x4009568")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public CommonButton battleLogButton;
    [Token(Token = "0x4009569")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup logTween;

    [Token(Token = "0x600D748")]
    [Address(RVA = "0x1D26C78", Offset = "0x1D26C78", VA = "0x1D26C78")]
    public void SetBattleLogSimplifiedText(string log)
    {
    }

    [Token(Token = "0x600D749")]
    [Address(RVA = "0x1D26474", Offset = "0x1D26474", VA = "0x1D26474")]
    public void SetOpenBattleLogButtonEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x600D74A")]
    [Address(RVA = "0x1D26BB8", Offset = "0x1D26BB8", VA = "0x1D26BB8")]
    public void ShowSimpleBattleLog()
    {
    }

    [Token(Token = "0x600D74B")]
    [Address(RVA = "0x1D27014", Offset = "0x1D27014", VA = "0x1D27014")]
    public void HideSimpleBattleLog()
    {
    }

    [Token(Token = "0x600D74C")]
    [Address(RVA = "0x1D270BC", Offset = "0x1D270BC", VA = "0x1D270BC")]
    public void HideSimpleBattleLog(UnityAction callback)
    {
    }

    [Token(Token = "0x600D74D")]
    [Address(RVA = "0x1D270E4", Offset = "0x1D270E4", VA = "0x1D270E4")]
    public PlayerCommandSimpleBattleLog()
    {
    }
  }
}
