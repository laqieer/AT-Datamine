-- このluaスクリプトは、EA_001_034.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_04","110111_04_h")
Include("content_adv_advsmall_110111_04","Template110111_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_002)
	InitializeTemplateRandomCamera110111_04()
	InitializeTemplate110111_04()
-- ▼直接出力
set_pos(Actor002,{-4.48, 0, -4.14,   325})
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Sad")
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Sad")
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003, {-4.02, 0, -3.406,   325})
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115114)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル","肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:ドンマイ<br>プランBで行こ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034002")

-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:プランB？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_034003")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to Finger")
-- ▼直接出力
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力

	--★★ラグネル★★:<ruby=ぬいぐるみ>お魚さん</ruby>が燃えちゃったんなら<br>また作ればいーことでしょ？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ","挨拶")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ローラ★★:材料もほとんど燃えちゃったの…
	Talk(Actor003,"CHRNAME_LOLA","speech","L","EA_001_034005")

	change_face(Actor002,"Sad")

	--★★ノワール★★:…服は？ローラが作ってた…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_034006")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ","落胆")
-- ▲直接出力

	--★★ローラ★★:跡形もなくなって…
	Talk(Actor003,"CHRNAME_LOLA","speech","L","EA_001_034007")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル","挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラグネル★★:燃え残ったのは？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ローラ★★:糸と、針と…布がほんの少しだけ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","EA_001_034009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:プランBはムリかぁー
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034010")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Surprise")

	--★★ラグネル★★:…な、なんとかするしかないよ<br>あたし故郷の港町じゃバシバシ売れてたんだから
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:ぬいぐるみを？ <br>いまだって苦戦してるのに、どうやって…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_034013")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0026")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:この笑顔で
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Surprise")

	--★★ノワール★★:その笑顔でかあ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_034017")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力

	--★★ラグネル★★:あはは、最初は日銭稼ぎのためにね<br>布もろくなヤツないからさ…かき集めて
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034018")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル","肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:子供の浅知恵で通りすがりの人に<br>「なんでも作ってあげる～」なんて売り込んだ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034019")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")

	--★★ラグネル★★:糸と針さえあれば縫えるし<br>やろうと思えば──
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034020")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.2)
change_face(Actor001,"Usual")
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(3.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Finger")
change_face(Actor001,"Surprise")
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
change_face(Actor001,"Smile")
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:ら、ラグネル…？
	Talk(Actor003,"CHRNAME_LOLA","speech","L","EA_001_034022")

-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラグネル","喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:………あははははっ！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:笑ってる場合じゃないぞ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_034024")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:沈んでるより良いでしょ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034025")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to Finger")
-- ▼直接出力
PlayPartVoice("ラグネル","肯定2")
-- ▲直接出力

	--★★ラグネル★★:プランCで行こう！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_034027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115114)
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
