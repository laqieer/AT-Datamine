// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartySlotUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007FB")]
  public class PartySlotUI : MonoBehaviour
  {
    [Token(Token = "0x4002581")]
    public const string ComStyleThumbAssetBundleName = "ui_common_thumb";
    [Token(Token = "0x4002582")]
    public const string ComStyleThumbPrefabName = "Com_StyleThumb";
    [Token(Token = "0x4002583")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected GameObject[] unitTags;
    [Token(Token = "0x4002584")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image unitNumberOnesPlace;
    [Token(Token = "0x4002585")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image unitNumberTensPlace;
    [Token(Token = "0x4002586")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button styleThumbButton;
    [Token(Token = "0x4002587")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform styleThumbParent;
    [Token(Token = "0x4002588")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject[] styleSlotObjs;
    [Token(Token = "0x4002589")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button styleDetailButton;
    [Token(Token = "0x400258A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI unitCharaNameText;
    [Token(Token = "0x400258B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI unitStyleNameText;
    [Token(Token = "0x400258C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject unitEquipmentSetOff;
    [Token(Token = "0x400258D")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject unitEquipmentSetOn;
    [Token(Token = "0x400258E")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Button unitEquipmentSetButton;
    [Token(Token = "0x400258F")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject styleDisableObj;
    [Token(Token = "0x4002590")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject styleAttentionObj;
    [Token(Token = "0x4002591")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text combatPowerText;
    [Token(Token = "0x4002592")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject slotLockObj;
    [Token(Token = "0x4002593")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject slotSelectObj;

    [Token(Token = "0x170006C3")]
    public GameObject[] UnitTags
    {
      [Token(Token = "0x6002D95"), Address(RVA = "0x3A89C2C", Offset = "0x3A89C2C", VA = "0x3A89C2C")] get
      {
        return (GameObject[]) null;
      }
    }

    [Token(Token = "0x170006C4")]
    public Image UnitNumberOnesPlace
    {
      [Token(Token = "0x6002D96"), Address(RVA = "0x3A89C34", Offset = "0x3A89C34", VA = "0x3A89C34")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x170006C5")]
    public Image UnitNumberTensPlace
    {
      [Token(Token = "0x6002D97"), Address(RVA = "0x3A89C3C", Offset = "0x3A89C3C", VA = "0x3A89C3C")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x170006C6")]
    public Button StyleThumbButton
    {
      [Token(Token = "0x6002D98"), Address(RVA = "0x3A89C44", Offset = "0x3A89C44", VA = "0x3A89C44")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x170006C7")]
    public Transform StyleThumbParent
    {
      [Token(Token = "0x6002D99"), Address(RVA = "0x3A89C4C", Offset = "0x3A89C4C", VA = "0x3A89C4C")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x170006C8")]
    public GameObject[] StyleSlotObjs
    {
      [Token(Token = "0x6002D9A"), Address(RVA = "0x3A89C54", Offset = "0x3A89C54", VA = "0x3A89C54")] get
      {
        return (GameObject[]) null;
      }
    }

    [Token(Token = "0x170006C9")]
    public Button StyleDetailButton
    {
      [Token(Token = "0x6002D9B"), Address(RVA = "0x3A89C5C", Offset = "0x3A89C5C", VA = "0x3A89C5C")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x170006CA")]
    public TextMeshProUGUI UnitCharaNameText
    {
      [Token(Token = "0x6002D9C"), Address(RVA = "0x3A89C64", Offset = "0x3A89C64", VA = "0x3A89C64")] get
      {
        return (TextMeshProUGUI) null;
      }
    }

    [Token(Token = "0x170006CB")]
    public TextMeshProUGUI UnitStyleNameText
    {
      [Token(Token = "0x6002D9D"), Address(RVA = "0x3A89C6C", Offset = "0x3A89C6C", VA = "0x3A89C6C")] get
      {
        return (TextMeshProUGUI) null;
      }
    }

    [Token(Token = "0x170006CC")]
    public GameObject UnitEquipmentSetOff
    {
      [Token(Token = "0x6002D9E"), Address(RVA = "0x3A89C74", Offset = "0x3A89C74", VA = "0x3A89C74")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170006CD")]
    public GameObject UnitEquipmentSetOn
    {
      [Token(Token = "0x6002D9F"), Address(RVA = "0x3A89C7C", Offset = "0x3A89C7C", VA = "0x3A89C7C")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170006CE")]
    public Button UnitEquipmentSetButton
    {
      [Token(Token = "0x6002DA0"), Address(RVA = "0x3A89C84", Offset = "0x3A89C84", VA = "0x3A89C84")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x170006CF")]
    public GameObject StyleDisableObj
    {
      [Token(Token = "0x6002DA1"), Address(RVA = "0x3A89C8C", Offset = "0x3A89C8C", VA = "0x3A89C8C")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170006D0")]
    public GameObject StyleAttentionObj
    {
      [Token(Token = "0x6002DA2"), Address(RVA = "0x3A89C94", Offset = "0x3A89C94", VA = "0x3A89C94")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170006D1")]
    public Text CombatPowerText
    {
      [Token(Token = "0x6002DA3"), Address(RVA = "0x3A89C9C", Offset = "0x3A89C9C", VA = "0x3A89C9C")] get
      {
        return (Text) null;
      }
    }

    [Token(Token = "0x170006D2")]
    public GameObject SlotLockObj
    {
      [Token(Token = "0x6002DA4"), Address(RVA = "0x3A89CA4", Offset = "0x3A89CA4", VA = "0x3A89CA4")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170006D3")]
    public GameObject SlotSelectObj
    {
      [Token(Token = "0x6002DA5"), Address(RVA = "0x3A89CAC", Offset = "0x3A89CAC", VA = "0x3A89CAC")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x6002DA6")]
    [Address(RVA = "0x3A89CB4", Offset = "0x3A89CB4", VA = "0x3A89CB4")]
    public string GetUnitNumberImageName(int number) => (string) null;

    [Token(Token = "0x6002DA7")]
    [Address(RVA = "0x3A89D34", Offset = "0x3A89D34", VA = "0x3A89D34")]
    public PartySlotUI()
    {
    }
  }
}
