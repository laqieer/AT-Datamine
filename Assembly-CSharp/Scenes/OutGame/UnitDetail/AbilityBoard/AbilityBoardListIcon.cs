// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardListIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200332A")]
  public class AbilityBoardListIcon : MonoBehaviour
  {
    [Token(Token = "0x400DD52")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject Complete;
    [Token(Token = "0x400DD53")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject NotComplete;
    [Token(Token = "0x400DD54")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject NotRelease_Lock;
    [Token(Token = "0x400DD55")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject[] Icons;
    [Token(Token = "0x400DD56")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject Cursor;

    [Token(Token = "0x60141C2")]
    [Address(RVA = "0x20C7FC4", Offset = "0x20C7FC4", VA = "0x20C7FC4")]
    public void SetState(AbilityBoardListIcon.IconState state)
    {
    }

    [Token(Token = "0x60141C3")]
    [Address(RVA = "0x20C8088", Offset = "0x20C8088", VA = "0x20C8088")]
    public CommonButton GetCommonButton() => (CommonButton) null;

    [Token(Token = "0x60141C4")]
    [Address(RVA = "0x20C80D0", Offset = "0x20C80D0", VA = "0x20C80D0")]
    public void SetIcon(AbilityBoardListIcon.IconType iconType)
    {
    }

    [Token(Token = "0x60141C5")]
    [Address(RVA = "0x20C816C", Offset = "0x20C816C", VA = "0x20C816C")]
    public void ChangeSelectActive(bool isActive)
    {
    }

    [Token(Token = "0x60141C6")]
    [Address(RVA = "0x20C818C", Offset = "0x20C818C", VA = "0x20C818C")]
    public AbilityBoardListIcon()
    {
    }

    [Token(Token = "0x200332B")]
    public enum IconType
    {
      [Token(Token = "0x400DD58")] CLASS,
      [Token(Token = "0x400DD59")] CUSTOM,
      [Token(Token = "0x400DD5A")] STATUS,
      [Token(Token = "0x400DD5B")] UNIQUE,
      [Token(Token = "0x400DD5C")] LOCK,
    }

    [Token(Token = "0x200332C")]
    public enum IconState
    {
      [Token(Token = "0x400DD5E")] NOT_COMPLETE,
      [Token(Token = "0x400DD5F")] COMPLETE,
      [Token(Token = "0x400DD60")] LOCK,
    }
  }
}
