// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.WeaponsEquipDetailUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnitEquipmentView.UI.EquipDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x200045E")]
  public class WeaponsEquipDetailUI : MonoBehaviour
  {
    [Token(Token = "0x4001802")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001803")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private WeaponsEquipDetailUI.AnimationGroups animationGroups;
    [Token(Token = "0x4001804")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button closeBtn;
    [Token(Token = "0x4001805")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private EquipmentInfo equipmentInfo;
    [Token(Token = "0x4001806")]
    [FieldOffset(Offset = "0x38")]
    private WeaponsEquipDetailUI.IEvent receiver;
    [Token(Token = "0x4001807")]
    [FieldOffset(Offset = "0x40")]
    private DurabilityFormatter durabilityFormatter;
    [Token(Token = "0x4001808")]
    [FieldOffset(Offset = "0x48")]
    private IEnumerator routine;

    [Token(Token = "0x60018C3")]
    [Address(RVA = "0x24921B8", Offset = "0x24921B8", VA = "0x24921B8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60018C4")]
    [Address(RVA = "0x24926C4", Offset = "0x24926C4", VA = "0x24926C4")]
    public void Register(WeaponsEquipDetailUI.IEvent receiver)
    {
    }

    [Token(Token = "0x60018C5")]
    [Address(RVA = "0x24926CC", Offset = "0x24926CC", VA = "0x24926CC")]
    public void In()
    {
    }

    [Token(Token = "0x60018C6")]
    [Address(RVA = "0x24927B0", Offset = "0x24927B0", VA = "0x24927B0")]
    public void Out()
    {
    }

    [Token(Token = "0x60018C7")]
    [Address(RVA = "0x249282C", Offset = "0x249282C", VA = "0x249282C")]
    public void Set(ItemDetailData itemData)
    {
    }

    [Token(Token = "0x60018C8")]
    [Address(RVA = "0x2492EA0", Offset = "0x2492EA0", VA = "0x2492EA0")]
    private void Start()
    {
    }

    [Token(Token = "0x60018C9")]
    [Address(RVA = "0x2492748", Offset = "0x2492748", VA = "0x2492748")]
    private IEnumerator ResizeOnFinishedInAnimation() => (IEnumerator) null;

    [Token(Token = "0x60018CA")]
    [Address(RVA = "0x2492F5C", Offset = "0x2492F5C", VA = "0x2492F5C")]
    private void Update()
    {
    }

    [Token(Token = "0x60018CB")]
    [Address(RVA = "0x2493004", Offset = "0x2493004", VA = "0x2493004")]
    private void OnClose()
    {
    }

    [Token(Token = "0x60018CC")]
    [Address(RVA = "0x24930A4", Offset = "0x24930A4", VA = "0x24930A4")]
    public WeaponsEquipDetailUI()
    {
    }

    [Token(Token = "0x200045F")]
    [Serializable]
    private class AnimationGroups
    {
      [Token(Token = "0x4001809")]
      [FieldOffset(Offset = "0x10")]
      public string In;
      [Token(Token = "0x400180A")]
      [FieldOffset(Offset = "0x18")]
      public string Out;

      [Token(Token = "0x60018CD")]
      [Address(RVA = "0x2493108", Offset = "0x2493108", VA = "0x2493108")]
      public AnimationGroups()
      {
      }
    }

    [Token(Token = "0x2000460")]
    public interface IEvent
    {
      [Token(Token = "0x60018CE")]
      void OnClose();
    }
  }
}
