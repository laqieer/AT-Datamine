-- このluaスクリプトは、CO_101035_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:あの畑さ。学園からちょっと離れてるけど<br>毎回歩いて往復するのは大変じゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03020002")


	--★★ノワール★★:重い荷物を<br>持たなきゃならないときもあるだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03020003")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力

	--★★リリアーナ★★:このくらいは全然平気ですよ<br>ローマにいた頃からいつもやってました
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:もうちょっと街から近いところにするとか<br>荷馬車を貸してもらうとかしたらどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03020005")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_No")
SkipDefaultMotion(Actor002)
-- ▲直接出力

	--★★リリアーナ★★:他のみなさんの迷惑になっちゃいますよ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03020006")


	--★★リリアーナ★★:私なんて居候みたいなもんですし<br>荷馬車も他に使いたい方がいるはずです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03020007")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:畑にする土地をいただけただけでも<br>アーサー様には感謝しないと！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101035_03020010","CO_101035_03020011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:畑を手配してくれたのは<br>アーサーだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:はい。以前、コルベニック城にいらしたときに<br>私が育てた野菜を召し上がっていただけたようで
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03020014")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:ログレスでも作ってみないか<br>と相談を受けたんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03020016")

	change_face(Actor001,"Smile")

	--★★ノワール★★:（アーサーなりの気遣いなんだろうな、きっと）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101035_03020017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:優しいんだな、リリアーナは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03020019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:そんな！<br>私なんて全然ですよ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03020020")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:フィエナやエクセリアのほうが優しいし<br>みんなに頼りにされてます
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_03020021")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ<br>そういうことにしておくか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_03020022")

	goto Block1end

::Block1end::
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リリアーナ_ランクアップ3_3")
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
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
