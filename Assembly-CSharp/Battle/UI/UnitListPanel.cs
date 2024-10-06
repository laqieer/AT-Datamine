// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitListPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.UI.Option;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData.StatusIcon;
using System;
using System.Collections.Generic;
using UI.Utilities.SerializeUI;
using UnitDetail.Data.ScriptableObjects;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200233A")]
  public class UnitListPanel : MonoBehaviour, IDisposable
  {
    [Token(Token = "0x4009572")]
    private const string ShowAnimationName = "In";
    [Token(Token = "0x4009573")]
    private const string HideAnimationName = "Out";
    [Token(Token = "0x4009574")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UnitFeatureTable features;
    [Token(Token = "0x4009575")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UnitListPanel.UnitListToggleUISet[] toggleUISets;
    [Token(Token = "0x4009576")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4009577")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<Image> badStatusHeaderIcons;
    [Token(Token = "0x4009578")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x4009579")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton forceChangeButton;
    [Token(Token = "0x400957A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<TextContainer> changeForceButtonTexts;
    [Token(Token = "0x400957B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400957C")]
    [FieldOffset(Offset = "0x58")]
    private UnitListConfig unitListConfig;
    [Token(Token = "0x400957D")]
    [FieldOffset(Offset = "0x60")]
    private GameObject LeftSidePartsPrefab;
    [Token(Token = "0x400957E")]
    [FieldOffset(Offset = "0x68")]
    private GameObject centerPartsPrefab;
    [Token(Token = "0x400957F")]
    [FieldOffset(Offset = "0x70")]
    private UnitListPanel.UnitListForceType currentForce;
    [Token(Token = "0x4009580")]
    [FieldOffset(Offset = "0x74")]
    private UnitStatusFactorBase.UnitListShowFactor currentShowFactor;
    [Token(Token = "0x4009581")]
    [FieldOffset(Offset = "0x78")]
    private BoardData board;
    [Token(Token = "0x4009582")]
    [FieldOffset(Offset = "0x80")]
    private List<UnitListPanel.ScrollListElement> activeUnitStatusPanels;
    [Token(Token = "0x4009583")]
    [FieldOffset(Offset = "0x88")]
    private Queue<UnitListPanel.ScrollListElement> inactiveUnitStatusPanels;
    [Token(Token = "0x4009584")]
    [FieldOffset(Offset = "0x90")]
    private IconFactory iconFactory;
    [Token(Token = "0x4009585")]
    [FieldOffset(Offset = "0x98")]
    private List<string> tweenPlayList;
    [Token(Token = "0x4009586")]
    [FieldOffset(Offset = "0xA0")]
    private UnityAction tweenCallback;
    [Token(Token = "0x4009587")]
    [FieldOffset(Offset = "0xA8")]
    private UnitStatusFactorBase.Context context;
    [Token(Token = "0x4009588")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private ScrollRect headerTopScrollRect;
    [Token(Token = "0x4009589")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private ScrollRect statusCenterScrollRect;
    [Token(Token = "0x400958A")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private ScrollRect unitLeftSideScrollRect;
    [Token(Token = "0x400958B")]
    [FieldOffset(Offset = "0xD8")]
    private bool disposed;
    [Token(Token = "0x400958C")]
    [FieldOffset(Offset = "0xD9")]
    [SerializeField]
    private bool variableScrollFlag;
    [Token(Token = "0x400958D")]
    [FieldOffset(Offset = "0xE0")]
    private IUnitListPanelEventHandler readyProcessEventHandler;
    [Token(Token = "0x400958E")]
    [FieldOffset(Offset = "0xE8")]
    private IUnitListPanelEventHandler playerPhaseCommandStepEventHandler;
    [Token(Token = "0x400958F")]
    [FieldOffset(Offset = "0xF0")]
    private int elementMaxCount;
    [Token(Token = "0x4009590")]
    [FieldOffset(Offset = "0xF4")]
    private float contentAreaHeight;
    [Token(Token = "0x4009591")]
    [FieldOffset(Offset = "0xF8")]
    private float viewportHeight;
    [Token(Token = "0x4009592")]
    [FieldOffset(Offset = "0xFC")]
    private int visibleElementMaxCount;
    [Token(Token = "0x4009593")]
    [FieldOffset(Offset = "0x100")]
    private float scrolledHeight;
    [Token(Token = "0x4009594")]
    [FieldOffset(Offset = "0x104")]
    private int startIndex;
    [Token(Token = "0x4009595")]
    [FieldOffset(Offset = "0x108")]
    private int prevStartIndex;
    [Token(Token = "0x4009596")]
    [FieldOffset(Offset = "0x10C")]
    private float prevNormalizedPositionY;
    [Token(Token = "0x4009597")]
    [FieldOffset(Offset = "0x110")]
    private List<UnitListPanel.ScrollListElement> unitElementDataList;
    [Token(Token = "0x4009598")]
    [FieldOffset(Offset = "0x118")]
    private float elementHeight;
    [Token(Token = "0x4009599")]
    [FieldOffset(Offset = "0x11C")]
    private bool isNeedLp;

    [Token(Token = "0x600D75B")]
    [Address(RVA = "0x1D275BC", Offset = "0x1D275BC", VA = "0x1D275BC")]
    private void InitializeElements()
    {
    }

    [Token(Token = "0x600D75C")]
    [Address(RVA = "0x1D28A58", Offset = "0x1D28A58", VA = "0x1D28A58")]
    private UnityAction<UnitParameterData> GetOnSelectUnitEvent()
    {
      return (UnityAction<UnitParameterData>) null;
    }

    [Token(Token = "0x600D75D")]
    [Address(RVA = "0x1D28B80", Offset = "0x1D28B80", VA = "0x1D28B80")]
    private void SetUpPanel(
      UnitStatusFactorBase factor,
      float offsetHeight,
      UnitListPanel.ScrollListElement scrollListElement)
    {
    }

    [Token(Token = "0x600D75E")]
    [Address(RVA = "0x1D28CF0", Offset = "0x1D28CF0", VA = "0x1D28CF0")]
    private void UpdateViewUnitList()
    {
    }

    [Token(Token = "0x600D75F")]
    [Address(RVA = "0x1D289C8", Offset = "0x1D289C8", VA = "0x1D289C8")]
    private int GetViewElementStartIndex(float height) => new int();

    [Token(Token = "0x600D760")]
    [Address(RVA = "0x1D29148", Offset = "0x1D29148", VA = "0x1D29148")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D761")]
    [Address(RVA = "0x1D29180", Offset = "0x1D29180", VA = "0x1D29180")]
    public void Initialize(IconFactory iconFactory, UnityAction closeButtonEvent)
    {
    }

    [Token(Token = "0x600D762")]
    [Address(RVA = "0x1D29164", Offset = "0x1D29164", VA = "0x1D29164", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600D763")]
    [Address(RVA = "0x1D29A14", Offset = "0x1D29A14", VA = "0x1D29A14")]
    public void SetReadyProcessEventHandler(IUnitListPanelEventHandler handler)
    {
    }

    [Token(Token = "0x600D764")]
    [Address(RVA = "0x1D29A1C", Offset = "0x1D29A1C", VA = "0x1D29A1C")]
    public void SetPlayerPhaseCommandStepEventHandler(IUnitListPanelEventHandler handler)
    {
    }

    [Token(Token = "0x600D765")]
    [Address(RVA = "0x1D29A04", Offset = "0x1D29A04", VA = "0x1D29A04")]
    public void ReleaseReadyProcessEventHandler()
    {
    }

    [Token(Token = "0x600D766")]
    [Address(RVA = "0x1D29A0C", Offset = "0x1D29A0C", VA = "0x1D29A0C")]
    public void ReleasePlayerPhaseCommandStepEventHandler()
    {
    }

    [Token(Token = "0x600D767")]
    [Address(RVA = "0x1D29A24", Offset = "0x1D29A24", VA = "0x1D29A24")]
    public void Show(BoardData board, bool isNeedLp, UnityAction callback = null)
    {
    }

    [Token(Token = "0x600D768")]
    [Address(RVA = "0x1D29D34", Offset = "0x1D29D34", VA = "0x1D29D34")]
    public void AddTweenPlayList(string groupId)
    {
    }

    [Token(Token = "0x600D769")]
    [Address(RVA = "0x1D29BA4", Offset = "0x1D29BA4", VA = "0x1D29BA4")]
    public void ResetTweenPlayList(bool isRollback)
    {
    }

    [Token(Token = "0x600D76A")]
    [Address(RVA = "0x1D29DDC", Offset = "0x1D29DDC", VA = "0x1D29DDC")]
    public void PlayTweenPlayList(UnityAction callback)
    {
    }

    [Token(Token = "0x600D76B")]
    [Address(RVA = "0x1D29ECC", Offset = "0x1D29ECC", VA = "0x1D29ECC")]
    public void Hide(UnityAction callback = null)
    {
    }

    [Token(Token = "0x600D76C")]
    [Address(RVA = "0x1D27E88", Offset = "0x1D27E88", VA = "0x1D27E88")]
    private List<UnitListPanel.ScrollListElement> CreateUnitElements()
    {
      return (List<UnitListPanel.ScrollListElement>) null;
    }

    [Token(Token = "0x600D76D")]
    [Address(RVA = "0x1D28C3C", Offset = "0x1D28C3C", VA = "0x1D28C3C")]
    private void UpdatePanel(UnitStatusFactorBase parts, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D76E")]
    [Address(RVA = "0x1D29F60", Offset = "0x1D29F60", VA = "0x1D29F60")]
    private void ResetUnitStatusList()
    {
    }

    [Token(Token = "0x600D76F")]
    [Address(RVA = "0x1D2A21C", Offset = "0x1D2A21C", VA = "0x1D2A21C")]
    public void OnChangedValueTag(bool isOn, UnitListPanel.UnitListToggleUISet uiSet)
    {
    }

    [Token(Token = "0x600D770")]
    [Address(RVA = "0x1D2A5C8", Offset = "0x1D2A5C8", VA = "0x1D2A5C8")]
    public void OnClickSwitchForce()
    {
    }

    [Token(Token = "0x600D771")]
    [Address(RVA = "0x1D2A684", Offset = "0x1D2A684", VA = "0x1D2A684")]
    public void OnChangeUnitScrollRect(Vector2 pos)
    {
    }

    [Token(Token = "0x600D772")]
    [Address(RVA = "0x1D2A6EC", Offset = "0x1D2A6EC", VA = "0x1D2A6EC")]
    public void OnChangeHeaderScrollRect(Vector2 pos)
    {
    }

    [Token(Token = "0x600D773")]
    [Address(RVA = "0x1D2A728", Offset = "0x1D2A728", VA = "0x1D2A728")]
    public void OnChangeScrollRect(Vector2 pos)
    {
    }

    [Token(Token = "0x600D774")]
    [Address(RVA = "0x1D2A7B8", Offset = "0x1D2A7B8", VA = "0x1D2A7B8")]
    public UnitListPanel()
    {
    }

    [Token(Token = "0x200233B")]
    private enum UnitListForceType
    {
      [Token(Token = "0x400959B")] Ally,
      [Token(Token = "0x400959C")] Enemy,
    }

    [Token(Token = "0x200233C")]
    [Serializable]
    public sealed class UnitListToggleUISet
    {
      [Token(Token = "0x400959D")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private UnitListToggle factorToggle;
      [Token(Token = "0x400959E")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private CanvasGroup headline;
      [Token(Token = "0x400959F")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private float headerContentAreaWidth;
      [Token(Token = "0x40095A0")]
      [FieldOffset(Offset = "0x24")]
      [SerializeField]
      private float centerStatusWidth;
      [Token(Token = "0x40095A1")]
      [FieldOffset(Offset = "0x28")]
      [SerializeField]
      private UnitStatusFactorBase.UnitListShowFactor factor;

      [Token(Token = "0x17002E63")]
      public UnitListToggle FactorToggle
      {
        [Token(Token = "0x600D775"), Address(RVA = "0x1B87E00", Offset = "0x1B87E00", VA = "0x1B87E00")] get
        {
          return (UnitListToggle) null;
        }
      }

      [Token(Token = "0x17002E64")]
      public CanvasGroup Headline
      {
        [Token(Token = "0x600D776"), Address(RVA = "0x1B87E08", Offset = "0x1B87E08", VA = "0x1B87E08")] get
        {
          return (CanvasGroup) null;
        }
      }

      [Token(Token = "0x17002E65")]
      public float HeaderContentAreaWidth
      {
        [Token(Token = "0x600D777"), Address(RVA = "0x1B87E10", Offset = "0x1B87E10", VA = "0x1B87E10")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x17002E66")]
      public float CenterStatusWidth
      {
        [Token(Token = "0x600D778"), Address(RVA = "0x1B87E18", Offset = "0x1B87E18", VA = "0x1B87E18")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x17002E67")]
      public UnitStatusFactorBase.UnitListShowFactor Factor
      {
        [Token(Token = "0x600D779"), Address(RVA = "0x1B87E20", Offset = "0x1B87E20", VA = "0x1B87E20")] get
        {
          return new UnitStatusFactorBase.UnitListShowFactor();
        }
      }

      [Token(Token = "0x600D77A")]
      [Address(RVA = "0x1B87E28", Offset = "0x1B87E28", VA = "0x1B87E28")]
      public void SetActive(bool flag, bool changeToggle = false)
      {
      }

      [Token(Token = "0x600D77B")]
      [Address(RVA = "0x1B87E84", Offset = "0x1B87E84", VA = "0x1B87E84")]
      public UnitListToggleUISet()
      {
      }
    }

    [Token(Token = "0x200233D")]
    private class ScrollListElement
    {
      [Token(Token = "0x40095A2")]
      [FieldOffset(Offset = "0x10")]
      public UnitParameterData UnitParameterData;
      [Token(Token = "0x40095A3")]
      [FieldOffset(Offset = "0x18")]
      public List<UnitStatusFactorBase> Elements;
      [Token(Token = "0x40095A4")]
      [FieldOffset(Offset = "0x20")]
      private int index;

      [Token(Token = "0x17002E68")]
      public int Index
      {
        [Token(Token = "0x600D77C"), Address(RVA = "0x1B87E8C", Offset = "0x1B87E8C", VA = "0x1B87E8C")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x600D77D")]
      [Address(RVA = "0x1B87E94", Offset = "0x1B87E94", VA = "0x1B87E94")]
      public ScrollListElement(int index)
      {
      }

      [Token(Token = "0x200233E")]
      public enum ElementType
      {
        [Token(Token = "0x40095A6")] Unit,
        [Token(Token = "0x40095A7")] Status,
        [Token(Token = "0x40095A8")] Max,
      }
    }
  }
}
