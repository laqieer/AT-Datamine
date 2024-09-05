// Decompiled with JetBrains decompiler
// Type: Opening.MA_00100_23_Manager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Opening
{
  [Token(Token = "0x2000A61")]
  public class MA_00100_23_Manager : MonoBehaviour
  {
    [Token(Token = "0x400301E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MA_00100_23_SettingsAsset openingSettings;
    [Token(Token = "0x400301F")]
    [FieldOffset(Offset = "0x20")]
    private Animator mainCharacterAnimator;
    [Token(Token = "0x4003020")]
    [FieldOffset(Offset = "0x28")]
    private Animator weaponAnimator;
    [Token(Token = "0x4003021")]
    [FieldOffset(Offset = "0x30")]
    private bool isInitialized;
    [Token(Token = "0x4003022")]
    [FieldOffset(Offset = "0x31")]
    private bool isPlaying;
    [Token(Token = "0x4003023")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Header("3D_制御対象")]
    private GameObject mainCharacterContainer;
    [Token(Token = "0x4003024")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PlayableDirector part01PlayableDirector;
    [Token(Token = "0x4003025")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject catContainer;
    [Token(Token = "0x4003026")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject geoLineMain;
    [Token(Token = "0x4003027")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject geoLineSub;
    [Token(Token = "0x4003028")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject monoris;
    [Token(Token = "0x4003029")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject cameraRoot;
    [Token(Token = "0x400302A")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject debugUIRoot;
    [Token(Token = "0x400302B")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    [Header("3D_使う素材への参照")]
    private RuntimeAnimatorController mainCharacterAnimatorController_M;
    [Token(Token = "0x400302C")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private RuntimeAnimatorController mainCharacterAnimatorController_F;
    [Token(Token = "0x400302D")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private DuelCharacterEquipmentSettingsAsset mainCharacterEquipmentModelYellow;
    [Token(Token = "0x400302E")]
    [FieldOffset(Offset = "0x90")]
    [Header("3D_色設定")]
    [SerializeField]
    private Color lineColorABlue;
    [Token(Token = "0x400302F")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Color monorisColorBlue;
    [Token(Token = "0x4003030")]
    [FieldOffset(Offset = "0xB0")]
    private GachaAwardData processingGachaAwardData;
    [Token(Token = "0x4003031")]
    private const string TRACK_NAME_PART01_CHARACTER_ANIMATION_M = "An_gacha_ch_m";
    [Token(Token = "0x4003032")]
    private const string TRACK_NAME_PART01_CHARACTER_ANIMATION_F = "An_gacha_ch_f";
    [Token(Token = "0x4003033")]
    private const string TRACK_NAME_PART03_CAM_CUT06_M = "An_gacha_camera_Cut06_01_m";
    [Token(Token = "0x4003034")]
    private const string TRACK_NAME_PART03_CAM_CUT06_F = "An_gacha_camera_Cut06_01_f";

    [Token(Token = "0x6003B0B")]
    [Address(RVA = "0x331AA38", Offset = "0x331AA38", VA = "0x331AA38")]
    public IEnumerator InitializeFromAdv(int setCharaId = -1) => (IEnumerator) null;

    [Token(Token = "0x6003B0C")]
    [Address(RVA = "0x331AAD8", Offset = "0x331AAD8", VA = "0x331AAD8")]
    private SexTypeEnum GetGender(int charaId) => new SexTypeEnum();

    [Token(Token = "0x6003B0D")]
    [Address(RVA = "0x331AB04", Offset = "0x331AB04", VA = "0x331AB04")]
    public IEnumerator Initialize(MA_00100_23_SettingsAsset openingSettings) => (IEnumerator) null;

    [Token(Token = "0x6003B0E")]
    [Address(RVA = "0x331ABA0", Offset = "0x331ABA0", VA = "0x331ABA0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6003B0F")]
    [Address(RVA = "0x331ABC0", Offset = "0x331ABC0", VA = "0x331ABC0")]
    private IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003B10")]
    [Address(RVA = "0x331AC50", Offset = "0x331AC50", VA = "0x331AC50")]
    private DuelCharacterEquipmentSettingsAsset GetMainCharacterWeapon()
    {
      return (DuelCharacterEquipmentSettingsAsset) null;
    }

    [Token(Token = "0x6003B11")]
    [Address(RVA = "0x331AC58", Offset = "0x331AC58", VA = "0x331AC58")]
    private void SetLineColor()
    {
    }

    [Token(Token = "0x6003B12")]
    [Address(RVA = "0x331AD3C", Offset = "0x331AD3C", VA = "0x331AD3C")]
    private void SetMonorisColor()
    {
    }

    [Token(Token = "0x6003B13")]
    [Address(RVA = "0x331ADE4", Offset = "0x331ADE4", VA = "0x331ADE4")]
    public void SetMainCharacter(
      DuelCharacterModelSettingsAsset mainCharacterModelSettings,
      SexTypeEnum mainCharacterGender)
    {
    }

    [Token(Token = "0x6003B14")]
    [Address(RVA = "0x331B434", Offset = "0x331B434", VA = "0x331B434")]
    private void SetMainCharacterTimelineBindings(Animator mainCharacterAnimator)
    {
    }

    [Token(Token = "0x6003B15")]
    [Address(RVA = "0x331AF0C", Offset = "0x331AF0C", VA = "0x331AF0C")]
    private GameObject CreatePrefabInstance(GameObject prefab, GameObject parent)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6003B16")]
    [Address(RVA = "0x331B110", Offset = "0x331B110", VA = "0x331B110")]
    private Animator SetCharacterEquipments(
      GameObject characterModel,
      DuelCharacterEquipmentSettingsAsset equipmentSettings,
      float weaponScale)
    {
      return (Animator) null;
    }

    [Token(Token = "0x6003B17")]
    [Address(RVA = "0x331BA70", Offset = "0x331BA70", VA = "0x331BA70")]
    public void Play()
    {
    }

    [Token(Token = "0x6003B18")]
    [Address(RVA = "0x331BB1C", Offset = "0x331BB1C", VA = "0x331BB1C")]
    public bool IsPlaying() => new bool();

    [Token(Token = "0x6003B19")]
    [Address(RVA = "0x331BAB4", Offset = "0x331BAB4", VA = "0x331BAB4")]
    private IEnumerator PlayCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6003B1A")]
    [Address(RVA = "0x331BB4C", Offset = "0x331BB4C", VA = "0x331BB4C")]
    public void Clear()
    {
    }

    [Token(Token = "0x6003B1B")]
    [Address(RVA = "0x331BB78", Offset = "0x331BB78", VA = "0x331BB78")]
    public void RemoveMainCharacter()
    {
    }

    [Token(Token = "0x6003B1C")]
    [Address(RVA = "0x331BC44", Offset = "0x331BC44", VA = "0x331BC44")]
    public MA_00100_23_Manager()
    {
    }
  }
}
