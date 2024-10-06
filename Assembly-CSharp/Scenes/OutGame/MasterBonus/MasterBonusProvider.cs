// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.MasterBonusProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003520")]
  public class MasterBonusProvider
  {
    [Token(Token = "0x400E725")]
    [FieldOffset(Offset = "0x10")]
    private MasterBonusPopup popup;
    [Token(Token = "0x400E726")]
    [FieldOffset(Offset = "0x18")]
    private bool InProcessOpenOrClose;

    [Token(Token = "0x1700450C")]
    public bool IsOpened
    {
      [Token(Token = "0x6014D55"), Address(RVA = "0x1B3EC48", Offset = "0x1B3EC48", VA = "0x1B3EC48")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6014D56")]
    [Address(RVA = "0x1B3ECD0", Offset = "0x1B3ECD0", VA = "0x1B3ECD0")]
    public IEnumerator OnMasterBonusButton(
      MasterBonusPopupGenerator generator,
      MasterBonusDetailPopupGenerator masterBonusDetailPopupGenerator,
      ContainerElementMasterBonusGenerator elementMasterBonusListGenerator,
      RectTransform headerTransform)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014D57")]
    [Address(RVA = "0x1B3ED88", Offset = "0x1B3ED88", VA = "0x1B3ED88")]
    public IEnumerator OnMasterBonusButton(
      MasterBonusPopupGenerator generator,
      MasterBonusDetailPopupGenerator masterBonusDetailPopupGenerator,
      ContainerWeaponMasterBonusGenerator weaponMasterBonusListGenerator,
      RectTransform headerTransform)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014D58")]
    [Address(RVA = "0x1B3EE40", Offset = "0x1B3EE40", VA = "0x1B3EE40")]
    private void OnClickClose(MasterBonusPopup masterBonusPopup)
    {
    }

    [Token(Token = "0x6014D59")]
    [Address(RVA = "0x1B3EEEC", Offset = "0x1B3EEEC", VA = "0x1B3EEEC")]
    public void Close()
    {
    }

    [Token(Token = "0x6014D5A")]
    [Address(RVA = "0x1B3EF74", Offset = "0x1B3EF74", VA = "0x1B3EF74")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6014D5B")]
    [Address(RVA = "0x1B3F018", Offset = "0x1B3F018", VA = "0x1B3F018")]
    private void PlayInAnim()
    {
    }

    [Token(Token = "0x6014D5C")]
    [Address(RVA = "0x1B3F0F8", Offset = "0x1B3F0F8", VA = "0x1B3F0F8")]
    private void PlayOutAnim()
    {
    }

    [Token(Token = "0x6014D5D")]
    [Address(RVA = "0x1B3F198", Offset = "0x1B3F198", VA = "0x1B3F198")]
    public MasterBonusProvider()
    {
    }
  }
}
