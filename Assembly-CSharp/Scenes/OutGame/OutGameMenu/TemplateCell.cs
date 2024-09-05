// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.TemplateCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AFE")]
  public class TemplateCell : MonoBehaviour
  {
    [Token(Token = "0x401040C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x401040D")]
    private const string CopyButtonInName = "CopyBtn_In";
    [Token(Token = "0x401040E")]
    private const string ClearButtonInName = "ClearBtn_In";
    [Token(Token = "0x401040F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text templateNumText;
    [Token(Token = "0x4010410")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text templateNameText;
    [Token(Token = "0x4010411")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text templateCombatPowerText;
    [Token(Token = "0x4010412")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text templateNoText;
    [Token(Token = "0x4010413")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button listButton;
    [Token(Token = "0x4010414")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button nameEditButton;
    [Token(Token = "0x4010415")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button deleteButton;
    [Token(Token = "0x4010416")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button cliearButton;
    [Token(Token = "0x4010417")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Button copyButton;
    [Token(Token = "0x4010418")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button pasteButton;
    [Token(Token = "0x4010419")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Button fomationButton;
    [Token(Token = "0x401041A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private PartyCell partyCell;
    [Token(Token = "0x401041B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject[] partySkills;
    [Token(Token = "0x401041C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text[] partySkillNameTexts;
    [Token(Token = "0x401041D")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text[] partySkillLevelTexts;
    [Token(Token = "0x401041F")]
    [FieldOffset(Offset = "0x9C")]
    private int copyTemplateId;
    [Token(Token = "0x4010420")]
    [FieldOffset(Offset = "0xA0")]
    private PartyListBelowScreen partyListBelowScreen;

    [Token(Token = "0x17004BBE")]
    public int TemplateId
    {
      [Token(Token = "0x6017366"), Address(RVA = "0x301C680", Offset = "0x301C680", VA = "0x301C680")] get
      {
        return new int();
      }
      [Token(Token = "0x6017367"), Address(RVA = "0x301C688", Offset = "0x301C688", VA = "0x301C688")] private set
      {
      }
    }

    [Token(Token = "0x6017368")]
    [Address(RVA = "0x3016458", Offset = "0x3016458", VA = "0x3016458")]
    public void InitTeamCell(int index, PartyListBelowScreen partyListBelowScreen)
    {
    }

    [Token(Token = "0x6017369")]
    [Address(RVA = "0x301527C", Offset = "0x301527C", VA = "0x301527C")]
    public void UpdataCell(bool dotInitSkip = false)
    {
    }

    [Token(Token = "0x601736A")]
    [Address(RVA = "0x301C690", Offset = "0x301C690", VA = "0x301C690")]
    public void ChangePaseteActive(bool isActive)
    {
    }

    [Token(Token = "0x601736B")]
    [Address(RVA = "0x301C6B0", Offset = "0x301C6B0", VA = "0x301C6B0")]
    public void OnListButton()
    {
    }

    [Token(Token = "0x601736C")]
    [Address(RVA = "0x301C6D4", Offset = "0x301C6D4", VA = "0x301C6D4")]
    public void OnNameEditButton()
    {
    }

    [Token(Token = "0x601736D")]
    [Address(RVA = "0x301C6F4", Offset = "0x301C6F4", VA = "0x301C6F4")]
    public void OnDeleteButton()
    {
    }

    [Token(Token = "0x601736E")]
    [Address(RVA = "0x301C714", Offset = "0x301C714", VA = "0x301C714")]
    public void OnCliearButton()
    {
    }

    [Token(Token = "0x601736F")]
    [Address(RVA = "0x301C788", Offset = "0x301C788", VA = "0x301C788")]
    public void OnCopyButton()
    {
    }

    [Token(Token = "0x6017370")]
    [Address(RVA = "0x301C800", Offset = "0x301C800", VA = "0x301C800")]
    public void OnPasteButton()
    {
    }

    [Token(Token = "0x6017371")]
    [Address(RVA = "0x301C820", Offset = "0x301C820", VA = "0x301C820")]
    public void OnFomationButton()
    {
    }

    [Token(Token = "0x6017372")]
    [Address(RVA = "0x301C888", Offset = "0x301C888", VA = "0x301C888")]
    public TemplateCell()
    {
    }
  }
}
