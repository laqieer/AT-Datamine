// Decompiled with JetBrains decompiler
// Type: TeamOrganization.FormationUnitNumDotView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000822")]
  public class FormationUnitNumDotView : MonoBehaviour
  {
    [Token(Token = "0x40026A6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40026A7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject team1Objct;
    [Token(Token = "0x40026A8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject team2Objct;
    [Token(Token = "0x40026A9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject team3Objct;
    [Token(Token = "0x40026AA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject[] dotOnObjcts;

    [Token(Token = "0x6002EBC")]
    [Address(RVA = "0x3E685D8", Offset = "0x3E685D8", VA = "0x3E685D8")]
    public void ChangePartySize(OrganizationTeam.TeamSizeType sizeType)
    {
    }

    [Token(Token = "0x6002EBD")]
    [Address(RVA = "0x3E686A0", Offset = "0x3E686A0", VA = "0x3E686A0")]
    public void ChangeSelectParty(int selectPartyIndex)
    {
    }

    [Token(Token = "0x6002EBE")]
    [Address(RVA = "0x3E6875C", Offset = "0x3E6875C", VA = "0x3E6875C")]
    public void UpdateDot(OrganizationTeam team)
    {
    }

    [Token(Token = "0x6002EBF")]
    [Address(RVA = "0x3E68820", Offset = "0x3E68820", VA = "0x3E68820")]
    public FormationUnitNumDotView()
    {
    }
  }
}
