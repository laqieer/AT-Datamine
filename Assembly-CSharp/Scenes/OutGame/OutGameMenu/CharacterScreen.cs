// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.CharacterScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Armoury;
using Scenes.OutGame.CharacterList;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039B9")]
  public class CharacterScreen : ArmouryScreenBase
  {
    [Token(Token = "0x400FC5F")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ContainerCharacterListPresenter _presenter;
    [Token(Token = "0x400FC60")]
    [FieldOffset(Offset = "0x98")]
    private CharacterScreen.Param characterListParam;

    [Token(Token = "0x6016ABF")]
    [Address(RVA = "0x3F648C0", Offset = "0x3F648C0", VA = "0x3F648C0", Slot = "4")]
    public override void Initialize(ArmouryChangeScreenParam param = null)
    {
    }

    [Token(Token = "0x6016AC0")]
    [Address(RVA = "0x3F64968", Offset = "0x3F64968", VA = "0x3F64968", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016AC1")]
    [Address(RVA = "0x3F649F8", Offset = "0x3F649F8", VA = "0x3F649F8", Slot = "14")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6016AC2")]
    [Address(RVA = "0x3F64A18", Offset = "0x3F64A18", VA = "0x3F64A18", Slot = "9")]
    public override void InActive()
    {
    }

    [Token(Token = "0x6016AC3")]
    [Address(RVA = "0x3F64A34", Offset = "0x3F64A34", VA = "0x3F64A34")]
    public void UpdateCharList()
    {
    }

    [Token(Token = "0x6016AC4")]
    [Address(RVA = "0x3F64A38", Offset = "0x3F64A38", VA = "0x3F64A38")]
    public void SubmenuOutRange()
    {
    }

    [Token(Token = "0x6016AC5")]
    [Address(RVA = "0x3F64A54", Offset = "0x3F64A54", VA = "0x3F64A54")]
    public CharacterScreen()
    {
    }

    [Token(Token = "0x20039BA")]
    public class Param : ArmouryChangeScreenParam
    {
      [Token(Token = "0x6016AC7")]
      [Address(RVA = "0x3F64960", Offset = "0x3F64960", VA = "0x3F64960")]
      public Param()
      {
      }
    }
  }
}
