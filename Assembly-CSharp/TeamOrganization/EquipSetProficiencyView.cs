// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipSetProficiencyView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007C6")]
  public class EquipSetProficiencyView : MonoBehaviour
  {
    [Token(Token = "0x400245D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject possibleObject;
    [Token(Token = "0x400245E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject textMaxObject;
    [Token(Token = "0x400245F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI textMaxProficText;
    [Token(Token = "0x4002460")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI textMaxProficMaxText;
    [Token(Token = "0x4002461")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject textObject;
    [Token(Token = "0x4002462")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI textProficText;
    [Token(Token = "0x4002463")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI textProficMaxText;
    [Token(Token = "0x4002464")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject noneObject;
    [Token(Token = "0x4002465")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject impossibleObject;

    [Token(Token = "0x6002C0B")]
    [Address(RVA = "0x3877B50", Offset = "0x3877B50", VA = "0x3877B50")]
    private void ResetProficiencyView()
    {
    }

    [Token(Token = "0x6002C0C")]
    [Address(RVA = "0x3877BC4", Offset = "0x3877BC4", VA = "0x3877BC4")]
    public void UpdateProficiencyImpossible()
    {
    }

    [Token(Token = "0x6002C0D")]
    [Address(RVA = "0x3877BEC", Offset = "0x3877BEC", VA = "0x3877BEC")]
    public void UpdateProficiencyNone()
    {
    }

    [Token(Token = "0x6002C0E")]
    [Address(RVA = "0x3877C28", Offset = "0x3877C28", VA = "0x3877C28")]
    public void UpdateProficiency(
      ProficiencyTypeEnum nowProficiency,
      ProficiencyTypeEnum maxProficiency)
    {
    }

    [Token(Token = "0x6002C0F")]
    [Address(RVA = "0x3877D9C", Offset = "0x3877D9C", VA = "0x3877D9C")]
    public EquipSetProficiencyView()
    {
    }
  }
}
