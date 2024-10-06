-- このluaスクリプトは、CO_101030_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_006)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("市民中年_男2","0030")
-- ▲直接出力

	--★★市民（中年男）★★:ああっ！<br>エレイン様、大変なんです！！
	Talk(Actor003,"NPCNAME_0272","speech","L","CO_101030_08020002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:どうしたんですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08020003")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "悲しみ")
-- ▲直接出力

	--★★市民（中年男）★★:少し前からトビーくんの姿が見えないんです
	Talk(Actor003,"NPCNAME_0272","speech","L","CO_101030_08020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★市民（中年男）★★:トビーくんらしき姿が村を出ていくところを<br>見たという者もおりまして…どうしましょう！？
	Talk(Actor003,"NPCNAME_0272","speech","L","CO_101030_08020005")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:まだ目が完全に見えるようになったわけじゃ<br>ないんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08020006")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "落胆")
-- ▲直接出力

	--★★市民（中年男）★★:本人は<br>ずいぶん良くなったと口にしていましたが
	Talk(Actor003,"NPCNAME_0272","speech","L","CO_101030_08020007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★市民（中年男）★★:まだ<br>ひとりで歩けるような状態ではないはずです
	Talk(Actor003,"NPCNAME_0272","speech","L","CO_101030_08020008")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.9, 0.6} , 1)
 keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)                    
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:心配だ<br>さがしにいこう、エレイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08020009")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_エレイン_ランクアップ8_3")
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
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
