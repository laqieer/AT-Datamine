// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.WeaponsEquipChangeUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnitEquipmentView.UI.EquipChange;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x200045B")]
  public class WeaponsEquipChangeUI : MonoBehaviour
  {
    [Token(Token = "0x40017F4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x40017F5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AnimationController animationController;
    [Token(Token = "0x40017F6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CompareEquipInfoUI beforeItemUI;
    [Token(Token = "0x40017F7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CompareEquipInfoUI afterItemUI;
    [Token(Token = "0x40017F8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private StatusSet basicStatusSet;
    [Token(Token = "0x40017F9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private StatusSet correctStatusSet;
    [Token(Token = "0x40017FA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button cancelBtn;
    [Token(Token = "0x40017FB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button executeBtn;
    [Token(Token = "0x40017FC")]
    [FieldOffset(Offset = "0x58")]
    private WeaponsEquipChangeUI.IUIEvent eventReceiver;
    [Token(Token = "0x40017FD")]
    [FieldOffset(Offset = "0x60")]
    private IEnumerator routineResizeOnDialogOpened;
    [Token(Token = "0x40017FE")]
    [FieldOffset(Offset = "0x68")]
    private DurabilityFormatter durabilityFormatter;

    [Token(Token = "0x60018AF")]
    [Address(RVA = "0x2491714", Offset = "0x2491714", VA = "0x2491714")]
    private void Start()
    {
    }

    [Token(Token = "0x60018B0")]
    [Address(RVA = "0x2491804", Offset = "0x2491804", VA = "0x2491804")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x60018B1")]
    [Address(RVA = "0x24918A4", Offset = "0x24918A4", VA = "0x24918A4")]
    private void OnExecute()
    {
    }

    [Token(Token = "0x60018B2")]
    [Address(RVA = "0x2491948", Offset = "0x2491948", VA = "0x2491948")]
    public void Register(WeaponsEquipChangeUI.IUIEvent eventReceiver)
    {
    }

    [Token(Token = "0x60018B3")]
    [Address(RVA = "0x2491950", Offset = "0x2491950", VA = "0x2491950")]
    public void In()
    {
    }

    [Token(Token = "0x60018B4")]
    [Address(RVA = "0x2491A20", Offset = "0x2491A20", VA = "0x2491A20")]
    public void Out()
    {
    }

    [Token(Token = "0x60018B5")]
    [Address(RVA = "0x2491B80", Offset = "0x2491B80", VA = "0x2491B80")]
    public void Apply(ItemDetailData before, ItemDetailData after)
    {
    }

    [Token(Token = "0x60018B6")]
    [Address(RVA = "0x2491CC0", Offset = "0x2491CC0", VA = "0x2491CC0")]
    private void ApplyEasyData(ItemDetailData item, CompareEquipInfoUI ui)
    {
    }

    [Token(Token = "0x60018B7")]
    [Address(RVA = "0x2491F38", Offset = "0x2491F38", VA = "0x2491F38")]
    private void Update()
    {
    }

    [Token(Token = "0x60018B8")]
    [Address(RVA = "0x2491F3C", Offset = "0x2491F3C", VA = "0x2491F3C")]
    private void RunResizeOnDialogOpened()
    {
    }

    [Token(Token = "0x60018B9")]
    [Address(RVA = "0x24919B8", Offset = "0x24919B8", VA = "0x24919B8")]
    private IEnumerator ResizeOnDialogOpened() => (IEnumerator) null;

    [Token(Token = "0x60018BA")]
    [Address(RVA = "0x249200C", Offset = "0x249200C", VA = "0x249200C")]
    public WeaponsEquipChangeUI()
    {
    }

    [Token(Token = "0x200045C")]
    public interface IUIEvent
    {
      [Token(Token = "0x60018BB")]
      void OnCancel();

      [Token(Token = "0x60018BC")]
      void OnExecute();
    }
  }
}
