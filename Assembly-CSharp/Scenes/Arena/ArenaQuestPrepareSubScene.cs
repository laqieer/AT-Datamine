// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaQuestPrepareSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.OutGame;
using StaqData;
using System;
using System.Collections;
using TeamOrganization;
using UI.Common;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x200313B")]
  public class ArenaQuestPrepareSubScene : QuestPrepareSubScene
  {
    [Token(Token = "0x400D190")]
    [FieldOffset(Offset = "0x2C8")]
    private ArenaTopSceneBase sceneBase;
    [Token(Token = "0x400D191")]
    [FieldOffset(Offset = "0x2D0")]
    private OrganizationTeam organizationTeam;
    [Token(Token = "0x400D192")]
    [FieldOffset(Offset = "0x2D8")]
    private bool deckDifference;
    [Token(Token = "0x400D193")]
    [FieldOffset(Offset = "0x2E0")]
    private Deck oldDeck;
    [Token(Token = "0x400D194")]
    [FieldOffset(Offset = "0x2E8")]
    [SerializeField]
    private CommonButton sortieButton;
    [Token(Token = "0x400D195")]
    [FieldOffset(Offset = "0x2F0")]
    [SerializeField]
    private GameObject offenseOnObj;
    [Token(Token = "0x400D196")]
    [FieldOffset(Offset = "0x2F8")]
    [SerializeField]
    private GameObject defenseOnObj;
    [Token(Token = "0x400D197")]
    [FieldOffset(Offset = "0x300")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400D198")]
    [FieldOffset(Offset = "0x308")]
    [SerializeField]
    private HomeTransitionButton homeTransitionButton;
    [Token(Token = "0x400D19A")]
    [FieldOffset(Offset = "0x318")]
    private IEnumerator checkArenaOpen;

    [Token(Token = "0x17004050")]
    public ArenaLoader ArenaLoader
    {
      [Token(Token = "0x601334D"), Address(RVA = "0x45E7C58", Offset = "0x45E7C58", VA = "0x45E7C58")] get
      {
        return (ArenaLoader) null;
      }
      [Token(Token = "0x601334E"), Address(RVA = "0x45E7C60", Offset = "0x45E7C60", VA = "0x45E7C60")] private set
      {
      }
    }

    [Token(Token = "0x601334F")]
    [Address(RVA = "0x45E7C68", Offset = "0x45E7C68", VA = "0x45E7C68")]
    private IEnumerator CheckArenaOpen() => (IEnumerator) null;

    [Token(Token = "0x6013350")]
    [Address(RVA = "0x45E7CD0", Offset = "0x45E7CD0", VA = "0x45E7CD0", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6013351")]
    [Address(RVA = "0x45E82E4", Offset = "0x45E82E4", VA = "0x45E82E4", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013352")]
    [Address(RVA = "0x45E834C", Offset = "0x45E834C", VA = "0x45E834C", Slot = "32")]
    protected override void CreateBg()
    {
    }

    [Token(Token = "0x6013353")]
    [Address(RVA = "0x45E8448", Offset = "0x45E8448", VA = "0x45E8448", Slot = "33")]
    public override void UpdateView()
    {
    }

    [Token(Token = "0x6013354")]
    [Address(RVA = "0x45E8568", Offset = "0x45E8568", VA = "0x45E8568", Slot = "38")]
    protected override void UpdatePartyChange()
    {
    }

    [Token(Token = "0x6013355")]
    [Address(RVA = "0x45E85B0", Offset = "0x45E85B0", VA = "0x45E85B0", Slot = "34")]
    protected override void UpdateMemberLimitText()
    {
    }

    [Token(Token = "0x6013356")]
    [Address(RVA = "0x45E865C", Offset = "0x45E865C", VA = "0x45E865C", Slot = "39")]
    public override void OtherUpdate()
    {
    }

    [Token(Token = "0x6013357")]
    [Address(RVA = "0x45E8858", Offset = "0x45E8858", VA = "0x45E8858")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6013358")]
    [Address(RVA = "0x45E8A54", Offset = "0x45E8A54", VA = "0x45E8A54", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6013359")]
    [Address(RVA = "0x45E8B3C", Offset = "0x45E8B3C", VA = "0x45E8B3C", Slot = "37")]
    protected override void UpdateTotalPower()
    {
    }

    [Token(Token = "0x601335A")]
    [Address(RVA = "0x45E8C28", Offset = "0x45E8C28", VA = "0x45E8C28")]
    public void OnClickToOffense()
    {
    }

    [Token(Token = "0x601335B")]
    [Address(RVA = "0x45E90D4", Offset = "0x45E90D4", VA = "0x45E90D4")]
    public void OnClickToDefense()
    {
    }

    [Token(Token = "0x601335C")]
    [Address(RVA = "0x45E9580", Offset = "0x45E9580", VA = "0x45E9580", Slot = "40")]
    public override void OnClickToBattleConfig()
    {
    }

    [Token(Token = "0x601335D")]
    [Address(RVA = "0x45E967C", Offset = "0x45E967C", VA = "0x45E967C")]
    public void OnClickGlobalMenu()
    {
    }

    [Token(Token = "0x601335E")]
    [Address(RVA = "0x45E9740", Offset = "0x45E9740", VA = "0x45E9740")]
    public void OnClickToArenaAutoEdit()
    {
    }

    [Token(Token = "0x601335F")]
    [Address(RVA = "0x45E9850", Offset = "0x45E9850", VA = "0x45E9850")]
    public void OnClickToArenaPartyEdit()
    {
    }

    [Token(Token = "0x6013360")]
    [Address(RVA = "0x45E9960", Offset = "0x45E9960", VA = "0x45E9960", Slot = "35")]
    public override void OnClickLeftArrow()
    {
    }

    [Token(Token = "0x6013361")]
    [Address(RVA = "0x45E9A74", Offset = "0x45E9A74", VA = "0x45E9A74", Slot = "36")]
    public override void OnClickRightArrow()
    {
    }

    [Token(Token = "0x6013362")]
    [Address(RVA = "0x45E9B88", Offset = "0x45E9B88", VA = "0x45E9B88")]
    public void OnClickToArenaPartyRegister()
    {
    }

    [Token(Token = "0x6013363")]
    [Address(RVA = "0x45EA2B8", Offset = "0x45EA2B8", VA = "0x45EA2B8")]
    public void OnClickToArenaPlace()
    {
    }

    [Token(Token = "0x6013364")]
    [Address(RVA = "0x45EA50C", Offset = "0x45EA50C", VA = "0x45EA50C")]
    public new void OnClickBackButton()
    {
    }

    [Token(Token = "0x6013365")]
    [Address(RVA = "0x45EA954", Offset = "0x45EA954", VA = "0x45EA954")]
    public void OnClickBackToHome()
    {
    }

    [Token(Token = "0x6013366")]
    [Address(RVA = "0x45EA898", Offset = "0x45EA898", VA = "0x45EA898")]
    private void BackToArenaTopSubScene()
    {
    }

    [Token(Token = "0x6013367")]
    [Address(RVA = "0x45EA5A0", Offset = "0x45EA5A0", VA = "0x45EA5A0")]
    private void OpenPartyUnsavedWarningPopup(Action onCanceled, Action onDecided)
    {
    }

    [Token(Token = "0x6013368")]
    [Address(RVA = "0x45E9C3C", Offset = "0x45E9C3C", VA = "0x45E9C3C")]
    private bool ArenaDeckSaveCheck(Deck deck) => new bool();

    [Token(Token = "0x6013369")]
    [Address(RVA = "0x45EA228", Offset = "0x45EA228", VA = "0x45EA228")]
    private IEnumerator ArenaDeckSave(Deck deck, bool isToaster, Action callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601336A")]
    [Address(RVA = "0x45EAA44", Offset = "0x45EAA44", VA = "0x45EAA44")]
    private IEnumerator APIDeckEdit(
      Deck deck,
      DeckTypeEnum deckTypeEnum,
      bool isToaster,
      Action callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601336B")]
    [Address(RVA = "0x45E8270", Offset = "0x45E8270", VA = "0x45E8270")]
    private void DeckTypeToggleChange(DeckTypeEnum type)
    {
    }

    [Token(Token = "0x601336C")]
    [Address(RVA = "0x45EAADC", Offset = "0x45EAADC", VA = "0x45EAADC")]
    public ArenaQuestPrepareSubScene()
    {
    }
  }
}
