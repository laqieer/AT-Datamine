// Decompiled with JetBrains decompiler
// Type: TeamOrganization.TeamSelectionCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000824")]
  public class TeamSelectionCell : MonoBehaviour
  {
    [Token(Token = "0x40026AE")]
    private const string UnitNumberAssetBundleName = "ui_page_partylist_texture";
    [Token(Token = "0x40026AF")]
    private const string UnitNumberAssetName = "Img_Num_UnitNumber_Atlas";
    [Token(Token = "0x40026B0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image teamNumImage;
    [Token(Token = "0x40026B1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject teamNum10Obj;
    [Token(Token = "0x40026B2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image teamNumImage1;
    [Token(Token = "0x40026B3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image teamNumImage2;
    [Token(Token = "0x40026B4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI teamCombatPowerText;
    [Token(Token = "0x40026B5")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text teamNameText;
    [Token(Token = "0x40026B6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject teamSelectObj;
    [Token(Token = "0x40026B7")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject teamDisableObj;
    [Token(Token = "0x40026B8")]
    [FieldOffset(Offset = "0x58")]
    public Action<int> callbackChange;
    [Token(Token = "0x40026B9")]
    [FieldOffset(Offset = "0x60")]
    private int teamIndex;
    [Token(Token = "0x40026BA")]
    [FieldOffset(Offset = "0x64")]
    private bool isSelect;
    [Token(Token = "0x40026BB")]
    [FieldOffset(Offset = "0x65")]
    private bool isDisable;

    [Token(Token = "0x170006E8")]
    public bool IsUse
    {
      [Token(Token = "0x6002ECA"), Address(RVA = "0x3E68ED4", Offset = "0x3E68ED4", VA = "0x3E68ED4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002ECB"), Address(RVA = "0x3E68EDC", Offset = "0x3E68EDC", VA = "0x3E68EDC")] private set
      {
      }
    }

    [Token(Token = "0x6002ECC")]
    [Address(RVA = "0x3E68EE8", Offset = "0x3E68EE8", VA = "0x3E68EE8")]
    public void UpdateCell(
      int teamIndex,
      int combatPower,
      string teamName,
      bool isSelect,
      bool isDisable,
      Action<int> selectAction)
    {
    }

    [Token(Token = "0x6002ECD")]
    [Address(RVA = "0x3E69244", Offset = "0x3E69244", VA = "0x3E69244")]
    public void CellOff()
    {
    }

    [Token(Token = "0x6002ECE")]
    [Address(RVA = "0x3E68FE4", Offset = "0x3E68FE4", VA = "0x3E68FE4")]
    private void UpdateUnitNumber(int teamIndex)
    {
    }

    [Token(Token = "0x6002ECF")]
    [Address(RVA = "0x3E6926C", Offset = "0x3E6926C", VA = "0x3E6926C")]
    public void OnSelectButton()
    {
    }

    [Token(Token = "0x6002ED0")]
    [Address(RVA = "0x3E69294", Offset = "0x3E69294", VA = "0x3E69294")]
    public TeamSelectionCell()
    {
    }
  }
}
