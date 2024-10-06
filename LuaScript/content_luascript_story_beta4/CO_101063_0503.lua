-- このluaスクリプトは、CO_101063_0503.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,1.0,0.5,1.0,0.2)
-- ▲直接出力
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
SkipDefaultMotion(Actor001)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor001,"to Run")
wait_time(0.3)
PlayActionDirect(Actor002,"to Run")
PlayPartVoiceDirect("男子1","0029")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:な、なんでいつも俺ばっかり！ほかにも滞納してる奴いるだろ！
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_05030002")


	--★★ノワール★★:それは言い訳になってない本を返せば済む話じゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05030003")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
se_play("SE_ADV_MA_01C900_19_Punch")
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:それができたら逃げてない…って、ぶわぅ！
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_05030004")

-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow()
setup_small_camera_start()
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Surp")
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "気合い")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")

	--★★クリスティーナ★★:クォルァアアアアアアアァ！<br>お前なあああーーーーっ！！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","N","CO_101063_05030006")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")

	--★★クリスティーナ★★:飽きずに懲りずに何度も毎回！！借りた本は必ず返すのがルールってもんだろ！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","N","CO_101063_05030007")

	close_cutin()
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("男子1","0031")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ヒ、ヒイイイイイイイイ！命だけはお助けを…
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_05030008")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:あ、あらやだ！私ったらはしたない…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05030010")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:私はただの司書よ虫だって触れやしないわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05030011")


	--★★ノワール★★:（ネコを追い払ってたけどな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101063_05030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.5)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なにか本を返せない理由でもあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05030013")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:実は…実はさ借りた本を失くしちゃったんだ…
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_05030014")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:なんですって？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05030015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ5_4")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
