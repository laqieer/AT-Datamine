// Decompiled with JetBrains decompiler
// Type: DuelDebugToolController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200011E")]
[RequireComponent(typeof (DuelManager))]
public class DuelDebugToolController : MonoBehaviour, IDuelDebugToolController
{
  [Token(Token = "0x40005FF")]
  [FieldOffset(Offset = "0x18")]
  private DuelManager duelManager;
  [Token(Token = "0x4000600")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private GameObject setEnvironmentButton;
  [Token(Token = "0x4000601")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private GameObject setCharactersButton;
  [Token(Token = "0x4000602")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private GameObject setActionsButton;
  [Token(Token = "0x4000603")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private GameObject setEnvironmentPanel;
  [Token(Token = "0x4000604")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private GameObject setCharactersPanel;
  [Token(Token = "0x4000605")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private GameObject setActionsPanel;
  [Token(Token = "0x4000606")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private DuelDebugToolEnvironmentSettingsPanelController environmentSettings;
  [Token(Token = "0x4000607")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private DuelDebugToolCharacterSettingsPanelController attackerSettings;
  [Token(Token = "0x4000608")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  private DuelDebugToolCharacterSettingsPanelController attackerSupporterSettings;
  [Token(Token = "0x4000609")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private DuelDebugToolCharacterSettingsPanelController defenderSettings;
  [Token(Token = "0x400060A")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  private DuelDebugToolCharacterSettingsPanelController defenderSupporterSettings;
  [Token(Token = "0x400060B")]
  [FieldOffset(Offset = "0x78")]
  [SerializeField]
  private GameObject turnButtonsContainer;
  [Token(Token = "0x400060C")]
  [FieldOffset(Offset = "0x80")]
  [SerializeField]
  private GameObject characterActionSettingsPanelContainer;
  [Token(Token = "0x400060D")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private GameObject turnButtonsPrefab;
  [Token(Token = "0x400060E")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private GameObject characterActionSettingsPanelPrefab;
  [Token(Token = "0x400060F")]
  [FieldOffset(Offset = "0x98")]
  private int currentSelectedTurnIndex;
  [Token(Token = "0x4000610")]
  [FieldOffset(Offset = "0x9C")]
  private DuelCharacterController.DuelCharacterRole currentSelectedCharacter;
  [Token(Token = "0x4000611")]
  [FieldOffset(Offset = "0xA0")]
  public List<Dictionary<DuelCharacterController.DuelCharacterRole, DuelDebugToolCharacterActionSettingsPanelController>> turnList;
  [Token(Token = "0x4000612")]
  [FieldOffset(Offset = "0xA8")]
  private List<DuelDebugToolTurnButtonsController> turnButtonsControllerList;
  [Token(Token = "0x4000613")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  [Space(20f)]
  public List<string> sceneNameList;

  [Token(Token = "0x1700006C")]
  public IDuelDebugToolEnvironmentSettings EnvironmentSettings
  {
    [Token(Token = "0x60007D0"), Address(RVA = "0x485A338", Offset = "0x485A338", VA = "0x485A338", Slot = "9")] get
    {
      return (IDuelDebugToolEnvironmentSettings) null;
    }
  }

  [Token(Token = "0x1700006D")]
  public List<Dictionary<DuelCharacterController.DuelCharacterRole, IDuelDebugToolActionSettings>> TurnList
  {
    [Token(Token = "0x60007D1"), Address(RVA = "0x485A340", Offset = "0x485A340", VA = "0x485A340", Slot = "10")] get
    {
      return (List<Dictionary<DuelCharacterController.DuelCharacterRole, IDuelDebugToolActionSettings>>) null;
    }
  }

  [Token(Token = "0x60007D2")]
  [Address(RVA = "0x485A400", Offset = "0x485A400", VA = "0x485A400")]
  private IEnumerable<DictionaryEntry> CastDict(IDictionary dictionary)
  {
    return (IEnumerable<DictionaryEntry>) null;
  }

  [Token(Token = "0x1700006E")]
  public IDuelDebugToolCharacterSettings AttackerSettings
  {
    [Token(Token = "0x60007D3"), Address(RVA = "0x485A4AC", Offset = "0x485A4AC", VA = "0x485A4AC", Slot = "5")] get
    {
      return (IDuelDebugToolCharacterSettings) null;
    }
  }

  [Token(Token = "0x1700006F")]
  public IDuelDebugToolCharacterSettings AttackerSupporterSettings
  {
    [Token(Token = "0x60007D4"), Address(RVA = "0x485A4B4", Offset = "0x485A4B4", VA = "0x485A4B4", Slot = "6")] get
    {
      return (IDuelDebugToolCharacterSettings) null;
    }
  }

  [Token(Token = "0x17000070")]
  public IDuelDebugToolCharacterSettings DefenderSettings
  {
    [Token(Token = "0x60007D5"), Address(RVA = "0x485A4BC", Offset = "0x485A4BC", VA = "0x485A4BC", Slot = "7")] get
    {
      return (IDuelDebugToolCharacterSettings) null;
    }
  }

  [Token(Token = "0x17000071")]
  public IDuelDebugToolCharacterSettings DefenderSupporterSettings
  {
    [Token(Token = "0x60007D6"), Address(RVA = "0x485A4C4", Offset = "0x485A4C4", VA = "0x485A4C4", Slot = "8")] get
    {
      return (IDuelDebugToolCharacterSettings) null;
    }
  }

  [Token(Token = "0x60007D7")]
  [Address(RVA = "0x485A4CC", Offset = "0x485A4CC", VA = "0x485A4CC")]
  [ContextMenu("Collect Asset Names")]
  public void CollectAssetNames()
  {
  }

  [Token(Token = "0x60007D8")]
  [Address(RVA = "0x485A4D0", Offset = "0x485A4D0", VA = "0x485A4D0")]
  [ContextMenu("Collect Scene Names")]
  public void CollectSceneNames()
  {
  }

  [Token(Token = "0x60007D9")]
  [Address(RVA = "0x485A62C", Offset = "0x485A62C", VA = "0x485A62C")]
  public void OnClickSetEnvironmentButton()
  {
  }

  [Token(Token = "0x60007DA")]
  [Address(RVA = "0x485A64C", Offset = "0x485A64C", VA = "0x485A64C")]
  public void OnClickSetEnvironmentConfirmButton()
  {
  }

  [Token(Token = "0x60007DB")]
  [Address(RVA = "0x485A66C", Offset = "0x485A66C", VA = "0x485A66C")]
  public void OnClickSetCharactersButton()
  {
  }

  [Token(Token = "0x60007DC")]
  [Address(RVA = "0x485A68C", Offset = "0x485A68C", VA = "0x485A68C")]
  public void OnClickSetCharactersConfirmButton()
  {
  }

  [Token(Token = "0x60007DD")]
  [Address(RVA = "0x485A6AC", Offset = "0x485A6AC", VA = "0x485A6AC")]
  public void OnClickSelectCharacterButton(
    DuelDebugToolCharacterSettingsPanelController selectedController)
  {
  }

  [Token(Token = "0x60007DE")]
  [Address(RVA = "0x485A838", Offset = "0x485A838", VA = "0x485A838")]
  public void OnClickSetActionsButton()
  {
  }

  [Token(Token = "0x60007DF")]
  [Address(RVA = "0x485A858", Offset = "0x485A858", VA = "0x485A858")]
  public void OnClickSetActionsConfirmButton()
  {
  }

  [Token(Token = "0x60007E0")]
  [Address(RVA = "0x485A878", Offset = "0x485A878", VA = "0x485A878")]
  public void OnClickAddTurnButton()
  {
  }

  [Token(Token = "0x60007E1")]
  [Address(RVA = "0x485A87C", Offset = "0x485A87C", VA = "0x485A87C")]
  private void AddTurn()
  {
  }

  [Token(Token = "0x60007E2")]
  [Address(RVA = "0x485B2A8", Offset = "0x485B2A8", VA = "0x485B2A8")]
  public void SelectTurn(int turnIndex)
  {
  }

  [Token(Token = "0x60007E3")]
  [Address(RVA = "0x485B2B0", Offset = "0x485B2B0", VA = "0x485B2B0")]
  public void RemoveTurn(int turnIndex)
  {
  }

  [Token(Token = "0x60007E4")]
  [Address(RVA = "0x485B804", Offset = "0x485B804", VA = "0x485B804")]
  public void OnClickSelectCharacterButton(
    DuelDebugToolSelectCharacterButtonController controller)
  {
  }

  [Token(Token = "0x60007E5")]
  [Address(RVA = "0x485B05C", Offset = "0x485B05C", VA = "0x485B05C")]
  private void UpdateDisplayingCharacterActionSettings()
  {
  }

  [Token(Token = "0x60007E6")]
  [Address(RVA = "0x485AD58", Offset = "0x485AD58", VA = "0x485AD58")]
  private void CreateCharacterActionSettingsPanel(
    int turnIndex,
    DuelCharacterController.DuelCharacterRole role)
  {
  }

  [Token(Token = "0x60007E7")]
  [Address(RVA = "0x485B820", Offset = "0x485B820", VA = "0x485B820")]
  public void OnClickInitializeButton()
  {
  }

  [Token(Token = "0x60007E8")]
  [Address(RVA = "0x485B880", Offset = "0x485B880", VA = "0x485B880")]
  public void OnClickClearButton()
  {
  }

  [Token(Token = "0x60007E9")]
  [Address(RVA = "0x485B8DC", Offset = "0x485B8DC", VA = "0x485B8DC")]
  private void Initialize()
  {
  }

  [Token(Token = "0x60007EA")]
  [Address(RVA = "0x485C59C", Offset = "0x485C59C", VA = "0x485C59C")]
  private IEnumerator AdjustContainerSizeYCoroutine(Transform containerTransform)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60007EB")]
  [Address(RVA = "0x485AD38", Offset = "0x485AD38", VA = "0x485AD38")]
  private void AdjustContainerSizeY(Transform containerTransform)
  {
  }

  [Token(Token = "0x60007EC")]
  [Address(RVA = "0x485C62C", Offset = "0x485C62C", VA = "0x485C62C", Slot = "4")]
  public DuelManager.DuelProcessType GetDuelProcessType() => new DuelManager.DuelProcessType();

  [Token(Token = "0x60007ED")]
  [Address(RVA = "0x485C7C0", Offset = "0x485C7C0", VA = "0x485C7C0")]
  private void Start()
  {
  }

  [Token(Token = "0x60007EE")]
  [Address(RVA = "0x485C8AC", Offset = "0x485C8AC", VA = "0x485C8AC")]
  public DuelDebugToolController()
  {
  }
}
