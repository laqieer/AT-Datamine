// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BattleConfigItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031C8")]
  public class BattleConfigItem : MonoBehaviour
  {
    [Token(Token = "0x400D40E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400D40F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject onActiveButton;
    [Token(Token = "0x400D410")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject onDeactiveButton;
    [Token(Token = "0x400D411")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject onDeactiveOffImg;
    [Token(Token = "0x400D412")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject offActiveButton;
    [Token(Token = "0x400D413")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject offDeactiveButton;
    [Token(Token = "0x400D414")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject offDeactiveOffImg;
    [Token(Token = "0x400D415")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text titleText;
    [Token(Token = "0x400D417")]
    [FieldOffset(Offset = "0x60")]
    private bool isOn;
    [Token(Token = "0x400D418")]
    [FieldOffset(Offset = "0x61")]
    private bool isActive;

    [Token(Token = "0x170040E2")]
    private Action<bool> OnSelect
    {
      [Token(Token = "0x60136D4"), Address(RVA = "0x4E09970", Offset = "0x4E09970", VA = "0x4E09970")] get
      {
        return (Action<bool>) null;
      }
      [Token(Token = "0x60136D5"), Address(RVA = "0x4E09978", Offset = "0x4E09978", VA = "0x4E09978")] set
      {
      }
    }

    [Token(Token = "0x60136D6")]
    [Address(RVA = "0x4E09980", Offset = "0x4E09980", VA = "0x4E09980")]
    public void Initialize(bool isOnActive, Action<bool> onSelectAction)
    {
    }

    [Token(Token = "0x60136D7")]
    [Address(RVA = "0x4E09AB0", Offset = "0x4E09AB0", VA = "0x4E09AB0")]
    public void OnClickToOnButton()
    {
    }

    [Token(Token = "0x60136D8")]
    [Address(RVA = "0x4E09AF8", Offset = "0x4E09AF8", VA = "0x4E09AF8")]
    public void OnClickToOffButton()
    {
    }

    [Token(Token = "0x60136D9")]
    [Address(RVA = "0x4E09B3C", Offset = "0x4E09B3C", VA = "0x4E09B3C")]
    public void ChangeActive(bool isActive)
    {
    }

    [Token(Token = "0x60136DA")]
    [Address(RVA = "0x4E09998", Offset = "0x4E09998", VA = "0x4E09998")]
    private void ChangeButtonActive()
    {
    }

    [Token(Token = "0x60136DB")]
    [Address(RVA = "0x4E09C98", Offset = "0x4E09C98", VA = "0x4E09C98")]
    public BattleConfigItem()
    {
    }
  }
}
