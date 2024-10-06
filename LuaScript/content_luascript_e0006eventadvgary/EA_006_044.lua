-- このluaスクリプトは、EA_006_044.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_01","112011_01_h")
Include("content_adv_advsmall_112011_01","Template112011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_006)
	Camera004 = SetTemplate("Actor005",nil,CharaPos112011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_007)
	InitializeTemplateRandomCamera112011_01()
	InitializeTemplate112011_01()
-- ▼直接出力
load_image("201010700", "content_still_20101070_image", "201010700_StillImage")
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
turn_lookat(Actor003,Actor001,0)
turn_lookat(Actor005,Actor001,0)
turn_chara(Actor001,204,0)
set_pos(Actor002,{5.44, 0.074, 6.64})
set_pos(Actor005,{2.08, 0.074, 8.55})
set_pos(Actor003,{-0.52, 0.074, 5.94})
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
Hide(Actor005)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
load_image("201010810", "content_still_20101081_image", "201010810_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("201010820", "content_still_20101082_image", "201010820_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112011)
	Actor001 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101013","001","101013001")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.8)
setup_small_camera_start(Camera001)
wait_time(2.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","simple","N","EA_006_0441001")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
wait_time(0.2)
hide_image(0.0)
wait_time(0.1)
show_image("201010810", 0.0, 0.0, 0.8,true,false)
wait_time(0.6)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★女子生徒A★★:
	Talk(Actor003,"NPCNAME_0146","simple","N","EA_006_0441002")


	--★★男子生徒A★★:
	Talk(Actor005,"NPCNAME_0151","simple","N","EA_006_0441003")


	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","simple","N","EA_006_0441004")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
wait_time(0.1)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(0.8)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","simple","N","EA_006_0441005")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
wait_time(0.2)
hide_image(0.0)
wait_time(0.1)
show_image("201010820", 0.0, 0.0, 0.8,true,false)
wait_time(0.6)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","simple","N","EA_006_0441006")


	--★★男子生徒Ｂ★★:
	Talk(Actor007,"NPCNAME_0153","simple","N","EA_006_0441007")


	--★★女子生徒Ｂ★★:
	Talk(Actor006,"NPCNAME_0147","simple","N","EA_006_0441008")


	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","simple","N","EA_006_0441009")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
wait_time(1.6)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガレス★★:………
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440003")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor002)
wait_time(0.8)
setup_small_camera_start()
wait_time(0.4)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{3.602, 0.074, 3.609},2.0)
wait_time(2.0)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(2.2)
setup_small_camera_end()
setup_small_camera_start(Camera002)
wait_time(1.0)
-- ▲直接出力

	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0440005")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera002)
setup_small_camera_end(Camera001)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,1.0)
wait_time(1.0)
PlayActionDirect(Actor001,"to Std_Loop")
set_enable_auto_lookat(Actor001,true)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガレス★★:ランスロット…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:俺を探していたんだろう<br>なにか用か
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0440007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:うん…お弁当の試食をしてほしくて<br>でももう冷めちゃったから
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440008")

	change_face(Actor001,"Sad")

	--★★ガレス★★:………
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440009")

	change_face(Actor001,"Normal")

	--★★ガレス★★:…難しいよな～、皆に認められるのは<br>そんなの当たり前だって分かってるのに
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440010")


	--★★ガレス★★:皆が円卓の騎士として積み重ねてきたのと<br>同じだけの信頼をすぐに得られるわけない
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440011")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガレス★★:わかってるんだけど、でも…<br>でも、ちょっとだけさみしくて
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:ガレス…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0440013")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor003)
Appear(Actor005)
wait_time(0.2)
setup_small_camera_start()
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{1.362, 0.074, 3.891},2.0)
wait_time(2.0)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.6)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,{2.08, 0.074, 4.5},2.0)
wait_time(2.0)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(2.2)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("女子2","0002")
-- ▲直接出力

	--★★女子生徒A★★:…あの、ガレスさん
	Talk(Actor003,"NPCNAME_0146","speech","N","EA_006_0440015")

	change_face(Actor001,"Normal")

	--★★ガレス★★:ん？
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440016")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor003,0.8)
wait_time(0.8)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")

	--★★女子生徒A★★:その――ごめんなさい
	Talk(Actor003,"NPCNAME_0146","speech","N","EA_006_0440017")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ガレス★★:え！？<br>ど、どうしたんだ、いきなり…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440018")


	--★★女子生徒A★★:私たち、やっかんでたの<br>見習いとはいえガレスがいきなり円卓だなんて
	Talk(Actor003,"NPCNAME_0146","speech","N","EA_006_0440019")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("男子1","0034")
-- ▲直接出力

	--★★男子生徒A★★:円卓の騎士ってのは皆の憧れでさ…<br>そう簡単になれるものじゃないから
	Talk(Actor005,"NPCNAME_0151","speech","N","EA_006_0440020")


	--★★男子生徒A★★:それで…どうせガウェインの妹だから<br>えこひいきでもされてるんじゃないかって
	Talk(Actor005,"NPCNAME_0151","speech","N","EA_006_0440021")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("男子1","0021")
-- ▲直接出力

	--★★男子生徒A★★:だから花見とか、変なこと言い出しても<br>許されるんじゃないかって
	Talk(Actor005,"NPCNAME_0151","speech","N","EA_006_0440022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★男子生徒A★★:けど…ガウェインに言われたんだ
	Talk(Actor005,"NPCNAME_0151","speech","N","EA_006_0440023")

-- ▼直接出力
CloseTalkWindow()
show_image("201010700", 0.0, 0.0, 0.8,true,false)
-- ▲直接出力
-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_1")
-- ▲直接出力

	--★★ガウェイン★★:あいつはちゃんと結果出してるだろ<br>騎士として、皆を守る為に戦ってる
	Talk(Actor004,"CHRNAME_GAWAIN","simple","N","EA_006_0440025")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ガウェイン★★:それなのにお前らは陰でコソコソ悪口か
	Talk(Actor004,"CHRNAME_GAWAIN","simple","N","EA_006_0440026")


	--★★ガウェイン★★:
	Talk(Actor004,"CHRNAME_GAWAIN","simple","N","EA_006_0440027")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
-- ▲直接出力
-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力

	--★★ガレス★★:兄さんが、そんなことを…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440029")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…家族想いの、良い兄だな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0440030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★女子生徒A★★:本当は、私たちもわかってた<br>ガレスががんばってることくらい
	Talk(Actor003,"NPCNAME_0146","speech","N","EA_006_0440031")


	--★★女子生徒A★★:円卓の騎士の名に恥じない結果を出したから<br>アーサー様に認められてるってことも
	Talk(Actor003,"NPCNAME_0146","speech","N","EA_006_0440032")

	PlayAction(Actor003,"to  Std_No")

	--★★女子生徒A★★:だからこそ、くやしくて――<br>…本当に、ごめんなさい
	Talk(Actor003,"NPCNAME_0146","speech","N","EA_006_0440033")

	change_face(Actor001,"Laugh")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440034")

	change_face(Actor001,"Surprise")

	--★★ガレス★★:――そうだ！皆にお願いがあるんだ
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440035")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("女子2","0028")
-- ▲直接出力

	--★★女子生徒A★★:お願い…？
	Talk(Actor003,"NPCNAME_0146","speech","N","EA_006_0440036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0007")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガレス★★:一緒にお弁当の試食――してくれないか～♪
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0440037")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010700", "content_still_20101070_image", "201010700_StillImage")
load_image_preload("201010810", "content_still_20101081_image", "201010810_StillImage")
load_image_preload("201010820", "content_still_20101082_image", "201010820_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112011)
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101013","001","101013001")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
