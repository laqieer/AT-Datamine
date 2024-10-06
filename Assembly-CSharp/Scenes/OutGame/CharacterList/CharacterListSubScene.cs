// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.CharacterListSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003705")]
  public class CharacterListSubScene : SubScene
  {
    [Token(Token = "0x400F03C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ContainerCharacterListPresenter _presenter;
    [Token(Token = "0x400F03D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton _backButton;
    [Token(Token = "0x400F03E")]
    [FieldOffset(Offset = "0x68")]
    private UITimelineController _timelineController;

    [Token(Token = "0x6015AB4")]
    [Address(RVA = "0x1D85200", Offset = "0x1D85200", VA = "0x1D85200")]
    public static void ChangeScene()
    {
    }

    [Token(Token = "0x6015AB5")]
    [Address(RVA = "0x1D852AC", Offset = "0x1D852AC", VA = "0x1D852AC", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6015AB6")]
    [Address(RVA = "0x1D85440", Offset = "0x1D85440", VA = "0x1D85440", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6015AB7")]
    [Address(RVA = "0x1D854D0", Offset = "0x1D854D0", VA = "0x1D854D0", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6015AB8")]
    [Address(RVA = "0x1D85560", Offset = "0x1D85560", VA = "0x1D85560")]
    private void OnBackButton()
    {
    }

    [Token(Token = "0x6015AB9")]
    [Address(RVA = "0x1D855E0", Offset = "0x1D855E0", VA = "0x1D855E0")]
    public CharacterListSubScene()
    {
    }
  }
}
