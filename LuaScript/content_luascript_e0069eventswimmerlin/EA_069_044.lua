-- このluaスクリプトは、EA_069_044.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","005","101020005","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0032")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★アーサー★★:本来なら人里までは出ないはずの獣たちが<br>なぜか巣穴を出て暴れまわっている
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440001")

	PlayAction(Actor001,"to  Std_Talk")

	--★★アーサー★★:それにこのただならぬ様子――<br>これは…何事かありそうだな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440002")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン_005","0030")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:おふたりもそれを調べに行ったのでしょうか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0440003")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0033")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アーサー★★:かもしれないな<br>ひとこと相談してくれればよいものを…
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440004")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アーサー★★:…いや、俺が頼りにしてもらえるだけの<br>甲斐性を示せていないだけか
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440005")

-- ▼直接出力
PlayPartVoiceDirect("マーリン","0037")
-- ▲直接出力

	--★★マーリン★★:…申し訳ありません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0440006")

	change_face(Actor001,"Surprise")

	--★★アーサー★★:ん？どうした、急に
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440007")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0023")
-- ▲直接出力

	--★★マーリン★★:私がおふたりの気晴らしを提案したばかりに<br>このような事態になってしまって
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0440008")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0048")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アーサー★★:なにを言う。むしろ感謝しているんだ<br>生徒の心のケアは本来、学長の務めなんだから
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440009")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★アーサー★★:お前にはいつも、助けてもらっているよ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン_005","0019")
-- ▲直接出力

	--★★マーリン★★:ですが…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0440011")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★アーサー★★:…そういえば、俺たちが孤児院を抜け出して<br>都を目指したのも、今日みたいな暑い日だったな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440012")


	--★★アーサー★★:母を喪い、父に遠ざけられるように<br>見知らぬ土地に送られ…
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440013")


	--★★アーサー★★:あの頃の俺は、どこにも<br>自分の居場所がないような気がした
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440014")

-- ▼直接出力
setup_small_camera_end(RndCamera003)
-- ▲直接出力
	PlayAction(Actor001,"to Std_Loop")

	--★★アーサー★★:焦燥感に駆られ無計画に飛び出した俺に<br>お前と義兄さんは着いてきてくれた
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:…あの頃のあなたはいつも寂しそうで<br>「ひとりにしてはいけない」――と
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0440016")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★マーリン★★:子供心に、そう思っていましたから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0440017")


	--★★アーサー★★:結局、子供の足ではそう遠くへ行くこともできず<br>志半ばで先生方に連れ戻され大目玉をくらった
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:よく覚えていますよ。連帯責任で怒られて…<br>とんだとばっちりでした
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0440020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力

	--★★アーサー★★:そうだったな<br>３人一緒に叱られてベソをかいて――
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440021")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アーサー★★:そのとき、俺はようやくわかったんだ<br>俺はひとりじゃないんだと
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440022")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力

	--★★アーサー★★:俺の大切な夏休みの思い出だな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0440023")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
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
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","005","101020005","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
