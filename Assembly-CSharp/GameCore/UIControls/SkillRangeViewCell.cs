// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.SkillRangeViewCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C12")]
  [RequireComponent(typeof (Image))]
  public sealed class SkillRangeViewCell : MonoBehaviour
  {
    [Token(Token = "0x40036CE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HideInInspector]
    private Image image;
    [Token(Token = "0x40036CF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Sprite defaultImage;
    [Token(Token = "0x40036D0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Sprite inFiringRangeImage;
    [Token(Token = "0x40036D1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Sprite inEffectiveRangeImage;
    [Token(Token = "0x40036D2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Sprite inBothRangeImage;

    [Token(Token = "0x170009FF")]
    public bool InFiringRnage
    {
      [Token(Token = "0x600451E"), Address(RVA = "0x350D9D0", Offset = "0x350D9D0", VA = "0x350D9D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600451F"), Address(RVA = "0x350D9D8", Offset = "0x350D9D8", VA = "0x350D9D8")] private set
      {
      }
    }

    [Token(Token = "0x17000A00")]
    public bool InEffectiveRange
    {
      [Token(Token = "0x6004520"), Address(RVA = "0x350D9E4", Offset = "0x350D9E4", VA = "0x350D9E4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004521"), Address(RVA = "0x350D9EC", Offset = "0x350D9EC", VA = "0x350D9EC")] private set
      {
      }
    }

    [Token(Token = "0x17000A01")]
    public bool InBothRange
    {
      [Token(Token = "0x6004522"), Address(RVA = "0x350D9F8", Offset = "0x350D9F8", VA = "0x350D9F8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004523")]
    [Address(RVA = "0x350DA18", Offset = "0x350DA18", VA = "0x350DA18")]
    public void UpdateView(bool inFiring, bool inEffective)
    {
    }

    [Token(Token = "0x6004524")]
    [Address(RVA = "0x350DA74", Offset = "0x350DA74", VA = "0x350DA74")]
    public SkillRangeViewCell()
    {
    }
  }
}
