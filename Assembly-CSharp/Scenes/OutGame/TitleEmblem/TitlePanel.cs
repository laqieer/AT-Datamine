// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.TitleEmblem.TitlePanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.TitleEmblem
{
  [Token(Token = "0x200335A")]
  public abstract class TitlePanel : MonoBehaviour
  {
    [Token(Token = "0x400DE69")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text preTitleText;
    [Token(Token = "0x400DE6A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text postTitleText;
    [Token(Token = "0x400DE6B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text combinationText;
    [Token(Token = "0x400DE6C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image frameOrFullSetImage;
    [Token(Token = "0x400DE6D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image textImage;
    [Token(Token = "0x400DE6E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private int defaultFontSize;

    [Token(Token = "0x17004375")]
    public int DefaultFontSize
    {
      [Token(Token = "0x60142E5"), Address(RVA = "0x1E139A0", Offset = "0x1E139A0", VA = "0x1E139A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004376")]
    public TitleSet Titles
    {
      [Token(Token = "0x60142E6"), Address(RVA = "0x1E139A8", Offset = "0x1E139A8", VA = "0x1E139A8")] get
      {
        return new TitleSet();
      }
      [Token(Token = "0x60142E7"), Address(RVA = "0x1E139BC", Offset = "0x1E139BC", VA = "0x1E139BC")] private set
      {
      }
    }

    [Token(Token = "0x60142E8")]
    [Address(RVA = "0x1E139D0", Offset = "0x1E139D0", VA = "0x1E139D0")]
    protected UniTask SetAsync(
      TitleSet titleSet,
      ITitleLoader loader,
      CancellationToken cancellationToken)
    {
      return new UniTask();
    }

    [Token(Token = "0x60142E9")]
    [Address(RVA = "0x1E13B40", Offset = "0x1E13B40", VA = "0x1E13B40")]
    private UniTask SetEachAsync(
      ITitleMasterData pre,
      ITitleMasterData post,
      ITitleMasterData frame,
      ITitleLoader loader,
      CancellationToken cancellationToken)
    {
      return new UniTask();
    }

    [Token(Token = "0x60142EA")]
    [Address(RVA = "0x1E13EE8", Offset = "0x1E13EE8", VA = "0x1E13EE8")]
    private UniTask SetFronAndBackTextAsync(
      string text,
      int frameTitleId,
      ITitleLoader loader,
      CancellationToken cancellationToken)
    {
      return new UniTask();
    }

    [Token(Token = "0x60142EB")]
    [Address(RVA = "0x1E13FE0", Offset = "0x1E13FE0", VA = "0x1E13FE0")]
    private UniTask SetTextImageAsync(
      int textImageTitleId,
      int frameTitleId,
      ITitleLoader loader,
      CancellationToken cancellationToken)
    {
      return new UniTask();
    }

    [Token(Token = "0x60142EC")]
    [Address(RVA = "0x1E14150", Offset = "0x1E14150", VA = "0x1E14150")]
    private UniTask SetFullSetAsync(
      int titleId,
      ITitleLoader loader,
      CancellationToken cancellationToken)
    {
      return new UniTask();
    }

    [Token(Token = "0x60142ED")]
    [Address(RVA = "0x1E13F58", Offset = "0x1E13F58", VA = "0x1E13F58")]
    private void ClearPreAndPostText()
    {
    }

    [Token(Token = "0x60142EE")]
    [Address(RVA = "0x1E13E64", Offset = "0x1E13E64", VA = "0x1E13E64")]
    private void ClearCombinationText()
    {
    }

    [Token(Token = "0x60142EF")]
    [Address(RVA = "0x1E13EC8", Offset = "0x1E13EC8", VA = "0x1E13EC8")]
    private void ClearTextImage()
    {
    }

    [Token(Token = "0x60142F0")]
    [Address(RVA = "0x1E13C48", Offset = "0x1E13C48", VA = "0x1E13C48")]
    private void SetText(Text text, ITitleMasterData title)
    {
    }

    [Token(Token = "0x60142F1")]
    [Address(RVA = "0x1E13ED0", Offset = "0x1E13ED0", VA = "0x1E13ED0")]
    private UniTask SetFrameOrFullSetAsync(
      int titleId,
      ITitleLoader loader,
      CancellationToken cancellationToken)
    {
      return new UniTask();
    }

    [Token(Token = "0x60142F2")]
    [Address(RVA = "0x1E141D8", Offset = "0x1E141D8", VA = "0x1E141D8")]
    private UniTask SetSpriteAsync(
      Image image,
      int titleId,
      ITitleLoader loader,
      CancellationToken cancellationToken)
    {
      return new UniTask();
    }

    [Token(Token = "0x60142F3")]
    [Address(RVA = "0x1E141A4", Offset = "0x1E141A4", VA = "0x1E141A4")]
    private void ClearSprite(Image image)
    {
    }

    [Token(Token = "0x60142F4")]
    [Address(RVA = "0x1E1434C", Offset = "0x1E1434C", VA = "0x1E1434C")]
    protected TitlePanel()
    {
    }
  }
}
