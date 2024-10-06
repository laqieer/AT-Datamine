-- このluaスクリプトは、MA_01B109_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",218.6384,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10102003_anim", "10102003_StillAnim", nil, nil, nil, "Root")
-- PlayActionDirect(Actor002,"to  Std_Sad01")
set_pos(Actor003, {8.052, 0, 13.486})
set_enable_auto_lookat_all(false)
BgProp = setup_prop_object(10102013)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115117)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★ランスロット★★:俺に会いに来たのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350002")

	open_select_window_tag(Actor001,"Normal","MA_01B109_350003","MA_01B109_350004","MA_01B109_350005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まさか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350007")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:だろうな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350008")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺は<br>お前に会えるかもと思っていたがな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、俺もそういうことにしておく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:必死にさがしたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350012")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:そんなふうには見えないがな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350013")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:さがされて悪い気はしないし<br>よしとしておこうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350014")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ひとりになりたかったのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350016")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:悪かったな<br>ひとりになれそうな場所に俺がいて
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350017")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:まあ、腐れ縁というやつだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350018")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:<ruby=たそがれ>黄昏</ruby>ているだろうとは思った<br>ひとりで格好つけて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350020")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:黄昏時は終わったよ<br>もう夜だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350022")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:そーゆーことじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350023")

	change_face(Actor002,"Surprise")

	--★★ランスロット★★:そーゆーことじゃないのか…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350024")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…もしも俺が<br>人並の奇跡を望めるのなら
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350026")


	--★★ノワール★★:…？ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350027")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003, 6.542, 0, 11.597, 1.6)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:<ruby=ブルーノ>師匠</ruby>を、遺せないかと思うんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350028")


	--★★ノワール★★:父さんを…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350030")

	change_face(Actor003,"Surprise")

	--★★ガラハッド★★:………！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_350031")


	--★★ランスロット★★:聖遺物化し、もう誰も覚えていない<br>俺たちにしか遺っていない彼を
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350032")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:名とコートはお前が引き継いだ<br>剣技のすべては俺に息づいている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350033")


	--★★ランスロット★★:俺たちふたりで歴史に遺したい<br>ブルーノという存在を
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350034")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…そうしたら、弔えるかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350035")


	--★★ノワール★★:父さんに命を預けたブライアンも<br>父さんを信じ続けた母さんも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350036")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
wait_time(2.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力

	--★★ランスロット★★:…俺たちふたりなら、必ず
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350037")

-- ▼直接出力
CloseTalkWindow()
fadeout(0, 0, 0, 0, 0.5)
wait_time(0.5)
	stillAnime.SetActive(true)
hide_image(0)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
-- ▲直接出力

	--★★ランスロット★★:亡くなった人のぶんまで生きて<br>忘れられた人のぶんまで戦って
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350038")

	change_face(Actor001,"Normal")

	--★★ノワール★★:その軌跡を人々の思い出に<br>遺すことができれば
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_350039")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:誰にも忘れられはしない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_350040")

-- ▼直接出力
	CloseTalkWindow()
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
fadeout(0, 0, 0, 0, BLACK_WHITE_TIME)
	wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
stillAnime.SetActive(false)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_ui_effect_preload("content_still_10102003_anim", "10102003_StillAnim", nil, nil, nil, "Root")
setup_prop_object_preload(10102013)
	InitializeLoad_Preload()
	load_area_scene_preload(115117)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
