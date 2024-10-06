// Decompiled with JetBrains decompiler
// Type: Battle.Debug.BattleDebugWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Debug
{
  [Token(Token = "0x20025C9")]
  public class BattleDebugWindow
  {
    [Token(Token = "0x400A292")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Vector2Int Resolution;
    [Token(Token = "0x400A293")]
    [FieldOffset(Offset = "0x8")]
    private static GUIStyle customButtonStyle;
    [Token(Token = "0x400A294")]
    [FieldOffset(Offset = "0x10")]
    private GUIStyle customLabelStyle;
    [Token(Token = "0x400A295")]
    [FieldOffset(Offset = "0x18")]
    private Rect? titleBarRect;

    [Token(Token = "0x170031CA")]
    public static GUIStyle CustomButtonStyle
    {
      [Token(Token = "0x600E941"), Address(RVA = "0x4C48F24", Offset = "0x4C48F24", VA = "0x4C48F24")] get
      {
        return (GUIStyle) null;
      }
    }

    [Token(Token = "0x170031CB")]
    protected GUIStyle CustomLabelStyle
    {
      [Token(Token = "0x600E942"), Address(RVA = "0x4C49010", Offset = "0x4C49010", VA = "0x4C49010")] get
      {
        return (GUIStyle) null;
      }
    }

    [Token(Token = "0x170031CC")]
    protected Rect TitleBarRect
    {
      [Token(Token = "0x600E943"), Address(RVA = "0x4C490AC", Offset = "0x4C490AC", VA = "0x4C490AC")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x600E944")]
    [Address(RVA = "0x4C4919C", Offset = "0x4C4919C", VA = "0x4C4919C")]
    protected static Rect GetRect(int x, int y, int width, int height) => new Rect();

    [Token(Token = "0x600E945")]
    [Address(RVA = "0x4C4924C", Offset = "0x4C4924C", VA = "0x4C4924C")]
    protected static int GetX(int x) => new int();

    [Token(Token = "0x600E946")]
    [Address(RVA = "0x4C492A0", Offset = "0x4C492A0", VA = "0x4C492A0")]
    protected static int GetY(int y) => new int();

    [Token(Token = "0x170031CD")]
    protected virtual string WindowName
    {
      [Token(Token = "0x600E947"), Address(RVA = "0x4C492F4", Offset = "0x4C492F4", VA = "0x4C492F4", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170031CE")]
    protected virtual int WindowId
    {
      [Token(Token = "0x600E948"), Address(RVA = "0x4C492FC", Offset = "0x4C492FC", VA = "0x4C492FC", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170031CF")]
    protected virtual Rect InitRect
    {
      [Token(Token = "0x600E949"), Address(RVA = "0x4C49304", Offset = "0x4C49304", VA = "0x4C49304", Slot = "6")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x170031D0")]
    protected Rect WindowRect
    {
      [Token(Token = "0x600E94A"), Address(RVA = "0x4C49348", Offset = "0x4C49348", VA = "0x4C49348")] get
      {
        return new Rect();
      }
      [Token(Token = "0x600E94B"), Address(RVA = "0x4C49354", Offset = "0x4C49354", VA = "0x4C49354")] set
      {
      }
    }

    [Token(Token = "0x170031D1")]
    public bool IsActive
    {
      [Token(Token = "0x600E94C"), Address(RVA = "0x4C49360", Offset = "0x4C49360", VA = "0x4C49360")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E94D"), Address(RVA = "0x4C49368", Offset = "0x4C49368", VA = "0x4C49368")] private set
      {
      }
    }

    [Token(Token = "0x600E94E")]
    [Address(RVA = "0x4C49374", Offset = "0x4C49374", VA = "0x4C49374", Slot = "7")]
    public virtual void OnTriggerGUI()
    {
    }

    [Token(Token = "0x600E94F")]
    [Address(RVA = "0x4C49580", Offset = "0x4C49580", VA = "0x4C49580")]
    public void Show()
    {
    }

    [Token(Token = "0x600E950")]
    [Address(RVA = "0x4C4958C", Offset = "0x4C4958C", VA = "0x4C4958C")]
    private void WindowFunction(int windowId)
    {
    }

    [Token(Token = "0x600E951")]
    [Address(RVA = "0x4C49598", Offset = "0x4C49598", VA = "0x4C49598", Slot = "8")]
    protected virtual void ShowImpl()
    {
    }

    [Token(Token = "0x600E952")]
    [Address(RVA = "0x4C4959C", Offset = "0x4C4959C", VA = "0x4C4959C")]
    public void Hide()
    {
    }

    [Token(Token = "0x600E953")]
    [Address(RVA = "0x4C495A4", Offset = "0x4C495A4", VA = "0x4C495A4", Slot = "9")]
    protected virtual void HideImpl()
    {
    }

    [Token(Token = "0x600E954")]
    [Address(RVA = "0x4C495A8", Offset = "0x4C495A8", VA = "0x4C495A8")]
    public BattleDebugWindow()
    {
    }

    [Token(Token = "0x600E955")]
    [Address(RVA = "0x4C49600", Offset = "0x4C49600", VA = "0x4C49600")]
    static BattleDebugWindow()
    {
    }
  }
}
