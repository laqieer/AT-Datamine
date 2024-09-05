// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.UIMarqueeText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C15")]
  public class UIMarqueeText : MonoBehaviour
  {
    [Token(Token = "0x40036DA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text marqueeText;
    [Token(Token = "0x40036DC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITweener.PlayMethod easing;
    [Token(Token = "0x40036DD")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private UIMarqueeText.Type marqueeType;
    [Token(Token = "0x40036DE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private float velocity;
    [Token(Token = "0x40036DF")]
    [FieldOffset(Offset = "0x34")]
    public float MarginLeft;
    [Token(Token = "0x40036E0")]
    [FieldOffset(Offset = "0x38")]
    public float MarginRight;
    [Token(Token = "0x40036E1")]
    [FieldOffset(Offset = "0x40")]
    private UIMarqueeText.Tweener tweener;
    [Token(Token = "0x40036E2")]
    [FieldOffset(Offset = "0x48")]
    private float distance;

    [Token(Token = "0x17000A02")]
    public Text MarqueeText
    {
      [Token(Token = "0x600452A"), Address(RVA = "0x350DB88", Offset = "0x350DB88", VA = "0x350DB88")] get
      {
        return (Text) null;
      }
      [Token(Token = "0x600452B"), Address(RVA = "0x350DB90", Offset = "0x350DB90", VA = "0x350DB90")] set
      {
      }
    }

    [Token(Token = "0x17000A03")]
    public UITweener.PlayMethod Easing
    {
      [Token(Token = "0x600452C"), Address(RVA = "0x350DB98", Offset = "0x350DB98", VA = "0x350DB98")] get
      {
        return new UITweener.PlayMethod();
      }
      [Token(Token = "0x600452D"), Address(RVA = "0x350DBA0", Offset = "0x350DBA0", VA = "0x350DBA0")] set
      {
      }
    }

    [Token(Token = "0x17000A04")]
    public UIMarqueeText.Type MarqueeType
    {
      [Token(Token = "0x600452E"), Address(RVA = "0x350DC24", Offset = "0x350DC24", VA = "0x350DC24")] get
      {
        return new UIMarqueeText.Type();
      }
      [Token(Token = "0x600452F"), Address(RVA = "0x350DC2C", Offset = "0x350DC2C", VA = "0x350DC2C")] set
      {
      }
    }

    [Token(Token = "0x17000A05")]
    public float Velocity
    {
      [Token(Token = "0x6004530"), Address(RVA = "0x350DCD0", Offset = "0x350DCD0", VA = "0x350DCD0")] get
      {
        return new float();
      }
      [Token(Token = "0x6004531"), Address(RVA = "0x350DCD8", Offset = "0x350DCD8", VA = "0x350DCD8")] set
      {
      }
    }

    [Token(Token = "0x6004532")]
    [Address(RVA = "0x350DDB0", Offset = "0x350DDB0", VA = "0x350DDB0")]
    public void StartMarquee()
    {
    }

    [Token(Token = "0x6004533")]
    [Address(RVA = "0x350DFC4", Offset = "0x350DFC4", VA = "0x350DFC4")]
    public void StopMarquee()
    {
    }

    [Token(Token = "0x6004534")]
    [Address(RVA = "0x350DFE4", Offset = "0x350DFE4", VA = "0x350DFE4")]
    public void ResumeMarquee()
    {
    }

    [Token(Token = "0x6004535")]
    [Address(RVA = "0x350E004", Offset = "0x350E004", VA = "0x350E004")]
    public void SetFitSize()
    {
    }

    [Token(Token = "0x6004536")]
    [Address(RVA = "0x350DF40", Offset = "0x350DF40", VA = "0x350DF40")]
    public void UpdateMarquee(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6004537")]
    [Address(RVA = "0x350E134", Offset = "0x350E134", VA = "0x350E134")]
    private void Start()
    {
    }

    [Token(Token = "0x6004538")]
    [Address(RVA = "0x350E32C", Offset = "0x350E32C", VA = "0x350E32C")]
    public UIMarqueeText()
    {
    }

    [Token(Token = "0x2000C16")]
    private class Tweener : UITweener
    {
      [Token(Token = "0x40036E3")]
      [FieldOffset(Offset = "0x68")]
      public UIMarqueeText.Tweener.UpdateDelegate OnTweenerUpdate;

      [Token(Token = "0x6004539")]
      [Address(RVA = "0x350E33C", Offset = "0x350E33C", VA = "0x350E33C", Slot = "8")]
      protected override void OnUpdate(float factor, bool isFinished)
      {
      }

      [Token(Token = "0x600453A")]
      [Address(RVA = "0x350E364", Offset = "0x350E364", VA = "0x350E364")]
      public Tweener()
      {
      }

      [Token(Token = "0x2000C17")]
      public delegate void UpdateDelegate(float factor, bool isFinished);
    }

    [Token(Token = "0x2000C18")]
    public enum Type
    {
      [Token(Token = "0x40036E5")] Once,
      [Token(Token = "0x40036E6")] PingPong,
    }
  }
}
