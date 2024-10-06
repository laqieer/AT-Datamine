// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EquipmentDetail.EquipmentRein_Btn_MainM
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.EquipmentDetail
{
  [Token(Token = "0x2003686")]
  public class EquipmentRein_Btn_MainM : MonoBehaviour
  {
    [Token(Token = "0x400ED33")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text nameDisp;
    [Token(Token = "0x400ED34")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text numDisp;
    [Token(Token = "0x400ED35")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text expDisp;
    [Token(Token = "0x400ED36")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton minusButton;
    [Token(Token = "0x400ED37")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton plusButton;
    [Token(Token = "0x400ED38")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Slider selectSlider;
    [Token(Token = "0x400ED39")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject maxCheckBox;
    [Token(Token = "0x400ED3A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400ED3B")]
    [FieldOffset(Offset = "0x60")]
    public int itemID;
    [Token(Token = "0x400ED3C")]
    [FieldOffset(Offset = "0x64")]
    public int itemNum;
    [Token(Token = "0x400ED3D")]
    [FieldOffset(Offset = "0x68")]
    private int selectNum;
    [Token(Token = "0x400ED3E")]
    [FieldOffset(Offset = "0x6C")]
    public float expNum;
    [Token(Token = "0x400ED3F")]
    [FieldOffset(Offset = "0x70")]
    public bool checkMax;
    [Token(Token = "0x400ED40")]
    [FieldOffset(Offset = "0x78")]
    public EquipmentRein_Btn_MainM.CheckPlus checkPlus;
    [Token(Token = "0x400ED41")]
    [FieldOffset(Offset = "0x80")]
    private bool checkNum;
    [Token(Token = "0x400ED42")]
    [FieldOffset(Offset = "0x81")]
    private bool expDispInteger;

    [Token(Token = "0x14000219")]
    public event Action<float> callback
    {
      [Token(Token = "0x6015737"), Address(RVA = "0x18E4F24", Offset = "0x18E4F24", VA = "0x18E4F24")] add
      {
      }
      [Token(Token = "0x6015738"), Address(RVA = "0x18E4FD4", Offset = "0x18E4FD4", VA = "0x18E4FD4")] remove
      {
      }
    }

    [Token(Token = "0x6015739")]
    [Address(RVA = "0x18E5084", Offset = "0x18E5084", VA = "0x18E5084")]
    private void Start()
    {
    }

    [Token(Token = "0x601573A")]
    [Address(RVA = "0x18E5304", Offset = "0x18E5304", VA = "0x18E5304")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x601573B")]
    [Address(RVA = "0x18E5328", Offset = "0x18E5328", VA = "0x18E5328")]
    public void InitParam(int id, int num, float exp, string name, bool expInteger = true)
    {
    }

    [Token(Token = "0x601573C")]
    [Address(RVA = "0x18E53D4", Offset = "0x18E53D4", VA = "0x18E53D4")]
    public void SetParam(int select)
    {
    }

    [Token(Token = "0x601573D")]
    [Address(RVA = "0x18E5448", Offset = "0x18E5448", VA = "0x18E5448")]
    public void OnMaxCheckClick()
    {
    }

    [Token(Token = "0x601573E")]
    [Address(RVA = "0x18E5218", Offset = "0x18E5218", VA = "0x18E5218")]
    public void SetExp()
    {
    }

    [Token(Token = "0x601573F")]
    [Address(RVA = "0x18E547C", Offset = "0x18E547C", VA = "0x18E547C")]
    public float GetExp() => new float();

    [Token(Token = "0x6015740")]
    [Address(RVA = "0x18E548C", Offset = "0x18E548C", VA = "0x18E548C")]
    public int GetNum() => new int();

    [Token(Token = "0x6015741")]
    [Address(RVA = "0x18E5494", Offset = "0x18E5494", VA = "0x18E5494")]
    public void OnValueChanged()
    {
    }

    [Token(Token = "0x6015742")]
    [Address(RVA = "0x18E553C", Offset = "0x18E553C", VA = "0x18E553C")]
    private void Update()
    {
    }

    [Token(Token = "0x6015743")]
    [Address(RVA = "0x18E5668", Offset = "0x18E5668", VA = "0x18E5668")]
    public EquipmentRein_Btn_MainM()
    {
    }

    [Token(Token = "0x2003687")]
    public delegate bool CheckPlus(int add);
  }
}
