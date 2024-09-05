// Decompiled with JetBrains decompiler
// Type: TeamOrganization.TemplateListCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using TMPro;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200082F")]
  public class TemplateListCell : MonoBehaviour
  {
    [Token(Token = "0x40026F6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI templateNo;
    [Token(Token = "0x40026F7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI templateName;
    [Token(Token = "0x40026F8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI templateCombat;
    [Token(Token = "0x40026F9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnitNodeDotCell unitNodeDotCell;
    [Token(Token = "0x40026FA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject selectObj;
    [Token(Token = "0x40026FD")]
    [FieldOffset(Offset = "0x48")]
    private TemplateListPopup templateListPopup;

    [Token(Token = "0x170006F0")]
    public int templateIndex
    {
      [Token(Token = "0x6002F18"), Address(RVA = "0x3E6BB38", Offset = "0x3E6BB38", VA = "0x3E6BB38")] get
      {
        return new int();
      }
      [Token(Token = "0x6002F19"), Address(RVA = "0x3E6BB40", Offset = "0x3E6BB40", VA = "0x3E6BB40")] private set
      {
      }
    }

    [Token(Token = "0x170006F1")]
    public int templateDotStyleId
    {
      [Token(Token = "0x6002F1A"), Address(RVA = "0x3E6BB48", Offset = "0x3E6BB48", VA = "0x3E6BB48")] get
      {
        return new int();
      }
      [Token(Token = "0x6002F1B"), Address(RVA = "0x3E6BB50", Offset = "0x3E6BB50", VA = "0x3E6BB50")] private set
      {
      }
    }

    [Token(Token = "0x6002F1C")]
    [Address(RVA = "0x3E6BB58", Offset = "0x3E6BB58", VA = "0x3E6BB58")]
    public void Initialized(TemplateListPopup popup, int index, bool isSelect)
    {
    }

    [Token(Token = "0x6002F1D")]
    [Address(RVA = "0x3E6C0C4", Offset = "0x3E6C0C4", VA = "0x3E6C0C4")]
    public void InitPartyCell(bool dotInitSkip)
    {
    }

    [Token(Token = "0x6002F1E")]
    [Address(RVA = "0x3E6C0F0", Offset = "0x3E6C0F0", VA = "0x3E6C0F0")]
    public void OnSelect()
    {
    }

    [Token(Token = "0x6002F1F")]
    [Address(RVA = "0x3E6C1A4", Offset = "0x3E6C1A4", VA = "0x3E6C1A4")]
    public void SetSelectActive(bool isActive)
    {
    }

    [Token(Token = "0x6002F20")]
    [Address(RVA = "0x3E6C1C4", Offset = "0x3E6C1C4", VA = "0x3E6C1C4")]
    public TemplateListCell()
    {
    }
  }
}
