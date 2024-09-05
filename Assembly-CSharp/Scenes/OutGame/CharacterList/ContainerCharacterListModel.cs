// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.ContainerCharacterListModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x200370B")]
  public class ContainerCharacterListModel
  {
    [Token(Token = "0x400F051")]
    [FieldOffset(Offset = "0x20")]
    private List<ContentCharacterModel> _characters;
    [Token(Token = "0x400F052")]
    [FieldOffset(Offset = "0x28")]
    private ContainerCharacterListModel.eLostReviveEndState _lostReviveEndState;
    [Token(Token = "0x400F053")]
    [FieldOffset(Offset = "0x2C")]
    public ContainerCharacterListModel.eCharacterListState _characterListState;
    [Token(Token = "0x400F054")]
    [FieldOffset(Offset = "0x30")]
    private int _selectCharacterIndex;

    [Token(Token = "0x6015AD4")]
    [Address(RVA = "0x1D861AC", Offset = "0x1D861AC", VA = "0x1D861AC")]
    public static ContainerCharacterListModel CreateFromRuntimeData(AssetCachedSpawner spawner)
    {
      return (ContainerCharacterListModel) null;
    }

    [Token(Token = "0x6015AD5")]
    [Address(RVA = "0x1D86980", Offset = "0x1D86980", VA = "0x1D86980")]
    public ContainerCharacterListModel(List<Character> characters, AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x170047B2")]
    public IReadOnlyList<ContentCharacterModel> Characters
    {
      [Token(Token = "0x6015AD6"), Address(RVA = "0x1D86EEC", Offset = "0x1D86EEC", VA = "0x1D86EEC")] get
      {
        return (IReadOnlyList<ContentCharacterModel>) null;
      }
    }

    [Token(Token = "0x170047B3")]
    public int CharacterCount
    {
      [Token(Token = "0x6015AD7"), Address(RVA = "0x1D86EF4", Offset = "0x1D86EF4", VA = "0x1D86EF4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170047B4")]
    public Action<bool> OperationPossibleEvent
    {
      [Token(Token = "0x6015AD8"), Address(RVA = "0x1D86F3C", Offset = "0x1D86F3C", VA = "0x1D86F3C")] get
      {
        return (Action<bool>) null;
      }
      [Token(Token = "0x6015AD9"), Address(RVA = "0x1D86F44", Offset = "0x1D86F44", VA = "0x1D86F44")] set
      {
      }
    }

    [Token(Token = "0x170047B5")]
    public Action OnSuccessPurchase
    {
      [Token(Token = "0x6015ADA"), Address(RVA = "0x1D86F4C", Offset = "0x1D86F4C", VA = "0x1D86F4C")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015ADB"), Address(RVA = "0x1D86F54", Offset = "0x1D86F54", VA = "0x1D86F54")] set
      {
      }
    }

    [Token(Token = "0x170047B6")]
    public int SelectIndex
    {
      [Token(Token = "0x6015ADC"), Address(RVA = "0x1D86F5C", Offset = "0x1D86F5C", VA = "0x1D86F5C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6015ADD")]
    [Address(RVA = "0x1D86F64", Offset = "0x1D86F64", VA = "0x1D86F64")]
    public void Close()
    {
    }

    [Token(Token = "0x6015ADE")]
    [Address(RVA = "0x1D86F70", Offset = "0x1D86F70", VA = "0x1D86F70")]
    public IEnumerator OnClickLostRecovery(
      AssetCachedSpawner spawner,
      int index,
      Action<bool> finish = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015ADF")]
    [Address(RVA = "0x1D87024", Offset = "0x1D87024", VA = "0x1D87024")]
    public IEnumerator SetRevive(AssetCachedSpawner spawner) => (IEnumerator) null;

    [Token(Token = "0x6015AE0")]
    [Address(RVA = "0x1D870C0", Offset = "0x1D870C0", VA = "0x1D870C0")]
    public IEnumerator OnLpRecovery(int index, int num, Action finish = null) => (IEnumerator) null;

    [Token(Token = "0x6015AE1")]
    [Address(RVA = "0x1D87170", Offset = "0x1D87170", VA = "0x1D87170")]
    public IEnumerator SetSupportList(AssetCachedSpawner spawner, int characterId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015AE2")]
    [Address(RVA = "0x1D87214", Offset = "0x1D87214", VA = "0x1D87214")]
    public void ChangeToStyleList(Character character)
    {
    }

    [Token(Token = "0x6015AE3")]
    [Address(RVA = "0x1D87220", Offset = "0x1D87220", VA = "0x1D87220")]
    public bool MoveSelectIndex(int move) => new bool();

    [Token(Token = "0x6015AE4")]
    [Address(RVA = "0x1D87294", Offset = "0x1D87294", VA = "0x1D87294")]
    public void SetSelectIndex(int index)
    {
    }

    [Token(Token = "0x6015AE5")]
    [Address(RVA = "0x1D874B8", Offset = "0x1D874B8", VA = "0x1D874B8")]
    public void UnsetSelectIndex()
    {
    }

    [Token(Token = "0x6015AE6")]
    [Address(RVA = "0x1D874C0", Offset = "0x1D874C0", VA = "0x1D874C0")]
    private List<ContentCharacterModel> LostReviveCharacters()
    {
      return (List<ContentCharacterModel>) null;
    }

    [Token(Token = "0x6015AE7")]
    [Address(RVA = "0x1D875D8", Offset = "0x1D875D8", VA = "0x1D875D8")]
    private IEnumerator LostRecoveryPlay(
      AssetCachedSpawner spawner,
      ContentCharacterModel model,
      Action<bool> finish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6015AE8")]
    [Address(RVA = "0x1D87688", Offset = "0x1D87688", VA = "0x1D87688")]
    private void CheckLostReviveState(CharacterLostRevive.eLostReviveState state)
    {
    }

    [Token(Token = "0x6015AE9")]
    [Address(RVA = "0x1D876A0", Offset = "0x1D876A0", VA = "0x1D876A0")]
    private IEnumerator LpRecoveryPlay(ContentCharacterModel model, int num, Action finish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x200370C")]
    private enum eLostReviveEndState
    {
      [Token(Token = "0x400F056")] Non,
      [Token(Token = "0x400F057")] cancel,
      [Token(Token = "0x400F058")] Revive,
    }

    [Token(Token = "0x200370D")]
    public enum eCharacterListState
    {
      [Token(Token = "0x400F05A")] Init,
      [Token(Token = "0x400F05B")] ReviveList,
      [Token(Token = "0x400F05C")] Normal,
      [Token(Token = "0x400F05D")] ReviveCheck,
      [Token(Token = "0x400F05E")] CharacterDetail,
      [Token(Token = "0x400F05F")] SupportRank,
      [Token(Token = "0x400F060")] Close,
    }
  }
}
