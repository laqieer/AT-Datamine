// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipParameterViewBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007BF")]
  public abstract class EquipParameterViewBase : MonoBehaviour
  {
    [Token(Token = "0x400242A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI InfoText;
    [Token(Token = "0x400242B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Color NomalTextColor;
    [Token(Token = "0x400242C")]
    [FieldOffset(Offset = "0x10")]
    public static readonly Color DownTextColor;
    [Token(Token = "0x400242D")]
    [FieldOffset(Offset = "0x20")]
    public static readonly Color UpTextColor;
    [Token(Token = "0x400242E")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<UniqueID, List<EquipParameterViewBase.EquipParameterInfo>> infoDic;

    [Token(Token = "0x6002BD8")]
    [Address(RVA = "0x3874848", Offset = "0x3874848", VA = "0x3874848")]
    public void InitInfo(
      Dictionary<UniqueID, List<EquipParameterViewBase.EquipParameterInfo>> data)
    {
    }

    [Token(Token = "0x6002BD9")]
    [Address(RVA = "0x386D300", Offset = "0x386D300", VA = "0x386D300")]
    public void UpdateSelectParameter(
      bool isSelectEquip,
      Equipment equipment,
      Equipment selectEquipment,
      Style selectStyle)
    {
    }

    [Token(Token = "0x6002BDA")]
    public abstract void ResetEquipParameter();

    [Token(Token = "0x6002BDB")]
    protected abstract void UpdateEquipParameter(Equipment equipment, Style selectStyle);

    [Token(Token = "0x6002BDC")]
    protected abstract void UpdateEquipParameter(
      Equipment baseEquipment,
      Equipment selectEquipment,
      Style selectStyle);

    [Token(Token = "0x6002BDD")]
    [Address(RVA = "0x3874850", Offset = "0x3874850", VA = "0x3874850")]
    public static Color GetParameterColor(int baseValue, int selectValue) => new Color();

    [Token(Token = "0x6002BDE")]
    [Address(RVA = "0x3874918", Offset = "0x3874918", VA = "0x3874918")]
    protected EquipParameterViewBase()
    {
    }

    [Token(Token = "0x6002BDF")]
    [Address(RVA = "0x3874920", Offset = "0x3874920", VA = "0x3874920")]
    static EquipParameterViewBase()
    {
    }

    [Token(Token = "0x20007C0")]
    public class EquipParameterInfo
    {
      [Token(Token = "0x400242F")]
      [FieldOffset(Offset = "0x10")]
      public int Index;
      [Token(Token = "0x4002430")]
      [FieldOffset(Offset = "0x18")]
      public string CharaName;
      [Token(Token = "0x4002431")]
      [FieldOffset(Offset = "0x20")]
      public int StyleID;

      [Token(Token = "0x6002BE0")]
      [Address(RVA = "0x3874994", Offset = "0x3874994", VA = "0x3874994")]
      public EquipParameterInfo()
      {
      }
    }
  }
}
