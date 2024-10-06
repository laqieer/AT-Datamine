// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.EquipmentOptionEffectUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Equipment.UI
{
  [Token(Token = "0x20035B1")]
  public class EquipmentOptionEffectUI : MonoBehaviour
  {
    [Token(Token = "0x400E99F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EquipmentOptionEffectGradeUI grade;
    [Token(Token = "0x400E9A0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject locked;

    [Token(Token = "0x6015220")]
    [Address(RVA = "0x4AAC168", Offset = "0x4AAC168", VA = "0x4AAC168")]
    public void SetLocked(bool locked)
    {
    }

    [Token(Token = "0x6015221")]
    [Address(RVA = "0x4AAD404", Offset = "0x4AAD404", VA = "0x4AAD404")]
    public void SetIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x6015222")]
    [Address(RVA = "0x4AAC1BC", Offset = "0x4AAC1BC", VA = "0x4AAC1BC")]
    public void SetTitle(string text)
    {
    }

    [Token(Token = "0x6015223")]
    [Address(RVA = "0x4AAC1E8", Offset = "0x4AAC1E8", VA = "0x4AAC1E8")]
    public void SetValue(float value)
    {
    }

    [Token(Token = "0x6015224")]
    [Address(RVA = "0x4AAD428", Offset = "0x4AAD428", VA = "0x4AAD428")]
    public void SetGradeBG(Sprite gradeBG)
    {
    }

    [Token(Token = "0x6015225")]
    [Address(RVA = "0x4AAD44C", Offset = "0x4AAD44C", VA = "0x4AAD44C")]
    public EquipmentOptionEffectUI()
    {
    }
  }
}
