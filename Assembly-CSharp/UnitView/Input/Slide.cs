// Decompiled with JetBrains decompiler
// Type: UnitView.Input.Slide
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UnitView.Input
{
  [Token(Token = "0x20003F5")]
  public class Slide
  {
    [Token(Token = "0x40016B8")]
    [FieldOffset(Offset = "0x10")]
    private Slide.InputData begin;
    [Token(Token = "0x40016B9")]
    [FieldOffset(Offset = "0x18")]
    private Slide.InputData end;

    [Token(Token = "0x60016BD")]
    [Address(RVA = "0x2488E90", Offset = "0x2488E90", VA = "0x2488E90")]
    public void OnPointerDown(Vector2 screenPos)
    {
    }

    [Token(Token = "0x60016BE")]
    [Address(RVA = "0x2488ED0", Offset = "0x2488ED0", VA = "0x2488ED0")]
    public Slide.OutputData OnPointerUp(Vector2 screenPos) => new Slide.OutputData();

    [Token(Token = "0x60016BF")]
    [Address(RVA = "0x2488F68", Offset = "0x2488F68", VA = "0x2488F68")]
    public Slide()
    {
    }

    [Token(Token = "0x20003F6")]
    public class InputData
    {
      [Token(Token = "0x17000281")]
      public Vector2 ScreenPos
      {
        [Token(Token = "0x60016C0"), Address(RVA = "0x2488FF4", Offset = "0x2488FF4", VA = "0x2488FF4")] get
        {
          return new Vector2();
        }
        [Token(Token = "0x60016C1"), Address(RVA = "0x2488FFC", Offset = "0x2488FFC", VA = "0x2488FFC")] private set
        {
        }
      }

      [Token(Token = "0x17000282")]
      public float Time
      {
        [Token(Token = "0x60016C2"), Address(RVA = "0x2489004", Offset = "0x2489004", VA = "0x2489004")] get
        {
          return new float();
        }
        [Token(Token = "0x60016C3"), Address(RVA = "0x248900C", Offset = "0x248900C", VA = "0x248900C")] private set
        {
        }
      }

      [Token(Token = "0x60016C4")]
      [Address(RVA = "0x2488EC0", Offset = "0x2488EC0", VA = "0x2488EC0")]
      public void SetScreenPos(Vector2 screenPos)
      {
      }

      [Token(Token = "0x60016C5")]
      [Address(RVA = "0x2488EC8", Offset = "0x2488EC8", VA = "0x2488EC8")]
      public void SetTime(float time)
      {
      }

      [Token(Token = "0x60016C6")]
      [Address(RVA = "0x2489014", Offset = "0x2489014", VA = "0x2489014")]
      public Vector2 GetDirectionTo(Slide.InputData destination) => new Vector2();

      [Token(Token = "0x60016C7")]
      [Address(RVA = "0x2488FEC", Offset = "0x2488FEC", VA = "0x2488FEC")]
      public InputData()
      {
      }
    }

    [Token(Token = "0x20003F7")]
    public struct OutputData
    {
      [Token(Token = "0x17000283")]
      public Vector2 Direction
      {
        [Token(Token = "0x60016C8"), Address(RVA = "0x2489038", Offset = "0x2489038", VA = "0x2489038")] readonly get
        {
          return new Vector2();
        }
        [Token(Token = "0x60016C9"), Address(RVA = "0x2489040", Offset = "0x2489040", VA = "0x2489040")] private set
        {
        }
      }

      [Token(Token = "0x17000284")]
      public float DeltaTime
      {
        [Token(Token = "0x60016CA"), Address(RVA = "0x2489048", Offset = "0x2489048", VA = "0x2489048")] readonly get
        {
          return new float();
        }
        [Token(Token = "0x60016CB"), Address(RVA = "0x2489050", Offset = "0x2489050", VA = "0x2489050")] private set
        {
        }
      }

      [Token(Token = "0x17000285")]
      public bool IsHorizontal
      {
        [Token(Token = "0x60016CC"), Address(RVA = "0x2488E24", Offset = "0x2488E24", VA = "0x2488E24")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17000286")]
      public bool IsVertical
      {
        [Token(Token = "0x60016CD"), Address(RVA = "0x2489058", Offset = "0x2489058", VA = "0x2489058")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x60016CE")]
      [Address(RVA = "0x2489070", Offset = "0x2489070", VA = "0x2489070")]
      public bool IsLeft() => new bool();

      [Token(Token = "0x60016CF")]
      [Address(RVA = "0x2489080", Offset = "0x2489080", VA = "0x2489080")]
      public bool IsRight() => new bool();

      [Token(Token = "0x60016D0")]
      [Address(RVA = "0x2489090", Offset = "0x2489090", VA = "0x2489090")]
      public bool IsUp() => new bool();

      [Token(Token = "0x60016D1")]
      [Address(RVA = "0x24890A0", Offset = "0x24890A0", VA = "0x24890A0")]
      public bool isDown() => new bool();

      [Token(Token = "0x60016D2")]
      [Address(RVA = "0x2488F30", Offset = "0x2488F30", VA = "0x2488F30")]
      public OutputData(Slide.InputData begin, Slide.InputData end)
      {
      }

      [Token(Token = "0x60016D3")]
      [Address(RVA = "0x24890B0", Offset = "0x24890B0", VA = "0x24890B0", Slot = "3")]
      public override string ToString() => (string) null;
    }
  }
}
