// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestSelectBg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using Tween.Tweeners;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033E6")]
  public class QuestSelectBg : MonoBehaviour
  {
    [Token(Token = "0x400E181")]
    private const string TWEEN_IN_BG = "QueBg_In";
    [Token(Token = "0x400E182")]
    private const string TWEEN_OUT_BG = "QueBg_Out";
    [Token(Token = "0x400E183")]
    private const string TWEEN_MAP_MOVE = "Map_Move";
    [Token(Token = "0x400E184")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<QuestSelectBg.TweenType, string> tweenMap;
    [Token(Token = "0x400E185")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image bgImage;
    [Token(Token = "0x400E186")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400E187")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400E188")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RectTransform limitArea;
    [Token(Token = "0x400E189")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RectTransform centerPosition;
    [Token(Token = "0x400E18A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TweenAnchorPosition tweenAnchorPosition;
    [Token(Token = "0x400E18B")]
    [FieldOffset(Offset = "0x50")]
    private QuestSelectMapObject mapObjBase;
    [Token(Token = "0x400E18C")]
    [FieldOffset(Offset = "0x58")]
    private List<QuestSelectMapObject> mapObjectList;
    [Token(Token = "0x400E18D")]
    [FieldOffset(Offset = "0x60")]
    private List<Vector2> mapPositionList;
    [Token(Token = "0x400E18E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Camera renderTextureCamera;
    [Token(Token = "0x400E18F")]
    [FieldOffset(Offset = "0x70")]
    private RenderTexture renderTexture;
    [Token(Token = "0x400E190")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Transform dotUnitParent;
    [Token(Token = "0x400E191")]
    [FieldOffset(Offset = "0x80")]
    private GameObject dotUnit;

    [Token(Token = "0x170043F9")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6014655"), Address(RVA = "0x1889F18", Offset = "0x1889F18", VA = "0x1889F18")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170043FA")]
    public bool IsTweenPlaying
    {
      [Token(Token = "0x6014656"), Address(RVA = "0x1889F20", Offset = "0x1889F20", VA = "0x1889F20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6014657")]
    [Address(RVA = "0x1889F3C", Offset = "0x1889F3C", VA = "0x1889F3C")]
    public void DeactiveRenderCamera()
    {
    }

    [Token(Token = "0x6014658")]
    [Address(RVA = "0x1889F68", Offset = "0x1889F68", VA = "0x1889F68")]
    public void Initialize(Sprite mapSprite)
    {
    }

    [Token(Token = "0x6014659")]
    [Address(RVA = "0x188A064", Offset = "0x188A064", VA = "0x188A064")]
    public void CreateDotUnit(GameObject dotUnit, RenderTexture renderTexture)
    {
    }

    [Token(Token = "0x601465A")]
    [Address(RVA = "0x188A2AC", Offset = "0x188A2AC", VA = "0x188A2AC")]
    public void SetupMapPosition(
      GameObject mapObj,
      StorySubquestFirstPositionData firstPositionData,
      IEnumerable<QuestMapPositionData> questMapPositionDatas)
    {
    }

    [Token(Token = "0x601465B")]
    [Address(RVA = "0x188A6D4", Offset = "0x188A6D4", VA = "0x188A6D4")]
    public void CreateMapIcon(
      IEnumerable<QuestMapPositionData> questMapPositionDatas,
      bool isDestroyIcon = true)
    {
    }

    [Token(Token = "0x601465C")]
    [Address(RVA = "0x188AD0C", Offset = "0x188AD0C", VA = "0x188AD0C")]
    public void SetMapIconCallback(Action<int> onClickMapIcon)
    {
    }

    [Token(Token = "0x601465D")]
    [Address(RVA = "0x188A5C4", Offset = "0x188A5C4", VA = "0x188A5C4")]
    private void UpdatePosition(QuestSelectMapObject target)
    {
    }

    [Token(Token = "0x601465E")]
    [Address(RVA = "0x188AE40", Offset = "0x188AE40", VA = "0x188AE40")]
    private void UpdatePosition()
    {
    }

    [Token(Token = "0x601465F")]
    [Address(RVA = "0x188AEEC", Offset = "0x188AEEC", VA = "0x188AEEC")]
    public IEnumerator MoveMap(int index) => (IEnumerator) null;

    [Token(Token = "0x6014660")]
    [Address(RVA = "0x188AF8C", Offset = "0x188AF8C", VA = "0x188AF8C")]
    public void PlayToEnableAnimation()
    {
    }

    [Token(Token = "0x6014661")]
    [Address(RVA = "0x188AFFC", Offset = "0x188AFFC", VA = "0x188AFFC")]
    public void PlayToDisableAnimation()
    {
    }

    [Token(Token = "0x6014662")]
    [Address(RVA = "0x188AB80", Offset = "0x188AB80", VA = "0x188AB80")]
    public void DestroyMapIcon()
    {
    }

    [Token(Token = "0x6014663")]
    [Address(RVA = "0x188B06C", Offset = "0x188B06C", VA = "0x188B06C")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6014664")]
    [Address(RVA = "0x188B148", Offset = "0x188B148", VA = "0x188B148")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6014665")]
    [Address(RVA = "0x188B1C8", Offset = "0x188B1C8", VA = "0x188B1C8")]
    public QuestSelectBg()
    {
    }

    [Token(Token = "0x20033E7")]
    public enum TweenType
    {
      [Token(Token = "0x400E193")] InBg,
      [Token(Token = "0x400E194")] OutBg,
    }
  }
}
