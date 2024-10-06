// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003327")]
  public class AbilityBoardIcon : MonoBehaviour
  {
    [Token(Token = "0x400DD40")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Complete;
    [Token(Token = "0x400DD41")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject NotComplete;
    [Token(Token = "0x400DD42")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject NotRelease_Lock;
    [Token(Token = "0x400DD43")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject Material_Shortage;
    [Token(Token = "0x400DD44")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject Icon;
    [Token(Token = "0x400DD45")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject Lock;
    [Token(Token = "0x400DD46")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image IconImage;
    [Token(Token = "0x400DD47")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject Cursor;
    [Token(Token = "0x400DD48")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text Txt_NodeName;

    [Token(Token = "0x60141B2")]
    [Address(RVA = "0x20C7E38", Offset = "0x20C7E38", VA = "0x20C7E38")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x60141B3")]
    [Address(RVA = "0x20C3738", Offset = "0x20C3738", VA = "0x20C3738")]
    public void SetActiveText(bool isEnabled)
    {
    }

    [Token(Token = "0x60141B4")]
    [Address(RVA = "0x20C3584", Offset = "0x20C3584", VA = "0x20C3584")]
    public void SetState(AbilityBoardIcon.IconState state)
    {
    }

    [Token(Token = "0x60141B5")]
    [Address(RVA = "0x20C7E5C", Offset = "0x20C7E5C", VA = "0x20C7E5C")]
    public CommonButton GetCommonButton() => (CommonButton) null;

    [Token(Token = "0x60141B6")]
    [Address(RVA = "0x20C371C", Offset = "0x20C371C", VA = "0x20C371C")]
    public void SetIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x60141B7")]
    [Address(RVA = "0x20C7EA4", Offset = "0x20C7EA4", VA = "0x20C7EA4")]
    public void ChangeSelectActive(bool isActive)
    {
    }

    [Token(Token = "0x60141B8")]
    [Address(RVA = "0x20C7EC4", Offset = "0x20C7EC4", VA = "0x20C7EC4")]
    public AbilityBoardIcon()
    {
    }

    [Token(Token = "0x2003328")]
    public enum IconState
    {
      [Token(Token = "0x400DD4A")] NOT_COMPLETE,
      [Token(Token = "0x400DD4B")] COMPLETE,
      [Token(Token = "0x400DD4C")] LOCK,
      [Token(Token = "0x400DD4D")] MATERIAL_SHORTAGE,
    }
  }
}
