-- このluaスクリプトは、MA_01A112_54.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-115,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",60,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
BgProp = setup_prop_object(10102012)
set_pos(BgProp,{-10,0,10})
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
-- 背景移動回転スケール
local bg = get_object("BG")
set_pos(bg,{-10,0,10})

-- 固定モブ移動回転スケール
local pro = get_object("Pro_1101_45")
set_pos(pro,{-10,0,10})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115116)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:あの学園が好きです。今は
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540002")


	--★★エレイン★★:人生の『先輩』が大勢いて<br>どう生きていけばいいか、迷える時間がある
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540004")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★エレイン★★:大切な人をキズつけてしまうこともあるけれど<br>それ以上に誰かを守る力を育てることができる
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540005")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★エレイン★★:悼む心は<br>誰もが変わらない
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540006")


	--★★エレイン★★:痛めたキズは<br>次の戦いへの武器に変わる
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:ぜんぶ全部、先輩が教えてくれたように思います
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540009")

	open_select_window_tag(Actor001,"Normal","MA_01A112_540010","MA_01A112_540011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:エレインの努力だよ<br>俺はなにもできていない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_540013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:そうですよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:先輩に食らいついて離れなかった<br>私自身の努力です
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540016")

	change_face(Actor002,"Normal")

	--★★エレイン★★:だから、先輩がいてくれなきゃ<br>だめだったんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いい先輩じゃなかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_540019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エレイン★★:私が追って来た人を<br>そんなふうに言うのはやめてください
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540020")

-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:こんなにも<br>いい後輩がいるっていうのに
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540021")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
change_face(Actor002,"Normal")
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
wait_time(2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:雪が降ってきましたね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
 --PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:…あの、冷えちゃうと良くないので
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540024")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★エレイン★★:どこかで…すこしだけ休憩しませんか<br>いっしょにお祭りを抜け出して
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540025")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★エレイン★★:雪がやむまでの間だけ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A112_540027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102012)
	InitializeLoad_Preload()
	load_area_scene_preload(115116)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
