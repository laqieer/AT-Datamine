// Decompiled with JetBrains decompiler
// Type: Battle.UI.CommandItemPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023B8")]
  public class CommandItemPanel : MonoBehaviour
  {
    [Token(Token = "0x400983C")]
    [FieldOffset(Offset = "0x18")]
    public UITweenGroup tweenGroup;
    [Token(Token = "0x400983D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image itemIcon;
    [Token(Token = "0x400983E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text usesRemaining;
    [Token(Token = "0x400983F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI commandName;
    [Token(Token = "0x4009840")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text durabilityConsumed;
    [Token(Token = "0x4009841")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text numberRemainingAvailableTurns;
    [Token(Token = "0x4009842")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image skillTypeIcon;
    [Token(Token = "0x4009843")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject skillTypeIconGrow;
    [Token(Token = "0x4009844")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x4009845")]
    [FieldOffset(Offset = "0x60")]
    private CommandItemPanelInfo commandItemPanelInfo;

    [Token(Token = "0x17002F21")]
    public Button Button
    {
      [Token(Token = "0x600DA8D"), Address(RVA = "0x22DA4B4", Offset = "0x22DA4B4", VA = "0x22DA4B4")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x17002F22")]
    public CommandItemPanelInfo CommandItemPanelInfo
    {
      [Token(Token = "0x600DA8E"), Address(RVA = "0x22DA4BC", Offset = "0x22DA4BC", VA = "0x22DA4BC")] get
      {
        return (CommandItemPanelInfo) null;
      }
    }

    [Token(Token = "0x600DA8F")]
    [Address(RVA = "0x22DA4C4", Offset = "0x22DA4C4", VA = "0x22DA4C4")]
    public void Set(
      CommandItemPanelInfo commandItemPanelInfo,
      UnityAction<CommandItemPanel> onSelect)
    {
    }

    [Token(Token = "0x600DA90")]
    [Address(RVA = "0x22DA8CC", Offset = "0x22DA8CC", VA = "0x22DA8CC")]
    public void Show(bool isLuaCommand, int selectedIdx)
    {
    }

    [Token(Token = "0x600DA91")]
    [Address(RVA = "0x22DA8F0", Offset = "0x22DA8F0", VA = "0x22DA8F0")]
    private IEnumerator ShowAnimation(bool isLuaCommand, int selectedIdx) => (IEnumerator) null;

    [Token(Token = "0x600DA92")]
    [Address(RVA = "0x22DA974", Offset = "0x22DA974", VA = "0x22DA974")]
    public CommandItemPanel()
    {
    }
  }
}
