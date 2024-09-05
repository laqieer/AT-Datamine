// Decompiled with JetBrains decompiler
// Type: Battle.DuelUIGradientSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002286")]
  public class DuelUIGradientSwitcher : MonoBehaviour
  {
    [Token(Token = "0x4009194")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UIGradient.UIGradient _gradientAlly;
    [Token(Token = "0x4009195")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UIGradient.UIGradient _gradientGuest;
    [Token(Token = "0x4009196")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UIGradient.UIGradient _gradientEnemy;
    [Token(Token = "0x4009197")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UIGradient.UIGradient _gradientAnotherForce;

    [Token(Token = "0x600D275")]
    [Address(RVA = "0x1961434", Offset = "0x1961434", VA = "0x1961434")]
    public void TurnColorByForceType(ForceTypeEnum forceTypeEnum)
    {
    }

    [Token(Token = "0x600D276")]
    [Address(RVA = "0x19615D8", Offset = "0x19615D8", VA = "0x19615D8")]
    public DuelUIGradientSwitcher()
    {
    }
  }
}
