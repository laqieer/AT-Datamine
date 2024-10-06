-- このluaスクリプトは、MA_01C112_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
load_image("102040020_StillImage", "content_still_10204002_image", "102040020_StillImage")
DontChangeRandomCamera(true)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage") --
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor006,"telop","narration","N","MA_01C112_091001")


	--★★テロップ★★:ランスロットはスノードンにいる、か<br>人質、ということだろうか…
	Talk(Actor006,"telop","narration","N","MA_01C112_091002")


	--★★テロップ★★:
	Talk(Actor006,"telop","narration","N","MA_01C112_091003")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.6)
wait_time(1.2)
show_image("102040020_StillImage", 0.0, 0.0, 0.0, true, false)
fadein(0.6)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:ランスロットはスノードンにいる、か<br>人質、ということだろうか…
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_090002")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME) --0.6秒
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) --0.6秒 + 0.8秒
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★トリスタン★★:でもそれって魔女が勝手に言ってることでしょ<br>信じてもいいのかな。ワナじゃないの
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01C112_090003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to Sit01_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:わからない。けど…他に手掛かりはない<br>それに、奴らは言っていた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_090004")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:１５日までにスノードンに向かわなければ<br>また学園を襲撃するって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_090005")

-- ▼直接出力
 --PlayPartVoice("ケイ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ケイ★★:ようやくここまで復興してきたというのに<br>また襲撃などあっては…！
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_090006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ルーシャス★★:今度こそ、民の心は折れるであろうな
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C112_090007")

	PlayAction(Actor004,"to Sit01_Talk")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★モルドレッド★★:連中の口車に乗ってやるしかねえってことだ<br>ったく、手のかかる最強騎士様だ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_090008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
 --PlayPartVoice("ケイ", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:ノワール<br>スノードンへ向かう準備を進めてくれ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_090009")

	change_face(Actor002,"Sad")

	--★★ケイ★★:私は残りの人員でログレスの守りを固める<br>…これ以上、民に被害を出すわけにはいかない
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_090010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_090011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102040020_StillImage", "content_still_10204002_image", "102040020_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
