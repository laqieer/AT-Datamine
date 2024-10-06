// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaChallengeRecoveryItemCost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003129")]
  public class ArenaChallengeRecoveryItemCost : MonoBehaviour
  {
    [Token(Token = "0x400D158")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text itemNameText;
    [Token(Token = "0x400D159")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text possesionText;
    [Token(Token = "0x400D15A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text afterPossesionText;
    [Token(Token = "0x400D15B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Color consumColor;
    [Token(Token = "0x400D15C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Color defaultColor;

    [Token(Token = "0x6013301")]
    [Address(RVA = "0x45E56A4", Offset = "0x45E56A4", VA = "0x45E56A4")]
    public void Setup(string name, long possesion, long afterPossesion)
    {
    }

    [Token(Token = "0x6013302")]
    [Address(RVA = "0x45E5794", Offset = "0x45E5794", VA = "0x45E5794")]
    public ArenaChallengeRecoveryItemCost()
    {
    }
  }
}
