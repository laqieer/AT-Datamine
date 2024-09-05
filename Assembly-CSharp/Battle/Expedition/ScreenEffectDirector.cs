// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.ScreenEffectDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Battle.Expedition
{
  [Token(Token = "0x20025D5")]
  public class ScreenEffectDirector : MonoBehaviour, ISubDirector<MainDirector>
  {
    [Token(Token = "0x400A2B6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;

    [Token(Token = "0x170031EC")]
    public bool Initialized
    {
      [Token(Token = "0x600E9B2"), Address(RVA = "0x4C4B904", Offset = "0x4C4B904", VA = "0x4C4B904", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E9B3"), Address(RVA = "0x4C4B90C", Offset = "0x4C4B90C", VA = "0x4C4B90C")] private set
      {
      }
    }

    [Token(Token = "0x170031ED")]
    public bool IsPlaying
    {
      [Token(Token = "0x600E9B4"), Address(RVA = "0x4C4B918", Offset = "0x4C4B918", VA = "0x4C4B918")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E9B5"), Address(RVA = "0x4C4B920", Offset = "0x4C4B920", VA = "0x4C4B920")] private set
      {
      }
    }

    [Token(Token = "0x170031EE")]
    public bool IsEffectOn
    {
      [Token(Token = "0x600E9B6"), Address(RVA = "0x4C4B92C", Offset = "0x4C4B92C", VA = "0x4C4B92C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E9B7"), Address(RVA = "0x4C4B934", Offset = "0x4C4B934", VA = "0x4C4B934")] private set
      {
      }
    }

    [Token(Token = "0x600E9B8")]
    [Address(RVA = "0x4C4A9C0", Offset = "0x4C4A9C0", VA = "0x4C4A9C0", Slot = "5")]
    public void Initialize(MainDirector mainDirector)
    {
    }

    [Token(Token = "0x600E9B9")]
    [Address(RVA = "0x4C4B940", Offset = "0x4C4B940", VA = "0x4C4B940", Slot = "6")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E9BA")]
    [Address(RVA = "0x4C4AC80", Offset = "0x4C4AC80", VA = "0x4C4AC80", Slot = "7")]
    public void Release()
    {
    }

    [Token(Token = "0x600E9BB")]
    [Address(RVA = "0x4C4B944", Offset = "0x4C4B944", VA = "0x4C4B944")]
    public void PlayFieldEntry()
    {
    }

    [Token(Token = "0x600E9BC")]
    [Address(RVA = "0x4C4BA08", Offset = "0x4C4BA08", VA = "0x4C4BA08")]
    public void PlayFieldExit()
    {
    }

    [Token(Token = "0x600E9BD")]
    [Address(RVA = "0x4C4BACC", Offset = "0x4C4BACC", VA = "0x4C4BACC")]
    public ScreenEffectDirector()
    {
    }
  }
}
