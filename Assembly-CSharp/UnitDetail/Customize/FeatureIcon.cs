// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.FeatureIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail.Customize
{
  [Token(Token = "0x20004E3")]
  public class FeatureIcon : MonoBehaviour
  {
    [Token(Token = "0x4001971")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject rootObject;
    [Token(Token = "0x4001972")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image icon;
    [Token(Token = "0x4001973")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text header;

    [Token(Token = "0x6001BAD")]
    [Address(RVA = "0x2C2CE38", Offset = "0x2C2CE38", VA = "0x2C2CE38")]
    public void UpdateIcon(Color color, string text)
    {
    }

    [Token(Token = "0x6001BAE")]
    [Address(RVA = "0x2C2CE88", Offset = "0x2C2CE88", VA = "0x2C2CE88")]
    public void Show()
    {
    }

    [Token(Token = "0x6001BAF")]
    [Address(RVA = "0x2C2CEA8", Offset = "0x2C2CEA8", VA = "0x2C2CEA8")]
    public void Hide()
    {
    }

    [Token(Token = "0x6001BB0")]
    [Address(RVA = "0x2C2CEC8", Offset = "0x2C2CEC8", VA = "0x2C2CEC8")]
    public FeatureIcon()
    {
    }
  }
}
