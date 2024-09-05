// Decompiled with JetBrains decompiler
// Type: Battle.UI.SkillButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023B6")]
  public class SkillButton : MonoBehaviour
  {
    [Token(Token = "0x400982D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400982E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image itemIcon;
    [Token(Token = "0x400982F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image weaponIcon;
    [Token(Token = "0x4009830")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI skillName;
    [Token(Token = "0x4009831")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI selectedSkillName;
    [Token(Token = "0x4009832")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text durabilityConsumed;
    [Token(Token = "0x4009833")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text usesRemaining;
    [Token(Token = "0x4009834")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text numberRemainingAvailableTurns;
    [Token(Token = "0x4009835")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x4009836")]
    [FieldOffset(Offset = "0x60")]
    private SkillButtonInfo info;

    [Token(Token = "0x17002F1D")]
    public CommonButton Button
    {
      [Token(Token = "0x600DA81"), Address(RVA = "0x22D9CF0", Offset = "0x22D9CF0", VA = "0x22D9CF0")] get
      {
        return (CommonButton) null;
      }
    }

    [Token(Token = "0x17002F1E")]
    public SkillButtonInfo Info
    {
      [Token(Token = "0x600DA82"), Address(RVA = "0x22D9CF8", Offset = "0x22D9CF8", VA = "0x22D9CF8")] get
      {
        return (SkillButtonInfo) null;
      }
    }

    [Token(Token = "0x600DA83")]
    [Address(RVA = "0x22D9D00", Offset = "0x22D9D00", VA = "0x22D9D00")]
    public void Set(SkillButtonInfo info)
    {
    }

    [Token(Token = "0x600DA84")]
    [Address(RVA = "0x22DA098", Offset = "0x22DA098", VA = "0x22DA098")]
    public void ShowAnimation(bool isLuaCommand, int selectedId)
    {
    }

    [Token(Token = "0x600DA85")]
    [Address(RVA = "0x22DA0BC", Offset = "0x22DA0BC", VA = "0x22DA0BC")]
    private IEnumerator IEShowAnimation(bool isLuaCommand, int selectedId) => (IEnumerator) null;

    [Token(Token = "0x600DA86")]
    [Address(RVA = "0x22DA168", Offset = "0x22DA168", VA = "0x22DA168")]
    public SkillButton()
    {
    }
  }
}
