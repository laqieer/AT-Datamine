// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Skill.UI.SkillListElementUISimple
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Info.Skill.UI
{
  [Token(Token = "0x200358D")]
  public class SkillListElementUISimple : MonoBehaviour
  {
    [Token(Token = "0x400E8D1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextAccessor title;
    [Token(Token = "0x400E8D2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextAccessor level;
    [Token(Token = "0x400E8D3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image levelBase;
    [Token(Token = "0x400E8D4")]
    [FieldOffset(Offset = "0x30")]
    private SkillListElementUISimple.ColorSet colorLevel;
    [Token(Token = "0x400E8D5")]
    [FieldOffset(Offset = "0x40")]
    private SkillListElementUISimple.ColorSet colorLevelBase;
    [Token(Token = "0x400E8D6")]
    [FieldOffset(Offset = "0x50")]
    private SkillListElementUISimple.ColorSet colorTitle;

    [Token(Token = "0x601507D")]
    [Address(RVA = "0x4AA8174", Offset = "0x4AA8174", VA = "0x4AA8174")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x601507E")]
    [Address(RVA = "0x4AA8190", Offset = "0x4AA8190", VA = "0x4AA8190")]
    public void SetLevel(int value)
    {
    }

    [Token(Token = "0x601507F")]
    [Address(RVA = "0x4AA81D0", Offset = "0x4AA81D0", VA = "0x4AA81D0")]
    public void SetUnlocked(bool unlocked)
    {
    }

    [Token(Token = "0x6015080")]
    [Address(RVA = "0x4AA82D0", Offset = "0x4AA82D0", VA = "0x4AA82D0")]
    public SkillListElementUISimple()
    {
    }

    [Token(Token = "0x200358E")]
    private struct ColorSet
    {
      [Token(Token = "0x170045B9")]
      public string Locked
      {
        [Token(Token = "0x6015082"), Address(RVA = "0x4AA8398", Offset = "0x4AA8398", VA = "0x4AA8398")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x6015083"), Address(RVA = "0x4AA83A0", Offset = "0x4AA83A0", VA = "0x4AA83A0")] set
        {
        }
      }

      [Token(Token = "0x170045BA")]
      public string UnLocked
      {
        [Token(Token = "0x6015084"), Address(RVA = "0x4AA83A8", Offset = "0x4AA83A8", VA = "0x4AA83A8")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x6015085"), Address(RVA = "0x4AA83B0", Offset = "0x4AA83B0", VA = "0x4AA83B0")] set
        {
        }
      }

      [Token(Token = "0x6015086")]
      [Address(RVA = "0x4AA8278", Offset = "0x4AA8278", VA = "0x4AA8278")]
      public string Get(bool unlocked) => (string) null;
    }
  }
}
