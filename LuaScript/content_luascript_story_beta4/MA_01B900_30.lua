-- このluaスクリプトは、MA_01B900_30.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	Camera003 = SetTemplate("Actor003",86.229,CharaPos110191_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_001)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:ニニアンの娘であるディナタンのみだった<br>世界を守るためディナタンを犠牲にすべきか否か
	Talk(Actor004,"telop","narration","N","MA_01B900_301001")


	--★★テロップ★★:選択を迫られるノワールの前でフィエナは<br>自分が妖精の代わりとなれると告げるのだった
	Talk(Actor004,"telop","narration","N","MA_01B900_301002")


	--★★テロップ★★:
	Talk(Actor004,"telop","narration","N","MA_01B900_301003")


	--★★テロップ★★:
	Talk(Actor004,"telop","narration","N","MA_01B900_301004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:誰も褒めてくんねえ
	Talk(Actor004,"telop","narration","N","MA_01B900_301005")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:誰も褒めてくんねえ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01B900_300002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:バレりゃそれこそ咎人扱い<br>あんたらは『妖精殺し』の後追いになる
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01B900_300003")


	--★★ガウェイン★★:王家の穢れを秘密にしたまま<br>バルバロイの王を討って…
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01B900_300005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガウェイン★★:この地の穢れをフッ飛ばして聖域を得る<br>最強騎士の存在を引き換えに
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01B900_300007")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_300009")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:俺がアーサー様を好きなのはさ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01B900_300011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:生徒といっぱい笑ってくれっからなんだよ<br>いっしょにいるだけで楽しくなる
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01B900_300012")

	change_face(Actor003,"Sad")

	--★★ガウェイン★★:学園中、笑顔でいさせるために<br>アーサー様はその道を選んだんだよな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01B900_300013")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:アーサー様を頼む
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01B900_300014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B900_300015","MA_01B900_300016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Normal")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
play_head_motion(Actor001,"Nod",0.3,1.0,false)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
play_head_motion(Actor003,"Nod",0.3,1.0,false)
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
play_head_motion(Actor002,"Nod",0.3,1.0,false)
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
	goto Block1end

::Block1end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
