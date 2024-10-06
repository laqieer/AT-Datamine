-- このluaスクリプトは、PT6_01A_01_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
lookat_delay_weight(Actor002, {1.0, 0.02, 0.4, 0} ,1.0)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:ここの食事は<br>なにを食べても美味しいですね…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010006")


	--★★リリアーナ★★:どれも食材が新鮮だし<br>調理方法にもこだわりが感じられます
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:うん。俺も初めてここの料理を食べたとき<br>街で店を開けるレベルだと思ったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_01_0010008")

-- ▼直接出力
PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:私もこのくらい作れるようになるかなあ？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…作る？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_01_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力

	--★★リリアーナ★★:少し前から、コック長さんやガレスさんに<br>料理を教わりはじめたんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010011")


	--★★リリアーナ★★:ここのところ<br>大きな戦いや遠征が続いてるじゃないですか
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★リリアーナ★★:戦いでお役に立てないぶん<br>こういったところで頑張ろうって思って
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT6_01A_01_0010014","PT6_01A_01_0010015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:リリアーナの野菜を使った料理が食べられるなら<br>きっとみんな喜ぶよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_01_0010017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:そう言ってもらえると嬉しいです<br>みなさんの期待に沿えるよう、頑張ります…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010018")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:本当は自慢のトマトを使った料理を<br>ご馳走したいんですけど
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:今は時期が良くなくて…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010020")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ト、トマト…<br>そ、そうか、それは残念だな…ハハハ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_01_0010021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リリアーナは<br>戦いでもじゅうぶん活躍できてると思うけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_01_0010023")

-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:ありがとうございます<br>でも、自分の能力は自分が一番わかってますから
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:できることで<br>みなさんのお役に立ていかないと
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010025")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:ノワールさんの食事…<br>野菜が少なくないですか？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★リリアーナ★★:ローマ軍との戦いの前に倒れちゃったら大変です<br>バランスの良い食事を心がけてくださいね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:私のマスターはお酒のつまみといって<br>しょっぱいものばかり食べてて
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010029")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★リリアーナ★★:体調を崩しちゃうことが多いんです<br>困ったものです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT6_01A_01_0010030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか…<br>気を付けるよ、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_01_0010031")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
