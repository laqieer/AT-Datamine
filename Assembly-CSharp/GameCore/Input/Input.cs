// Decompiled with JetBrains decompiler
// Type: GameCore.Input.Input
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.Input
{
  [Token(Token = "0x200144F")]
  public class Input
  {
    [Token(Token = "0x4005D7B")]
    public const int TOUCH_PINT_0 = 0;
    [Token(Token = "0x4005D7C")]
    public const int TOUCH_PINT_1 = 1;
    [Token(Token = "0x4005D7E")]
    [FieldOffset(Offset = "0x18")]
    private bool[] move;
    [Token(Token = "0x4005D7F")]
    [FieldOffset(Offset = "0x20")]
    private bool[] stop;
    [Token(Token = "0x4005D80")]
    [FieldOffset(Offset = "0x28")]
    private bool[] tap;
    [Token(Token = "0x4005D81")]
    [FieldOffset(Offset = "0x30")]
    private bool[] isFlick;
    [Token(Token = "0x4005D82")]
    [FieldOffset(Offset = "0x38")]
    private bool[] isLongTap;
    [Token(Token = "0x4005D83")]
    [FieldOffset(Offset = "0x40")]
    private bool[] beganDrag;
    [Token(Token = "0x4005D84")]
    [FieldOffset(Offset = "0x48")]
    private GameObject[] dragObject;
    [Token(Token = "0x4005D85")]
    [FieldOffset(Offset = "0x50")]
    private float[] nextPressRepertTIme;
    [Token(Token = "0x4005D86")]
    [FieldOffset(Offset = "0x58")]
    private Vector2[] tapStartPos;
    [Token(Token = "0x4005D87")]
    [FieldOffset(Offset = "0x60")]
    private Vector2[] lastEndPos;
    [Token(Token = "0x4005D88")]
    [FieldOffset(Offset = "0x68")]
    private float thresholdTapTime;
    [Token(Token = "0x4005D89")]
    [FieldOffset(Offset = "0x70")]
    private GameCore.Time.Time[] beganTime;
    [Token(Token = "0x4005D8A")]
    public const int TouchIndexMax = 2;
    [Token(Token = "0x4005D8B")]
    public const float ThresholdPressTime = 1.5f;
    [Token(Token = "0x4005D8C")]
    public const float ThresholdPressRepartTime = 0.5f;
    [Token(Token = "0x4005D8D")]
    public const float ThresholdTapTime = 0.4f;
    [Token(Token = "0x4005D8E")]
    public const float ThresholdFlickTime = 0.1f;
    [Token(Token = "0x4005D8F")]
    public const float ThresholdTapLength = 0.0235f;
    [Token(Token = "0x4005D90")]
    public const float ThresholdDragLength = 0.0094f;
    [Token(Token = "0x4005D91")]
    public const float ThresholdScrollWheel = 0.5f;
    [Token(Token = "0x4005D92")]
    [FieldOffset(Offset = "0x78")]
    private Vector2 prevMousePos;
    [Token(Token = "0x4005D93")]
    [FieldOffset(Offset = "0x80")]
    private Vector2 mouseDelta;
    [Token(Token = "0x4005D94")]
    [FieldOffset(Offset = "0x88")]
    private Touch[] touch;
    [Token(Token = "0x4005D95")]
    [FieldOffset(Offset = "0x90")]
    private DoubleTouch doubleTouch;

    [Token(Token = "0x17001187")]
    public bool Enable
    {
      [Token(Token = "0x600725C"), Address(RVA = "0x404E754", Offset = "0x404E754", VA = "0x404E754")] get
      {
        return new bool();
      }
      [Token(Token = "0x600725D"), Address(RVA = "0x404E75C", Offset = "0x404E75C", VA = "0x404E75C")] set
      {
      }
    }

    [Token(Token = "0x17001188")]
    private bool IsEditor
    {
      [Token(Token = "0x600725E"), Address(RVA = "0x404E768", Offset = "0x404E768", VA = "0x404E768")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001189")]
    private bool IsWinPC
    {
      [Token(Token = "0x600725F"), Address(RVA = "0x404E770", Offset = "0x404E770", VA = "0x404E770")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700118A")]
    public Action<Vector2, Vector2> DragStartAction
    {
      [Token(Token = "0x6007260"), Address(RVA = "0x404E78C", Offset = "0x404E78C", VA = "0x404E78C")] private get
      {
        return (Action<Vector2, Vector2>) null;
      }
      [Token(Token = "0x6007261"), Address(RVA = "0x404E794", Offset = "0x404E794", VA = "0x404E794")] set
      {
      }
    }

    [Token(Token = "0x1700118B")]
    public Action<Vector2, Vector2> DragAction
    {
      [Token(Token = "0x6007262"), Address(RVA = "0x404E79C", Offset = "0x404E79C", VA = "0x404E79C")] private get
      {
        return (Action<Vector2, Vector2>) null;
      }
      [Token(Token = "0x6007263"), Address(RVA = "0x404E7A4", Offset = "0x404E7A4", VA = "0x404E7A4")] set
      {
      }
    }

    [Token(Token = "0x1700118C")]
    public Action<Vector2, Vector2, GameObject> DragEndAction
    {
      [Token(Token = "0x6007264"), Address(RVA = "0x404E7AC", Offset = "0x404E7AC", VA = "0x404E7AC")] private get
      {
        return (Action<Vector2, Vector2, GameObject>) null;
      }
      [Token(Token = "0x6007265"), Address(RVA = "0x404E7B4", Offset = "0x404E7B4", VA = "0x404E7B4")] set
      {
      }
    }

    [Token(Token = "0x1700118D")]
    public Action<GameCore.Input.Input.Direction> FlickAction
    {
      [Token(Token = "0x6007266"), Address(RVA = "0x404E7BC", Offset = "0x404E7BC", VA = "0x404E7BC")] private get
      {
        return (Action<GameCore.Input.Input.Direction>) null;
      }
      [Token(Token = "0x6007267"), Address(RVA = "0x404E7C4", Offset = "0x404E7C4", VA = "0x404E7C4")] set
      {
      }
    }

    [Token(Token = "0x1700118E")]
    public Action<Vector2, GameObject> ReleaseAction
    {
      [Token(Token = "0x6007268"), Address(RVA = "0x404E7CC", Offset = "0x404E7CC", VA = "0x404E7CC")] private get
      {
        return (Action<Vector2, GameObject>) null;
      }
      [Token(Token = "0x6007269"), Address(RVA = "0x404E7D4", Offset = "0x404E7D4", VA = "0x404E7D4")] set
      {
      }
    }

    [Token(Token = "0x1700118F")]
    public Action<GameObject> LongPressStartAction
    {
      [Token(Token = "0x600726A"), Address(RVA = "0x404E7DC", Offset = "0x404E7DC", VA = "0x404E7DC")] private get
      {
        return (Action<GameObject>) null;
      }
      [Token(Token = "0x600726B"), Address(RVA = "0x404E7E4", Offset = "0x404E7E4", VA = "0x404E7E4")] set
      {
      }
    }

    [Token(Token = "0x17001190")]
    public Action<GameObject> LongPressAction
    {
      [Token(Token = "0x600726C"), Address(RVA = "0x404E7EC", Offset = "0x404E7EC", VA = "0x404E7EC")] private get
      {
        return (Action<GameObject>) null;
      }
      [Token(Token = "0x600726D"), Address(RVA = "0x404E7F4", Offset = "0x404E7F4", VA = "0x404E7F4")] set
      {
      }
    }

    [Token(Token = "0x17001191")]
    public Action<PinchEventData> PinchAction
    {
      [Token(Token = "0x600726E"), Address(RVA = "0x404E7FC", Offset = "0x404E7FC", VA = "0x404E7FC")] private get
      {
        return (Action<PinchEventData>) null;
      }
      [Token(Token = "0x600726F"), Address(RVA = "0x404E804", Offset = "0x404E804", VA = "0x404E804")] set
      {
      }
    }

    [Token(Token = "0x17001192")]
    public Action<Vector2, Vector2> DoubleDragAction
    {
      [Token(Token = "0x6007270"), Address(RVA = "0x404E80C", Offset = "0x404E80C", VA = "0x404E80C")] private get
      {
        return (Action<Vector2, Vector2>) null;
      }
      [Token(Token = "0x6007271"), Address(RVA = "0x404E814", Offset = "0x404E814", VA = "0x404E814")] set
      {
      }
    }

    [Token(Token = "0x17001193")]
    public Action<Vector2> DoubleTouchReleaseAction
    {
      [Token(Token = "0x6007272"), Address(RVA = "0x404E81C", Offset = "0x404E81C", VA = "0x404E81C")] private get
      {
        return (Action<Vector2>) null;
      }
      [Token(Token = "0x6007273"), Address(RVA = "0x404E824", Offset = "0x404E824", VA = "0x404E824")] set
      {
      }
    }

    [Token(Token = "0x6007274")]
    [Address(RVA = "0x404E82C", Offset = "0x404E82C", VA = "0x404E82C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6007275")]
    [Address(RVA = "0x404EC6C", Offset = "0x404EC6C", VA = "0x404EC6C")]
    private bool LongPress(int index) => new bool();

    [Token(Token = "0x6007276")]
    [Address(RVA = "0x404F088", Offset = "0x404F088", VA = "0x404F088")]
    private bool Flick(int index) => new bool();

    [Token(Token = "0x6007277")]
    [Address(RVA = "0x404F2D4", Offset = "0x404F2D4", VA = "0x404F2D4")]
    private void TouchBegin(int index)
    {
    }

    [Token(Token = "0x6007278")]
    [Address(RVA = "0x404F520", Offset = "0x404F520", VA = "0x404F520")]
    private void TouchMove(int index)
    {
    }

    [Token(Token = "0x6007279")]
    [Address(RVA = "0x404F7A4", Offset = "0x404F7A4", VA = "0x404F7A4")]
    private void TouchEnd(int index, bool isCheckSwaipe)
    {
    }

    [Token(Token = "0x600727A")]
    [Address(RVA = "0x404EEBC", Offset = "0x404EEBC", VA = "0x404EEBC")]
    private RaycastHit2D GetHitObject(int index) => new RaycastHit2D();

    [Token(Token = "0x600727B")]
    [Address(RVA = "0x404FA98", Offset = "0x404FA98", VA = "0x404FA98")]
    private void UpdateDoubleTouch(float deltaTime)
    {
    }

    [Token(Token = "0x600727C")]
    [Address(RVA = "0x404FE04", Offset = "0x404FE04", VA = "0x404FE04")]
    private bool DoubleTouchEnd() => new bool();

    [Token(Token = "0x600727D")]
    [Address(RVA = "0x404FED0", Offset = "0x404FED0", VA = "0x404FED0")]
    private bool DoubleTouchMove() => new bool();

    [Token(Token = "0x600727E")]
    [Address(RVA = "0x404FFB8", Offset = "0x404FFB8", VA = "0x404FFB8")]
    private bool Pinch() => new bool();

    [Token(Token = "0x600727F")]
    [Address(RVA = "0x4050198", Offset = "0x4050198", VA = "0x4050198")]
    public void Update(float deltaTime)
    {
    }

    [Token(Token = "0x6007280")]
    [Address(RVA = "0x4050754", Offset = "0x4050754", VA = "0x4050754")]
    public int GetInputMouseButtonCount() => new int();

    [Token(Token = "0x6007281")]
    [Address(RVA = "0x404F6A0", Offset = "0x404F6A0", VA = "0x404F6A0")]
    public bool GetTouchDeltaPosition(int touchId, ref Vector2 position) => new bool();

    [Token(Token = "0x6007282")]
    [Address(RVA = "0x404FE6C", Offset = "0x404FE6C", VA = "0x404FE6C")]
    private UnityEngine.TouchPhase GetTouchRawPhase(int touchId) => new UnityEngine.TouchPhase();

    [Token(Token = "0x6007283")]
    [Address(RVA = "0x40507BC", Offset = "0x40507BC", VA = "0x40507BC")]
    public bool GetKeyDown(KeyCode keyCode) => new bool();

    [Token(Token = "0x6007284")]
    [Address(RVA = "0x40507E8", Offset = "0x40507E8", VA = "0x40507E8")]
    public bool GetKey(KeyCode keyCode) => new bool();

    [Token(Token = "0x6007285")]
    [Address(RVA = "0x40507B4", Offset = "0x40507B4", VA = "0x40507B4")]
    private bool GetInputEnable() => new bool();

    [Token(Token = "0x6007286")]
    [Address(RVA = "0x404FCD4", Offset = "0x404FCD4", VA = "0x404FCD4")]
    public bool GetTouch(int index, ref Vector2 pos) => new bool();

    [Token(Token = "0x6007287")]
    [Address(RVA = "0x40507F4", Offset = "0x40507F4", VA = "0x40507F4")]
    public bool GetTouchLong(int index, ref Vector2 pos) => new bool();

    [Token(Token = "0x6007288")]
    [Address(RVA = "0x40505D8", Offset = "0x40505D8", VA = "0x40505D8")]
    public bool GetPress(int index, ref Vector2 pos) => new bool();

    [Token(Token = "0x6007289")]
    [Address(RVA = "0x40508B0", Offset = "0x40508B0", VA = "0x40508B0")]
    public bool GetRelease(int index, ref Vector2 pos) => new bool();

    [Token(Token = "0x600728A")]
    [Address(RVA = "0x404F420", Offset = "0x404F420", VA = "0x404F420")]
    public bool GetTouchPosition(int touchId, ref Vector2 position) => new bool();

    [Token(Token = "0x600728B")]
    [Address(RVA = "0x4050A08", Offset = "0x4050A08", VA = "0x4050A08")]
    public bool GetTap(int index, ref Vector2 pos) => new bool();

    [Token(Token = "0x600728C")]
    [Address(RVA = "0x4050B64", Offset = "0x4050B64", VA = "0x4050B64")]
    public bool GetTapStartPos(int index, ref Vector2 pos) => new bool();

    [Token(Token = "0x600728D")]
    [Address(RVA = "0x4050BC0", Offset = "0x4050BC0", VA = "0x4050BC0")]
    public bool GetBeganPosition(int touchId, ref Vector2 position) => new bool();

    [Token(Token = "0x600728E")]
    [Address(RVA = "0x4050C3C", Offset = "0x4050C3C", VA = "0x4050C3C")]
    public bool GetMovePosition(int touchId, ref Vector2 position) => new bool();

    [Token(Token = "0x600728F")]
    [Address(RVA = "0x4050CB8", Offset = "0x4050CB8", VA = "0x4050CB8")]
    public bool GetSwipeStart(int index, ref Vector2 start) => new bool();

    [Token(Token = "0x6007290")]
    [Address(RVA = "0x4050DA4", Offset = "0x4050DA4", VA = "0x4050DA4")]
    public bool GetSwipeDelta(int index, ref Vector2 deltadir) => new bool();

    [Token(Token = "0x6007291")]
    [Address(RVA = "0x404F1CC", Offset = "0x404F1CC", VA = "0x404F1CC")]
    public bool GetFlick(int index, ref Vector2 start, ref Vector2 end, ref Vector2 dir)
    {
      return new bool();
    }

    [Token(Token = "0x6007292")]
    [Address(RVA = "0x404FF70", Offset = "0x404FF70", VA = "0x404FF70")]
    public bool GetDoubleTouchMove(ref Vector2 pos, ref Vector2 dir) => new bool();

    [Token(Token = "0x6007293")]
    [Address(RVA = "0x405007C", Offset = "0x405007C", VA = "0x405007C")]
    public bool GetPinchi(ref Vector2 startPos, ref Vector2 value, ref bool isout) => new bool();

    [Token(Token = "0x6007294")]
    [Address(RVA = "0x4050EB0", Offset = "0x4050EB0", VA = "0x4050EB0")]
    public bool GetPinchLength(out float length) => new bool();

    [Token(Token = "0x6007295")]
    [Address(RVA = "0x4050B0C", Offset = "0x4050B0C", VA = "0x4050B0C")]
    public bool IsOverThresholdTap(Vector2 dir) => new bool();

    [Token(Token = "0x6007296")]
    [Address(RVA = "0x404EE64", Offset = "0x404EE64", VA = "0x404EE64")]
    public bool IsOverThresholdDrag(Vector2 dir) => new bool();

    [Token(Token = "0x6007297")]
    [Address(RVA = "0x4050F48", Offset = "0x4050F48", VA = "0x4050F48")]
    public GameCore.Input.Input.TouchPhase GetTouchPhase(int touchId) => new GameCore.Input.Input.TouchPhase();

    [Token(Token = "0x6007298")]
    [Address(RVA = "0x4051100", Offset = "0x4051100", VA = "0x4051100")]
    public void SetThresholdTapTime(float time)
    {
    }

    [Token(Token = "0x6007299")]
    [Address(RVA = "0x4051108", Offset = "0x4051108", VA = "0x4051108")]
    public void ResetThresholdTapTime()
    {
    }

    [Token(Token = "0x600729A")]
    [Address(RVA = "0x4051118", Offset = "0x4051118", VA = "0x4051118")]
    public Input()
    {
    }

    [Token(Token = "0x2001450")]
    public enum TouchPhase
    {
      [Token(Token = "0x4005DA1")] Began,
      [Token(Token = "0x4005DA2")] Moved,
      [Token(Token = "0x4005DA3")] Stationary,
      [Token(Token = "0x4005DA4")] Ended,
      [Token(Token = "0x4005DA5")] Canceled,
      [Token(Token = "0x4005DA6")] DoNot,
    }

    [Token(Token = "0x2001451")]
    public enum Direction
    {
      [Token(Token = "0x4005DA8")] DoNot,
      [Token(Token = "0x4005DA9")] Left,
      [Token(Token = "0x4005DAA")] Up,
      [Token(Token = "0x4005DAB")] Right,
      [Token(Token = "0x4005DAC")] Down,
    }
  }
}
