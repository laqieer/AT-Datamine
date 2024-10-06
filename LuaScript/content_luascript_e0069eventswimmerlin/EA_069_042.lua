-- このluaスクリプトは、EA_069_042.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera004 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Emy_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_sound("BGM_ADV_Invasion2")
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
prop1 = set_object("content_model_weapon_98_emy_wpn_emy_001_01_swd", "Wpn_01_Emy_001_01_swd", false)
-- ▲直接出力
-- ▼直接出力
on_parent(prop1 ,Actor006,"Loc_weapon_constrint_R",{0,0,0,0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101016","004","101016004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_2DOnly("101016","004","101016004")
	Actor005 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201017","001","201017001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0025")
-- ▲直接出力

	--★★ギネマウア★★:だいぶ奥まで来たわね
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0420002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…なんかここ、変じゃない？<br>上手く言えないけど…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0420003")


	--★★ギネヴィア★★:動物の巣穴にしてはなんていうか…<br>生きてるって感じがしないっていうか
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0420004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ギネマウア★★:…言いたいことはわかるわ<br>私にも違和感がある
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0420005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:…なんか、嫌な予感する
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0420006")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{-0.336, 0, 0.446}, 0.8)
wait_time(0.5)
voice_play("VO_101016_sp_0003_1")
-- ▲直接出力

	--★★ギネマウア★★:ギネヴィア、地面がぬかるんでいるわ<br>足元に気を付けて
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0420007")

-- ▼直接出力
DontChangeRandomCamera(true)
PlayPartVoiceDirect("ギネヴィア","0015")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:大丈夫よこれくらい<br>子供じゃないんだから――
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0420008")

-- ▼直接出力

--on_camera(Camera002)
PlayActionDirect(Actor002,"to  Std_Surp")
slidemove(Actor002,{-0.336, -0.05, 0.446}, 0.1)
turn(Actor002, 0, 95-15, 0, 0.1)
PlayPartVoiceDirect("ギネヴィア","swim_0029")
--shake_camera(Camera002, 0.3, 0.3)
shake_camera(Camera001, 0.3, 0.3)
wait_time(0.2)
slidemove(Actor002,{-0.336, 0, 0.446}, 0.1)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ひゃあっ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0421001")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
RestartRandomCamera()
setup_small_camera_start()
PlayPartVoiceDirect("ギネマウア_004","0014")
-- ▲直接出力

	--★★ギネマウア★★:もう、だから言ったのに<br>本当に人の話を聞かないんだから
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0420009")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn(Actor002, 0, 95-180, 0, 0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.1)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:う…聞いてないわけじゃないもん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0420010")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ギネマウア★★:そうかしら？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0420011")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力

	--★★ギネヴィア★★:…聞いてくれないのは、お姉ちゃんでしょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0420012")

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:え？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0420013")

-- ▼直接出力
bgm_play("BGM_ADV_Invasion2")
on_camera(RndCamera090)
shake_camera(RndCamera090, 0.5, 2.0)
se_play("SE_ADV_Emy001_Cry")
wait_time(0.2)

PlayActionDirect(Actor002,"to Wlk")
turn(Actor002, 0, 95, 0, 0.5)
wait_time(0.5)
--PlayActionDirect(Actor002,"to Std_Squareoff_Loop")
PlayActionDirect(Actor002,"to Std_Loop")

wait_time(1.5)
--RestartRandomCamera()
--setup_small_camera_start()
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor002,"Surprise")
	on_cutin(2,Actor001,"Surprise")

	--★★ギネヴィア/ギネマウア★★:！？
	Talk(Actor003,"CHRNAME_GUINEVERE_GWENHWYMAWR","speech","N","EA_069_0420015")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0028")
-- ▲直接出力
	close_cutin()

	--★★ギネヴィア★★:今のって――…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0420016")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0030")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネマウア★★:ギネヴィア、私の後ろに
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0420017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:う、うん…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_069_0420018")

-- ▼直接出力
fadeout(0, 0, 0, 0, 1.0)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001, {1.031, 0, -0.062}, 2.0)
wait_time(3.0)

CloseTalkWindow()
setup_small_camera_end()
Hide(Actor001)
Hide(Actor002)
Appear(Actor006)
Appear(Actor007)
on_cameraframe(1)

fadein(2.0)
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101011_sp_0003_2")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★2Dギネヴィア★★:…！お姉ちゃん、あれ――
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0420022")

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0023")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★2Dギネマウア★★:バルバロイ――<br>イノシシたちが怯えていた理由がわかったわね
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0420024")

	change_face(Actor005,"Sad")

	--★★2Dギネヴィア★★:あの子たち、巣穴を乗っ取られちゃったんだ
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0420025")


	--★★2Dギネヴィア★★:大切な家を奪われて、行く場所もなくて<br>どうしていいかわかんなくて
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0420026")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0023")
-- ▲直接出力

	--★★2Dギネヴィア★★:なんか…わたしたちみたい
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0420027")

	change_face(Actor004,"Sad")

	--★★2Dギネマウア★★:………
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0420028")

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
preload_sound("BGM_ADV_Invasion2")
set_object_preload("content_model_weapon_98_emy_wpn_emy_001_01_swd", "Wpn_01_Emy_001_01_swd", false)
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101016","004","101016004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101016","004","101016004")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201017","001","201017001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
