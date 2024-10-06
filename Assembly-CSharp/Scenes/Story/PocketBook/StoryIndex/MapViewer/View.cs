// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.MapViewer.View
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using Scenes.Story.PocketBook.StoryIndex.Map.UI;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.MapViewer
{
  [Token(Token = "0x2002E2A")]
  public class View
  {
    [Token(Token = "0x400C628")]
    [FieldOffset(Offset = "0x60")]
    private AreaMapView areamapView;
    [Token(Token = "0x400C629")]
    [FieldOffset(Offset = "0x68")]
    private IconView iconView;
    [Token(Token = "0x400C62A")]
    [FieldOffset(Offset = "0x70")]
    private PlayerView playerView;
    [Token(Token = "0x400C62B")]
    [FieldOffset(Offset = "0x78")]
    private MapUIAnimation mapAnimationController;
    [Token(Token = "0x400C62C")]
    [FieldOffset(Offset = "0x80")]
    private readonly Input input;
    [Token(Token = "0x400C62D")]
    private const float SCALE_THRESHOLD_OF_AUTO_POSITION = 1f;
    [Token(Token = "0x400C62E")]
    private const float FRAME_IN_SPEED = 0.5f;
    [Token(Token = "0x400C62F")]
    [FieldOffset(Offset = "0x88")]
    private Coroutine coAreaChanging;
    [Token(Token = "0x400C630")]
    [FieldOffset(Offset = "0x90")]
    private int viewAreaID;

    [Token(Token = "0x1400016E")]
    public event Action<FreeMapUIParamBase> OnClickIcon
    {
      [Token(Token = "0x6012098"), Address(RVA = "0x437D038", Offset = "0x437D038", VA = "0x437D038")] add
      {
      }
      [Token(Token = "0x6012099"), Address(RVA = "0x437D830", Offset = "0x437D830", VA = "0x437D830")] remove
      {
      }
    }

    [Token(Token = "0x1400016F")]
    public event Action<int> OnClickTransition
    {
      [Token(Token = "0x601209A"), Address(RVA = "0x437D0E8", Offset = "0x437D0E8", VA = "0x437D0E8")] add
      {
      }
      [Token(Token = "0x601209B"), Address(RVA = "0x437D8E0", Offset = "0x437D8E0", VA = "0x437D8E0")] remove
      {
      }
    }

    [Token(Token = "0x17003D68")]
    public CurrentFreeActionParam CurrentFreeActionParam
    {
      [Token(Token = "0x601209C"), Address(RVA = "0x437D990", Offset = "0x437D990", VA = "0x437D990")] get
      {
        return (CurrentFreeActionParam) null;
      }
      [Token(Token = "0x601209D"), Address(RVA = "0x437D998", Offset = "0x437D998", VA = "0x437D998")] set
      {
      }
    }

    [Token(Token = "0x17003D69")]
    public MapUI MapUI
    {
      [Token(Token = "0x601209E"), Address(RVA = "0x437D9A0", Offset = "0x437D9A0", VA = "0x437D9A0")] get
      {
        return (MapUI) null;
      }
      [Token(Token = "0x601209F"), Address(RVA = "0x437D9A8", Offset = "0x437D9A8", VA = "0x437D9A8")] set
      {
      }
    }

    [Token(Token = "0x17003D6A")]
    public Image MapImage
    {
      [Token(Token = "0x60120A0"), Address(RVA = "0x4378D20", Offset = "0x4378D20", VA = "0x4378D20")] get
      {
        return (Image) null;
      }
    }

    [Token(Token = "0x17003D6B")]
    public RectTransform MapRectTransform
    {
      [Token(Token = "0x60120A1"), Address(RVA = "0x4378C88", Offset = "0x4378C88", VA = "0x4378C88")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003D6C")]
    public RectTransform FrameRectTransform
    {
      [Token(Token = "0x60120A2"), Address(RVA = "0x437D9B0", Offset = "0x437D9B0", VA = "0x437D9B0")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003D6D")]
    public Func<IEnumerator, Coroutine> StartCoroutine
    {
      [Token(Token = "0x60120A3"), Address(RVA = "0x437DA28", Offset = "0x437DA28", VA = "0x437DA28")] get
      {
        return (Func<IEnumerator, Coroutine>) null;
      }
      [Token(Token = "0x60120A4"), Address(RVA = "0x437DA30", Offset = "0x437DA30", VA = "0x437DA30")] set
      {
      }
    }

    [Token(Token = "0x17003D6E")]
    public PocketBookLoader Loader
    {
      [Token(Token = "0x60120A5"), Address(RVA = "0x437DA38", Offset = "0x437DA38", VA = "0x437DA38")] get
      {
        return (PocketBookLoader) null;
      }
      [Token(Token = "0x60120A6"), Address(RVA = "0x437DA40", Offset = "0x437DA40", VA = "0x437DA40")] set
      {
      }
    }

    [Token(Token = "0x17003D6F")]
    public SpriteAtlas IconAtlas
    {
      [Token(Token = "0x60120A7"), Address(RVA = "0x437DA48", Offset = "0x437DA48", VA = "0x437DA48")] get
      {
        return (SpriteAtlas) null;
      }
      [Token(Token = "0x60120A8"), Address(RVA = "0x437DA50", Offset = "0x437DA50", VA = "0x437DA50")] set
      {
      }
    }

    [Token(Token = "0x17003D70")]
    public SpriteAtlas CharaIconAtlas
    {
      [Token(Token = "0x60120A9"), Address(RVA = "0x437DA58", Offset = "0x437DA58", VA = "0x437DA58")] get
      {
        return (SpriteAtlas) null;
      }
      [Token(Token = "0x60120AA"), Address(RVA = "0x437DA60", Offset = "0x437DA60", VA = "0x437DA60")] set
      {
      }
    }

    [Token(Token = "0x17003D71")]
    public MinimapRectalize Rectalize
    {
      [Token(Token = "0x60120AB"), Address(RVA = "0x437DA68", Offset = "0x437DA68", VA = "0x437DA68")] get
      {
        return (MinimapRectalize) null;
      }
      [Token(Token = "0x60120AC"), Address(RVA = "0x437DA70", Offset = "0x437DA70", VA = "0x437DA70")] private set
      {
      }
    }

    [Token(Token = "0x17003D72")]
    public EventData<float> PinchRate
    {
      [Token(Token = "0x60120AD"), Address(RVA = "0x437DA78", Offset = "0x437DA78", VA = "0x437DA78")] get
      {
        return (EventData<float>) null;
      }
      [Token(Token = "0x60120AE"), Address(RVA = "0x437DA80", Offset = "0x437DA80", VA = "0x437DA80")] private set
      {
      }
    }

    [Token(Token = "0x60120AF")]
    [Address(RVA = "0x4370C88", Offset = "0x4370C88", VA = "0x4370C88")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60120B0")]
    [Address(RVA = "0x4371068", Offset = "0x4371068", VA = "0x4371068")]
    public IEnumerator PreLoad() => (IEnumerator) null;

    [Token(Token = "0x60120B1")]
    [Address(RVA = "0x437DAB0", Offset = "0x437DAB0", VA = "0x437DAB0")]
    public void ChangeArea(int areaID)
    {
    }

    [Token(Token = "0x60120B2")]
    [Address(RVA = "0x437DB54", Offset = "0x437DB54", VA = "0x437DB54")]
    private void ChangeAreaInternal(int areaID, IEnumerator changeArea)
    {
    }

    [Token(Token = "0x60120B3")]
    [Address(RVA = "0x437DBF8", Offset = "0x437DBF8", VA = "0x437DBF8")]
    public void SelectIcon(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x60120B4")]
    [Address(RVA = "0x437DCAC", Offset = "0x437DCAC", VA = "0x437DCAC")]
    public void UnSelectIcon(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x60120B5")]
    [Address(RVA = "0x437DBA0", Offset = "0x437DBA0", VA = "0x437DBA0")]
    public void ChangeAreaName(int areaID)
    {
    }

    [Token(Token = "0x60120B6")]
    [Address(RVA = "0x437DADC", Offset = "0x437DADC", VA = "0x437DADC")]
    private IEnumerator ChangeAreaMap(int areaID) => (IEnumerator) null;

    [Token(Token = "0x60120B7")]
    [Address(RVA = "0x437DCEC", Offset = "0x437DCEC", VA = "0x437DCEC")]
    private static bool IsPlayingArea(CurrentFreeActionParam freeActionParam, int areaID)
    {
      return new bool();
    }

    [Token(Token = "0x60120B8")]
    [Address(RVA = "0x437DD80", Offset = "0x437DD80", VA = "0x437DD80")]
    public void Update()
    {
    }

    [Token(Token = "0x60120B9")]
    [Address(RVA = "0x437DE14", Offset = "0x437DE14", VA = "0x437DE14")]
    private void AutoPositionCenter()
    {
    }

    [Token(Token = "0x60120BA")]
    [Address(RVA = "0x437DE98", Offset = "0x437DE98", VA = "0x437DE98")]
    private void AutoPositionInFrame()
    {
    }

    [Token(Token = "0x60120BB")]
    [Address(RVA = "0x437E0BC", Offset = "0x437E0BC", VA = "0x437E0BC")]
    private Vector2 CalculateSize(RectTransform rectTransform) => new Vector2();

    [Token(Token = "0x60120BC")]
    [Address(RVA = "0x437E05C", Offset = "0x437E05C", VA = "0x437E05C")]
    private void OnMove(Vector2 delta)
    {
    }

    [Token(Token = "0x60120BD")]
    [Address(RVA = "0x437E144", Offset = "0x437E144", VA = "0x437E144")]
    private void OnPinch(float delta)
    {
    }

    [Token(Token = "0x60120BE")]
    [Address(RVA = "0x437E1C4", Offset = "0x437E1C4", VA = "0x437E1C4")]
    private void OnScale(float scale)
    {
    }

    [Token(Token = "0x60120BF")]
    [Address(RVA = "0x437E264", Offset = "0x437E264", VA = "0x437E264")]
    public void RefreshIcon()
    {
    }

    [Token(Token = "0x60120C0")]
    [Address(RVA = "0x437E314", Offset = "0x437E314", VA = "0x437E314")]
    private void Reset()
    {
    }

    [Token(Token = "0x60120C1")]
    [Address(RVA = "0x437E39C", Offset = "0x437E39C", VA = "0x437E39C")]
    private void PositionReset()
    {
    }

    [Token(Token = "0x60120C2")]
    [Address(RVA = "0x4370BE0", Offset = "0x4370BE0", VA = "0x4370BE0")]
    public View()
    {
    }
  }
}
