// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldUnitListViewElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200241D")]
  public class FieldUnitListViewElement : MonoBehaviour
  {
    [Token(Token = "0x4009A7E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform _frontFrame;
    [Token(Token = "0x4009A7F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform _backFrame;
    [Token(Token = "0x4009A80")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image _frontUnitThumbnail;
    [Token(Token = "0x4009A81")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image _backUnitThumbnail;
    [Token(Token = "0x4009A82")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Slider _frontUnitHPGauge;
    [Token(Token = "0x4009A83")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Slider _backUnitHPGauge;
    [Token(Token = "0x4009A84")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private DuelAbnormalStatusIcon _frontBadStatusIcon;
    [Token(Token = "0x4009A85")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private DuelAbnormalStatusIcon _backBadStatusIcon;
    [Token(Token = "0x4009A86")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject _frontStockCounter;
    [Token(Token = "0x4009A87")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject _backStockCounter;
    [Token(Token = "0x4009A88")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private LongPressButton _frontUnitButton;
    [Token(Token = "0x4009A89")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private LongPressButton _backUnitButton;
    [Token(Token = "0x4009A8A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject _unitNumberObject;
    [Token(Token = "0x4009A8B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI _unitNumberText;
    [Token(Token = "0x4009A8C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI _unitNumberEnText;
    [Token(Token = "0x4009A8D")]
    [FieldOffset(Offset = "0x90")]
    private UITweenGroup _tweenGroup;
    [Token(Token = "0x4009A8E")]
    [FieldOffset(Offset = "0x98")]
    private UnityAction[] _prevPressEvent;
    [Token(Token = "0x4009A8F")]
    [FieldOffset(Offset = "0xA0")]
    private UnityAction _callback;

    [Token(Token = "0x17002F81")]
    public float FrontFrameHeight
    {
      [Token(Token = "0x600DD45"), Address(RVA = "0x1E222CC", Offset = "0x1E222CC", VA = "0x1E222CC")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002F82")]
    public float BackFrameHeight
    {
      [Token(Token = "0x600DD46"), Address(RVA = "0x1E222F0", Offset = "0x1E222F0", VA = "0x1E222F0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600DD47")]
    [Address(RVA = "0x1E27A28", Offset = "0x1E27A28", VA = "0x1E27A28")]
    private void Awake()
    {
    }

    [Token(Token = "0x600DD48")]
    [Address(RVA = "0x1E2262C", Offset = "0x1E2262C", VA = "0x1E2262C")]
    public void PlayTweenAnimation(string groupID, bool stopPlayingAnim, UnityAction callback)
    {
    }

    [Token(Token = "0x600DD49")]
    [Address(RVA = "0x1E22DF4", Offset = "0x1E22DF4", VA = "0x1E22DF4")]
    public void ResetToEndTweenAnimation(string groupID)
    {
    }

    [Token(Token = "0x600DD4A")]
    [Address(RVA = "0x1E25D9C", Offset = "0x1E25D9C", VA = "0x1E25D9C")]
    public void SetButtonEvent(FieldUnitListViewElement.IconType iconType, UnityAction pressEvent)
    {
    }

    [Token(Token = "0x600DD4B")]
    [Address(RVA = "0x1E226D8", Offset = "0x1E226D8", VA = "0x1E226D8")]
    public void SetActive(FieldUnitListViewElement.IconType iconType, bool display)
    {
    }

    [Token(Token = "0x600DD4C")]
    [Address(RVA = "0x1E228A8", Offset = "0x1E228A8", VA = "0x1E228A8")]
    public void SetBadStatusIcon(FieldUnitListViewElement.IconType iconType, Sprite badStatusIcon)
    {
    }

    [Token(Token = "0x600DD4D")]
    [Address(RVA = "0x1E22760", Offset = "0x1E22760", VA = "0x1E22760")]
    public void SetThumbnail(FieldUnitListViewElement.IconType iconType, Sprite sprite)
    {
    }

    [Token(Token = "0x600DD4E")]
    [Address(RVA = "0x1E227A8", Offset = "0x1E227A8", VA = "0x1E227A8")]
    public void SetHpGauge(
      FieldUnitListViewElement.IconType iconType,
      float currentHp,
      float maxHp)
    {
    }

    [Token(Token = "0x600DD4F")]
    [Address(RVA = "0x1E22984", Offset = "0x1E22984", VA = "0x1E22984")]
    public void SetStockCounter(
      FieldUnitListViewElement.IconType iconType,
      StockCounterData stockCounterData,
      int currentStockCounter,
      bool isAnimationDelay)
    {
    }

    [Token(Token = "0x600DD50")]
    [Address(RVA = "0x1E245A0", Offset = "0x1E245A0", VA = "0x1E245A0")]
    public void StockCounterAnimation()
    {
    }

    [Token(Token = "0x600DD51")]
    [Address(RVA = "0x1E220DC", Offset = "0x1E220DC", VA = "0x1E220DC")]
    public void SetUnitNumberObject(int num)
    {
    }

    [Token(Token = "0x600DD52")]
    [Address(RVA = "0x1E27E1C", Offset = "0x1E27E1C", VA = "0x1E27E1C")]
    public FieldUnitListViewElement()
    {
    }

    [Token(Token = "0x200241E")]
    public enum IconType
    {
      [Token(Token = "0x4009A91")] Front,
      [Token(Token = "0x4009A92")] Back,
    }
  }
}
