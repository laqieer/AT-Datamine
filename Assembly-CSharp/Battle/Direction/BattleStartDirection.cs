// Decompiled with JetBrains decompiler
// Type: Battle.Direction.BattleStartDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.Direction
{
  [Token(Token = "0x20025C0")]
  public class BattleStartDirection : MonoBehaviour
  {
    [Token(Token = "0x400A261")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController controller;
    [Token(Token = "0x400A262")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400A263")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject SubTargetObj;
    [Token(Token = "0x400A264")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text victoryText;
    [Token(Token = "0x400A265")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text defeatText;
    [Token(Token = "0x400A266")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text subTargetPrimaryText;
    [Token(Token = "0x400A267")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text subTargetSecondaryText;
    [Token(Token = "0x400A268")]
    [FieldOffset(Offset = "0x50")]
    private string clearText;
    [Token(Token = "0x400A269")]
    [FieldOffset(Offset = "0x58")]
    private string failText;

    [Token(Token = "0x170031C0")]
    public bool IsInitialized
    {
      [Token(Token = "0x600E90E"), Address(RVA = "0x4C469E8", Offset = "0x4C469E8", VA = "0x4C469E8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170031C1")]
    public bool IsPlaying
    {
      [Token(Token = "0x600E90F"), Address(RVA = "0x4C46A04", Offset = "0x4C46A04", VA = "0x4C46A04")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E910")]
    [Address(RVA = "0x4C46A20", Offset = "0x4C46A20", VA = "0x4C46A20")]
    public void Awake()
    {
    }

    [Token(Token = "0x600E911")]
    [Address(RVA = "0x4C46A70", Offset = "0x4C46A70", VA = "0x4C46A70")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E912")]
    [Address(RVA = "0x4C46B10", Offset = "0x4C46B10", VA = "0x4C46B10")]
    public void Release()
    {
    }

    [Token(Token = "0x600E913")]
    [Address(RVA = "0x4C46B2C", Offset = "0x4C46B2C", VA = "0x4C46B2C")]
    public void Abort()
    {
    }

    [Token(Token = "0x600E914")]
    [Address(RVA = "0x4C46B80", Offset = "0x4C46B80", VA = "0x4C46B80")]
    public void Display()
    {
    }

    [Token(Token = "0x600E915")]
    [Address(RVA = "0x4C46A24", Offset = "0x4C46A24", VA = "0x4C46A24")]
    public void Hide()
    {
    }

    [Token(Token = "0x600E916")]
    [Address(RVA = "0x4C46BCC", Offset = "0x4C46BCC", VA = "0x4C46BCC")]
    public void SetText(int questID, int clearId, int failId)
    {
    }

    [Token(Token = "0x600E917")]
    [Address(RVA = "0x4C46E8C", Offset = "0x4C46E8C", VA = "0x4C46E8C")]
    public void Play()
    {
    }

    [Token(Token = "0x600E918")]
    [Address(RVA = "0x4C46F7C", Offset = "0x4C46F7C", VA = "0x4C46F7C")]
    public BattleStartDirection()
    {
    }
  }
}
