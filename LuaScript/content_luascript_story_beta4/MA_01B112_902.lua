-- このluaスクリプトは、MA_01B112_902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ランスロット、戻って来ていたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_9020002")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーの容体はどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_9020003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:悪くはない<br>良いと言えるほどではないがな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B112_9020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ランスロット★★:お前の顔を見たがっていたよ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B112_9020005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力

	--★★ケイ★★:であれば<br>見舞いにでも行ってくるといい
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B112_9020006")


	--★★ノワール★★:いいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_9020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:貴公ひとりが抜けたくらいで<br>我が国の運営が滞ることはない
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B112_9020008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ケイ★★:現に国王不在でまわっているのだからな
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B112_9020009")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ランスロット★★:ただ、実際にノワールの顔を見たら<br>聖杯城に連れて行けと言い出しかねない
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B112_9020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:マーリンのこともある<br>無理を押してでも行きがたがるだろう
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B112_9020011")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:昔から言い出したら聞かぬ男だ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B112_9020012")


	--★★ケイ★★:だが、同時に「自分は不死身だ」と言い張り<br>最後までやり遂げる男でもある
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B112_9020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:連れてくればいい
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01B112_9020014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:わかった<br>行ってくる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_9020015")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ランスロット★★:やれやれ<br>俺は止めてほしくて来たつもりだったんだがな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B112_9020016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
