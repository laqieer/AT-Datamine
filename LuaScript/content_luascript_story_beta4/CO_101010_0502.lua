-- このluaスクリプトは、CO_101010_0502.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_007)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:それで、話って？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020002")

-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:それなんだが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020003")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:あの人の…師匠の思い出の地を<br>ふたりで巡らないか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020004")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:父さん…の？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020006")


	--★★ランスロット★★:お前も今ならなんとなくわかると思うが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020007")


	--★★ランスロット★★:GSを果たすと<br>相手の記憶が流れ込んでくることがある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:「遺したい」と強く願う思い出があるとき<br>極めて稀に起こる現象として確認されるらしい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020010")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:遺したい…思い出
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020011")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★ランスロット★★:師匠は聖遺物化してしまったが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020012")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:あの人の心のなかに強く遺り<br>誰かに伝えたいと願った思い出のいくつかが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:今、俺に引き継がれている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020014")


	--★★ノワール★★:父さんの過去、か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_05020017","CO_101010_05020018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:言われてみれば…全然知らないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:だろう？<br>俺もGSするまでほとんど知らなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020021")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺たちがあの人について知っていたのは<br>リムニーナ村で見せる顔だけだったんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:昔、ちょっとだけ聞いたような気がするな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020024")

	change_face(Actor001,"Normal")

	--★★ノワール★★:父さんは口数が多いほうじゃなかったし<br>俺も幼かったからほとんど覚えてないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020025")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:団らんのときにも<br>自分の過去については語りたがらなかったな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020026")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ノワール、提案がある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020028")


	--★★ランスロット★★:ふたりで師匠の思い出の地を巡ろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020029")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:俺のなかに遺る師匠の記憶…<br>それを道しるべに
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020030")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:実際に訪れることでしか<br>知れないこともあるはずだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020031")


	--★★ランスロット★★:師匠が世界から忘れ去られてしまったからこそ<br>俺たちふたりは覚えておかなければならない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020032")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:師匠の記憶を心に刻もう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_05020035","CO_101010_05020036")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:賛成だ<br>父さんも喜ぶよ、きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020038")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺たちに知ってほしいこと<br>伝えていってほしいこともあるんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…ありがとう。決まりだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020040")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん、どうかなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020042")

	change_face(Actor001,"Normal")

	--★★ノワール★★:父さんにも知られたくない過去が<br>ひとつふたつありそうだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020043")

-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:思い出の地を全部巡るわけではないし
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020044")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺たちに伝えたかった想いが<br>遺る地だけに絞るつもりだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020045")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうか<br>それなら賛成だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020046")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ところで…これも補習か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_05020048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:そうだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020050")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力

	--★★ランスロット★★:俺とお前、ふたりで受ける…<br>『師匠学』の補習だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_05020051")

-- ▼直接出力
local trustParam = set_communication_rankup("ランスロット_コミュランク", "ランスロット_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
