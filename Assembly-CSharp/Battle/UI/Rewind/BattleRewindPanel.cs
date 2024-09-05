// Decompiled with JetBrains decompiler
// Type: Battle.UI.Rewind.BattleRewindPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using GameCore.Input;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI.Rewind
{
  [Token(Token = "0x2002451")]
  public class BattleRewindPanel : MonoBehaviour
  {
    [Token(Token = "0x4009BC4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject logPartsPrefab;
    [Token(Token = "0x4009BC5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject rootObject;
    [Token(Token = "0x4009BC6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITimelineController fadeController;
    [Token(Token = "0x4009BC7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BGParameters bgParam;
    [Token(Token = "0x4009BC8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4009BC9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4009BCA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private LongPressButton upScrollButton;
    [Token(Token = "0x4009BCB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private LongPressButton downScrollButton;
    [Token(Token = "0x4009BCC")]
    [FieldOffset(Offset = "0x58")]
    private BattleRewindManager battleRewind;
    [Token(Token = "0x4009BCD")]
    [FieldOffset(Offset = "0x60")]
    private List<BattleRewindLogParts> logParts;
    [Token(Token = "0x4009BCE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton normalNextButton;
    [Token(Token = "0x4009BCF")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton normalBackButton;
    [Token(Token = "0x4009BD0")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI normalAllCoinText;
    [Token(Token = "0x4009BD1")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI normalFreeRollbackLeftCountText;
    [Token(Token = "0x4009BD2")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI normalNeedCoinText;
    [Token(Token = "0x4009BD3")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private BattleRewindConfirmDialog confirmDialog;
    [Token(Token = "0x4009BD4")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private BattleRewindRetreatUnitDialog retreatUnitDialog;
    [Token(Token = "0x4009BD5")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private BattleRewindLoseDialog loseDialog;
    [Token(Token = "0x4009BD6")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private PlayerCommandSimpleBattleLog simpleBattleLog;
    [Token(Token = "0x4009BD7")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4009BD8")]
    [FieldOffset(Offset = "0xB8")]
    private BattleConfigData battleConfig;

    [Token(Token = "0x17002FCE")]
    public ScrollRect ScrollRect
    {
      [Token(Token = "0x600DEBC"), Address(RVA = "0x2014484", Offset = "0x2014484", VA = "0x2014484")] get
      {
        return (ScrollRect) null;
      }
    }

    [Token(Token = "0x17002FCF")]
    public TextMeshProUGUI NormalFreeRollbackLeftCountText
    {
      [Token(Token = "0x600DEBD"), Address(RVA = "0x201448C", Offset = "0x201448C", VA = "0x201448C")] get
      {
        return (TextMeshProUGUI) null;
      }
    }

    [Token(Token = "0x17002FD0")]
    public TextMeshProUGUI NormalNeedCoinText
    {
      [Token(Token = "0x600DEBE"), Address(RVA = "0x2014494", Offset = "0x2014494", VA = "0x2014494")] get
      {
        return (TextMeshProUGUI) null;
      }
    }

    [Token(Token = "0x17002FD1")]
    public BattleRewindConfirmDialog ConfirmDialog
    {
      [Token(Token = "0x600DEBF"), Address(RVA = "0x201449C", Offset = "0x201449C", VA = "0x201449C")] get
      {
        return (BattleRewindConfirmDialog) null;
      }
    }

    [Token(Token = "0x17002FD2")]
    public BattleRewindRetreatUnitDialog RetreatUnitDialog
    {
      [Token(Token = "0x600DEC0"), Address(RVA = "0x20144A4", Offset = "0x20144A4", VA = "0x20144A4")] get
      {
        return (BattleRewindRetreatUnitDialog) null;
      }
    }

    [Token(Token = "0x17002FD3")]
    public BattleRewindLoseDialog LoseDialog
    {
      [Token(Token = "0x600DEC1"), Address(RVA = "0x20144AC", Offset = "0x20144AC", VA = "0x20144AC")] get
      {
        return (BattleRewindLoseDialog) null;
      }
    }

    [Token(Token = "0x17002FD4")]
    public PlayerCommandSimpleBattleLog SimpleBattleLog
    {
      [Token(Token = "0x600DEC2"), Address(RVA = "0x20144B4", Offset = "0x20144B4", VA = "0x20144B4")] get
      {
        return (PlayerCommandSimpleBattleLog) null;
      }
    }

    [Token(Token = "0x600DEC3")]
    [Address(RVA = "0x20144BC", Offset = "0x20144BC", VA = "0x20144BC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600DEC4")]
    [Address(RVA = "0x201475C", Offset = "0x201475C", VA = "0x201475C")]
    private void Update()
    {
    }

    [Token(Token = "0x600DEC5")]
    [Address(RVA = "0x2014798", Offset = "0x2014798", VA = "0x2014798")]
    public void Initialize(BattleRewindManager battleRewind)
    {
    }

    [Token(Token = "0x600DEC6")]
    [Address(RVA = "0x2013F20", Offset = "0x2013F20", VA = "0x2013F20")]
    public IEnumerator InitializeCoroutine(
      Dictionary<int, Sprite> unitThumbnailSprites,
      BattleConfigData battleConfig)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600DEC7")]
    [Address(RVA = "0x2014F64", Offset = "0x2014F64", VA = "0x2014F64")]
    public void Show(BattleRewindManager.PanelType panelType, Action callback = null)
    {
    }

    [Token(Token = "0x600DEC8")]
    [Address(RVA = "0x20153E8", Offset = "0x20153E8", VA = "0x20153E8")]
    public void Hide(BattleRewindManager.PanelType panelType, Action callback = null)
    {
    }

    [Token(Token = "0x600DEC9")]
    [Address(RVA = "0x2015808", Offset = "0x2015808", VA = "0x2015808")]
    public void SetNormalAllCoin(string value)
    {
    }

    [Token(Token = "0x600DECA")]
    [Address(RVA = "0x2015814", Offset = "0x2015814", VA = "0x2015814")]
    public void RewindRequest()
    {
    }

    [Token(Token = "0x600DECB")]
    [Address(RVA = "0x2014090", Offset = "0x2014090", VA = "0x2014090")]
    public void RewindAnimationPlay()
    {
    }

    [Token(Token = "0x600DECC")]
    [Address(RVA = "0x20158E0", Offset = "0x20158E0", VA = "0x20158E0")]
    public void SetInteractableDecideButton(bool enable)
    {
    }

    [Token(Token = "0x600DECD")]
    [Address(RVA = "0x2015900", Offset = "0x2015900", VA = "0x2015900")]
    public void CloseButtonEvent()
    {
    }

    [Token(Token = "0x600DECE")]
    [Address(RVA = "0x2015A74", Offset = "0x2015A74", VA = "0x2015A74")]
    public void CheckFreeRollback()
    {
    }

    [Token(Token = "0x600DECF")]
    [Address(RVA = "0x2015BEC", Offset = "0x2015BEC", VA = "0x2015BEC")]
    public void UpScrollLogList()
    {
    }

    [Token(Token = "0x600DED0")]
    [Address(RVA = "0x2015C10", Offset = "0x2015C10", VA = "0x2015C10")]
    public void DownScrollLogList()
    {
    }

    [Token(Token = "0x600DED1")]
    [Address(RVA = "0x2015C34", Offset = "0x2015C34", VA = "0x2015C34")]
    public void BillingSucceedHidePanel()
    {
    }

    [Token(Token = "0x600DED2")]
    [Address(RVA = "0x2015C54", Offset = "0x2015C54", VA = "0x2015C54")]
    private IEnumerator BillingSucceedAnimaWait() => (IEnumerator) null;

    [Token(Token = "0x600DED3")]
    [Address(RVA = "0x2015CE4", Offset = "0x2015CE4", VA = "0x2015CE4")]
    public void ShowRetreatUnitDialog(bool isCancel = false)
    {
    }

    [Token(Token = "0x600DED4")]
    [Address(RVA = "0x2015DD0", Offset = "0x2015DD0", VA = "0x2015DD0")]
    public void DecideRetreatUnitDialog()
    {
    }

    [Token(Token = "0x600DED5")]
    [Address(RVA = "0x2015E54", Offset = "0x2015E54", VA = "0x2015E54")]
    public void CloseRetreatUnitDialog()
    {
    }

    [Token(Token = "0x600DED6")]
    [Address(RVA = "0x2015F90", Offset = "0x2015F90", VA = "0x2015F90")]
    public void ShowLoseDialog(bool isCancel = false)
    {
    }

    [Token(Token = "0x600DED7")]
    [Address(RVA = "0x201607C", Offset = "0x201607C", VA = "0x201607C")]
    public void DecideButtonIntoLoseDialog()
    {
    }

    [Token(Token = "0x600DED8")]
    [Address(RVA = "0x2016100", Offset = "0x2016100", VA = "0x2016100")]
    public void CloseButtonIntoLoseDialog()
    {
    }

    [Token(Token = "0x600DED9")]
    [Address(RVA = "0x201623C", Offset = "0x201623C", VA = "0x201623C")]
    public void CreateLog(UnityAction<int> touchEvent)
    {
    }

    [Token(Token = "0x600DEDA")]
    [Address(RVA = "0x2016374", Offset = "0x2016374", VA = "0x2016374")]
    public void AllDeleteLog()
    {
    }

    [Token(Token = "0x600DEDB")]
    [Address(RVA = "0x201637C", Offset = "0x201637C", VA = "0x201637C")]
    public void DeleteLog(int index = -1)
    {
    }

    [Token(Token = "0x600DEDC")]
    [Address(RVA = "0x20165DC", Offset = "0x20165DC", VA = "0x20165DC")]
    public void SetLogInformation(int index, string message)
    {
    }

    [Token(Token = "0x600DEDD")]
    [Address(RVA = "0x20166B0", Offset = "0x20166B0", VA = "0x20166B0")]
    public void SetActiveLog(int index, bool active)
    {
    }

    [Token(Token = "0x600DEDE")]
    [Address(RVA = "0x201674C", Offset = "0x201674C", VA = "0x201674C")]
    public BattleRewindPanel()
    {
    }
  }
}
