// Decompiled with JetBrains decompiler
// Type: Direction.Subtitles.SubtitleAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Direction.Subtitles
{
  [Token(Token = "0x2001F1E")]
  public abstract class SubtitleAction
  {
    [Token(Token = "0x4008581")]
    [FieldOffset(Offset = "0x18")]
    protected ISubtitleUI UI;
    [Token(Token = "0x4008582")]
    [FieldOffset(Offset = "0x20")]
    protected SubtitleData data;
    [Token(Token = "0x4008583")]
    [FieldOffset(Offset = "0x28")]
    protected ISubtilesTextProvider text;

    [Token(Token = "0x17002669")]
    public bool IsStarted
    {
      [Token(Token = "0x600B8C8"), Address(RVA = "0x2137514", Offset = "0x2137514", VA = "0x2137514")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B8C9"), Address(RVA = "0x213751C", Offset = "0x213751C", VA = "0x213751C")] protected set
      {
      }
    }

    [Token(Token = "0x1700266A")]
    public bool IsEnded
    {
      [Token(Token = "0x600B8CA"), Address(RVA = "0x2137528", Offset = "0x2137528", VA = "0x2137528")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B8CB"), Address(RVA = "0x2137530", Offset = "0x2137530", VA = "0x2137530")] protected set
      {
      }
    }

    [Token(Token = "0x600B8CC")]
    [Address(RVA = "0x213753C", Offset = "0x213753C", VA = "0x213753C")]
    public SubtitleAction(ISubtitleUI ui)
    {
    }

    [Token(Token = "0x600B8CD")]
    [Address(RVA = "0x2137564", Offset = "0x2137564", VA = "0x2137564")]
    public void SetData(SubtitleData data, ISubtilesTextProvider textProvider)
    {
    }

    [Token(Token = "0x600B8CE")]
    [Address(RVA = "0x2137570", Offset = "0x2137570", VA = "0x2137570")]
    public void Update(float time)
    {
    }

    [Token(Token = "0x600B8CF")]
    protected abstract void OnEnter(float time);

    [Token(Token = "0x600B8D0")]
    protected abstract void OnUpdate(float time);

    [Token(Token = "0x600B8D1")]
    protected abstract void OnExit(float time);
  }
}
