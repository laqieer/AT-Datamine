// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacter.ChangeCharacterSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;
using Network.Param;
using System.Collections;

#nullable disable
namespace Scenes.Home.ChangeCharacter
{
  [Token(Token = "0x2002B57")]
  public class ChangeCharacterSubScene : SubScene
  {
    [Token(Token = "0x400B890")]
    [FieldOffset(Offset = "0x58")]
    private ChangeCharacterPlacementView _placementView;
    [Token(Token = "0x400B891")]
    [FieldOffset(Offset = "0x60")]
    private ChangeCharacterCharacterView _changeCharacterView;
    [Token(Token = "0x400B892")]
    [FieldOffset(Offset = "0x68")]
    private ChangeCharacterStyleView _changeStyleView;
    [Token(Token = "0x400B893")]
    private const string AssetBundleName = "ui_page_home_charachenge_prefab";
    [Token(Token = "0x400B894")]
    private const string PlacementAssetName = "Com_Popup_Base_L_CharaPlacement";
    [Token(Token = "0x400B895")]
    private const string ChangeCharaterAssetName = "Com_Popup_Base_L_CharaChange";
    [Token(Token = "0x400B896")]
    private const string ChangeStyleAssetName = "Com_Popup_Base_L_StyleChange";
    [Token(Token = "0x400B897")]
    [FieldOffset(Offset = "0x70")]
    private ChangeCharacterSubScene.CharacterSettings _saveData;
    [Token(Token = "0x400B898")]
    [FieldOffset(Offset = "0x78")]
    private ChangeCharacterSubScene.ViewState _viewState;
    [Token(Token = "0x400B899")]
    [FieldOffset(Offset = "0x7C")]
    private bool _isInSequence;
    [Token(Token = "0x400B89A")]
    [FieldOffset(Offset = "0x80")]
    private int _selectingIndex;
    [Token(Token = "0x400B89B")]
    [FieldOffset(Offset = "0x84")]
    private bool isInitializeEnd;

    [Token(Token = "0x6010EEF")]
    [Address(RVA = "0x1C6EDCC", Offset = "0x1C6EDCC", VA = "0x1C6EDCC", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6010EF0")]
    [Address(RVA = "0x1C6EDD4", Offset = "0x1C6EDD4", VA = "0x1C6EDD4", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6010EF1")]
    [Address(RVA = "0x1C6EE64", Offset = "0x1C6EE64", VA = "0x1C6EE64", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x6010EF2")]
    [Address(RVA = "0x1C6F03C", Offset = "0x1C6F03C", VA = "0x1C6F03C")]
    private void CreateSaveData()
    {
    }

    [Token(Token = "0x6010EF3")]
    [Address(RVA = "0x1C6F0DC", Offset = "0x1C6F0DC", VA = "0x1C6F0DC")]
    private IEnumerator CreatePlacementView() => (IEnumerator) null;

    [Token(Token = "0x6010EF4")]
    [Address(RVA = "0x1C6F16C", Offset = "0x1C6F16C", VA = "0x1C6F16C")]
    private IEnumerator CreateChangeCharacterView(int index) => (IEnumerator) null;

    [Token(Token = "0x6010EF5")]
    [Address(RVA = "0x1C6F20C", Offset = "0x1C6F20C", VA = "0x1C6F20C")]
    private IEnumerator CreateChangeStyleView(int characterId) => (IEnumerator) null;

    [Token(Token = "0x6010EF6")]
    [Address(RVA = "0x1C6F2AC", Offset = "0x1C6F2AC", VA = "0x1C6F2AC")]
    private void PlacementToChangeCharacter(int index)
    {
    }

    [Token(Token = "0x6010EF7")]
    [Address(RVA = "0x1C6F344", Offset = "0x1C6F344", VA = "0x1C6F344")]
    private void ChangeCharacterToPlacement(
      ChangeCharacterSubScene.CharacterSettings temporarySaveData)
    {
    }

    [Token(Token = "0x6010EF8")]
    [Address(RVA = "0x1C6EFE0", Offset = "0x1C6EFE0", VA = "0x1C6EFE0")]
    private void CancelCharacterToPlacement()
    {
    }

    [Token(Token = "0x6010EF9")]
    [Address(RVA = "0x1C6F440", Offset = "0x1C6F440", VA = "0x1C6F440")]
    private void ConfirmStyleToPlacement(int styleId)
    {
    }

    [Token(Token = "0x6010EFA")]
    [Address(RVA = "0x1C6F000", Offset = "0x1C6F000", VA = "0x1C6F000")]
    private void BackStyleToPlacement()
    {
    }

    [Token(Token = "0x6010EFB")]
    [Address(RVA = "0x1C6F2CC", Offset = "0x1C6F2CC", VA = "0x1C6F2CC")]
    private IEnumerator PlacementToChangeCharacterViewAsync(int index) => (IEnumerator) null;

    [Token(Token = "0x6010EFC")]
    [Address(RVA = "0x1C6F364", Offset = "0x1C6F364", VA = "0x1C6F364")]
    private IEnumerator ChangeCharacterToPlacementAsync(
      ChangeCharacterSubScene.CharacterSettings temporarySaveData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010EFD")]
    [Address(RVA = "0x1C6F3D8", Offset = "0x1C6F3D8", VA = "0x1C6F3D8")]
    private IEnumerator ChangeCharacterToPlacementWithCancelAsync() => (IEnumerator) null;

    [Token(Token = "0x6010EFE")]
    [Address(RVA = "0x1C6F620", Offset = "0x1C6F620", VA = "0x1C6F620")]
    private void PlacementToChangeStyle(int index)
    {
    }

    [Token(Token = "0x6010EFF")]
    [Address(RVA = "0x1C6F460", Offset = "0x1C6F460", VA = "0x1C6F460")]
    private IEnumerator ChangeStyleToPlacementAsync(int styleId) => (IEnumerator) null;

    [Token(Token = "0x6010F00")]
    [Address(RVA = "0x1C6F74C", Offset = "0x1C6F74C", VA = "0x1C6F74C")]
    private IEnumerator PlacementToChangeStyleAsync(int characterId, int index)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010F01")]
    [Address(RVA = "0x1C6F818", Offset = "0x1C6F818", VA = "0x1C6F818")]
    private void SelectCharacterToChangeStyle(int characterId)
    {
    }

    [Token(Token = "0x6010F02")]
    [Address(RVA = "0x1C6F838", Offset = "0x1C6F838", VA = "0x1C6F838")]
    private IEnumerator ChangeCharacterToChangeStyleAsync(int characterId) => (IEnumerator) null;

    [Token(Token = "0x6010F03")]
    [Address(RVA = "0x1C6EECC", Offset = "0x1C6EECC", VA = "0x1C6EECC")]
    private void BackSubScene()
    {
    }

    [Token(Token = "0x6010F04")]
    [Address(RVA = "0x1C6F8D8", Offset = "0x1C6F8D8", VA = "0x1C6F8D8")]
    private void Confirm()
    {
    }

    [Token(Token = "0x6010F05")]
    [Address(RVA = "0x1C6F8F8", Offset = "0x1C6F8F8", VA = "0x1C6F8F8")]
    private IEnumerator ConfirmAsync() => (IEnumerator) null;

    [Token(Token = "0x6010F06")]
    [Address(RVA = "0x1C6F988", Offset = "0x1C6F988", VA = "0x1C6F988")]
    private IEnumerator InvalidSaveDialog() => (IEnumerator) null;

    [Token(Token = "0x6010F07")]
    [Address(RVA = "0x1C6FA10", Offset = "0x1C6FA10", VA = "0x1C6FA10")]
    private IEnumerator SaveToServer() => (IEnumerator) null;

    [Token(Token = "0x6010F08")]
    [Address(RVA = "0x1C6FAA0", Offset = "0x1C6FAA0", VA = "0x1C6FAA0")]
    public ChangeCharacterSubScene()
    {
    }

    [Token(Token = "0x2002B58")]
    public class CharacterSettings
    {
      [Token(Token = "0x400B89C")]
      [FieldOffset(Offset = "0x10")]
      public int StyleIdMain;
      [Token(Token = "0x400B89D")]
      [FieldOffset(Offset = "0x14")]
      public int StyleIdSub1;
      [Token(Token = "0x400B89E")]
      [FieldOffset(Offset = "0x18")]
      public int StyleIdSub2;
      [Token(Token = "0x400B89F")]
      [FieldOffset(Offset = "0x1C")]
      public int StyleIdSub3;
      [Token(Token = "0x400B8A0")]
      public const int SlotNum = 4;

      [Token(Token = "0x6010F0A")]
      [Address(RVA = "0x1C6F4D8", Offset = "0x1C6F4D8", VA = "0x1C6F4D8")]
      public int IndexToSettingStyleId(int index) => new int();

      [Token(Token = "0x6010F0B")]
      [Address(RVA = "0x1C6FAB0", Offset = "0x1C6FAB0", VA = "0x1C6FAB0")]
      public void Remove(int index)
      {
      }

      [Token(Token = "0x6010F0C")]
      [Address(RVA = "0x1C6FB7C", Offset = "0x1C6FB7C", VA = "0x1C6FB7C")]
      public void SetToIndex(int index, int styleId)
      {
      }

      [Token(Token = "0x6010F0D")]
      [Address(RVA = "0x1C6FC48", Offset = "0x1C6FC48", VA = "0x1C6FC48")]
      public PlayerHomeSettingType ToRequestData() => (PlayerHomeSettingType) null;

      [Token(Token = "0x6010F0E")]
      [Address(RVA = "0x1C6FCB0", Offset = "0x1C6FCB0", VA = "0x1C6FCB0")]
      public ChangeCharacterSubScene.CharacterSettings Clone()
      {
        return (ChangeCharacterSubScene.CharacterSettings) null;
      }

      [Token(Token = "0x6010F0F")]
      [Address(RVA = "0x1C6F0D4", Offset = "0x1C6F0D4", VA = "0x1C6F0D4")]
      public CharacterSettings()
      {
      }
    }

    [Token(Token = "0x2002B59")]
    private enum ViewState
    {
      [Token(Token = "0x400B8A2")] Placement,
      [Token(Token = "0x400B8A3")] CharacterChange,
      [Token(Token = "0x400B8A4")] StyleChange,
    }
  }
}
