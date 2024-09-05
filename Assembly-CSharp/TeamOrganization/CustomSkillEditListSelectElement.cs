// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CustomSkillEditListSelectElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200079E")]
  public class CustomSkillEditListSelectElement : MonoBehaviour
  {
    [Token(Token = "0x400237C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CustomSkillEditListSelect[] thumbList;

    [Token(Token = "0x6002AF6")]
    [Address(RVA = "0x350561C", Offset = "0x350561C", VA = "0x350561C")]
    public void Initialize(
      int idx,
      CustomSkillEditListPopup.eCustomSkillListKind kind,
      CustomSkillEditListPopup customSkillEditListPopup,
      Action<int, CustomSkillEditListPopup.eCustomSkillListKind> onChange,
      Action onRemove)
    {
    }

    [Token(Token = "0x6002AF7")]
    [Address(RVA = "0x35053D8", Offset = "0x35053D8", VA = "0x35053D8")]
    public void SetActive(bool requestActive)
    {
    }

    [Token(Token = "0x6002AF8")]
    [Address(RVA = "0x3504DD0", Offset = "0x3504DD0", VA = "0x3504DD0")]
    public void SetThumbButtonOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6002AF9")]
    [Address(RVA = "0x3506C58", Offset = "0x3506C58", VA = "0x3506C58")]
    public CustomSkillEditListSelect GetSelectItem(int idx) => (CustomSkillEditListSelect) null;

    [Token(Token = "0x6002AFA")]
    [Address(RVA = "0x3509538", Offset = "0x3509538", VA = "0x3509538")]
    public CustomSkillEditListSelectElement()
    {
    }
  }
}
