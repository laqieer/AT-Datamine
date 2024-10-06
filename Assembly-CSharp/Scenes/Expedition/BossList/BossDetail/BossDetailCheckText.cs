// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossDetail.BossDetailCheckText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.BossList.BossDetail
{
  [Token(Token = "0x2002D2F")]
  public class BossDetailCheckText : MonoBehaviour
  {
    [Token(Token = "0x400C1CC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text checkText;
    [Token(Token = "0x400C1CD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image lockImage;
    [Token(Token = "0x400C1CE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image unLockImage;

    [Token(Token = "0x6011ACB")]
    [Address(RVA = "0x42AE040", Offset = "0x42AE040", VA = "0x42AE040")]
    public void SetCheckText(string inputCheckText, bool isUnlocked)
    {
    }

    [Token(Token = "0x6011ACC")]
    [Address(RVA = "0x42AE0B8", Offset = "0x42AE0B8", VA = "0x42AE0B8")]
    public BossDetailCheckText()
    {
    }
  }
}
