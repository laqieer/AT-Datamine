-- このluaスクリプトは、EA_006_045.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
turn_lookat(Actor004,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
-- ▼直接出力
load_image("104000300", "content_still_10400030_image", "104000300_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("104000320", "content_still_10400032_image", "104000320_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("102050040", "content_still_10205004_image", "102050040_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:よし！準備完了だね！<br>見て見てガレス、あたしの力作！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_006_0450002")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
setup_small_camera_start()
turn_lookat(Actor002,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.4)
ShowImageItem(104000300)
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ガレス★★:お～！<br>このピクニックシート、刺繡がかわいい～！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0450003")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
HideImageItem(104000300)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003,0.4)
set_common_look_at(Actor002,Actor003)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.2)
ShowImageItem(104000320)
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0047")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:このバスケットもお弁当がたっぷり入りそうで<br>とってもいい感じだ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0450004")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
HideImageItem(104000320)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor003,0.4)
set_common_look_at(Actor001,Actor003)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ヴォールス★★:俺の意図を正しく汲んでくれた<br>マルイルのおかげだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_006_0450005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0002")
-- ▲直接出力

	--★★クレア★★:ところで…あなた、さっきより元気ね<br>なにかあったのかしら
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_006_0450006")

	PlayAction(Actor002,"to  Std_No")

	--★★ガレス★★:…ううん。なにも！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0450007")

	change_face(Actor002,"Smile")

	--★★ガレス★★:皆…本当にありがとう！<br>後は当日、お弁当を持って出かけるだけだな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0450008")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,0.4)
set_common_look_at(Actor001,Actor002)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.6)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラグネル★★:ところで、お花見ってどこでやる予定なの？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_006_0450009")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.4)
set_common_look_at(Actor002,Actor001)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0007")
-- ▲直接出力

	--★★ガレス★★:よくぞ聞いてくれました！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0450010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:実は、前にリオネスと見回りに行ったときに<br>見つけたんだ。最高のお花見スポット！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0450011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:たくさん花が咲いて、すごく綺麗で…<br>昔、家族でお花見した場所にちょっと似てるんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0450012")

-- ▼直接出力
show_image("102050040", 0.0, 0.0, STILL_SWITCH_TIME ,true,false) 
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ほら、ここ！キャメリアードから歩いて<br>少しのところにある花畑なんだけど…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0450013")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★クレア★★:
	Talk(Actor004,"CHRNAME_CLARE","speech","L","EA_006_0450015")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.2)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor002,Actor004,0.4)
turn_lookat(Actor001,Actor004,0.4)
set_common_look_at(Actor002,Actor004)
set_common_look_at(Actor001,Actor004)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:ただ？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0450016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0034")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:…カレドニアに近いな<br>――なにもなければいいが
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_006_0450017")

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
load_image_preload("104000300", "content_still_10400030_image", "104000300_StillImage")
load_image_preload("104000320", "content_still_10400032_image", "104000320_StillImage")
load_image_preload("102050040", "content_still_10205004_image", "102050040_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
