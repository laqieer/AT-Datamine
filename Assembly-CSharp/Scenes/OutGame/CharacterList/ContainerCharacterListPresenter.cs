// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.ContainerCharacterListPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.Armoury;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x2003718")]
  public class ContainerCharacterListPresenter : MonoBehaviour
  {
    [Token(Token = "0x400F08F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CharacterListHeader _header;
    [Token(Token = "0x400F090")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ContentCharacterList _contentList;
    [Token(Token = "0x400F091")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollCtrl _scrollCtrl;
    [Token(Token = "0x400F092")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CharacterListSubMenu _subMenu;
    [Token(Token = "0x400F094")]
    [FieldOffset(Offset = "0x40")]
    public Action OnSubmenuOpen;
    [Token(Token = "0x400F095")]
    [FieldOffset(Offset = "0x48")]
    private Action _openHomeButton;
    [Token(Token = "0x400F096")]
    [FieldOffset(Offset = "0x50")]
    private Action _closeHomeButton;
    [Token(Token = "0x400F097")]
    [FieldOffset(Offset = "0x58")]
    private bool _isInitiazlied;
    [Token(Token = "0x400F098")]
    [FieldOffset(Offset = "0x60")]
    private AssetCachedSpawner _assetCachedSpawner;
    [Token(Token = "0x400F099")]
    [FieldOffset(Offset = "0x68")]
    private ContainerCharacterListModel _model;

    [Token(Token = "0x170047C3")]
    public Action<bool> OperationPossibleEvent
    {
      [Token(Token = "0x6015B1B"), Address(RVA = "0x1D888CC", Offset = "0x1D888CC", VA = "0x1D888CC")] get
      {
        return (Action<bool>) null;
      }
      [Token(Token = "0x6015B1C"), Address(RVA = "0x1D888D4", Offset = "0x1D888D4", VA = "0x1D888D4")] set
      {
      }
    }

    [Token(Token = "0x6015B1D")]
    [Address(RVA = "0x1D888DC", Offset = "0x1D888DC", VA = "0x1D888DC")]
    private void Update()
    {
    }

    [Token(Token = "0x6015B1E")]
    [Address(RVA = "0x1D85374", Offset = "0x1D85374", VA = "0x1D85374")]
    public void Initialize(
      int margin = 3,
      Action<ArmouryScreenType, ArmouryChangeScreenParam> changeScreenAction = null,
      Action closeHomeButton = null,
      Action openHomeButton = null)
    {
    }

    [Token(Token = "0x6015B1F")]
    [Address(RVA = "0x1D88908", Offset = "0x1D88908", VA = "0x1D88908")]
    public void Initialize(
      ContainerCharacterListModel model,
      int margin,
      Action<ArmouryScreenType, ArmouryChangeScreenParam> changeScreenAction)
    {
    }

    [Token(Token = "0x6015B20")]
    [Address(RVA = "0x1D85880", Offset = "0x1D85880", VA = "0x1D85880")]
    public void Close(Action finish = null)
    {
    }

    [Token(Token = "0x6015B21")]
    [Address(RVA = "0x1D8560C", Offset = "0x1D8560C", VA = "0x1D8560C")]
    public bool IsLoading() => new bool();

    [Token(Token = "0x6015B22")]
    [Address(RVA = "0x1D8912C", Offset = "0x1D8912C", VA = "0x1D8912C")]
    private void InitSubMenu(
      Action<ArmouryScreenType, ArmouryChangeScreenParam> changeScreenAction)
    {
    }

    [Token(Token = "0x6015B23")]
    [Address(RVA = "0x1D892F8", Offset = "0x1D892F8", VA = "0x1D892F8")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6015B24")]
    [Address(RVA = "0x1D89388", Offset = "0x1D89388", VA = "0x1D89388")]
    private void OpenSubMenu(int index)
    {
    }

    [Token(Token = "0x6015B25")]
    [Address(RVA = "0x1D894F0", Offset = "0x1D894F0", VA = "0x1D894F0")]
    public void CloseSubMenu()
    {
    }

    [Token(Token = "0x6015B26")]
    [Address(RVA = "0x1D8950C", Offset = "0x1D8950C", VA = "0x1D8950C")]
    public void DisableSubMenu()
    {
    }

    [Token(Token = "0x6015B27")]
    [Address(RVA = "0x1D8953C", Offset = "0x1D8953C", VA = "0x1D8953C")]
    private void OnClickCharacter(int index)
    {
    }

    [Token(Token = "0x6015B28")]
    [Address(RVA = "0x1D8958C", Offset = "0x1D8958C", VA = "0x1D8958C")]
    private void OnOpenSupportRankList(Character character)
    {
    }

    [Token(Token = "0x6015B29")]
    [Address(RVA = "0x1D895C8", Offset = "0x1D895C8", VA = "0x1D895C8")]
    private void OnOpenStyleList(Character character)
    {
    }

    [Token(Token = "0x6015B2A")]
    [Address(RVA = "0x1D89674", Offset = "0x1D89674", VA = "0x1D89674")]
    private void OnClickLostRecovery(int index)
    {
    }

    [Token(Token = "0x6015B2B")]
    [Address(RVA = "0x1D89720", Offset = "0x1D89720", VA = "0x1D89720")]
    private void OnHeal(int index, int recoveryCount)
    {
    }

    [Token(Token = "0x6015B2C")]
    [Address(RVA = "0x1D897D0", Offset = "0x1D897D0", VA = "0x1D897D0")]
    private void OnSuccessPurchase()
    {
    }

    [Token(Token = "0x6015B2D")]
    [Address(RVA = "0x1D897EC", Offset = "0x1D897EC", VA = "0x1D897EC")]
    private void HeaderUpdateView()
    {
    }

    [Token(Token = "0x6015B2E")]
    [Address(RVA = "0x1D89808", Offset = "0x1D89808", VA = "0x1D89808")]
    private void SetRevive()
    {
    }

    [Token(Token = "0x6015B2F")]
    [Address(RVA = "0x1D89828", Offset = "0x1D89828", VA = "0x1D89828")]
    private IEnumerator SetReviveAsync() => (IEnumerator) null;

    [Token(Token = "0x6015B30")]
    [Address(RVA = "0x1D89848", Offset = "0x1D89848", VA = "0x1D89848")]
    public ContainerCharacterListPresenter()
    {
    }
  }
}
