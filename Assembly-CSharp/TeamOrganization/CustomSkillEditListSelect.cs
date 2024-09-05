// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CustomSkillEditListSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200079D")]
  public class CustomSkillEditListSelect : MonoBehaviour
  {
    [Token(Token = "0x4002374")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002375")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button removeButton;
    [Token(Token = "0x4002376")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button changeButton;
    [Token(Token = "0x4002377")]
    [FieldOffset(Offset = "0x30")]
    public bool use;
    [Token(Token = "0x400237A")]
    [FieldOffset(Offset = "0x40")]
    private Action<int, CustomSkillEditListPopup.eCustomSkillListKind> onChangeAction;
    [Token(Token = "0x400237B")]
    [FieldOffset(Offset = "0x48")]
    private Action onRemoveAction;

    [Token(Token = "0x17000670")]
    public int itemIndex
    {
      [Token(Token = "0x6002AE8"), Address(RVA = "0x35091DC", Offset = "0x35091DC", VA = "0x35091DC")] get
      {
        return new int();
      }
      [Token(Token = "0x6002AE9"), Address(RVA = "0x35091E4", Offset = "0x35091E4", VA = "0x35091E4")] private set
      {
      }
    }

    [Token(Token = "0x17000671")]
    public CustomSkillEditListPopup.eCustomSkillListKind itemKind
    {
      [Token(Token = "0x6002AEA"), Address(RVA = "0x35091EC", Offset = "0x35091EC", VA = "0x35091EC")] get
      {
        return new CustomSkillEditListPopup.eCustomSkillListKind();
      }
      [Token(Token = "0x6002AEB"), Address(RVA = "0x35091F4", Offset = "0x35091F4", VA = "0x35091F4")] private set
      {
      }
    }

    [Token(Token = "0x6002AEC")]
    [Address(RVA = "0x35091FC", Offset = "0x35091FC", VA = "0x35091FC")]
    public void Initialize(
      int idx,
      CustomSkillEditListPopup.eCustomSkillListKind kind,
      Action<int, CustomSkillEditListPopup.eCustomSkillListKind> onChangeAction,
      Action onRemoveAction)
    {
    }

    [Token(Token = "0x6002AED")]
    [Address(RVA = "0x3509344", Offset = "0x3509344", VA = "0x3509344")]
    public void SetThumbButtonOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6002AEE")]
    [Address(RVA = "0x3509388", Offset = "0x3509388", VA = "0x3509388")]
    public void ChangeSelectButton(bool isRemove)
    {
    }

    [Token(Token = "0x6002AEF")]
    [Address(RVA = "0x3503B7C", Offset = "0x3503B7C", VA = "0x3503B7C")]
    public void SelectOn(bool isRemove)
    {
    }

    [Token(Token = "0x6002AF0")]
    [Address(RVA = "0x35038C4", Offset = "0x35038C4", VA = "0x35038C4")]
    public void SelectOff()
    {
    }

    [Token(Token = "0x6002AF1")]
    [Address(RVA = "0x35094B0", Offset = "0x35094B0", VA = "0x35094B0")]
    public void OnChangeButton()
    {
    }

    [Token(Token = "0x6002AF2")]
    [Address(RVA = "0x35094D0", Offset = "0x35094D0", VA = "0x35094D0")]
    public void OnRemoveButton()
    {
    }

    [Token(Token = "0x6002AF3")]
    [Address(RVA = "0x35094EC", Offset = "0x35094EC", VA = "0x35094EC")]
    public CustomSkillEditListSelect()
    {
    }
  }
}
