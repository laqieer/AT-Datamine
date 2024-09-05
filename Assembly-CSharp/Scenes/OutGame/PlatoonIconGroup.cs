// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlatoonIconGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TeamOrganization;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003225")]
  public class PlatoonIconGroup : MonoBehaviour
  {
    [Token(Token = "0x400D635")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image[] platoonIcons;

    [Token(Token = "0x6013905")]
    [Address(RVA = "0x49C8E80", Offset = "0x49C8E80", VA = "0x49C8E80")]
    public void SetData(OrganizationParty[] partyDatas, int battleMenberNum)
    {
    }

    [Token(Token = "0x6013906")]
    [Address(RVA = "0x49C97A8", Offset = "0x49C97A8", VA = "0x49C97A8")]
    public void SetDataArena(OrganizationParty[] partyDatas, int battleMenberNum)
    {
    }

    [Token(Token = "0x6013907")]
    [Address(RVA = "0x49CAD88", Offset = "0x49CAD88", VA = "0x49CAD88")]
    public PlatoonIconGroup()
    {
    }
  }
}
