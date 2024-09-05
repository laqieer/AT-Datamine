// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.LvUpEffectBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A6B")]
  public class LvUpEffectBase : EnhanceEffectBase
  {
    [Token(Token = "0x401000F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI prev;
    [Token(Token = "0x4010010")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text result;

    [Token(Token = "0x6016F64")]
    [Address(RVA = "0x29C2CF0", Offset = "0x29C2CF0", VA = "0x29C2CF0")]
    protected void SetLevelUpText(int beafore, int after)
    {
    }

    [Token(Token = "0x6016F65")]
    [Address(RVA = "0x29C2D68", Offset = "0x29C2D68", VA = "0x29C2D68")]
    protected void SetLevelUpText(int beafore, int after, Color color)
    {
    }

    [Token(Token = "0x6016F66")]
    [Address(RVA = "0x29C2E28", Offset = "0x29C2E28", VA = "0x29C2E28")]
    public LvUpEffectBase()
    {
    }
  }
}
